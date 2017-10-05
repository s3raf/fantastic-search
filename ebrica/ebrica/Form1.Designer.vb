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
        Me.btm_Classe = New System.Windows.Forms.Button()
        Me.gbxUTEC = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txbNumero = New System.Windows.Forms.TextBox()
        Me.gbxRicerca = New System.Windows.Forms.GroupBox()
        Me.lbl02 = New System.Windows.Forms.Label()
        Me.lbl01 = New System.Windows.Forms.Label()
        Me.txbUtente = New System.Windows.Forms.TextBox()
        Me.btn_diretta = New System.Windows.Forms.Button()
        Me.btnForm2 = New System.Windows.Forms.Button()
        Me.gbxUTEC.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxRicerca.SuspendLayout()
        Me.SuspendLayout()
        '
        'btm_Classe
        '
        Me.btm_Classe.Location = New System.Drawing.Point(198, 443)
        Me.btm_Classe.Name = "btm_Classe"
        Me.btm_Classe.Size = New System.Drawing.Size(169, 23)
        Me.btm_Classe.TabIndex = 0
        Me.btm_Classe.Text = "connessione via classe"
        Me.btm_Classe.UseVisualStyleBackColor = True
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
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(5, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(366, 193)
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
        Me.gbxRicerca.Location = New System.Drawing.Point(12, 374)
        Me.gbxRicerca.Name = "gbxRicerca"
        Me.gbxRicerca.Size = New System.Drawing.Size(180, 92)
        Me.gbxRicerca.TabIndex = 3
        Me.gbxRicerca.TabStop = False
        Me.gbxRicerca.Text = "Ricerca"
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
        'btn_diretta
        '
        Me.btn_diretta.Location = New System.Drawing.Point(198, 374)
        Me.btn_diretta.Name = "btn_diretta"
        Me.btn_diretta.Size = New System.Drawing.Size(169, 23)
        Me.btn_diretta.TabIndex = 4
        Me.btn_diretta.Text = "connessione diretta"
        Me.btn_diretta.UseVisualStyleBackColor = True
        '
        'btnForm2
        '
        Me.btnForm2.Location = New System.Drawing.Point(198, 308)
        Me.btnForm2.Name = "btnForm2"
        Me.btnForm2.Size = New System.Drawing.Size(169, 23)
        Me.btnForm2.TabIndex = 5
        Me.btnForm2.Text = "form2"
        Me.btnForm2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 472)
        Me.Controls.Add(Me.btnForm2)
        Me.Controls.Add(Me.btn_diretta)
        Me.Controls.Add(Me.gbxUTEC)
        Me.Controls.Add(Me.btm_Classe)
        Me.Controls.Add(Me.gbxRicerca)
        Me.Name = "Form1"
        Me.Text = "eBrica"
        Me.gbxUTEC.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxRicerca.ResumeLayout(False)
        Me.gbxRicerca.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btm_Classe As Button
    Friend WithEvents gbxUTEC As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txbNumero As TextBox
    Friend WithEvents gbxRicerca As GroupBox
    Friend WithEvents lbl01 As Label
    Friend WithEvents txbUtente As TextBox
    Friend WithEvents lbl02 As Label
    Friend WithEvents btn_diretta As Button
    Friend WithEvents btnForm2 As Button
End Class
