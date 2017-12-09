Imports System.IO

Public Class Form1

    Private Sub lblStart_Click(sender As Object, e As EventArgs) Handles lblStart.Click
        whenStartStop(True)
        writeLog("[프로그램/" & Now & "] Story Notifier 알림 시작")
    End Sub

    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click

        If Login(txtID.Text, txtPW.Text) = True Then

            whenLoginOut(True)

            If CheckBox1.Checked = True Then
                createAccount(txtID.Text, txtPW.Text)
            End If

            MyStoryID = loadMyStoryID()

            Notify(NotifyIcon1)

        Else
            MsgBox("로그인에 실패하였습니다." & vbCrLf & "아이디 또는 비밀번호를 확인해주세요.", , "로그인")
        End If
    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipClicked

        Shell("explorer.exe https://story.kakao.com/" & BoardID)

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
        MsgBox("Copyright © Reflection 2016-2017" & vbCrLf & "Developed by Reflection" & vbCrLf & "Special Bug Reporter, Hoppin™", vbInformation, "프로그램 정보")
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
        LoadFont() '// 외부 폰트 로드

        '// 설정파일 X => 설정 파일 생성
        If File.Exists(settingsPath) = False Then
            createSettings(5000, True)
        End If

        loadSettings()
        Timer1.Interval = timerTime

        '//폰트 설정
        setFontEB(18, lblLogin, lblStart, lblStop)
        setFontEB(12, txtID, txtPW)
        setFontR(9, lblSet, CheckBox1)
        setFontUR(9, lblCaptchaLogin)

        lblLogin.ForeColor = Color.White '//로그인 버튼 비활성화 처럼 보이도록 설정

        If File.Exists(accountPath) = True Then

            CheckBox1.Checked = True
            txtID.ForeColor = Color.Black
            txtPW.ForeColor = Color.Black
            lblLogin.ForeColor = Color.Black
            txtPW.PasswordChar = "●"

            txtID.Text = loadAccount(True)
            txtPW.Text = loadAccount(False)

        End If

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
                System.IO.File.Delete(accountPath)
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

    Private Sub lblCaptchaLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles lblCaptchaLogin.MouseMove
        lblCaptchaLogin.Font = New Font(NanumGothicEB.Families(0), 9, FontStyle.Underline)
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        lblCaptchaLogin.Font = New Font(NanumGothic.Families(0), 9, FontStyle.Underline)
    End Sub

End Class
