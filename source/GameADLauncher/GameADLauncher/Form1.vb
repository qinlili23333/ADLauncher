Imports LitJson

Public Class Form1
    Private ADJson As String
    Dim ADCacheJson As JsonData
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
            Me.ADJson = My.Computer.FileSystem.ReadAllText("ADCache.json")
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.ADCacheJson = LitJson.JsonMapper.ToObject(ADJson)
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
        If Me.ADCacheJson.Item("ADURL") IsNot Nothing Then
            System.Diagnostics.Process.Start(Me.ADCacheJson.Item("ADURL"))
            If Me.ADCacheJson.Item("clickToExit").ToString Like "True" Then
                End
            End If
        End If
    End Sub
End Class
