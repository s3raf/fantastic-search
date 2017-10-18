Public Class Inventory
    Public SQL As New MySQLControl

    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT * FROM tabella1;")
        Else
            SQL.ExecQuery(Query)
        End If

        ' ERROR HANDLING
        If SQL.HasException(True) Then Exit Sub

        dgvData.DataSource = SQL.DBDT
    End Sub

    Private Sub LoadCBX()
        ' REFRESH COMBOBOX
        cbxItems.Items.Clear()

        ' RUN QUERY
        SQL.ExecQuery("SELECT nome FROM tabella1 ORDER BY nome ASC;")

        If SQL.HasException(True) Then Exit Sub

        ' LOOP ROW & ADD TO COMBOBOX
        For Each r As DataRow In SQL.DBDT.Rows
            cbxItems.Items.Add(r("nome").ToString)
        Next
    End Sub

    Private Sub FindItem()
        SQL.AddParam("@item", "%" & txtSearch.Text & "%")
        LoadGrid("SELECT nome,cognome,nascita FROM tabella1 WHERE CONCAT(nome,cognome,nascita) LIKE @item;")
    End Sub

    Private Sub Inventory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MdiParent = Form2
        LoadGrid()
        LoadCBX()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        FindItem()
    End Sub

End Class