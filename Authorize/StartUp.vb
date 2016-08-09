Imports System.IO
Public Class StartUp
    '
    'Global Variables
    '
    Dim pass As String = ""
    Dim wr As StreamWriter
    Dim re As StreamReader
    Dim p As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Authorize"
    '
    'Form Load
    'Creates Initial Folder
    '
    Private Sub StartUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not Directory.Exists(p) Then
            Directory.CreateDirectory(p)
        End If

        wr = My.Computer.FileSystem.OpenTextFileWriter(p + "\Projects.aut", True)
        wr.Close()

        re = My.Computer.FileSystem.OpenTextFileReader(p + "\Projects.aut")
        While re.EndOfStream = False
            bNameList.Items.Add(re.ReadLine)
        End While
        re.Close()

        If bNameList.Items.Count <> 0 Then
            bNameList.SelectedIndex = 0
        End If
    End Sub
    '
    'Open or Add Project
    '
    Private Sub pOpen_Click(sender As Object, e As EventArgs) Handles pOpen.Click
        If pBox.Text = pass Then
            Form1.setProject(bNameList.SelectedItem)
            Form1.Show()
            Me.Close()
        Else
            MsgBox("Wrong password.", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub pAdd_Click(sender As Object, e As EventArgs) Handles pAdd.Click
        addProj.Show()
    End Sub
    '
    'Password Existance Checker (Password Box Enabled or Not) 
    '
    Private Sub bNameList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bNameList.SelectedIndexChanged
        re = My.Computer.FileSystem.OpenTextFileReader(p + "\" + bNameList.SelectedItem + "\info.aut")
        re.ReadLine() : re.ReadLine() : pass = re.ReadLine()
        pBox.Text = ""
        If pass = "" Then
            pBox.Enabled = False
        Else
            pBox.Enabled = True
        End If
        re.Close()
    End Sub
End Class