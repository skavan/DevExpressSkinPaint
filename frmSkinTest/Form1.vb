Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Tile

Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'reSkinButton
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        GridControl1.DataSource = GetData(10)
        'DevExpress.XtraEditors.WindowsFormsSettings.AllowDpiScale=True
        'DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware
        
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim element2 As SkinElement = SkinManager.GetSkinElement(SkinProductId.Ribbon, DevExpress.LookAndFeel.UserLookAndFeel.Default, "TabPanel")
        'PanelControl2.LookAndFeel.UseDefaultLookAndFeel=False
        PanelControl2.BackgroundImageLayout = ImageLayout.Stretch
        PanelControl2.BackgroundImage = element2.Image.Image

        'PanelControl2.Appearance.Options.UseImage=True
        LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        Debug.Print("Click")
    End Sub

    Private Sub TileView1_ContextButtonCustomize(sender As Object, e As TileViewContextButtonCustomizeEventArgs) Handles TileView1.ContextButtonCustomize
        Dim row As DataRowView = TryCast(TileView1.GetRow(e.RowHandle), DataRowView)
        Dim check As Boolean = CBool(row.Row("Check"))
        e.Item.Visibility = If(check, DevExpress.Utils.ContextItemVisibility.Visible, DevExpress.Utils.ContextItemVisibility.Hidden)
    End Sub

    Private Function GetData(rows As Integer) As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Info", GetType(String))
        dt.Columns.Add("Check", GetType(Boolean))
        For i As Integer = 0 To rows - 1
            dt.Rows.Add(i, "Info" & i, i Mod 2 = 0)
        Next
        Return dt
    End Function

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim x As ContextItem = TileView1.ContextButtons(0)
        
        Dim y As DevExpress.XtraGrid.Columns.TileViewColumn = TileView1.Columns("colButton")
        'As DevExpress.XtraGrid.Columns.GridColumn 
        Dim z As TileViewItemElement= GetTileElement("colButton")
        Debug.Print("XX")
        y.Width=32
        
        
        x.Size = New Size(12,12)
        LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
    End Sub

    Private Function GetTileElement(colName As String) As TileViewItemElement
        For each element As TileViewItemElement In TileView1.TileTemplate
            If element.Column.Name = colName Then Return element
        Next
        Return Nothing
    End Function

    Private Sub reSkinButton
        Dim currentSkin As DevExpress.Skins.Skin
        Dim element As DevExpress.Skins.SkinElement
        Dim elementName As String
        currentSkin = DevExpress.Skins.CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default)
        elementName = DevExpress.Skins.CommonSkins.SkinButton

        element = currentSkin(elementName)

        Dim image As Image = element.Image.GetImages.Images(4)
        Dim newImage = image.FromFile("d:\skin.png")
        element.Image.SetImage(newImage,"elementName")
        LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim currentSkin As DevExpress.Skins.Skin
        Dim element As DevExpress.Skins.SkinElement
        Dim elementName As String

        'currentSkin = DevExpress.Skins.GridSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default)
        'elementName = DevExpress.Skins.GridSkins.SkinHeader

        currentSkin = DevExpress.Skins.CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default)
        elementName = DevExpress.Skins.CommonSkins.SkinButton

        element = currentSkin(elementName)

        Dim image As Image = element.Image.GetImages.Images(4)
        Dim newImage = image.FromFile("d:\skin.png")
        element.Image.SetImage(newImage,"elementName")
        'Dim img2 = New Bitmap(Image, New Size(PanelControl2.Bounds.Width, PanelControl2.Bounds.Height)) 'ctl.Height /scaleFactor.Height

        Dim rr As Rectangle = PanelControl2.Bounds
        'rr.Inflate(1,1)
        'element.Image.GetImages(0)
        'PanelControl2.ContentImage = Img2
        'PanelControl2.CreateGraphics.DrawImage(image, rr, New Rectangle(3,3, image.Width-8, image.Height - 8), GraphicsUnit.Pixel)
        'Graphics.DrawImage(bmp, rr, New Rectangle(1, 1, bmp.Width - 3, bmp.Height - 2), GraphicsUnit.Pixel)
        'PanelControl2.BackgroundImage = image
        LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        
        Dim tgtRect As Rectangle = rr
        Dim l As Integer = tgtRect.Left
        Dim r As Integer = tgtRect.Right
        Dim w As Integer = tgtRect.Width
        Dim t As Integer = tgtRect.Top
        Dim b As Integer = tgtRect.Bottom
        Dim h As Integer = tgtRect.Height

        'Dim images As DevExpress.Utils.ImageCollection = element.Image.GetImages()
        'bmp = images.Images(0)
    End Sub

    Private Sub PanelControl2_Paint(sender As Object, e As PaintEventArgs) Handles PanelControl2.Paint
        Dim currentSkin As DevExpress.Skins.Skin
        Dim element As DevExpress.Skins.SkinElement
        Dim elementName As String
        currentSkin = DevExpress.Skins.CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default)
        elementName = DevExpress.Skins.CommonSkins.SkinButton

        Dim image As Image
        element = currentSkin(elementName)
