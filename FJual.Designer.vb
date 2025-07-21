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
        Me.txtjualnofaktur = New System.Windows.Forms.TextBox()
        Me.txtpelangganid = New System.Windows.Forms.TextBox()
        Me.cmdbaru = New System.Windows.Forms.Button()
        Me.cmdcaripelanggan = New System.Windows.Forms.Button()
        Me.txtpelanggannama = New System.Windows.Forms.TextBox()
        Me.txtjmluang = New System.Windows.Forms.TextBox()
        Me.txtkembali = New System.Windows.Forms.TextBox()
        Me.cmdtambahpelanggan = New System.Windows.Forms.Button()
        Me.cmdsimpan = New System.Windows.Forms.Button()
        Me.cmdkeluar = New System.Windows.Forms.Button()
        Me.cmdcetak = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbltgl = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbltotbay = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbltotqty = New System.Windows.Forms.Label()
        Me.lblterbilang = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.cmdbaru.Size = New System.Drawing.Size(43, 23)
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
        Me.txtpelanggannama.Location = New System.Drawing.Point(306, 70)
        Me.txtpelanggannama.Name = "txtpelanggannama"
        Me.txtpelanggannama.Size = New System.Drawing.Size(203, 22)
        Me.txtpelanggannama.TabIndex = 7
        '
        'txtjmluang
        '
        Me.txtjmluang.Location = New System.Drawing.Point(812, 479)
        Me.txtjmluang.Name = "txtjmluang"
        Me.txtjmluang.Size = New System.Drawing.Size(100, 22)
        Me.txtjmluang.TabIndex = 8
        '
        'txtkembali
        '
        Me.txtkembali.Location = New System.Drawing.Point(812, 517)
        Me.txtkembali.Name = "txtkembali"
        Me.txtkembali.Size = New System.Drawing.Size(100, 22)
        Me.txtkembali.TabIndex = 9
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
        Me.cmdsimpan.Location = New System.Drawing.Point(263, 516)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(75, 23)
        Me.cmdsimpan.TabIndex = 13
        Me.cmdsimpan.Text = "Simpan"
        Me.cmdsimpan.UseVisualStyleBackColor = True
        '
        'cmdkeluar
        '
        Me.cmdkeluar.Location = New System.Drawing.Point(382, 516)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(75, 23)
        Me.cmdkeluar.TabIndex = 14
        Me.cmdkeluar.Text = "Keluar"
        Me.cmdkeluar.UseVisualStyleBackColor = True
        '
        'cmdcetak
        '
        Me.cmdcetak.Location = New System.Drawing.Point(105, 516)
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
        Me.dg.Location = New System.Drawing.Point(30, 192)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersWidth = 51
        Me.dg.RowTemplate.Height = 24
        Me.dg.Size = New System.Drawing.Size(904, 281)
        Me.dg.TabIndex = 16
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "No Faktur"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Pelanggan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(692, 485)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Jumlah Uang"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(692, 524)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Kembali"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 173)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 16)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Data Produk"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(27, 485)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(307, 16)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Tekan Tombol Esc Untuk Menghapus item Produk"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(725, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 80)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total Bayar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbltotbay)
        Me.Panel1.Location = New System.Drawing.Point(6, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(181, 39)
        Me.Panel1.TabIndex = 0
        '
        'lbltgl
        '
        Me.lbltgl.AutoSize = True
        Me.lbltgl.BackColor = System.Drawing.Color.RosyBrown
        Me.lbltgl.Location = New System.Drawing.Point(303, 25)
        Me.lbltgl.Name = "lbltgl"
        Me.lbltgl.Size = New System.Drawing.Size(35, 16)
        Me.lbltgl.TabIndex = 0
        Me.lbltgl.Text = "lbltgl"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Location = New System.Drawing.Point(725, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 61)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Quantity"
        '
        'lbltotbay
        '
        Me.lbltotbay.AutoSize = True
        Me.lbltotbay.Location = New System.Drawing.Point(9, 11)
        Me.lbltotbay.Name = "lbltotbay"
        Me.lbltotbay.Size = New System.Drawing.Size(58, 16)
        Me.lbltotbay.TabIndex = 0
        Me.lbltotbay.Text = "lbltotbay"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbltotqty)
        Me.Panel2.Location = New System.Drawing.Point(18, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(176, 34)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblterbilang)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 111)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(566, 61)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Terbilang"
        '
        'lbltotqty
        '
        Me.lbltotqty.AutoSize = True
        Me.lbltotqty.Location = New System.Drawing.Point(3, 9)
        Me.lbltotqty.Name = "lbltotqty"
        Me.lbltotqty.Size = New System.Drawing.Size(53, 16)
        Me.lbltotqty.TabIndex = 0
        Me.lbltotqty.Text = "lbltotqty"
        '
        'lblterbilang
        '
        Me.lblterbilang.AutoSize = True
        Me.lblterbilang.Location = New System.Drawing.Point(18, 30)
        Me.lblterbilang.Name = "lblterbilang"
        Me.lblterbilang.Size = New System.Drawing.Size(73, 16)
        Me.lblterbilang.TabIndex = 0
        Me.lblterbilang.Text = "lblterbilang"
        '
        'FJual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 567)
        Me.Controls.Add(Me.lbltgl)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.cmdcetak)
        Me.Controls.Add(Me.cmdkeluar)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.cmdtambahpelanggan)
        Me.Controls.Add(Me.txtkembali)
        Me.Controls.Add(Me.txtjmluang)
        Me.Controls.Add(Me.txtpelanggannama)
        Me.Controls.Add(Me.cmdcaripelanggan)
        Me.Controls.Add(Me.cmdbaru)
        Me.Controls.Add(Me.txtpelangganid)
        Me.Controls.Add(Me.txtjualnofaktur)
        Me.Name = "FJual"
        Me.Text = "ENTRI DATA PENJUALAN"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtjualnofaktur As TextBox
    Friend WithEvents txtpelangganid As TextBox
    Friend WithEvents cmdbaru As Button
    Friend WithEvents cmdcaripelanggan As Button
    Friend WithEvents txtpelanggannama As TextBox
    Friend WithEvents txtjmluang As TextBox
    Friend WithEvents txtkembali As TextBox
    Friend WithEvents cmdtambahpelanggan As Button
    Friend WithEvents cmdsimpan As Button
    Friend WithEvents cmdkeluar As Button
    Friend WithEvents cmdcetak As Button
    Friend WithEvents dg As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbltgl As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbltotbay As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbltotqty As Label
    Friend WithEvents lblterbilang As Label
End Class
