Imports System.IO
Public Class addChar1
    Dim oProject As String = Form1.getProject()
    Dim charFolder As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Authorize\" + oProject + "\Char"

    Private Sub addNick_Click(sender As Object, e As EventArgs) Handles addNick.Click
        If nName.Text <> "" Then
            nList.Items.Add(nName.Text)
            nName.Text = ""
        End If
    End Sub

    Private Sub nextB_Click(sender As Object, e As EventArgs) Handles nextB.Click
        If fName.Text <> "" Then
            Dim fullName As String = fName.Text + " " + mName.Text + " " + lName.Text
            Dim thisChar As String = charFolder + "\" + fullName

            Dim wr As StreamWriter
            wr = My.Computer.FileSystem.OpenTextFileWriter(charFolder + "\charList.aut", True)
            wr.WriteLine(fullName)
            wr.Close()

            Directory.CreateDirectory(thisChar)
            wr = My.Computer.FileSystem.OpenTextFileWriter(thisChar + "\basics.aut", False)
            wr.WriteLine(fullName)
            For k As Integer = 0 To nList.Items.Count - 1
                wr.WriteLine(nList.Items.Item(k))
            Next
            wr.Close()

            Dim re As StreamReader
            Dim n As String
            re = My.Computer.FileSystem.OpenTextFileReader(thisChar + "\basics.aut")
            n = re.ReadLine()
            Form1.charl.Items.Add(n)
            re.Close()

            Close()
            addChar2.Show()
        Else
            MsgBox("Please enter at least the first name before adding the character.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub delNick_click() Handles delNick.Click
        If nList.SelectedIndex <> -1 Then
            If MsgBox("Do you want to delete this nickname?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                nList.Items.RemoveAt(nList.SelectedIndex)
            End If
        End If
    End Sub
    Private Sub nList_DoubleClick(sender As Object, e As EventArgs) Handles nList.DoubleClick
        delNick_click()
    End Sub

    Private Sub EnterNick() Handles nName.Enter
        AcceptButton = addNick
    End Sub
    Private Sub ExitNick() Handles nName.Leave
        AcceptButton = nextB
    End Sub
    Private Sub EnterList() Handles nList.Enter
        AcceptButton = delNick
    End Sub
    Private Sub ExitList() Handles nList.Leave
        AcceptButton = nextB
    End Sub
End Class