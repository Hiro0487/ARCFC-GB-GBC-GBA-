Public NotInheritable Class SplashScreen1
    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).
    ' Constants for desired behavior (adjust as needed)
    ' Constants for desired behavior (adjust as needed)
    Private Const DesiredTotalTimeInSeconds As Double = 5 ' Change this to your desired total loading time in seconds
    Private Const TimerIntervalMilliseconds As Integer = 100 ' Change this to your desired timer interval in milliseconds
    Private Const ProgressTolerance As Integer = 2 ' Tolerance value for progress bar comparison (adjust as needed)

    ' Internal variables
    Private startTime As DateTime

    Private Sub SplashScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Start timer and record start time
        Timer1.Interval = TimerIntervalMilliseconds
        Timer1.Start()
        startTime = DateTime.Now
        ' Set up the dialog text at runtime according to the application's assembly information.
        ' ... (same code as your original)
        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Calculate elapsed time in seconds
        Dim elapsedTime As Double = (DateTime.Now - startTime).TotalSeconds

        ' Update progress bar based on elapsed time and chosen maximum value
        ProgressBar1.Value = Math.Min(ProgressBar1.Maximum, CInt(elapsedTime * ProgressBar1.Maximum / DesiredTotalTimeInSeconds))

        ' Update label with estimated remaining time (optional)
        ' RemainingTimeLabel.Text = String.Format("Estimated time remaining: {0:0} seconds", DesiredTotalTimeInSeconds - elapsedTime)

        ' Check if loading is complete and close splash screen (replace with your loading logic)
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            Timer1.Stop()
            Me.Close()
            ' Show main form here
        End If
    End Sub

    Private Sub MainLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles MainLayoutPanel.Paint

    End Sub
End Class
