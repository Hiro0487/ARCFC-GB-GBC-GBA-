Imports System.IO
Imports System.Text

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim openFileDialog As New OpenFileDialog()
            With openFileDialog
                .Title = "Select Cheat File"
                .Filter = "Cheat Files (*.DCT)|*.DCT"
                .InitialDirectory = "E:\Emulator's\DS\DeSmuMe\Cheats" ' Adjust path as needed
            End With

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = openFileDialog.FileName
                If File.Exists(filePath) Then
                    Dim chtFileContent As String = File.ReadAllText(filePath)

                    ' Parse and modify cheat information
                    Dim xmlDoc As New XDocument(chtFileContent)
                    Dim modifiedCheats = From cheat1 In xmlDoc.Descendants("cheat")
                                         Select New With
                                             {
                                                 .Name = "#" & cheat1.Attribute("name").Value,
                                                 .Code = cheat1.Descendants("code").FirstOrDefault().Value("")
                                             }
                    Dim outputStream As New StreamWriter("modified_cheats.cheats")

                    For Each modifiedCheat In modifiedCheats
                        Dim codeLines As New StringBuilder()

                        For Each line As String In modifiedCheat.Code.Split(Environment.NewLine)
                            codeLines.Append(line & vbCrLf & vbCrLf)
                        Next

                        codeLines.Append(vbCrLf)
                        outputStream.Write(modifiedCheat.Name & codeLines)
                    Next

                    outputStream.Close()


                    MsgBox("Successfully converted cheat file to modified_cheats.cheats!")
                Else
                    MsgBox("File not found!")
                End If
            Else
                MsgBox("No file selected.")
            End If
        Catch ex As Exception
            MsgBox("Error processing the cht file: " & ex.Message)
            ' Consider logging error details for further investigation
        Finally
            ' Close any open resources if needed
        End Try


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


End Class