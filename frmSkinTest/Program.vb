Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraEditors


Friend NotInheritable Class Program

		Private Sub New()
		End Sub

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Shared Sub Main()
            WindowsFormsSettings.SetDPIAware
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New frmSkinUtilities())
		End Sub
	End Class

