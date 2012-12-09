Imports Microsoft.Win32

Public Class NewTaskForm

    Private Sub chooseFileBrowseButton_Click(sender As System.Object, e As System.EventArgs) Handles chooseFileBrowseButton.Click

        OpenFileDialog.ShowDialog()

    End Sub

    Private Sub OpenFileDialog_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog.FileOk

        chooseFileTextBox.Text = OpenFileDialog.FileName

    End Sub


#Region "kind of task(exe, multimedia, etc) checkbuttons"

    Private Sub ExecutableCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles ExecutableCheckButton.Click

        'makes sure the textbox is empy because another checkbutton might had filled it
        chooseFileTextBox.Text = ""

        'handles ChooseFile Panel (visibility and label text)
        HandleChooseFilePanel(True, ".exe ")

        'sets the kind of files the OpenDialog is allowed to open
        OpenFileDialog.Filter = "Executable Files(*.exe)|*.exe"

        'handles the arrow labels
        HandleArrowLabels(False, True, False, False, False)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, True, False, False, False)

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

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, True, False, False, False)

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

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, True, False, False, False)

    End Sub

    Private Sub ReminderCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles ReminderCheckButton.Click
        MsgBox("Does nothing yet")
    End Sub

#End Region

    Private Sub chooseFileTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles chooseFileTextBox.TextChanged

        chooseFileOkButton.Enabled = True

    End Sub

#Region "OK Buttons"
    Private Sub chooseFileOkButton_Click(sender As System.Object, e As System.EventArgs) Handles chooseFileOkButton.Click

        'handles all panels' visibility
        HandleAllPanels(False, False, True, False, False, False)

        'handles the arrow labels
        HandleArrowLabels(False, False, True, False, False)

        'handles all Reset buttons' visibility
        HandleResetButtons(True, False, False)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, True, False, False)

    End Sub

    Private Sub chooseDateTimeOkButton_Click(sender As System.Object, e As System.EventArgs) Handles chooseDateTimeOkButton.Click

        'handles all panels' visibility
        HandleAllPanels(False, False, False, True, True, False)

        'handles the arrow labels
        HandleArrowLabels(False, False, False, True, False)

        'handles MoreOptions & SaveTask buttons' visibility
        HandleMoreAndSaveButtons(True, False)

        'handles all Reset buttons' visibility
        HandleResetButtons(True, True, False)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, True, False)

    End Sub

    Private Sub typeOfTaskOkButton_Click(sender As System.Object, e As System.EventArgs) Handles typeOfTaskOkButton.Click

        'handles all panels' visibility
        HandleAllPanels(False, False, False, False, False, False)

        ''ArrowLabel5.Visible = False
        HandleArrowLabels(False, False, False, False, False)

        'handles MoreOptions & SaveTask buttons' visibility
        HandleMoreAndSaveButtons(False, True)

        'handles all Reset buttons' visibility
        HandleResetButtons(True, True, True)

    End Sub

    Private Sub OnceOKButton_Click(sender As System.Object, e As System.EventArgs) Handles OnceOKButton.Click

        'handles all panels' visibility
        HandleAllPanels(False, False, False, False, False, False)

        ''ArrowLabel4.Visible = False
        HandleArrowLabels(False, False, False, False, False)

        'handles MoreOptions & SaveTask buttons' visibility
        HandleMoreAndSaveButtons(False, True)

        'handles all Reset buttons' visibility
        HandleResetButtons(True, True, True)

    End Sub
#End Region

#Region "Reset Buttons"
    Private Sub resetChooseFileButton_Click(sender As System.Object, e As System.EventArgs) Handles resetChooseFileButton.Click

        'handles all panels' visibility
        HandleAllPanels(True, True, False, False, False, False)

        'handles the arrow labels
        HandleArrowLabels(True, False, False, False, False)

        'handles MoreOptions & SaveTask buttons' visibility
        HandleMoreAndSaveButtons(False, False)

        'handles all Reset buttons' visibility
        HandleResetButtons(False, False, False)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(True, False, False, False, False)

    End Sub

    Private Sub resetDateTimeButton_Click(sender As System.Object, e As System.EventArgs) Handles resetDateTimeButton.Click

        'handles all panels' visibility
        HandleAllPanels(False, False, True, False, False, False)

        'handles the arrow labels
        HandleArrowLabels(False, False, True, False, False)

        'handles MoreOptions & SaveTask buttons' visibility
        HandleMoreAndSaveButtons(False, False)

        'handles all Reset buttons' visibility
        HandleResetButtons(True, False, False)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, True, False, False)

    End Sub

    Private Sub resetTypeOfTaskButton_Click(sender As System.Object, e As System.EventArgs) Handles resetTypeOfTaskButton.Click

        'handles all panels' visibility
        HandleAllPanels(False, False, False, True, True, True)

        ''ArrowLabel4.Visible = True
        HandleArrowLabels(False, False, False, True, False)

        'handles MoreOptions & SaveTask buttons' visibility
        HandleMoreAndSaveButtons(True, False)

        'handles all Reset buttons' visibility
        HandleResetButtons(True, True, False)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, True, False)

    End Sub

