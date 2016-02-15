Imports System.ComponentModel
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.Utils.Design
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraGrid.Views.Tile

Module DevExpressUtils
    Public activeLookAndFeel As UserLookAndFeel
    
    '// add handlers to selected buttons
    Public Sub SetButtonResizing(form As XtraForm, ByRef Func As EventHandler, Optional TagMatch As String="")
        Dim ctl As Control = Nothing
        Do
            ctl = form.GetNextControl(ctl, True)
            If ctl IsNot Nothing Then
                If TagMatch="" Or (TagMatch = ctl?.Tag) Then
                    If TypeOf ctl Is DevExpress.XtraEditors.SimpleButton Then
                        Dim btnCtl As DevExpress.XtraEditors.SimpleButton = ctl
                        AddHandler btnCtl.SizeChanged, Func        
                        btnCtl.BeginInvoke(func, {btnCtl, New EventArgs})
                    End If
                End If
            End If
        Loop Until ctl Is Nothing
    End Sub

    '// make the project dpi aware.
    Public Sub SetModeDPIAware
        DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware
    End Sub

    '// from the DevExpress Icon Library -- quite slow. Consider using an imageList for speed
    Public Function GetDevExpressImage(imageName As String) As Image
        Dim iconImage As Image = DevExpress.Images.ImageResourceCache.Default.GetImage(imageName)
        Return iconImage
    End Function

    Public Function GetRandomDevExpressImage() As Image
        Dim image As Image
        Do
            Dim numImages As Integer = 32 'DevExpress.Images.ImageResourceCache.Default.GetAllResourceKeys.Count
            Dim X As Integer = CInt(Math.Ceiling(Rnd() * numImages)) + 256
            Dim key As String = DevExpress.Images.ImageResourceCache.Default.GetAllResourceKeys(X)
            image =  DevExpress.Images.ImageResourceCache.Default.GetImage(key)
        Loop Until image.Width=32
        Return image
    End Function
    
    '// three overloads. the first doesn't use a scale factor
    Public Function RescaleImageByScaleFactor(srcImage As Image, targetSize As Size) As Image
        Return RescaleImageByScaleFactor(srcImage, targetSize.Width, targetSize.Height, New SizeF(1, 1))
    End Function

    Public Function RescaleImageByScaleFactor(srcImage As Image, targetSize As Size, scaleFactor As SizeF) As Image
        Return RescaleImageByScaleFactor(srcImage, targetSize.Width, targetSize.Height, scaleFactor)
    End Function

    Public Function RescaleImageByScaleFactor(srcImage As Image, width As Integer, height As Integer, scaleFactor As SizeF) As Image
        Return New Bitmap((srcImage), New Size(width * scaleFactor.Width, height * scaleFactor.Height))
    End Function

    Public Function RescaleImageByPadding(srcImage As Image, targetSize As Size, padding As Padding) As Image
        Return RescaleImageByPadding(srcImage, targetSize.Width, targetSize.Height, padding)
    End Function

    Public Function RescaleImageByPadding(srcImage As Image, width As Integer, height As Integer, padding As Padding) As Image
        Return New Bitmap((srcImage), New Size(width - (padding.Left+padding.Right), height - (padding.Top+padding.Bottom)))
    End Function

    Public Sub ScaleForm(form As XtraForm, factor As SizeF)
        form.Scale(factor)
        ' seems to work in the form itself but not in this module! Me.ScaleCore(1.5,1.5)
    End Sub

    Public Sub ScaleFonts(form As XtraForm, fontScaleFactor As Single, sizeChildren As Boolean)
        '// get current Font
        Dim font As Font = DevExpress.Utils.AppearanceObject.DefaultFont
        Dim startSize As Single = font.SizeInPoints
        '// now resize it
        DevExpress.Utils.AppearanceObject.DefaultFont = New Font(font.FontFamily.Name, startSize * fontScaleFactor, font.Style)
        '// now check devexpress children
        If sizeChildren Then ScaleControlFonts(form, fontScaleFactor)
    End Sub

    Public Sub ScaleControlFonts(TopCtl As Object, fontscaleFactor As Single)
        For each ctl As Object In TopCtl.Controls
            Dim type = ctl.GetType
            If ctl.Name="LabelTPH_L"Then
                Debug.Print("Ys")
            End If
            If type.GetProperty("Appearance", Reflection.BindingFlags.DeclaredOnly Or Reflection.BindingFlags.Public Or Reflection.BindingFlags.Instance) IsNot Nothing Then
                If ctl.Appearance.Options.UseFont Then
                    Dim font As Font = ctl.Appearance.Font
                    Dim startSize As Single = font.Size
                    ctl.Appearance.Font = New Font(font.FontFamily.Name, startSize*fontScaleFactor, font.Style)

                End If
            End If
            If ctl.Controls.Count>0 Then
                ScaleControlFonts(ctl, fontscaleFactor)
            End If
        Next
    End Sub

    Public Sub ScaleTileViewFonts(View As TileView, scaleFactor As Single)
        Dim ap As AppearanceObject
        'Dim font As Font
        For Each ap In View.Appearance
            'font = ap.Font
            ap.FontSizeDelta = 1.5
            'ap.Font = font
        Next
    End Sub

    '// utility function - must be a better way!
    Public Function GetTileElement(view As TileView, colName As String) As TileViewItemElement
        For Each element As TileViewItemElement In view.TileTemplate
            If element.Column.Name = colName Then Return element
        Next
        Return Nothing
    End Function


