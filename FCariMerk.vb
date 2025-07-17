Public Class FCarimerk

    Private Sub cmdsimpan_Click(sender As Object, e As EventArgs) Handles cmdsimpan.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "INSERT INTO merk_2421106(merknama) VALUES('" & txtnamamerk.Text & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
        Me.Dispose()
    End Sub

    Private Sub FCarimerk_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from merk_2421106 order by merkid"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "merk_2421106")
        dg.DataSource = ds.Tables("merk_2421106")
        kon.Close()
    End Sub
End Class