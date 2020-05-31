Imports System.Data
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlConnection
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared.CrystalReportsException
Imports PAGEOBJECTMODELLib


Module Module1
    Public conn As OdbcConnection
    Public cmd As OdbcCommand
    Public ds As DataSet
    Public dr As OdbcDataReader
    Public da As OdbcDataAdapter
    Public str As String

    Sub koneksi()
        Try
            conn = New OdbcConnection("DSN=janger;MultipleActiveResultSets=true;")
            If conn.State = ConnectionState.Closed Then
                conn.Open()

            End If
        Catch ex As Exception
            MsgBox("Gagal Koneksi Ke Database")
        End Try
    End Sub
End Module
