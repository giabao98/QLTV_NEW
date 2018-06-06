Imports QLyDTO
Imports QLyBUS

Public Class frmLogin

    Private ValidLogin As loginBUS

    'Lenh dieu khien nut X
    Private Sub frmLogin_Closing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Application.Exit()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim Login As loginDTO
        Login = New loginDTO()

        Login.UserName = txbUserName.Text
        Login.Password = txbPassword.Text

        'BUS kiem tra
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
            DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Ten Tai khoan hoac Mat khau sai! ")
            Return
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'button dong chuong trinh
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
