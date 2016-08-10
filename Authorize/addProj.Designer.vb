<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addProj
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
        Me.addBt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pName = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.pAuthor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'addBt
        '
        Me.addBt.Location = New System.Drawing.Point(34, 210)
        Me.addBt.Name = "addBt"
        Me.addBt.Size = New System.Drawing.Size(75, 23)
        Me.addBt.TabIndex = 5
        Me.addBt.Text = "Add"
        Me.addBt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Project Name"
        '
        'pName
        '
        Me.pName.Location = New System.Drawing.Point(87, 40)
        Me.pName.Name = "pName"
        Me.pName.Size = New System.Drawing.Size(100, 20)
        Me.pName.TabIndex = 1
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(34, 140)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(127, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Password Protected?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'pAuthor
        '
        Me.pAuthor.Location = New System.Drawing.Point(87, 91)
        Me.pAuthor.Name = "pAuthor"
        Me.pAuthor.Size = New System.Drawing.Size(100, 20)
        Me.pAuthor.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Author"
        '
        'pPass
        '
        Me.pPass.Enabled = False
        Me.pPass.Location = New System.Drawing.Point(87, 163)
        Me.pPass.Name = "pPass"
        Me.pPass.Size = New System.Drawing.Size(100, 20)
        Me.pPass.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'addProj
        '
        Me.AcceptButton = Me.addBt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(218, 247)
        Me.Controls.Add(Me.pPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pAuthor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.pName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.addBt)
        Me.Name = "addProj"
        Me.Text = "addProj"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addBt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pName As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents pAuthor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pPass As TextBox
    Friend WithEvents Label3 As Label
End Class
