
Public Class ViewSubmissionsForm
    Public Shared submissions As List(Of Submission)
    Public Shared currentIndex As Integer
    Public Shared fromEditButton As Boolean
    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load submissions from the backend when the form loads
        submissions = BackendService.GetSubmissions()
        currentIndex = 0
        DisplaySubmission()
    End Sub

    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            ' Display current submission
            Dim submission = submissions(currentIndex)
            lblName.Text = submission.Name
            lblEmail.Text = submission.Email
            lblPhone.Text = submission.Phone
            lblGithub.Text = submission.GitHub
            lblTimer.Text = submission.Timer
        Else
            MsgBox("No Submission available")
            Me.Close()
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        PreviousClickHandler()
    End Sub
    Private Sub PreviousClickHandler()
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        Else
            MsgBox("you can't go any backward")
        End If
    End Sub
    Private Sub NextClickHandler()
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        Else
            MsgBox("You come to the end of the submission list")
        End If
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        NextClickHandler()
    End Sub


    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            PreviousClickHandler()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            NextClickHandler()
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            DeleteSubmission()
        ElseIf e.Control AndAlso e.KeyCode = Keys.E Then
            EditSubmission()
        End If
    End Sub
    Private Sub EditSubmission()
        Dim createForm As New CreateSubmissionForm()
        fromEditButton = True
        Me.Close()
        createForm.Show()
    End Sub
    Private Sub DeleteSubmission()
        BackendService.DeleteSubmission(currentIndex)
        submissions.RemoveAt(currentIndex)
        MsgBox($"Successfully delete your submission of ID:- {currentIndex}")
        If submissions.Count = 0 Then
            MsgBox("No more submission form")
            Me.Close()
        ElseIf currentIndex > Submissions.Count - 1 Then
            currentIndex = submissions.Count - 1
        End If
        DisplaySubmission()

    End Sub

    Private Sub SearchSubmission()
        Dim email = searchBox.Text
        Dim submissions = BackendService.SearchSubmission(email)
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission = submissions(0)
            lblName.Text = submission.Name
            lblEmail.Text = submission.Email
            lblPhone.Text = submission.Phone
            lblGithub.Text = submission.GitHub
            lblTimer.Text = submission.Timer
        Else
            MsgBox("No Submission available")
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteSubmission()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EditSubmission()
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchSubmission()
    End Sub
End Class
