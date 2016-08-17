<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addChar1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.addNick = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fName = New System.Windows.Forms.TextBox()
        Me.mName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nList = New System.Windows.Forms.ListBox()
        Me.nextB = New System.Windows.Forms.Button()
        Me.delNick = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'addNick
        '
        Me.addNick.Location = New System.Drawing.Point(12, 161)
        Me.addNick.Name = "addNick"
        Me.addNick.Size = New System.Drawing.Size(72, 23)
        Me.addNick.TabIndex = 0
        Me.addNick.Text = "Add"
        Me.addNick.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name (*) :"
        '
        'fName
        '
        Me.fName.Location = New System.Drawing.Point(89, 6)
        Me.fName.Name = "fName"
        Me.fName.Size = New System.Drawing.Size(105, 20)
        Me.fName.TabIndex = 2
        '
        'mName
        '
        Me.mName.Location = New System.Drawing.Point(89, 39)
        Me.mName.Name = "mName"
        Me.mName.Size = New System.Drawing.Size(105, 20)
        Me.mName.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Middle Name:"
        '
        'lName
        '
        Me.lName.Location = New System.Drawing.Point(89, 77)
        Me.lName.Name = "lName"
        Me.lName.Size = New System.Drawing.Size(105, 20)
        Me.lName.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Last Name:"
        '
        'nName
        '
        Me.nName.Location = New System.Drawing.Point(12, 135)
        Me.nName.Name = "nName"
        Me.nName.Size = New System.Drawing.Size(72, 20)
        Me.nName.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nicknames:"
        '
        'nList
        '
        Me.nList.FormattingEnabled = True
        Me.nList.Location = New System.Drawing.Point(89, 119)
        Me.nList.Name = "nList"
        Me.nList.Size = New System.Drawing.Size(120, 95)
        Me.nList.TabIndex = 11
        '
        'nextB
        '
        Me.nextB.Location = New System.Drawing.Point(89, 220)
        Me.nextB.Name = "nextB"
        Me.nextB.Size = New System.Drawing.Size(120, 39)
        Me.nextB.TabIndex = 12
        Me.nextB.Text = "Next"
        Me.nextB.UseVisualStyleBackColor = True
        '
        'delNick
        '
        Me.delNick.Location = New System.Drawing.Point(12, 190)
        Me.delNick.Name = "delNick"
        Me.delNick.Size = New System.Drawing.Size(72, 23)
        Me.delNick.TabIndex = 13
        Me.delNick.Text = "Delete"
        Me.delNick.UseVisualStyleBackColor = True
        '
        'addChar1
        '
        Me.AcceptButton = Me.nextB
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 271)
        Me.Controls.Add(Me.delNick)
        Me.Controls.Add(Me.nextB)
        Me.Controls.Add(Me.nList)
        Me.Controls.Add(Me.nName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.mName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.addNick)
        Me.Name = "addChar1"
        Me.Text = "addChar1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addNick As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents fName As TextBox
    Friend WithEvents mName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nList As ListBox
    Friend WithEvents nextB As Button
    Friend WithEvents delNick As Button
End Class
