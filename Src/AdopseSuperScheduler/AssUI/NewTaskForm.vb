Imports Microsoft.Win32
Imports AssLogic
Imports System.IO


Public Class NewTaskForm

    Dim m_master_control As ALMasterControl

    Private Sub chooseFileBrowseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chooseFileBrowseButton.Click

        OpenFileDialog.ShowDialog()

    End Sub

    Private Sub OpenFileDialog_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog.FileOk

        chooseFileTextBox.Text = OpenFileDialog.FileName

    End Sub


#Region "kind of task(exe, multimedia, etc) checkbuttons"

    Private Sub ExecutableCheckButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExecutableCheckButton.Click

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

        chooseFileCheckLabel.Visible = True

    End Sub

    Private Sub MultimediaCheckButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultimediaCheckButton.Click

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

        chooseFileCheckLabel.Visible = True

    End Sub

    Private Sub OtherCheckButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherCheckButton.Click

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

        chooseFileCheckLabel.Visible = True

    End Sub

    Private Sub ReminderCheckButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReminderCheckButton.Click
        MsgBox("Does nothing yet")
    End Sub

#End Region

    Private Sub chooseFileTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chooseFileTextBox.TextChanged
        If (ExecutableCheckButton.Checked = True) Then
            checkIfFileExists(".exe")

        ElseIf (MultimediaCheckButton.Checked = True) Then
            checkIfFileExists(".mp3")   'will be changed using a regular expression

        ElseIf (OtherCheckButton.Checked = True) Then
            checkIfFileExists("")
        End If


    End Sub

    Private Sub checkIfFileExists(ByVal type As String)

        If (File.Exists(chooseFileTextBox.Text) And chooseFileTextBox.Text.EndsWith(type)) Then

            enableRestOfPanels(True)
            chooseFileCheckLabel.Values.Image = AssUI.My.Resources.tick

        Else
            enableRestOfPanels(False)
            chooseFileCheckLabel.Values.Image = AssUI.My.Resources.cross
        End If

    End Sub

    Private Sub enableRestOfPanels(ByVal state As Boolean)
        If state Then
            'handles all panels' visibility
            HandleAllPanels(True, True, True, True, True)

            'handles the arrow labels
            HandleArrowLabels(False, False, True, False, False)

            'handles all Rectangle Shapes' visibility
            HandleRectangles(False, False, True, False, False)

            'handles MoreOptions & SaveTask buttons' visibility
            HandleMoreAndSaveButtons(True, True)

        Else
            'handles all panels' visibility
            HandleAllPanels(True, True, False, False, False)

            'handles the arrow labels
            HandleArrowLabels(False, True, False, False, False)

            'handles all Rectangle Shapes' visibility
            HandleRectangles(False, True, False, False, False)

            'handles MoreOptions & SaveTask buttons' visibility
            HandleMoreAndSaveButtons(False, False)
        End If
    End Sub

#Region "type of task(once, daily, weekly, etc) checkbuttons"

    Private Sub OnceCheckButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnceCheckButton.Click

        'handles all the arrow labels
        HandleArrowLabels(False, False, False, False, False)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, False, False)

        'handles RecurrencePanel's Visibility
        HandleRecPanel(False, True)

    End Sub

    Private Sub DailyCheckButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyCheckButton.Click

        'handles the arrow labels
        HandleArrowLabels(False, False, False, False, True)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, False, True)

        'handles RecurrencePanel's Visibility
        HandleRecPanel(True, True)

        'handles RecurrencePanel's content
        HandleRecPanelContent(False, False, False, False, False, False)

        Label2.Text = "days"

    End Sub

    Private Sub WeeklyCheckButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WeeklyCheckButton.Click

        'handles the arrow labels
        HandleArrowLabels(False, False, False, False, True)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, False, True)

        'handles RecurrencePanel's Visibility
        HandleRecPanel(True, True)

        'handles RecurrencePanel's content
        HandleRecPanelContent(True, True, False, False, False, False)

        Label2.Text = "weeks"

    End Sub

    Private Sub MonthlyCheckButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthlyCheckButton.Click

        'handles the arrow labels
        HandleArrowLabels(False, False, False, False, True)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, False, True)

        'handles RecurrencePanel's Visibility
        HandleRecPanel(True, True)

        'handles RecurrencePanel's content
        HandleRecPanelContent(False, False, True, True, False, False)

        Label2.Text = "months"

    End Sub

    Private Sub YearlyCheckButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearlyCheckButton.Click

        'handles the arrow labels
        HandleArrowLabels(False, False, False, False, True)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, False, True)

        'handles RecurrencePanel's Visibility
        HandleRecPanel(True, True)

        'handles RecurrencePanel's content
        HandleRecPanelContent(False, False, False, False, True, True)

        Label2.Text = "years"

    End Sub
#End Region


    Private Sub MoreOptionsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoreOptionsButton.Click

        MoreOptionsForm.ShowDialog()

    End Sub

