Imports QLyBUS
Imports QLyDAL
Imports QLyDTO

Public Class frmTiepnhanSach

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub cbBookKindID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBookKindID.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub frmTiepnhanSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TVDataBsDataSet2.tblSACH' table. You can move, or remove it, as needed.
        Me.TblSACHTableAdapter.Fill(Me.TVDataBsDataSet2.tblSACH)

    End Sub

    Private Sub Add_button_Click(sender As Object, e As EventArgs) Handles Add_button.Click
        Dim ts As TiepnhansachDTO
        ts = New TiepnhansachDTO()

        '1. Lop GUI control
        ts.BookID = cbBookID.Text
        ts.BookName = txbBookName.Text
        ts.BookKindID = cbBookKindID.Text
        ts.AuthorID = cbAuthorID.Text
        ts.PublishingDate = dtpPublishingYear.Text
        ts.PublishingHouseID = cbPublishingHouseID.Text
        ts.ReceiptDate = dtpReceiptDate.Text
        ts.Value = txbValue.Text
        ts.StatusID = cbStatusID.Text
        ts.Numbers = txtNumbers.Text

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
            dtpPublishingYear.Focus()
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

        If (tsbus.ValidNumbers(ts) = False) Then
            MessageBox.Show("So luong sach chua duoc nhap")
            txtNumbers.Focus()
            Return
        End If
        '3. Chen ket qua vao DataBase
        Dim tsdal As QLyDAL.TiepnhansachDAL
        tsdal = New QLyDAL.TiepnhansachDAL()
        Dim result As Integer
        result = tsdal.ThemSach(ts)
        If (result = 0) Then
            MessageBox.Show("Them sach thanh cong.")
        Else
            MessageBox.Show("Them sach that bai.")
        End If
        Me.TblSACHTableAdapter.Fill(Me.TVDataBsDataSet2.tblSACH)
    End Sub

    Private Sub Update_button_Click(sender As Object, e As EventArgs) Handles Update_button.Click
        Dim ts As TiepnhansachDTO
        ts = New TiepnhansachDTO()

        '1. Lop GUI control
        ts.BookID = cbBookID.Text
        ts.BookName = txbBookName.Text
        ts.BookKindID = cbBookKindID.Text
        ts.AuthorID = cbAuthorID.Text
        ts.PublishingDate = dtpPublishingYear.Text
        ts.PublishingHouseID = cbPublishingHouseID.Text
        ts.ReceiptDate = dtpReceiptDate.Text
        ts.Value = txbValue.Text
        ts.StatusID = cbStatusID.Text
        ts.Numbers = txtNumbers.Text

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
            dtpPublishingYear.Focus()
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

        If (tsbus.ValidNumbers(ts) = False) Then
            MessageBox.Show("So luong sach chua duoc nhap")
            txtNumbers.Focus()
            Return
        End If
        '3. Chen ket qua vao DataBase
        Dim tsdal As QLyDAL.TiepnhansachDAL
        tsdal = New QLyDAL.TiepnhansachDAL()
        Dim result As Integer
        result = tsdal.CapNhatSach(ts)
        If (result = 0) Then
            MessageBox.Show("Cap nhat sach thanh cong.")
        Else
            MessageBox.Show("Cap nhat sach that bai.")
        End If
        Me.TblSACHTableAdapter.Fill(Me.TVDataBsDataSet2.tblSACH)
    End Sub

    Private Sub Delete_button_Click(sender As Object, e As EventArgs) Handles Delete_button.Click
        Dim ts As TiepnhansachDTO
        ts = New TiepnhansachDTO()

        '1. Lop GUI control
        ts.BookID = cbBookID.Text
        ts.BookName = txbBookName.Text
        ts.BookKindID = cbBookKindID.Text
        ts.AuthorID = cbAuthorID.Text
        ts.PublishingDate = dtpPublishingYear.Text
        ts.PublishingHouseID = cbPublishingHouseID.Text
        ts.ReceiptDate = dtpReceiptDate.Text
        ts.Value = txbValue.Text
        ts.StatusID = cbStatusID.Text
        ts.Numbers = txtNumbers.Text
        '3. Chen ket qua vao DataBase
        Dim tsdal As QLyDAL.TiepnhansachDAL
        tsdal = New QLyDAL.TiepnhansachDAL()
        Dim result As Integer
        result = tsdal.XoaSach(ts)
        If (result = 0) Then
            MessageBox.Show("Xoa sach thanh cong.")
        Else
            MessageBox.Show("Xoa sach that bai.")
        End If
        Me.TblSACHTableAdapter.Fill(Me.TVDataBsDataSet2.tblSACH)
    End Sub
End Class