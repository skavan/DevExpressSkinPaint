Imports System.Dynamic
Imports System.IO
Imports System.Reflection
Imports System.Xml.Serialization
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Tile
Imports DevExpress.XtraGrid.Views.Tile.ViewInfo


Module DXUtilities

#Region "General Utilities"

    '// utility function to recurse through all controls and find one matching a name
    Public Function GetControlByName(ctl As Control, name As String) As Control
        If ctl.Name = name Then Return ctl
        For Each ctlKid As Control In ctl.Controls
            Dim ctlFound As Control = GetControlByName(ctlKid, name)
            If ctlFound IsNot Nothing Then Return ctlFound
        Next
        Return Nothing
    End Function

    '// utility function - to get a TileViewItem element from a TileView by colName --- there must be a better way!
    Public Function GetTileElement(view As TileView, colName As String) As TileViewItemElement
        For Each element As TileViewItemElement In view.TileTemplate
            If element.Column.Name = colName Then Return element
        Next
        Return Nothing
    End Function

    '// serialize a MusicItem List
    Public Sub SerializeMusicItemLibrary(mList As List(Of MusicItem), filepath As String)

        Dim ser As XmlSerializer = New XmlSerializer(GetType(List(Of MusicItem)))
        Using writer As TextWriter = New StreamWriter(filepath)
            ser.Serialize(writer, mList)
        End Using
    End Sub

    '// deserialize a MusicItem List
    Public Function DeSerializeMusicItemLibrary(filepath As String) As List(Of MusicItem)

        Dim ser As XmlSerializer = New XmlSerializer(GetType(List(Of MusicItem)))
        Dim items As New List(Of MusicItem)
        Try
            Using reader As TextReader = New StreamReader(filepath)
                items = ser.Deserialize(reader)
            End Using
        Catch ex As Exception

        End Try

        Return items
    End Function
     '// deserialize a MusicItem List
    Public Function DeSerializeMusicItemLibrary(data As String, isResource As Boolean) As Dictionary(Of String, MusicItem)
        Dim ser As XmlSerializer = New XmlSerializer(GetType(List(Of MusicItem)))
        Dim items As New List(Of MusicItem)
        Try
            Using reader As TextReader = New StringReader(data)
                items = ser.Deserialize(reader)
            End Using
        Catch ex As Exception

        End Try
        Dim dic As New Dictionary(Of String, MusicItem)

        For Each item As MusicItem In items
            dic.Add(item.ID, item)
        Next

        Return dic
    End Function

#End Region

#Region "Skin Related"
    '// force a refresh of all DevExpress stuff.
    Public Sub ForceDefaultLookAndFeelChanged
        LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
    End Sub

    '// get the skinImage from a given element. Note: use SkinEditor to find the elementName
    Public Function GetSkinElementSkinImage(activeLookAndFeel As UserLookAndFeel, skinCategory As Object, elementName As String) As SkinImage
        'Dim currentSkin As DevExpress.Skins.Skin = skinCategory.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default)
        Dim currentSkin As DevExpress.Skins.Skin = skinCategory.GetSkin(activeLookAndFeel)
        Dim element As DevExpress.Skins.SkinElement = currentSkin(elementName)
        Return element.Image
    End Function

    '// set the IMAGE in a skinImage for a given element. Note, this may need to be a vertical imagestrip to get desired results
    '// look at the element in SkinEditor, else you will get odd results!
    Public Sub SetSkinElementImage(activeLookAndFeel As UserLookAndFeel, skinCategory As Object, elementName As String, image As Image, Optional imageName As String = "")
        Dim skinImage As SkinImage = GetSkinElementSkinImage(activeLookAndFeel, skinCategory, elementName)
        If imageName = "" Then imageName = skinImage.ImageName
        skinImage.SetImage(image, imageName)
        skinImage.SaveImage
    End Sub
    '// override to Set the IMAGE in a skinImage from file
    Public Sub SetSkinElementImage(activeLookAndFeel As UserLookAndFeel, skinCategory As Object, elementName As String, filename As String, Optional imageName As String = "")
        Dim image As Image = Image.FromFile(filename)
        SetSkinElementImage(activeLookAndFeel, skinCategory, elementName, image, imageName)
    End Sub

    '// save the skinImage from a given element. Note: use SkinEditor to find the elementName
    Public Sub SaveSkinElementSkinImage(activeLookAndFeel As UserLookAndFeel, skinCategory As Object, elementName As String, filename As String)
        Dim skinImage As SkinImage = GetSkinElementSkinImage(activeLookAndFeel, skinCategory, elementName)
        skinImage.Image.Save(filename)
    End Sub

    '// There seems to be a bug in skinImage.GetImages.Images(index) not getting updated. 
    '// This is a (complex) workaround
    Public Function GetImageFromSkinImage(skinImage As SkinImage, index As Integer) As Image
        Dim x As Integer = 0
        Dim w As Integer = skinImage.Image.Width
        Dim h As Integer = skinImage.Image.Height / skinImage.ImageCount
        Dim y As Integer = (index * h)
        Dim bmp As New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(skinImage.Image, New Rectangle(0, 0, w, h), New Rectangle(x, y, w, h), GraphicsUnit.Pixel)
        End Using
        Return bmp
    End Function