#Region "Skin Related"
    '// force a refresh of all DevExpress stuff.
    Public Sub ForceDefaultLookAndFeelChanged
        LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
    End Sub

    Public Sub SetActiveSkin(form As XtraForm)
        activeLookAndFeel = form.LookAndFeel.ActiveLookAndFeel
    End Sub

    '// get the skinImage from a given element. Note: use SkinEditor to find the elementName
    Public Function GetSkinElementSkinImage(skinCategory As Object, elementName As String) As SkinImage
        'Dim currentSkin As DevExpress.Skins.Skin = skinCategory.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default)
        Dim currentSkin As DevExpress.Skins.Skin = skinCategory.GetSkin(activeLookAndFeel)
        Dim element As DevExpress.Skins.SkinElement = currentSkin(elementName)
        Return element.Image
    End Function

    '// set the IMAGE in a skinImage for a given element. Note, this may need to be a vertical imagestrip to get desired results
    '// look at the element in SkinEditor, else you will get odd results!
    Public Sub SetSkinElementImage(skinCategory As Object, elementName As String, image As Image, Optional imageName As String="")
        Dim skinImage As SkinImage = GetSkinElementSkinImage(skinCategory, elementName)
        If imageName = "" Then imageName = skinImage.ImageName
        skinImage.SetImage(image, imageName)
        skinImage.SaveImage
    End Sub
    '// override to Set the IMAGE in a skinImage from file
    Public Sub SetSkinElementImage(skinCategory As Object, elementName As String, filename As String, Optional imageName As String="")
        Dim image As Image = image.FromFile(filename)
        SetSkinElementImage(skinCategory, elementName, image, imageName)
    End Sub

    '// save the skinImage from a given element. Note: use SkinEditor to find the elementName
    Public Sub SaveSkinElementSkinImage(skinCategory As Object, elementName As String, filename As String)
        Dim skinImage As SkinImage = GetSkinElementSkinImage(skinCategory, elementName)
        skinImage.Image.Save(filename)
    End Sub

    '// There seems to be a bug in skinImage.GetImages.Images(index) not getting updated. 
    '// This is a workaround
    Public Function GetImageFromSkinImage(skinImage As SkinImage, index As Integer) As Image
        Dim x As Integer = 0
        Dim w As Integer = skinImage.Image.Width
        Dim h As Integer = skinImage.Image.Height / skinImage.ImageCount
        Dim y As Integer = (index * h)
        Dim bmp As New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(skinImage.Image,New Rectangle(0,0,w,h), New Rectangle(x,y,w,h),GraphicsUnit.Pixel)
        End Using
        Return bmp
    End Function

#End Region

