Imports MySql.Data.MySqlClient
Public Class Listcelana
    Sub tampil()
        Call buka()
        adapter = New MySqlDataAdapter("select * from celana", conn)
        data = New DataSet
        adapter.Fill(data, "celana")
        dgv_list_celana.DataSource = data.Tables("celana")
    End Sub
    Private Sub Listcelana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil()

    End Sub

    Private Sub dgv_list_celana_Click(sender As Object, e As EventArgs) Handles dgv_list_celana.Click
        Dim i As Integer

        i = dgv_list_celana.CurrentRow.Index
        Call buka()
        cmd = New MySqlCommand("select * from celana where id_celana = '" & dgv_list_celana.Item(0, i).Value & "'", conn)
        baca = cmd.ExecuteReader
        baca.Read()
        If baca.HasRows Then
            detail.Label1.Text = baca.Item("nama_celana")
            detail.Label2.Text = baca.Item("ukuran_celana")
            detail.Label3.Text = baca.Item("jenis_kain")
            detail.Label4.Text = baca.Item("harga")
            detail.Label5.Text = baca.Item("url")
            detail.PictureBox1.ImageLocation = detail.Label5.Text
            detail.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        detail.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call buka()
        cmd = New MySqlCommand("Select * from celana where  nama_celana like '%" & TextBox1.Text & "%'", conn)
        baca = cmd.ExecuteReader()
        baca.Read()

        If baca.HasRows Then
            Call buka()
            adapter = New MySqlDataAdapter("Select * from celana where  nama_celana like '%" & TextBox1.Text & "%'", conn)
            data = New DataSet
            adapter.Fill(data, "ketemudata")
            dgv_list_celana.DataSource = data.Tables("ketemudata")
            dgv_list_celana.ReadOnly = True

        End If
    End Sub
End Class