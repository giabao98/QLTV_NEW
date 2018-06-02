Public Class frmMain

    Private LoginSign As DialogResult
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim flogin = New frmLogin()
        Dim lt = New frmLapthe()
        flogin.ShowDialog()
        'lt.ShowDialog()

        ''Kiem Tra ket qua Login, neu khong dung thi close
        LoginSign = flogin.DialogResult
        If (LoginSign <> DialogResult.OK) Then
            Me.Close()
        End If


    End Sub

End Class