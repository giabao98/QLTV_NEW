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
    End Sub

    Public Function LoadData2DataGridView(strSelect As String, dgv As DataGridView)
        dt.Clear()
        sqlAdap = New SqlDataAdapter(strSelect, con)
        sqlAdap.Fill(dt)
        dgv.DataSource = dt
        Return 0
    End Function

End Class
