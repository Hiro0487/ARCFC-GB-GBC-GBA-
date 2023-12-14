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
        OpenFileDialog = New OpenFileDialog()
        SaveFileDialog = New SaveFileDialog()
        BrowseButton = New Button()
        ExtractButton = New Button()
        CloseButton = New Button()
        ProgressBar = New ProgressBar()
        inputFileTextBox = New TextBox()
        OutputFileLabel = New Label()
        SuspendLayout()
        ' 
        ' OpenFileDialog
        ' 
        OpenFileDialog.FileName = "OpenFileDialog"
        ' 
        ' BrowseButton
        ' 
        BrowseButton.Location = New Point(12, 30)
        BrowseButton.Name = "BrowseButton"
        BrowseButton.Size = New Size(263, 78)
        BrowseButton.TabIndex = 0
        BrowseButton.Text = "Browse"
        BrowseButton.UseVisualStyleBackColor = True
        ' 
        ' ExtractButton
        ' 
        ExtractButton.Location = New Point(12, 114)
        ExtractButton.Name = "ExtractButton"
        ExtractButton.Size = New Size(263, 78)
        ExtractButton.TabIndex = 1
        ExtractButton.Text = "Extract"
        ExtractButton.UseVisualStyleBackColor = True
        ' 
        ' CloseButton
        ' 
        CloseButton.Location = New Point(12, 302)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(263, 78)
        CloseButton.TabIndex = 2
        CloseButton.Text = "CLOSE"
        CloseButton.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar
        ' 
        ProgressBar.Location = New Point(12, 219)
        ProgressBar.Name = "ProgressBar"
        ProgressBar.Size = New Size(263, 77)
        ProgressBar.TabIndex = 3
        ' 
        ' inputFileTextBox
        ' 
        inputFileTextBox.Location = New Point(12, 1)
        inputFileTextBox.Multiline = True
        inputFileTextBox.Name = "inputFileTextBox"
        inputFileTextBox.ReadOnly = True
        inputFileTextBox.Size = New Size(263, 23)
        inputFileTextBox.TabIndex = 4
        inputFileTextBox.Text = "Source Directory"
        ' 
        ' OutputFileLabel
        ' 
        OutputFileLabel.AutoSize = True
        OutputFileLabel.Location = New Point(23, 198)
        OutputFileLabel.Name = "OutputFileLabel"
        OutputFileLabel.Size = New Size(90, 15)
        OutputFileLabel.TabIndex = 5
        OutputFileLabel.Text = "Target Directory"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(287, 392)
        ControlBox = False
        Controls.Add(OutputFileLabel)
        Controls.Add(inputFileTextBox)
        Controls.Add(ProgressBar)
        Controls.Add(CloseButton)
        Controls.Add(ExtractButton)
        Controls.Add(BrowseButton)
        Name = "Form1"
        Text = "mBoy! to mGBA Cheat File converter"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents BrowseButton As Button
    Friend WithEvents ExtractButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents inputFileTextBox As TextBox
    Friend WithEvents OutputFileLabel As Label

End Class
