Imports System.Diagnostics

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    Private submissions As New List(Of Submission)
    Private currentIndex As Integer = 0
    Private stopwatch As New Stopwatch()

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load submissions from storage (if any)
        ' For demonstration, adding a few dummy submissions
        submissions.Add(New Submission("John Doe", "john@example.com", "1234567890", "https://github.com/johndoe", "00:10:20"))
        submissions.Add(New Submission("Jane Doe", "jane@example.com", "0987654321", "https://github.com/janedoe", "00:05:30"))
        DisplaySubmission()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub btnStopwatch_Click(sender As Object, e As EventArgs)
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        txtStopwatchTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub DisplaySubmission()
        If submissions.Count > 0 Then
            Dim currentSubmission = submissions(currentIndex)
            txtGitHubRepo.Text = currentSubmission.GitHubRepo
            txtPhoneNumber.Text = currentSubmission.PhoneNumber
            txtEmail.Text = currentSubmission.Email
            txtName.Text = currentSubmission.Name
            txtStopwatchTime.Text = currentSubmission.StopwatchTime
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub

    ' Form overrides dispose to clean up the component list.
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

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnPrevious = New Button()
        btnNext = New Button()
        Label1 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNumber = New TextBox()
        txtGitHubRepo = New TextBox()
        btnStopwatch = New Button()
        txtStopwatchTime = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnPrevious.Location = New Point(12, 337)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.RightToLeft = RightToLeft.No
        btnPrevious.Size = New Size(195, 29)
        btnPrevious.TabIndex = 0
        btnPrevious.Text = "PREVIOUS (CTRL+P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.SkyBlue
        btnNext.Location = New Point(239, 337)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(195, 29)
        btnNext.TabIndex = 1
        btnNext.Text = "NEXT (CTRL+N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(51, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(296, 20)
        Label1.TabIndex = 2
        Label1.Text = "John Doe, Slidely Task 2 - View Submissions"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(182, 60)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(252, 27)
        txtName.TabIndex = 3
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(182, 109)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(252, 27)
        txtEmail.TabIndex = 4
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(182, 169)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.ReadOnly = True
        txtPhoneNumber.Size = New Size(252, 27)
        txtPhoneNumber.TabIndex = 5
        ' 
        ' txtGitHubRepo
        ' 
        txtGitHubRepo.Location = New Point(182, 223)
        txtGitHubRepo.Name = "txtGitHubRepo"
        txtGitHubRepo.ReadOnly = True
        txtGitHubRepo.Size = New Size(252, 27)
        txtGitHubRepo.TabIndex = 6
        ' 
        ' btnStopwatch
        ' 
        btnStopwatch.Location = New Point(12, 290)
        btnStopwatch.Name = "btnStopwatch"
        btnStopwatch.Size = New Size(195, 29)
        btnStopwatch.TabIndex = 7
        btnStopwatch.Text = "STOPWATCH TIME"
        btnStopwatch.UseVisualStyleBackColor = True
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(218, 290)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(216, 27)
        txtStopwatchTime.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 9
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 10
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 169)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 11
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(25, 223)
        Label5.Name = "Label5"
        Label5.Size = New Size(151, 20)
        Label5.TabIndex = 12
        Label5.Text = "Github Link For Task 2"
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(441, 385)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtStopwatchTime)
        Controls.Add(btnStopwatch)
        Controls.Add(txtGitHubRepo)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Name = "ViewSubmissionsForm"
        Text = "View Submissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGitHubRepo As TextBox
    Friend WithEvents btnStopwatch As Button
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
