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
        Me.gbxUTEC.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 545)
        Me.Controls.Add(Me.gbxUTEC)
        Me.Controls.Add(Me.btmExit)
        Me.Name = "Form1"
        Me.Text = "eBrica"
        Me.gbxUTEC.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btmExit As Button
    Friend WithEvents gbxUTEC As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
