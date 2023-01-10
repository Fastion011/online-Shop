Public Class MainMenu
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles loginmenu.Click
        login.ShowDialog()
    End Sub

    Private Sub BajuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajuToolStripMenuItem.Click
        baju.ShowDialog()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles usermenu.Click
        user.ShowDialog()
    End Sub

    Private Sub CelanaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CelanaToolStripMenuItem.Click
        celana.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form_listbaju.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Listcelana.ShowDialog()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Form_laporan.ShowDialog()
    End Sub

    Private Sub DataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem.Click
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataBarangToolStripMenuItem.Enabled = False
        Bayar.Button2.Enabled = False
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click

    End Sub
End Class