#End Region

#Region "type of task(once, daily, weekly, etc) checkbuttons"

    Private Sub OnceCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles OnceCheckButton.Click

        RecurrencePanel.Visible = False

        ''ArrowLabel5.Visible = False
        HandleArrowLabels(False, False, False, False, False)

        'handles MoreOptions & SaveTask buttons' visibility
        HandleMoreAndSaveButtons(True, False)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, False, False)

        With OnceOKButtonPanel
            .Visible = True
            .Enabled = True
        End With

    End Sub

    Private Sub DailyCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles DailyCheckButton.Click

        'handles the arrow labels
        HandleArrowLabels(False, False, False, False, True)

        'Shows Recurrence Panel
        RecurrencePanel.Enabled = True 'because it might have been disabled from a Reset Button
        RecurrencePanel.Visible = True
        OnceOKButtonPanel.Visible = False 'in case it has been enabled by Once button

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

        'handles MoreOptions & SaveTask buttons' visibility
        HandleMoreAndSaveButtons(True, False)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, False, True)

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

        'handles MoreOptions & SaveTask buttons' visibility
        HandleMoreAndSaveButtons(True, False)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, False, True)

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

        'handles MoreOptions & SaveTask buttons' visibility
        HandleMoreAndSaveButtons(True, False)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, False, True)

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

        'handles MoreOptions & SaveTask buttons' visibility
        HandleMoreAndSaveButtons(True, False)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, False, True)

    End Sub
#End Region


    Private Sub MoreOptionsButton_Click(sender As System.Object, e As System.EventArgs) Handles MoreOptionsButton.Click

        MoreOptionsForm.ShowDialog()

    End Sub

#Region "My handle-methods"
    'handles the blue directional ArrowLabels visibility
    Public Sub HandleArrowLabels(ByVal label1 As Boolean, ByVal label2 As Boolean, _
                                    ByVal label3 As Boolean, ByVal label4 As Boolean, label5 As Boolean)
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

    'handles all panels' visibility
    Public Sub HandleAllPanels(ByVal panel1 As Boolean, ByVal panel2 As Boolean, ByVal panel3 As Boolean, _
                                ByVal panel4 As Boolean, ByVal panel5 As Boolean, ByVal panel6 As Boolean)

        KindOfTaskPanel.Enabled = panel1
        chooseFilePanel.Enabled = panel2
        DateTimePanel.Enabled = panel3
        TypeOfTaskPanel.Enabled = panel4
        RecurrencePanel.Enabled = panel5
        OnceOKButtonPanel.Enabled = panel6

    End Sub

    'handles MoreOptions & SaveTask buttons' visibility
    Public Sub HandleMoreAndSaveButtons(ByVal more As Boolean, ByVal save As Boolean)
        MoreOptionsButton.Enabled = more
        SaveTaskButton.Enabled = save
    End Sub

    'handles all Reset buttons' visibility
    Public Sub HandleResetButtons(ByVal first As Boolean, ByVal second As Boolean, ByVal third As Boolean)

        resetChooseFileButton.Visible = first
        resetDateTimeButton.Visible = second
        resetTypeOfTaskButton.Visible = third

    End Sub

    'handles all Rectangle Shapes
    Public Sub HandleRectangles(ByVal rectangle1 As Boolean, ByVal rectangle2 As Boolean, _
                                ByVal rectangle3 As Boolean, ByVal rectangle4 As Boolean, ByVal rectangle5 As Boolean)

        RectangleShape1.Visible = rectangle1
        RectangleShape2.Visible = rectangle2
        RectangleShape3.Visible = rectangle3
        RectangleShape4.Visible = rectangle4
        RectangleShape5.Visible = rectangle5

    End Sub

#End Region

    Private Sub chooseFilePanel_MouseEnter(sender As System.Object, e As System.EventArgs) Handles chooseFilePanel.MouseEnter
        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, True, False, False, False)

        'handles the arrow labels
        HandleArrowLabels(False, True, False, False, False)
    End Sub

    Private Sub RecurrencePanel_MouseEnter(sender As System.Object, e As System.EventArgs) Handles RecurrencePanel.MouseEnter
        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, False, True)

        'handles the arrow labels
        HandleArrowLabels(False, False, False, False, True)
    End Sub
End Class
