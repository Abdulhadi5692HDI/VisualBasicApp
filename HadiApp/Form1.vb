Imports System.IO
Imports System.Text

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        SplashScreen1.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        LoginForm1.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        WebBrowser_Welcome.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Path As String = "c:\haditoolbox.data"

        Dim fs As FileStream = File.Create(Path)

        Dim info As Byte() = New UTF8Encoding(True).GetBytes("haditoolbox.data //Start write bytes from Writefile Sucessfully Done haditoolbox.data //End here")
        fs.Write(info, 0, info.Length)
        fs.Close()
        MsgBox("Saved at C:\haditoolbox.data", 0 + 64, "Info")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Console.WriteLine("HADIApp 1.1.0")
        MsgBox("Please run as administrator if you want to use the Write File!", 0 + 48, "Info")
        Dim DataPath As String = "c:\haditoolBX" ' Directory '
        MkDir(DataPath)

    End Sub
End Class
