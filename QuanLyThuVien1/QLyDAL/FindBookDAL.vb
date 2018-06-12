Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports QLyDTO

Public Class FindBookDAL
    Protected con As SqlConnection
    Private ConnectionString As String
    Dim sqlAdap As New SqlDataAdapter
    Dim dt As New DataTable

    Public Sub New()
        con = New SqlConnection
        ConnectionString = ConfigurationManager.AppSettings("ConnectionString")
        con.ConnectionString = ConnectionString
        con.Open()
    End Sub

    Public Function LoadData2DataGridView(dgv As DataGridView, fb As FindBookDTO)

        Dim strFind As String = "select * from tblSACH where " + fb.FindCategory + " Like'%" + fb.Find + "%'"
        dt.Clear()
        sqlAdap = New SqlDataAdapter(strFind, con)
        sqlAdap.Fill(dt)
        dgv.DataSource = dt

        Return 0
    End Function

    'Public Function LoadData2DataGridView1(dgv As DataGridView, fb As FindBookDTO)

    '    Dim strFind As String = String.Empty
    '    strFind &= " select * from tblSACH where masach Like '% " + fb.BookCode + " %' "
    '    strFind &= " or tensach like '% " + fb.BookName + " %' "
    '    strFind &= " Or manhaxuatban Like '% " + fb.ProducerCode + " %'  "
    '    strFind &= " Or matacgia Like '% " + fb.AuthorCode + " %'  "
    '    strFind &= " Or matheloai Like '% " + fb.CategoryCode + " %'  "
    '    strFind &= " Or namxuatban = ' " + fb.PublishingYear + " '  "
    '    strFind &= " Or soluong = ' " + fb.Amount + " ' "
    '    strFind &= " Or ngaynhap = ' " + fb.InputDay + " ' "
    '    dt.Clear()
    '    sqlAdap = New SqlDataAdapter(strFind, con)
    '    sqlAdap.Fill(dt)
    '    dgv.DataSource = dt

    '    Return 0
    'End Function

End Class
