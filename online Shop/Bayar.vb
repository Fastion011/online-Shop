Imports MySql.Data.MySqlClient
Public Class Bayar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim simpan As New Bayar_db With {
         .nama_baju = Label5.Text,
         .ukuran_baju = Label6.Text,
         .jenis_kain = Label7.Text,
         .harga = Label11.Text,
         .pembayaran = ComboBox1.Text,
         .jumlah = TextBox2.Text,
         .total = TextBox1.Text
        }
        simpan.Simpan()
        MsgBox("berhasil memesan barang")
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox1.Text = Val(Label11.Text) * Val(TextBox2.Text)
        TextBox1.Text = TextBox1.Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Bayar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("pastikan sudah login")
    End Sub
End Class