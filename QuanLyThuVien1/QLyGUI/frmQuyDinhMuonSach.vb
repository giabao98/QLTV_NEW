Imports QLyDTO
Imports QLyBUS
Imports QLyDAL

Public Class frmQuyDinhMuonSach

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        'Gui
        Dim qdms As New QuyDinhMuonSachDTO
        qdms.SoLuongToiDa = txbSoLuongToiDa.Text
        qdms.SoNgayToiDa = txbSoNgayToiDa.Text

        'BUS
        Dim qdmsBUS As New QuyDinhMuonSachBUS
        If (qdmsBUS.ValidSoLuongToiDa(qdms) = False) Then
            MessageBox.Show("Ô số lượng sách mượn tối đa trống!")
            txbSoLuongToiDa.Focus()
            Return
        End If
        If (qdmsBUS.ValidSoNgayToiDa(qdms) = False) Then
            MessageBox.Show("Ô số ngày mượn tối đa trống!")
            txbSoNgayToiDa.Focus()
            Return
        End If

        'DAL
        Dim qdmsDAL As New QuyDinhMuonSachDAL
        Dim result As Integer

        result = qdmsDAL.CapNhatQuyDinhMuonSach(qdms)

        If (result = 0) Then
            MessageBox.Show("Cập nhật quy định thành công!")

        End If
        If (result = 1) Then
            MessageBox.Show("Cập nhật quy định thất bại!")
        End If
    End Sub

    Private Sub frmQuyDinhMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim qdmsDAL As New QuyDinhMuonSachDAL
        Dim dtsource = qdmsDAL.datatable

        'đưa data vào textbox
        txbSoLuongToiDa.DataBindings.Add("Text", dtsource, "soluongmuontoida")
        txbSoNgayToiDa.DataBindings.Add("Text", dtsource, "thoigianmuontoida")
    End Sub
End Class