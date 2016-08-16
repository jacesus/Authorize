Imports System.IO
Public Class addChar1
    Dim oProject As String = Form1.getProject()
    Dim charFolder As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Authorize\" + oProject + "\Char"

    Private Sub addNick_Click(sender As Object, e As EventArgs) Handles addNick.Click
        If nName.Text <> "" Then
            ListBox1.Items.Add(nName.Text)
            nName.Text = ""
        End If
    End Sub

    Private Sub nextB_Click(sender As Object, e As EventArgs) Handles nextB.Click
        Dim fullName As String = fName.Text + " " + mName.Text + " " + lName.Text
        Dim thisChar As String = charFolder + "\" + fullName

        Dim wr As StreamWriter
        wr = My.Computer.FileSystem.OpenTextFileWriter(charFolder + "\charList.aut", True)
        wr.WriteLine(fullName)
        wr.Close()

        Directory.CreateDirectory(thisChar)
        wr = My.Computer.FileSystem.OpenTextFileWriter(thisChar + "\basics.aut", False)
        wr.WriteLine(fullName)
        For k As Integer = 0 To ListBox1.Items.Count - 1
            wr.WriteLine(ListBox1.Items.Item(k))
        Next
        wr.Close()

        Dim re As StreamReader
        Dim n As String
        re = My.Computer.FileSystem.OpenTextFileReader(thisChar + "\basics.aut")
        n = re.ReadLine()
        Form1.charl.Items.Add(n)
        re.Close()

        Close()
    End Sub
End Class