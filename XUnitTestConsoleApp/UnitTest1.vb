Imports System
Imports Xunit
Imports ConsoleTestApp

Namespace XUnitTestConsoleApp
    Public Class UnitTest1
        <Fact>
        Sub TestMessage()
            Dim message As New Message()
            Dim messageResult As String = message.CreateMessage()
            Assert.Equal("Hello BIS 305!", messageResult)
        End Sub
    End Class
End Namespace

