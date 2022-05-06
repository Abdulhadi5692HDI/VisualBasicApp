Imports System.IO
Imports System.Text

Public Class WriteFile

    Public Function Main()
        Dim Path As String = "c:\haditoolbox.data"

        Dim fs As FileStream = File.Create(Path)

        Dim info As Byte() = New UTF8Encoding(True).GetBytes("haditoolbox.data //Start write bytes from Writefile\n0101\n[HADI Toolbox]Application Sucess\n0202\nhaditoolbox.data //End here")
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Function
End Class
