Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btmExit_Click(sender As Object, e As EventArgs) Handles btmExit.Click
        Dim myConn As New mysqlConn

        myConn.connect()
    End Sub
End Class
