Public Class Form1
    Private Sub ZeroBtn_Click(sender As Object, e As EventArgs) Handles ZeroBtn.Click
        If Display.Text = "0" Then
            Display.Text = "0"
        Else
            Display.Text = Display.Text + "0"
        End If

    End Sub

    Private Sub OneBtn_Click(sender As Object, e As EventArgs) Handles OneBtn.Click
        If Display.Text = "0" Then
            Display.Text = "1"
        Else
            Display.Text = Display.Text + "1"
        End If
    End Sub

    Private Sub TwoBtn_Click(sender As Object, e As EventArgs) Handles TwoBtn.Click
        If Display.Text = "0" Then
            Display.Text = "2"
        Else
            Display.Text = Display.Text + "2"
        End If
    End Sub

    Private Sub ThreeBtn_Click(sender As Object, e As EventArgs) Handles ThreeBtn.Click
        If Display.Text = "0" Then
            Display.Text = "3"
        Else
            Display.Text = Display.Text + "3"
        End If
    End Sub

    Private Sub FourBtn_Click(sender As Object, e As EventArgs) Handles FourBtn.Click
        If Display.Text = "0" Then
            Display.Text = "4"
        Else
            Display.Text = Display.Text + "4"
        End If
    End Sub

    Private Sub FiveBtn_Click(sender As Object, e As EventArgs) Handles FiveBtn.Click
        If Display.Text = "0" Then
            Display.Text = "5"
        Else
            Display.Text = Display.Text + "5"
        End If
    End Sub

    Private Sub SixBtn_Click(sender As Object, e As EventArgs) Handles SixBtn.Click
        If Display.Text = "0" Then
            Display.Text = "6"
        Else
            Display.Text = Display.Text + "6"
        End If
    End Sub

    Private Sub SevenBtn_Click(sender As Object, e As EventArgs) Handles SevenBtn.Click
        If Display.Text = "0" Then
            Display.Text = "7"
        Else
            Display.Text = Display.Text + "7"
        End If
    End Sub

    Private Sub EightBtn_Click(sender As Object, e As EventArgs) Handles EightBtn.Click
        If Display.Text = "0" Then
            Display.Text = "8"
        Else
            Display.Text = Display.Text + "8"
        End If
    End Sub

    Private Sub NineBtn_Click(sender As Object, e As EventArgs) Handles NineBtn.Click
        If Display.Text = "0" Then
            Display.Text = "9"
        Else
            Display.Text = Display.Text + "9"
        End If
    End Sub

    Private Sub ClearAllBtn_Click(sender As Object, e As EventArgs) Handles ClearAllBtn.Click
        Display.Text = "0"
    End Sub

    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click
        If Display.Text.Length = 1 Then
            Display.Text = "0"
        Else
            Display.Text = Display.Text.Remove(Display.Text.Length - 1)
        End If
    End Sub
End Class
