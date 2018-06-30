Imports QLyBUS
Imports QLyDAL
Imports QLyDTO

Public Class frmQuyDinhTheLoaiSach
    Private Sub frmLoaiDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TVDataBsDataSet6.tblTHELOAI' table. You can move, or remove it, as needed.
        Me.TblTHELOAITableAdapter.Fill(Me.TVDataBsDataSet6.tblTHELOAI)

        Dim qdtlsDAL As New QuyDinhTheLoaiSachDAL
        Dim dtsource = qdtlsDAL.datatable

        'đưa data vào textbox
        txbKhoangNamXB.DataBindings.Add("Text", dtsource, "thoigianxuatban")


    End Sub
    Public Function resetData(a)
        txbMaTheLoai.Text = ""
        txbTenTheLoai.Text = ""
        txbSoLuong.Text = ""
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'LOP GUI
        Dim qdtls As QuyDinhTheLoaiSachDTO
        qdtls = New QuyDinhTheLoaiSachDTO()
        qdtls.MaTheLoai = txbMaTheLoai.Text
        qdtls.TenTheLoai = txbTenTheLoai.Text
        qdtls.SoLuong = txbSoLuong.Text
        'Lop BUS
        Dim qdtlsBUS As New QuyDinhTheLoaiSachBUS
        If (qdtlsBUS.ValidMaTheLoai(qdtls) = False) Then
            MessageBox.Show("Mã thể loại chưa được nhập!")
            txbMaTheLoai.Focus()
            Return
        End If
        If (qdtlsBUS.ValidTenTheLoai(qdtls) = False) Then
            MessageBox.Show("Tên thể loại chưa được nhập!")
            txbTenTheLoai.Focus()
            Return
        End If
        If (qdtlsBUS.ValidSoLuong(qdtls) = False) Then
            MessageBox.Show("Số lượng chưa được nhập!")
            txbMaTheLoai.Focus()
            Return
        End If
        'lop dal
        Dim qdtlsDAL As QuyDinhTheLoaiSachDAL
        qdtlsDAL = New QuyDinhTheLoaiSachDAL()
        Dim result As Integer
        result = qdtlsDAL.ThemTheLoai(qdtls)
        If (result = 0) Then
            MessageBox.Show("Thêm thể loại sách thành công.")
        Else
            MessageBox.Show("Thêm thể loại sách thất bại, trường dữ liệu MÃ THỂ LOẠI phải là kiểu dữ liệu SỐ!")
        End If
        'Me.TblLOAIDOCGIATableAdapter.Fill(Me.TVDataBsDataSet4.tblLOAIDOCGIA)
        Me.TblTHELOAITableAdapter.Fill(Me.TVDataBsDataSet6.tblTHELOAI)
        resetData(qdtls)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'LOP GUI
        Dim qdtls As QuyDinhTheLoaiSachDTO
        qdtls = New QuyDinhTheLoaiSachDTO()
        qdtls.MaTheLoai = txbMaTheLoai.Text
        qdtls.TenTheLoai = txbTenTheLoai.Text
        qdtls.SoLuong = txbSoLuong.Text
        'Lop BUS
        Dim qdtlsBUS As New QuyDinhTheLoaiSachBUS
        If (qdtlsBUS.ValidMaTheLoai(qdtls) = False) Then
            MessageBox.Show("Mã thể loại chưa được nhập!")
            txbMaTheLoai.Focus()
            Return
        End If
        If (qdtlsBUS.ValidTenTheLoai(qdtls) = False) Then
            MessageBox.Show("Tên thể loại chưa được nhập!")
            txbTenTheLoai.Focus()
            Return
        End If
        If (qdtlsBUS.ValidSoLuong(qdtls) = False) Then
            MessageBox.Show("Số lượng chưa được nhập!")
            txbMaTheLoai.Focus()
            Return
        End If
        'lop dal
        Dim qdtlsDAL As QuyDinhTheLoaiSachDAL
        qdtlsDAL = New QuyDinhTheLoaiSachDAL()
        Dim result As Integer
        result = qdtlsDAL.CapNhatTheLoai(qdtls)
        If (result = 0) Then
            MessageBox.Show("Cập nhật thể loại sách thành công.")
        Else
            MessageBox.Show("Cập nhật thể loại sách thất bại, trường dữ liệu MÃ THỂ LOẠI phải là kiểu dữ liệu SỐ")
        End If
        'Me.TblLOAIDOCGIATableAdapter.Fill(Me.TVDataBsDataSet4.tblLOAIDOCGIA)
        Me.TblTHELOAITableAdapter.Fill(Me.TVDataBsDataSet6.tblTHELOAI)
        resetData(qdtls)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'LOP GUI
        Dim qdtls As QuyDinhTheLoaiSachDTO
        qdtls = New QuyDinhTheLoaiSachDTO()
        qdtls.MaTheLoai = txbMaTheLoai.Text
        qdtls.TenTheLoai = txbTenTheLoai.Text
        qdtls.SoLuong = txbSoLuong.Text
        'lop dal
        Dim qdtlsDAL As QuyDinhTheLoaiSachDAL
        qdtlsDAL = New QuyDinhTheLoaiSachDAL()
        Dim result As Integer
        result = qdtlsDAL.XoaTheLoai(qdtls)
        If (result = 0) Then
            MessageBox.Show("Xóa thể loại sách thành công.")
        Else
            MessageBox.Show("Xóa thể loại sách thất bại!")
        End If
        'Me.TblLOAIDOCGIATableAdapter.Fill(Me.TVDataBsDataSet4.tblLOAIDOCGIA)
        Me.TblTHELOAITableAdapter.Fill(Me.TVDataBsDataSet6.tblTHELOAI)
        resetData(qdtls)
    End Sub

    Private Sub dgvTheLoaiSach_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTheLoaiSach.CellClick
        Dim row As DataGridViewRow = dgvTheLoaiSach.CurrentRow
        Try
            txbMaTheLoai.Text = row.Cells(0).Value.ToString()
            txbTenTheLoai.Text = row.Cells(1).Value.ToString()
            txbSoLuong.Text = row.Cells(2).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUpdateNamXB_Click(sender As Object, e As EventArgs) Handles btnUpdateNamXB.Click
        'Gui
        Dim qdtls As New QuyDinhTheLoaiSachDTO
        qdtls.KhoangNamXB = txbKhoangNamXB.Text

        'BUS
        Dim qdtlsBUS As New QuyDinhTheLoaiSachBUS
        If (qdtlsBUS.ValidKhoangNamXB(qdtls) = False) Then
            MessageBox.Show("Ô số lượng sách mượn tối đa trống!")
            txbKhoangNamXB.Focus()
            Return
        End If

        'DAL
        Dim qdtlsDAL As New QuyDinhTheLoaiSachDAL
        Dim result As Integer

        result = qdtlsDAL.CapNhatKhoangNamXB(qdtls)

        If (result = 0) Then
            MessageBox.Show("Cập nhật quy định thành công!")

        End If
        If (result = 1) Then
            MessageBox.Show("Cập nhật quy định thất bại!")
        End If
    End Sub
End Class