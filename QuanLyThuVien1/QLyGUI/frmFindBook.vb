Imports QLyBUS
Imports QLyDTO
Imports QLyDAL


Public Class frmFindBook
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    'Private Sub btnFind1_Click(sender As Object, e As EventArgs)
    '    Dim fb As FindBookDTO
    '    fb = New FindBookDTO

    '    fb.BookCode = txbBookCode.Text
    '    fb.BookName = txbBookName.Text
    '    fb.ProducerCode = txbProducerCode.Text
    '    fb.AuthorCode = txbAuthorCode.Text
    '    fb.CategoryCode = txbCategoryCode.Text
    '    fb.PublishingYear = txbPublishingYear.Text
    '    fb.Amount = txbAmount.Text
    '    fb.InputDay = dateInputDay.Value

    '    Dim fbDAL As New FindBookDAL
    '    Dim result As Integer
    '    result = fbDAL.LoadData2DataGridView1(dgvBookInfo1, fb)

    'End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs)
        Dim fb As FindBookDTO
        fb = New FindBookDTO

        'Lay Du lieu tu GUI
        fb.FindCategory = cbbFindCategory.Text
        fb.Find = txbFind.Text


        'BUS kiem tra
        Dim ValidFindBook As FindBookBUS
        ValidFindBook = New FindBookBUS

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

        Dim fbDAL As New FindBookDAL
        Dim result As Integer
        result = fbDAL.LoadData2DataGridView(dgvBookInfo, fb)

    End Sub

    Private Sub frmFindBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TVDataBsDataSet.tblSACH' table. You can move, or remove it, as needed.
        Me.TblSACHTableAdapter.Fill(Me.TVDataBsDataSet.tblSACH)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnClose1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class