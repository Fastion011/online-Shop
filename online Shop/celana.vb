Imports MySql.Data.MySqlClient
Public Class celana
    Sub tampil()
        Call buka()
        adapter = New MySqlDataAdapter("select * from celana", conn)
        data = New DataSet
        adapter.Fill(data, "celana")
        dgv_celana.DataSource = data.Tables("celana")
    End Sub

    Private Sub celana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil()

    End Sub

    'MENYIMPAN DATA KE DATABASE
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Data belum lengkap, Silahkan isi smua field")

        Else
            Dim simpan = New Celana_db With {
            .id_celana = TextBox1.Text,
            .nama_celana = TextBox2.Text,
            .ukuran_celana = TextBox3.Text,
            .jenis_kain = TextBox5.Text,
            .harga = TextBox4.Text,
            .url = TextBox6.Text
            }
            simpan.Simpan()
            MsgBox("Data berhasil di input")
            Call tampil()


        End If

    End Sub

    'MEMERSIHKAN DATA PADA TEXTBOX
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        PictureBox1.ImageLocation = ""
    End Sub


    'MENHAPUS DATA DARI DATABASAE
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim hapus = New Celana_db With {
        .id_celana = TextBox1.Text
        }
        hapus.Hapus()
        MsgBox("Data berhasil di hapus")
        Call tampil()
    End Sub

    'MENGAMBIL DATA DARI DATABASE SESUI ID 
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call buka()
        cmd = New MySqlCommand("select * from celana where id_celana= '" & TextBox1.Text & "'", conn)
        baca = cmd.ExecuteReader
        baca.Read()

        If baca.HasRows Then
            TextBox2.Text = baca.Item("nama_celana")
            TextBox3.Text = baca.Item("ukuran_celana")
            TextBox4.Text = baca.Item("harga")
            TextBox5.Text = baca.Item("jenis_kain")
            TextBox6.Text = baca.Item("url")
            PictureBox1.ImageLocation = TextBox6.Text
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage


        End If
    End Sub

    'MENGANBILL DATA DI DI LOKAL
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        bukafile2.Filter = "*.jpg|"
        bukafile2.ShowDialog()
        TextBox6.Text = bukafile2.FileName
        PictureBox1.ImageLocation = TextBox6.Text
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class