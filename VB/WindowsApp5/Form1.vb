Public Class Form1
    Dim random As New Random(), rnd As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Show()
        Button2.Show()
        Button3.Show()
        Button4.Show()
        Button5.Show()
        Button6.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Hide()
        rnd = random.Next(0, 3)
        Button3.Hide()
        If rnd = 1 Then
            Button5.Hide()
            Button6.Hide()
        ElseIf rnd = 2 Then
            Button4.Hide()
            Button6.Hide()
        Else
            Button4.Hide()
            Button5.Hide()
        End If
        Threading.Thread.Sleep(1000)
        Application.Restart()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Hide()
        Button3.Hide()
        rnd = random.Next(0, 3)
        If rnd = 1 Then
            Button5.Hide()
            Button6.Hide()
        ElseIf rnd = 2 Then
            Button4.Hide()
            Button6.Hide()
        Else
            Button4.Hide()
            Button5.Hide()
        End If
        Threading.Thread.Sleep(1000)
        Application.Restart()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button1.Hide()
        Button2.Hide()
        rnd = random.Next(0, 3)
        If rnd = 1 Then
            Button5.Hide()
            Button6.Hide()
        ElseIf rnd = 2 Then
            Button4.Hide()
            Button6.Hide()
        Else
            Button4.Hide()
            Button5.Hide()
        End If
        Threading.Thread.Sleep(1000)
        Application.Restart()
    End Sub
End Class