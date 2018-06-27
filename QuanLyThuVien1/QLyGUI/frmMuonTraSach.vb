Imports QLyBUS
Imports QLyDAL
Imports QLyDTO
Public Class frmMuonTraSach
    Private Sub frmMuonTraSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TVDataBsDataSet5.tblCHITIETPHIEUMUON' table. You can move, or remove it, as needed.
        Me.TblCHITIETPHIEUMUONTableAdapter.Fill(Me.TVDataBsDataSet5.tblCHITIETPHIEUMUON)
        'TODO: This line of code loads data into the 'TVDataBsDataSet4.tblCHITIETPHIEUMUON' table. You can move, or remove it, as needed.
        Me.TblCHITIETPHIEUMUONTableAdapter.Fill(Me.TVDataBsDataSet5.tblCHITIETPHIEUMUON)
        dtpNgayMuon.Format = DateTimePickerFormat.Custom
        dtpNgayMuon.CustomFormat = "dd/MM/yyyy"
        dtpNgayTra.Format = DateTimePickerFormat.Custom
        dtpNgayTra.CustomFormat = "dd/MM/yyyy"
    End Sub
    Public Function ResetData(mt)
        txbMaPhieuMuon.Text = ""
        cbMaDocGia.Text = ""
        txbTenDocGia.Text = ""
        cbMaSach.Text = ""
        txbTenSach.Text = ""
        txbTacGia.Text = ""
        cbTheLoai.Text = ""
        txbSoLuongmuon.Text = ""
        cbXacNhanTra.Text = ""
        txbGhiChu.Text = ""
    End Function
    Private Sub dgvPhieuMuonTra_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPhieuMuonTra.CellClick
        Dim row As DataGridViewRow = dgvPhieuMuonTra.CurrentRow
        Try
            txbMaPhieuMuon.Text = row.Cells(0).Value.ToString()
            cbMaDocGia.Text = row.Cells(1).Value
            txbTenDocGia.Text = row.Cells(2).Value.ToString()
            cbMaSach.Text = row.Cells(3).Value
            txbTenSach.Text = row.Cells(4).Value.ToString()
            txbTacGia.Text = row.Cells(6).Value.ToString()
            cbTheLoai.Text = row.Cells(5).Value
            dtpNgayMuon.Text = row.Cells(7).Value.ToString()
            txbSoLuongmuon.Text = row.Cells(8).Value.ToString()
            dtpNgayTra.Text = row.Cells(9).Value.ToString()
            cbXacNhanTra.Text = row.Cells(10).Value.ToString()
            txbGhiChu.Text = row.Cells(11).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        Dim mt As MuonTraSachDTO
        mt = New MuonTraSachDTO()

        '1. Lop GUI control
        mt.MaPhieuMuon = txbMaPhieuMuon.Text
        mt.MaDocGia = cbMaDocGia.Text
        mt.TenDocGia = txbTenDocGia.Text
        mt.MaSach = cbMaSach.Text
        mt.TenSach = txbTenSach.Text
        mt.TacGia = txbTacGia.Text
        mt.TheLoai = cbTheLoai.Text
        mt.NgayMuon = dtpNgayMuon.Value
        mt.SoLuongMuon = txbSoLuongmuon.Text
        mt.NgayTra = dtpNgayTra.Value
        mt.XacNhanTra = cbXacNhanTra.Text
        mt.GhiChu = txbGhiChu.Text
        '2. Business .... kiem tra cac textbox du lieu nhap
        Dim mtbus As New MuonTraSachBUS
        If (mtbus.ValidMaPhieuMuon(mt) = False) Then
            MessageBox.Show("Ma phieumuon chua duoc nhap")
            txbMaPhieuMuon.Focus()
            Return
        End If

        If (mtbus.ValidMaDocGia(mt) = False) Then
            MessageBox.Show("Ma doc gia chua duoc nhap")
            cbMaDocGia.Focus()
            Return
        End If

        If (mtbus.ValidTenDocGia(mt) = False) Then
            MessageBox.Show("Ten doc gia chua duoc nhap")
            txbTenDocGia.Focus()
            Return
        End If

        If (mtbus.ValidMaSach(mt) = False) Then
            MessageBox.Show("Ma sach chua duoc nhap")
            cbMaSach.Focus()
            Return
        End If

        If (mtbus.ValidTenSach(mt) = False) Then
            MessageBox.Show("Ten sach chua duoc nhap")
            txbTenSach.Focus()
            Return
        End If

        If (mtbus.ValidTheLoai(mt) = False) Then
            MessageBox.Show("The loai chua duoc nhap")
            cbTheLoai.Focus()
            Return
        End If

        If (mtbus.ValidTacGia(mt) = False) Then
            MessageBox.Show("Tac gia chua duoc nhap")
            txbTacGia.Focus()
            Return
        End If

        If (mtbus.ValidNgayMuon(mt) = False) Then
            MessageBox.Show("Ngay muon chua duoc nhap")
            dtpNgayMuon.Focus()
            Return
        End If

        If (mtbus.ValidSoLuongMuon(mt) = False) Then
            MessageBox.Show("So luong muon chua duoc nhap")
            txbSoLuongmuon.Focus()
            Return
        End If

        If (mtbus.ValidNgayTra(mt) = False) Then
            MessageBox.Show("Ngay tra chua duoc nhap")
            dtpNgayTra.Focus()
            Return
        End If
        If (mtbus.ValidXacNhanTra(mt) = False) Then
            MessageBox.Show("Chua co thong tin xac nhan tra")
            cbXacNhanTra.Focus()
            Return
        End If

        '3. Chen ket qua vao DataBase
        Dim mtdal As QLyDAL.MuonTraSachDAL
        mtdal = New QLyDAL.MuonTraSachDAL()
        Dim result As Integer
        result = mtdal.XacNhan(mt)
        If (result = 0) Then
            MessageBox.Show("Them phieu muon thanh cong.")
        Else
            MessageBox.Show("Them phieu muon that bai.")
        End If
        Me.TblCHITIETPHIEUMUONTableAdapter.Fill(Me.TVDataBsDataSet5.tblCHITIETPHIEUMUON)
        ResetData(mt)
    End Sub

    Private Sub btUpdate_Click(sender As Object, e As EventArgs) Handles btUpdate.Click
        Dim mt As MuonTraSachDTO
        mt = New MuonTraSachDTO()

        '1. Lop GUI control
        mt.MaPhieuMuon = txbMaPhieuMuon.Text
        mt.MaDocGia = cbMaDocGia.Text
        mt.TenDocGia = txbTenDocGia.Text
        mt.MaSach = cbMaSach.Text
        mt.TenSach = txbTenSach.Text
        mt.TacGia = txbTacGia.Text
        mt.TheLoai = cbTheLoai.Text
        mt.NgayMuon = dtpNgayMuon.Value
        mt.SoLuongMuon = txbSoLuongmuon.Text
        mt.NgayTra = dtpNgayTra.Value
        mt.XacNhanTra = cbXacNhanTra.Text
        mt.GhiChu = txbGhiChu.Text
        '2. Business .... kiem tra cac textbox du lieu nhap
        Dim mtbus As New MuonTraSachBUS
        If (mtbus.ValidMaPhieuMuon(mt) = False) Then
            MessageBox.Show("Ma phieumuon chua duoc nhap")
            txbMaPhieuMuon.Focus()
            Return
        End If

        If (mtbus.ValidMaDocGia(mt) = False) Then
            MessageBox.Show("Ma doc gia chua duoc nhap")
            cbMaDocGia.Focus()
            Return
        End If

        If (mtbus.ValidTenDocGia(mt) = False) Then
            MessageBox.Show("Ten doc gia chua duoc nhap")
            txbTenDocGia.Focus()
            Return
        End If

        If (mtbus.ValidMaSach(mt) = False) Then
            MessageBox.Show("Ma sach chua duoc nhap")
            cbMaSach.Focus()
            Return
        End If

        If (mtbus.ValidTenSach(mt) = False) Then
            MessageBox.Show("Ten sach chua duoc nhap")
            txbTenSach.Focus()
            Return
        End If

        If (mtbus.ValidTheLoai(mt) = False) Then
            MessageBox.Show("The loai chua duoc nhap")
            cbTheLoai.Focus()
            Return
        End If

        If (mtbus.ValidTacGia(mt) = False) Then
            MessageBox.Show("Tac gia chua duoc nhap")
            txbTacGia.Focus()
            Return
        End If

        If (mtbus.ValidNgayMuon(mt) = False) Then
            MessageBox.Show("Ngay muon chua duoc nhap")
            dtpNgayMuon.Focus()
            Return
        End If

        If (mtbus.ValidSoLuongMuon(mt) = False) Then
            MessageBox.Show("So luong muon chua duoc nhap")
            txbSoLuongmuon.Focus()
            Return
        End If

        If (mtbus.ValidNgayTra(mt) = False) Then
            MessageBox.Show("Ngay tra chua duoc nhap")
            dtpNgayTra.Focus()
            Return
        End If
        If (mtbus.ValidXacNhanTra(mt) = False) Then
            MessageBox.Show("Chua co thong tin xac nhan tra")
            cbXacNhanTra.Focus()
            Return
        End If

        '3. Chen ket qua vao DataBase
        Dim mtdal As QLyDAL.MuonTraSachDAL
        mtdal = New QLyDAL.MuonTraSachDAL()
        Dim result As Integer
        result = mtdal.CapNhatMuonTra(mt)
        If (result = 0) Then
            MessageBox.Show("Cap nhat phieu muon thanh cong.")
        Else
            MessageBox.Show("Cap nhat phieu muon that bai.")
        End If
        Me.TblCHITIETPHIEUMUONTableAdapter.Fill(Me.TVDataBsDataSet5.tblCHITIETPHIEUMUON)
        ResetData(mt)
    End Sub

    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click
        Dim mt As MuonTraSachDTO
        mt = New MuonTraSachDTO()

        '1. Lop GUI control
        mt.MaPhieuMuon = txbMaPhieuMuon.Text
        mt.MaDocGia = cbMaDocGia.Text
        mt.TenDocGia = txbTenDocGia.Text
        mt.MaSach = cbMaSach.Text
        mt.TenSach = txbTenSach.Text
        mt.TacGia = txbTacGia.Text
        mt.TheLoai = cbTheLoai.Text
        mt.NgayMuon = dtpNgayMuon.Value
        mt.SoLuongMuon = txbSoLuongmuon.Text
        mt.NgayTra = dtpNgayTra.Value
        mt.XacNhanTra = cbXacNhanTra.Text
        mt.GhiChu = txbGhiChu.Text


        '3. Chen ket qua vao DataBase
        Dim mtdal As QLyDAL.MuonTraSachDAL
        mtdal = New QLyDAL.MuonTraSachDAL()
        Dim result As Integer
        result = mtdal.XoaPhieu(mt)
        If (result = 0) Then
            MessageBox.Show("Xoa phieu muon thanh cong.")
        Else
            MessageBox.Show("Xoa phieu muon that bai.")
        End If
        Me.TblCHITIETPHIEUMUONTableAdapter.Fill(Me.TVDataBsDataSet5.tblCHITIETPHIEUMUON)
        ResetData(mt)

    End Sub
End Class