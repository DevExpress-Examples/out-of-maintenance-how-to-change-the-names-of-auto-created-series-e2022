Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace ChangeNames4AutoSeries
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Load
            Me.GSPTableAdapter.Fill(Me.GspDataSet.GSP)
        End Sub

        Private Sub chartControl1_CustomDrawSeries(ByVal sender As Object, ByVal e As CustomDrawSeriesEventArgs) _
        Handles chartControl1.CustomDrawSeries
            e.LegendText = e.LegendText.Remove(0, 3)
        End Sub
    End Class

End Namespace
