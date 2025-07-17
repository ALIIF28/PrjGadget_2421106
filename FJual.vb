Imports MySql.Data.MySqlClient
Public Class FJual
    Dim i, no As Integer
    Dim totsel, kembali As Double

    Function terbilang(ByVal n As Double) As String
        Dim satuan As String() = {"", "Satu", "Dua", "Tiga", "Empat", "Lima", "Enam", "Tujuh", "Delapan", "Sembilan", "Sepuluh", "Sebelas"}
        Select Case n
            Case 0 To 11
                terbilang = " " + satuan(Fix(n))
            Case 12 To 19
                terbilang = terbilang(n Mod 10) + " Belas"
            Case 20 To 99
                terbilang = terbilang(Fix(n / 10)) + " Puluh " + terbilang(n Mod 10)
            Case 100 To 199
                terbilang = " Seratus" + terbilang(n - 100)
            Case 200 To 999
                terbilang = terbilang(Fix(n / 100)) + " Ratus " + terbilang(n Mod 100)
            Case 1000 To 1999
                terbilang = " Seribu" + terbilang(n - 1000)
            Case 2000 To 999999
                terbilang = terbilang(Fix(n / 1000)) + " Ribu " + terbilang(n Mod 1000)
            Case 1000000 To 999999999
                terbilang = terbilang(Fix(n / 1000000)) + " Juta " + terbilang(n Mod 1000000)
            Case 1000000000 To 999999999999
                terbilang = terbilang(Fix(n / 1000000000)) + " Milyar " + terbilang(n Mod 1000000000)
            Case Else
                terbilang = terbilang(Fix(n / 1000000000000)) + " Trilyun " + terbilang(n Mod 1000000000000)
        End Select
    End Function

    Sub tidakaktif()
        txtjualnofaktur.Enabled = False
        txtpelangganid.Enabled = False
        txtpelanggannama.Enabled = False
        txtjmluang.Enabled = False
        txtkembali.Enabled = False
        txtjualnofaktur.BackColor = Color.Gray
        txtpelangganid.BackColor = Color.Gray
        txtpelanggannama.BackColor = Color.Gray
        txtjmluang.BackColor = Color.Gray
        txtkembali.BackColor = Color.Gray
        cmdcetak.Enabled = False
        cmdsimpan.Enabled = False
        dg.Enabled = False
    End Sub

    Sub aktif()
        txtjualnofaktur.Enabled = True
        txtpelangganid.Enabled = True
        txtpelanggannama.Enabled = True
        txtjmluang.Enabled = True
        txtkembali.Enabled = True
        txtjualnofaktur.BackColor = Color.White
        txtpelangganid.BackColor = Color.White
        txtpelanggannama.BackColor = Color.White
        txtjmluang.BackColor = Color.White
        txtkembali.BackColor = Color.White
        cmdcetak.Enabled = True
        cmdsimpan.Enabled = True
        dg.Enabled = True
    End Sub

    Sub bersih()
        txtjualnofaktur.Text = ""
        txtpelangganid.Text = ""
        txtpelanggannama.Text = ""
        txtjmluang.Text = ""
        txtkembali.Text = ""
        lbltgl.Text = ""
        lblterbilang.Text = ""
        lbltotbay.Text = ""
        lbltotqty.Text = ""
    End Sub

    Sub buatkolom()
        dg.Columns.Add("kode", "Kode Produk")
        dg.Columns.Add("nama", "Nama Produk")
        dg.Columns.Add("imei", "No. IMEI/No. Seri")
        dg.Columns.Add("qty", "Quantity")
        dg.Columns.Add("harga", "Harga Jual")
        dg.Columns.Add("subtotal", "Sub Total (Rp)")
        dg.Columns(0).Width = 120
        dg.Columns(1).Width = 350
        dg.Columns(2).Width = 150
        dg.Columns(3).Width = 75
        dg.Columns(4).Width = 120
        dg.Columns(5).Width = 150
        dg.Columns(5).DefaultCellStyle.Format = "Rp ###,###,###"
        dg.Columns(1).ReadOnly = True
        dg.Columns(5).ReadOnly = True
    End Sub

    Sub hitungtotal()
        Dim total As Double
        For i = 0 To dg.Rows.Count - 1
            total += dg.Rows(i).Cells(5).Value
        Next
        lbltotbay.Text = Format(total, "Rp ###,###,###")
        lblterbilang.Text = UCase(terbilang(total)) & " RUPIAH"
    End Sub

    Sub hitungtotalQty()
        Dim totqty As Double
        For i = 0 To dg.Rows.Count - 1
            totqty += dg.Rows(i).Cells(3).Value
        Next
        lbltotqty.Text = totqty
    End Sub

    Sub simpantransaksi()
        For i = 0 To dg.RowCount - 2
            kon.Open()
            perintah.Connection = kon
            perintah.CommandText = "INSERT INTO jual (...)"
            perintah.ExecuteNonQuery()
            kon.Close()
        Next
        MsgBox("Data Sukses Disimpan", MsgBoxStyle.Information, "Informasi")
    End Sub

    Sub buatfaktur()
        Dim kode, tgl As String
        Dim no As Integer
        tgl = Format(Now, "ddMMyyyy")
        kon.Open()
        perintah.Connection = kon
        perintah.CommandText = "SELECT ..."
        cek = perintah.ExecuteReader()
        cek.Read()
        If cek.HasRows Then
            kode = cek.Item("jualnofaktur")
            no = Val(Mid(kode, 3, 4)) + 1
            txtjualnofaktur.Text = "F-" & Format(no, "0001") & tgl
        Else
            txtjualnofaktur.Text = "F-0001" & tgl
        End If
        cek.Close()
        kon.Close()
    End Sub

    Private Sub FJual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call buatkolom()
        totsel = 0
        tidakaktif()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltgl.Text = Format(Now, "dd MMMM yyyy") & " -- " & Format(Now, "H : mm : ss")
    End Sub
End Class
