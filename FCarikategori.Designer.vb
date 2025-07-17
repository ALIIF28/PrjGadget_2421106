<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCarikategori
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnamakategori = New System.Windows.Forms.TextBox()
        Me.cmdsimpan = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Kategori"
        '
        'txtnamakategori
        '
        Me.txtnamakategori.Location = New System.Drawing.Point(159, 33)
        Me.txtnamakategori.Name = "txtnamakategori"
        Me.txtnamakategori.Size = New System.Drawing.Size(213, 22)
        Me.txtnamakategori.TabIndex = 1
        '
        'cmdsimpan
        '
        Me.cmdsimpan.Location = New System.Drawing.Point(422, 33)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(75, 23)
        Me.cmdsimpan.TabIndex = 2
        Me.cmdsimpan.Text = "Simpan"
        Me.cmdsimpan.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(28, 92)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersWidth = 51
        Me.dg.RowTemplate.Height = 24
        Me.dg.Size = New System.Drawing.Size(505, 310)
        Me.dg.TabIndex = 3
        '
        'FCarikategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.txtnamakategori)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FCarikategori"
        Me.Text = "TAMBAH KATEGORI"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtnamakategori As TextBox
    Friend WithEvents cmdsimpan As Button
    Friend WithEvents dg As DataGridView
End Class
