<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim ContextButton1 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Me.colID = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colInfo = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colCheck = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colButton = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.TileView1 = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.RepositoryItemButtonEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl1.SuspendLayout
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TileView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PanelControl2,System.ComponentModel.ISupportInitialize).BeginInit
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
        ContextButton1.Alignment = DevExpress.Utils.ContextItemAlignment.CenterFar
        ContextButton1.Caption = "Button"
        ContextButton1.Glyph = CType(resources.GetObject("ContextButton1.Glyph"),System.Drawing.Image)
        ContextButton1.Height = 32
        ContextButton1.Id = New System.Guid("b5701d27-0b29-4276-a571-274cf2345073")
        ContextButton1.MaxHeight = 32
        ContextButton1.MaxWidth = 32
        ContextButton1.Name = "ContextButton"
        ContextButton1.Padding = New System.Windows.Forms.Padding(0, 0, 6, 0)
        ContextButton1.Visibility = DevExpress.Utils.ContextItemVisibility.Visible
        ContextButton1.Width = 32
        Me.TileView1.ContextButtons.Add(ContextButton1)
        Me.TileView1.GridControl = Me.GridControl1
        Me.TileView1.Name = "TileView1"
        Me.TileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TileView1.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        TileViewItemElement1.Column = Me.colID
        TileViewItemElement1.Text = "colID"
        TileViewItemElement2.Column = Me.colInfo
        TileViewItemElement2.Text = "colInfo"
        TileViewItemElement3.Column = Me.colCheck
        TileViewItemElement3.Text = "colCheck"
        TileViewItemElement4.Column = Me.colButton
        TileViewItemElement4.Image = CType(resources.GetObject("TileViewItemElement4.Image"),System.Drawing.Image)
        TileViewItemElement4.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        TileViewItemElement4.ImageSize = New System.Drawing.Size(32, 32)
        TileViewItemElement4.StretchHorizontal = true
        TileViewItemElement4.StretchVertical = true
        TileViewItemElement4.Text = "colButton"
        Me.TileView1.TileTemplate.Add(TileViewItemElement1)
        Me.TileView1.TileTemplate.Add(TileViewItemElement2)
        Me.TileView1.TileTemplate.Add(TileViewItemElement3)
        Me.TileView1.TileTemplate.Add(TileViewItemElement4)
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
        Me.SimpleButton1.Text = "Test"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(757, 398)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(185, 58)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "SimpleButton2"
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
        'SimpleButton6
        '
        Me.SimpleButton6.Location = New System.Drawing.Point(757, 535)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(185, 58)
        Me.SimpleButton6.TabIndex = 5
        Me.SimpleButton6.Text = "SimpleButton6"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144!, 144!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1311, 977)
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
End Class
