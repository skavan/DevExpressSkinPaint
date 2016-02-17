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
    Dim commonSkins As New DevExpress.Skins.CommonSkins
    Dim ribbonSkins As New DevExpress.Skins.RibbonSkins
    Dim dicSkins As New Dictionary(Of String, SkinStyler)           'Just convenience, so I can manage reskinning easily

    Dim windowsScaleFactor As SizeF = New SizeF(1F, 1F)             'The scale factor [to deal with HDPI screens]
    Dim btnImageScaleFactor As SizeF = New SizeF(0.85, 0.85)        'The scale factor applied to button images
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSkinUtilities))

    Dim currentScaleFactor As Single = 1
    Dim desiredScaleFactor As Single = 1
    Dim baseFont As Font = Me.Font
    Dim dxScaler As DXScaler

    Dim data As Dictionary(Of String, MusicItem)
    Dim shadowList As String()

    Dim WithEvents tileScrollBar As DevExpress.XtraGrid.Scrolling.VCrkScrollBar 'The grid/TileView scrollbar
    Dim HotTrackRow As Integer = GridControl.InvalidRowHandle
    Dim FocusRow As Integer = GridControl.InvalidRowHandle
    
    Class SkinStyler
        Property IsImage As Boolean
        Property Skins As Object
        Property ElementName As String
        Property ImageIndex As Integer
    End Class

#Region "Startup and Initialization"

    '// Used to set Font
    Public Sub New()
        '// set all devexpress fonts to specific font, before initialization
        'DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Segoe UI", 10)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.              
    End Sub

    '// used to grab the scalefactor (useful, when DevExpress is Not SetModeDPIAware)
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
        baseFont = DevExpress.Utils.AppearanceObject.DefaultFont
        dxScaler = New DXScaler(Me)
        tileScrollBar = dxScaler.GetTileViewVScrollBar(Grid1)
        ButtonXtraItem.PerformClick
    End Sub

    '// a central place to setup skinning overrides.
    Private Sub SetSkinStylingOverrides
        dicSkins.Add(PanelTop.Name, New SkinStyler With {.IsImage = "True",
                                  .Skins = commonSkins, .ElementName = "Button", .ImageIndex = 4})
        dicSkins.Add(PanelLeftHeader.Name, New SkinStyler With {.IsImage = "True",
                                  .Skins = commonSkins, .ElementName = "Button", .ImageIndex = 1})
        dicSkins.Add(PanelRightHeader.Name, New SkinStyler With {.IsImage = "True",
                                  .Skins = commonSkins, .ElementName = "Button", .ImageIndex = 1})
        dicSkins.Add(PanelCenterHeader.Name, New SkinStyler With {.IsImage = "True",
                                  .Skins = commonSkins, .ElementName = "Button", .ImageIndex = 1})
        dicSkins.Add(PanelLeftXtraHeader.Name, New SkinStyler With {.IsImage = "True",
                                  .Skins = commonSkins, .ElementName = "Button", .ImageIndex = 0})
        '// use this tag to flag buttons where we want to rescale the images 
        ButtonLPH_L.Tag = "UsePadding"
        ButtonLPH_R.Tag = "UsePadding"
        'TileView1.
    End Sub
#End Region

