Imports MySql.Data.MySqlClient
Public Class admin
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("ID dan assword tidak boleh kosong")

        Else
            Call buka()
            cmd = New MySqlCommand(" select * from admin where id = '" & TextBox1.Text & "'", conn)
            baca = cmd.ExecuteReader
            baca.Read()

            If baca.HasRows Then


                Me.Hide()
                MsgBox("login Berhasil")
                MainMenu.DataBarangToolStripMenuItem.Enabled = True


            Else
                MsgBox("ID dan password salah")





            End If
        End If
    End Sub

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class