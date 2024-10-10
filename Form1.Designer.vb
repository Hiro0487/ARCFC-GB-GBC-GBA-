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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        OpenFileDialog = New OpenFileDialog()
        SaveFileDialog = New SaveFileDialog()
        PictureBox1 = New PictureBox()
        OutputFileLabel = New Label()
        BrowseButton = New Button()
        inputFileTextBox = New Label()
        ProgressBar = New ProgressBar()
        CloseButton = New Button()
        ExtractButton = New Button()
        GroupBox1 = New GroupBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' OpenFileDialog
        ' 
        OpenFileDialog.FileName = "OpenFileDialog"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.Hiro0487_s_mBoy__to_mGBA_Marker1
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(10, 223)
        PictureBox1.Margin = New Padding(5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(462, 174)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' OutputFileLabel
        ' 
        OutputFileLabel.AutoSize = True
        OutputFileLabel.BackColor = Color.Transparent
        OutputFileLabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Underline)
        OutputFileLabel.ForeColor = Color.Firebrick
        OutputFileLabel.Location = New Point(238, 148)
        OutputFileLabel.Margin = New Padding(5, 0, 5, 0)
        OutputFileLabel.Name = "OutputFileLabel"
        OutputFileLabel.Size = New Size(58, 21)
        OutputFileLabel.TabIndex = 5
        OutputFileLabel.Text = "Target"
        ' 
        ' BrowseButton
        ' 
        BrowseButton.BackColor = Color.Transparent
        BrowseButton.BackgroundImage = My.Resources.Resources.Browse_Button1
        BrowseButton.BackgroundImageLayout = ImageLayout.Stretch
        BrowseButton.FlatStyle = FlatStyle.Popup
        BrowseButton.ForeColor = Color.Transparent
        BrowseButton.Location = New Point(10, 37)
        BrowseButton.Margin = New Padding(5)
        BrowseButton.Name = "BrowseButton"
        BrowseButton.Size = New Size(222, 76)
        BrowseButton.TabIndex = 0
        BrowseButton.UseVisualStyleBackColor = False
        ' 
        ' inputFileTextBox
        ' 
        inputFileTextBox.AutoSize = True
        inputFileTextBox.BackColor = Color.Transparent
        inputFileTextBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Underline)
        inputFileTextBox.ForeColor = Color.Firebrick
        inputFileTextBox.Location = New Point(238, 37)
        inputFileTextBox.Margin = New Padding(5, 0, 5, 0)
        inputFileTextBox.Name = "inputFileTextBox"
        inputFileTextBox.Size = New Size(62, 21)
        inputFileTextBox.TabIndex = 7
        inputFileTextBox.Text = "Source"
        ' 
        ' ProgressBar
        ' 
        ProgressBar.ForeColor = SystemColors.HotTrack
        ProgressBar.Location = New Point(241, 63)
        ProgressBar.Margin = New Padding(5)
        ProgressBar.Name = "ProgressBar"
        ProgressBar.Size = New Size(459, 80)
        ProgressBar.Step = 1
        ProgressBar.Style = ProgressBarStyle.Continuous
        ProgressBar.TabIndex = 3
        ' 
        ' CloseButton
        ' 
        CloseButton.AutoSize = True
        CloseButton.BackColor = Color.Transparent
        CloseButton.BackgroundImage = My.Resources.Resources.Close_Button
        CloseButton.BackgroundImageLayout = ImageLayout.Stretch
        CloseButton.FlatStyle = FlatStyle.Popup
        CloseButton.ForeColor = Color.Transparent
        CloseButton.Location = New Point(481, 223)
        CloseButton.Margin = New Padding(5)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(219, 174)
        CloseButton.TabIndex = 2
        CloseButton.UseVisualStyleBackColor = False
        ' 
        ' ExtractButton
        ' 
        ExtractButton.BackColor = Color.Transparent
        ExtractButton.BackgroundImage = My.Resources.Resources.Extract_Button
        ExtractButton.BackgroundImageLayout = ImageLayout.Stretch
        ExtractButton.FlatStyle = FlatStyle.Popup
        ExtractButton.ForeColor = Color.Transparent
        ExtractButton.Location = New Point(10, 123)
        ExtractButton.Margin = New Padding(5)
        ExtractButton.Name = "ExtractButton"
        ExtractButton.Size = New Size(222, 90)
        ExtractButton.TabIndex = 1
        ExtractButton.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.AutoSize = True
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(ExtractButton)
        GroupBox1.Controls.Add(CloseButton)
        GroupBox1.Controls.Add(ProgressBar)
        GroupBox1.Controls.Add(inputFileTextBox)
        GroupBox1.Controls.Add(BrowseButton)
        GroupBox1.Controls.Add(OutputFileLabel)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.FlatStyle = FlatStyle.Popup
        GroupBox1.ForeColor = Color.Transparent
        GroupBox1.Location = New Point(6, 2)
        GroupBox1.Margin = New Padding(5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(5)
        GroupBox1.Size = New Size(710, 439)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.Inherit
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackgroundImage = My.Resources.Resources.mBoy__to_mGBA_Cheat_Converter_Background
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(722, 444)
        ControlBox = False
        Controls.Add(GroupBox1)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5)
        Name = "Form1"
        Text = "mBoy! to mGBA Cheat File converter"
        TransparencyKey = SystemColors.Control
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OutputFileLabel As Label
    Friend WithEvents BrowseButton As Button
    Friend WithEvents inputFileTextBox As Label
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents CloseButton As Button
    Friend WithEvents ExtractButton As Button
    Friend WithEvents GroupBox1 As GroupBox

End Class
