'// note: form autoscalemode is set to DPI
'// form font is set to Segoe UI, 10 pt.
'// Devexpress is 
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

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
        tileScrollBar = dxScaler.GetTileViewVScrollBar(grid1)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form))
        'If resources.GetObject(btnCtl.Name & ".Image") Is Nothing Then Exit Sub
        btnCtl.Image = RescaleImageByScaleFactor(resources.GetObject(btnCtl.Name & ".Image"),
                                                                     btnCtl.Size, btnImageScaleFactor)

    End Sub

    '// when the Grid is resized, change the Tile Item Size
    Private Sub Grid1_SizeChanged(sender As Object, e As EventArgs) Handles Grid1.SizeChanged
        If tileScrollBar IsNot Nothing Then dxScaler.ResizeTileItems(Grid1, TileView1, PanelLeftXtraHeader,  tileScrollBar)
    End Sub

    Private Sub tileScrollBar_VisibleChanged(sender As Object, e As EventArgs) Handles tileScrollBar.VisibleChanged
        If tileScrollBar IsNot Nothing Then dxScaler.ResizeTileItems(Grid1, TileView1, PanelLeftXtraHeader,  tileScrollBar)
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
        dxScaler.ScaleForm(Me, grid1, New SizeF(xFormScaleFactor, xFormScaleFactor))
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

        ReDim shadowList(data.count - 1)
        For i As Integer = 0 To data.Count - 1
            shadowList(i) = data.Values(i).id
        Next
        Grid1.DataSource = shadowList
    End Sub

    Private Sub ButtonScaleTiles_Click(sender As Object, e As EventArgs) Handles ButtonScaleTiles.Click       
        dxScaler.ResizeTileItems(Grid1, TileView1, PanelLeftXtraHeader,  tileScrollBar)
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




#End Region
End Class