'// note: form autoscalemode is set to DPI
'// form font is set to Segoe UI, 10 pt.
'// Devexpress is 
Imports DevExpress.Data
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Tile
Imports DevExpress.XtraGrid.Views.Tile.ViewInfo

Public Class frmSkinUtilities

#Region "Variables and Classes"
    '// skin related
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSkinUtilities))
    Dim commonSkins As New DevExpress.Skins.CommonSkins
    Dim ribbonSkins As New DevExpress.Skins.RibbonSkins
    Dim dicSkins As New Dictionary(Of String, SkinStyler)           'Just convenience, so I can manage reskinning easily

    '// scaling related
    Dim windowsScaleFactor As SizeF = New SizeF(1F, 1F)             'The scale factor [to deal with HDPI screens]
    Dim btnImageScaleFactor As SizeF = New SizeF(0.85, 0.85)        'The scale factor applied to button images
    Dim currentScaleFactor As Single = 1
    Dim desiredScaleFactor As Single = 1
    Dim AppBasefont As Font = Me.Font
    Dim dxScaler As DXScaler

    '// used for bound and unbound data management
    Dim data As Dictionary(Of String, MusicItem)
    Dim shadowList As String()

    Dim WithEvents tileScrollBar As DevExpress.XtraGrid.Scrolling.VCrkScrollBar 'The grid/TileView scrollbar
    
    Class SkinStyler
        Property IsImage As Boolean
        Property Skins As Object
        Property ElementName As String
        Property ImageIndex As Integer
    End Class

#End Region
   
#Region "Startup and Initialization"

    '// Could be Used to set Font
    Public Sub New()
        '// set all devexpress fonts to specific font, before initialization
        'DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Segoe UI", 10)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.              
    End Sub

    '// used to grab the windows scalefactor applied to pretty much everything, except the Naughty GridControl
    Protected Overrides Sub ScaleControl(factor As SizeF, specified As BoundsSpecified)
        MyBase.ScaleControl(factor, specified)
        Debug.Print("Scale Factor Set:" & factor.Height)
        'Record the running scale factor used
        Me.windowsScaleFactor = New SizeF(Me.windowsScaleFactor.Width * factor.Width, Me.windowsScaleFactor.Height * factor.Height)
        'RescaleTiles
    End Sub

    '// initial Skin Setup
    Private Sub frmSkinUtilities_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetModeDPIAware
        '// set afterwards (at cost of extra refresh, but form font is now set
        DevExpress.Utils.AppearanceObject.DefaultFont = Me.Font        '// set to form font
        SetSkinStylingOverrides
        AppBasefont = DevExpress.Utils.AppearanceObject.DefaultFont
        dxScaler = New DXScaler(Me)
        tileScrollBar = TileView1.VScrollBar            '// uses MyTileView, otherwise have to peek inside the Grid or the TileView
        GetInitialDataset(false)
    End Sub

    '// a central place to setup skinning overrides.
    Private Sub SetSkinStylingOverrides
        dicSkins.Add(PanelTop.Name, New SkinStyler With {.IsImage = "True",
                                  .Skins = commonSkins, .ElementName = "Button", .ImageIndex = 0})
        dicSkins.Add(PanelLeftHeader.Name, New SkinStyler With {.IsImage = "True",
                                  .Skins = commonSkins, .ElementName = "Button", .ImageIndex = 1})
        dicSkins.Add(PanelRightHeader.Name, New SkinStyler With {.IsImage = "True",
                                  .Skins = commonSkins, .ElementName = "Button", .ImageIndex = 1})
        dicSkins.Add(PanelCenterHeader.Name, New SkinStyler With {.IsImage = "True",
                                  .Skins = commonSkins, .ElementName = "Button", .ImageIndex = 1})
        dicSkins.Add(PanelLeftXtraHeader.Name, New SkinStyler With {.IsImage = "True",
                                  .Skins = commonSkins, .ElementName = "Button", .ImageIndex = 4})
        dicSkins.Add(TileView1.Name, New SkinStyler With {.IsImage = "True",
                                  .Skins = commonSkins, .ElementName = "HighlightedItem", .ImageIndex = 0})
        '// use this tag to flag buttons where we want to rescale the images 
        ButtonLPH_L.Tag = "UsePadding"
        ButtonLPH_R.Tag = "UsePadding"
        TileView1.Appearance.ItemNormal.TextOptions.Trimming=Trimming.EllipsisCharacter
        TileView1.Appearance.ItemNormal.TextOptions.WordWrap= WordWrap.NoWrap
                
        'TileView1.Appearance.ItemFocused.BorderColor = Color.FromArgb(164, 192, 244)
        'TileView1.BorderStyle=DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
    End Sub

