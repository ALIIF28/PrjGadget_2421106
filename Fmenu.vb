Public Class Fmenu

    Private Sub GantiPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        Fgantipassword.Show()
    End Sub

    Private Sub ManajemenUserToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ManajemenUserToolStripMenuItem.Click
        Fuser.ShowDialog()
    End Sub

    Private Sub LaporanDataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanDataProdukToolStripMenuItem.Click
        FProduk.ShowDialog()
    End Sub

    Private Sub LaporanDataPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanDataPelangganToolStripMenuItem.Click
        FPelanggan.ShowDialog()
    End Sub

    Private Sub Fmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        End
    End Sub
End Class