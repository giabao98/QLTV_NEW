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
        fTiepNhanSach.ShowDialog()
    End Sub

    Private Sub btnReaderManagement_Click(sender As Object, e As EventArgs) Handles btnReaderManagement.Click
        Dim fLapThe = New frmLapthe
        fLapThe.ShowDialog()
    End Sub

    Private Sub btnAuthorManagement_Click(sender As Object, e As EventArgs) Handles btnAuthorManagement.Click
        Dim td = New frmThayDoiQuyDinh
        td.ShowDialog()
    End Sub

    Private Sub btnBorrowBook_Click(sender As Object, e As EventArgs) Handles btnBorrowBook.Click
        Dim fMuonTraSach = New frmMuonTraSach
        fMuonTraSach.ShowDialog()
    End Sub

    Private Sub btnFindBook_Click(sender As Object, e As EventArgs) Handles btnFindBook.Click
        Dim fFind = New frmFind
        fFind.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fReport = New frmReport
        fReport.ShowDialog()
    End Sub

    Private Sub btnHeThong_Click(sender As Object, e As EventArgs) Handles btnHeThong.Click
        Dim fHeThong As New frmHeThong
        fHeThong.ShowDialog()
    End Sub
End Class