<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cbxItems = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxUffEle = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.gbxUffCom = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.gbxUffTec = New System.Windows.Forms.GroupBox()
        Me.gbxUffMan = New System.Windows.Forms.GroupBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.gbxUffAmm = New System.Windows.Forms.GroupBox()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbxUffEle.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxUffCom.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxUffTec.SuspendLayout()
        Me.gbxUffMan.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxUffAmm.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(752, 423)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(112, 20)
        Me.txtSearch.TabIndex = 1
        '
        'cbxItems
        '
        Me.cbxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxItems.FormattingEnabled = True
        Me.cbxItems.Location = New System.Drawing.Point(752, 396)
        Me.cbxItems.Name = "cbxItems"
        Me.cbxItems.Size = New System.Drawing.Size(112, 21)
        Me.cbxItems.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(702, 426)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ricerca"
        '
        'gbxUffEle
        '
        Me.gbxUffEle.Controls.Add(Me.DataGridView1)
        Me.gbxUffEle.Location = New System.Drawing.Point(300, 12)
        Me.gbxUffEle.Name = "gbxUffEle"
        Me.gbxUffEle.Size = New System.Drawing.Size(279, 235)
        Me.gbxUffEle.TabIndex = 6
        Me.gbxUffEle.TabStop = False
        Me.gbxUffEle.Text = "Ufficio Elettrico"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(267, 210)
        Me.DataGridView1.TabIndex = 2
        '
        'gbxUffCom
        '
        Me.gbxUffCom.Controls.Add(Me.DataGridView2)
        Me.gbxUffCom.Location = New System.Drawing.Point(585, 12)
        Me.gbxUffCom.Name = "gbxUffCom"
        Me.gbxUffCom.Size = New System.Drawing.Size(279, 235)
        Me.gbxUffCom.TabIndex = 7
        Me.gbxUffCom.TabStop = False
        Me.gbxUffCom.Text = "Ufficio Commerciale"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(267, 210)
        Me.DataGridView2.TabIndex = 2
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(6, 19)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.Size = New System.Drawing.Size(267, 210)
        Me.dgvData.TabIndex = 2
        '
        'gbxUffTec
        '
        Me.gbxUffTec.Controls.Add(Me.dgvData)
        Me.gbxUffTec.Location = New System.Drawing.Point(15, 12)
        Me.gbxUffTec.Name = "gbxUffTec"
        Me.gbxUffTec.Size = New System.Drawing.Size(279, 235)
        Me.gbxUffTec.TabIndex = 5
        Me.gbxUffTec.TabStop = False
        Me.gbxUffTec.Text = "Ufficio Tecnico"
        '
        'gbxUffMan
        '
        Me.gbxUffMan.Controls.Add(Me.DataGridView3)
        Me.gbxUffMan.Location = New System.Drawing.Point(300, 253)
        Me.gbxUffMan.Name = "gbxUffMan"
        Me.gbxUffMan.Size = New System.Drawing.Size(279, 235)
        Me.gbxUffMan.TabIndex = 8
        Me.gbxUffMan.TabStop = False
        Me.gbxUffMan.Text = "Ufficio Manuali"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(267, 210)
        Me.DataGridView3.TabIndex = 2
        '
        'gbxUffAmm
        '
        Me.gbxUffAmm.Controls.Add(Me.DataGridView4)
        Me.gbxUffAmm.Location = New System.Drawing.Point(15, 253)
        Me.gbxUffAmm.Name = "gbxUffAmm"
        Me.gbxUffAmm.Size = New System.Drawing.Size(279, 235)
        Me.gbxUffAmm.TabIndex = 9
        Me.gbxUffAmm.TabStop = False
        Me.gbxUffAmm.Text = "Ufficio Amministrazione"
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.Size = New System.Drawing.Size(267, 210)
        Me.DataGridView4.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(789, 459)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 493)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gbxUffAmm)
        Me.Controls.Add(Me.gbxUffMan)
        Me.Controls.Add(Me.gbxUffCom)
        Me.Controls.Add(Me.gbxUffEle)
        Me.Controls.Add(Me.gbxUffTec)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxItems)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "Inventory"
        Me.Text = "Inventory"
        Me.gbxUffEle.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxUffCom.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxUffTec.ResumeLayout(False)
        Me.gbxUffMan.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxUffAmm.ResumeLayout(False)
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cbxItems As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbxUffEle As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents gbxUffCom As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents gbxUffTec As GroupBox
    Friend WithEvents gbxUffMan As GroupBox
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents gbxUffAmm As GroupBox
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents btnExit As Button
End Class
