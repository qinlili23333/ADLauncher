Imports System.Net
Imports LitJson

Public Class Form1
    Private ADJson As String
    Dim ADCacheJson As JsonData
    Dim DownloadClient As New WebClient
    Private Declare Function timeGetTime Lib "winmm.dll" () As Long
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler DownloadClient.DownloadProgressChanged, AddressOf ShowDownProgress
        AddHandler DownloadClient.DownloadFileCompleted, AddressOf DownloadFileCompleted
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
            Me.ADCacheJson = LitJson.JsonMapper.ToObject(ADJson)
            If Me.ADCacheJson.Item("ADURL") IsNot Nothing Then
                Me.Cursor = System.Windows.Forms.Cursors.Hand
            End If
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
        Catch ex As Exception
        End Try
        Try
            If Me.ADCacheJson.Item("needUpdate").ToString Like "False" Then
                End
            End If
            Label1.Visible = True
            ProgressBar1.Visible = True
            DownloadClient.DownloadFileAsync(New Uri(Me.ADCacheJson.Item("updateURL").ToString), ("Patch.exe"))
        Catch ex As Exception
            End
        End Try
    End Sub
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Try
            If Me.ADCacheJson.Item("ADURL") IsNot Nothing Then
                System.Diagnostics.Process.Start(Me.ADCacheJson.Item("ADURL"))
                If Me.ADCacheJson.Item("clickToExit").ToString Like "True" Then
                    End
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ShowDownProgress(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Invoke(New Action(Of Integer)(Sub(i) ProgressBar1.Value = i), e.ProgressPercentage)
    End Sub
    Private Sub DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        End
    End Sub
End Class

