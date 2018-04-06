Module modFont

    '//https://stackoverflow.com/questions/15897941/font-is-installed-function 
    '//Author: Jack Gajanan
    Public Function IsFontInstalled(ByVal FontName As String) As Boolean
        Using TestFont As Font = New Font(FontName, 10)
            Return CBool(String.Compare(FontName, TestFont.Name, StringComparison.InvariantCultureIgnoreCase) = 0)
        End Using
    End Function

End Module
