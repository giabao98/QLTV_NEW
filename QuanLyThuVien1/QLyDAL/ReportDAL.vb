Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports QLyDTO

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

    Public Function LoadData2DataGridView(dgv As DataGridView, report As ReportDTO)
        Dim strFind As String = ""
        If (report.KiHieu = 1) Then
            strFind = "select a.masach, tensach, count(*) as SoLanMuon from tblCHITIETPHIEUMUON a inner join tblSACH b on a.masach = b.tensach group by a.masach, tensach "
        End If
        If (report.KiHieu = 2) Then
            strFind = "select* from tblSACH where sosachhong > 0"
        End If

        dt.Clear()
        sqlAdap = New SqlDataAdapter(strFind, con)
        sqlAdap.Fill(dt)
        dgv.DataSource = dt
        Return 0
    End Function

    'Public Function LoadData2DataGridView1(dgv As DataGridView)
    '    Dim strFind As String = ""
    '    dt.Clear()
    '    sqlAdap = New SqlDataAdapter(strFind, con)
    '    sqlAdap.Fill(dt)
    '    dgv.DataSource = dt
    '    Return 0
    'End Function
End Class
