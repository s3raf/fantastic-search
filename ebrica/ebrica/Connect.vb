Imports MySql.Data.MySqlClient

Module Connect
    Public conn As New MySqlConnection

    Public Sub ConnectDatabase()

        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "server=localhost;userid=root;password=;database=tracking"

                conn.Open()
            End If

        Catch myerror As Exception
            MsgBox("Connection Error")
            End
        End Try
    End Sub

    Public Sub DisconnectDatabase()
        Try
            conn.Close()
        Catch myerror As MySql.Data.MySqlClient.MySqlException

        End Try
    End Sub
End Module