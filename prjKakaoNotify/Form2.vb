Imports System.IO

Public Class Form2

    Dim EA As Integer = 0

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        Dim setLogs As Boolean
        Dim setAutoLogin As Boolean
        Dim setBrowserExternal As Boolean

        If chkLogSet.Checked = True Then
            setLogs = True
        Else
            setLogs = False
        End If

        'If chkAutoLogin.Checked = True Then
        '    setAutoLogin = True
        'Else
        '    setAutoLogin = False
        'End If

        setAutoLogin = False

        If rbWebExternal.Checked = True Then
            setBrowserExternal = True
        Else
            setBrowserExternal = False
        End If

        createSettings(Val(txtTime.Text) * 1000, setLogs, setAutoLogin, setBrowserExternal)

        loadSettings()
        Form1.Timer1.Interval = timerTime

        Me.Dispose()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '//설정 로드
        txtTime.Text = timerTime / 1000

        If logStatus = True Then
            chkLogSet.Checked = True
        Else
            chkLogSet.Checked = False
        End If

        If autoLoginStatus = True Then
            chkAutoLogin.Checked = True
        Else
            chkAutoLogin.Checked = False
        End If

        If browserStatus = True Then
            rbWebExternal.Checked = True
        Else
            rbWebInternal.Checked = True
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        EA = EA + 1

        If EA = 10 Then
            MsgBox("ALL BLACK : )")
            Me.BackColor = Color.Black
        End If

    End Sub

    Private Sub chkAutoLogin_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutoLogin.CheckedChanged
        'If chkAutoLogin.Checked = True And File.Exists(accountPath) = False Then
        '    MsgBox("계정 저장이 되어있지 않아 자동 로그인을 사용할 수 없습니다.", vbCritical, "Story Notifier")
        '    chkAutoLogin.Checked = False
        'End If
    End Sub

    Private Sub txtTime_TextChanged(sender As Object, e As EventArgs) Handles txtTime.TextChanged
        If IsNumeric(txtTime.Text) = False Then
            MsgBox("숫자만 입력할 수 있습니다.", vbCritical, "Story Notifier")
        End If
    End Sub
End Class