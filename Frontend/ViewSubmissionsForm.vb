Imports System.Net.Http

Public Class ViewSubmissionsForm
    Private submissions As List(Of Dictionary(Of String, String))
    Private currentIndex As Integer = 0

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubmissions()
        DisplaySubmission(currentIndex)
    End Sub

    Private Sub LoadSubmissions()
        Dim client As New HttpClient()
        Dim response As HttpResponseMessage = client.GetAsync("http://localhost:3000/forms/read?index=" & currentIndex).Result
        If response.IsSuccessStatusCode Then
            Dim result As String = response.Content.ReadAsStringAsync().Result
            submissions = JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, String)))(result)
        Else
            MessageBox.Show("Failed to load submissions.")
        End If
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission = submissions(index)
            txtName.Text = submission("name")
            txtEmail.Text = submission("email")
            txtPhone.Text = submission("phone")
            txtGithub.Text = submission("github_link")
            txtTime.Text = submission("stopwatch_time")
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub
End Class
