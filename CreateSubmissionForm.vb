Imports System.Reflection.Emit
Imports System.Threading
Imports WindownsFormsApp.ViewSubmissionsForm

Public Class CreateSubmissionForm
    Dim StopWatch As New Diagnostics.Stopwatch

    Private Sub btnStartStopwatch_Click(sender As Object, e As EventArgs) Handles btnStartStopWatch.Click
        ToggleStopWatch()
    End Sub
    Private Sub ToggleStopWatch()
        If StopWatch.IsRunning Then
            Timer1.Stop()
            Me.StopWatch.Stop()
        Else
            Timer1.Start()
            Me.StopWatch.Start()
        End If
    End Sub
    Private Sub SendDataToBackend()
        ' Save submission to a data source
        Dim submission As New Submission() With {
        .Name = txtName.Text,
        .Email = txtEmail.Text,
        .Phone = txtPhone.Text,
        .GitHub = txtGithub.Text,
        .Timer = txtTimer.Text
        }
        BackendService.SubmitSubmission(submission)
        Me.Close()
        MsgBox("Successfully Form submit")
    End Sub
    Private Sub SendEditDataToBackend()
        ' Save submission to a data source
        Dim submission As New UpdatedSubmission() With {
        .Name = txtName.Text,
        .Email = txtEmail.Text,
        .Phone = txtPhone.Text,
        .GitHub = txtGithub.Text,
        .Timer = txtTimer.Text,
        .SubmissionId = currentIndex
        }
        BackendService.UpdateSubmission(submission)
        fromEditButton = False
        Me.Close()
        MsgBox("Successfully Form Updated")
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim sumbitBtnText = btnSubmit.Text
        If sumbitBtnText = "EDIT (CTRL + S)" Then
            SendEditDataToBackend()
        Else
            SendDataToBackend()
        End If

    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub

    Private Sub btnStartStopWatch_KeyDown(sender As Object, e As KeyEventArgs) Handles btnStartStopWatch.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            ToggleStopWatch()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            SendDataToBackend()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = Me.StopWatch.Elapsed
        txtTimer.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds)
    End Sub

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If fromEditButton Then
            Dim editSubmission = submissions(currentIndex)
            txtName.Text = editSubmission.Name
            txtEmail.Text = editSubmission.Email
            txtPhone.Text = editSubmission.Phone
            txtGithub.Text = editSubmission.GitHub
            txtTimer.Text = editSubmission.Timer
            btnSubmit.Text = "EDIT (CTRL + S)"
        End If
    End Sub

    Private Sub CreateSubmissionForm_HandleDestroyed(sender As Object, e As EventArgs) Handles Me.HandleDestroyed
        fromEditButton = False
    End Sub
End Class

