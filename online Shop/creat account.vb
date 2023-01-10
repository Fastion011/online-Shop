Imports MySql.Data.MySqlClient


Public Class creat_account
    Sub tampil()
        Call buka()
        adapter = New MySqlDataAdapter("select * from user", conn)
        data = New DataSet
        adapter.Fill(data, "user")
    End Sub

    Sub refres()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call buka()
        Dim simpan As String = "insert into user values ('" & TextBox1.Text & "' ,'" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "')"
        cmd = New MySqlCommand(simpan, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil membuat account")
        Call refres()
        Me.Hide()
    End Sub

    Private Sub creat_account_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class