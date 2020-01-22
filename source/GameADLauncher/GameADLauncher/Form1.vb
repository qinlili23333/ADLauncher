Public Class Form1
    Private ADURL As String
    Private Declare Function timeGetTime Lib "winmm.dll" () As Long
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
        Try
            Me.ADURL = My.Computer.FileSystem.ReadAllText("ADCache.cfg")
            Me.Cursor = System.Windows.Forms.Cursors.Hand
        Catch ex As Exception
        End Try
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            Dim Savetime As Double

            Savetime = timeGetTime
            While timeGetTime < Savetime + Double.Parse(Command)

                Application.DoEvents()
            End While
            End
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        If Me.ADURL IsNot Nothing Then
            System.Diagnostics.Process.Start(Me.ADURL)
        End If
    End Sub
End Class
