Imports QLyBUS
Imports QLyDAL
Imports QLyDTO


Public Class frmLapthe

    Private Sub frmLapthe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TVDataBsDataSet1.tblDOCGIA' table. You can move, or remove it, as needed.
        Me.TblDOCGIATableAdapter.Fill(Me.TVDataBsDataSet1.tblDOCGIA)
        dtpNgayLapThe.Format = DateTimePickerFormat.Custom
        dtpNgayLapThe.CustomFormat = "dd/MM/yyyy"
        dtpNgaySinh.Format = DateTimePickerFormat.Custom
        dtpNgaySinh.CustomFormat = "dd/MM/yyyy"


    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
    Public Function resetData(dg)
        txbMaDocGia.Text = ""
        txbTenDocGia.Text = ""
        cbLoaiDocGia.Text = ""
        dtpNgaySinh.Text = ""
        txbDiaChi.Text = ""
        dtpNgayLapThe.Text = ""
        txbEmail.Text = ""
    End Function

    Private Sub Add_button_Click_1(sender As Object, e As EventArgs) Handles Add_button.Click
        Dim lt As LaptheDTO
        lt = New LaptheDTO()

        '1. Lop GUI control
        lt.ReaderID = txbMaDocGia.Text
        lt.ReaderName = txbTenDocGia.Text
        lt.ReaderCategory = cbLoaiDocGia.Text
        lt.Birthday = dtpNgaySinh.Value
        lt.Adress = txbDiaChi.Text
        lt.DayOfCard = dtpNgayLapThe.Value
        lt.Email = txbEmail.Text
        '2. Business .... kiem tra cac textbox du lieu nhap
        Dim ltbus As New LaptheBUS
        If (ltbus.ValidReaderName(lt) = False) Then
            MessageBox.Show("Họ tên chưa được nhập.")
            txbTenDocGia.Focus()
            Return
        End If

        If (ltbus.ValidAdress(lt) = False) Then
            MessageBox.Show("Địa chỉ chưa được nhập.")
            txbDiaChi.Focus()
            Return
        End If

        If (ltbus.ValidEmail(lt) = False) Then
            MessageBox.Show("Email chưa được nhập.")
            txbEmail.Focus()
            Return
        End If

        If (ltbus.ValidReaderCategory(lt) = False) Then
            MessageBox.Show("Loại đọc giả chưa được nhập.")
            txbMaDocGia.Focus()
            Return
        End If

        If (ltbus.ValidDayOfCard(lt) = False) Then
            MessageBox.Show("Ngày lập thẻ chưa được nhập hoặc ngày được nhập đã quá hạn.")
            dtpNgayLapThe.Focus()
            Return
        End If

        If (ltbus.ValidBirthday(lt) = False) Then
            MessageBox.Show("Ngày sinh vừa nhập có năm sinh lớn/bé hơn so với tuổi quy định.")
            dtpNgaySinh.Focus()
            Return
        End If

        If (ltbus.ValidReaderID(lt) = False) Then
            MessageBox.Show("Mã đọc giả chưa được nhập.")
            txbMaDocGia.Focus()
            Return
        End If

        ''3. Chen ket qua vao DataBase
        Dim ltdal As QLyDAL.LaptheDAL
        ltdal = New QLyDAL.LaptheDAL()
        Dim result As Integer
        result = ltdal.ThemDocGia(lt)
        If (result = 0) Then
            MessageBox.Show("Thêm đọc giả thành công.")
        Else
            MessageBox.Show("Thêm đọc giả thất bại!")
        End If
        Me.TblDOCGIATableAdapter.Fill(Me.TVDataBsDataSet1.tblDOCGIA)
        resetData(lt)
    End Sub

    Private Sub Update_button_Click(sender As Object, e As EventArgs) Handles Update_button.Click
        Dim lt As LaptheDTO
        lt = New LaptheDTO()

        '1. Lop GUI control
        lt.ReaderID = txbMaDocGia.Text
        lt.ReaderName = txbTenDocGia.Text
        lt.ReaderCategory = cbLoaiDocGia.Text
        lt.Birthday = dtpNgaySinh.Value
        lt.Adress = txbDiaChi.Text
        lt.DayOfCard = dtpNgayLapThe.Value
        lt.Email = txbEmail.Text
        '2. Business .... kiem tra cac textbox du lieu nhap
        Dim ltbus As New LaptheBUS
        If (ltbus.ValidReaderName(lt) = False) Then
            MessageBox.Show("Họ tên chưa được nhập.")
            txbTenDocGia.Focus()
            Return
        End If

        If (ltbus.ValidAdress(lt) = False) Then
            MessageBox.Show("Địa chỉ chưa được nhập.")
            txbDiaChi.Focus()
            Return
        End If

        If (ltbus.ValidEmail(lt) = False) Then
            MessageBox.Show("Email chưa được nhập.")
            txbEmail.Focus()
            Return
        End If

        If (ltbus.ValidReaderCategory(lt) = False) Then
            MessageBox.Show("Loại đọc giả chưa được nhập.")
            txbMaDocGia.Focus()
            Return
        End If

        If (ltbus.ValidDayOfCard(lt) = False) Then
            MessageBox.Show("Ngày lập thẻ chưa được nhập hoặc ngày được nhập đã quá hạn.")
            dtpNgayLapThe.Focus()
            Return
        End If

        If (ltbus.ValidBirthday(lt) = False) Then
            MessageBox.Show("Ngày sinh vừa nhập có năm sinh lớn/bé hơn so với tuổi quy định.")
            dtpNgaySinh.Focus()
            Return
        End If

        If (ltbus.ValidReaderID(lt) = False) Then
            MessageBox.Show("Mã đọc giả chưa được nhập.")
            txbMaDocGia.Focus()
            Return
        End If
        ''3. Chen ket qua vao DataBase
        Dim ltdal As QLyDAL.LaptheDAL
        ltdal = New QLyDAL.LaptheDAL()
        Dim result As Integer
        result = ltdal.CapNhatDocGia(lt)
        If (result = 0) Then
            MessageBox.Show("Cập nhật đọc giả thành công.")
        Else
            MessageBox.Show("Cập nhật đọc giả thất bại.")
        End If
        Me.TblDOCGIATableAdapter.Fill(Me.TVDataBsDataSet1.tblDOCGIA)
        resetData(lt)

    End Sub

    Private Sub Delete_button_Click(sender As Object, e As EventArgs) Handles Delete_button.Click
        Dim lt As LaptheDTO
        lt = New LaptheDTO()
        lt.ReaderID = txbMaDocGia.Text
        lt.ReaderName = txbTenDocGia.Text
        lt.ReaderCategory = cbLoaiDocGia.Text
        lt.Birthday = dtpNgaySinh.Value
        lt.Adress = txbDiaChi.Text
        lt.DayOfCard = dtpNgayLapThe.Value
        lt.Email = txbEmail.Text
        Dim ltdal As QLyDAL.LaptheDAL
        ltdal = New QLyDAL.LaptheDAL()
        Dim result As Integer
        result = ltdal.XoaDocGia(lt)
        If (result = 0) Then
            MessageBox.Show("Xóa đọc giả thành công.")
        Else
            MessageBox.Show("Xoá đọc giả thất bại.")
        End If
        Me.TblDOCGIATableAdapter.Fill(Me.TVDataBsDataSet1.tblDOCGIA)
        resetData(lt)
    End Sub
    Private Sub dgvDocGia_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocGia.CellClick
        Dim row As DataGridViewRow = dgvDocGia.CurrentRow
        Try
            txbMaDocGia.Text = row.Cells(0).Value.ToString()
            cbLoaiDocGia.Text = row.Cells(2).Value
            txbTenDocGia.Text = row.Cells(1).Value.ToString()
            dtpNgaySinh.Value = row.Cells(3).Value
            txbEmail.Text = row.Cells(4).Value.ToString()
            txbDiaChi.Text = row.Cells(5).Value.ToString()
            dtpNgayLapThe.Value = row.Cells(6).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvDocGia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocGia.CellContentClick

    End Sub
End Class