Imports QLyDTO
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class QuyDinhMuonSachDAL
    Private dbAccess As DataBaseAccess
    Protected Con As SqlConnection
    Private ConnectionString As String
    Dim dt As New DataTable
    Dim dtAdap As SqlDataAdapter

    Public Sub New()
        Con = New SqlConnection
        ConnectionString = ConfigurationManager.AppSettings("ConnectionString")
        Con.ConnectionString = ConnectionString
    End Sub

    Public Function datatable()
        Dim dtSour As New DataGridView
        Dim strFind As String = "select [thoigianmuontoida],[soluongmuontoida] from tblTHAMSO"
        dt.Clear()
        dtAdap = New SqlDataAdapter(strFind, Con)
        dtAdap.Fill(dt)
        dtSour.DataSource = dt
        Return dtSour.DataSource
    End Function

    Public Function CapNhatQuyDinhMuonSach(qdms As QuyDinhMuonSachDTO)
        Dim query As String = String.Empty
        query &= "UPDATE [tblTHAMSO] SET "
        query &= "[soluongmuontoida] = @soluongmuontoida "
        query &= " ,[thoigianmuontoida] = @thoigianmuontoida "
        'query &= " WHERE "
        'query &= " [soluongmuontoida] = @soluongmuontoida "

        Using conn As New SqlConnection(ConnectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@soluongmuontoida", qdms.SoLuongToiDa)
                    .Parameters.AddWithValue("@thoigianmuontoida", qdms.SoNgayToiDa)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return 1 ' cap nhat loai doc gia that bai!!!
                End Try
            End Using
        End Using
        Return 0 ' thanh cong
    End Function
End Class
