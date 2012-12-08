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



#Region "what kind of task -> checkbuttons"

    Private Sub ExecutableCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles ExecutableCheckButton.Click

        'makes sure the textbox is empy because another checkbutton might had filled it
        chooseFileTextBox.Text = ""

        'handles ChooseFile Panel (visibility and label text)
        HandleChooseFilePanel(True, ".exe ")

        'sets the kind of files the OpenDialog is allowed to open
        OpenFileDialog.Filter = "Executable Files(*.exe)|*.exe"

        'handles the arrow labels
        HandleArrowLabels(False, True, False, False, False)

    End Sub

    Private Sub MultimediaCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles MultimediaCheckButton.Click

        'makes sure the textbox is empy because another checkbutton might had filled it
        chooseFileTextBox.Text = ""

        'handles ChooseFile Panel (visibility and label text)
        HandleChooseFilePanel(True, "multimedia ")

        'sets the kind of files the OpenDialog is allowed to open
        OpenFileDialog.Filter = "Audio Files(*.mp3, *.wav, *.wma, *.flac, *.ogg, *.oga, *.mpa, *.mid, *.m4a, *.m3u, *.aif, *.iff)" _
                              + "|*.mp3;*.wav;*.wma,*.flac;*.ogg;*.oga;*.mpa;*.mid;*.m4a;*.m3u;*.aif;*.iff|" _
                              + "Video Files(*.wmv, *.avi, *.mp4, *.mov, *.mkv, *.flv, *.ogg, *.ogv, *.3gp, *.3g2, *.swf, *.rm, *.vob, *.asf, *.asx)" _
                              + "|*.wmv;*.avi;*.mp4;*.mov;*.mkv;*.flv;*.ogg;*.ogv;*.3gp;*.3g2;*.swf;*.rm;*.vob;*.asf;*.asx"

        'handles the arrow labels
        HandleArrowLabels(False, True, False, False, False)

    End Sub

    Private Sub OtherCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles OtherCheckButton.Click

        'makes sure the textbox is empy because another checkbutton might had filled it
        chooseFileTextBox.Text = ""

        'handles ChooseFile Panel (visibility and label text)
        HandleChooseFilePanel(True, " ")

        'sets the kind of files the OpenDialog is allowed to open
        OpenFileDialog.Filter = "All Files(*.*)|*.*"

        'handles the arrow labels
        HandleArrowLabels(False, True, False, False, False)

    End Sub

