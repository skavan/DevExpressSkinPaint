Imports System.ComponentModel
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.Utils.Design
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Scrolling
Imports DevExpress.XtraGrid.Views.Tile
Imports IgorO.ExposedObjectProject

Class DXScaler
    Public activeLookAndFeel As UserLookAndFeel
    Public ctlDict As New Dictionary(Of String, ControlInfo)

    Public Class ControlInfo
        Sub New(_name As String,  _controlType As String, _size As Size, _location As Point)
            size=_size
            controlType=_controlType
            location=_location
            name = _name
        End Sub

        Property name As String
        Property size As Size
        Property location As Point
        Property originalFontSize As Single
        Property useFont As Boolean = False
        Property useImagePadding As Boolean = False
        Property controlType As String
        Property tag As Object
    End Class

#Region "Initialization Routines"
    Public Sub New(form As XtraForm)
        activeLookAndFeel = form.LookAndFeel.ActiveLookAndFeel
        SetAppControlInfo(form)
    End Sub

    '// create a dictionary of all DevExpress Controls that we want to process at runtime, for one reason or another (i.e. Font size, image size etc..)
    Public Sub SetAppControlInfo(topCtl As Control)
        For each ctl As Object In topCtl.Controls
            Dim type As System.Type = ctl.GetType
            
            '// if it's a devexpress control with an appearance property [uses reflection to check]
            '// this will pickup at least panels, labels and buttons (thats all I'm interested in right now)...expand to tileItems and columns soon.
            Select Case type.Name
                Case "SimpleButton", "LabelControl", "PanelControl"
                    Dim controlInfo As New ControlInfo(ctl.Name, type.Name, ctl.size, ctl.location)
                    '// and the font is manually set in the appearance section or the control has a UsePadding Tag set
                    Debug.Print("Control Name: {0}, UseFont: {1}, Tag: {2}", ctl.Name, ctl.Appearance.Options.UseFont, ctl?.Tag)
                    If ctl.Appearance.Options.UseFont Or ctl?.Tag = "UsePadding" Then
                        '// handle the font case
                        controlInfo.originalFontSize = ctl.Appearance.Font.SizeInPoints
                        controlInfo.useFont = ctl.Appearance.Options.UseFont
                        '// handle the image padding case
                        If ctl?.Tag = "UsePadding" Then
                            controlInfo.useImagePadding=True
                        End If
                        '// if children have controls, recurse the function
                        If Not ctlDict.ContainsKey(ctl.Name) Then
                            ctlDict.Add(ctl.Name,controlInfo)
                        End If
                
                    End If
            End Select

            If ctl.Controls.Count>0 Then
                SetAppControlInfo(ctl)
            End If
        Next
        
    End Sub  

#End Region

#Region "Event Assignment and Handling"
    '// add handlers to selected buttons
    Public Sub SetButtonSizeChangedHandlers(form As XtraForm, ByRef Func As EventHandler)
        For each item In ctlDict
            Dim ctlInfo As ControlInfo = item.Value
            If ctlInfo.useImagePadding Then
                Dim ctl As Control = GetControlByName(form, ctlInfo.Name)
                AddHandler ctl.SizeChanged, Func        
                ctl.BeginInvoke(func, {ctl, New EventArgs})     '// force a refresh
            End If
        Next
    End Sub
    
#End Region
    
#Region "Font, Form and Tile Scaling"

    '// scale a form by taking the desired scale abnd the current scale. work out the transform and apply it. Return what is the new resultant (=desired) scale.
    Public Function ScaleForm(form As XtraForm, desiredScaleFactor As Single, currentScaleFactor As Single) As Single
        Dim xFormScaleFactor As Single = desiredScaleFactor / currentScaleFactor
        ScaleFormByFactor(form, New SizeF(xFormScaleFactor, xFormScaleFactor))
        Return desiredScaleFactor
    End Function

    '// scale everything on a form by a factor
    Public Sub ScaleFormByFactor(form As XtraForm, factor As SizeF)
        form.Scale(factor)
    End Sub

    '// given a basefont (the starting font size, family and style), rescale it by a factor and set all Devexpress controls to this, then process individually overridden children
    Public Sub ScaleFonts(form As XtraForm, baseFont As Font, fontScaleFactor As Single)
        Dim startSize As Single = baseFont.SizeInPoints
        DevExpress.Utils.AppearanceObject.DefaultFont = New Font(basefont.FontFamily.Name, startSize * fontScaleFactor, basefont.Style)
        ScaleIndependentControls(form, fontScaleFactor)
    End Sub

    '// go through the dictionary, find controls that have independent font use and rescale by the scalefactor
    Public Sub ScaleIndependentControls(form As XtraForm, fontScaleFactor As Single)
        '// iterate through each affected control and apply the scale factor to the original size
        For Each item In ctlDict
            Dim cInfo As ControlInfo = item.Value
            If cInfo.useFont Then
                Dim ctl As Object = GetControlByName(form, item.Key)
                Dim font As Font = ctl.Appearance.Font
                ctl.Appearance.Font = New Font(font.FontFamily.Name, cInfo.originalFontSize*fontScaleFactor, font.Style)
            End If
        Next
    End Sub
    
#End Region

#Region "WIP"

#End Region
    '// Notes:
    '// There is a bug in the contextbutton class where contextButton.Size = 0
    '// contextButton.Height and contextButton.Width must be used instead.
End Class
