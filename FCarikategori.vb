Imports MySql.Data.MySqlClient
Public Class FCarikategori
    Private Sub cmdsimpan_Click(sender As Object, e As EventArgs) Handles cmdsimpan.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "INSERT INTO kategori_2421106(kategorinama) VALUES('" & txtnamakategori.Text & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
        Me.Dispose()
    End Sub

    Private Sub FCarikategori_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from kategori_2421106 order by kategoriid"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "kategori_2421106")
        dg.DataSource = ds.Tables("kategori_2421106")
        kon.Close()
    End Sub
End Class