Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports QLyDTO

Public Class FindReaderDAL
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

    Public Function LoadData2DataGridView(dgv As DataGridView, fb As FindReaderDTO)

        Dim strFind As String = "select * from tblDOCGIA where " + fb.FindCategory + " Like'%" + fb.Find + "%'"
        dt.Clear()
        sqlAdap = New SqlDataAdapter(strFind, con)
        sqlAdap.Fill(dt)
        dgv.DataSource = dt

        Return 0
    End Function
End Class
