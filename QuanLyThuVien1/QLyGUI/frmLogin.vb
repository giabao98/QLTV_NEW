Imports QLyDTO
Imports QLyBUS

Public Class frmLogin

    Private ValidLogin As loginBUS
    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click

        Dim Login As loginDTO
        Login = New loginDTO()

        Login.UserName = txbUserName.Text
        Login.Password = txbPassword.Text

        'Business
        ValidLogin = New loginBUS()
        If (ValidLogin.ValidUserName(Login) = False) Then
            MessageBox.Show("Ten tai khoan khong hop le ! ")
            txbUserName.Focus()
            Return
        End If

        If (ValidLogin.ValidPassword(Login) = False) Then
            MessageBox.Show("Mat khau khong hop le !")
            txbPassword.Focus()
            Return
        End If

        If (ValidLogin.CompareAccount(Login)) Then
            MessageBox.Show("Thanh cong")
        Else
            MessageBox.Show("Code ngu")
        End If

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
