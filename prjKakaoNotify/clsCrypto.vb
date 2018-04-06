'//Source: https://docs.microsoft.com/ko-kr/dotnet/visual-basic/programming-guide/language-features/strings/walkthrough-encrypting-and-decrypting-strings

Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Public NotInheritable Class clsCrypto
    Private TripleDES As New TripleDESCryptoServiceProvider

    Private Function TruncateHash(ByVal key As String, ByVal length As Integer) As Byte()

        Dim sha1 As New SHA1CryptoServiceProvider

        Dim keyBytes() As Byte = Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)

        ReDim Preserve hash(length - 1)
        Return hash
    End Function

    Sub New(ByVal key As String)
        TripleDES.Key = TruncateHash(key, TripleDES.KeySize \ 8)
        TripleDES.IV = TruncateHash("", TripleDES.BlockSize \ 8)
    End Sub

    Public Function EncryptData(ByVal plaintext As String) As String

        Dim plaintextBytes() As Byte = Encoding.Unicode.GetBytes(plaintext)

        Dim ms As New MemoryStream

        Dim encStream As New CryptoStream(ms, TripleDES.CreateEncryptor(), CryptoStreamMode.Write)

        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function DecryptData(ByVal encryptedtext As String) As String

        Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

        Dim ms As New MemoryStream
        Dim decStream As New CryptoStream(ms, TripleDES.CreateDecryptor(), CryptoStreamMode.Write)

        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        decStream.FlushFinalBlock()

        Return Encoding.Unicode.GetString(ms.ToArray)
    End Function
End Class
