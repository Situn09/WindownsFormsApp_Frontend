Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class BackendService
    Private Shared ReadOnly client As HttpClient = New HttpClient()
    Private Shared baseUrl = "http://localhost:3000/api/"

    ' Fetch list of submissions from the backend API
    Public Shared Function GetSubmissions() As List(Of Submission)
        Dim submissions As New List(Of Submission)()

        Try
            Dim response As HttpResponseMessage = client.GetAsync(baseUrl + "read").Result
            response.EnsureSuccessStatusCode()
            Dim responseBody As String = response.Content.ReadAsStringAsync().Result
            submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(responseBody)
        Catch e As Exception
            Console.WriteLine($"An error occurred: {e.Message}")
        End Try

        Return submissions
    End Function

    ' Submit a new submission to the backend API
    Public Shared Sub SubmitSubmission(submission As Submission)
        Try
            Dim json As String = JsonConvert.SerializeObject(submission)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = client.PostAsync(baseUrl + "submit", content).Result
            response.EnsureSuccessStatusCode()
            Dim responseBody As String = response.Content.ReadAsStringAsync().Result
            Console.WriteLine($"Submission response: {responseBody}")
        Catch e As Exception
            Console.WriteLine($"An error occurred: {e.Message}")
        End Try
    End Sub

    ' Update an existing submission in the backend API
    Public Shared Sub UpdateSubmission(submission As Submission)
        Try
            Dim json As String = JsonConvert.SerializeObject(submission)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = client.PutAsync($"{baseUrl}edit", content).Result
            response.EnsureSuccessStatusCode()
            Dim responseBody As String = response.Content.ReadAsStringAsync().Result
            Console.WriteLine($"Update response: {responseBody}")
        Catch e As Exception
            Console.WriteLine($"An error occurred: {e.Message}")
        End Try
    End Sub

    ' Delete a submission from the backend API
    Public Shared Sub DeleteSubmission(submissionId As Integer)
        Try
            Dim response As HttpResponseMessage = client.DeleteAsync($"{baseUrl}delete?submissionId={submissionId}").Result
            response.EnsureSuccessStatusCode()
            Dim responseBody As String = response.Content.ReadAsStringAsync().Result
            Console.WriteLine($"Delete response: {responseBody}")
        Catch e As Exception
            Console.WriteLine($"An error occurred: {e.Message}")
        End Try
    End Sub
End Class
