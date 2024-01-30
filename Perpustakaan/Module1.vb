Imports System.Data.Odbc
Module Module1
    Public CONN As OdbcConnection
    Public CMD As OdbcCommand
    Public DR As OdbcDataReader
    Public DA As OdbcDataAdapter
    Public QUERY As String
    Public DS As DataSet
    Public DT As DataTable
    Sub KONEKSI()
        Dim str As String = "Dsn=perpustakaan_coon"
        CONN = New OdbcConnection(str)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
End Module