#Region "Panel Painting and Button Resizing"
    '// demonstrating overriding paint method and using a skin image 
    Private Sub PanelTop_Paint(sender As Object, e As PaintEventArgs) Handles PanelTop.Paint
        Dim skinStyler As SkinStyler = dicSkins(sender.Name)
        e.Graphics.DrawImage(DrawButtonSkinGraphic(dxScaler.activeLookAndFeel, sender.Bounds, skinStyler.Skins, skinStyler.ElementName, skinStyler.ImageIndex), 0, 0)
    End Sub

    Private Sub PanelLeftHeader_Paint(sender As Object, e As PaintEventArgs) Handles PanelLeftHeader.Paint
        Dim skinStyler As SkinStyler = dicSkins(sender.Name)
        e.Graphics.DrawImage(DrawButtonSkinGraphic(dxScaler.activeLookAndFeel, sender.Bounds, skinStyler.Skins, skinStyler.ElementName, skinStyler.ImageIndex), 0, 0)
    End Sub

    Private Sub PanelCenterHeader_Paint(sender As Object, e As PaintEventArgs) Handles PanelCenterHeader.Paint
        Dim skinStyler As SkinStyler = dicSkins(sender.Name)
        e.Graphics.DrawImage(DrawButtonSkinGraphic(dxScaler.activeLookAndFeel, sender.Bounds, skinStyler.Skins, skinStyler.ElementName, skinStyler.ImageIndex), 0, 0)
    End Sub

    Private Sub PanelRightHeader_Paint(sender As Object, e As PaintEventArgs) Handles PanelRightHeader.Paint
        Dim skinStyler As SkinStyler = dicSkins(sender.Name)
        e.Graphics.DrawImage(DrawButtonSkinGraphic(dxScaler.activeLookAndFeel, sender.Bounds, skinStyler.Skins, skinStyler.ElementName, skinStyler.ImageIndex), 0, 0)
    End Sub

    Private Sub PanelLeftXtraHeader_Paint(sender As Object, e As PaintEventArgs) Handles PanelLeftXtraHeader.Paint
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
        Debug.Print("Resized")
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

    '// when the Grid is resized, change the Tile Item Size
    Private Sub Grid1_SizeChanged(sender As Object, e As EventArgs) Handles Grid1.SizeChanged
        If tileScrollBar IsNot Nothing Then dxScaler.ResizeTileItems(Grid1, TileView1, PanelLeftXtraHeader, tileScrollBar)
    End Sub

    Private Sub tileScrollBar_VisibleChanged(sender As Object, e As EventArgs) Handles tileScrollBar.VisibleChanged
        If tileScrollBar IsNot Nothing Then dxScaler.ResizeTileItems(Grid1, TileView1, PanelLeftXtraHeader, tileScrollBar)
    End Sub

#End Region

