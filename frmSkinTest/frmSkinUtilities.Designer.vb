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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSkinUtilities))
        Me.PanelTop = New DevExpress.XtraEditors.PanelControl()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.PanelLeft = New DevExpress.XtraEditors.PanelControl()
        Me.PanelLeftHeader = New DevExpress.XtraEditors.PanelControl()
        Me.LabelLPH_C = New DevExpress.XtraEditors.LabelControl()
        Me.ButtonLPH_R = New DevExpress.XtraEditors.SimpleButton()
        Me.ButtonLPH_L = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelRight = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.ButtonFontMetrics = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.ButtonScaleForm = New DevExpress.XtraEditors.SimpleButton()
        Me.ComboScaleForm = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.PanelResizeFonts = New DevExpress.XtraEditors.PanelControl()
        Me.ButtonResizeFonts = New DevExpress.XtraEditors.SimpleButton()
        Me.ComboFontSize = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ButtonResizeBtns = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelRightHeader = New DevExpress.XtraEditors.PanelControl()
        Me.PanelCenter = New DevExpress.XtraEditors.PanelControl()
        Me.LabelTPH_L = New DevExpress.XtraEditors.LabelControl()
        Me.LabelCPH_C = New DevExpress.XtraEditors.LabelControl()
        Me.PanelCenterHeader = New DevExpress.XtraEditors.PanelControl()
        Me.ButtonRPH_L = New DevExpress.XtraEditors.SimpleButton()
        Me.ButtonRPH_R = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelRPH_C = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PanelTop,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelTop.SuspendLayout
        CType(Me.PanelLeft,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelLeft.SuspendLayout
        CType(Me.PanelLeftHeader,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelLeftHeader.SuspendLayout
        CType(Me.PanelRight,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelRight.SuspendLayout
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl1.SuspendLayout
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
        'PanelTop
        '
        Me.PanelTop.Controls.Add(Me.LabelTPH_L)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1215, 128)
        Me.PanelTop.TabIndex = 0
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "DevExpress Dark Style"
        '
        'PanelLeft
        '
        Me.PanelLeft.Controls.Add(Me.PanelLeftHeader)
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Location = New System.Drawing.Point(0, 128)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(426, 621)
        Me.PanelLeft.TabIndex = 1
        '
        'PanelLeftHeader
        '
        Me.PanelLeftHeader.Controls.Add(Me.LabelLPH_C)
        Me.PanelLeftHeader.Controls.Add(Me.ButtonLPH_R)
        Me.PanelLeftHeader.Controls.Add(Me.ButtonLPH_L)
        Me.PanelLeftHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLeftHeader.Location = New System.Drawing.Point(3, 3)
        Me.PanelLeftHeader.Name = "PanelLeftHeader"
        Me.PanelLeftHeader.Size = New System.Drawing.Size(420, 54)
        Me.PanelLeftHeader.TabIndex = 0
        '
        'LabelLPH_C
        '
        Me.LabelLPH_C.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelLPH_C.AutoEllipsis = true
        Me.LabelLPH_C.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelLPH_C.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelLPH_C.Location = New System.Drawing.Point(51, 3)
        Me.LabelLPH_C.Name = "LabelLPH_C"
        Me.LabelLPH_C.Size = New System.Drawing.Size(318, 48)
        Me.LabelLPH_C.TabIndex = 2
        Me.LabelLPH_C.Text = "Left Panel header"
        '
        'ButtonLPH_R
        '
        Me.ButtonLPH_R.AllowFocus = false
        Me.ButtonLPH_R.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
        Me.ButtonLPH_R.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonLPH_R.Image = CType(resources.GetObject("ButtonLPH_R.Image"),System.Drawing.Image)
        Me.ButtonLPH_R.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.ButtonLPH_R.Location = New System.Drawing.Point(369, 3)
        Me.ButtonLPH_R.Margin = New System.Windows.Forms.Padding(6)
        Me.ButtonLPH_R.Name = "ButtonLPH_R"
        Me.ButtonLPH_R.Padding = New System.Windows.Forms.Padding(4)
        Me.ButtonLPH_R.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.ButtonLPH_R.Size = New System.Drawing.Size(48, 48)
        Me.ButtonLPH_R.TabIndex = 1
        '
        'ButtonLPH_L
        '
        Me.ButtonLPH_L.AllowFocus = false
        Me.ButtonLPH_L.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
        Me.ButtonLPH_L.Dock = System.Windows.Forms.DockStyle.Left
        Me.ButtonLPH_L.Image = CType(resources.GetObject("ButtonLPH_L.Image"),System.Drawing.Image)
        Me.ButtonLPH_L.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.ButtonLPH_L.Location = New System.Drawing.Point(3, 3)
        Me.ButtonLPH_L.Margin = New System.Windows.Forms.Padding(6)
        Me.ButtonLPH_L.Name = "ButtonLPH_L"
        Me.ButtonLPH_L.Padding = New System.Windows.Forms.Padding(4)
        Me.ButtonLPH_L.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.ButtonLPH_L.Size = New System.Drawing.Size(48, 48)
        Me.ButtonLPH_L.TabIndex = 0
        '
        'PanelRight
        '
        Me.PanelRight.Controls.Add(Me.SimpleButton4)
        Me.PanelRight.Controls.Add(Me.SimpleButton3)
        Me.PanelRight.Controls.Add(Me.ButtonFontMetrics)
        Me.PanelRight.Controls.Add(Me.PanelControl1)
        Me.PanelRight.Controls.Add(Me.PanelResizeFonts)
        Me.PanelRight.Controls.Add(Me.ButtonResizeBtns)
        Me.PanelRight.Controls.Add(Me.PanelRightHeader)
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelRight.Location = New System.Drawing.Point(910, 128)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(305, 621)
        Me.PanelRight.TabIndex = 2
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Dock = System.Windows.Forms.DockStyle.Top
        Me.SimpleButton4.Location = New System.Drawing.Point(3, 297)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(299, 48)
        Me.SimpleButton4.TabIndex = 5
        Me.SimpleButton4.Text = "Resize Button Images"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.SimpleButton3.Location = New System.Drawing.Point(3, 249)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(299, 48)
        Me.SimpleButton3.TabIndex = 4
        Me.SimpleButton3.Text = "Resize Button Images"
        '
        'ButtonFontMetrics
        '
        Me.ButtonFontMetrics.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonFontMetrics.Location = New System.Drawing.Point(3, 201)
        Me.ButtonFontMetrics.Name = "ButtonFontMetrics"
        Me.ButtonFontMetrics.Size = New System.Drawing.Size(299, 48)
        Me.ButtonFontMetrics.TabIndex = 3
        Me.ButtonFontMetrics.Text = "Font Information"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.ButtonScaleForm)
        Me.PanelControl1.Controls.Add(Me.ComboScaleForm)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(3, 153)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(299, 48)
        Me.PanelControl1.TabIndex = 7
        '
        'ButtonScaleForm
        '
        Me.ButtonScaleForm.AllowFocus = false
        Me.ButtonScaleForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonScaleForm.Location = New System.Drawing.Point(0, 0)
        Me.ButtonScaleForm.Name = "ButtonScaleForm"
        Me.ButtonScaleForm.Size = New System.Drawing.Size(219, 48)
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
        Me.ComboScaleForm.Size = New System.Drawing.Size(80, 48)
        Me.ComboScaleForm.TabIndex = 1
        '
        'PanelResizeFonts
        '
        Me.PanelResizeFonts.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelResizeFonts.Controls.Add(Me.ButtonResizeFonts)
        Me.PanelResizeFonts.Controls.Add(Me.ComboFontSize)
        Me.PanelResizeFonts.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelResizeFonts.Location = New System.Drawing.Point(3, 105)
        Me.PanelResizeFonts.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelResizeFonts.Name = "PanelResizeFonts"
        Me.PanelResizeFonts.Size = New System.Drawing.Size(299, 48)
        Me.PanelResizeFonts.TabIndex = 6
        '
        'ButtonResizeFonts
        '
        Me.ButtonResizeFonts.AllowFocus = false
        Me.ButtonResizeFonts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonResizeFonts.Location = New System.Drawing.Point(0, 0)
        Me.ButtonResizeFonts.Name = "ButtonResizeFonts"
        Me.ButtonResizeFonts.Size = New System.Drawing.Size(219, 48)
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
        Me.ComboFontSize.Size = New System.Drawing.Size(80, 48)
        Me.ComboFontSize.TabIndex = 1
        '
        'ButtonResizeBtns
        '
        Me.ButtonResizeBtns.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonResizeBtns.Location = New System.Drawing.Point(3, 57)
        Me.ButtonResizeBtns.Name = "ButtonResizeBtns"
        Me.ButtonResizeBtns.Size = New System.Drawing.Size(299, 48)
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
        'PanelCenter
        '
        Me.PanelCenter.Controls.Add(Me.PanelCenterHeader)
        Me.PanelCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCenter.Location = New System.Drawing.Point(426, 128)
        Me.PanelCenter.Name = "PanelCenter"
        Me.PanelCenter.Size = New System.Drawing.Size(484, 621)
        Me.PanelCenter.TabIndex = 3
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
        Me.LabelTPH_L.Size = New System.Drawing.Size(417, 122)
        Me.LabelTPH_L.TabIndex = 3
        Me.LabelTPH_L.Text = "Panel Top Main Header"
        '
        'LabelCPH_C
        '
        Me.LabelCPH_C.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelCPH_C.AutoEllipsis = true
        Me.LabelCPH_C.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelCPH_C.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelCPH_C.Location = New System.Drawing.Point(3, 3)
        Me.LabelCPH_C.Name = "LabelCPH_C"
        Me.LabelCPH_C.Size = New System.Drawing.Size(472, 48)
        Me.LabelCPH_C.TabIndex = 5
        Me.LabelCPH_C.Text = "Central Panel header"
        '
        'PanelCenterHeader
        '
        Me.PanelCenterHeader.Controls.Add(Me.LabelCPH_C)
        Me.PanelCenterHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCenterHeader.Location = New System.Drawing.Point(3, 3)
        Me.PanelCenterHeader.Name = "PanelCenterHeader"
        Me.PanelCenterHeader.Size = New System.Drawing.Size(478, 54)
        Me.PanelCenterHeader.TabIndex = 1
        '
        'ButtonRPH_L
        '
        Me.ButtonRPH_L.AllowFocus = false
        Me.ButtonRPH_L.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
        Me.ButtonRPH_L.Dock = System.Windows.Forms.DockStyle.Left
        Me.ButtonRPH_L.Image = CType(resources.GetObject("ButtonRPH_L.Image"),System.Drawing.Image)
        Me.ButtonRPH_L.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.ButtonRPH_L.Location = New System.Drawing.Point(3, 3)
        Me.ButtonRPH_L.Margin = New System.Windows.Forms.Padding(6)
        Me.ButtonRPH_L.Name = "ButtonRPH_L"
        Me.ButtonRPH_L.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.ButtonRPH_L.Size = New System.Drawing.Size(48, 48)
        Me.ButtonRPH_L.TabIndex = 4
        Me.ButtonRPH_L.ToolTip = "Scale Form Down by 25%"
        '
        'ButtonRPH_R
        '
        Me.ButtonRPH_R.AllowFocus = false
        Me.ButtonRPH_R.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
        Me.ButtonRPH_R.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonRPH_R.Image = CType(resources.GetObject("ButtonRPH_R.Image"),System.Drawing.Image)
        Me.ButtonRPH_R.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.ButtonRPH_R.Location = New System.Drawing.Point(248, 3)
        Me.ButtonRPH_R.Margin = New System.Windows.Forms.Padding(6)
        Me.ButtonRPH_R.Name = "ButtonRPH_R"
        Me.ButtonRPH_R.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.ButtonRPH_R.Size = New System.Drawing.Size(48, 48)
        Me.ButtonRPH_R.TabIndex = 5
        Me.ButtonRPH_R.ToolTip = "Scale Form Up by 25%"
        '
        'LabelRPH_C
        '
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
        Me.Text = "frmSkinUtilities"
        CType(Me.PanelTop,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelTop.ResumeLayout(false)
        CType(Me.PanelLeft,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelLeft.ResumeLayout(false)
        CType(Me.PanelLeftHeader,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelLeftHeader.ResumeLayout(false)
        CType(Me.PanelRight,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelRight.ResumeLayout(false)
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl1.ResumeLayout(false)
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
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ButtonFontMetrics As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ButtonResizeBtns As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelResizeFonts As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ButtonResizeFonts As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ComboFontSize As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ButtonScaleForm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ComboScaleForm As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelTPH_L As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelRPH_C As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ButtonRPH_R As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ButtonRPH_L As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelCenterHeader As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelCPH_C As DevExpress.XtraEditors.LabelControl
End Class
