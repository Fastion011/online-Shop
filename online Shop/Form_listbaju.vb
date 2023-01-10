Imports MySql.Data.MySqlClient

Public Class Form_listbaju
    Sub Tampil()
        Call buka()
        adapter = New MySqlDataAdapter("select * from baju", conn)
        data = New DataSet
        adapter.Fill(data, "baju")
        dgv_list_baju.DataSource = data.Tables("baju")
    End Sub

    Private Sub Form_listbaju_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampil()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call buka()
        cmd = New MySqlCommand("Select * from baju where  nama_baju like '%" & TextBox1.Text & "%'", conn)
        baca = cmd.ExecuteReader()
        baca.Read()

        If baca.HasRows Then
            Call buka()
            adapter = New MySqlDataAdapter("Select * from baju where  nama_baju like '%" & TextBox1.Text & "%'", conn)
            data = New DataSet
            adapter.Fill(data, "ketemudata")
            dgv_list_baju.DataSource = data.Tables("ketemudata")
            dgv_list_baju.ReadOnly = True

        End If

    End Sub

    Private Sub dgv_list_baju_Click(sender As Object, e As EventArgs) Handles dgv_list_baju.Click
        Dim i As Integer

        i = dgv_list_baju.CurrentRow.Index
        Call buka()
        cmd = New MySqlCommand("select * from baju where id_baju = '" & dgv_list_baju.Item(0, i).Value & "'", conn)
        baca = cmd.ExecuteReader
        baca.Read()
        If baca.HasRows Then
            detail.Label1.Text = baca.Item("nama_baju")
            detail.Label2.Text = baca.Item("ukuran_baju")
            detail.Label3.Text = baca.Item("jenis_kain")
            detail.Label4.Text = baca.Item("harga")
            detail.Label5.Text = baca.Item("url")
            detail.PictureBox1.ImageLocation = detail.Label5.Text
            detail.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        detail.ShowDialog()
    End Sub

    Private Sub dgv_list_baju_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_list_baju.CellContentClick

    End Sub
End Class