#Region "Main Demo Button Methods"

    '// set all DevExpress fonts to specific size or auto-size
    Private Sub ButtonResizeFonts_Click(sender As Object, e As EventArgs) Handles ButtonResizeFonts.Click
        Dim s As String = ComboFontSize.SelectedItem
        If s = "Auto" Or s = "" Then
            dxScaler.ScaleFonts2(Me, baseFont, currentScaleFactor)
        Else
            If s <> "" Then
                Dim newScaleFactor = (s / baseFont.Size)
                dxScaler.ScaleFonts2(Me, baseFont, newScaleFactor)
            End If
        End If

    End Sub

    '// Scale Form by a factor
    Private Sub ButtonScaleForm_Click(sender As Object, e As EventArgs) Handles ButtonScaleForm.Click
        Dim s As String = ComboScaleForm.SelectedItem
        If s > 0 Then
            desiredScaleFactor = s
            Dim xFormScaleFactor As Single = desiredScaleFactor / currentScaleFactor
            dxScaler.ScaleForm(Me, Grid1, New SizeF(xFormScaleFactor, xFormScaleFactor))
            '// now the current is equal to the desired
            currentScaleFactor = desiredScaleFactor
        End If
    End Sub

    Private Sub ButtonResizeBtns_Click(sender As Object, e As EventArgs) Handles ButtonResizeBtns.Click
        dxScaler.SetButtonResizing(CType(Me, XtraForm), AddressOf Button_SizeChanged)
    End Sub

    Private Sub ButtonFontMetrics_Click(sender As Object, e As EventArgs) Handles ButtonFontMetrics.Click
        Debug.Print("Font Size:" & LabelLPH_C.Font.SizeInPoints)
        Debug.Print("Ctl Size:" & LabelLPH_C.Height)
        Debug.Print("Line Spacing:" & LabelLPH_C.Font.GetHeight)
        Debug.Print("em-height:" & LabelLPH_C.Font.FontFamily.GetEmHeight(LabelLPH_C.Font.Style))
        Debug.Print("DPIY:" & DevExpress.XtraBars.DPISettings.DpiY)
    End Sub

    Private Sub ButtonRPH_L_Click(sender As Object, e As EventArgs) Handles ButtonRPH_L.Click
        DoScaling(-0.25)
    End Sub

    Private Sub DoScaling(ScaleChange As Single)
        Debug.Print("================START SCALING=================")
        Debug.Print("Current Desired/Current [{0},{1}]", desiredScaleFactor, currentScaleFactor)
        Debug.Print("Current Form x,y & Font Size[{0},{1} : {2}]", Me.Width, Me.Height, DevExpress.Utils.AppearanceObject.DefaultFont.Size)
        desiredScaleFactor = desiredScaleFactor + ScaleChange
        If desiredScaleFactor < 0.5 Then desiredScaleFactor = 0.5
        If desiredScaleFactor > 2 Then desiredScaleFactor = 2
        '// the transformation required to get from current to desired
        Dim xFormScaleFactor As Single = desiredScaleFactor / currentScaleFactor
        dxScaler.ScaleForm(Me, Grid1, New SizeF(xFormScaleFactor, xFormScaleFactor))
        '// now the current is equal to the desired
        currentScaleFactor = desiredScaleFactor
        dxScaler.ScaleFonts2(Me, baseFont, desiredScaleFactor)

        Debug.Print("+++++++++++++TRANSFORMED+++++++++++++++")
        Debug.Print("New Desired/Current [{0},{1}]", desiredScaleFactor, currentScaleFactor)
        Debug.Print("New Form x,y & Font Size[{0},{1} : {2}]", Me.Width, Me.Height, DevExpress.Utils.AppearanceObject.DefaultFont.Size)


    End Sub

    Private Sub ButtonRPH_R_Click(sender As Object, e As EventArgs) Handles ButtonRPH_R.Click
        DoScaling(+0.25)

    End Sub

    Private Sub ButtonXtraItem_Click(sender As Object, e As EventArgs) Handles ButtonXtraItem.Click
        'Dim list As List(Of MusicItem) = DeSerializeMusicItemLibrary("G:\smallList.XML")
        data = DeSerializeMusicItemLibrary(My.Resources.AlbumTrackList, True)

        ReDim shadowList(data.Count - 1)
        For i As Integer = 0 To data.Count - 1
            shadowList(i) = data.Values(i).ID
        Next
        Grid1.DataSource = shadowList
    End Sub

    Private Sub ButtonScaleTiles_Click(sender As Object, e As EventArgs) Handles ButtonScaleTiles.Click
        dxScaler.ResizeTileItems(Grid1, TileView1, PanelLeftXtraHeader, tileScrollBar)
    End Sub



#End Region

