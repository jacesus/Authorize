Imports System.IO

Public Class addProj
    '
    'Global Variables
    '
    Dim p As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Authorize"
    Dim wr As StreamWriter
    Dim re As StreamReader
    '
    'Password Exists?
    '
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        toggle(pPass.Enabled)
        pPass.Text = ""
    End Sub
    Sub toggle(ByRef bool As Boolean)
        If bool = True Then
            bool = False
        ElseIf bool = False Then
            bool = True
        End If
    End Sub
    '
    'Add Button
    'Creates all the project sub-folders and files: Info.aut, Char folder, Set.aut, and Text.rtf
    '
    Private Sub addBt_Click(sender As Object, e As EventArgs) Handles addBt.Click
        If Not Directory.Exists(p + "\" + pName.Text) Then
            If pName.Text <> "" And pAuthor.Text <> "" Then
                Directory.CreateDirectory(p + "\" + pName.Text)
                wr = My.Computer.FileSystem.OpenTextFileWriter(p + "\Projects.aut", True)
                wr.WriteLine(pName.Text)
                wr.Close()
                Directory.CreateDirectory(p + "\" + pName.Text + "\Char")
                wr = My.Computer.FileSystem.OpenTextFileWriter(p + "\" + pName.Text + "\set.aut", True)
                wr.Close()
                wr = My.Computer.FileSystem.OpenTextFileWriter(p + "\" + pName.Text + "\info.aut", True)
                wr.WriteLine(pName.Text) : wr.WriteLine(pAuthor.Text) : wr.WriteLine(pPass.Text)
                wr.Close()
                StartUp.Close()
                StartUp.Show()
                Me.Close()
            Else
                MsgBox("Please fill in all information.", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Name already exists. Please pick another one.")
        End If
    End Sub
End Class