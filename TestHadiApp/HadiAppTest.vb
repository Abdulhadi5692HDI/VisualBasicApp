Imports System.Text

<TestClass()>
Public Class HadiAppTest

    <TestMethod()>
    Public Sub TestMethod1()
        Console.WriteLine("HADIAPP CO.")
        Command("pause")
    End Sub

    Private Sub Command(ByVal p1 As String)
        Throw New NotImplementedException
    End Sub

End Class