#Region "Data Handling"
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

    Private Sub TileView1_ContextButtonClick(sender As Object, e As ContextItemClickEventArgs) Handles TileView1.ContextButtonClick

    End Sub

    Private Sub TileView1_ContextButtonCustomize(sender As Object, e As TileViewContextButtonCustomizeEventArgs) Handles TileView1.ContextButtonCustomize

    End Sub

    Private Sub TileView1_MouseMove(sender As Object, e As MouseEventArgs) Handles TileView1.MouseMove
        'Dictionary(Of Integer, DevExpress.XtraGrid.Views.Tile.TileViewItem)
        

        Dim view As TileView = sender
        Dim info As TileViewHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
        If info.InItem Then
            Dim item = info.Item
            If Not (HotTrackRow = item.RowHandle) Then
                '// new row
                Dim pRow As Integer = HotTrackRow
                HotTrackRow = item.RowHandle
                '// refresh previous to normal
                If pRow <> GridControl.InvalidRowHandle Then TileView1.RefreshRow(pRow)
                'If pRow <> GridControl.InvalidRowHandle Then PaintFocusTile2(pRow, False)
                '// refresh the new hotTrackrow
                'PaintFocusTile2(HotTrackRow, True)
                TileView1.RefreshRow(HotTrackRow)
            End If
        Else
            'HotTrackRow = GridControl.InvalidRowHandle
        End If
    End Sub

    Private Sub Grid1_MouseLeave(sender As Object, e As EventArgs) Handles Grid1.MouseLeave
        Debug.Print("Mouse Left Grid")
        '// invalidate previous hottrackrow if any.
        Dim pRow As Integer = HotTrackRow
        HotTrackRow=GridControl.InvalidRowHandle
        If pRow<> GridControl.InvalidRowHandle Then TileView1.RefreshRow(pRow)
    End Sub

    '// is fired both by mouse click and enter key
    Private Sub TileView1_ItemClick(sender As Object, e As TileViewItemClickEventArgs) Handles TileView1.ItemClick
        Debug.Print("ItemClick")
        '// DO ACTIONS HERE

    End Sub

    Private Sub TileView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles TileView1.FocusedRowChanged
        Debug.Print("Prev: {0}, New: {1}", e.PrevFocusedRowHandle, e.FocusedRowHandle)
        'TileView1.RefreshRow(e.FocusedRowHandle)
    End Sub

    Private Sub TileView1_CustomDrawEmptyForeground(sender As Object, e As CustomDrawEventArgs) Handles TileView1.CustomDrawEmptyForeground
        Debug.Print("Paint Row: ", sender.GetType.Name)
    End Sub

    Private Sub Grid1_Paint(sender As Object, e As PaintEventArgs) Handles Grid1.Paint
        'Debug.Print("Grid Paint eType: {0}, senderType: {1}", e.GetType.Name, sender.GetType.Name)

    End Sub

    Private Sub PaintFocusTile2(rowHandle As Integer, isFocus As Boolean)
        If rowHandle = GridControl.InvalidRowHandle Then Exit Sub
        Dim vItem As TileViewItem = TryCast(TryCast(tileView1.GetViewInfo(), ITileControl).ViewInfo, TileViewInfoCore).VisibleItems(rowHandle)
        If vItem Is Nothing Then Exit Sub
        If isFocus Then
            Debug.Print ("Painting Row:" & vItem.RowHandle)
            vItem.BackgroundImage = DrawButtonSkinGraphic(dxScaler.activeLookAndFeel, New Rectangle(0, 0, vItem.View.OptionsTiles.ItemSize.Width, vItem.View.OptionsTiles.ItemSize.Height), commonSkins, "HighlightedItem", 0)
            TileView1.RefreshRow(vItem.RowHandle)
        Else
            Debug.Print ("Unpainting Row:" & vItem.RowHandle)
            vItem.BackgroundImage=Nothing
            Grid1.Refresh
        End If
    End Sub

    Private Sub PaintFocusTile(rowHandle As Integer)
        Dim visibleItems As Dictionary(Of Integer, TileViewItem) = GetVisibleRows(TileView1)
        For each vItem In visibleItems.Values
            If vItem.RowHandle = HotTrackRow Then
                Debug.Print ("Filling Row:" & vItem.RowHandle)
                vItem.BackgroundImage = DrawButtonSkinGraphic(dxScaler.activeLookAndFeel, New Rectangle(0, 0, vItem.View.OptionsTiles.ItemSize.Width, vItem.View.OptionsTiles.ItemSize.Height), commonSkins, "HighlightedItem", 1)
            Else
                Debug.Print ("Erasing Row:" & vItem.RowHandle)
                vItem.BackgroundImage=Nothing
                    
            End If
        Next
    End Sub
    Private Sub TileView1_ItemCustomize(sender As Object, e As TileViewItemCustomizeEventArgs) Handles TileView1.ItemCustomize
        Debug.Print("TileView Customize: {0}, row: {1}", sender.GetType.Name, e.RowHandle)
        Dim item As TileViewItem = e.Item
        If HotTrackRow = item.RowHandle Then
            Item.BackgroundImage = DrawButtonSkinGraphic(dxScaler.activeLookAndFeel, New Rectangle(0, 0, Item.View.OptionsTiles.ItemSize.Width, Item.View.OptionsTiles.ItemSize.Height), commonSkins, "HighlightedItem", 0)
        Else
            item.BackgroundImage=Nothing
        End If
        
        'Else
        '    item.BackgroundImage=Nothing

        'End If

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Dim visibleItems As Dictionary(Of Integer, TileViewItem) = GetVisibleRows(TileView1)
            For each vItem In visibleItems.Values
                
                    vItem.BackgroundImage = Nothing
                
            Next
    End Sub




#End Region
End Class