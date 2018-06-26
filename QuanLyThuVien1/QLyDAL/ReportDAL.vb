Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ReportDAL
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

    Public Function LoadData2DataGridView(dgv As DataGridView)
        Dim strFind As String = ""
        dt.Clear()
        sqlAdap = New SqlDataAdapter(strFind, con)
        sqlAdap.Fill(dt)
        dgv.DataSource = dt
        Return 0
    End Function

    Public Function LoadData2DataGridView1(dgv As DataGridView)
        Dim strFind As String = ""
        dt.Clear()
        sqlAdap = New SqlDataAdapter(strFind, con)
        sqlAdap.Fill(dt)
        dgv.DataSource = dt
        Return 0
    End Function
End Class
