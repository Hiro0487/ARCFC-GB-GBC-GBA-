Imports System.IO
Imports System.Text
Imports System.Xml

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Browse button click event
    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        Dim inputFileDialog As New OpenFileDialog
        inputFileDialog.Filter = "Cheat files (*.cht)|*.cht"
        If inputFileDialog.ShowDialog = DialogResult.OK Then
            inputFileTextBox.Text = inputFileDialog.FileName
            OutputFileLabel.Text = Path.ChangeExtension(inputFileDialog.FileName, ".cheats")
        End If
    End Sub

    ' Extract button click event
    Private Sub ExtractButton_Click(sender As Object, e As EventArgs) Handles ExtractButton.Click
        ProgressBar.Value = 0 ' Set progress bar to 0 (optional)
        Dim inputFile As String = inputFileTextBox.Text
        Dim outputFile As String = OutputFileLabel.Text

        Try
            Dim xmlDoc As New XmlDocument
            xmlDoc.Load(inputFile)
            Dim outputString As New StringBuilder
            Dim cheatCount = xmlDoc.SelectNodes("//cheat").Count

            For i As Integer = 1 To cheatCount
                Dim cheatElement As XmlElement = xmlDoc.SelectNodes("//cheat")(i - 1)
                Dim name As String = cheatElement.GetAttribute("name")
                Dim code As String = cheatElement.InnerText

                ' Prepend "#" before "name" data (modified line)
                outputString.AppendLine("#" & name)
                outputString.AppendLine(code)
                outputString.AppendLine()
            Next


            Dim outputStreamWriter As New StreamWriter(outputFile)
            outputStreamWriter.Write(outputString.ToString)
            outputStreamWriter.Close()

            MessageBox.Show("Data extracted successfully to " & outputFile)
            ProgressBar.Value = 100 ' Set progress bar to 100 (optional)
        Catch ex As Exception
            MessageBox.Show("Error extracting data: " & ex.Message)
        End Try
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
        End

    End Sub
End Class