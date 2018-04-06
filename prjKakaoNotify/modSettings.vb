Imports System.Xml
Imports System.IO

Module modSettings

    '//로드된 설정 값
    Public logStatus As Boolean
    Public timerTime As Integer
    Public autoLoginStatus As Boolean

    Public accountPath As String = Application.StartupPath & "\Account.xml"
    Public settingsPath As String = Application.StartupPath & "\Settings.xml"

    Public encryptKey As String = "StoryNotifierForWindows"

    Public loginCookie As String '//로그인시 필요한 쿠키 값

    Public MyStoryID As String '//내 아이디

    Public NotyID As String '//알림 고유 번호
    Public BoardID As String '//게시글 ID

    Public Sub createAccount(ID As String, PW As String)
        Dim xmlW As New XmlTextWriter(accountPath, System.Text.Encoding.UTF8)
        With xmlW
            .WriteStartDocument(True)
            .Formatting = Formatting.Indented
            .WriteStartElement("Account")

            '// 아이디
            .WriteStartElement("ID")
            .WriteString(ID)
            .WriteEndElement()
            '//비밀번호
            .WriteStartElement("PW")
            .WriteString(PW)
            .WriteEndElement()

            .WriteEndElement()
            .WriteEndDocument()
            .Close()
        End With
    End Sub

    Public Function checkSettings(settingsName As String) As Boolean
        Dim settings As XDocument = XDocument.Load(settingsPath)
        Dim chkElement As XElement = settings.Root.Element(settingsName)

        If IsNothing(chkElement) = True Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function EncryptTripleDES(text As String) As String
        Dim wrapper As New clsCrypto(encryptKey)
        Dim cipherText As String = wrapper.EncryptData(text)

        Return cipherText
    End Function

    Public Function DecryptTripleDES(encryptedText As String) As String
        Dim wrapper As New clsCrypto(encryptKey)
        Dim plainText As String = wrapper.DecryptData(encryptedText)

        Return plainText
    End Function

    Public Sub modifySettings(settingName As String, settingValue As String)
        Dim xmlSettings As XDocument = XDocument.Load(settingsPath)
        xmlSettings.Element("Config").SetElementValue(settingName, settingValue)
        xmlSettings.Save(settingsPath)
    End Sub

    Public Sub addSettings(settingName As String, settingValue As String)
        Dim xmlSettings As XDocument = XDocument.Load(settingsPath)
        Dim rootPath As XElement = New XElement(settingName, settingValue)
        xmlSettings.Element("Config").Add(rootPath)
        xmlSettings.Save(settingsPath)
    End Sub

    Public Function loadAccount(isID As Boolean) As String

        Dim xmlAccount As String = File.ReadAllText(accountPath)

        Dim xmlR As XmlReader = XmlReader.Create(New StringReader(xmlAccount))

        Dim loadData As String

        If isID = True Then
            loadData = "ID"
        Else
            loadData = "PW"
        End If
        Do While xmlR.Read()
            If xmlR.NodeType = XmlNodeType.Element AndAlso xmlR.Name = loadData Then
                loadAccount = xmlR.ReadElementContentAsString
            Else
                xmlR.Read()
            End If
        Loop

    End Function

    Public Sub createSettings(timer As Integer, writeLogs As Boolean, autoLogin As Boolean)
        Dim xmlW As New XmlTextWriter(settingsPath, System.Text.Encoding.UTF8)
        With xmlW
            .WriteStartDocument(True)
            .Formatting = Formatting.Indented
            .WriteStartElement("Config")

            '//타이머 시간 설정
            .WriteStartElement("Timer")
            .WriteString(timer)
            .WriteEndElement()
            '//로그 기록
            .WriteStartElement("writeLogs")
            .WriteString(writeLogs)
            .WriteEndElement()
            '//자동 로그인 설정
            .WriteStartElement("autoLogin")
            .WriteString(autoLogin)
            .WriteEndElement()

            .WriteEndElement()
            .WriteEndDocument()
            .Close()
        End With
    End Sub

    Public Sub loadSettings()

        Dim xmlSettings As String = File.ReadAllText(settingsPath)

        Dim xmlR As XmlReader = XmlReader.Create(New StringReader(xmlSettings))
        Do While xmlR.Read()
            If xmlR.NodeType = XmlNodeType.Element AndAlso xmlR.Name = "Timer" Then
                timerTime = xmlR.ReadElementContentAsInt
            ElseIf xmlR.NodeType = XmlNodeType.Element AndAlso xmlR.Name = "writeLogs" Then
                Dim tmpBool As String
                tmpBool = xmlR.ReadElementContentAsString
                If tmpBool = "True" Then
                    logStatus = True
                Else
                    logStatus = False
                End If
            ElseIf xmlR.NodeType = XmlNodeType.Element AndAlso xmlR.Name = "autoLogin" Then
                Dim tmpBool2 As String
                tmpBool2 = xmlR.ReadElementContentAsString
                If tmpBool2 = "True" Then
                    autoLoginStatus = True
                Else
                    autoLoginStatus = False
                End If

            Else
                xmlR.Read()
            End If
        Loop

    End Sub

End Module
