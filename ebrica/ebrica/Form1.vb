Imports MySql.Data.MySqlClient

Public Class Form1
    Dim myConn As New MySqlConn

    Private Sub btn_diretta_Click(sender As Object, e As EventArgs) Handles btn_diretta.Click
        Dim connessione As MySqlConnection

        connessione = New MySqlConnection
        connessione.ConnectionString = "server=....;user id=prv;password=...;database=utenti"
        Try
            connessione.Open()
            MessageBox.Show("database connesso")
            connessione.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connessione.Dispose()

        End Try
    End Sub

    Private Sub btm_Classe_Click(sender As Object, e As EventArgs) Handles btm_Classe.Click

        myConn.Connect()
        myConn.conn.Close()

    End Sub

    Private Sub btnForm2_Click(sender As Object, e As EventArgs) Handles btnForm2.Click
        Form2.Show()
    End Sub
End Class
