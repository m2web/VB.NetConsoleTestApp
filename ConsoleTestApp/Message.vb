Public Class Message
    Public Function CreateMessage() As String
        Return "Hello BIS 305!"
    End Function

    Public Function SayHello(name As String) As String
        'If the input parameter is an empty String or null the return the error String
        'If the input parameter is NOT an empty String or null trim the String and remove
        'any space characters. If the trimmed String is empty (the input was just space 
        'characters) then return the error String.
        If String.IsNullOrEmpty(name) OrElse name.Trim().Equals(String.Empty) Then
            Return "ERROR: The name is empty, blank, or null."
        End If

        Return "Hello " & name
    End Function
End Class
