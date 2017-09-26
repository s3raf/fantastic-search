Imports MySql.Data.MySqlClient
Public Class mysqlConn
    Private _conn As MySqlConnection

    Public Sub connect()
        Dim databaseName As String = "utenti"
        Dim server As String = "192.168.0.200"
        Dim username As String = "..." 'inserire valore prima di compilare
        Dim password As String = "..." 'inserire valore prima di compilare

        If Not _conn Is Nothing Then _conn.Close()
        _conn.ConnectionString = String.Format("server-{0}; username-{1}; password-{2}; database-{3}; pooling-false", server, username, password, databaseName)
        Try
            _conn.Open()
            MsgBox("connected")
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        'la connessione no viene chiusa nella classe 
    End Sub

    Public Property conn As MySqlConnection
        Get
            Return _conn
        End Get
        Set(value As MySqlConnection)

        End Set
    End Property
End Class
