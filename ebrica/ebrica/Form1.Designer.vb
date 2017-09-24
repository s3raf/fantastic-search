<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btmExit = New System.Windows.Forms.Button()
        Me.gbxUTEC = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txbNumero = New System.Windows.Forms.TextBox()
        Me.gbxRicerca = New System.Windows.Forms.GroupBox()
        Me.lbl01 = New System.Windows.Forms.Label()
        Me.txbUtente = New System.Windows.Forms.TextBox()
        Me.lbl02 = New System.Windows.Forms.Label()
        Me.gbxUTEC.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxRicerca.SuspendLayout()
        Me.SuspendLayout()
        '
        'btmExit
        '
        Me.btmExit.Location = New System.Drawing.Point(835, 510)
        Me.btmExit.Name = "btmExit"
        Me.btmExit.Size = New System.Drawing.Size(75, 23)
        Me.btmExit.TabIndex = 0
        Me.btmExit.Text = "Exit"
        Me.btmExit.UseVisualStyleBackColor = True
        '
        'gbxUTEC
        '
        Me.gbxUTEC.Controls.Add(Me.DataGridView1)
        Me.gbxUTEC.Location = New System.Drawing.Point(12, 12)
        Me.gbxUTEC.Name = "gbxUTEC"
        Me.gbxUTEC.Size = New System.Drawing.Size(377, 218)
        Me.gbxUTEC.TabIndex = 1
        Me.gbxUTEC.TabStop = False
        Me.gbxUTEC.Text = "Ufficio Tecnico"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(365, 193)
        Me.DataGridView1.TabIndex = 0
        '
        'txbNumero
        '
        Me.txbNumero.Location = New System.Drawing.Point(5, 46)
        Me.txbNumero.Name = "txbNumero"
        Me.txbNumero.Size = New System.Drawing.Size(59, 20)
        Me.txbNumero.TabIndex = 2
        '
        'gbxRicerca
        '
        Me.gbxRicerca.Controls.Add(Me.lbl02)
        Me.gbxRicerca.Controls.Add(Me.lbl01)
        Me.gbxRicerca.Controls.Add(Me.txbUtente)
        Me.gbxRicerca.Controls.Add(Me.txbNumero)
        Me.gbxRicerca.Location = New System.Drawing.Point(12, 441)
        Me.gbxRicerca.Name = "gbxRicerca"
        Me.gbxRicerca.Size = New System.Drawing.Size(180, 92)
        Me.gbxRicerca.TabIndex = 3
        Me.gbxRicerca.TabStop = False
        Me.gbxRicerca.Text = "Ricerca"
        '
        'lbl01
        '
        Me.lbl01.AutoSize = True
        Me.lbl01.Location = New System.Drawing.Point(6, 30)
        Me.lbl01.Name = "lbl01"
        Me.lbl01.Size = New System.Drawing.Size(44, 13)
        Me.lbl01.TabIndex = 4
        Me.lbl01.Text = "Numero" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txbUtente
        '
        Me.txbUtente.Location = New System.Drawing.Point(70, 46)
        Me.txbUtente.Name = "txbUtente"
        Me.txbUtente.Size = New System.Drawing.Size(104, 20)
        Me.txbUtente.TabIndex = 3
        '
        'lbl02
        '
        Me.lbl02.AutoSize = True
        Me.lbl02.Location = New System.Drawing.Point(67, 30)
        Me.lbl02.Name = "lbl02"
        Me.lbl02.Size = New System.Drawing.Size(39, 13)
        Me.lbl02.TabIndex = 5
        Me.lbl02.Text = "Utente"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 545)
        Me.Controls.Add(Me.gbxUTEC)
        Me.Controls.Add(Me.btmExit)
        Me.Controls.Add(Me.gbxRicerca)
        Me.Name = "Form1"
        Me.Text = "eBrica"
        Me.gbxUTEC.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxRicerca.ResumeLayout(False)
        Me.gbxRicerca.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btmExit As Button
    Friend WithEvents gbxUTEC As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txbNumero As TextBox
    Friend WithEvents gbxRicerca As GroupBox
    Friend WithEvents lbl01 As Label
    Friend WithEvents txbUtente As TextBox
    Friend WithEvents lbl02 As Label
End Class
