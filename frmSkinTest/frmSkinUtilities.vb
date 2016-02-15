﻿'// note: form autoscalemode is set to DPI
'// form font is set to Segoe UI, 10 pt.
'// Devexpress is 
Imports DevExpress.XtraEditors

Public Class frmSkinUtilities
    Dim commonSkins As New DevExpress.Skins.CommonSkins
    Dim ribbonSkins As New DevExpress.Skins.RibbonSkins
    Dim dicSkins As New Dictionary(Of String, SkinStyler)           'Just convenience, so I can manage reskinning easily

    Dim windowsScaleFactor As SizeF = New SizeF(1F, 1F)             'The scale factor [to deal with HDPI screens]
    Dim btnImageScaleFactor As SizeF = New SizeF(0.85, 0.85)        'The scale factor applied to button images
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSkinUtilities))
    Dim fontToControlRatio As Single=1
    Dim fontInitialSize As Single=10
    Dim currentScaleFactor As Single = 1
    Dim desiredScaleFactor As Single =1
    Dim baseFont As Font = Me.Font
    

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
        '// set afterwards (at cost of extra refresh, but form font is now set
        DevExpress.Utils.AppearanceObject.DefaultFont = Me.Font        '// set to form font
        '// the font to control ratio, compares the size of the font in points to the default height of the Control it sits in
        fontToControlRatio = LabelLPH_C.Font.Size()/LabelLPH_C.Height
        fontInitialSize = LabelLPH_C.Font.Size
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
        'SetModeDPIAware
        SetSkinStylingOverrides
        SetAppControlInfo(Me)
        baseFont = DevExpress.Utils.AppearanceObject.DefaultFont
    End Sub

    #End Region 

 

#Region "Panel Painting"
    '// demonstrating overriding paint method and using a skin image 
    Private Sub PanelTop_Paint(sender As Object, e As PaintEventArgs) Handles PanelTop.Paint
        Dim skinStyler As SkinStyler=dicSkins(sender.Name)
        e.Graphics.DrawImage(DrawButtonSkinGraphic(sender.Bounds, skinStyler.Skins, skinStyler.ElementName, skinStyler.ImageIndex),0,0)       
    End Sub

    Private Sub PanelLeftHeader_Paint(sender As Object, e As PaintEventArgs) Handles PanelLeftHeader.Paint
        Dim skinStyler As SkinStyler=dicSkins(sender.Name)
        e.Graphics.DrawImage(DrawButtonSkinGraphic(sender.Bounds, skinStyler.Skins, skinStyler.ElementName, skinStyler.ImageIndex),0,0)       
    End Sub

    Private Sub PanelCenterHeader_Paint(sender As Object, e As PaintEventArgs) Handles PanelCenterHeader.Paint
        Dim skinStyler As SkinStyler=dicSkins(sender.Name)
        e.Graphics.DrawImage(DrawButtonSkinGraphic(sender.Bounds, skinStyler.Skins, skinStyler.ElementName, skinStyler.ImageIndex),0,0)       
    End Sub

    Private Sub PanelRightHeader_Paint(sender As Object, e As PaintEventArgs) Handles PanelRightHeader.Paint
        Dim skinStyler As SkinStyler=dicSkins(sender.Name)
        e.Graphics.DrawImage(DrawButtonSkinGraphic(sender.Bounds, skinStyler.Skins, skinStyler.ElementName, skinStyler.ImageIndex),0,0)       
    End Sub
#End Region

    '// a central place to setup skinning overrides.
    Private Sub SetSkinStylingOverrides
        dicSkins.Add(PanelTop.Name, New SkinStyler With {.IsImage = "True", 
                                  .Skins = commonSkins, .ElementName="Button", .ImageIndex=4})
        dicSkins.Add(PanelLeftHeader.Name, New SkinStyler With {.IsImage = "True", 
                                  .Skins = commonSkins, .ElementName="Button", .ImageIndex=1})
        dicSkins.Add(PanelRightHeader.Name, New SkinStyler With {.IsImage = "True", 
                                  .Skins = commonSkins, .ElementName="Button", .ImageIndex=1})
        dicSkins.Add(PanelCenterHeader.Name, New SkinStyler With {.IsImage = "True", 
                                  .Skins = commonSkins, .ElementName="Button", .ImageIndex=1})
        '// use this tag to flag buttons where we want to rescale the images 
        ButtonLPH_L.Tag=True
        ButtonLPH_R.Tag=True
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

    
#Region "Main Demo Button Methods"
    '// set all DevExpress fonts
    Private Sub ButtonResizeFonts_Click(sender As Object, e As EventArgs) Handles ButtonResizeFonts.Click
        Dim s As String = ComboFontSize.SelectedItem
        If s="Auto" Or s="" Then
            ScaleFonts2(Me,baseFont, currentScaleFactor)
        Else
            If s<>"" Then
                Dim newScaleFactor = (s/DevExpress.Utils.AppearanceObject.DefaultFont.Size)
                ScaleFonts2(Me,baseFont, newScaleFactor)
            End If
        End If
        
    End Sub

    '// Scale Form by a factor
    Private Sub ButtonScaleForm_Click(sender As Object, e As EventArgs) Handles ButtonScaleForm.Click
        Dim s As String = ComboScaleForm.SelectedItem
        If s>0 Then
            Dim desiredScaleFactor As Single = s
            Dim xFormScaleFactor As Single = desiredScaleFactor/currentScaleFactor
            ScaleForm(Me,New SizeF(xFormScaleFactor,xFormScaleFactor))
            '// now the current is equal to the desired
            currentScaleFactor = desiredScaleFactor
            
        End If
    End Sub

    Private Sub ButtonResizeBtns_Click(sender As Object, e As EventArgs) Handles ButtonResizeBtns.Click
        SetButtonResizing(CType(Me,XtraForm), AddressOf Button_SizeChanged,True)      
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
        If desiredScaleFactor>2 Then desiredScaleFactor=2
        '// the transformation required to get from current to desired
        Dim xFormScaleFactor As Single = desiredScaleFactor/currentScaleFactor
        ScaleForm(Me,New SizeF(xFormScaleFactor,xFormScaleFactor))
        '// now the current is equal to the desired
        currentScaleFactor = desiredScaleFactor
        ScaleFonts2(Me,baseFont, desiredScaleFactor)
        Debug.Print("+++++++++++++TRANSFORMED+++++++++++++++")
        Debug.Print("New Desired/Current [{0},{1}]", desiredScaleFactor, currentScaleFactor)
        Debug.Print("New Form x,y & Font Size[{0},{1} : {2}]", Me.Width, Me.Height, DevExpress.Utils.AppearanceObject.DefaultFont.Size)
        

    End Sub

    '// using a fixed control element to gauge size changes, scale fonts
    Private Sub ScaleFontsToForm
        Dim fontScaleFactor As Single = (fontToControlRatio * LabelLPH_C.Height) / fontInitialSize
        Dim newScaleFactor = (fontInitialSize * currentScaleFactor) / DevExpress.Utils.AppearanceObject.DefaultFont.Size
        ScaleFonts(Me,newScaleFactor, True)
    End Sub

    Private Sub ButtonRPH_R_Click(sender As Object, e As EventArgs) Handles ButtonRPH_R.Click
        DoScaling(+0.25)

    End Sub
#End Region

End Class