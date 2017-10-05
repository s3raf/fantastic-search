Imports MySql.Data.MySqlClient
Public Class MySqlConn
    Private _conn As MySqlConnection

    Public Sub Connect()
        Dim databaseName As String = "utenti"
        Dim server As String = "192.168.0.200"
        Dim username As String = "prv" 'inserire valore prima di compilare
        Dim password As String = "..." 'inserire valore prima di compilare


        If Not _conn Is Nothing Then _conn.Close()
        _conn.ConnectionString = "server=192.168.0.200;user id=prv;password=...;database=utenti"
        '_conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, username, password, databaseName)

        Try
            _conn.Open()
            MsgBox("connection successfully!!!")
            _conn.Close()
            MsgBox("disconnected")
        Catch ex As MySqlException
            MsgBox(ex.Message)

        Finally
            _conn.Dispose()

        End Try

    End Sub

    Public Property conn As MySqlConnection
        Get
            Return _conn
        End Get
        Set(value As MySqlConnection)

        End Set
    End Property
End Class
