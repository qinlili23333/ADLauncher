Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Icon = New Icon("Launcher.ico")
        Catch ex As Exception

        End Try

        BackgroundImage = System.Drawing.Image.FromFile("DefaultSplash.jpg")
        Try
            BackgroundImage = System.Drawing.Image.FromFile("ADCache.jpg")

        Catch ex As Exception

        End Try
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub
End Class