#Region "My handle-methods"
    'handles the blue directional ArrowLabels visibility
    Private Sub HandleArrowLabels(ByVal label1 As Boolean, ByVal label2 As Boolean, _
                                    ByVal label3 As Boolean, ByVal label4 As Boolean, ByVal label5 As Boolean)
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

    End Sub

    'handles all panels' visibility
    Private Sub HandleAllPanels(ByVal panel1 As Boolean, ByVal panel2 As Boolean, ByVal panel3 As Boolean, _
                                ByVal panel4 As Boolean, ByVal panel5 As Boolean)

        KindOfTaskPanel.Enabled = panel1
        chooseFilePanel.Enabled = panel2
        DateTimePanel.Enabled = panel3
        TypeOfTaskPanel.Enabled = panel4
        RecurrencePanel.Enabled = panel5

    End Sub

    'handles MoreOptions & SaveTask buttons' visibility
    Private Sub HandleMoreAndSaveButtons(ByVal more As Boolean, ByVal save As Boolean)
        MoreOptionsButton.Enabled = more
        SaveTaskButton.Enabled = save
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

    'handles RecurrencePanel's Visibility
    Private Sub HandleRecPanel(ByVal RecVis As Boolean, ByVal RecEn As Boolean)
        RecurrencePanel.Visible = RecVis
        RecurrencePanel.Enabled = RecEn
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

    Private Sub chooseFilePanel_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chooseFilePanel.MouseEnter
        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, True, False, False, False)

        'handles the arrow labels
        HandleArrowLabels(False, True, False, False, False)
    End Sub

    Private Sub RecurrencePanel_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecurrencePanel.MouseEnter
        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, False, True)

        'handles the arrow labels
        HandleArrowLabels(False, False, False, False, True)
    End Sub


    Public Sub SetMasterControl(ByRef a_master_control As ALMasterControl)
        m_master_control = a_master_control
    End Sub

    Public Sub SaveTaskButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveTaskButton.Click
        'gets the result from the Dialog (asking the user)
        Dim result As DialogResult
        result = SaveButtonTaskDialog.ShowDialog()

        If (result = DialogResult.Yes) Then

            Dim m_date As Date = New Date(DatePicker.Value.Year, DatePicker.Value.Month, DatePicker.Value.Day, _
                                  TimePicker.Value.Hour, TimePicker.Value.Minute, TimePicker.Value.Second)

            Dim m_end_date As Date = New Date(MoreOptionsForm.EndAtDateTimePicker.Value.Year, MoreOptionsForm.EndAtDateTimePicker.Value.Month, MoreOptionsForm.EndAtDateTimePicker.Value.Day, _
                              TimePicker.Value.Hour, TimePicker.Value.Minute, TimePicker.Value.Second)

            Dim m_not_run As String
            If MoreOptionsForm.RunWhenPcOpensRadioButton.Checked Then
                m_not_run = "RUN"
            ElseIf MoreOptionsForm.DisplayDialogAskingRadioButton.Checked Then
                m_not_run = "DIALOG"
            Else
                m_not_run = "NOTHING"
            End If

            If OnceCheckButton.Checked Then
                m_master_control.AddTask(chooseFileTextBox.Text, m_date, m_end_date, MoreOptionsForm.KryptonRadioButton2.Checked, _
                MoreOptionsForm.DescriptionTextBox.Text, 0, 0, 0, 0, m_not_run)

            ElseIf DailyCheckButton.Checked Then
                m_master_control.AddTask(chooseFileTextBox.Text, m_date, m_end_date, MoreOptionsForm.KryptonRadioButton2.Checked, _
                MoreOptionsForm.DescriptionTextBox.Text, KryptonNumericUpDown1.Value, KryptonNumericUpDown1.Value, 0, 0, m_not_run)

            ElseIf WeeklyCheckButton.Checked Then
                m_master_control.AddTask(chooseFileTextBox.Text, m_date, m_end_date, MoreOptionsForm.KryptonRadioButton2.Checked, _
                MoreOptionsForm.DescriptionTextBox.Text, KryptonNumericUpDown1.Value, 0, KryptonNumericUpDown1.Value, 0, m_not_run)

            Else
                m_master_control.AddTask(chooseFileTextBox.Text, m_date, m_end_date, MoreOptionsForm.KryptonRadioButton2.Checked, _
                MoreOptionsForm.DescriptionTextBox.Text, KryptonNumericUpDown1.Value, 0, 0, KryptonNumericUpDown1.Value, m_not_run)
            End If

            'to be resolved : null reference exception
            SuccessTaskDialog.ShowDialog()
            'will add reset function, it will reset all fields of the form
            Me.Close()
        Else
            Exit Sub
        End If



    End Sub

    Private Sub NewTaskForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DateTimePanel_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePanel.MouseEnter
        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, True, False, False)

        'handles the arrow labels
        HandleArrowLabels(False, False, True, False, False)
    End Sub

    Private Sub TypeOfTaskPanel_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypeOfTaskPanel.MouseEnter
        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, True, False)

        'handles the arrow labels
        HandleArrowLabels(False, False, False, True, False)
    End Sub

    Private Sub chooseFileOkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click

    End Sub
End Class