#End Region

#Region "Panel Painting and Button Resizing"

    '// demonstrating overriding paint method and using a skin image 
    Private Sub PanelBackGround_Paint(sender As Object, e As PaintEventArgs) Handles PanelTop.Paint, PanelLeftHeader.Paint, PanelCenterHeader.Paint, PanelRightHeader.Paint, PanelLeftXtraHeader.Paint
        Dim skinStyler As SkinStyler = dicSkins(sender.Name)
        e.Graphics.DrawImage(DrawButtonSkinGraphic(dxScaler.activeLookAndFeel, sender.Bounds, skinStyler.Skins, skinStyler.ElementName, skinStyler.ImageIndex), 0, 0)
    End Sub

    '// adjust size of button image based on the button Padding.
    '// this method is connected to Button SizeChanged Events 
    Private Sub Button_SizeChanged(sender As Object, e As EventArgs)
        Dim btnCtl = sender
        btnCtl.Width = btnCtl.Height
        btnCtl.Image = RescaleImageByPadding(resources.GetObject(btnCtl.Name & ".Image"),
                                            btnCtl.Size, btnCtl.Padding)
    End Sub

    '// not used, but an alternate approach to scaling button images using a scalingfactor
    Private Sub Button_SizeChangedByFactor(sender As Object, e As EventArgs)
        Dim btnCtl = sender
        btnCtl.Width = btnCtl.Height
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        'If resources.GetObject(btnCtl.Name & ".Image") Is Nothing Then Exit Sub
        btnCtl.Image = RescaleImageByScaleFactor(resources.GetObject(btnCtl.Name & ".Image"),
                                                                     btnCtl.Size, btnImageScaleFactor)

    End Sub

    '// when the Grid is resized, change the TileViewItem Size
    Private Sub Grid1_SizeChanged(sender As Object, e As EventArgs) Handles Grid1.SizeChanged
        Dim view As MyTileView = sender.DefaultView
        view.SetHScaledTileViewItemSize(PanelLeftXtraHeader.Height)
    End Sub

    '// when the scrollbar is visibly changed, recalc the TileViewItem Size
    Private Sub tileScrollBar_VisibleChanged(sender As Object, e As EventArgs) Handles tileScrollBar.VisibleChanged
        Dim grid As MyGridControl = tileScrollBar.Parent
        Dim view As MyTileView = grid.DefaultView
        view.SetHScaledTileViewItemSize(PanelLeftXtraHeader.Height)

    End Sub

#End Region

