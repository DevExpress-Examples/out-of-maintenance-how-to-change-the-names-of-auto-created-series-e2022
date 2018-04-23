Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace ChangeNames4AutoSeries
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'gspDataSet.GSP' table. You can move, or remove it, as needed.
			Me.gSPTableAdapter.Fill(Me.gspDataSet.GSP)
		End Sub

		Private Sub chartControl1_CustomDrawSeries(ByVal sender As Object, ByVal e As CustomDrawSeriesEventArgs) Handles chartControl1.CustomDrawSeries
			e.LegendText = e.LegendText.Remove(0, 3)
		End Sub

	End Class
End Namespace