'        Dim newImage = image.FromFile("d:\skinbtn.png")
'        element.Image.SetImage(newImage,"elementName")
        image = element.Image.GetImages.Images(0)
'        image = newImage
        'element.Image.GetImage(false).Save("D:\skin.png", System.Drawing.Imaging.ImageFormat.Png)
        Dim rr As Rectangle = PanelControl2.Bounds
        'Dim core As Rectangle = rr.Inflate(-4,-4)
        
        rr.Inflate(-4,-4)
        Dim sizingMargins = element.Image.SizingMargins
        'e.Graphics.DrawImage(image, rr, New Rectangle(0 + sizingMargins.Left,0+ sizingMargins.Top, image.Width-sizingMargins.Width, image.Height - sizingMargins.Height), GraphicsUnit.Pixel)
        'e.Graphics.DrawImage(image, rr, New Rectangle(0 + sizingMargins.Left,0+ sizingMargins.Top, image.Width-sizingMargins.Width, image.Height - sizingMargins.Height), GraphicsUnit.Pixel)
        Dim image2 As Image = DrawFilledRectangle(128,128, Brushes.Yellow)
        DrawPanel3(e.Graphics, image, sizingMargins, PanelControl2)
    End Sub

    Private Sub DrawPanel3(g As Graphics, image As Image, sM As SkinPaddingEdges, panel As PanelControl)
        Dim tgtRect = panel.Bounds

        Dim l As Integer = 0
        Dim w As Integer = tgtRect.Width
        Dim t As Integer = 0
        Dim h As Integer = tgtRect.Height

        Dim srcR As Rectangle = New Rectangle(0,0, image.Width, image.Height)
        
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
 
    End Sub

    Private Sub DrawPanel2(g As Graphics, image As Image, sM As SkinPaddingEdges, panel As PanelControl)
        Dim tgtRect = panel.Bounds
        Dim l As Integer = 0
        Dim w As Integer = tgtRect.Width
        Dim t As Integer = 0
        Dim h As Integer = tgtRect.Height


        Dim srcR As Rectangle = New Rectangle(0,0, image.Width-1, image.Height-1)
        
        g.DrawImage(image, New Rectangle(l, t, sM.Left, sM.top), New Rectangle(0, 0, sM.Left, sM.Top), GraphicsUnit.Pixel)
        g.DrawImage(image, New Rectangle(l, h-sM.Bottom, sM.Left, sM.Bottom), New Rectangle(0, srcR.Bottom-sM.Bottom + 1, sM.Left, sM.Bottom), GraphicsUnit.Pixel)
        g.DrawImage(image, New Rectangle(w-sM.Right,t,sM.Right,sM.Top), New Rectangle(srcR.Right- sM.right + 1, 0, sM.Right, sM.Top), GraphicsUnit.Pixel)
        g.DrawImage(image, New Rectangle(w-sM.Right, h-sM.Bottom , sM.Right, sM.Bottom), New Rectangle(srcR.Right-sM.Right + 1, srcR.Bottom - sM.Bottom + 1, sM.Right, sM.Bottom), GraphicsUnit.Pixel)

        g.DrawImage(image, New Rectangle(l+sM.Left, t, w-l-sM.Width, sM.Top), New Rectangle(sM.Left, 0, image.Width-sM.Width - 1, sM.Top), GraphicsUnit.Pixel)
        g.DrawImage(image, New Rectangle(l+sM.Left, h-sM.Bottom, w-l-sM.Width, sM.Bottom), New Rectangle(sM.Left, srcR.Bottom-sM.Bottom + 1, image.Width-sM.Width - 1, sM.Bottom), GraphicsUnit.Pixel)
        g.DrawImage(image, New Rectangle(l, t+sM.Top, sM.Left, h-t-sM.Height), New Rectangle(0, sM.Top, sM.Left, image.Height - sM.Height - 1), GraphicsUnit.Pixel)
        g.DrawImage(image, New Rectangle(w-sM.Right, t+sM.Top, sM.Right, h-t-sM.Height), New Rectangle(srcR.right - sM.Right + 1, sM.Top, sM.Right, image.Height - sM.Height - 1), GraphicsUnit.Pixel)

        g.DrawImage(image, New Rectangle(l+sM.Left, t+sM.Top, w-l-sM.Width, h-t-sM.Height), New Rectangle(sM.Left, sM.Top, image.Width-sM.Width-1, image.Height-sM.Height-1), GraphicsUnit.Pixel)
 
    End Sub




    Private Sub DrawPanel(g As Graphics, image As Image, sM As SkinPaddingEdges, panel As PanelControl)
        Dim tgtRect = panel.Bounds
        'tgtRect.Inflate(-1,-1)
        'Dim l As Integer = tgtRect.Left
        'Dim r As Integer = tgtRect.Right
        'Dim t As Integer = tgtRect.Top
        'Dim b As Integer = tgtRect.Bottom
        Dim l As Integer = 0
        Dim r As Integer = (tgtRect.Width)
        Dim t As Integer = 0
        Dim b As Integer = tgtRect.Height


        Dim srcR As Rectangle = New Rectangle(0,0, image.Width-1, image.Height-1)

        '// top left - no scaling
        'g.DrawImage(image, New Rectangle(l, t , l + sM.Left, t + sM.Top), New Rectangle(0, 0, sM.Left, sM.Top), GraphicsUnit.Pixel)
        'g.DrawImage(image, New Rectangle(r-sM.Right, t , r, t + sM.Top), New Rectangle(srcR.Right - sM.Right, 0, srcR.Right, sM.Top), GraphicsUnit.Pixel)
        'g.DrawImage(image, New Rectangle(l, b-sM.Bottom , l + sM.Left, b), New Rectangle(0, srcR.bottom-sM.Bottom, sM.Left, srcR.Bottom), GraphicsUnit.Pixel)
        'g.DrawImage(image, New Rectangle(r-sM.Right, b-sM.Bottom , r, b), New Rectangle(srcR.Right - sM.Right, srcR.bottom-sM.Bottom, srcR.Right, srcR.Bottom), GraphicsUnit.Pixel)

        Dim rr As Rectangle = New Rectangle(0,0,3,3)
        g.DrawImage(image, New Rectangle(l, t, 4, 4), New Rectangle(0, 0, 4, 4), GraphicsUnit.Pixel)
        g.DrawImage(image, New Rectangle(l, b-4 , 4, 4), New Rectangle(0, srcR.Bottom-4+1, 4, 4), GraphicsUnit.Pixel)
        g.DrawImage(image, New Rectangle(r-4,t,4,4), New Rectangle(srcR.Right- 4 + 1, 0, 4, 4), GraphicsUnit.Pixel)
        g.DrawImage(image, New Rectangle(r-4, b-4 , 4, 4), New Rectangle(srcR.Right-4+1, srcR.Bottom-4+1, 4, 4), GraphicsUnit.Pixel)

        g.DrawImage(image, New Rectangle(l+4, t, r-l-8, 4), New Rectangle(4, 0, image.Width-8-1, 4), GraphicsUnit.Pixel)
        g.DrawImage(image, New Rectangle(l+4, b-4, r-l-8, 4), New Rectangle(4, srcR.Bottom-4+1, image.Width-8-1, 4), GraphicsUnit.Pixel)
        g.DrawImage(image, New Rectangle(l, t+4, 4, b-t-8), New Rectangle(0, 4, 4, image.Height-8-1), GraphicsUnit.Pixel)
        g.DrawImage(image, New Rectangle(r-4, t+4, 4, b-t-8), New Rectangle(srcR.right-4+1, 4, 4, image.Height-8-1), GraphicsUnit.Pixel)

        g.DrawImage(image, New Rectangle(l+4, t+4, r-l-8, b-t-8), New Rectangle(4, 4, image.Width-8-1, image.Height-8-1), GraphicsUnit.Pixel)
 
    End Sub

    Private Function DrawFilledRectangle(x As Integer, y As Integer, brush As Brush) As Image
	Dim bmp As New Bitmap(x, y)
	Using graph As Graphics = Graphics.FromImage(bmp)
		Dim ImageSize As New Rectangle(0, 0, x, y)
		graph.FillRectangle(brush, ImageSize)
	End Using
	Return bmp
End Function

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        PanelControl2.Refresh
    End Sub
End Class
