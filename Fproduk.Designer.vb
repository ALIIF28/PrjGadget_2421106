<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FProduk
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtprodukid = New System.Windows.Forms.TextBox()
        Me.txtproduknama = New System.Windows.Forms.TextBox()
        Me.cmbkategori = New System.Windows.Forms.ComboBox()
        Me.cmbmerk = New System.Windows.Forms.ComboBox()
        Me.txtprodukstok = New System.Windows.Forms.TextBox()
        Me.cmdtambah = New System.Windows.Forms.Button()
        Me.cmdsimpan = New System.Windows.Forms.Button()
        Me.cmdhapus = New System.Windows.Forms.Button()
        Me.cmdkeluar = New System.Windows.Forms.Button()
        Me.cmdcarikategori = New System.Windows.Forms.Button()
        Me.cmdcarimerk = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Produk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kategori"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Merk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stok"
        '
        'txtprodukid
        '
        Me.txtprodukid.Location = New System.Drawing.Point(137, 35)
        Me.txtprodukid.Name = "txtprodukid"
        Me.txtprodukid.Size = New System.Drawing.Size(100, 22)
        Me.txtprodukid.TabIndex = 5
        '
        'txtproduknama
        '
        Me.txtproduknama.Location = New System.Drawing.Point(137, 69)
        Me.txtproduknama.Name = "txtproduknama"
        Me.txtproduknama.Size = New System.Drawing.Size(100, 22)
        Me.txtproduknama.TabIndex = 6
        '
        'cmbkategori
        '
        Me.cmbkategori.FormattingEnabled = True
        Me.cmbkategori.Location = New System.Drawing.Point(137, 106)
        Me.cmbkategori.Name = "cmbkategori"
        Me.cmbkategori.Size = New System.Drawing.Size(121, 24)
        Me.cmbkategori.TabIndex = 7
        '
        'cmbmerk
        '
        Me.cmbmerk.FormattingEnabled = True
        Me.cmbmerk.Location = New System.Drawing.Point(137, 141)
        Me.cmbmerk.Name = "cmbmerk"
        Me.cmbmerk.Size = New System.Drawing.Size(121, 24)
        Me.cmbmerk.TabIndex = 8
        '
        'txtprodukstok
        '
        Me.txtprodukstok.Location = New System.Drawing.Point(137, 183)
        Me.txtprodukstok.Name = "txtprodukstok"
        Me.txtprodukstok.Size = New System.Drawing.Size(100, 22)
        Me.txtprodukstok.TabIndex = 9
        '
        'cmdtambah
        '
        Me.cmdtambah.Location = New System.Drawing.Point(28, 231)
        Me.cmdtambah.Name = "cmdtambah"
        Me.cmdtambah.Size = New System.Drawing.Size(75, 23)
        Me.cmdtambah.TabIndex = 10
        Me.cmdtambah.Text = "Tambah"
        Me.cmdtambah.UseVisualStyleBackColor = True
        '
        'cmdsimpan
        '
        Me.cmdsimpan.Location = New System.Drawing.Point(137, 231)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(75, 23)
        Me.cmdsimpan.TabIndex = 11
        Me.cmdsimpan.Text = "Simpan"
        Me.cmdsimpan.UseVisualStyleBackColor = True
        '
        'cmdhapus
        '
        Me.cmdhapus.Location = New System.Drawing.Point(247, 231)
        Me.cmdhapus.Name = "cmdhapus"
        Me.cmdhapus.Size = New System.Drawing.Size(75, 23)
        Me.cmdhapus.TabIndex = 12
        Me.cmdhapus.Text = "Hapus"
        Me.cmdhapus.UseVisualStyleBackColor = True
        '
        'cmdkeluar
        '
        Me.cmdkeluar.Location = New System.Drawing.Point(354, 231)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(75, 23)
        Me.cmdkeluar.TabIndex = 13
        Me.cmdkeluar.Text = "Keluar"
        Me.cmdkeluar.UseVisualStyleBackColor = True
        '
        'cmdcarikategori
        '
        Me.cmdcarikategori.Location = New System.Drawing.Point(288, 107)
        Me.cmdcarikategori.Name = "cmdcarikategori"
        Me.cmdcarikategori.Size = New System.Drawing.Size(75, 23)
        Me.cmdcarikategori.TabIndex = 14
        Me.cmdcarikategori.Text = "+"
        Me.cmdcarikategori.UseVisualStyleBackColor = True
        '
        'cmdcarimerk
        '
        Me.cmdcarimerk.Location = New System.Drawing.Point(288, 142)
        Me.cmdcarimerk.Name = "cmdcarimerk"
        Me.cmdcarimerk.Size = New System.Drawing.Size(75, 23)
        Me.cmdcarimerk.TabIndex = 15
        Me.cmdcarimerk.Text = "+"
        Me.cmdcarimerk.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Cari Kode / Nama Produk"
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(28, 300)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(382, 22)
        Me.txtcari.TabIndex = 17
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(28, 328)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersWidth = 51
        Me.dg.RowTemplate.Height = 24
        Me.dg.Size = New System.Drawing.Size(652, 163)
        Me.dg.TabIndex = 18
        '
        'Fproduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 503)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdcarimerk)
        Me.Controls.Add(Me.cmdcarikategori)
        Me.Controls.Add(Me.cmdkeluar)
        Me.Controls.Add(Me.cmdhapus)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.cmdtambah)
        Me.Controls.Add(Me.txtprodukstok)
        Me.Controls.Add(Me.cmbmerk)
        Me.Controls.Add(Me.cmbkategori)
        Me.Controls.Add(Me.txtproduknama)
        Me.Controls.Add(Me.txtprodukid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Fproduk"
        Me.Text = "DATA PRODUK"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtprodukid As TextBox
    Friend WithEvents txtproduknama As TextBox
    Friend WithEvents cmbkategori As ComboBox
    Friend WithEvents cmbmerk As ComboBox
    Friend WithEvents txtprodukstok As TextBox
    Friend WithEvents cmdtambah As Button
    Friend WithEvents cmdsimpan As Button
    Friend WithEvents cmdhapus As Button
    Friend WithEvents cmdkeluar As Button
    Friend WithEvents cmdcarikategori As Button
    Friend WithEvents cmdcarimerk As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcari As TextBox
    Friend WithEvents dg As DataGridView
End Class