#Region "Main Demo Button Methods"

    '// set all DevExpress fonts to specific size or auto-size
    Private Sub ButtonResizeFonts_Click(sender As Object, e As EventArgs) Handles ButtonResizeFonts.Click
        Dim s As String = ComboFontSize.SelectedItem
        If s = "Auto" Or s = "" Then
            dxScaler.ScaleFonts(Me, appBaseFont, currentScaleFactor)
        Else
            dxScaler.ScaleFonts(Me, appBaseFont, (s / appBaseFont.Size))
        End If
    End Sub

    '// Scale Form by a factor
    Private Sub ButtonScaleForm_Click(sender As Object, e As EventArgs) Handles ButtonScaleForm.Click
        Dim s As String = ComboScaleForm.SelectedItem
        If s > 0 Then
            currentScaleFactor = dxScaler.ScaleForm(Me, s, currentScaleFactor)
        End If
    End Sub

    '// Create resizing handlers for relevant buttons
    Private Sub ButtonResizeBtns_Click(sender As Object, e As EventArgs) Handles ButtonResizeBtns.Click
        dxScaler.SetButtonSizeChangedHandlers(Me, AddressOf Button_SizeChanged)
    End Sub

    Private Sub ButtonFontMetrics_Click(sender As Object, e As EventArgs) Handles ButtonFontMetrics.Click
        Debug.Print("Font Size:" & LabelLPH_C.Font.SizeInPoints)
        Debug.Print("Ctl Size:" & LabelLPH_C.Height)
        Debug.Print("Line Spacing:" & LabelLPH_C.Font.GetHeight)
        Debug.Print("em-height:" & LabelLPH_C.Font.FontFamily.GetEmHeight(LabelLPH_C.Font.Style))
        Debug.Print("DPIY:" & DevExpress.XtraBars.DPISettings.DpiY)
        Debug.Print("ScaleFactor" & currentScaleFactor)
        Debug.Print("GridScaleFactor:" & Grid1.ScaleFactor.Width)
    End Sub

    Private Sub ButtonRPH_L_Click(sender As Object, e As EventArgs) Handles ButtonRPH_L.Click
        DoScaling(-0.25)
    End Sub

    Private Sub DoScaling(ScaleChange As Single)
        Debug.Print("================START SCALING=================")
        'Debug.Print("Current Desired/Current [{0},{1}]", desiredScaleFactor, currentScaleFactor)
        'Debug.Print("Current Form x,y & Font Size[{0},{1} : {2}]", Me.Width, Me.Height, DevExpress.Utils.AppearanceObject.DefaultFont.Size)
        desiredScaleFactor = desiredScaleFactor + ScaleChange
        If desiredScaleFactor < 0.5 Then desiredScaleFactor = 0.5
        If desiredScaleFactor > 2 Then desiredScaleFactor = 2

        currentScaleFactor = dxScaler.ScaleForm(Me, desiredScaleFactor, currentScaleFactor)
        dxScaler.ScaleFonts(Me, appBaseFont, currentScaleFactor)
        'Debug.Print("+++++++++++++TRANSFORMED+++++++++++++++")
        'Debug.Print("New Desired/Current [{0},{1}]", desiredScaleFactor, currentScaleFactor)
        'Debug.Print("New Form x,y & Font Size[{0},{1} : {2}]", Me.Width, Me.Height, DevExpress.Utils.AppearanceObject.DefaultFont.Size)
    End Sub

    Private Sub ButtonRPH_R_Click(sender As Object, e As EventArgs) Handles ButtonRPH_R.Click
        DoScaling(+0.25)
    End Sub

    Private Sub ButtonXtraItem_Click(sender As Object, e As EventArgs) Handles ButtonXtraItem.Click
        GetInitialDataset(true)
    End Sub

    Private Sub ButtonScaleTiles_Click(sender As Object, e As EventArgs) Handles ButtonScaleTiles.Click
        TileView1.SetHScaledTileViewItemSize(PanelLeftXtraHeader.Height)
    End Sub

#End Region

#Region "Data Handling"

    '// get a short (no scroll bar) or long (w scrollbar) dataset
    Private Sub GetInitialDataset(isSmallDataset As Boolean)
        If isSmallDataset Then
            data = DeSerializeMusicItemLibrary(My.Resources.ShortAlbumTrackList, True)
        Else
            data = DeSerializeMusicItemLibrary(My.Resources.AlbumTrackList, True)
        End If
        
        ReDim shadowList(data.Count - 1)
        For i As Integer = 0 To data.Count - 1
            shadowList(i) = data.Values(i).ID
        Next
        Grid1.DataSource = shadowList
    End Sub

    Private Sub TileView1_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles TileView1.CustomUnboundColumnData
        If e.IsGetData Then
            Select Case e.Column.Name
                Case "colArt"
                    e.Value = data(e.Row.ToString).ArtWork
                Case "colTitle"
                    e.Value = data(e.Row.ToString).Title
            End Select
        End If
    End Sub

    Private Sub TileView1_ItemCustomize(sender As Object, e As TileViewItemCustomizeEventArgs) Handles TileView1.ItemCustomize
        'Debug.Print("TileView Customize: {0}, row: {1}", sender.GetType.Name, e.RowHandle)
        Dim item As TileViewItem = e.Item
        Dim view As MyTileView = e.Item.View
        '// this is to handle the Hover Management. If we're hovering, set the background image. If not, set to nothing.
        '// need to handle the crazy Grid/TileView scalefactor thing.
        If view.HotTrackRow = item.RowHandle Then
            Dim skinStyler As SkinStyler = dicSkins(sender.Name)
            Item.BackgroundImage = DrawButtonSkinGraphic(dxScaler.activeLookAndFeel, view.GetTileViewItemBackgroundBounds, skinStyler.Skins, skinStyler.ElementName, skinStyler.ImageIndex)
        Else
            item.BackgroundImage=Nothing
        End If
        
    End Sub

    '// test border functionality in MyTileView
    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Debug.Print(TileView1.GetType.Name)
        TileView1.MyBorderWidth=5       
    End Sub

