Imports System.IO

Module modLog
    Public Win_Http As New WinHttp.WinHttpRequest

    Public Sub writeLog(logContent As String)

        Dim tmpLogs As String

        If logStatus = False Then Exit Sub

        If File.Exists(Application.StartupPath & "\logs.txt") = True Then
            tmpLogs = File.ReadAllText(Application.StartupPath & "\logs.txt")
            File.WriteAllText(Application.StartupPath & "\logs.txt", tmpLogs & vbCrLf & logContent)
        Else
            File.WriteAllText(Application.StartupPath & "\Logs.txt", "#Story Notifier Logs" & vbCrLf & "#Created: " & Now & vbCrLf & "[프로그램/" & Now & "] 로그 파일 생성" & vbCrLf & logContent)
        End If
    End Sub
End Module
