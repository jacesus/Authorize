Imports System.IO

Public Class StartUp

    Dim wr As StreamWriter
    Dim re As StreamReader
    Dim p As String = "C:\Users\Hamoudy\Documents\Authorize"

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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.setProject(bNameList.SelectedItem)
        Form1.Show()
        Me.Close()
    End Sub
End Class

'If Not Directory.Exists(path) Then
'Directory.CreateDirectory(path)
'End If