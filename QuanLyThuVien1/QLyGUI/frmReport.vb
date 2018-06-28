Imports QLyDAL
Imports QLyDTO

Public Class frmReport
    Dim report As New ReportDTO

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        If (rbtnBaoCaoTheLoai.Checked) Then
            report.KiHieu = 1
        End If
        If (rbtnBaoCaoTre.Checked) Then
            report.KiHieu = 2
        End If

        Dim rpDAL As New ReportDAL
        Dim result As Integer

        result = rpDAL.LoadData2DataGridView(dgvBookReport, report)
    End Sub
End Class