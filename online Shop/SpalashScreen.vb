Public Class SpalashScreen
    Dim progres As Integer = 0

    'menjalankana timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim newprogres = progres + 1

        If (newprogres <= 100) Then
            Label1.Text = newprogres & "%"
            ProgressBar1.Value = newprogres
            progres = newprogres
        Else
            Timer1.Stop()
            Me.Hide()
            MainMenu.ShowDialog()

        End If
    End Sub

    Private Sub SpalashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
