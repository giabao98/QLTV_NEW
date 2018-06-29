Imports QLyDTO
Imports QLyDAL
Imports QLyBUS

Public Class frmQuyDinhDocGia
    Private Sub frmQuyDinhDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim qddgDAL As New QuyDinhDocGiaDAL
        Dim dtsource = qddgDAL.datatable

        'Đưa data vào textbox
        txbTuoiToiDa.DataBindings.Add("Text", dtsource, "tuoitoida")
        txbTuoiToiThieu.DataBindings.Add("Text", dtsource, "tuoitoithieu")
        txbHanSuDung.DataBindings.Add("Text", dtsource, "hansudungthe")

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'GUI
        Dim qddg As New QuyDinhDocGiaDTO
        qddg.TuoiToiDa = txbTuoiToiDa.Text
        qddg.TuoiToiThieu = txbTuoiToiThieu.Text
        qddg.HanSuDung = txbHanSuDung.Text

        'BUS
        Dim qddgBUS As New QuyDinhDocGiaBUS
        If (qddgBUS.ValidTuoiToiDa(qddg) = False) Then
            MessageBox.Show("Ô tuổi tối đa chưa được nhập!")
            txbTuoiToiDa.Focus()
            Return
        End If
        If (qddgBUS.ValidTuoiToiThieu(qddg) = False) Then
            MessageBox.Show("Ô tuổi tối thiểu chưa được nhập!")
            txbTuoiToiThieu.Focus()
            Return
        End If
        If (qddgBUS.ValidHanSuDung(qddg) = False) Then
            MessageBox.Show("Ô Hạn sử dụng thẻ chưa được nhập!")
            txbHanSuDung.Focus()
            Return
        End If

        'DAL
        Dim qddgDAL As New QuyDinhDocGiaDAL
        Dim result As Integer

        result = qddgDAL.CapNhatQuyDinhMuonSach(qddg)

        If (result = 0) Then
            MessageBox.Show("Cập nhật quy định thành công!")

        End If
        If (result = 1) Then
            MessageBox.Show("Cập nhật quy định thất bại!")
        End If
    End Sub
End Class