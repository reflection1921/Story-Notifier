Imports System.IO

Public Class Form1

    Private Sub lblStart_Click(sender As Object, e As EventArgs) Handles lblStart.Click
        whenStartStop(True)
        writeLog("[프로그램/" & Now & "] Story Notifier 알림 시작")
    End Sub

    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        'loginCookie = LoginWithCookie(txtID.Text, txtPW.Text)

        'If loginCookie = Nothing Then

        '    MsgBox("로그인에 실패하였습니다." & vbCrLf & "아이디 또는 비밀번호를 확인해주세요.", , "로그인")

        'Else
        '    whenLoginOut(True)

        '    If CheckBox1.Checked = True Then
        '        createAccount(txtID.Text, EncryptTripleDES(txtPW.Text))
        '    End If

        '    MyStoryID = loadMyStoryID()

        '    Notify(NotifyIcon1)
        'End If

        Form3.Show()
    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipClicked

        If browserStatus = True Then
            Shell("explorer.exe https://story.kakao.com/" & BoardID)
        Else
            Form4.Show()
            Form4.webView.Navigate("https://story.kakao.com/" & BoardID)
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Notify(NotifyIcon1)

    End Sub

    Private Sub 내스토리이동ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 내스토리이동ToolStripMenuItem.Click
        Shell("explorer.exe https://story.kakao.com/" & MyStoryID)
    End Sub

    Private Sub 설정ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 설정ToolStripMenuItem.Click
        Shell("explorer.exe https://story.kakao.com/" & MyStoryID & "/profile/")
    End Sub

    Private Sub 프로그램정보ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 프로그램정보ToolStripMenuItem.Click
        MsgBox("Copyright © Reflection 2016-2018" & vbCrLf & "Developed by Reflection" & vbCrLf & "Special Bug Reporter, Hoppin™" & vbCrLf & "NanumGothic font is created by Naver", vbInformation, "프로그램 정보")
    End Sub

    Private Sub 종료ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 종료ToolStripMenuItem.Click
        End
    End Sub

    Private Sub 최근알림ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 최근알림ToolStripMenuItem.Click
        Shell("explorer.exe https://story.kakao.com/" & BoardID)
    End Sub


    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub txtID_Click(sender As Object, e As EventArgs) Handles txtID.Click
        txtID.Clear()
        txtID.ForeColor = Color.Black

        If txtPW.Text = "" Then
            txtPW.Text = "비밀번호"
            txtPW.ForeColor = Color.LightGray
            txtPW.PasswordChar = ""
        End If
    End Sub

    Private Sub txtPW_Click(sender As Object, e As EventArgs) Handles txtPW.Click
        txtPW.Text = ""
        txtPW.PasswordChar = "●"
        PictureBox3.Image = My.Resources.hide
        txtPW.ForeColor = Color.Black

        If txtID.Text = "" Then
            txtID.Text = "ID"
            txtID.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If IsFontInstalled("나눔고딕") = False Or IsFontInstalled("나눔고딕 ExtraBold") = False Then
            If MsgBox("사용자의 PC에 나눔고딕이 설치되어있지 않습니다." & vbCrLf & "이 프로그램은 나눔고딕을 사용하여 개발되었습니다." & vbCrLf & "지금 나눔고딕을 다운로드하시겠습니까?", vbYesNo) = vbYes Then
                Shell("explorer.exe ""http://hangeul.naver.com/font""")
                Me.Close()
            Else
                MsgBox("이 프로그램을 정상적으로 사용하기 위해서는 나눔고딕 폰트의 설치가 필요합니다.", vbInformation, "Story Notifier")
            End If
        End If

        '// 설정파일 X => 설정 파일 생성
        If File.Exists(settingsPath) = False Then
            createSettings(5000, True, False, False)
        Else
            '//프로그램 업데이트를 통한 설정 파일 수정
            If checkSettings("Timer") = False Then
                addSettings("Timer", "5000")
            End If

            If checkSettings("writeLogs") = False Then
                addSettings("writeLogs", "True")
            End If

            If checkSettings("openBrowserExternal") = False Then
                addSettings("openBrowserExternal", "False")
            End If

            If checkSettings("autoLogin") = False Then
                addSettings("autoLogin", "False")
            End If
        End If

        loadSettings()
        Timer1.Interval = timerTime

        lblLogin.ForeColor = Color.White '//로그인 버튼 비활성화 처럼 보이도록 설정

        'If File.Exists(accountPath) = True Then

        '    CheckBox1.Checked = True
        '    txtID.ForeColor = Color.Black
        '    txtPW.ForeColor = Color.Black
        '    lblLogin.ForeColor = Color.Black
        '    txtPW.PasswordChar = "●"

        '    txtID.Text = loadAccount(True)
        '    txtPW.Text = DecryptTripleDES(loadAccount(False))

        'Else
        '    If autoLoginStatus = True Then
        '        MsgBox("저장된 계정이 없어 자동 로그인을 비활성화 하였습니다. 계정을 저장한 다음, 설정에서 자동 로그인 기능을 활성화 하세요.")
        '        modifySettings("autoLogin", "False")
        '        autoLoginStatus = False
        '    End If
        'End If

        'If autoLoginStatus = True Then
        '    lblLogin_Click(lblLogin, e)
        'End If


        Form3.Show()

    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

        If txtID.Text = "" Or txtPW.Text = "" Or txtPW.Text = "비밀번호" Or txtID.ForeColor = Color.LightGray Then
            lblLogin.ForeColor = Color.White
            lblLogin.Enabled = False
        Else
            lblLogin.ForeColor = Color.Black
            lblLogin.Enabled = True
        End If
    End Sub

    Private Sub txtPW_TextChanged(sender As Object, e As EventArgs) Handles txtPW.TextChanged

        If txtPW.Text = "비밀번호" Then
            txtPW.ForeColor = Color.LightGray
            txtPW.PasswordChar = ""
        Else
            txtPW.ForeColor = Color.Black
            txtPW.PasswordChar = "●"
        End If

        If txtID.Text = "" Or txtPW.Text = "" Or txtPW.Text = "비밀번호" Or txtID.ForeColor = Color.LightGray Then
            lblLogin.ForeColor = Color.White
            lblLogin.Enabled = False
        Else
            lblLogin.ForeColor = Color.Black
            lblLogin.Enabled = True
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            If File.Exists(accountPath) = True Then
                File.Delete(accountPath)
            End If
        End If
    End Sub

    Private Sub 제작자스토리ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 제작자스토리ToolStripMenuItem.Click
        Shell("explorer.exe ""http://story.chihaya.kr""")
    End Sub

    Private Sub 제작자웹사이트ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 제작자웹사이트ToolStripMenuItem.Click
        Shell("explorer.exe ""http://chihaya.kr""")
    End Sub

    Private Sub lblStop_Click(sender As Object, e As EventArgs) Handles lblStop.Click
        whenStartStop(False)

        writeLog("[프로그램/" & Now & "] Story Notifier 알림 종료")
    End Sub

    Private Sub picSet_Click(sender As Object, e As EventArgs) Handles picSet.Click
        Form2.Show()
    End Sub

    Private Sub lblSet_Click(sender As Object, e As EventArgs) Handles lblSet.Click
        Form2.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If txtPW.PasswordChar = "●" Then
            PictureBox3.Image = My.Resources.show
            txtPW.PasswordChar = ""
        Else
            PictureBox3.Image = My.Resources.hide
            txtPW.PasswordChar = "●"
        End If
    End Sub

    Private Sub 설정ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 설정ToolStripMenuItem1.Click
        Form2.Show()
    End Sub

    Private Sub lblCaptchaLogin_Click(sender As Object, e As EventArgs) Handles lblCaptchaLogin.Click
        Form5.Show()
    End Sub

    Private Sub 로그아웃ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 로그아웃ToolStripMenuItem.Click
        whenStartStop(False)
        whenLoginOut(False)
        Logout()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If CheckConnection() = True Then
            Timer1.Enabled = True
            Timer2.Enabled = False
        End If
    End Sub
End Class