#End Region

#Region "Image Retrieval & Rescaling"

    '// make the project dpi aware.
    Public Sub SetModeDPIAware
        DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware
    End Sub

    '// get an image from the DevExpress Icon Library -- quite slow. Consider using an imageList for speed
    Public Function GetDevExpressImage(imageName As String) As Image
        Dim iconImage As Image = DevExpress.Images.ImageResourceCache.Default.GetImage(imageName)
        Return iconImage
    End Function

    '// get a random 32x32 image from the ImageLibrary. Slow.
    Public Function GetRandomDevExpressImage() As Image
        Dim image As Image
        Do
            Dim numImages As Integer = 32 'DevExpress.Images.ImageResourceCache.Default.GetAllResourceKeys.Count
            Dim X As Integer = CInt(Math.Ceiling(Rnd() * numImages)) + 256
            Dim key As String = DevExpress.Images.ImageResourceCache.Default.GetAllResourceKeys(X)
            image = DevExpress.Images.ImageResourceCache.Default.GetImage(key)
        Loop Until image.Width = 32
        Return image
    End Function

    '// three overloads. the first doesn't use a scale factor. i.e. it just loads the image
    Public Function RescaleImageByScaleFactor(srcImage As Image, targetSize As Size) As Image
        Return RescaleImageByScaleFactor(srcImage, targetSize.Width, targetSize.Height, New SizeF(1, 1))
    End Function

    '// get a rescaled image using a Size for target Size
    Public Function RescaleImageByScaleFactor(srcImage As Image, targetSize As Size, scaleFactor As SizeF) As Image
        Return RescaleImageByScaleFactor(srcImage, targetSize.Width, targetSize.Height, scaleFactor)
    End Function

    '// get a rescaled image using Width and Height for target Size
    Public Function RescaleImageByScaleFactor(srcImage As Image, width As Integer, height As Integer, scaleFactor As SizeF) As Image
        Return New Bitmap((srcImage), New Size(width * scaleFactor.Width, height * scaleFactor.Height))
    End Function

    '// Rescale an image using a padding to calculate size offsets. i.e. pass a control size with padding and the image will be shrunk to respect the padding.
    '// use for controls that don't apply padding to images
    Public Function RescaleImageByPadding(srcImage As Image, targetSize As Size, padding As Padding) As Image
        Return RescaleImageByPadding(srcImage, targetSize.Width, targetSize.Height, padding)
    End Function

    Public Function RescaleImageByPadding(srcImage As Image, width As Integer, height As Integer, padding As Padding) As Image
        Return New Bitmap((srcImage), New Size(width - (padding.Left + padding.Right), height - (padding.Top + padding.Bottom)))
    End Function

#End Region

