Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Icon = New Icon("Launcher.ico")
        Catch ex As Exception

        End Try
        Try
            BackgroundImage = System.Drawing.Image.FromFile("DefaultSplash.jpg")


        Catch ex As Exception
            MessageBox.Show("默认启动图DefaultSplash.jpg丢失或损坏!", "未找到文件!")
            End
        End Try

        Try
            BackgroundImage = System.Drawing.Image.FromFile("ADCache.jpg")

        Catch ex As Exception

        End Try
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub
End Class
