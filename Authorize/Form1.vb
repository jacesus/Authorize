Imports System.IO
Public Class Form1
    '
    'Global Variables
    '
    Dim bold As Boolean = False
    Dim italic As Boolean = False
    Dim oProject As String
    Dim first As Boolean
    Dim re As StreamReader
    Dim wr As StreamWriter
    Dim p As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Authorize"
    '
    'Form Open / Close
    'Handles loading existing files and prompting for save
    ' 
    Private Sub Form1_Load() Handles Me.Load
        Dim path As String = p + "\" + oProject + "\text.rtf"
        re = My.Computer.FileSystem.OpenTextFileReader(p + "\" + oProject + "\info.aut")
        re.ReadLine() : re.ReadLine() : re.ReadLine()
        If re.ReadLine = "1" Then
            re.Close()
            wr = My.Computer.FileSystem.OpenTextFileWriter(p + "\" + oProject + "\info.aut", True)
            wr.WriteLine("0")
            wr.Close()
            mat.SaveFile(path)
        Else
            re.Close()
            mat.LoadFile(path)
        End If

    End Sub
    Private Sub Form1_Close() Handles Me.FormClosing
        re = My.Computer.FileSystem.OpenTextFileReader(p + "\" + oProject + "\text.rtf")
        Dim comp As New RichTextBox
        comp.Rtf = re.ReadToEnd
        re.Close()
        If mat.Rtf <> comp.Rtf Then
            If MsgBox("Would you like to save your progress?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                saveBt_click()
            End If
        End If
    End Sub
    '
    'Always On
    'Handles form aesthetic on resize and Bold-Italic Shortcuts
    '
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
                        st.Font = New Font(mat.Font, FontStyle.Bold Or FontStyle.Italic)
                    Else
                        mat.SelectionFont = New Font(mat.Font, FontStyle.Bold)
                        st.Font = New Font(mat.Font, FontStyle.Bold)
                    End If
                Else
                    If italic = True Then
                        mat.SelectionFont = New Font(mat.Font, FontStyle.Italic)
                        st.Font = New Font(mat.Font, FontStyle.Italic)
                    Else
                        mat.SelectionFont = New Font(mat.Font, FontStyle.Regular)
                        st.Font = New Font(mat.Font, FontStyle.Regular)
                    End If
                End If
            End If

            If e.KeyCode = Keys.I Then
                toggle(italic)
                If italic = True Then
                    If bold = True Then
                        mat.SelectionFont = New Font(mat.Font, FontStyle.Bold Or FontStyle.Italic)
                        st.Font = New Font(mat.Font, FontStyle.Bold Or FontStyle.Italic)
                    Else
                        mat.SelectionFont = New Font(mat.Font, FontStyle.Italic)
                        st.Font = New Font(mat.Font, FontStyle.Italic)
                    End If
                Else
                    If bold = True Then
                        mat.SelectionFont = New Font(mat.Font, FontStyle.Bold)
                        st.Font = New Font(mat.Font, FontStyle.Bold)
                    Else
                        mat.SelectionFont = New Font(mat.Font, FontStyle.Regular)
                        st.Font = New Font(mat.Font, FontStyle.Regular)
                    End If
                End If
                e.Handled = True
                e.SuppressKeyPress = True
            End If

        End If

    End Sub
    '
    'Misc
    '
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
    Sub setFirst(cCase As Boolean)
        first = cCase
    End Sub
    '
    'Save / Import
    '
    Private Sub saveDial()
        save.ShowDialog()
        If save.FileName <> "" Then
            mat.SaveFile(save.FileName())
        End If
    End Sub
    Private Sub saveBt_click() Handles saveBt.Click
        mat.SaveFile(p + "\" + oProject + "\text.rtf")
        re = My.Computer.FileSystem.OpenTextFileReader(p + "\" + oProject + "\info.aut")
        re.ReadLine() : re.ReadLine() : re.ReadLine() : re.ReadLine()
        Dim path As String = re.ReadLine()
        re.Close()
        If path = "" Or Not File.Exists(path) Then
            saveDial()
            wr = My.Computer.FileSystem.OpenTextFileWriter(p + "\" + oProject + "\info.aut", True)
            wr.WriteLine(save.FileName)
            wr.Close()
        Else
            mat.SaveFile(path)
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