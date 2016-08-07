<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartUp
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
        Me.bNameList = New System.Windows.Forms.ListBox()
        Me.pOpen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pBox = New System.Windows.Forms.TextBox()
        Me.pAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bNameList
        '
        Me.bNameList.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNameList.FormattingEnabled = True
        Me.bNameList.ItemHeight = 31
        Me.bNameList.Location = New System.Drawing.Point(12, 12)
        Me.bNameList.Name = "bNameList"
        Me.bNameList.Size = New System.Drawing.Size(380, 345)
        Me.bNameList.TabIndex = 0
        '
        'pOpen
        '
        Me.pOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pOpen.Location = New System.Drawing.Point(398, 306)
        Me.pOpen.Name = "pOpen"
        Me.pOpen.Size = New System.Drawing.Size(152, 51)
        Me.pOpen.TabIndex = 1
        Me.pOpen.Text = "Open"
        Me.pOpen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(398, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password"
        '
        'pBox
        '
        Me.pBox.Enabled = False
        Me.pBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pBox.Location = New System.Drawing.Point(398, 12)
        Me.pBox.Name = "pBox"
        Me.pBox.ShortcutsEnabled = False
        Me.pBox.Size = New System.Drawing.Size(311, 38)
        Me.pBox.TabIndex = 3
        Me.pBox.UseSystemPasswordChar = True
        '
        'pAdd
        '
        Me.pAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pAdd.Location = New System.Drawing.Point(398, 249)
        Me.pAdd.Name = "pAdd"
        Me.pAdd.Size = New System.Drawing.Size(152, 51)
        Me.pAdd.TabIndex = 4
        Me.pAdd.Text = "Add"
        Me.pAdd.UseVisualStyleBackColor = True
        '
        'StartUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 378)
        Me.Controls.Add(Me.pAdd)
        Me.Controls.Add(Me.pBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pOpen)
        Me.Controls.Add(Me.bNameList)
        Me.Name = "StartUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StartUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bNameList As ListBox
    Friend WithEvents pOpen As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pBox As TextBox
    Friend WithEvents pAdd As Button
End Class
