Imports MySql.Data.MySqlClient
Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("username dan assword tidak boleh kosong")

        Else
            Call buka()
            cmd = New MySqlCommand(" select * from user where id = '" & txt1.Text & "' and password = '" & TextBox2.Text & "'", conn)
            baca = cmd.ExecuteReader
            baca.Read()

            If baca.HasRows Then


                Me.Hide()
                MsgBox("login Berhasil")
                user.pengguna()
                Bayar.Button2.Enabled = True



            Else
                MsgBox("username dan password salah")





            End If
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        creat_account.ShowDialog()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        admin.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub
End Class