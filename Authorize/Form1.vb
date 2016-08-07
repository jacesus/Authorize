Imports System.IO
Public Class Form1
    Dim bold As Boolean = False
    Dim italic As Boolean = False
    Dim oProject As String
    Dim re As StreamReader
    Dim p As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Authorize"

    Private Sub resizePatrol() Handles Me.Resize
        workspace.Height = Height - saveBt.Height - 70
        saveBt.Location = New Point(saveBt.Location.X, Height - 120)
        importBt.Location = New Point(importBt.Location.X, Height - 120)
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
    Sub setProject(pName As String)
        oProject = pName
    End Sub

    Private Sub saveBt_Click(sender As Object, e As EventArgs) Handles saveBt.Click
        save.ShowDialog()
        If save.FileName <> "" Then
            mat.SaveFile(save.FileName())
        End If
        save.FileName = ""
    End Sub

    Private Sub importBt_Click(sender As Object, e As EventArgs) Handles importBt.Click
        import.ShowDialog()
        Dim f As String = import.FileName
        If Not f = "" Then
            If f.EndsWith(".rtf") Then
                mat.LoadFile(f)
            ElseIf f.EndsWith(".txt") Then
                mat.Text = ""
                re = My.Computer.FileSystem.OpenTextFileReader(f)
                mat.Text = re.ReadToEnd
                re.Close()
            Else
                MsgBox("Incorrect File Format!", MsgBoxStyle.Critical)
            End If
        End If
    End Sub
End Class