#End Region

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

        'handles the arrow labels
        HandleArrowLabels(False, False, True, False, False)

        'enables date and time picker panel
        DateTimePanel.Enabled = True

    End Sub

    Private Sub resetChooseFileButton_Click(sender As System.Object, e As System.EventArgs) Handles resetChooseFileButton.Click
        'enables KindOfTask Panel
        KindOfTaskPanel.Enabled = True

        'Enables choosFile Panel
        chooseFilePanel.Enabled = True

        'handles the arrow labels
        HandleArrowLabels(True, False, False, False, False)

        'handles all reset buttons
        resetDateTimeButton.Visible = False
        resetTypeOfTaskButton.Visible = False

        'handles all panels
        DateTimePanel.Enabled = False
        TypeOfTaskPanel.Enabled = False
        RecurrencePanel.Enabled = False
        OnceOKButtonPanel.Visible = False

        'handles MoreOptions and SaveTask buttons
        MoreOptionsButton.Enabled = False
        SaveTaskButton.Enabled = False

        'Hides itself
        resetChooseFileButton.Visible = False
    End Sub

    Private Sub ReminderCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles ReminderCheckButton.Click
        MsgBox("Does nothing yet")
    End Sub

    Private Sub OnceCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles OnceCheckButton.Click

        RecurrencePanel.Visible = False

        ArrowLabel5.Visible = False

        MoreOptionsButton.Enabled = True

        With OnceOKButtonPanel
            .Visible = True
            .Enabled = True

        End With

    End Sub

    Private Sub DailyCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles DailyCheckButton.Click

        'handles the arrow labels
        HandleArrowLabels(False, False, False, False, True)


        'Shows Recurrence Panel
        RecurrencePanel.Visible = True
        RecurrencePanel.Enabled = True 'because it might have been disabled from a Reset Button

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

        OnceOKButtonPanel.Visible = False 'in case it has been enabled by Once button

        SaveTaskButton.Enabled = False 'in case it has been enabled by Once button
        MoreOptionsButton.Enabled = True


    End Sub

    Private Sub WeeklyCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles WeeklyCheckButton.Click

        'handles the arrow labels
        HandleArrowLabels(False, False, False, False, True)


        'Shows Recurrence Panel
        RecurrencePanel.Visible = True
        RecurrencePanel.Enabled = True 'because it might have been disabled from a Reset Button

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

        OnceOKButtonPanel.Visible = False 'in case it has been enabled by Once button
        SaveTaskButton.Enabled = False 'in case it has been enabled by Once button
        MoreOptionsButton.Enabled = True

    End Sub

    Private Sub MonthlyCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles MonthlyCheckButton.Click

        'handles the arrow labels
        HandleArrowLabels(False, False, False, False, True)


        'Shows Recurrence Panel
        RecurrencePanel.Visible = True
        RecurrencePanel.Enabled = True 'because it might have been disabled from a Reset Button

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

        OnceOKButtonPanel.Visible = False 'in case it has been enabled by Once button
        SaveTaskButton.Enabled = False 'in case it has been enabled by Once button
        MoreOptionsButton.Enabled = True

    End Sub

    Private Sub YearlyCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles YearlyCheckButton.Click

        'handles the arrow labels
        HandleArrowLabels(False, False, False, False, True)

        'Shows Recurrence Panel
        RecurrencePanel.Visible = True
        RecurrencePanel.Enabled = True 'because it might have been disabled from a Reset Button

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

        OnceOKButtonPanel.Visible = False 'in case it has been enabled by Once button
        SaveTaskButton.Enabled = False 'in case it has been enabled by Once button
        MoreOptionsButton.Enabled = True

    End Sub

    Private Sub chooseDateTimeOkButton_Click(sender As System.Object, e As System.EventArgs) Handles chooseDateTimeOkButton.Click

        'disables DateTimePanel
        DateTimePanel.Enabled = False


        'Shows Reset Buttton
        resetDateTimeButton.Visible = True

        'handles the arrow labels
        HandleArrowLabels(False, False, False, True, False)

        'enables TypeOFTask Panel
        TypeOfTaskPanel.Enabled = True

        RecurrencePanel.Enabled = True 'because of Reset Buttons


    End Sub

    Private Sub resetDateTimeButton_Click(sender As System.Object, e As System.EventArgs) Handles resetDateTimeButton.Click

        'enables DateTime Panel
        DateTimePanel.Enabled = True

        'handles the arrow labels
        HandleArrowLabels(False, False, True, False, False)

        'handles panels
        TypeOfTaskPanel.Enabled = False
        RecurrencePanel.Enabled = False
        OnceOKButtonPanel.Visible = False

        'handles MoreOptions and SaveTask buttons
        MoreOptionsButton.Enabled = False
        SaveTaskButton.Enabled = False

        'hides itself
        resetDateTimeButton.Visible = False


    End Sub

    Private Sub resetTypeOfTaskButton_Click(sender As System.Object, e As System.EventArgs) Handles resetTypeOfTaskButton.Click

        TypeOfTaskPanel.Enabled = True
        RecurrencePanel.Enabled = True
        OnceOKButtonPanel.Enabled = True
        MoreOptionsButton.Enabled = True
        ArrowLabel4.Visible = True

        SaveTaskButton.Enabled = False

        'hidets itself
        resetTypeOfTaskButton.Visible = False

    End Sub

    Private Sub typeOfTaskOkButton_Click(sender As System.Object, e As System.EventArgs) Handles typeOfTaskOkButton.Click

        TypeOfTaskPanel.Enabled = False
        RecurrencePanel.Enabled = False

        MoreOptionsButton.Enabled = False

        SaveTaskButton.Enabled = True
        resetTypeOfTaskButton.Visible = True

        ArrowLabel5.Visible = False
    End Sub

    Private Sub OnceOKButton_Click(sender As System.Object, e As System.EventArgs) Handles OnceOKButton.Click
        TypeOfTaskPanel.Enabled = False
        RecurrencePanel.Enabled = False

        MoreOptionsButton.Enabled = False
        ArrowLabel4.Visible = False

        OnceOKButtonPanel.Enabled = False

        SaveTaskButton.Enabled = True
        resetTypeOfTaskButton.Visible = True
    End Sub

    Private Sub MoreOptionsButton_Click(sender As System.Object, e As System.EventArgs) Handles MoreOptionsButton.Click
        MoreOptionsForm.ShowDialog()

    End Sub

    'handles the blue directional ArrowLabels
    Public Sub HandleArrowLabels(ByVal label1 As Boolean, ByVal label2 As Boolean, ByVal label3 As Boolean, ByVal label4 As Boolean, label5 As Boolean)
        ArrowLabel1.Visible = label1
        ArrowLabel2.Visible = label2
        ArrowLabel3.Visible = label3
        ArrowLabel4.Visible = label4
        ArrowLabel5.Visible = label5
    End Sub

    'handles ChooseFile Panel (visibility and label text)
    Public Sub HandleChooseFilePanel(ByVal status As Boolean, ByVal label As String)

        'handles the panel's status
        chooseFilePanel.Enabled = status

        'handles the label's text
        chooseFileLabel.Text = "Please choose your " + label + "file"

        'disables OK button if the user didn't choose a program
        If chooseFileTextBox.Text = "" Then
            chooseFileOkButton.Enabled = False
        End If

    End Sub
End Class
