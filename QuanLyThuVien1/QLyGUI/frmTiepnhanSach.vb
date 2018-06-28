Imports QLyBUS
Imports QLyDAL
Imports QLyDTO

Public Class frmTiepnhanSach

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub cbBookKindID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBookKindID.SelectedIndexChanged

    End Sub

    Private Sub dgvSach_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSach.CellContentClick

    End Sub
    Private Sub dgvSach_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSach.CellClick
        Dim row As DataGridViewRow = dgvSach.CurrentRow
        Try
            cbBookID.Text = row.Cells(0).Value.ToString()
            txbBookName.Text = row.Cells(1).Value
            cbBookKindID.Text = row.Cells(2).Value.ToString()
            cbAuthorID.Text = row.Cells(3).Value
            dtpPublishingYear.Text = row.Cells(4).Value.ToString()
            cbPublishingHouseID.Text = row.Cells(5).Value.ToString()
            dtpReceiptDate.Text = row.Cells(6).Value
            txbValue.Text = row.Cells(7).Value.ToString()
            cbStatusID.Text = row.Cells(8).Value.ToString()
            txtNumbers.Text = row.Cells(9).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub
    Public Function resetData(ts)
        cbBookID.Text = ""
        txbBookName.Text = ""
        cbBookKindID.Text = ""
        cbAuthorID.Text = ""
        dtpPublishingYear.Text = ""
        cbPublishingHouseID.Text = ""
        dtpReceiptDate.Text = ""
        txbValue.Text = ""
        cbStatusID.Text = ""
        txtNumbers.Text = ""
    End Function
    Private Sub frmTiepnhanSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TVDataBsDataSet2.tblSACH' table. You can move, or remove it, as needed.
        Me.TblSACHTableAdapter.Fill(Me.TVDataBsDataSet2.tblSACH)
        dtpPublishingYear.Format = DateTimePickerFormat.Custom
        dtpPublishingYear.CustomFormat = "dd/MM/yyyy"
        dtpReceiptDate.Format = DateTimePickerFormat.Custom
        dtpReceiptDate.CustomFormat = "dd/MM/yyyy"

    End Sub

    Private Sub Add_button_Click(sender As Object, e As EventArgs) Handles Add_button.Click
        Dim ts As TiepnhansachDTO
        ts = New TiepnhansachDTO()

        '1. Lop GUI control
        ts.BookID = cbBookID.Text
        ts.BookName = txbBookName.Text
        ts.BookKindID = cbBookKindID.Text
        ts.AuthorID = cbAuthorID.Text
        ts.PublishingDate = dtpPublishingYear.Value
        ts.PublishingHouseID = cbPublishingHouseID.Text
        ts.ReceiptDate = dtpReceiptDate.Value
        ts.Value = txbValue.Text
        ts.StatusID = cbStatusID.Text
        ts.Numbers = txtNumbers.Text

        '2. Business .... kiem tra cac textbox du lieu nhap
        Dim tsbus As New TiepnhansachBUS
        If (tsbus.ValidBookID(ts) = False) Then
            MessageBox.Show("Mã sách chưa được nhập!")
            cbBookID.Focus()
            Return
        End If

        If (tsbus.ValidBookName(ts) = False) Then
            MessageBox.Show("Tên sách chưa được nhập!")
            txbBookName.Focus()
            Return
        End If

        If (tsbus.ValidBookKindID(ts) = False) Then
            MessageBox.Show("Thể loại chưa được nhập!")
            cbBookKindID.Focus()
            Return
        End If

        If (tsbus.ValidAuthorID(ts) = False) Then
            MessageBox.Show("Mã tác giả chưa được nhập!")
            cbAuthorID.Focus()
            Return
        End If

        If (tsbus.ValidPublishingDate(ts) = False) Then
            MessageBox.Show("Năm xuất bản chưa được nhập!")
            dtpPublishingYear.Focus()
            Return
        End If

        If (tsbus.ValidPublishingHouseID(ts) = False) Then
            MessageBox.Show("Nhà xuất bản chưa được nhập!")
            cbPublishingHouseID.Focus()
            Return
        End If

        If (tsbus.ValidReceiptDate(ts) = False) Then
            MessageBox.Show("Ngày nhập sách chưa được nhập!")
            dtpReceiptDate.Focus()
            Return
        End If

        If (tsbus.ValidValue(ts) = False) Then
            MessageBox.Show("Trị giá sách chưa được nhập!")
            txbValue.Focus()
            Return
        End If

        If (tsbus.ValidStatusID(ts) = False) Then
            MessageBox.Show("Hiện trạng sách chưa được nhập!")
            cbStatusID.Focus()
            Return
        End If

        If (tsbus.ValidNumbers(ts) = False) Then
            MessageBox.Show("Số lượng chưa được nhập!")
            txtNumbers.Focus()
            Return
        End If
        '3. Chen ket qua vao DataBase
        Dim tsdal As QLyDAL.TiepnhansachDAL
        tsdal = New QLyDAL.TiepnhansachDAL()
        Dim result As Integer
        result = tsdal.ThemSach(ts)
        If (result = 0) Then
            MessageBox.Show("Thêm sách thành công.")
        Else
            MessageBox.Show("Thêm sách thất bại, trường dữ liệu TRỊ GIÁ và SỐ LƯỢNG phải là kiểu dữ liệu SỐ!")
        End If
        Me.TblSACHTableAdapter.Fill(Me.TVDataBsDataSet2.tblSACH)
        resetData(ts)
    End Sub

    Private Sub Update_button_Click(sender As Object, e As EventArgs) Handles Update_button.Click
        Dim ts As TiepnhansachDTO
        ts = New TiepnhansachDTO()

        '1. Lop GUI control
        ts.BookID = cbBookID.Text
        ts.BookName = txbBookName.Text
        ts.BookKindID = cbBookKindID.Text
        ts.AuthorID = cbAuthorID.Text
        ts.PublishingDate = dtpPublishingYear.Value
        ts.PublishingHouseID = cbPublishingHouseID.Text
        ts.ReceiptDate = dtpReceiptDate.Value
        ts.Value = txbValue.Text
        ts.StatusID = cbStatusID.Text
        ts.Numbers = txtNumbers.Text

        '2. Business .... kiem tra cac textbox du lieu nhap
        Dim tsbus As New TiepnhansachBUS
        If (tsbus.ValidBookID(ts) = False) Then
            MessageBox.Show("Mã sách chưa được nhập!")
            cbBookID.Focus()
            Return
        End If

        If (tsbus.ValidBookName(ts) = False) Then
            MessageBox.Show("Tên sách chưa được nhập!")
            txbBookName.Focus()
            Return
        End If

        If (tsbus.ValidBookKindID(ts) = False) Then
            MessageBox.Show("Thể loại chưa được nhập!")
            cbBookKindID.Focus()
            Return
        End If

        If (tsbus.ValidAuthorID(ts) = False) Then
            MessageBox.Show("Mã tác giả chưa được nhập!")
            cbAuthorID.Focus()
            Return
        End If

        If (tsbus.ValidPublishingDate(ts) = False) Then
            MessageBox.Show("Năm xuất bản chưa được nhập!")
            dtpPublishingYear.Focus()
            Return
        End If

        If (tsbus.ValidPublishingHouseID(ts) = False) Then
            MessageBox.Show("Nhà xuất bản chưa được nhập!")
            cbPublishingHouseID.Focus()
            Return
        End If

        If (tsbus.ValidReceiptDate(ts) = False) Then
            MessageBox.Show("Ngày nhập sách chưa được nhập!")
            dtpReceiptDate.Focus()
            Return
        End If

        If (tsbus.ValidValue(ts) = False) Then
            MessageBox.Show("Trị giá sách chưa được nhập!")
            txbValue.Focus()
            Return
        End If

        If (tsbus.ValidStatusID(ts) = False) Then
            MessageBox.Show("Hiện trạng sách chưa được nhập!")
            cbStatusID.Focus()
            Return
        End If

        If (tsbus.ValidNumbers(ts) = False) Then
            MessageBox.Show("Số lượng chưa được nhập!")
            txtNumbers.Focus()
            Return
        End If
        '3. Chen ket qua vao DataBase
        Dim tsdal As QLyDAL.TiepnhansachDAL
        tsdal = New QLyDAL.TiepnhansachDAL()
        Dim result As Integer
        result = tsdal.CapNhatSach(ts)
        If (result = 0) Then
            MessageBox.Show("Cập nhật sách thành công.")
        Else
            MessageBox.Show("Cập nhật sách thất bại, trường dữ liệu TRỊ GIÁ và SỐ LƯỢNG phải là kiểu dữ liệu SỐ!")
        End If
        Me.TblSACHTableAdapter.Fill(Me.TVDataBsDataSet2.tblSACH)
        resetData(ts)
    End Sub

    Private Sub Delete_button_Click(sender As Object, e As EventArgs) Handles Delete_button.Click
        Dim ts As TiepnhansachDTO
        ts = New TiepnhansachDTO()

        '1. Lop GUI control
        ts.BookID = cbBookID.Text
        ts.BookName = txbBookName.Text
        ts.BookKindID = cbBookKindID.Text
        ts.AuthorID = cbAuthorID.Text
        ts.PublishingDate = dtpPublishingYear.Value
        ts.PublishingHouseID = cbPublishingHouseID.Text
        ts.ReceiptDate = dtpReceiptDate.Value
        ts.Value = txbValue.Text
        ts.StatusID = cbStatusID.Text
        ts.Numbers = txtNumbers.Text
        '3. Chen ket qua vao DataBase
        Dim tsdal As QLyDAL.TiepnhansachDAL
        tsdal = New QLyDAL.TiepnhansachDAL()
        Dim result As Integer
        result = tsdal.XoaSach(ts)
        If (result = 0) Then
            MessageBox.Show("Xóa sách thành công.")
        Else
            MessageBox.Show("Xóa sách thất bại!")
        End If
        Me.TblSACHTableAdapter.Fill(Me.TVDataBsDataSet2.tblSACH)
        resetData(ts)
    End Sub
End Class