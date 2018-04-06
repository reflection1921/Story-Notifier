Module modConnection
    Public Function CheckConnection() As Boolean
        Try
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
        Catch ex As Exception
            Return False
            Exit Function
        End Try
        Return True
    End Function
End Module