#Region "Graphics and Painting Related"

    '// given a target size, a skinelement and a target image index, construct a graphic
    Public Function DrawButtonSkinGraphic(activeLookAndFeel As UserLookAndFeel, tgtRect As Rectangle, skinCategory As Object, elementName As String, imageIndex As Integer) As Image
        Dim skinImage As SkinImage = GetSkinElementSkinImage(activeLookAndFeel, skinCategory, elementName)
        'Dim image As Image = skinImage.GetImages.Images(imageIndex)
        Dim image As Image = GetImageFromSkinImage(skinImage, imageIndex)
        Dim sM As SkinPaddingEdges = skinImage.SizingMargins
        Dim srcR As Rectangle = New Rectangle(0, 0, image.Width, image.Height)
        Dim l As Integer = 0
        Dim w As Integer = tgtRect.Width
        Dim t As Integer = 0
        Dim h As Integer = tgtRect.Height

        Dim bmp As New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            '// corner squares
            g.DrawImage(image, New Rectangle(l, t, sM.Left, sM.Top), New Rectangle(0, 0, sM.Left, sM.Top), GraphicsUnit.Pixel)
            g.DrawImage(image, New Rectangle(l, h - sM.Bottom, sM.Left, sM.Bottom), New Rectangle(0, srcR.Bottom - sM.Bottom, sM.Left, sM.Bottom), GraphicsUnit.Pixel)
            g.DrawImage(image, New Rectangle(w - sM.Right, t, sM.Right, sM.Top), New Rectangle(srcR.Right - sM.Right, 0, sM.Right, sM.Top), GraphicsUnit.Pixel)
            g.DrawImage(image, New Rectangle(w - sM.Right, h - sM.Bottom, sM.Right, sM.Bottom), New Rectangle(srcR.Right - sM.Right, srcR.Bottom - sM.Bottom, sM.Right, sM.Bottom), GraphicsUnit.Pixel)

            '// edges
            g.DrawImage(image, New Rectangle(l + sM.Left, t, w - l - sM.Width, sM.Top), New Rectangle(sM.Left, 0, image.Width - sM.Width - 1, sM.Top), GraphicsUnit.Pixel)
            g.DrawImage(image, New Rectangle(l + sM.Left, h - sM.Bottom, w - l - sM.Width, sM.Bottom), New Rectangle(sM.Left, srcR.Bottom - sM.Bottom, image.Width - sM.Width - 1, sM.Bottom), GraphicsUnit.Pixel)
            g.DrawImage(image, New Rectangle(l, t + sM.Top, sM.Left, h - t - sM.Height), New Rectangle(0, sM.Top, sM.Left, image.Height - sM.Height - 1), GraphicsUnit.Pixel)
            g.DrawImage(image, New Rectangle(w - sM.Right, t + sM.Top, sM.Right, h - t - sM.Height), New Rectangle(srcR.Right - sM.Right, sM.Top, sM.Right, image.Height - sM.Height - 1), GraphicsUnit.Pixel)
            '// body
            g.DrawImage(image, New Rectangle(l + sM.Left, t + sM.Top, w - l - sM.Width, h - t - sM.Height), New Rectangle(sM.Left, sM.Top, image.Width - sM.Width - 1, image.Height - sM.Height - 1), GraphicsUnit.Pixel)
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
    Public Sub ReskinPanelBackground(activeLookAndFeel As UserLookAndFeel, panel As PanelControl, skinCategory As Object, elementName As String, imageIndex As Integer)
        Dim image As Image = DrawButtonSkinGraphic(activeLookAndFeel, panel.Bounds, skinCategory, "Button", imageIndex)
        '// need to kill the border for the contentimage to fill the entire panel.
        panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        panel.ContentImage = image
    End Sub

#End Region

#Region "TileView Specific"
    Public Function GetVisibleRows(view As TileView) As Dictionary(Of Integer, DevExpress.XtraGrid.Views.Tile.TileViewItem)
        Dim x As TileViewInfoCore = TryCast(TryCast(view.GetViewInfo(), ITileControl).ViewInfo, TileViewInfoCore)
        Return x.VisibleItems
    End Function
#End Region

End Module


