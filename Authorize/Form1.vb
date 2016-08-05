Public Class Form1
    Dim bold As Boolean = False
    Dim italic As Boolean = False

    Private Sub resizePatrol() Handles Me.Resize
        workspace.Height = Height - Button1.Height - 70
        Button1.Location = New Point(Button1.Location.X, Height - 120)
    End Sub
    Sub IsKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles mat.KeyDown

        If e.Control = True Then

            If e.KeyCode = Keys.B Then
                toggle(bold)
                If bold = True Then
                    If italic = True Then
                        mat.SelectionFont = New Font(mat.Font, FontStyle.Bold Or FontStyle.Italic)
                    Else
                        mat.SelectionFont = New Font(mat.Font, FontStyle.Bold)
                    End If
                Else
                    If italic = True Then
                        mat.SelectionFont = New Font(mat.Font, FontStyle.Italic)
                    Else
                        mat.SelectionFont = New Font(mat.Font, FontStyle.Regular)
                    End If
                End If
            End If

            If e.KeyCode = Keys.I Then
                toggle(italic)
                If italic = True Then
                    If bold = True Then
                        mat.SelectionFont = New Font(mat.Font, FontStyle.Bold Or FontStyle.Italic)
                    Else
                        mat.SelectionFont = New Font(mat.Font, FontStyle.Italic)
                    End If
                Else
                    If bold = True Then
                        mat.SelectionFont = New Font(mat.Font, FontStyle.Bold)
                    Else
                        mat.SelectionFont = New Font(mat.Font, FontStyle.Regular)
                    End If
                End If
                e.Handled = True
                e.SuppressKeyPress = True
            End If

        End If

    End Sub

    Sub toggle(ByRef bool As Boolean)
        If bool = True Then
            bool = False
        ElseIf bool = False Then
            bool = True
        End If
    End Sub

End Class


'7719