Imports MySql.Data.MySqlClient
Public Class detail
    Private Sub detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Bayar.Label5.Text = Label1.Text
        Bayar.Label6.Text = Label2.Text
        Bayar.Label7.Text = Label3.Text
        Bayar.Label11.Text = Label4.Text
        Bayar.TextBox1.Text = Label4.Text
        Bayar.ShowDialog()
    End Sub
End Class