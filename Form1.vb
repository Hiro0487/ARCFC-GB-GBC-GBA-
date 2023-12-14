Imports System.IO
Imports System.Text
Imports System.Xml

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Browse button click event
    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        Dim inputFileDialog As New OpenFileDialog With {
            .Title = "Select Cheat File",
            .Filter = "Cheat Files (*.CHT)|*.CHT"
        }
        If inputFileDialog.ShowDialog = DialogResult.OK Then
            inputFileTextBox.Text = inputFileDialog.FileName
            OutputFileLabel.Text = Path.ChangeExtension(inputFileDialog.FileName, ".cheats")
        End If
    End Sub

    ' Extract button click event
    Private Sub ExtractButton_Click(sender As Object, e As EventArgs) Handles ExtractButton.Click
        ProgressBar.Value = 0 ' Set progress bar to 0

        Dim inputFile As String = inputFileTextBox.Text
        Dim outputFile As String

        Dim saveFileDialog As New SaveFileDialog With {
            .Title = "Save Extracted Code",
            .Filter = "Cheat Files (*.cheats)|*.cheats"
        }
        If saveFileDialog.ShowDialog = DialogResult.OK Then
            outputFile = saveFileDialog.FileName
        Else
            MsgBox("Please choose a file to save the extracted code.", vbInformation, "Save Location Required")
            Exit Sub
        End If

        Try
            Dim xmlDoc As New XmlDocument
            xmlDoc.Load(inputFile)
            Dim outputString As New StringBuilder
            Dim cheatCount = xmlDoc.SelectNodes("//cheat").Count

            For i As Integer = 1 To cheatCount
                Dim cheatElement As XmlElement = xmlDoc.SelectNodes("//cheat")(i - 1)
                Dim name As String = cheatElement.GetAttribute("name")
                Dim codeBlock As New StringWriter

                ProgressBar.Value = (i / cheatCount) * 100

                For Each childNode In cheatElement.ChildNodes
                    If childNode.NodeType = XmlNodeType.Element Then
                        codeBlock.Write(childNode.InnerText & Environment.NewLine)
                    ElseIf childNode.NodeType = XmlNodeType.Text Then
                        Dim textContent As String = childNode.InnerText
                        codeBlock.Write(Mid(textContent, 2, textContent.Length - 2) & Environment.NewLine) ' Extract excluding tags
                    End If
                Next

                Dim codeString As String = codeBlock.ToString()

                outputString.AppendLine("!disabled")
                outputString.AppendLine("#" & name)
                outputString.AppendLine(codeString)
                'outputString.AppendLine()
            Next i

            Dim outputStreamWriter As New StreamWriter(outputFile)
            outputStreamWriter.Write(outputString.ToString)
            outputStreamWriter.Close()

            MsgBox("Data extracted successfully to " & outputFile, vbInformation, "Extraction Complete")
        Catch ex As Exception
            MsgBox("Error extracting data: " & ex.Message, vbExclamation, "Extraction Error")
        End Try

        ProgressBar.Value = 100 ' Set progress bar to 0 (optional)
    End Sub




    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
        End

    End Sub
End Class