Imports QLyBUS
Imports QLyDAL
Imports QLyDTO

Public Class frmQuyDinhTheLoaiSach
    Private Sub frmLoaiDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TVDataBsDataSet4.tblLOAIDOCGIA' table. You can move, or remove it, as needed.
        Me.TblLOAIDOCGIATableAdapter.Fill(Me.TVDataBsDataSet4.tblLOAIDOCGIA)

    End Sub
    Public Function resetData(a)
        txbMaLoaiDocGia.Text = ""
        txbTenLoaiDocGia.Text = ""
    End Function

    Private Sub Add_button_Click(sender As Object, e As EventArgs) Handles Add_button.Click
        'LOP GUI
        Dim ldg As LoaiDocGiaDTO
        ldg = New LoaiDocGiaDTO()
        ldg.MaLoaiDocGia = txbMaLoaiDocGia.Text
        ldg.TenLoaiDocGia = txbTenLoaiDocGia.Text
        'Lop BUS
        Dim ldgbus As New LoaiDocGiaBUS
        If (ldgbus.ValidMaLoaiDocGia(ldg) = False) Then
            MessageBox.Show("Mã loại đọc giả chưa được nhập!")
            txbMaLoaiDocGia.Focus()
            Return
        End If
        If (ldgbus.ValidTenLoaiDocGia(ldg) = False) Then
            MessageBox.Show("Tên loại đọc giả chưa được nhập!")
            txbTenLoaiDocGia.Focus()
            Return
        End If
        'lop dal
        Dim ldgdal As QLyDAL.LoaiDocGiaDAL
        ldgdal = New QLyDAL.LoaiDocGiaDAL()
        Dim result As Integer
        result = ldgdal.ThemLoaiDocGia(ldg)
        If (result = 0) Then
            MessageBox.Show("Thêm loại đọc giả thành công.")
        Else
            MessageBox.Show("Thêm loại đọc giả thất bại, trường dữ liệu MÃ LOẠI ĐỌC GIẢ phải là kiểu dữ liệu SỐ!")
        End If
        Me.TblLOAIDOCGIATableAdapter.Fill(Me.TVDataBsDataSet4.tblLOAIDOCGIA)
        resetData(ldg)
    End Sub

    Private Sub Update_button_Click(sender As Object, e As EventArgs) Handles Update_button.Click
        'LOP GUI
        Dim ldg As LoaiDocGiaDTO
        ldg = New LoaiDocGiaDTO()
        ldg.MaLoaiDocGia = txbMaLoaiDocGia.Text
        ldg.TenLoaiDocGia = txbTenLoaiDocGia.Text
        'Lop BUS
        Dim ldgbus As New LoaiDocGiaBUS
        If (ldgbus.ValidMaLoaiDocGia(ldg) = False) Then
            MessageBox.Show("Mã loại đọc giả chưa được nhập!")
            txbMaLoaiDocGia.Focus()
            Return
        End If
        If (ldgbus.ValidTenLoaiDocGia(ldg) = False) Then
            MessageBox.Show("Tên loại đọc giả chưa được nhập!")
            txbTenLoaiDocGia.Focus()
            Return
        End If
        'lop dal
        Dim ldgdal As QLyDAL.LoaiDocGiaDAL
        ldgdal = New QLyDAL.LoaiDocGiaDAL()
        Dim result As Integer
        result = ldgdal.CapNhatLoaiDocGia(ldg)
        If (result = 0) Then
            MessageBox.Show("Cập nhật loại đọc giả thành công.")
        Else
            MessageBox.Show("Cập nhật loại đọc giả thất bại, trường dữ liệu MÃ LOẠI ĐỌC GIẢ phải là kiểu dữ liệu SỐ")
        End If
        Me.TblLOAIDOCGIATableAdapter.Fill(Me.TVDataBsDataSet4.tblLOAIDOCGIA)
        resetData(ldg)
    End Sub

    Private Sub Delete_button_Click(sender As Object, e As EventArgs) Handles Delete_button.Click
        'LOP GUI
        Dim ldg As LoaiDocGiaDTO
        ldg = New LoaiDocGiaDTO()
        ldg.MaLoaiDocGia = txbMaLoaiDocGia.Text
        ldg.TenLoaiDocGia = txbTenLoaiDocGia.Text
        'lop dal
        Dim ldgdal As QLyDAL.LoaiDocGiaDAL
        ldgdal = New QLyDAL.LoaiDocGiaDAL()
        Dim result As Integer
        result = ldgdal.XoaLoaiDocGia(ldg)
        If (result = 0) Then
            MessageBox.Show("Xóa loại đọc giả thành công.")
        Else
            MessageBox.Show("Xóa loại đọc giả thất bại!")
        End If
        Me.TblLOAIDOCGIATableAdapter.Fill(Me.TVDataBsDataSet4.tblLOAIDOCGIA)
        resetData(ldg)
    End Sub
    Private Sub dgvLoaiDocGia_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLoaiDocGia.CellClick
        Dim row As DataGridViewRow = dgvLoaiDocGia.CurrentRow
        Try
            txbMaLoaiDocGia.Text = row.Cells(0).Value.ToString()
            txbTenLoaiDocGia.Text = row.Cells(1).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub
End Class