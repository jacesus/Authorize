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
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.saveBt = New System.Windows.Forms.Button()
        Me.importBt = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.SaveFileDialog()
        Me.import = New System.Windows.Forms.OpenFileDialog()
        Me.workspace.SuspendLayout()
        Me.TabPage1.SuspendLayout()
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
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1055, 373)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Characters"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        'saveBt
        '
        Me.saveBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBt.Location = New System.Drawing.Point(4, 405)
        Me.saveBt.Name = "saveBt"
        Me.saveBt.Size = New System.Drawing.Size(264, 62)
        Me.saveBt.TabIndex = 0
        Me.saveBt.Text = "Save File"
        Me.saveBt.UseVisualStyleBackColor = True
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 479)
        Me.Controls.Add(Me.importBt)
        Me.Controls.Add(Me.saveBt)
        Me.Controls.Add(Me.workspace)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.workspace.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents workspace As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents saveBt As Button
    Friend WithEvents mat As RichTextBox
    Friend WithEvents importBt As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents save As SaveFileDialog
    Friend WithEvents import As OpenFileDialog
End Class
