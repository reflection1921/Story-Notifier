<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.설정ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.로그아웃ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.최근알림ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.내스토리이동ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.설정ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.프로그램정보ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.제작자스토리ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.제작자웹사이트ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.종료ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblSet = New System.Windows.Forms.Label()
        Me.lblStop = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.picSet = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblCaptchaLogin = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipText = "ㅎㅇㅎㅇ"
        Me.NotifyIcon1.BalloonTipTitle = "ㅎㅇ"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Story Notifer"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.설정ToolStripMenuItem1, Me.로그아웃ToolStripMenuItem, Me.ToolStripSeparator2, Me.최근알림ToolStripMenuItem, Me.내스토리이동ToolStripMenuItem, Me.설정ToolStripMenuItem, Me.ToolStripSeparator1, Me.프로그램정보ToolStripMenuItem, Me.제작자스토리ToolStripMenuItem, Me.제작자웹사이트ToolStripMenuItem, Me.종료ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(163, 214)
        '
        '설정ToolStripMenuItem1
        '
        Me.설정ToolStripMenuItem1.Name = "설정ToolStripMenuItem1"
        Me.설정ToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.설정ToolStripMenuItem1.Text = "설정"
        '
        '로그아웃ToolStripMenuItem
        '
        Me.로그아웃ToolStripMenuItem.Enabled = False
        Me.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem"
        Me.로그아웃ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.로그아웃ToolStripMenuItem.Text = "로그아웃"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(159, 6)
        '
        '최근알림ToolStripMenuItem
        '
        Me.최근알림ToolStripMenuItem.Name = "최근알림ToolStripMenuItem"
        Me.최근알림ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.최근알림ToolStripMenuItem.Text = "최근 알림 이동"
        '
        '내스토리이동ToolStripMenuItem
        '
        Me.내스토리이동ToolStripMenuItem.Name = "내스토리이동ToolStripMenuItem"
        Me.내스토리이동ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.내스토리이동ToolStripMenuItem.Text = "내 스토리"
        '
        '설정ToolStripMenuItem
        '
        Me.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem"
        Me.설정ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.설정ToolStripMenuItem.Text = "프로필 설정"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(159, 6)
        '
        '프로그램정보ToolStripMenuItem
        '
        Me.프로그램정보ToolStripMenuItem.Name = "프로그램정보ToolStripMenuItem"
        Me.프로그램정보ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.프로그램정보ToolStripMenuItem.Text = "프로그램 정보"
        '
        '제작자스토리ToolStripMenuItem
        '
        Me.제작자스토리ToolStripMenuItem.Name = "제작자스토리ToolStripMenuItem"
        Me.제작자스토리ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.제작자스토리ToolStripMenuItem.Text = "개발자 스토리"
        '
        '제작자웹사이트ToolStripMenuItem
        '
        Me.제작자웹사이트ToolStripMenuItem.Name = "제작자웹사이트ToolStripMenuItem"
        Me.제작자웹사이트ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.제작자웹사이트ToolStripMenuItem.Text = "개발자 웹사이트"
        '
        '종료ToolStripMenuItem
        '
        Me.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem"
        Me.종료ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.종료ToolStripMenuItem.Text = "종료"
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID.Font = New System.Drawing.Font("나눔고딕 ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.LightGray
        Me.txtID.Location = New System.Drawing.Point(26, 18)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(298, 19)
        Me.txtID.TabIndex = 1
        Me.txtID.Text = "ID"
        '
        'txtPW
        '
        Me.txtPW.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPW.Font = New System.Drawing.Font("나눔고딕 ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPW.ForeColor = System.Drawing.Color.LightGray
        Me.txtPW.Location = New System.Drawing.Point(26, 62)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Size = New System.Drawing.Size(274, 19)
        Me.txtPW.TabIndex = 3
        Me.txtPW.Text = "비밀번호"
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("나눔고딕", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(26, 102)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(98, 18)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "계정 정보 저장"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("나눔고딕 ExtraBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLogin.Location = New System.Drawing.Point(220, 102)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(104, 28)
        Me.lblLogin.TabIndex = 13
        Me.lblLogin.Text = "→로그인"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("나눔고딕 ExtraBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(190, 102)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(134, 28)
        Me.lblStart.TabIndex = 14
        Me.lblStart.Text = "→알림 시작"
        Me.lblStart.Visible = False
        '
        'lblSet
        '
        Me.lblSet.AutoSize = True
        Me.lblSet.Font = New System.Drawing.Font("나눔고딕", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSet.Location = New System.Drawing.Point(45, 103)
        Me.lblSet.Name = "lblSet"
        Me.lblSet.Size = New System.Drawing.Size(29, 14)
        Me.lblSet.TabIndex = 16
        Me.lblSet.Text = "설정"
        Me.lblSet.Visible = False
        '
        'lblStop
        '
        Me.lblStop.AutoSize = True
        Me.lblStop.Font = New System.Drawing.Font("나눔고딕 ExtraBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStop.Location = New System.Drawing.Point(190, 102)
        Me.lblStop.Name = "lblStop"
        Me.lblStop.Size = New System.Drawing.Size(134, 28)
        Me.lblStop.TabIndex = 17
        Me.lblStop.Text = "→알림 중단"
        Me.lblStop.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.prjKakaoNotify.My.Resources.Resources.hide
        Me.PictureBox3.Location = New System.Drawing.Point(306, 62)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'picSet
        '
        Me.picSet.Image = Global.prjKakaoNotify.My.Resources.Resources.Settings
        Me.picSet.Location = New System.Drawing.Point(26, 102)
        Me.picSet.Name = "picSet"
        Me.picSet.Size = New System.Drawing.Size(18, 18)
        Me.picSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSet.TabIndex = 15
        Me.picSet.TabStop = False
        Me.picSet.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.prjKakaoNotify.My.Resources.Resources.Line
        Me.PictureBox2.Location = New System.Drawing.Point(26, 87)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(298, 1)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prjKakaoNotify.My.Resources.Resources.Line
        Me.PictureBox1.Location = New System.Drawing.Point(26, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(298, 1)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'lblCaptchaLogin
        '
        Me.lblCaptchaLogin.Font = New System.Drawing.Font("나눔고딕", 8.999999!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblCaptchaLogin.Location = New System.Drawing.Point(123, 103)
        Me.lblCaptchaLogin.Name = "lblCaptchaLogin"
        Me.lblCaptchaLogin.Size = New System.Drawing.Size(54, 22)
        Me.lblCaptchaLogin.TabIndex = 19
        Me.lblCaptchaLogin.Text = "캡챠 사용"
        Me.lblCaptchaLogin.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(347, 141)
        Me.Controls.Add(Me.lblCaptchaLogin)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lblStop)
        Me.Controls.Add(Me.lblSet)
        Me.Controls.Add(Me.picSet)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.txtID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Story Notifier"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPW As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 최근알림ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 내스토리이동ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 설정ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 프로그램정보ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 종료ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents 제작자스토리ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 제작자웹사이트ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblStart As Label
    Friend WithEvents picSet As PictureBox
    Friend WithEvents lblSet As Label
    Friend WithEvents lblStop As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents 설정ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents lblCaptchaLogin As Label
    Friend WithEvents 로그아웃ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer2 As Timer
End Class
