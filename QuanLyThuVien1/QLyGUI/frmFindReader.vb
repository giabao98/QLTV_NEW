Imports QLyDTO
Imports QLyDAL
Imports QLyBUS


Public Class frmFindReader


    Private Sub frmFindReader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TVDataBsDataSet3.tblDOCGIA' table. You can move, or remove it, as needed.
        Me.TblDOCGIATableAdapter.Fill(Me.TVDataBsDataSet3.tblDOCGIA)

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim fb As FindReaderDTO
        fb = New FindReaderDTO

        'Lay Du lieu tu GUI
        fb.FindCategory = cbbFindCategory.Text
        fb.Find = txbFind.Text


        'BUS kiem tra
        Dim ValidFindBook As FindReaderBUS
        ValidFindBook = New FindReaderBUS

        If (ValidFindBook.ValidFindCategory(fb) = False) Then
            MessageBox.Show("Chưa chọn loại tìm kiếm !")
            cbbFindCategory.Focus()
            Return
        End If

        If (ValidFindBook.ValidFind(fb) = False) Then
            MessageBox.Show("Ô tìm kiếm trống!")
            txbFind.Focus()
            Return
        End If

        Dim fbDAL As New FindReaderDAL
        Dim result As Integer
        result = fbDAL.LoadData2DataGridView(dgvReaderInfo, fb)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class