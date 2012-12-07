Imports Microsoft.Win32

Public Class NewTaskForm

    Private Sub KryptonButton1_Click(sender As System.Object, e As System.EventArgs)
        MsgBox("wtf")
    End Sub


    Private Sub exeBrowseButton_Click(sender As System.Object, e As System.EventArgs) Handles chooseFileBrowseButton.Click
        OpenFileDialog.ShowDialog()

    End Sub

    Private Sub OpenFileDialog_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog.FileOk
        chooseFileTextBox.Text = OpenFileDialog.FileName

    End Sub

    Private Sub ExecutableCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles ExecutableCheckButton.Click

        chooseFilePanel.Enabled = True
        chooseFileLabel.Text = "Please choose your .exe file"
        chooseFileTextBox.Text = ""

        OpenFileDialog.Filter = "Executable Files(*.exe)|*.exe"

        If chooseFileTextBox.Text = "" Then
            chooseFileOkButton.Enabled = False

        End If

        'shows the directional blue arrows
        ArrowLabel1.Visible = False
        ArrowLabel2.Visible = True


    End Sub

    Private Sub MultimediaCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles MultimediaCheckButton.Click

        chooseFilePanel.Enabled = True
        chooseFileLabel.Text = "Please choose your multimedia file"
        chooseFileTextBox.Text = ""

        OpenFileDialog.Filter = "Audio Files(*.mp3, *.wav, *.wma, *.flac, *.ogg, *.oga, *.mpa, *.mid, *.m4a, *.m3u, *.aif, *.iff)" _
                              + "|*.mp3;*.wav;*.wma,*.flac;*.ogg;*.oga;*.mpa;*.mid;*.m4a;*.m3u;*.aif;*.iff|" _
                              + "Video Files(*.wmv, *.avi, *.mp4, *.mov, *.mkv, *.flv, *.ogg, *.ogv, *.3gp, *.3g2, *.swf, *.rm, *.vob, *.asf, *.asx)" _
                              + "|*.wmv;*.avi;*.mp4;*.mov;*.mkv;*.flv;*.ogg;*.ogv;*.3gp;*.3g2;*.swf;*.rm;*.vob;*.asf;*.asx"

        If chooseFileTextBox.Text = "" Then
            chooseFileOkButton.Enabled = False

        End If

        'shows the directional blue arrows
        ArrowLabel1.Visible = False
        ArrowLabel2.Visible = True

    End Sub

    Private Sub chooseFileTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles chooseFileTextBox.TextChanged
        chooseFileOkButton.Enabled = True

    End Sub

    Private Sub chooseFileOkButton_Click(sender As System.Object, e As System.EventArgs) Handles chooseFileOkButton.Click

        'disables kind of task panel
        KindOfTaskPanel.Enabled = False

        'disables choose file panel
        chooseFilePanel.Enabled = False

        'Shows Reset Button
        resetChooseFileButton.Visible = True

        'shows the directional blue arrows
        ArrowLabel1.Visible = False
        ArrowLabel2.Visible = False
        ArrowLabel3.Visible = True

        'enables date and time picker panel
        DateTimePanel.Enabled = True

    End Sub

    Private Sub resetChooseFileButton_Click(sender As System.Object, e As System.EventArgs) Handles resetChooseFileButton.Click
        'enables KindOfTask Panel
        KindOfTaskPanel.Enabled = True

        'Enables choosFile Panel
        chooseFilePanel.Enabled = True

        'handles all directional blue arrows
        ArrowLabel1.Visible = True
        ArrowLabel2.Visible = False
        ArrowLabel3.Visible = False
        ArrowLabel4.Visible = False

        'handles all reset buttons
        resetDateTimeButton.Visible = False

        'handles all panels
        DateTimePanel.Enabled = False
        TypeOfTaskPanel.Enabled = False


        'Hides itself
        resetChooseFileButton.Visible = False
    End Sub

    Private Sub OtherCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles OtherCheckButton.Click
        chooseFilePanel.Enabled = True
        chooseFileTextBox.Text = ""

        OpenFileDialog.Filter = "All Files(*.*)|*.*"

        If chooseFileTextBox.Text = "" Then
            chooseFileOkButton.Enabled = False

        End If

        'shows the directional blue arrows
        ArrowLabel1.Visible = False
        ArrowLabel2.Visible = True

    End Sub

    Private Sub ReminderCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles ReminderCheckButton.Click
        MsgBox("Does nothing yet")
    End Sub

    Private Sub OnceCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles OnceCheckButton.Click

        RecurrencePanel.Visible = False

    End Sub

    Private Sub DailyCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles DailyCheckButton.Click
        'handles directional blue arrows
        ArrowLabel4.Visible = False
        ArrowLabel5.Visible = True


        'Shows Recurrence Panel
        RecurrencePanel.Visible = True

        Label2.Text = "days"

        'enables ok button
        typeOfTaskOkButton.Enabled = True

        'handles things that other Types have enabled
        WeekdaysLabel.Visible = False
        WeekdaysDropDownButton.Visible = False
        MonthDaysLabel.Visible = False
        MonthDaysDropDownButton.Visible = False
        MonthsLabel.Visible = False
        MonthsDropDownButton.Visible = False




    End Sub

    Private Sub WeeklyCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles WeeklyCheckButton.Click
        'handles directional blue arrows
        ArrowLabel4.Visible = False
        ArrowLabel5.Visible = True


        'Shows Recurrence Panel
        RecurrencePanel.Visible = True

        'changes Label2 days->weeks
        Label2.Text = "weeks"

        'handles things that other Types have enabled
        MonthDaysLabel.Visible = False
        MonthDaysDropDownButton.Visible = False
        MonthsLabel.Visible = False
        MonthsDropDownButton.Visible = False

        'shows Weekdays Label
        WeekdaysLabel.Visible = True

        'shows WeekdaysDropDown Button
        WeekdaysDropDownButton.Visible = True

        'enables the OK button
        typeOfTaskOkButton.Enabled = True


    End Sub

    Private Sub MonthlyCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles MonthlyCheckButton.Click
        'handles directional blue arrows
        ArrowLabel4.Visible = False
        ArrowLabel5.Visible = True


        'Shows Recurrence Panel
        RecurrencePanel.Visible = True

        'enables ok button
        typeOfTaskOkButton.Enabled = True

        'changes Label2 days->months
        Label2.Text = "months"

        'handles things that other Types have enabled
        WeekdaysLabel.Visible = False
        WeekdaysDropDownButton.Visible = False
        MonthsLabel.Visible = False
        MonthsDropDownButton.Visible = False

        'shows MonthDay sLabel
        MonthDaysLabel.Visible = True

        'shows MonthDays DropDown Button
        MonthDaysDropDownButton.Visible = True

        'enables the OK button
        typeOfTaskOkButton.Enabled = True



    End Sub

    Private Sub YearlyCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles YearlyCheckButton.Click

        'handles directional blue arrows
        ArrowLabel4.Visible = False
        ArrowLabel5.Visible = True

        'Shows Recurrence Panel
        RecurrencePanel.Visible = True

        'enables ok button
        typeOfTaskOkButton.Enabled = True

        'changes Label2 days->years
        Label2.Text = "years"

        'handles things that other Types have enabled
        WeekdaysLabel.Visible = False
        WeekdaysDropDownButton.Visible = False
        MonthDaysLabel.Visible = False
        MonthDaysDropDownButton.Visible = False

        'shows Months Label
        MonthsLabel.Visible = True
        'shows Months DropDown Button
        MonthsDropDownButton.Visible = True


    End Sub


    Private Sub chooseDateTimeOkButton_Click(sender As System.Object, e As System.EventArgs) Handles chooseDateTimeOkButton.Click

        'disables DateTimePanel
        DateTimePanel.Enabled = False


        'Shows Reset Buttton
        resetDateTimeButton.Visible = True

        'shows the directional blue arrows
        ArrowLabel3.Visible = False
        ArrowLabel4.Visible = True

        'enables TypeOFTask Panel
        TypeOfTaskPanel.Enabled = True


    End Sub

    Private Sub resetDateTimeButton_Click(sender As System.Object, e As System.EventArgs) Handles resetDateTimeButton.Click

        'enables DateTime Panel
        DateTimePanel.Enabled = True

        'handles directional blue arrows
        ArrowLabel1.Visible = False
        ArrowLabel2.Visible = False
        ArrowLabel3.Visible = True
        ArrowLabel4.Visible = False

        'hides itself
        resetDateTimeButton.Visible = False


    End Sub


End Class
