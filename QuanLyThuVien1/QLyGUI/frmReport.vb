Imports QLyDAL
Imports QLyDTO

Public Class frmReport
    Dim report As New ReportDTO
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        If (rbtnDGKhongMuonSach.Checked) Then
            report.KiHieu = 0
        End If
        If (rbtnDGMuonSachQuaHan.Checked) Then
            report.KiHieu = 1
        End If
        If (rbtnSoLanDGMuonSach.Checked) Then
            report.KiHieu = 2
        End If
    End Sub

    Private Sub btnReport1_Click(sender As Object, e As EventArgs) Handles btnReport1.Click
        If (rbtnSachHong.Checked) Then
            report.KiHieu = 3
        End If
        If (rbtnSoLanSachMuon.Checked) Then
            report.KiHieu = 4
        End If
        If (rbtnSachChuaDuocMuon.Checked) Then
            report.KiHieu = 5
        End If
    End Sub
End Class