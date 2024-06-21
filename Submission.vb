Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property PhoneNumber As String
    Public Property GitHubRepo As String
    Public Property StopwatchTime As String

    Public Sub New(name As String, email As String, phoneNumber As String, gitHubRepo As String, stopwatchTime As String)
        Me.Name = name
        Me.Email = email
        Me.PhoneNumber = phoneNumber
        Me.GitHubRepo = gitHubRepo
        Me.StopwatchTime = stopwatchTime
    End Sub
End Class
