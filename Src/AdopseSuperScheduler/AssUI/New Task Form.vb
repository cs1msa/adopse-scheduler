Imports Microsoft.Win32
Imports AssLogic

Public Class NewTaskForm

    Dim m_master_control As ALMasterControl

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

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, False, False)

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

        'handles all the arrow labels
        HandleArrowLabels(False, False, False, False, False)

        'handles MoreOptions & SaveTask buttons' visibility
        HandleMoreAndSaveButtons(True, False)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, False, False)

        'handles RecurrencePanel and OnceOkButtonPanell
        HandleRecurrence_and_OnceOkButton_Panels(False, True, True, True)

    End Sub

    Private Sub DailyCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles DailyCheckButton.Click

        'handles the arrow labels
        HandleArrowLabels(False, False, False, False, True)

        'handles MoreOptions & SaveTask buttons' visibility
        HandleMoreAndSaveButtons(True, False)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, False, True)

        'handles RecurrencePanel and OnceOkButtonPanell
        HandleRecurrence_and_OnceOkButton_Panels(True, True, False, True)

        'handles RecurrencePanel's content
        HandleRecPanelContent(False, False, False, False, False, False)

        Label2.Text = "days"

        typeOfTaskOkButton.Enabled = True 'enables ok button

    End Sub

    Private Sub WeeklyCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles WeeklyCheckButton.Click

        'handles the arrow labels
        HandleArrowLabels(False, False, False, False, True)

        'handles MoreOptions & SaveTask buttons' visibility
        HandleMoreAndSaveButtons(True, False)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, False, True)

        'handles RecurrencePanel and OnceOkButtonPanell
        HandleRecurrence_and_OnceOkButton_Panels(True, True, False, True)

        'handles RecurrencePanel's content
        HandleRecPanelContent(True, True, False, False, False, False)

        Label2.Text = "weeks"

        typeOfTaskOkButton.Enabled = True 'enables the OK button

    End Sub

    Private Sub MonthlyCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles MonthlyCheckButton.Click

        'handles the arrow labels
        HandleArrowLabels(False, False, False, False, True)

        'handles MoreOptions & SaveTask buttons' visibility
        HandleMoreAndSaveButtons(True, False)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, False, True)

        'handles RecurrencePanel and OnceOkButtonPanell
        HandleRecurrence_and_OnceOkButton_Panels(True, True, False, True)

        'enables ok button
        typeOfTaskOkButton.Enabled = True

        'handles RecurrencePanel's content
        HandleRecPanelContent(False, False, True, True, False, False)

        Label2.Text = "months"

        typeOfTaskOkButton.Enabled = True 'enables the OK button

    End Sub

    Private Sub YearlyCheckButton_Click(sender As System.Object, e As System.EventArgs) Handles YearlyCheckButton.Click

        'handles the arrow labels
        HandleArrowLabels(False, False, False, False, True)

        'handles MoreOptions & SaveTask buttons' visibility
        HandleMoreAndSaveButtons(True, False)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, False, True)

        'handles RecurrencePanel and OnceOkButtonPanell
        HandleRecurrence_and_OnceOkButton_Panels(True, True, False, True)

        'handles RecurrencePanel's content
        HandleRecPanelContent(False, False, False, False, True, True)

        Label2.Text = "years"

        typeOfTaskOkButton.Enabled = True 'enables ok button

    End Sub
#End Region


    Private Sub MoreOptionsButton_Click(sender As System.Object, e As System.EventArgs) Handles MoreOptionsButton.Click

        MoreOptionsForm.ShowDialog()

    End Sub

#Region "My handle-methods"
    'handles the blue directional ArrowLabels visibility
    Private Sub HandleArrowLabels(ByVal label1 As Boolean, ByVal label2 As Boolean, _
                                    ByVal label3 As Boolean, ByVal label4 As Boolean, label5 As Boolean)
        ArrowLabel1.Visible = label1
        ArrowLabel2.Visible = label2
        ArrowLabel3.Visible = label3
        ArrowLabel4.Visible = label4
        ArrowLabel5.Visible = label5
    End Sub

    'handles ChooseFile Panel (visibility and label text)
    Private Sub HandleChooseFilePanel(ByVal status As Boolean, ByVal label As String)

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
    Private Sub HandleAllPanels(ByVal panel1 As Boolean, ByVal panel2 As Boolean, ByVal panel3 As Boolean, _
                                ByVal panel4 As Boolean, ByVal panel5 As Boolean, ByVal panel6 As Boolean)

        KindOfTaskPanel.Enabled = panel1
        chooseFilePanel.Enabled = panel2
        DateTimePanel.Enabled = panel3
        TypeOfTaskPanel.Enabled = panel4
        RecurrencePanel.Enabled = panel5
        OnceOKButtonPanel.Enabled = panel6

    End Sub

    'handles MoreOptions & SaveTask buttons' visibility
    Private Sub HandleMoreAndSaveButtons(ByVal more As Boolean, ByVal save As Boolean)
        MoreOptionsButton.Enabled = more
        SaveTaskButton.Enabled = save
    End Sub

    'handles all Reset buttons' visibility
    Private Sub HandleResetButtons(ByVal first As Boolean, ByVal second As Boolean, ByVal third As Boolean)

        resetChooseFileButton.Visible = first
        resetDateTimeButton.Visible = second
        resetTypeOfTaskButton.Visible = third

    End Sub

    'handles all Rectangle Shapes
    Private Sub HandleRectangles(ByVal rectangle1 As Boolean, ByVal rectangle2 As Boolean, _
                                ByVal rectangle3 As Boolean, ByVal rectangle4 As Boolean, ByVal rectangle5 As Boolean)

        RectangleShape1.Visible = rectangle1
        RectangleShape2.Visible = rectangle2
        RectangleShape3.Visible = rectangle3
        RectangleShape4.Visible = rectangle4
        RectangleShape5.Visible = rectangle5

    End Sub

    'handles RecurrencePanel and OnceOkButtonPanell
    Private Sub HandleRecurrence_and_OnceOkButton_Panels(ByVal RecVis As Boolean, ByVal RecEn As Boolean, _
                                                         ByVal OnceVis As Boolean, ByVal OnceEn As Boolean)
        RecurrencePanel.Visible = RecVis
        RecurrencePanel.Enabled = RecEn
        OnceOKButtonPanel.Visible = OnceVis
        OnceOKButtonPanel.Enabled = OnceEn

    End Sub

    'handles RecurrencePanel's content
    Private Sub HandleRecPanelContent(ByVal wkLbl As Boolean, ByVal wkDrpDnBtn As Boolean, _
                                      ByVal mnthDLbl As Boolean, ByVal mnthDDrpDnBtn As Boolean, _
                                      ByVal mnthLbl As Boolean, ByVal mnthDrpDnBtn As Boolean)

        WeekdaysLabel.Visible = wkLbl
        WeekdaysDropDownButton.Visible = wkDrpDnBtn
        MonthDaysLabel.Visible = mnthDLbl
        MonthDaysDropDownButton.Visible = mnthDDrpDnBtn
        MonthsLabel.Visible = mnthLbl
        MonthsDropDownButton.Visible = mnthDrpDnBtn

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


    Public Sub SetMasterControl(ByRef a_master_control As ALMasterControl)
        m_master_control = a_master_control
    End Sub

    Public Sub SaveTaskButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveTaskButton.Click
        '  m_master_control.AddTask(NewTaskForm.Text, DatePicker.date, )
        '' incomplete for now, paw gia ypno den thn paleuw
    End Sub


End Class
