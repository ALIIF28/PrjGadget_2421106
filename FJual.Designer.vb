<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FJual
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtjualnofaktur = New System.Windows.Forms.TextBox()
        Me.txtpelangganid = New System.Windows.Forms.TextBox()
        Me.cmdbaru = New System.Windows.Forms.Button()
        Me.cmdcaripelanggan = New System.Windows.Forms.Button()
        Me.txtpelanggannama = New System.Windows.Forms.TextBox()
        Me.txtjmluang = New System.Windows.Forms.TextBox()
        Me.txtkembali = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdtambahpelanggan = New System.Windows.Forms.Button()
        Me.cmdsimpan = New System.Windows.Forms.Button()
        Me.cmdkeluar = New System.Windows.Forms.Button()
        Me.cmdcetak = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbltgl = New System.Windows.Forms.Label()
        Me.lbltotbay = New System.Windows.Forms.Label()
        Me.lbltotqty = New System.Windows.Forms.Label()
        Me.lblterbilang = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Faktur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pelanggan"
        '
        'txtjualnofaktur
        '
        Me.txtjualnofaktur.Location = New System.Drawing.Point(105, 26)
        Me.txtjualnofaktur.Name = "txtjualnofaktur"
        Me.txtjualnofaktur.Size = New System.Drawing.Size(100, 22)
        Me.txtjualnofaktur.TabIndex = 2
        '
        'txtpelangganid
        '
        Me.txtpelangganid.Location = New System.Drawing.Point(105, 68)
        Me.txtpelangganid.Name = "txtpelangganid"
        Me.txtpelangganid.Size = New System.Drawing.Size(100, 22)
        Me.txtpelangganid.TabIndex = 3
        '
        'cmdbaru
        '
        Me.cmdbaru.Location = New System.Drawing.Point(227, 25)
        Me.cmdbaru.Name = "cmdbaru"
        Me.cmdbaru.Size = New System.Drawing.Size(75, 23)
        Me.cmdbaru.TabIndex = 5
        Me.cmdbaru.Text = "Baru"
        Me.cmdbaru.UseVisualStyleBackColor = True
        '
        'cmdcaripelanggan
        '
        Me.cmdcaripelanggan.Location = New System.Drawing.Point(227, 68)
        Me.cmdcaripelanggan.Name = "cmdcaripelanggan"
        Me.cmdcaripelanggan.Size = New System.Drawing.Size(43, 23)
        Me.cmdcaripelanggan.TabIndex = 6
        Me.cmdcaripelanggan.Text = "..."
        Me.cmdcaripelanggan.UseVisualStyleBackColor = True
        '
        'txtpelanggannama
        '
        Me.txtpelanggannama.Location = New System.Drawing.Point(331, 69)
        Me.txtpelanggannama.Name = "txtpelanggannama"
        Me.txtpelanggannama.Size = New System.Drawing.Size(203, 22)
        Me.txtpelanggannama.TabIndex = 7
        '
        'txtjmluang
        '
        Me.txtjmluang.Location = New System.Drawing.Point(812, 419)
        Me.txtjmluang.Name = "txtjmluang"
        Me.txtjmluang.Size = New System.Drawing.Size(100, 22)
        Me.txtjmluang.TabIndex = 8
        '
        'txtkembali
        '
        Me.txtkembali.Location = New System.Drawing.Point(812, 467)
        Me.txtkembali.Name = "txtkembali"
        Me.txtkembali.Size = New System.Drawing.Size(100, 22)
        Me.txtkembali.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(703, 422)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Jumlah Uang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(703, 473)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Kembali"
        '
        'cmdtambahpelanggan
        '
        Me.cmdtambahpelanggan.Location = New System.Drawing.Point(553, 69)
        Me.cmdtambahpelanggan.Name = "cmdtambahpelanggan"
        Me.cmdtambahpelanggan.Size = New System.Drawing.Size(25, 23)
        Me.cmdtambahpelanggan.TabIndex = 12
        Me.cmdtambahpelanggan.Text = "+"
        Me.cmdtambahpelanggan.UseVisualStyleBackColor = True
        '
        'cmdsimpan
        '
        Me.cmdsimpan.Location = New System.Drawing.Point(165, 450)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(75, 23)
        Me.cmdsimpan.TabIndex = 13
        Me.cmdsimpan.Text = "Simpan"
        Me.cmdsimpan.UseVisualStyleBackColor = True
        '
        'cmdkeluar
        '
        Me.cmdkeluar.Location = New System.Drawing.Point(283, 450)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(75, 23)
        Me.cmdkeluar.TabIndex = 14
        Me.cmdkeluar.Text = "Keluar"
        Me.cmdkeluar.UseVisualStyleBackColor = True
        '
        'cmdcetak
        '
        Me.cmdcetak.Location = New System.Drawing.Point(16, 450)
        Me.cmdcetak.Name = "cmdcetak"
        Me.cmdcetak.Size = New System.Drawing.Size(119, 23)
        Me.cmdcetak.TabIndex = 15
        Me.cmdcetak.Text = "Cetak Faktur"
        Me.cmdcetak.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.GridColor = System.Drawing.Color.Cyan
        Me.dg.Location = New System.Drawing.Point(16, 151)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersWidth = 51
        Me.dg.RowTemplate.Height = 24
        Me.dg.Size = New System.Drawing.Size(904, 262)
        Me.dg.TabIndex = 16
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lbltgl
        '
        Me.lbltgl.AutoSize = True
        Me.lbltgl.Location = New System.Drawing.Point(323, 29)
        Me.lbltgl.Name = "lbltgl"
        Me.lbltgl.Size = New System.Drawing.Size(35, 16)
        Me.lbltgl.TabIndex = 17
        Me.lbltgl.Text = "lbltgl"
        '
        'lbltotbay
        '
        Me.lbltotbay.AutoSize = True
        Me.lbltotbay.Location = New System.Drawing.Point(604, 25)
        Me.lbltotbay.Name = "lbltotbay"
        Me.lbltotbay.Size = New System.Drawing.Size(77, 16)
        Me.lbltotbay.TabIndex = 18
        Me.lbltotbay.Text = "Total Bayar"
        '
        'lbltotqty
        '
        Me.lbltotqty.AutoSize = True
        Me.lbltotqty.Location = New System.Drawing.Point(604, 76)
        Me.lbltotqty.Name = "lbltotqty"
        Me.lbltotqty.Size = New System.Drawing.Size(55, 16)
        Me.lbltotqty.TabIndex = 19
        Me.lbltotqty.Text = "Quantity"
        '
        'lblterbilang
        '
        Me.lblterbilang.AutoSize = True
        Me.lblterbilang.Location = New System.Drawing.Point(13, 110)
        Me.lblterbilang.Name = "lblterbilang"
        Me.lblterbilang.Size = New System.Drawing.Size(65, 16)
        Me.lblterbilang.TabIndex = 20
        Me.lblterbilang.Text = "Terbilang"
        '
        'FJual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 517)
        Me.Controls.Add(Me.lblterbilang)
        Me.Controls.Add(Me.lbltotqty)
        Me.Controls.Add(Me.lbltotbay)
        Me.Controls.Add(Me.lbltgl)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.cmdcetak)
        Me.Controls.Add(Me.cmdkeluar)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.cmdtambahpelanggan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtkembali)
        Me.Controls.Add(Me.txtjmluang)
        Me.Controls.Add(Me.txtpelanggannama)
        Me.Controls.Add(Me.cmdcaripelanggan)
        Me.Controls.Add(Me.cmdbaru)
        Me.Controls.Add(Me.txtpelangganid)
        Me.Controls.Add(Me.txtjualnofaktur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FJual"
        Me.Text = "ENTRI DATA PENJUALAN"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtjualnofaktur As TextBox
    Friend WithEvents txtpelangganid As TextBox
    Friend WithEvents cmdbaru As Button
    Friend WithEvents cmdcaripelanggan As Button
    Friend WithEvents txtpelanggannama As TextBox
    Friend WithEvents txtjmluang As TextBox
    Friend WithEvents txtkembali As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdtambahpelanggan As Button
    Friend WithEvents cmdsimpan As Button
    Friend WithEvents cmdkeluar As Button
    Friend WithEvents cmdcetak As Button
    Friend WithEvents dg As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbltgl As Label
    Friend WithEvents lbltotbay As Label
    Friend WithEvents lbltotqty As Label
    Friend WithEvents lblterbilang As Label
End Class
