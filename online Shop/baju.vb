Imports MySql.Data.MySqlClient
Public Class baju

    'menampilkan database
    Sub tampil()
        Call buka()
        adapter = New MySqlDataAdapter("select * from baju", conn)
        data = New DataSet
        adapter.Fill(data, "baju")
        dgv_baju.DataSource = data.Tables("baju")
    End Sub

    Private Sub baju_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil()
    End Sub

    'untuk menyimpan data ke data base
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Data belum lengkap, Silahkan isi smua field dan gambar")

        Else
            Dim simpan = New Baju_db With {
            .id_baju = TextBox1.Text,
            .nama_baju = TextBox2.Text,
            .ukuran_baju = TextBox3.Text,
            .jenis_kain = TextBox5.Text,
            .harga = TextBox4.Text,
            .url = TextBox6.Text
            }

            simpan.Simpan()
            MsgBox("data berhasil disimpan")
            Call tampil()


        End If


    End Sub

    'membrsihkan isi dari textbox
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        PictureBox1.ImageLocation = ""
    End Sub


    'menghapus data dari database
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim delete = New Baju_db With {
            .id_baju = TextBox1.Text
        }
        delete.Delete()
        MsgBox("Data berhasil di hapus")
        Call tampil()
    End Sub


    'MEMANANGGIL DATA SESUI ID
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call buka()
        cmd = New MySqlCommand("select * from baju where id_baju= '" & TextBox1.Text & "'", conn)
        baca = cmd.ExecuteReader
        baca.Read()

        If baca.HasRows Then
            TextBox2.Text = baca.Item("nama_baju")
            TextBox3.Text = baca.Item("ukuran_baju")
            TextBox5.Text = baca.Item("harga")
            TextBox4.Text = baca.Item("jenis_kain")
            TextBox6.Text = baca.Item("url")
            PictureBox1.ImageLocation = TextBox6.Text
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

        End If
    End Sub


    'MENGAMBIL FOTO DARI LOKAL
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Bukafile.Filter = "*.jpg|"
        Bukafile.ShowDialog()
        TextBox6.Text = Bukafile.FileName
        PictureBox1.ImageLocation = TextBox6.Text
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
    End Sub
End Class