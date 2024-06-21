<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    Private stopwatch As New Stopwatch()

    Private Sub btnStopwatch_Click(sender As Object, e As EventArgs) Handles btnStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Save submission logic
        Dim submission As String = $"{txtName.Text}, {txtEmail.Text}, {txtPhoneNumber.Text}, {txtGitHubRepo.Text}, {stopwatch.Elapsed}"
        ' Add submission to storage
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
        txtName = New Label()
        txtEmail = New Label()
        txtPhoneNumber = New Label()
        txtGitHubRepo = New Label()
        btnSubmit = New Button()
        btnStopwatch = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.AutoSize = True
        txtName.Location = New Point(12, 51)
        txtName.Name = "txtName"
        txtName.Size = New Size(49, 20)
        txtName.TabIndex = 0
        txtName.Text = "Name"
        ' 
        ' txtEmail
        ' 
        txtEmail.AutoSize = True
        txtEmail.Location = New Point(12, 99)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(46, 20)
        txtEmail.TabIndex = 1
        txtEmail.Text = "Email"
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.AutoSize = True
        txtPhoneNumber.Location = New Point(12, 149)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(108, 20)
        txtPhoneNumber.TabIndex = 2
        txtPhoneNumber.Text = "Phone Number"
        ' 
        ' txtGitHubRepo
        ' 
        txtGitHubRepo.AutoSize = True
        txtGitHubRepo.Location = New Point(12, 196)
        txtGitHubRepo.Name = "txtGitHubRepo"
        txtGitHubRepo.Size = New Size(125, 20)
        txtGitHubRepo.TabIndex = 3
        txtGitHubRepo.Text = "GitHub Repo Link"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.SkyBlue
        btnSubmit.Location = New Point(12, 299)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(399, 29)
        btnSubmit.TabIndex = 4
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnStopwatch
        ' 
        btnStopwatch.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnStopwatch.Location = New Point(12, 250)
        btnStopwatch.Name = "btnStopwatch"
        btnStopwatch.Size = New Size(242, 29)
        btnStopwatch.TabIndex = 5
        btnStopwatch.Text = "TOGGLE STOPWATCH (CRTL+T)"
        btnStopwatch.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(176, 196)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(228, 27)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(176, 149)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(228, 27)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(176, 99)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(228, 27)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Location = New Point(176, 51)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(228, 27)
        TextBox4.TabIndex = 9
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(279, 252)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(125, 27)
        TextBox5.TabIndex = 10
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(423, 340)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(btnStopwatch)
        Controls.Add(btnSubmit)
        Controls.Add(txtGitHubRepo)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Name = "CreateSubmissionForm"
        Text = "Create Submission Form"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtName As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents txtGitHubRepo As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnStopwatch As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
End Class
