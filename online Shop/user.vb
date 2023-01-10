Imports MySql.Data.MySqlClient
Public Class user
    Sub pengguna()
        Call buka()
        Dim str As String
        str = "select * from user where id = '" & login.txt1.Text & "'"
        cmd = New MySqlCommand(str, conn)
        baca = cmd.ExecuteReader
        baca.Read()

        If baca.HasRows Then
            Label1.Text = baca.Item("id")
            TextBox1.Text = baca.Item("id")
            TextBox2.Text = baca.Item("tanggal_lahir")
            TextBox3.Text = baca.Item("no")
        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class