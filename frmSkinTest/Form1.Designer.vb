﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ContextButton2 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
        Dim TileViewItemElement5 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement6 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement7 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement8 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Me.colID = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colInfo = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colCheck = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colButton = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.TileView1 = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.IC1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.PE1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.RepositoryItemButtonEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl1.SuspendLayout
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TileView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PanelControl2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PanelControl3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.IC1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PE1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = true
        Me.colID.VisibleIndex = 0
        '
        'colInfo
        '
        Me.colInfo.Caption = "Info"
        Me.colInfo.FieldName = "Info"
        Me.colInfo.Name = "colInfo"
        Me.colInfo.Visible = true
        Me.colInfo.VisibleIndex = 1
        '
        'colCheck
        '
        Me.colCheck.Caption = "Check"
        Me.colCheck.FieldName = "Check"
        Me.colCheck.Name = "colCheck"
        Me.colCheck.Visible = true
        Me.colCheck.VisibleIndex = 2
        '
        'colButton
        '
        Me.colButton.Caption = "MyButton"
        Me.colButton.ColumnEdit = Me.RepositoryItemButtonEdit1
        Me.colButton.FieldName = "colButton"
        Me.colButton.Image = CType(resources.GetObject("colButton.Image"),System.Drawing.Image)
        Me.colButton.Name = "colButton"
        Me.colButton.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.colButton.Visible = true
        Me.colButton.VisibleIndex = 3
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = false
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "DevExpress Dark Style"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GridControl1)
        Me.PanelControl1.Controls.Add(Me.SimpleButton5)
        Me.PanelControl1.Location = New System.Drawing.Point(112, 303)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(6)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelControl1.Size = New System.Drawing.Size(624, 567)
        Me.PanelControl1.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(9, 76)
        Me.GridControl1.MainView = Me.TileView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Padding = New System.Windows.Forms.Padding(2)
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(606, 482)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TileView1})
        '
        'TileView1
        '
        Me.TileView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colInfo, Me.colCheck, Me.colButton})
        ContextButton2.Alignment = DevExpress.Utils.ContextItemAlignment.CenterFar
        ContextButton2.Glyph = CType(resources.GetObject("ContextButton2.Glyph"),System.Drawing.Image)
        ContextButton2.Height = 32
        ContextButton2.Id = New System.Guid("b5701d27-0b29-4276-a571-274cf2345073")
        ContextButton2.MaxHeight = 32
        ContextButton2.MaxWidth = 32
        ContextButton2.Name = "ContextButton"
        ContextButton2.Padding = New System.Windows.Forms.Padding(0, 0, 6, 0)
        ContextButton2.Visibility = DevExpress.Utils.ContextItemVisibility.Visible
        ContextButton2.Width = 32
        Me.TileView1.ContextButtons.Add(ContextButton2)
        Me.TileView1.GridControl = Me.GridControl1
        Me.TileView1.Name = "TileView1"
        Me.TileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TileView1.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        TileViewItemElement5.Column = Me.colID
        TileViewItemElement5.Text = "colID"
        TileViewItemElement6.Column = Me.colInfo
        TileViewItemElement6.Text = "colInfo"
        TileViewItemElement7.Column = Me.colCheck
        TileViewItemElement7.Text = "colCheck"
        TileViewItemElement8.Appearance.Hovered.ForeColor = System.Drawing.Color.Red
        TileViewItemElement8.Appearance.Hovered.Options.UseForeColor = true
        TileViewItemElement8.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        TileViewItemElement8.Appearance.Normal.Options.UseForeColor = true
        TileViewItemElement8.Appearance.Pressed.ForeColor = System.Drawing.Color.Fuchsia
        TileViewItemElement8.Appearance.Pressed.Options.UseForeColor = true
        TileViewItemElement8.Column = Me.colButton
        TileViewItemElement8.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        TileViewItemElement8.ImageSize = New System.Drawing.Size(32, 32)
        TileViewItemElement8.StretchHorizontal = true
        TileViewItemElement8.StretchVertical = true
        TileViewItemElement8.Text = "colButton"
        Me.TileView1.TileTemplate.Add(TileViewItemElement5)
        Me.TileView1.TileTemplate.Add(TileViewItemElement6)
        Me.TileView1.TileTemplate.Add(TileViewItemElement7)
        Me.TileView1.TileTemplate.Add(TileViewItemElement8)
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Dock = System.Windows.Forms.DockStyle.Top
        Me.SimpleButton5.Location = New System.Drawing.Point(9, 9)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Padding = New System.Windows.Forms.Padding(2)
        Me.SimpleButton5.Size = New System.Drawing.Size(606, 67)
        Me.SimpleButton5.TabIndex = 5
        Me.SimpleButton5.Text = "SimpleButton5"
        '
        'PanelControl2
        '
        Me.PanelControl2.Location = New System.Drawing.Point(115, 134)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelControl2.Size = New System.Drawing.Size(618, 67)
        Me.PanelControl2.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(757, 313)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(185, 60)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Glyph ReSize"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(757, 398)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(185, 58)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "Resize Form"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(757, 471)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(185, 58)
        Me.SimpleButton3.TabIndex = 3
        Me.SimpleButton3.Text = "SimpleButton3"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(115, 219)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(618, 67)
        Me.SimpleButton4.TabIndex = 4
        Me.SimpleButton4.Text = "SimpleButton4"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Location = New System.Drawing.Point(757, 535)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(185, 58)
        Me.SimpleButton6.TabIndex = 5
        Me.SimpleButton6.Text = "Reskin Panel BG"
        '
        'PanelControl3
        '
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Location = New System.Drawing.Point(115, 51)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelControl3.Size = New System.Drawing.Size(618, 67)
        Me.PanelControl3.TabIndex = 6
        '
        'IC1
        '
        Me.IC1.ImageStream = CType(resources.GetObject("IC1.ImageStream"),DevExpress.Utils.ImageCollectionStreamer)
        Me.IC1.InsertGalleryImage("next_32x32.png", "office2013/navigation/next_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/navigation/next_32x32.png"), 0)
        Me.IC1.Images.SetKeyName(0, "next_32x32.png")
        '
        'PE1
        '
        Me.PE1.Location = New System.Drawing.Point(974, 188)
        Me.PE1.Name = "PE1"
        Me.PE1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PE1.Size = New System.Drawing.Size(274, 681)
        Me.PE1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144!, 144!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1311, 977)
        Me.Controls.Add(Me.PE1)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.SimpleButton6)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.RepositoryItemButtonEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl1.ResumeLayout(false)
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TileView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PanelControl2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PanelControl3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.IC1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PE1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents TileView1 As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colInfo As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colCheck As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colButton As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents IC1 As DevExpress.Utils.ImageCollection
    Friend WithEvents PE1 As DevExpress.XtraEditors.PictureEdit
End Class
