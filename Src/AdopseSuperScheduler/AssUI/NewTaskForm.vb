Imports Microsoft.Win32
Imports AssLogic
Imports System.IO
Imports System.ServiceProcess
Imports ComponentFactory.Krypton.Toolkit


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

        'handles things that the Service Check Button opens
        HandleServiceCheckButtonFunction(True, False, False)

    End Sub


    Private Sub FileCheckButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileCheckButton.Click

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

        'handles things that the Service Check Button opens
        HandleServiceCheckButtonFunction(True, False, False)

    End Sub

    Private Sub ServiceCheckButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiceCheckButton.Click

        HandleServiceCheckButtonFunction(False, True, True)
        HandleChooseFilePanel(False, " ")
        ListServices()
        HandleArrowLabels(False, True, False, False, False)
        HandleRectangles(False, False, False, False, False)


    End Sub

    Private Sub ListServices()
        Dim svcs As ServiceController() = _
         ServiceController.GetServices()

        For Each svc As ServiceController In svcs

            ServicesDataGridView.Rows.Add(svc.DisplayName, svc.Status, svc.ServiceType.ToString())

        Next (svc)

    End Sub

    Private Function FormatStatus( _
 ByVal st As ServiceControllerStatus) As String
        Dim result As String = Nothing
        Select Case st
            Case ServiceControllerStatus.ContinuePending
                result = "Continuing"
            Case ServiceControllerStatus.Paused
                result = "Paused"
            Case ServiceControllerStatus.PausePending
                result = "Pausing"
            Case ServiceControllerStatus.Running
                result = "Started"
            Case ServiceControllerStatus.StartPending
                result = "Starting"
            Case ServiceControllerStatus.Stopped
                result = String.Empty
            Case ServiceControllerStatus.StopPending
                result = "Stopping"
        End Select
        Return result
    End Function

#End Region

    Private Sub chooseFileTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chooseFileTextBox.TextChanged
        If (ExecutableCheckButton.Checked = True) Then
            checkIfFileExists(".exe")

        ElseIf (FileCheckButton.Checked = True) Then
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
        HandleRecPanelContent(False, False, False)

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
        HandleRecPanelContent(True, False, False)

        Label2.Text = "weeks"

        'Automatically checks the day of the week you chose
        'at the next dropdown button
        AutoCheckDayOfWeek()

    End Sub

    Private Sub MonthlyCheckButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthlyCheckButton.Click

        'handles the arrow labels
        HandleArrowLabels(False, False, False, False, True)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, False, True)

        'handles RecurrencePanel's Visibility
        HandleRecPanel(True, True)

        'handles RecurrencePanel's content
        HandleRecPanelContent(False, True, False)

        Label2.Text = "months"

        'Automatically checks the day of the month the user have chosen
        'and ticks the checkbox at AllMonthkDays dropdown button
        AutoCheckDayOfMonth()

    End Sub

    Private Sub YearlyCheckButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearlyCheckButton.Click

        'handles the arrow labels
        HandleArrowLabels(False, False, False, False, True)

        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, False, True)

        'handles RecurrencePanel's Visibility
        HandleRecPanel(True, True)

        'handles RecurrencePanel's content
        HandleRecPanelContent(False, True, True)

        Label2.Text = "years"

        AutoCheckMonth()

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
    Private Sub HandleRecPanelContent(ByVal wkDrpDnBtn As Boolean, ByVal mnthDDrpDnBtn As Boolean, _
                                      ByVal mnthDrpDnBtn As Boolean)

        'WeekdaysLabel.Visible = wkLbl
        WeekdaysDropDownButton.Visible = wkDrpDnBtn
        'MonthDaysLabel.Visible = mnthDLbl
        MonthDaysDropDownButton.Visible = mnthDDrpDnBtn
        'MonthsLabel.Visible = mnthLbl
        MonthsDropDownButton.Visible = mnthDrpDnBtn

    End Sub

    'handles things that the Service Check Button opens
    Private Sub HandleServiceCheckButtonFunction(ByVal checkLabel As Boolean, ByVal srvcLabel As Boolean, ByVal srvcListView As Boolean)
        chooseFileCheckLabel.Visible = checkLabel
        ServiceLabel.Visible = srvcLabel
        ServicesDataGridView.Visible = srvcListView
    End Sub

