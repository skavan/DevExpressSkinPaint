<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSkinUtilities
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
                If baseFont IsNot Nothing Then
                    baseFont.Dispose()
                    baseFont = Nothing
                End If
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
        Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSkinUtilities))
        Dim TileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Me.colArt = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.RepositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
        Me.PanelTop = New DevExpress.XtraEditors.PanelControl()
        Me.LabelTPH_L = New DevExpress.XtraEditors.LabelControl()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.PanelLeft = New DevExpress.XtraEditors.PanelControl()
        Me.Grid1 = New DevExpress.XtraGrid.GridControl()
        Me.TileView1 = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.PanelLeftXtraHeader = New DevExpress.XtraEditors.PanelControl()
        Me.LabelXtraItem = New DevExpress.XtraEditors.LabelControl()
        Me.LabelXtraItemRight = New DevExpress.XtraEditors.LabelControl()
        Me.ButtonXtraItem = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelLeftHeader = New DevExpress.XtraEditors.PanelControl()
        Me.LabelLPH_C = New DevExpress.XtraEditors.LabelControl()
        Me.ButtonLPH_R = New DevExpress.XtraEditors.SimpleButton()
        Me.ButtonLPH_L = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelRight = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.ButtonScaleTiles = New DevExpress.XtraEditors.SimpleButton()
        Me.ButtonFontMetrics = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelScaleForm = New DevExpress.XtraEditors.PanelControl()
        Me.ButtonScaleForm = New DevExpress.XtraEditors.SimpleButton()
        Me.ComboScaleForm = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.PanelResizeFonts = New DevExpress.XtraEditors.PanelControl()
        Me.ButtonResizeFonts = New DevExpress.XtraEditors.SimpleButton()
        Me.ComboFontSize = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ButtonResizeBtns = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelRightHeader = New DevExpress.XtraEditors.PanelControl()
        Me.LabelRPH_C = New DevExpress.XtraEditors.LabelControl()
        Me.ButtonRPH_R = New DevExpress.XtraEditors.SimpleButton()
        Me.ButtonRPH_L = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelCenter = New DevExpress.XtraEditors.PanelControl()
        Me.PanelCenterHeader = New DevExpress.XtraEditors.PanelControl()
        Me.LabelCPH_C = New DevExpress.XtraEditors.LabelControl()
        Me.colTitle = New DevExpress.XtraGrid.Columns.TileViewColumn()
        CType(Me.RepositoryItemImageEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PanelTop,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelTop.SuspendLayout
        CType(Me.PanelLeft,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelLeft.SuspendLayout
        CType(Me.Grid1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TileView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PanelLeftXtraHeader,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelLeftXtraHeader.SuspendLayout
        CType(Me.PanelLeftHeader,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelLeftHeader.SuspendLayout
        CType(Me.PanelRight,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelRight.SuspendLayout
        CType(Me.PanelScaleForm,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelScaleForm.SuspendLayout
        CType(Me.ComboScaleForm.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PanelResizeFonts,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelResizeFonts.SuspendLayout
        CType(Me.ComboFontSize.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PanelRightHeader,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelRightHeader.SuspendLayout
        CType(Me.PanelCenter,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelCenter.SuspendLayout
        CType(Me.PanelCenterHeader,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelCenterHeader.SuspendLayout
        Me.SuspendLayout
        '
        'colArt
        '
        Me.colArt.FieldName = "colArt"
        Me.colArt.Name = "colArt"
        Me.colArt.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colArt.Visible = true
        Me.colArt.VisibleIndex = 0
        '
        'RepositoryItemImageEdit1
        '
        Me.RepositoryItemImageEdit1.AutoHeight = false
        Me.RepositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageEdit1.Name = "RepositoryItemImageEdit1"
        '
        'PanelTop
        '
        Me.PanelTop.Controls.Add(Me.LabelTPH_L)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1215, 97)
        Me.PanelTop.TabIndex = 0
        '
        'LabelTPH_L
        '
        Me.LabelTPH_L.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelTPH_L.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelTPH_L.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelTPH_L.AutoEllipsis = true
        Me.LabelTPH_L.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelTPH_L.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelTPH_L.Location = New System.Drawing.Point(3, 3)
        Me.LabelTPH_L.Margin = New System.Windows.Forms.Padding(6)
        Me.LabelTPH_L.Name = "LabelTPH_L"
        Me.LabelTPH_L.Padding = New System.Windows.Forms.Padding(6)
        Me.LabelTPH_L.Size = New System.Drawing.Size(417, 91)
        Me.LabelTPH_L.TabIndex = 3
        Me.LabelTPH_L.Text = "Panel Top Main Header"
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "DevExpress Dark Style"
        '
        'PanelLeft
        '
        Me.PanelLeft.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.PanelLeft.Appearance.Options.UseBorderColor = true
        Me.PanelLeft.Controls.Add(Me.Grid1)
        Me.PanelLeft.Controls.Add(Me.PanelLeftXtraHeader)
        Me.PanelLeft.Controls.Add(Me.PanelLeftHeader)
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Location = New System.Drawing.Point(0, 97)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(440, 652)
        Me.PanelLeft.TabIndex = 1
        '
        'Grid1
        '
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.Location = New System.Drawing.Point(3, 121)
        Me.Grid1.MainView = Me.TileView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemImageEdit1})
        Me.Grid1.Size = New System.Drawing.Size(434, 528)
        Me.Grid1.TabIndex = 3
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TileView1})
        '
        'TileView1
        '
        Me.TileView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.TileView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colArt, Me.colTitle})
        Me.TileView1.GridControl = Me.Grid1
        Me.TileView1.Name = "TileView1"
        Me.TileView1.OptionsTiles.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.TileView1.OptionsTiles.IndentBetweenItems = 3
        Me.TileView1.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(6)
        Me.TileView1.OptionsTiles.ItemSize = New System.Drawing.Size(300, 64)
        Me.TileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TileView1.OptionsTiles.Padding = New System.Windows.Forms.Padding(3)
        Me.TileView1.OptionsTiles.ShowGroupText = false
        TileViewItemElement1.Column = Me.colArt
        TileViewItemElement1.Image = CType(resources.GetObject("TileViewItemElement1.Image"),System.Drawing.Image)
        TileViewItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileViewItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch
        TileViewItemElement1.ImageSize = New System.Drawing.Size(48, 48)
        TileViewItemElement1.Text = "colArt"
        TileViewItemElement2.Column = Me.colTitle
        TileViewItemElement2.Text = "colTitle"
        TileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileViewItemElement2.TextLocation = New System.Drawing.Point(60, 0)
        Me.TileView1.TileTemplate.Add(TileViewItemElement1)
        Me.TileView1.TileTemplate.Add(TileViewItemElement2)
        '
        'PanelLeftXtraHeader
        '
        Me.PanelLeftXtraHeader.Controls.Add(Me.LabelXtraItem)
        Me.PanelLeftXtraHeader.Controls.Add(Me.LabelXtraItemRight)
        Me.PanelLeftXtraHeader.Controls.Add(Me.ButtonXtraItem)
        Me.PanelLeftXtraHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLeftXtraHeader.Location = New System.Drawing.Point(3, 57)
        Me.PanelLeftXtraHeader.Name = "PanelLeftXtraHeader"
        Me.PanelLeftXtraHeader.Size = New System.Drawing.Size(434, 64)
        Me.PanelLeftXtraHeader.TabIndex = 2
        '
        'LabelXtraItem
        '
        Me.LabelXtraItem.Appearance.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelXtraItem.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelXtraItem.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        Me.LabelXtraItem.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelXtraItem.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.LabelXtraItem.AutoEllipsis = true
        Me.LabelXtraItem.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelXtraItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelXtraItem.Location = New System.Drawing.Point(51, 3)
        Me.LabelXtraItem.Name = "LabelXtraItem"
        Me.LabelXtraItem.Padding = New System.Windows.Forms.Padding(9, 0, 0, 3)
        Me.LabelXtraItem.Size = New System.Drawing.Size(332, 58)
        Me.LabelXtraItem.TabIndex = 3
        Me.LabelXtraItem.Text = "Greatest Hits (11 Tracks)"
        '
        'LabelXtraItemRight
        '
        Me.LabelXtraItemRight.Appearance.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelXtraItemRight.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelXtraItemRight.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        Me.LabelXtraItemRight.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.LabelXtraItemRight.AutoEllipsis = true
        Me.LabelXtraItemRight.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelXtraItemRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelXtraItemRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelXtraItemRight.Location = New System.Drawing.Point(383, 3)
        Me.LabelXtraItemRight.Name = "LabelXtraItemRight"
        Me.LabelXtraItemRight.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.LabelXtraItemRight.Size = New System.Drawing.Size(48, 58)
        Me.LabelXtraItemRight.TabIndex = 7
        Me.LabelXtraItemRight.Text = "11"
        '
        'ButtonXtraItem
        '
        Me.ButtonXtraItem.AllowFocus = false
        Me.ButtonXtraItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
        Me.ButtonXtraItem.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.ButtonXtraItem.Appearance.Options.UseBorderColor = true
        Me.ButtonXtraItem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ButtonXtraItem.Dock = System.Windows.Forms.DockStyle.Left
        Me.ButtonXtraItem.Image = CType(resources.GetObject("ButtonXtraItem.Image"),System.Drawing.Image)
        Me.ButtonXtraItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.ButtonXtraItem.Location = New System.Drawing.Point(3, 3)
        Me.ButtonXtraItem.MinimumSize = New System.Drawing.Size(48, 48)
        Me.ButtonXtraItem.Name = "ButtonXtraItem"
        Me.ButtonXtraItem.Padding = New System.Windows.Forms.Padding(6)
        Me.ButtonXtraItem.Size = New System.Drawing.Size(48, 58)
        Me.ButtonXtraItem.TabIndex = 6
        Me.ButtonXtraItem.Tag = "UsePadding"
        '
        'PanelLeftHeader
        '
        Me.PanelLeftHeader.Controls.Add(Me.LabelLPH_C)
        Me.PanelLeftHeader.Controls.Add(Me.ButtonLPH_R)
        Me.PanelLeftHeader.Controls.Add(Me.ButtonLPH_L)
        Me.PanelLeftHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLeftHeader.Location = New System.Drawing.Point(3, 3)
        Me.PanelLeftHeader.Name = "PanelLeftHeader"
        Me.PanelLeftHeader.Size = New System.Drawing.Size(434, 54)
        Me.PanelLeftHeader.TabIndex = 0
        '
        'LabelLPH_C
        '
        Me.LabelLPH_C.Appearance.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelLPH_C.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelLPH_C.AutoEllipsis = true
        Me.LabelLPH_C.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelLPH_C.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelLPH_C.Location = New System.Drawing.Point(51, 3)
        Me.LabelLPH_C.Name = "LabelLPH_C"
        Me.LabelLPH_C.Size = New System.Drawing.Size(332, 48)
        Me.LabelLPH_C.TabIndex = 2
        Me.LabelLPH_C.Text = "Left Panel header"
        '
        'ButtonLPH_R
        '
        Me.ButtonLPH_R.AllowFocus = false
        Me.ButtonLPH_R.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.ButtonLPH_R.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonLPH_R.Image = CType(resources.GetObject("ButtonLPH_R.Image"),System.Drawing.Image)
        Me.ButtonLPH_R.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.ButtonLPH_R.Location = New System.Drawing.Point(383, 3)
        Me.ButtonLPH_R.Margin = New System.Windows.Forms.Padding(6)
        Me.ButtonLPH_R.Name = "ButtonLPH_R"
        Me.ButtonLPH_R.Padding = New System.Windows.Forms.Padding(6)
        Me.ButtonLPH_R.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.ButtonLPH_R.Size = New System.Drawing.Size(48, 48)
        Me.ButtonLPH_R.TabIndex = 1
        '
        'ButtonLPH_L
        '
        Me.ButtonLPH_L.AllowFocus = false
        Me.ButtonLPH_L.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.ButtonLPH_L.Dock = System.Windows.Forms.DockStyle.Left
        Me.ButtonLPH_L.Image = CType(resources.GetObject("ButtonLPH_L.Image"),System.Drawing.Image)
        Me.ButtonLPH_L.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.ButtonLPH_L.Location = New System.Drawing.Point(3, 3)
        Me.ButtonLPH_L.Margin = New System.Windows.Forms.Padding(6)
        Me.ButtonLPH_L.Name = "ButtonLPH_L"
        Me.ButtonLPH_L.Padding = New System.Windows.Forms.Padding(6)
        Me.ButtonLPH_L.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.ButtonLPH_L.Size = New System.Drawing.Size(48, 48)
        Me.ButtonLPH_L.TabIndex = 0
        '
        'PanelRight
        '
        Me.PanelRight.Controls.Add(Me.SimpleButton4)
        Me.PanelRight.Controls.Add(Me.ButtonScaleTiles)
        Me.PanelRight.Controls.Add(Me.ButtonFontMetrics)
        Me.PanelRight.Controls.Add(Me.PanelScaleForm)
        Me.PanelRight.Controls.Add(Me.PanelResizeFonts)
        Me.PanelRight.Controls.Add(Me.ButtonResizeBtns)
        Me.PanelRight.Controls.Add(Me.PanelRightHeader)
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelRight.Location = New System.Drawing.Point(910, 97)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(305, 652)
        Me.PanelRight.TabIndex = 2
        '
        'SimpleButton4
        '
        Me.SimpleButton4.AllowFocus = false
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SimpleButton4.Appearance.Options.UseFont = true
        Me.SimpleButton4.Dock = System.Windows.Forms.DockStyle.Top
        Me.SimpleButton4.Location = New System.Drawing.Point(3, 327)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(299, 54)
        Me.SimpleButton4.TabIndex = 5
        Me.SimpleButton4.Text = "Resize Button Images"
        '
        'ButtonScaleTiles
        '
        Me.ButtonScaleTiles.AllowFocus = false
        Me.ButtonScaleTiles.Appearance.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ButtonScaleTiles.Appearance.Options.UseFont = true
        Me.ButtonScaleTiles.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonScaleTiles.Location = New System.Drawing.Point(3, 273)
        Me.ButtonScaleTiles.Name = "ButtonScaleTiles"
        Me.ButtonScaleTiles.Size = New System.Drawing.Size(299, 54)
        Me.ButtonScaleTiles.TabIndex = 4
        Me.ButtonScaleTiles.Text = "Resize Grid Tiles"
        '
        'ButtonFontMetrics
        '
        Me.ButtonFontMetrics.AllowFocus = false
        Me.ButtonFontMetrics.Appearance.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ButtonFontMetrics.Appearance.Options.UseFont = true
        Me.ButtonFontMetrics.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonFontMetrics.Location = New System.Drawing.Point(3, 219)
        Me.ButtonFontMetrics.Name = "ButtonFontMetrics"
        Me.ButtonFontMetrics.Size = New System.Drawing.Size(299, 54)
        Me.ButtonFontMetrics.TabIndex = 3
        Me.ButtonFontMetrics.Text = "Font Information"
        '
        'PanelScaleForm
        '
        Me.PanelScaleForm.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelScaleForm.Controls.Add(Me.ButtonScaleForm)
        Me.PanelScaleForm.Controls.Add(Me.ComboScaleForm)
        Me.PanelScaleForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelScaleForm.Location = New System.Drawing.Point(3, 165)
        Me.PanelScaleForm.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelScaleForm.Name = "PanelScaleForm"
        Me.PanelScaleForm.Size = New System.Drawing.Size(299, 54)
        Me.PanelScaleForm.TabIndex = 7
        '
        'ButtonScaleForm
        '
        Me.ButtonScaleForm.AllowFocus = false
        Me.ButtonScaleForm.Appearance.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ButtonScaleForm.Appearance.Options.UseFont = true
        Me.ButtonScaleForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonScaleForm.Location = New System.Drawing.Point(0, 0)
        Me.ButtonScaleForm.Name = "ButtonScaleForm"
        Me.ButtonScaleForm.Size = New System.Drawing.Size(219, 54)
        Me.ButtonScaleForm.TabIndex = 0
        Me.ButtonScaleForm.Text = "Scale Form"
        '
        'ComboScaleForm
        '
        Me.ComboScaleForm.Dock = System.Windows.Forms.DockStyle.Right
        Me.ComboScaleForm.EditValue = "1.25"
        Me.ComboScaleForm.Location = New System.Drawing.Point(219, 0)
        Me.ComboScaleForm.Name = "ComboScaleForm"
        Me.ComboScaleForm.Properties.AutoHeight = false
        Me.ComboScaleForm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboScaleForm.Properties.Items.AddRange(New Object() {"2", "1.5", "1.25", "1", "0.75", "0.5"})
        Me.ComboScaleForm.Size = New System.Drawing.Size(80, 54)
        Me.ComboScaleForm.TabIndex = 1
        '
        'PanelResizeFonts
        '
        Me.PanelResizeFonts.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelResizeFonts.Controls.Add(Me.ButtonResizeFonts)
        Me.PanelResizeFonts.Controls.Add(Me.ComboFontSize)
        Me.PanelResizeFonts.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelResizeFonts.Location = New System.Drawing.Point(3, 111)
        Me.PanelResizeFonts.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelResizeFonts.Name = "PanelResizeFonts"
        Me.PanelResizeFonts.Size = New System.Drawing.Size(299, 54)
        Me.PanelResizeFonts.TabIndex = 6
        '
        'ButtonResizeFonts
        '
        Me.ButtonResizeFonts.AllowFocus = false
        Me.ButtonResizeFonts.Appearance.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ButtonResizeFonts.Appearance.Options.UseFont = true
        Me.ButtonResizeFonts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonResizeFonts.Location = New System.Drawing.Point(0, 0)
        Me.ButtonResizeFonts.Name = "ButtonResizeFonts"
        Me.ButtonResizeFonts.Size = New System.Drawing.Size(219, 54)
        Me.ButtonResizeFonts.TabIndex = 0
        Me.ButtonResizeFonts.Text = "Resize Fonts"
        '
        'ComboFontSize
        '
        Me.ComboFontSize.Dock = System.Windows.Forms.DockStyle.Right
        Me.ComboFontSize.EditValue = "Auto"
        Me.ComboFontSize.Location = New System.Drawing.Point(219, 0)
        Me.ComboFontSize.Name = "ComboFontSize"
        Me.ComboFontSize.Properties.AutoHeight = false
        Me.ComboFontSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboFontSize.Properties.Items.AddRange(New Object() {"Auto", "8", "10", "12", "14", "16", "18", "20"})
        Me.ComboFontSize.Size = New System.Drawing.Size(80, 54)
        Me.ComboFontSize.TabIndex = 1
        '
        'ButtonResizeBtns
        '
        Me.ButtonResizeBtns.AllowFocus = false
        Me.ButtonResizeBtns.Appearance.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ButtonResizeBtns.Appearance.Options.UseFont = true
        Me.ButtonResizeBtns.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonResizeBtns.Location = New System.Drawing.Point(3, 57)
        Me.ButtonResizeBtns.Name = "ButtonResizeBtns"
        Me.ButtonResizeBtns.Size = New System.Drawing.Size(299, 54)
        Me.ButtonResizeBtns.TabIndex = 2
        Me.ButtonResizeBtns.Text = "Resize LPH Button Images"
        '
        'PanelRightHeader
        '
        Me.PanelRightHeader.Controls.Add(Me.LabelRPH_C)
        Me.PanelRightHeader.Controls.Add(Me.ButtonRPH_R)
        Me.PanelRightHeader.Controls.Add(Me.ButtonRPH_L)
        Me.PanelRightHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelRightHeader.Location = New System.Drawing.Point(3, 3)
        Me.PanelRightHeader.Name = "PanelRightHeader"
        Me.PanelRightHeader.Size = New System.Drawing.Size(299, 54)
        Me.PanelRightHeader.TabIndex = 1
        '
        'LabelRPH_C
        '
        Me.LabelRPH_C.Appearance.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelRPH_C.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelRPH_C.AutoEllipsis = true
        Me.LabelRPH_C.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelRPH_C.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelRPH_C.Location = New System.Drawing.Point(51, 3)
        Me.LabelRPH_C.Name = "LabelRPH_C"
        Me.LabelRPH_C.Size = New System.Drawing.Size(197, 48)
        Me.LabelRPH_C.TabIndex = 6
        Me.LabelRPH_C.Text = "Actions"
        '
        'ButtonRPH_R
        '
        Me.ButtonRPH_R.AllowFocus = false
        Me.ButtonRPH_R.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.ButtonRPH_R.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonRPH_R.Image = CType(resources.GetObject("ButtonRPH_R.Image"),System.Drawing.Image)
        Me.ButtonRPH_R.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.ButtonRPH_R.Location = New System.Drawing.Point(248, 3)
        Me.ButtonRPH_R.Margin = New System.Windows.Forms.Padding(6)
        Me.ButtonRPH_R.Name = "ButtonRPH_R"
        Me.ButtonRPH_R.Padding = New System.Windows.Forms.Padding(6)
        Me.ButtonRPH_R.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.ButtonRPH_R.Size = New System.Drawing.Size(48, 48)
        Me.ButtonRPH_R.TabIndex = 5
        Me.ButtonRPH_R.Tag = "UsePadding"
        Me.ButtonRPH_R.ToolTip = "Scale Form Up by 25%"
        '
        'ButtonRPH_L
        '
        Me.ButtonRPH_L.AllowFocus = false
        Me.ButtonRPH_L.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.ButtonRPH_L.Dock = System.Windows.Forms.DockStyle.Left
        Me.ButtonRPH_L.Image = CType(resources.GetObject("ButtonRPH_L.Image"),System.Drawing.Image)
        Me.ButtonRPH_L.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.ButtonRPH_L.Location = New System.Drawing.Point(3, 3)
        Me.ButtonRPH_L.Margin = New System.Windows.Forms.Padding(6)
        Me.ButtonRPH_L.Name = "ButtonRPH_L"
        Me.ButtonRPH_L.Padding = New System.Windows.Forms.Padding(6)
        Me.ButtonRPH_L.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.ButtonRPH_L.Size = New System.Drawing.Size(48, 48)
        Me.ButtonRPH_L.TabIndex = 4
        Me.ButtonRPH_L.Tag = "UsePadding"
        Me.ButtonRPH_L.ToolTip = "Scale Form Down by 25%"
        '
        'PanelCenter
        '
        Me.PanelCenter.Controls.Add(Me.PanelCenterHeader)
        Me.PanelCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCenter.Location = New System.Drawing.Point(440, 97)
        Me.PanelCenter.Name = "PanelCenter"
        Me.PanelCenter.Size = New System.Drawing.Size(470, 652)
        Me.PanelCenter.TabIndex = 3
        '
        'PanelCenterHeader
        '
        Me.PanelCenterHeader.Controls.Add(Me.LabelCPH_C)
        Me.PanelCenterHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCenterHeader.Location = New System.Drawing.Point(3, 3)
        Me.PanelCenterHeader.Name = "PanelCenterHeader"
        Me.PanelCenterHeader.Size = New System.Drawing.Size(464, 54)
        Me.PanelCenterHeader.TabIndex = 1
        '
        'LabelCPH_C
        '
        Me.LabelCPH_C.Appearance.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelCPH_C.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelCPH_C.AutoEllipsis = true
        Me.LabelCPH_C.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelCPH_C.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelCPH_C.Location = New System.Drawing.Point(3, 3)
        Me.LabelCPH_C.Name = "LabelCPH_C"
        Me.LabelCPH_C.Size = New System.Drawing.Size(458, 48)
        Me.LabelCPH_C.TabIndex = 5
        Me.LabelCPH_C.Text = "Central Panel header"
        '
        'colTitle
        '
        Me.colTitle.Caption = "A Slight Case  of Overbombing"
        Me.colTitle.FieldName = "colTitle"
        Me.colTitle.Name = "colTitle"
        Me.colTitle.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colTitle.Visible = true
        Me.colTitle.VisibleIndex = 1
        '
        'frmSkinUtilities
        '
        Me.Appearance.Options.UseFont = true
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144!, 144!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1215, 749)
        Me.Controls.Add(Me.PanelCenter)
        Me.Controls.Add(Me.PanelRight)
        Me.Controls.Add(Me.PanelLeft)
        Me.Controls.Add(Me.PanelTop)
        Me.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Name = "frmSkinUtilities"
        Me.Text = "DX Skin Utilities"
        CType(Me.RepositoryItemImageEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PanelTop,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelTop.ResumeLayout(false)
        CType(Me.PanelLeft,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelLeft.ResumeLayout(false)
        CType(Me.Grid1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TileView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PanelLeftXtraHeader,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelLeftXtraHeader.ResumeLayout(false)
        CType(Me.PanelLeftHeader,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelLeftHeader.ResumeLayout(false)
        CType(Me.PanelRight,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelRight.ResumeLayout(false)
        CType(Me.PanelScaleForm,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelScaleForm.ResumeLayout(false)
        CType(Me.ComboScaleForm.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PanelResizeFonts,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelResizeFonts.ResumeLayout(false)
        CType(Me.ComboFontSize.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PanelRightHeader,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelRightHeader.ResumeLayout(false)
        CType(Me.PanelCenter,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelCenter.ResumeLayout(false)
        CType(Me.PanelCenterHeader,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelCenterHeader.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PanelTop As DevExpress.XtraEditors.PanelControl
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents PanelLeft As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelLeftHeader As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelRight As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelRightHeader As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelCenter As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelLPH_C As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ButtonLPH_R As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ButtonLPH_L As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ButtonScaleTiles As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ButtonFontMetrics As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ButtonResizeBtns As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelResizeFonts As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ButtonResizeFonts As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ComboFontSize As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents PanelScaleForm As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ButtonScaleForm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ComboScaleForm As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelTPH_L As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelRPH_C As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ButtonRPH_R As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ButtonRPH_L As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelCenterHeader As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelCPH_C As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelLeftXtraHeader As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelXtraItem As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelXtraItemRight As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ButtonXtraItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents TileView1 As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents colArt As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents RepositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Friend WithEvents colTitle As DevExpress.XtraGrid.Columns.TileViewColumn
End Class
