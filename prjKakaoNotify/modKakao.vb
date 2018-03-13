Module modKakao

    Public Function LoginWithCookie(ID As String, PW As String) As String

        Dim sendData As String = "type=w&continue=https%3A%2F%2Fstory.kakao.com&email=" & ID & "&password=" & PW & "&callback_url=https%3A%2F%2Faccounts.kakao.com%2Fcb.html&scriptVersion=1.4.2"

        With Win_Http
            .Option(WinHttp.WinHttpRequestOption.WinHttpRequestOption_EnableRedirects) = False
            .Open("POST", "https://accounts.kakao.com/weblogin/authenticate")
            .SetRequestHeader("User-Agent", "Mozilla/5.0 (Windows NT 5.1; rv:16.0) Gecko/20100101 Firefox/16.0")
            .SetRequestHeader("Host", "accounts.kakao.com")
            .SetRequestHeader("Referer", "https://accounts.kakao.com/login/kakaostory")
            .SetRequestHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8")
            .SetRequestHeader("Accept-Language", "ko-KR,ko;q=0.8,en-US;q=0.5,en;q=0.3")
            .SetRequestHeader("Accept-Encoding", "gzip, deflate, br")
            .SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
            .SetRequestHeader("Connection", "keep-alive")
            .SetRequestHeader("Upgrade-Insecure-Requests", "1")
            .SetRequestHeader("Content-Length", sendData.Length)
            .Send(sendData)
        End With

        Dim AllHeaders As String = Win_Http.GetAllResponseHeaders

        If InStr(AllHeaders, "_kawlt=") Then
            Dim tempCookie As String = Split(Split(AllHeaders, "Set-Cookie: _kawlt=")(1), ";")(0)
            LoginWithCookie = "_kawlt=" & tempCookie & ";"
        Else
            LoginWithCookie = Nothing
        End If

        Win_Http.Option(WinHttp.WinHttpRequestOption.WinHttpRequestOption_EnableRedirects) = True

    End Function

    Public Function Login(ID As String, PW As String) As Boolean
        With Win_Http
            .Open("POST", "https://accounts.kakao.com/weblogin/authenticate")
            .SetRequestHeader("Referer", "https://story.kakao.com/s/login")
            .SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
            .SetRequestHeader("User-Agent", "Mozilla/5.0 (Windows NT 6.1; rv:35.0) Gecko/20100101 Firefox/35.0")
            .SetRequestHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8")
            .SetRequestHeader("Accept-Language", "ko-kr,ko;q=0.8,en-us;q=0.5,en;q=0.3")
            .SetRequestHeader("Host", "accounts.kakao.com")
            .Send("email=" & ID & "&password=" & PW & "&callback_url=https%3A%2F%2Fstory.kakao.com%2Fs%2dummy&scriptVersion=1.3.0")
        End With

        With Win_Http
            .Open("GET", "https://story.kakao.com/a/friends")
            .SetRequestHeader("Host", "story.kakao.com")
            .SetRequestHeader("User-Agent", "Mozilla/5.0 (Windows NT 6.1; rv:35.0) Gecko/20100101 Firefox/35.0")
            .SetRequestHeader("Accept", "application/json")
            .SetRequestHeader("Accept-Language", "ko")
            .SetRequestHeader("Connection", "keep-alive")
            .SetRequestHeader("X-Kakao-ApiLevel", "13")
            .SetRequestHeader("X-Kakao-DeviceInfo", "web:-;-;-")
            .SetRequestHeader("X-Requested-With", "XMLHttpRequest")
            .SetRequestHeader("Referer", "https://story.kakao.com/")
            .Send()
        End With

        If InStr(Win_Http.ResponseText, "profile_thumbnail_url") Then
            Login = True
        Else
            Login = False
        End If
    End Function

    Public Function reCaptcha() As String
        With Win_Http
            .Open("GET", "https://www.google.com/recaptcha/api/challenge?k=6LfIz_USAAAAALNnNqQJK8YI9SrPuNJqQeMgY0DY&ajax=1&cachestop=0.27867610606292925&lang=ko")
            .SetRequestHeader("User-Agent", "Mozilla/5.0 (Windows NT 6.1; rv:35.0) Gecko/20100101 Firefox/35.0")
            .SetRequestHeader("Host", "www.google.com")
            .SetRequestHeader("Accept-Language", "ko-kr,ko;q=0.8,en-us;q=0.5,en;q=0.3")
            .SetRequestHeader("Referer", "https://accounts.kakao.com/weblogin/main_captcha?continue=https%3A%2F%2Fstory.kakao.com")
            .Send()
        End With

        reCaptcha = Split(Split(Win_Http.ResponseText, ": '")(1), "',")(0)
    End Function

    Public Function reCaptchaLogin(ID As String, PW As String, reCaptchaID As String, reCaptchaValue As String) As Boolean
        With Win_Http
            .Open("POST", "https://accounts.kakao.com/weblogin/authenticate_captcha")
            .SetRequestHeader("Referer", "https://accounts.kakao.com/weblogin/main_captcha?continue=https%3A%2F%2Fstory.kakao.com")
            .SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
            .SetRequestHeader("User-Agent", "Mozilla/5.0 (Windows NT 6.1; rv:35.0) Gecko/20100101 Firefox/35.0")
            .SetRequestHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8")
            .SetRequestHeader("Accept-Language", "ko-kr,ko;q=0.8,en-us;q=0.5,en;q=0.3")
            .SetRequestHeader("Host", "accounts.kakao.com")
            .Send("type=w&continue=https%3A%2F%2Fstory.kakao.com&email=" & ID & "&password=" & PW & "&recaptcha_challenge_field=" & reCaptchaID & "&recaptcha_response_field=" & reCaptchaValue & "&callback_url=https%3A%2F%2Faccounts.kakao.com%2Fcb.html&scriptVersion=1.3.0")
        End With

        With Win_Http
            .Open("GET", "https://story.kakao.com/a/friends")
            .SetRequestHeader("Host", "story.kakao.com")
            .SetRequestHeader("User-Agent", "Mozilla/5.0 (Windows NT 6.1; rv:35.0) Gecko/20100101 Firefox/35.0")
            .SetRequestHeader("Accept", "application/json")
            .SetRequestHeader("Accept-Language", "ko")
            .SetRequestHeader("Connection", "keep-alive")
            .SetRequestHeader("X-Kakao-ApiLevel", "29")
            .SetRequestHeader("X-Kakao-DeviceInfo", "web:-;-;-")
            .SetRequestHeader("X-Requested-With", "XMLHttpRequest")
            .SetRequestHeader("Referer", "https://story.kakao.com/")
            .Send()
        End With

        If InStr(Win_Http.ResponseText, "profile_thumbnail_url") Then
            reCaptchaLogin = True
        Else
            reCaptchaLogin = False
        End If
    End Function

    Public Function loadMyStoryID() As String
        With Win_Http
            .Open("GET", "https://story.kakao.com/a/settings/profile")
            .SetRequestHeader("Host", "story.kakao.com")
            .SetRequestHeader("User-Agent", "Mozilla/5.0 (Windows NT 6.1; rv:35.0) Gecko/20100101 Firefox/35.0")
            .SetRequestHeader("Accept", "application/json")
            .SetRequestHeader("Accept-Language", "ko")
            .SetRequestHeader("Connection", "keep-alive")
            .SetRequestHeader("X-Kakao-ApiLevel", "29")
            .SetRequestHeader("X-Kakao-DeviceInfo", "web:d;-;-")
            .SetRequestHeader("X-Requested-With", "XMLHttpRequest")
            .Send()
        End With

        loadMyStoryID = Split(Split(Win_Http.ResponseText, """id"":""")(1), """,")(0)
    End Function

    Public Sub Notify(Noty As NotifyIcon)

        Dim NotyMessage As String
        Dim comment As String
        Dim NewNotyID As String

        With Win_Http
            .Open("GET", "https://story.kakao.com/a/notifications")
            .SetRequestHeader("Host", "story.kakao.com")
            .SetRequestHeader("User-Agent", "Mozilla/5.0 (Windows NT 6.1; rv:35.0) Gecko/20100101 Firefox/35.0")
            .SetRequestHeader("Accept", "application/json")
            .SetRequestHeader("Accept-Language", "ko")
            .SetRequestHeader("Connection", "keep-alive")
            .SetRequestHeader("X-Kakao-ApiLevel", "31")
            .SetRequestHeader("X-Kakao-DeviceInfo", "web:-;-;-")
            .SetRequestHeader("X-Requested-With", "XMLHttpRequest")
            .SetRequestHeader("Cookie", loginCookie)
            .SetRequestHeader("Referer", "https://story.kakao.com/")
            .Send()
        End With

        If InStr(Win_Http.ResponseText, "created_at") Then
            NewNotyID = Split(Split(Win_Http.ResponseText, ",""created_at"":""")(1), """,""message")(0)
            NewNotyID = Split(Split(NewNotyID, ",""id"":""")(1), """,")(0)

            If NotyID = NewNotyID Then Exit Sub

            NotyMessage = Split(Split(Win_Http.ResponseText, """message"":""")(1), """,")(0)
            NotyMessage = Replace(NotyMessage, "\""", """")
            NotyMessage = Replace(NotyMessage, "\n", "")

            NotyID = NewNotyID

            BoardID = Split(Split(Win_Http.ResponseText, """scheme"":""")(1), """,")(0)
            If InStr(BoardID, "kakaostory://activities/") Then
                BoardID = Split(Split(BoardID, "kakaostory://activities/")(1), "?")(0)
                BoardID = Replace(BoardID, ".", "/")
            Else
                BoardID = ""
            End If

            '//받은 알림이 댓글과 관련된 알림일 경우
            If InStr(NotyMessage, "댓글을 남겼습니다") Then
                comment = Split(Split(Win_Http.ResponseText, """comment_id""")(1), "},")(0)
                comment = Split(Split(comment, """content"":""")(1), """")(0)
                comment = Replace(comment, "\""", """")
                comment = Replace(comment, "\n", " ")
            Else
                comment = ""
            End If

            '//알림 띄우기
            With Noty
                .BalloonTipIcon = ToolTipIcon.None
                .BalloonTipTitle = "Story Notifier(" & Now & ")"
                .BalloonTipText = NotyMessage & " " & comment
                .ShowBalloonTip(100)
            End With

            writeLog("[알림/" & Now & "] " & NotyMessage & " " & comment & "(ID: " & BoardID & ")")

        Else

            writeLog("[프로그램/" & Now & "] Story Notifier 알림 종료. 사유: 자동 로그아웃")
            writeLog("[프로그램/" & Now & "] Story Notifier 재로그인 시도")

            loginCookie = LoginWithCookie(Form1.txtID.Text, Form1.txtPW.Text)

            If loginCookie = Nothing Then

                writeLog("[프로그램/" & Now & "] Story Notifier 재로그인 실패")
                Form1.로그아웃ToolStripMenuItem.PerformClick()

            Else
                writeLog("[프로그램/" & Now & "] Story Notifier 재로그인 성공")
                MyStoryID = loadMyStoryID()

            End If



        End If
    End Sub
End Module
