
Public Class FirstForm
    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
        createForm.KeyPreview = True
    End Sub



    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FirstForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim viewForm As New ViewSubmissionsForm()
        Dim createForm As New CreateSubmissionForm()
        If e.Control AndAlso e.KeyCode = Keys.N Then
            createForm.Show()
        ElseIf e.Control AndAlso e.KeyCode = Keys.V Then
            viewForm.Show()
        End If
    End Sub


End Class

