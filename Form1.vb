Imports System.IO
Imports System.Text
Imports System.Xml

Public Class Form1
    ' Displays file dialog and updates input/output file paths
    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        Dim inputFile As String = ShowFileDialog("Select Cheat File", "Cheat Files (*.CHT)|*.CHT")
        If Not String.IsNullOrEmpty(inputFile) Then
            inputFileTextBox.Text = inputFile
            OutputFileLabel.Text = Path.ChangeExtension(inputFile, ".cheats")
        End If
    End Sub

    ' Handles the extraction process
    Private Sub ExtractButton_Click(sender As Object, e As EventArgs) Handles ExtractButton.Click
        ProgressBar.Value = 0
        Dim inputFile As String = inputFileTextBox.Text
        Dim outputFile As String = ShowFileDialog("Save Extracted Code", "Cheat Files (*.cheats)|*.cheats", False)

        If String.IsNullOrEmpty(outputFile) Then
            ShowMessage("Please choose a file to save the extracted code.", "Save Location Required")
            Exit Sub
        End If

        Try
            Dim xmlDoc As XmlDocument = LoadXmlDocument(inputFile)
            Dim cheatNodes As XmlNodeList = xmlDoc.SelectNodes("//cheat")
            Dim extractedContent As String = ExtractCheats(cheatNodes)
            File.WriteAllText(outputFile, extractedContent)
            ShowMessage("Data extracted successfully to " & outputFile, "Extraction Complete")
        Catch ex As Exception
            ShowMessage("Error extracting data: " & ex.Message, "Extraction Error", vbExclamation)
        End Try

        ProgressBar.Value = 100
    End Sub

    ' Closes the application
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
        End
    End Sub

    ' Opens the website in the default browser
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("https://hiroscheatfileconverter.net/")
    End Sub

    ' Shows a file dialog and returns the selected file path
    Private Function ShowFileDialog(title As String, filter As String, Optional isOpenDialog As Boolean = True) As String
        Dim dialog As FileDialog
        If isOpenDialog Then
            dialog = New OpenFileDialog()
        Else
            dialog = New SaveFileDialog()
        End If
        dialog.Title = title
        dialog.Filter = filter
        If dialog.ShowDialog() = DialogResult.OK Then
            Return dialog.FileName
        End If
        Return String.Empty
    End Function

    ' Loads an XML document from a file
    Private Function LoadXmlDocument(filePath As String) As XmlDocument
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(filePath)
        Return xmlDoc
    End Function

    ' Extracts cheat data from XML nodes
    Private Function ExtractCheats(cheatNodes As XmlNodeList) As String
        Dim outputString As New StringBuilder()
        Dim totalCheats As Integer = cheatNodes.Count

        For i As Integer = 0 To totalCheats - 1
            Dim cheatElement As XmlElement = cheatNodes(i)
            Dim name As String = cheatElement.GetAttribute("name")
            Dim codeBlock As String = ExtractCheatCode(cheatElement)

            outputString.AppendLine("!disabled")
            outputString.AppendLine("#" & name)
            outputString.AppendLine(codeBlock)

            ProgressBar.Value = ((i + 1) / totalCheats) * 100
        Next

        Return outputString.ToString()
    End Function

    ' Extracts code from a single cheat element
    Private Function ExtractCheatCode(cheatElement As XmlElement) As String
        Dim codeBlock As New StringBuilder()
        For Each childNode In cheatElement.ChildNodes
            If childNode.NodeType = XmlNodeType.Element Then
                codeBlock.AppendLine(childNode.InnerText)
            ElseIf childNode.NodeType = XmlNodeType.Text Then
                Dim textContent As String = childNode.InnerText
                codeBlock.AppendLine(textContent.Trim(""""c))
            End If
        Next
        Return codeBlock.ToString()
    End Function

    ' Displays a message box
    Private Sub ShowMessage(message As String, title As String, Optional style As MsgBoxStyle = vbInformation)
        MsgBox(message, style, title)
    End Sub
End Class
