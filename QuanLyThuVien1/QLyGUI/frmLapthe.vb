Imports QLyBUS
Imports QLyDAL
Imports QLyDTO


Public Class frmLapthe

    Private Sub frmLapthe_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Add_button_Click(sender As Object, e As EventArgs) Handles Add_button.Click

        Dim lt As LaptheDTO
        lt = New LaptheDTO()

        '1. Lop GUI control
        lt.ReaderID = txbMaDocGia.Text
        lt.ReaderName = txbTenDocGia.Text
        lt.ReaderCategoryID = Convert.ToInt32(cbLoaiDocGia.SelectedValue)
        lt.Birthday = dtpNgaySinh.Value
        lt.Adress = txbDiaChi.Text
        lt.DayOfCard = dtpNgayLapThe.Value
        lt.Email = txbEmail.Text
        '2. Business .... kiem tra cac textbox du lieu nhap
        Dim ltbus As New LaptheBUS
        If (ltbus.ValidReaderName(lt) = False) Then
            MessageBox.Show("Ho ten chua duoc nhap")
            txbTenDocGia.Focus()
            Return
        End If

        If (ltbus.ValidAdress(lt) = False) Then
            MessageBox.Show("Dia chi chua duoc nhap")
            txbDiaChi.Focus()
            Return
        End If

        If (ltbus.ValidEmail(lt) = False) Then
            MessageBox.Show("Email chua duoc nhap")
            txbEmail.Focus()
            Return
        End If

        If (ltbus.ValidReaderCategoryID(lt) = False) Then
            MessageBox.Show("Ma loai doc gia chua duoc nhap")
            txbMaDocGia.Focus()
            Return
        End If

        If (ltbus.ValidDayOfCard(lt) = False) Then
            MessageBox.Show("Ngay lap the chua duoc nhap")
            dtpNgayLapThe.Focus()
            Return
        End If

        If (ltbus.ValidBirthday(lt) = False) Then
            MessageBox.Show("Ngay sinh chua duoc nhap")
            dtpNgaySinh.Focus()
            Return
        End If

        If (ltbus.ValidReaderID(lt) = False) Then
            MessageBox.Show("Ma doc gia chua duoc nhap")
            txbMaDocGia.Focus()
            Return
        End If

        ''3. Chen ket qua vao DataBase
        Dim ltdal As QLyDAL.LaptheDAL
        ltdal = New QLyDAL.LaptheDAL()
        Dim result As Integer
        result = ltdal.ThemDocGia(lt)
        If (result = 0) Then
            MessageBox.Show("Them doc gia thanh cong.")
        Else
            MessageBox.Show("Them doc gia that bai.")
        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
End Class