Public Class frmMain

    Private LoginSign As DialogResult
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim flogin = New frmLogin()
        flogin.ShowDialog()

        ''Kiem Tra ket qua Login, neu khong dung thi close
        LoginSign = flogin.DialogResult
        If (LoginSign <> DialogResult.OK) Then
            Me.Close()
        End If


    End Sub

    Private Sub btnBookUpdate_Click(sender As Object, e As EventArgs) Handles btnBookUpdate.Click
        Dim fTiepNhanSach = New frmTiepnhanSach
        frmTiepnhanSach.ShowDialog()
    End Sub

    Private Sub btnReaderManagement_Click(sender As Object, e As EventArgs) Handles btnReaderManagement.Click
        Dim fLapThe = New frmLapthe
        fLapThe.ShowDialog()
    End Sub

    Private Sub btnAuthorManagement_Click(sender As Object, e As EventArgs) Handles btnAuthorManagement.Click

    End Sub

    Private Sub btnBorrowBook_Click(sender As Object, e As EventArgs) Handles btnBorrowBook.Click

    End Sub

    Private Sub btnFindBook_Click(sender As Object, e As EventArgs) Handles btnFindBook.Click
        Dim fFind = New frmFind
        fFind.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        'Me.Controls.Clear()
        'InitializeComponent()
        'frmMain_Load(e, e)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class