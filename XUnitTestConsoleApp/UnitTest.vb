Option Strict On

Imports Xunit
Imports ConsoleTestApp

Namespace XUnitTestConsoleApp
    Public Class UnitTest
        Private _message As Message

        'UnitTest Class Constructor
        Sub New()
            _message = New Message()
        End Sub

        'The <Fact> attribute denotes a test method that is run by the test runner.
        'The Message Class's CreateMessage Function should return "Hello BIS 305!"
        <Fact>
        Sub TestMessage()
            Dim messageResult As String = _message.CreateMessage()
            Assert.Equal("Hello BIS 305!", messageResult)
        End Sub

        'The Message Class's SayHello Function should return "Hello {name}" or 
        'in this case "Hello Mark"
        <Fact>
        Sub TestSayHello()
            Dim name As String = "Mark"
            Dim messageResult As String = _message.SayHello(name)
            Assert.Equal($"Hello {name}", messageResult)
        End Sub

        'A <Theory> attribute represents a suite of tests that execute the same 
        'code but have different input arguments. You can use the <InlineData> 
        'attribute To specify values For those inputs.
        <Theory>
        <InlineData("")>
        <InlineData(" ")>
        <InlineData("      ")>
        <InlineData(Nothing)>
        Sub TestInputArgumentIsString(input As String)
            Dim messageResult As String = _message.SayHello(input)
            Assert.Equal("ERROR: The name is empty, blank, or null.", messageResult)
        End Sub
    End Class
End Namespace