#Region "Graphics and Painting Related"
    
    '// given a target size, a skinelement and a target image index, construct a graphic
    Public Function DrawButtonSkinGraphic(tgtRect As Rectangle, skinCategory As Object, elementName As String, imageIndex As Integer) As Image
        Dim skinImage As SkinImage = GetSkinElementSkinImage(skinCategory, elementName)
        'Dim image As Image = skinImage.GetImages.Images(imageIndex)
        Dim image As Image = GetImageFromSkinImage(skinImage,imageIndex)
        Dim sM As SkinPaddingEdges = skinImage.SizingMargins
        Dim srcR As Rectangle = New Rectangle(0,0,image.Width, image.Height)
        Dim l As Integer = 0
        Dim w As Integer = tgtRect.Width
        Dim t As Integer = 0
        Dim h As Integer = tgtRect.Height

        Dim bmp As New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            '// corner squares
            g.DrawImage(image, New Rectangle(l, t, sM.Left, sM.top), New Rectangle(0, 0, sM.Left, sM.Top), GraphicsUnit.Pixel)
            g.DrawImage(image, New Rectangle(l, h-sM.Bottom, sM.Left, sM.Bottom), New Rectangle(0, srcR.Bottom-sM.Bottom, sM.Left, sM.Bottom), GraphicsUnit.Pixel)
            g.DrawImage(image, New Rectangle(w-sM.Right,t,sM.Right,sM.Top), New Rectangle(srcR.Right- sM.right, 0, sM.Right, sM.Top), GraphicsUnit.Pixel)
            g.DrawImage(image, New Rectangle(w-sM.Right, h-sM.Bottom , sM.Right, sM.Bottom), New Rectangle(srcR.Right-sM.Right, srcR.Bottom - sM.Bottom, sM.Right, sM.Bottom), GraphicsUnit.Pixel)

            '// edges
            g.DrawImage(image, New Rectangle(l+sM.Left, t, w-l-sM.Width, sM.Top), New Rectangle(sM.Left, 0, image.Width-sM.Width - 1, sM.Top), GraphicsUnit.Pixel)
            g.DrawImage(image, New Rectangle(l+sM.Left, h-sM.Bottom, w-l-sM.Width, sM.Bottom), New Rectangle(sM.Left, srcR.Bottom-sM.Bottom, image.Width-sM.Width - 1, sM.Bottom), GraphicsUnit.Pixel)
            g.DrawImage(image, New Rectangle(l, t+sM.Top, sM.Left, h-t-sM.Height), New Rectangle(0, sM.Top, sM.Left, image.Height - sM.Height - 1), GraphicsUnit.Pixel)
            g.DrawImage(image, New Rectangle(w-sM.Right, t+sM.Top, sM.Right, h-t-sM.Height), New Rectangle(srcR.right - sM.Right, sM.Top, sM.Right, image.Height - sM.Height - 1), GraphicsUnit.Pixel)
            '// body
            g.DrawImage(image, New Rectangle(l+sM.Left, t+sM.Top, w-l-sM.Width, h-t-sM.Height), New Rectangle(sM.Left, sM.Top, image.Width-sM.Width-1, image.Height-sM.Height - 1), GraphicsUnit.Pixel)
        End Using
        Return bmp
    End Function

    '// create a colored rectangle in a the provided brush color
     Private Function DrawFilledRectangle(x As Integer, y As Integer, brush As Brush) As Image
	    Dim bmp As New Bitmap(x, y)
	    Using graph As Graphics = Graphics.FromImage(bmp)
		    Dim ImageSize As New Rectangle(0, 0, x, y)
		    graph.FillRectangle(brush, ImageSize)
	    End Using
	    Return bmp
    End Function

    '// reskin a panel control by setting its background via the contentImage property
    Public Sub ReskinPanelBackground(panel As PanelControl, skinCategory As Object, elementName As String, imageIndex As Integer)
        Dim image As Image = DrawButtonSkinGraphic(panel.Bounds, skinCategory, "Button", imageIndex)
        '// need to kill the border for the contentimage to fill the entire panel.
        panel.BorderStyle=DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        panel.ContentImage = image
    End Sub

#End Region

#Region "WIP"

#End Region
    '// Notes:
    '// There is a bug in the contextbutton class where contextButton.Size = 0
    '// contextButton.Height and contextButton.Width must be used instead.
End Module