#End Region

    Public Sub SetMasterControl(ByRef a_master_control As ALMasterControl)
        m_master_control = a_master_control
    End Sub

    Public Sub SaveTaskButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveTaskButton.Click

        'checks if the task type is Once
        'and if the time is before the current time
        'if so, it changes it to the current time + 3min
        'and opens a dialog prompting the user

        If (OnceCheckButton.Checked = True) And _
                (DatePicker.Value.ToLongDateString = Date.Now.ToLongDateString) Then

            TimePicker.Value = DateTime.Now.ToLongTimeString
            TimePicker.Value = TimePicker.Value.AddMinutes(3.0)

            TimeChangedTaskDialog.Content = "Scheduled time changed to *" & TimePicker.Value & "*" _
                                    & vbCrLf & "so that the task won't be missed!" & vbCrLf _
                                    & vbCrLf & "Do you want to continue ?"

            Dim resultTime As DialogResult
            resultTime = TimeChangedTaskDialog.ShowDialog()

            If (resultTime = DialogResult.No) Then
                Exit Sub
            End If

        End If


        'gets the result from the Dialog 
        'asking the user if he wants to save the task
        Dim resultSave As DialogResult
        resultSave = SaveButtonTaskDialog.ShowDialog()

        If (resultSave = DialogResult.Yes) Then

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

            Dim m_type As String
            If ExecutableCheckButton.Checked Then
                m_type = "EXE"
                ' ElseIf .Checked Then
                '     m_type = "DIALOG"   ''SERVICE OPTION RESERVED, TO BE DONE
            Else
                m_type = "FILE"
            End If

            If OnceCheckButton.Checked Then
                m_master_control.AddTask(chooseFileTextBox.Text, m_date, m_end_date, MoreOptionsForm.ActiveRadioButton.Checked, m_type, _
                MoreOptionsForm.DescriptionTextBox.Text, Integer.Parse(MoreOptionsForm.MinutesUpDown.Value), 0, 0, 0, m_not_run)

            ElseIf DailyCheckButton.Checked Then
                m_master_control.AddTask(chooseFileTextBox.Text, m_date, m_end_date, MoreOptionsForm.ActiveRadioButton.Checked, m_type, _
                MoreOptionsForm.DescriptionTextBox.Text, Integer.Parse(MoreOptionsForm.MinutesUpDown.Value), KryptonNumericUpDown1.Value, 0, 0, m_not_run)

            ElseIf WeeklyCheckButton.Checked Then
                m_master_control.AddTask(chooseFileTextBox.Text, m_date, m_end_date, MoreOptionsForm.ActiveRadioButton.Checked, m_type, _
                MoreOptionsForm.DescriptionTextBox.Text, Integer.Parse(MoreOptionsForm.MinutesUpDown.Value), KryptonNumericUpDown1.Value, 0, 0, m_not_run)

            Else
                m_master_control.AddTask(chooseFileTextBox.Text, m_date, m_end_date, MoreOptionsForm.ActiveRadioButton.Checked, m_type, _
                MoreOptionsForm.DescriptionTextBox.Text, Integer.Parse(MoreOptionsForm.MinutesUpDown.Value), 0, 0, KryptonNumericUpDown1.Value, m_not_run)
            End If

            'Opens up a dialog show that the task was Successfully added
            SuccessTaskDialog.ShowDialog()

            ' dispose the Form object, so when we open the form again all fields will be cleared
            MoreOptionsForm.Dispose()
            Me.Dispose()

            'closes the current form
            Me.Close()
            Me.SetMasterControl(m_master_control)

        Else

            Exit Sub

        End If

    End Sub

#Region "Mouse Enter handle methods"

    Private Sub chooseFilePanel_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chooseFilePanel.MouseEnter
        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, True, False, False, False)

        'handles the arrow labels
        HandleArrowLabels(False, True, False, False, False)
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

    Private Sub RecurrencePanel_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecurrencePanel.MouseEnter
        'handles all Rectangle Shapes' visibility
        HandleRectangles(False, False, False, False, True)

        'handles the arrow labels
        HandleArrowLabels(False, False, False, False, True)
    End Sub

