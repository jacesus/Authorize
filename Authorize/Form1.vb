Public Class Form1
    Private Sub resizePatrol() Handles Me.Resize
        workspace.Height = Height - Button1.Height - 70
        Button1.Location = New Point(Button1.Location.X, Height - 120)
    End Sub
End Class
