Module modForm

    Public Sub whenStartStop(isStart As Boolean)
        Form1.Timer1.Enabled = isStart '//알림 시작

        Form1.lblStop.Visible = isStart '//알림 중단 버튼 보이기
        Form1.lblStart.Visible = Not isStart '//알림 시작 버튼 숨기기

        '//설정 버튼 비활성화
        Form1.picSet.Enabled = Not isStart
        Form1.lblSet.Enabled = Not isStart

        Form1.설정ToolStripMenuItem1.Enabled = Not isStart
        Form1.로그아웃ToolStripMenuItem.Enabled = Not isStart

        If isStart = True Then
            Form1.lblSet.ForeColor = Color.LightGray
        Else
            Form1.lblSet.ForeColor = Color.Black
        End If
    End Sub

    Public Sub whenLoginOut(isLogin As Boolean)

        '//아이디, 비밀번호 입력 비활성화
        Form1.txtID.Enabled = Not isLogin
        Form1.txtPW.Enabled = Not isLogin

        '//로그인 관련한 버튼 비활성화
        Form1.lblLogin.Enabled = Not isLogin
        Form1.CheckBox1.Enabled = Not isLogin
        Form1.lblCaptchaLogin.Enabled = Not isLogin

        Form1.CheckBox1.Visible = Not isLogin
        Form1.lblCaptchaLogin.Visible = Not isLogin

        Form1.PictureBox3.Visible = Not isLogin

        Form1.picSet.Visible = isLogin
        Form1.lblSet.Visible = isLogin
        Form1.lblStart.Visible = isLogin

        If isLogin = True Then
            Form1.txtID.ForeColor = Color.LightGray
            Form1.txtPW.ForeColor = Color.LightGray
            Form1.lblLogin.ForeColor = Color.LightGray
        Else
            Form1.txtID.ForeColor = Color.Black
            Form1.txtPW.ForeColor = Color.Black
            Form1.lblLogin.ForeColor = Color.Black
        End If
    End Sub
End Module
