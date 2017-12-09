Imports System.IO

Public Class Form2

    Dim EA As Integer = 0

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        Dim setLogs As Boolean

        If chkLogSet.Checked = True Then
            setLogs = True
        Else
            setLogs = False
        End If

        createSettings(Val(txtTime.Text) * 1000, setLogs)

        loadSettings()
        Form1.Timer1.Interval = timerTime

        Me.Dispose()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '//폰트 초기 설정
        setFontEB(18, Label1)
        setFontEB(14.25, Label4)
        setFontB(9, Label2, Label5)
        setFontR(9, Label3, txtTime, chkLogSet)

        '//설정 로드
        txtTime.Text = timerTime / 1000

        If logStatus = True Then
            chkLogSet.Checked = True
        Else
            chkLogSet.Checked = False
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        EA = EA + 1

        If EA = 10 Then
            MsgBox("이것은 설정입니다. 그러니까 그만 두드리세요.")
            Me.BackColor = Color.Black
        End If

    End Sub
End Class