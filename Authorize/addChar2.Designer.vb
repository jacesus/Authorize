<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addChar2
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
        Me.gender = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.nbGender = New System.Windows.Forms.TextBox()
        Me.age = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.race = New System.Windows.Forms.ComboBox()
        CType(Me.age, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gender
        '
        Me.gender.FormattingEnabled = True
        Me.gender.Items.AddRange(New Object() {"Male", "Female", "Non-Binary"})
        Me.gender.Location = New System.Drawing.Point(131, 55)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(121, 21)
        Me.gender.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(46, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nbGender
        '
        Me.nbGender.Enabled = False
        Me.nbGender.Location = New System.Drawing.Point(258, 56)
        Me.nbGender.Name = "nbGender"
        Me.nbGender.Size = New System.Drawing.Size(138, 20)
        Me.nbGender.TabIndex = 2
        '
        'age
        '
        Me.age.Location = New System.Drawing.Point(132, 7)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(120, 20)
        Me.age.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Age:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Gender:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Race:"
        '
        'race
        '
        Me.race.FormattingEnabled = True
        Me.race.Items.AddRange(New Object() {"Add Race..."})
        Me.race.Location = New System.Drawing.Point(131, 98)
        Me.race.Name = "race"
        Me.race.Size = New System.Drawing.Size(121, 21)
        Me.race.TabIndex = 7
        '
        'addChar2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 327)
        Me.Controls.Add(Me.race)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.nbGender)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gender)
        Me.Name = "addChar2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addChar2"
        CType(Me.age, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gender As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents nbGender As TextBox
    Friend WithEvents age As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents race As ComboBox
End Class