#End Region

    Private Sub NewTaskForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'handles all Rectangle Shapes' visibility
        HandleRectangles(True, False, False, False, False)

        'handles the arrow labels
        HandleArrowLabels(True, False, False, False, False)

        'sets the minimum day the user can choose as the current day
        DatePicker.MinDate = Today

    End Sub


    'Automatically checks the day of the week the user have chosen
    'and ticks the checkbox at AllWeekDays dropdown button
    Private Sub AutoCheckDayOfWeek()
        Dim day As String
        day = DatePicker.Value.Date.DayOfWeek.ToString

        Dim checkBoxes(6) As KryptonContextMenuCheckBox
        checkBoxes(0) = KryptonContextMenuCheckBox1
        checkBoxes(1) = KryptonContextMenuCheckBox2
        checkBoxes(2) = KryptonContextMenuCheckBox3
        checkBoxes(3) = KryptonContextMenuCheckBox4
        checkBoxes(4) = KryptonContextMenuCheckBox5
        checkBoxes(5) = KryptonContextMenuCheckBox6
        checkBoxes(6) = KryptonContextMenuCheckBox7

        For i As Integer = 0 To 6
            If checkBoxes(i).ToString.Equals(day) Then
                checkBoxes(i).Checked = True
                checkBoxes(i).AutoCheck = False
            Else
                checkBoxes(i).Checked = False
                checkBoxes(i).AutoCheck = True
            End If
        Next
    End Sub

    'Automatically checks the day of the month the user have chosen
    'and ticks the checkbox at AllMonthkDays dropdown button
    Private Sub AutoCheckDayOfMonth()
        Dim day As String
        day = DatePicker.Value.Date.Day.ToString

        Dim checkBoxes(30) As KryptonContextMenuCheckBox
        checkBoxes(0) = KryptonContextMenuCheckBox17
        checkBoxes(1) = KryptonContextMenuCheckBox18
        checkBoxes(2) = KryptonContextMenuCheckBox19
        checkBoxes(3) = KryptonContextMenuCheckBox20
        checkBoxes(4) = KryptonContextMenuCheckBox21
        checkBoxes(5) = KryptonContextMenuCheckBox22
        checkBoxes(6) = KryptonContextMenuCheckBox23
        checkBoxes(7) = KryptonContextMenuCheckBox24
        checkBoxes(8) = KryptonContextMenuCheckBox25
        checkBoxes(9) = KryptonContextMenuCheckBox26
        checkBoxes(10) = KryptonContextMenuCheckBox27
        checkBoxes(11) = KryptonContextMenuCheckBox28
        checkBoxes(12) = KryptonContextMenuCheckBox29
        checkBoxes(13) = KryptonContextMenuCheckBox30
        checkBoxes(14) = KryptonContextMenuCheckBox31
        checkBoxes(15) = KryptonContextMenuCheckBox32
        checkBoxes(16) = KryptonContextMenuCheckBox33
        checkBoxes(17) = KryptonContextMenuCheckBox34
        checkBoxes(18) = KryptonContextMenuCheckBox35
        checkBoxes(19) = KryptonContextMenuCheckBox36
        checkBoxes(20) = KryptonContextMenuCheckBox37
        checkBoxes(21) = KryptonContextMenuCheckBox38
        checkBoxes(22) = KryptonContextMenuCheckBox39
        checkBoxes(23) = KryptonContextMenuCheckBox40
        checkBoxes(24) = KryptonContextMenuCheckBox41
        checkBoxes(25) = KryptonContextMenuCheckBox44
        checkBoxes(26) = KryptonContextMenuCheckBox45
        checkBoxes(27) = KryptonContextMenuCheckBox46
        checkBoxes(28) = KryptonContextMenuCheckBox47
        checkBoxes(29) = KryptonContextMenuCheckBox49
        checkBoxes(30) = KryptonContextMenuCheckBox50


        For i As Integer = 0 To 30
            If checkBoxes(i).ToString.Equals(day + "th") Or checkBoxes(i).ToString.Equals(day + "st") _
                    Or checkBoxes(i).ToString.Equals(day + "nd") Or checkBoxes(i).ToString.Equals(day + "rd") Then

                checkBoxes(i).Checked = True
                checkBoxes(i).AutoCheck = False
            Else
                checkBoxes(i).Checked = False
                checkBoxes(i).AutoCheck = True
            End If
        Next
    End Sub

    'Automatically checks the month the user have chosen
    'and ticks the checkbox at AllMonths dropdown button
    Private Sub AutoCheckMonth()

        Dim month As String
        month = MonthName(DatePicker.Value.Date.Month, True)
        convertMonthNameToEng(month)

        Dim checkBoxes(11) As KryptonContextMenuCheckBox
        checkBoxes(0) = KryptonContextMenuCheckBox9
        checkBoxes(1) = KryptonContextMenuCheckBox10
        checkBoxes(2) = KryptonContextMenuCheckBox11
        checkBoxes(3) = KryptonContextMenuCheckBox12
        checkBoxes(4) = KryptonContextMenuCheckBox13
        checkBoxes(5) = KryptonContextMenuCheckBox14
        checkBoxes(6) = KryptonContextMenuCheckBox15
        checkBoxes(7) = KryptonContextMenuCheckBox55
        checkBoxes(8) = KryptonContextMenuCheckBox16
        checkBoxes(9) = KryptonContextMenuCheckBox52
        checkBoxes(10) = KryptonContextMenuCheckBox53
        checkBoxes(11) = KryptonContextMenuCheckBox54

        For i As Integer = 0 To 11
            If checkBoxes(i).ToString.Contains(Month) Then
                checkBoxes(i).Checked = True
                checkBoxes(i).AutoCheck = False
            Else
                checkBoxes(i).Checked = False
                checkBoxes(i).AutoCheck = True
            End If
        Next
    End Sub

    'converts the greek month name to english (etc 'Ιαν' to 'Jan')
    Private Function convertMonthNameToEng(ByRef month As String) As String
        If month.Equals("Ιαν") Then
            month = "Jan"
        End If
        If month.Equals("Φεβ") Then
            month = "Feb"
        End If
        If month.Equals("Μαρ") Then
            month = "Mar"
        End If
        If month.Equals("Απρ") Then
            month = "Apr"
        End If
        If month.Equals("Μαϊ") Then
            month = "May"
        End If
        If month.Equals("Ιουν") Then
            month = "Jun"
        End If
        If month.Equals("Ιουλ") Then
            month = "Jul"
        End If
        If month.Equals("Αυγ") Then
            month = "Aug"
        End If
        If month.Equals("Σεπ") Then
            month = "Sep"
        End If
        If month.Equals("Οκτ") Then
            month = "Oct"
        End If
        If month.Equals("Νοε") Then
            month = "Nov"
        End If
        If month.Equals("Δεκ") Then
            month = "Dec"
        End If


        Return month
    End Function

    Private Sub MonthsDropDownButton_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MonthsDropDownButton.MouseEnter
        AutoCheckMonth()
    End Sub

    Private Sub WeekdaysDropDownButton_MouseEnter(sender As System.Object, e As System.EventArgs) Handles WeekdaysDropDownButton.MouseEnter
        AutoCheckDayOfWeek()
    End Sub

    Private Sub MonthDaysDropDownButton_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MonthDaysDropDownButton.MouseEnter
        AutoCheckDayOfMonth()
    End Sub

    Private Sub ServicesDataGridView_VisibleChanged(sender As System.Object, e As System.EventArgs) Handles ServicesDataGridView.VisibleChanged
        If ServicesDataGridView.Visible = True Then
            enableRestOfPanels(True)
        Else
            enableRestOfPanels(False)
        End If
    End Sub

    Private Sub ServicesDataGridView_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles ServicesDataGridView.SelectionChanged
        HandleArrowLabels(False, False, True, False, False)
        HandleRectangles(False, False, True, False, False)
    End Sub

End Class
