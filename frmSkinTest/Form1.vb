Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraGrid.Views.Tile

Public Class Form1
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
    Dim scaleFactor As SizeF = New SizeF(0.666667, 0.6667)
    Dim commonSkins As New DevExpress.Skins.CommonSkins
    Dim WithEvents skinEditorButtonPainter As SkinEditorButtonPainter
    Dim WithEvents activeContextItem As ContextItem
    Dim WithEvents ContextMenu1 As New ContextMenu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetActiveSkin(Me)
        GridControl1.DataSource = GetData(10)
    End Sub

    '//attempt to customize button, hiding it based on a column view
    Private Sub TileView1_ContextButtonCustomize(sender As Object, e As TileViewContextButtonCustomizeEventArgs) Handles TileView1.ContextButtonCustomize
        Dim row As DataRowView = TryCast(TileView1.GetRow(e.RowHandle), DataRowView)
        Dim check As Boolean = CBool(row.Row("Check"))
        e.Item.Visibility = If(check, DevExpress.Utils.ContextItemVisibility.Visible, DevExpress.Utils.ContextItemVisibility.Hidden)      
        TileView1.ContextButtonOptions.NormalStateOpacity=0.5
        TileView1.ContextButtonOptions.HoverStateOpacity=1
        'Debug.Print("Context Item Update:" & e.RowHandle)
        
        'e.Item
    End Sub

    Private Sub TileView1_ContextButtonClick(sender As Object, e As ContextItemClickEventArgs) Handles TileView1.ContextButtonClick
        Dim item As ContextItem = e.Item
        'item.BeginUpdate
        'item.Enabled=True
        'item.EndUpdate
        Dim tileItem As TileItem = e.DataItem
        Debug.Print("Click:" & e.DataItem.RowHandle)
        'ContextMenu1.Show(Me, System.Windows.Forms.Cursor.Position)
        PopupMenu1.ShowPopup(System.Windows.Forms.Cursor.Position)
    End Sub

    '// fill in dummy data
    Private Function GetData(rows As Integer) As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Info", GetType(String))
        dt.Columns.Add("Check", GetType(Boolean))
        dt.Columns.Add("Art", GetType(Image))
        For i As Integer = 0 To rows - 1
            dt.Rows.Add(i, "This is Item #" & i, i Mod 2 = 0, GetRandomDevExpressImage)
        Next
        Return dt
    End Function

#Region "examples via buttons clicks"

    '// demonstrate resizing of a contextbutton glyph    
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim x As DevExpress.Utils.ContextButton = TileView1.ContextButtons(0)       
        '// for speed, consider getting the image from an imagelist
        Dim y As Integer = x.Glyph.Height
        'IC1.Images(2)
        'x.Glyph = RescaleImageByScaleFactor(GetDevExpressImage("office2013/navigation/next_32x32.png"),x.Width, x.Height,scaleFactor)
        x.Glyph = RescaleImageByScaleFactor(IC1.Images(1),x.Width, x.Height,scaleFactor)
        x.Width=x.Glyph.Width
        x.Height = x.Glyph.Height
        
    End Sub

      '// resize form
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        'Me.AutoScaleDimensions = new System.Drawing.SizeF(72F, 72F)
        ScaleForm(Me, New SizeF(1.5,1.5))
        ScaleFonts(Me, Me.Font.Size*1.5,False)
        'Me.ForceRefresh
    End Sub 

    '// force load of replacement skin element image
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        SetSkinElementImage(commonSkins,"Button","D:\Skin.png")
        ForceDefaultLookAndFeelChanged
    End Sub

    '// show the full skinImage
    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Dim skinImage As SkinImage = GetSkinElementSkinImage(commonSkins,"Button")
        PE1.Image = skinImage.Image
    End Sub

    '// demonstrate the extract image from skinimage method
    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Dim skinImage As SkinImage = GetSkinElementSkinImage(commonSkins,"Button")
        PE1.Image = GetImageFromSkinImage(skinImage, 0)
    End Sub

    '// reskin a panel control by setting its background via the contentImage property
    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        ReskinPanelBackground(PanelControl3, commonSkins, "Button", 0)
    End Sub

#End Region

#Region "Panel Control Custom Painting, Hover, Click Background Customization Examples"

    '// example showing the painting of an element from a specified skinelement image
    Private Sub PanelControl2_Paint(sender As Object, e As PaintEventArgs) Handles PanelControl2.Paint
        e.Graphics.DrawImage(DrawButtonSkinGraphic(PanelControl2.Bounds, commonSkins, "Button", 0),0,0)       
    End Sub

    Private Sub PanelControl3_MouseHover(sender As Object, e As EventArgs) Handles PanelControl3.MouseHover
        'ReskinPanelBackground(PanelControl3, commonSkins, "Button", 1)
    End Sub

    Private Sub PanelControl3_MouseLeave(sender As Object, e As EventArgs) Handles PanelControl3.MouseLeave
        ReskinPanelBackground(PanelControl3, commonSkins, "Button", 0)
    End Sub

    Private Sub PanelControl3_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelControl3.MouseMove
        
        If e.Button= MouseButtons.None Then
            ReskinPanelBackground(PanelControl3, commonSkins, "Button", 1)
        Debug.Print("Panel Move")
        End If
        
    End Sub

    Private Sub PanelControl3_Click(sender As Object, e As EventArgs) Handles PanelControl3.Click
        ReskinPanelBackground(PanelControl3, commonSkins, "Button", 4)
        Debug.Print("Panel Click")
    End Sub

    Private Sub PanelControl3_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelControl3.MouseDown
        ReskinPanelBackground(PanelControl3, commonSkins, "Button", 4)
        Debug.Print("Panel MouseDown")
    End Sub

    Private Sub PopupMenu1_Popup(sender As Object, e As EventArgs) Handles PopupMenu1.Popup
        
    End Sub

    Public Sub AddContextMenu()
        'Dim mnuContextMenu as New ContextMenu()
        'Me.ContextMenu = mnuContextMenu
        Dim mnuItemNew as New MenuItem()
        Dim mnuItemOpen as New MenuItem()
        mnuItemNew.Text = "&New"
        mnuItemOpen.Text = "&Open"
        ContextMenu1.MenuItems.Add(mnuItemNew)
        ContextMenu1.MenuItems.Add(mnuItemOpen)
        ContextMenu1.MenuItems.Add("&Close")

    End Sub

    Private Sub PanelControl2_Click(sender As Object, e As EventArgs) Handles PanelControl2.Click
        Dim image As Image = GetRandomDevExpressImage
    End Sub



#End Region

#Region "WIP"


    '   Protected Overrides Sub SkinEditorButtonPainter.UpdateButtonInfo(e As ObjectInfoArgs)
    'Dim ee As EditorButtonObjectInfoArgs = TryCast(e, EditorButtonObjectInfoArgs)
    '       If Not ee.BuiltIn Then
    '           ee.Transparent = True
    '           ee.FillBackground = False
    '       End If
    '       info.Bounds = ee.Bounds
    '       info.Element = GetSkinElement(ee, ee.Button.Kind)
    '       'THESE LINES
    '       Dim elem As SkinElement = info.Element.Copy(info.Element.Owner, "CustomButton")
    '       elem.SetActualImage(Button.CustomImage, True)
    '       info.Element = elem
    '       '
    '       info.State = ee.State
    '       info.Cache = ee.Cache
    '       info.ImageIndex = CalcImageIndex(ee.Button.Kind, ee.State)
    '   End Sub
#End Region

End Class
