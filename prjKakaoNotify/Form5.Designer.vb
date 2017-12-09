<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.wbCaptcha = New System.Windows.Forms.WebBrowser()
        Me.txtCaptcha = New System.Windows.Forms.TextBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wbCaptcha
        '
        Me.wbCaptcha.Location = New System.Drawing.Point(12, 12)
        Me.wbCaptcha.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbCaptcha.Name = "wbCaptcha"
        Me.wbCaptcha.Size = New System.Drawing.Size(345, 113)
        Me.wbCaptcha.TabIndex = 9
        '
        'txtCaptcha
        '
        Me.txtCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCaptcha.Font = New System.Drawing.Font("나눔고딕", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.txtCaptcha.Location = New System.Drawing.Point(20, 134)
        Me.txtCaptcha.Name = "txtCaptcha"
        Me.txtCaptcha.Size = New System.Drawing.Size(298, 14)
        Me.txtCaptcha.TabIndex = 10
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("나눔고딕 ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(336, 133)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(18, 19)
        Me.lblLogin.TabIndex = 18
        Me.lblLogin.Text = ">"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prjKakaoNotify.My.Resources.Resources.Line
        Me.PictureBox1.Location = New System.Drawing.Point(20, 153)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(298, 1)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(370, 169)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.txtCaptcha)
        Me.Controls.Add(Me.wbCaptcha)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form5"
        Me.Text = "Story Notifier - reCaptcha"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents wbCaptcha As WebBrowser
    Friend WithEvents txtCaptcha As TextBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
