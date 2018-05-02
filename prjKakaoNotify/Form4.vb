Public Class Form4

    Private Sub webView_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles webView.DocumentCompleted
        Me.Text = webView.DocumentTitle
    End Sub
End Class