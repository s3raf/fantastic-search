<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mstMain = New System.Windows.Forms.MenuStrip()
        Me.msMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mstMain
        '
        Me.mstMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msMain})
        Me.mstMain.Location = New System.Drawing.Point(0, 0)
        Me.mstMain.Name = "mstMain"
        Me.mstMain.Size = New System.Drawing.Size(994, 24)
        Me.mstMain.TabIndex = 1
        Me.mstMain.Text = "MenuStrip1"
        '
        'msMain
        '
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(69, 20)
        Me.msMain.Text = "Inventory"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 512)
        Me.Controls.Add(Me.mstMain)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mstMain
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.mstMain.ResumeLayout(False)
        Me.mstMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mstMain As MenuStrip
    Friend WithEvents msMain As ToolStripMenuItem
End Class
