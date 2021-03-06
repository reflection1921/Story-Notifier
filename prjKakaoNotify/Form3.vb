﻿Imports System.Runtime.InteropServices
Imports System.Text

'//Sources: http://ycouriel.blogspot.kr/2010/07/webbrowser-and-httpwebrequest-cookies.html
Public Class Form3

    <DllImport("wininet.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function InternetGetCookieEx(ByVal pchURL As String, ByVal pchCookieName As String, ByVal pchCookieData As StringBuilder, ByRef pcchCookieData As UInteger, ByVal dwFlags As Integer, ByVal lpReserved As IntPtr) As Boolean
    End Function

    Const INTERNET_COOKIE_HTTPONLY As Integer = 8192

    Public Function GetGlobalCookies(ByVal uri As String) As String
        Dim datasize As UInteger = 1024
        Dim cookieData As StringBuilder = New StringBuilder(CInt(datasize))
        If InternetGetCookieEx(uri, Nothing, cookieData, datasize, INTERNET_COOKIE_HTTPONLY, IntPtr.Zero) AndAlso cookieData.Length > 0 Then
            Return cookieData.ToString()
        Else
            Return Nothing
        End If
    End Function

    Private Sub webLogin_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles webLogin.DocumentCompleted
        If webLogin.Url.Host = "story.kakao.com" Then
            Dim tmpCookies As String = GetGlobalCookies(webLogin.Document.Url.AbsoluteUri)
            If InStr(tmpCookies, "_kawlt=") Then

                loginCookie = tmpCookies '//로그인 쿠키값 저장

                Form1.txtID.Text = "******@******.***"
                Form1.txtPW.Text = "123456789012"

                whenLoginOut(True) '//Form1 로그인된 상태로 변경
                MyStoryID = loadMyStoryID() '//내 스토리 로드
                Notify(Form1.NotifyIcon1) '//알림
                Me.Close() '//로그인 위한 웹브 Form 종료
            End If
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Enabled = False
    End Sub

    Private Sub Form3_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Enabled = True
    End Sub
End Class