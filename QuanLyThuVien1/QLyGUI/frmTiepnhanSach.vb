Imports QLyBUS
Imports QLyDAL
Imports QLyDTO

Public Class frmTiepnhanSach
    Private Sub btThemSach_Click(sender As Object, e As EventArgs) Handles btThemSach.Click
        Dim ts As TiepnhansachDTO
        ts = New TiepnhansachDTO()

        '1. Lop GUI control
        ts.BookID = cbBookID.Text
        ts.BookName = txbBookName.Text
        ts.BookKindID = cbBookKindID.Text
        ts.AuthorID = cbAuthorID.Text
        ts.PublishingDate = txbPublishingYear.Text
        ts.PublishingHouseID = cbPublishingHouseID.Text
        ts.ReceiptDate = dtpReceiptDate.Text
        ts.Value = txbValue.Text
        ts.StatusID = cbStatusID.Text
        '2. Business .... kiem tra cac textbox du lieu nhap
        Dim tsbus As New TiepnhansachBUS
        If (tsbus.ValidBookID(ts) = False) Then
            MessageBox.Show("Ma sach chua duoc nhap")
            cbBookID.Focus()
            Return
        End If

        If (tsbus.ValidBookName(ts) = False) Then
            MessageBox.Show("Ten sach chua duoc nhap")
            txbBookName.Focus()
            Return
        End If

        If (tsbus.ValidBookKindID(ts) = False) Then
            MessageBox.Show("Ma the loai chua duoc nhap")
            cbBookKindID.Focus()
            Return
        End If

        If (tsbus.ValidAuthorID(ts) = False) Then
            MessageBox.Show("Ma tac gia chua duoc nhap")
            cbAuthorID.Focus()
            Return
        End If

        If (tsbus.ValidPublishingDate(ts) = False) Then
            MessageBox.Show("Nam san xuat chua duoc nhap")
            txbPublishingYear.Focus()
            Return
        End If

        If (tsbus.ValidPublishingHouseID(ts) = False) Then
            MessageBox.Show("Ma nha san xuat chua duoc nhap")
            cbPublishingHouseID.Focus()
            Return
        End If

        If (tsbus.ValidReceiptDate(ts) = False) Then
            MessageBox.Show("Ngay nhap sach chua duoc nhap")
            dtpReceiptDate.Focus()
            Return
        End If

        If (tsbus.ValidValue(ts) = False) Then
            MessageBox.Show("Tri gia chua duoc nhap")
            txbValue.Focus()
            Return
        End If

        If (tsbus.ValidStatusID(ts) = False) Then
            MessageBox.Show("Ma hien trang sach chua duoc nhap")
            cbStatusID.Focus()
            Return
        End If
        '3. Chen ket qua vao DataBase
        Dim tsdal As QLyDAL.TiepnhansachDAL
        tsdal = New QLyDAL.TiepnhansachDAL()
        Dim result As Integer
        result = tsdal.insertsach(ts)
        If (result = 0) Then
            MessageBox.Show("Them hoc sinh thanh cong.")
        Else
            MessageBox.Show("Them hoc sinh that bai.")
        End If
    End Sub
End Class