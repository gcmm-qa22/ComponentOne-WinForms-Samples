Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace TestSchedule
	NotInheritable Class Program
		Private Sub New()
		End Sub
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread()> _
		Private Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub
	End Class
End Namespace
