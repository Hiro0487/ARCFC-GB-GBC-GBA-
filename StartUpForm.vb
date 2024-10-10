Public Class StartUpForm
    Private toolTip As New ToolTip()

    Private Sub StartUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable Button2
        Button2.Enabled = False


        ' Set up the tooltip
        toolTip.AutoPopDelay = 5000
        toolTip.InitialDelay = 0
        toolTip.ReshowDelay = 0
        toolTip.ShowAlways = True

        ' Add tooltip to the disabled button
        SetupToolTipForButton(Button2, ("Unsupported Feature" & vbCrLf & "Will be available" & vbCrLf & "Eventually"))
    End Sub

    Private Sub SetupToolTipForButton(button As Button, message As String)
        ' Create a transparent panel that covers the button
        Dim panel As New Panel With {
            .Size = button.Size,
            .Location = button.Location,
            .BackColor = Color.Transparent,
            .Parent = button.Parent
        }
        panel.BringToFront()

        ' Set up tooltip for the panel
        toolTip.SetToolTip(panel, message)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Unsupported Feature" & vbCrLf & "Will be available" & vbCrLf & "Eventually")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class
