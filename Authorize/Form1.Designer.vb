<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.workspace = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.mat = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.nnList = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.charl = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.importBt = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.SaveFileDialog()
        Me.import = New System.Windows.Forms.OpenFileDialog()
        Me.saveBt = New System.Windows.Forms.Button()
        Me.st = New System.Windows.Forms.Label()
        Me.workspace.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'workspace
        '
        Me.workspace.Controls.Add(Me.TabPage1)
        Me.workspace.Controls.Add(Me.TabPage2)
        Me.workspace.Controls.Add(Me.TabPage3)
        Me.workspace.Dock = System.Windows.Forms.DockStyle.Top
        Me.workspace.Location = New System.Drawing.Point(0, 0)
        Me.workspace.Name = "workspace"
        Me.workspace.SelectedIndex = 0
        Me.workspace.Size = New System.Drawing.Size(1063, 399)
        Me.workspace.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.mat)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1055, 373)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'mat
        '
        Me.mat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mat.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mat.Location = New System.Drawing.Point(3, 3)
        Me.mat.Name = "mat"
        Me.mat.Size = New System.Drawing.Size(1049, 367)
        Me.mat.TabIndex = 0
        Me.mat.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TabControl1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1055, 373)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Characters"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1049, 367)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.nnList)
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Controls.Add(Me.fName)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.charl)
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1041, 341)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'nnList
        '
        Me.nnList.FormattingEnabled = True
        Me.nnList.Location = New System.Drawing.Point(96, 116)
        Me.nnList.Name = "nnList"
        Me.nnList.Size = New System.Drawing.Size(120, 95)
        Me.nnList.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Nicknames:"
        '
        'fName
        '
        Me.fName.BackColor = System.Drawing.SystemColors.Window
        Me.fName.Location = New System.Drawing.Point(96, 63)
        Me.fName.Name = "fName"
        Me.fName.ReadOnly = True
        Me.fName.Size = New System.Drawing.Size(211, 20)
        Me.fName.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Name:"
        '
        'charl
        '
        Me.charl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.charl.FormattingEnabled = True
        Me.charl.Items.AddRange(New Object() {"New Character..."})
        Me.charl.Location = New System.Drawing.Point(9, 19)
        Me.charl.MaxDropDownItems = 100
        Me.charl.Name = "charl"
        Me.charl.Size = New System.Drawing.Size(197, 21)
        Me.charl.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(415, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 79)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Selected Character"
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1041, 341)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1055, 373)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Settings"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'importBt
        '
        Me.importBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.importBt.Location = New System.Drawing.Point(274, 405)
        Me.importBt.Name = "importBt"
        Me.importBt.Size = New System.Drawing.Size(264, 62)
        Me.importBt.TabIndex = 1
        Me.importBt.Text = "Import File"
        Me.importBt.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.Filter = "Rich test format|*.rtf|Text file|*.txt|All files|*.*"
        '
        'import
        '
        Me.import.Filter = "Rich test format|*.rtf|Simple text file|*.txt|All text files|*.rtf; *.txt|All fil" &
    "es|*.*"
        Me.import.FilterIndex = 3
        '
        'saveBt
        '
        Me.saveBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBt.Location = New System.Drawing.Point(4, 405)
        Me.saveBt.Name = "saveBt"
        Me.saveBt.Size = New System.Drawing.Size(264, 62)
        Me.saveBt.TabIndex = 2
        Me.saveBt.Text = "Save File"
        Me.saveBt.UseVisualStyleBackColor = True
        '
        'st
        '
        Me.st.AutoSize = True
        Me.st.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.st.Location = New System.Drawing.Point(561, 412)
        Me.st.Name = "st"
        Me.st.Size = New System.Drawing.Size(92, 45)
        Me.st.TabIndex = 3
        Me.st.Text = "Style"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 479)
        Me.Controls.Add(Me.st)
        Me.Controls.Add(Me.saveBt)
        Me.Controls.Add(Me.importBt)
        Me.Controls.Add(Me.workspace)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.workspace.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents workspace As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents mat As RichTextBox
    Friend WithEvents importBt As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents save As SaveFileDialog
    Friend WithEvents import As OpenFileDialog
    Friend WithEvents saveBt As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents st As Label
    Friend WithEvents charl As ComboBox
    Friend WithEvents nnList As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents fName As TextBox
    Friend WithEvents Label5 As Label
End Class