#End Region

#Region "TileView and Grid Events"

    Private Sub TileView1_ContextButtonClick(sender As Object, e As ContextItemClickEventArgs) Handles TileView1.ContextButtonClick

    End Sub

    Private Sub TileView1_ContextButtonCustomize(sender As Object, e As TileViewContextButtonCustomizeEventArgs) Handles TileView1.ContextButtonCustomize

    End Sub  

    '// is fired both by mouse click and enter key
    Private Sub TileView1_ItemClick(sender As Object, e As TileViewItemClickEventArgs) Handles TileView1.ItemClick
        Debug.Print("ItemClick")
        '// DO ACTIONS HERE

    End Sub
#End Region

#Region "Mouse & HotTracking"
    Private Sub TileView1_MouseMove(sender As Object, e As MouseEventArgs) Handles TileView1.MouseMove
       
        Dim view As MyTileView = sender
        Dim info As TileViewHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
        If info.InItem Then
            Dim item = info.Item
            If Not (view.HotTrackRow = item.RowHandle) Then
                '// new row
                Dim pRow As Integer = view.HotTrackRow
                view.HotTrackRow = item.RowHandle
                '// refresh previous to normal
                If pRow <> GridControl.InvalidRowHandle Then view.RefreshRow(pRow)
                '// refresh the new hotTrackrow
                view.RefreshRow(view.HotTrackRow)
            End If
        Else
            'view.HotTrackRow = GridControl.InvalidRowHandle
        End If
    End Sub

    Private Sub TileView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles TileView1.FocusedRowChanged
        'Debug.Print("Prev: {0}, New: {1}", e.PrevFocusedRowHandle, e.FocusedRowHandle)
        'TileView1.RefreshRow(e.FocusedRowHandle)
    End Sub

    Private Sub Grid1_MouseLeave(sender As Object, e As EventArgs) Handles Grid1.MouseLeave
        Debug.Print("Mouse Left Grid")
        '// invalidate previous hottrackrow if any once we leave the grid
        Dim view As MyTileView = Ctype(Grid1.DefaultView,MyTileView)
        Dim pRow As Integer = view.HotTrackRow
        view.HotTrackRow=GridControl.InvalidRowHandle
        If pRow<> GridControl.InvalidRowHandle Then TileView1.RefreshRow(pRow)
    End Sub

    Private Sub PanelLeft_SizeChanged(sender As Object, e As EventArgs) Handles PanelLeft.SizeChanged
        Dim tileItemElement As TileItemElement = TileView1.SpringTileItemElementWidth(colTitle, True)
    End Sub

    Private Sub PanelCenter_SizeChanged(sender As Object, e As EventArgs) Handles PanelCenter.SizeChanged
        
    End Sub

    Private Sub PanelCenter_Resize(sender As Object, e As EventArgs) Handles PanelCenter.Resize

    End Sub

    Private Sub PanelCenter_LocationChanged(sender As Object, e As EventArgs) Handles PanelCenter.LocationChanged
        
    End Sub

    Private Sub frmSkinUtilities_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        
        'Debug.Print("Panel C Left: {0}, PanelL R: {1}", PanelCenter.Left, PanelLeft.Right)
        'If PanelCenter.Left+1 < (PanelLeft.Right) Then
        '    PanelRight.Hide
        ''Else
        ''    PanelRight.Show
        'End If
        
    End Sub

    
#End Region
End Class