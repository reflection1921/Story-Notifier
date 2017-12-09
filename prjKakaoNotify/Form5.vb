Imports System.IO

Public Class Form5
    Dim reCaptchaID_ As String
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setFontR(9, txtCaptcha)
        setFontEB(12, lblLogin)

        reCaptchaID_ = reCaptcha()

        wbCaptcha.Navigate("https://www.google.com/recaptcha/api/image?c=" & reCaptchaID_)
    End Sub

    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click

        If reCaptchaLogin(Form1.txtID.Text, Form1.txtPW.Text, reCaptchaID_, txtCaptcha.Text) = True Then

            whenLoginOut(True)

            If Form1.CheckBox1.Checked = True Then
                createAccount(Form1.txtID.Text, Form1.txtPW.Text)
            End If

            MyStoryID = loadMyStoryID()

            Notify(Form1.NotifyIcon1)

        Else
            MsgBox("아이디, 비밀번호 또는 캡챠가 잘못 입력되어 로그인에 실패하였습니다.", , "로그인")
        End If

        Me.Dispose()

    End Sub
End Class