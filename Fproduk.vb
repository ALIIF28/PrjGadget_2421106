Public Class FProduk
    Dim sql As String
    Sub tampilproduk(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "produk_2421106")
        dg.DataSource = (ds.Tables("produk_2421106"))
        kon.Close()
    End Sub
    Sub prosesproduk(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        perintah.ExecuteNonQuery()
        kon.Close()
    End Sub
    Sub ambilkategori()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from kategori_2421106 order by kategoriid"
        cek = perintah.ExecuteReader
        While cek.Read
            cmbkategori.Items.Add(cek.Item("kategoriid") & " - " & cek.Item("kategorinama"))
        End While
        cek.Close()
        kon.Close()
    End Sub
    Sub ambilmerk()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from merk_2421106 order by merkid"
        cek = perintah.ExecuteReader
        While cek.Read
            cmbmerk.Items.Add(cek.Item("merkid") & " - " & cek.Item("merknama"))
        End While
        cek.Close()
        kon.Close()
    End Sub
    Sub setdg()
        dg.Columns(0).HeaderText = "Kode Produk"
        dg.Columns(1).HeaderText = "Nama Produk"
        dg.Columns(2).HeaderText = "Kategori"
        dg.Columns(3).HeaderText = "Merk"
        dg.Columns(4).HeaderText = "Stok"

        dg.Columns(0).Width = 80
        dg.Columns(1).Width = 200
        dg.Columns(2).Width = 150
        dg.Columns(3).Width = 100
        dg.Columns(4).Width = 50
    End Sub
    Sub tidakaktif()
        txtprodukid.Enabled = False
        txtproduknama.Enabled = False
        txtprodukstok.Enabled = False

        txtprodukid.BackColor = Color.Gray
        txtproduknama.BackColor = Color.Gray
        txtprodukstok.BackColor = Color.Gray
    End Sub
    Sub aktif()
        txtproduknama.Enabled = True
        txtprodukstok.Enabled = True

        txtprodukid.BackColor = Color.White
        txtproduknama.BackColor = Color.White
        txtprodukstok.BackColor = Color.White
    End Sub

    Private Sub FProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tidakaktif()
        bersih()

        tampilproduk("SELECT produkid,produknama,kategorinama,merknama, " &
                     " produkstok FROM produk_2421106 JOIN kategori_2421106 " &
                     " ON produkkategoriid=kategoriid JOIN merk_2421106 ON " &
                     " produkmerkid=merkid ORDER BY produkid")
        setdg()

        cmdsimpan.Enabled = False
    End Sub
    Sub bersih()
        txtprodukid.Text = ""
        txtproduknama.Text = ""
        txtprodukstok.Text = ""
    End Sub

    Private Sub cmdtambah_Click(sender As Object, e As EventArgs) Handles cmdtambah.Click
        If cmdtambah.Text = "Tambah" Then
            cmdtambah.Text = "Batal"
            txtprodukid.Enabled = True
            txtprodukid.BackColor = Color.White
            txtprodukid.Focus()
            bersih()
        Else
            cmdtambah.Text = "Tambah"
            tidakaktif()
            bersih()
        End If
        cmdsimpan.Text = "Simpan"
    End Sub

    Private Sub cmdhapus_Click(sender As Object, e As EventArgs) Handles cmdhapus.Click
        prosesproduk("delete from produk_2421106 where produkid='" & txtprodukid.Text & "'")

        tampilproduk("SELECT produkid,produknama,kategorinama,merknama,produkstok " &
                     " FROM produk_2421106 JOIN kategori_2421106 ON produkkategoriid=kategoriid JOIN " &
                     " merk_2421106 ON produkmerkid=merkid")
        setdg()

        cmdtambah_Click(e, AcceptButton)
    End Sub

    Private Sub cmdsimpan_Click(sender As Object, e As EventArgs) Handles cmdsimpan.Click
        If cmdsimpan.Text = "Simpan" Then
            prosesproduk("INSERT INTO produk_2421106 VALUES('" & txtprodukid.Text & "', '" &
                         txtproduknama.Text & "','" & cmbkategori.Text.Substring(0, 1) & "', '" &
                         cmbmerk.Text.Substring(0, 1) & "','" & txtprodukstok.Text & "')")
        Else
            prosesproduk("UPDATE produk_2421106 SET produknama='" & txtproduknama.Text & "', " &
                         " produkkategoriid='" & cmbkategori.Text.Substring(0, 1) & "', " &
                         " produkmerkid='" & cmbmerk.Text.Substring(0, 1) & "', " &
                         " produkstok='" & txtprodukstok.Text & "' WHERE produkid='" & txtprodukid.Text & "'")
        End If

        tampilproduk("SELECT produkid,produknama,kategorinama,merknama,produkstok " &
                     " FROM produk_2421106 JOIN kategori_2421106 ON produkkategoriid=kategoriid JOIN " &
                     " merk_2421106 ON produkmerkid=merkid order by produkid")
        setdg()
        bersih()
        tidakaktif()
        cmdtambah.Enabled = True
    End Sub

    Private Sub cmdkeluar_Click(sender As Object, e As EventArgs) Handles cmdkeluar.Click
        Me.Dispose()
        Fmenu.Show()
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        tampilproduk("SELECT produkid,produknama,kategorinama,merknama,produkstok " &
        " FROM produk_2421106 JOIN kategori_2421106 ON produkkategoriid=kategoriid JOIN " &
        " merk_2421106 ON produkmerkid=merkid where produkid='" & txtcari.Text & "' " &
        " or produknama like '%" & txtcari.Text & "%'")
        setdg()
    End Sub

    Private Sub FProduk_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        cmbkategori.Items.Clear()
        cmbmerk.Items.Clear()
        ambilkategori()
        ambilmerk()
    End Sub

    Private Sub cmdcarikategori_Click(sender As Object, e As EventArgs) Handles cmdcarikategori.Click
        FCarikategori.Show()
    End Sub

    Private Sub cmdcarimerk_Click(sender As Object, e As EventArgs) Handles cmdcarimerk.Click
        FCarimerk.Show()
    End Sub

    Private Sub txtprodukid_TextChanged(sender As Object, e As EventArgs) Handles txtprodukid.TextChanged

    End Sub

    Private Sub txtprodukid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprodukid.KeyPress
        If e.KeyChar = Chr(13) Then
            txtprodukid.Text = UCase(txtprodukid.Text)
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "select produk_2421106.*,kategorinama,merknama " &
            " from produk_2421106 join kategori_2421106 on produkkategoriid=kategoriid " &
            " join merk_2421106 on produkmerkid=merkid where produkid='" & txtprodukid.Text & "'"
            cek = perintah.ExecuteReader
            cek.Read()
            If cek.HasRows Then
                txtprodukid.Enabled = False

                txtproduknama.Text = cek.Item("produknama")
                cmbkategori.Text = cek.Item("produkkategoriid") & " - " & cek.Item("kategorinama")
                cmbmerk.Text = cek.Item("produkmerkid") & " - " & cek.Item("merknama")
                txtprodukstok.Text = cek.Item("produkstok")

                cmdsimpan.Text = "Update"
            Else
                cmdsimpan.Text = "Simpan"
            End If
            cek.Close()
            kon.Close()
            aktif()
            txtproduknama.Focus()
            cmdsimpan.Enabled = True
        End If
    End Sub
End Class