Imports QLyBUS
Imports QLyDAL
Imports QLyDTO

Public Class frmLapthe

    Private Sub btLapthe_Click_1(sender As Object, e As EventArgs) Handles btLapthe.Click

        Dim lt As LaptheDTO
        lt = New LaptheDTO()

        '1. Lop GUI control
        lt.ReaderID = tbMaDocGia.Text
        lt.ReaderName = tbTenDocGia.Text
        lt.ReaderCategoryID = cbLoaiDocGia.Text
        lt.Birthday = dtpNgaySinh.Text
        lt.Adress = tbDiaChi.Text
        lt.DayOfCard = dtpNgayLapThe.Text
        lt.Email = tbEmail.Text
        '2. Business .... kiem tra cac textbox du lieu nhap
        Dim ltbus As New LaptheBUS
        If (ltbus.ValidReaderName(lt) = False) Then
            MessageBox.Show("Ho ten chua duoc nhap")
            lt.ReaderName()
            Return
        End If

        If (ltbus.ValidAdress(lt) = False) Then
            MessageBox.Show("Dia chi chua duoc nhap")
            tbHoTen.Focus()
            Return
        End If

        If (ltbus.isValidClass(lt) = False) Then
            MessageBox.Show("Lop chua duoc nhap")
            tbHoTen.Focus()
            Return
        End If
        If (ltbus.isValidAddress(lt) = False) Then
            MessageBox.Show("Dia chi chua duoc nhap")
            tbHoTen.Focus()
            Return
        End If

        '3. Chen ket qua vao DataBase
        Dim ltdal As QLyDAL.LaptheDAL
        ltdal = New QLyDAL.LaptheDAL()
        Dim result As Integer
        result = ltdal.insertDocGia(lt)
        If (result = 0) Then
            MessageBox.Show("Them hoc sinh thanh cong.")
        Else
            MessageBox.Show("Them hoc sinh that bai.")
        End If
    End Sub

    Private Sub frmLapthe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class