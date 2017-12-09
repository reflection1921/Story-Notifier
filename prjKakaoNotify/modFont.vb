Imports System.Drawing.Text

Module modFont
    Public NanumGothic, NanumGothicB, NanumGothicEB As New PrivateFontCollection

    Public Sub LoadFont()
        NanumGothic.AddFontFile(Application.StartupPath & "\Fonts\NanumGothic.ttf")
        NanumGothicB.AddFontFile(Application.StartupPath & "\Fonts\NanumGothicBold.ttf")
        NanumGothicEB.AddFontFile(Application.StartupPath & "\Fonts\NanumGothicExtraBold.ttf")
    End Sub

    Public Sub setFontEB(fontSize As Integer, ParamArray controlName() As Control)

        For i = 0 To UBound(controlName) - 1
            controlName(i).Font = New Font(NanumGothicEB.Families(0), fontSize)
        Next


    End Sub

    Public Sub setFontB(fontSize As Integer, ParamArray controlName() As Control)
        For i = 0 To UBound(controlName) - 1
            controlName(i).Font = New Font(NanumGothicB.Families(0), fontSize)
        Next

    End Sub

    Public Sub setFontR(fontSize As Integer, ParamArray controlName() As Control)
        For i = 0 To UBound(controlName) - 1
            controlName(i).Font = New Font(NanumGothic.Families(0), fontSize)
        Next

    End Sub

    Public Sub setFontUR(fontSize As Integer, ParamArray controlName() As Control)
        For i = 0 To UBound(controlName) - 1
            controlName(i).Font = New Font(NanumGothic.Families(0), fontSize, FontStyle.Underline)
        Next

    End Sub

End Module
