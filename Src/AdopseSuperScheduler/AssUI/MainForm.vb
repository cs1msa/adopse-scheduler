Imports ComponentFactory.Krypton.Toolkit
Imports AssLogic
Imports CompletIT.Windows.Forms.Export.Pdf
Imports CompletIT.Windows.Forms.Export
Imports System.ServiceProcess
Imports System.Data
Imports Microsoft.Win32


Public Class MainForm

    Friend m_master_control As ALMasterControl

    Dim m_scheduled_tasks__datagrid_restrictions As List(Of String)
    Dim m_log_datagrid_restrictions As List(Of String)
    Dim m_need_to_update_datagrids As Boolean = True

    Private _widthLeftRight As Integer
    Private _heightUpDown As Integer

    Dim m__row_clicked As Integer

    Dim grWords As New List(Of String)
    Dim engWords As New List(Of String)

    Private Sub ButtonSpecHeaderGroup1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecHeaderGroup1.Click
        ''Suspend layout changes until all splitter properties have been updated
        KryptonSplitContainer1.SuspendLayout()

        ''Is the left header group currently expanded?
        If (KryptonSplitContainer1.FixedPanel = FixedPanel.None) Then

            '' Make the left panel of the splitter fixed in size
            KryptonSplitContainer1.FixedPanel = FixedPanel.Panel1
            KryptonSplitContainer1.IsSplitterFixed = True

            '' Remember the current height of the header group
            _widthLeftRight = NavigateHeaderGroup.Width

            ''We have not changed the orientation of the header yet, so the width of 
            '' the splitter panel is going to be the height of the collapsed header group
            Dim newWidth As Integer
            newWidth = NavigateHeaderGroup.PreferredSize.Height

            '' Make the header group fixed just as the new height
            KryptonSplitContainer1.Panel1MinSize = newWidth
            KryptonSplitContainer1.SplitterDistance = newWidth

            ''Change header to be vertical and button to near edge
            NavigateHeaderGroup.HeaderPositionPrimary = VisualOrientation.Right
            NavigateHeaderGroup.ButtonSpecs(0).Edge = PaletteRelativeEdgeAlign.Near

        Else

            ''Make the bottom panel not-fixed in size anymore
            KryptonSplitContainer1.FixedPanel = FixedPanel.None
            KryptonSplitContainer1.IsSplitterFixed = False

            '' Put back the minimise size to the original
            KryptonSplitContainer1.Panel1MinSize = 25

            '' Calculate the correct splitter we want to put back
            KryptonSplitContainer1.SplitterDistance = _widthLeftRight

            '' Change header to be horizontal and button to far edge
            NavigateHeaderGroup.HeaderPositionPrimary = VisualOrientation.Top
            NavigateHeaderGroup.ButtonSpecs(0).Edge = PaletteRelativeEdgeAlign.Far


        End If

        KryptonSplitContainer1.ResumeLayout()
    End Sub

    Private Sub ButtonSpecHeaderGroup2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecHeaderGroup2.Click
        ''Suspend layout changes until all splitter properties have been updated
        KryptonSplitContainer2.SuspendLayout()

        '' Is the bottom right header group currently expanded?
        If (KryptonSplitContainer2.FixedPanel = FixedPanel.None) Then

            ''Make the bottom panel of the splitter fixed in size
            KryptonSplitContainer2.FixedPanel = FixedPanel.Panel2
            KryptonSplitContainer2.IsSplitterFixed = True

            ''Remember the current height of the header group (to restore later)
            _heightUpDown = LogHeaderGroup.Height

            ''Find the new height to use for the header group
            Dim newHeight As Integer
            newHeight = LogHeaderGroup.PreferredSize.Height

            ''Make the header group fixed to the new height
            KryptonSplitContainer2.Panel2MinSize = newHeight
            KryptonSplitContainer2.SplitterDistance = KryptonSplitContainer2.Height

        Else

            ''Make the bottom panel not-fixed in size anymore
            KryptonSplitContainer2.FixedPanel = FixedPanel.None
            KryptonSplitContainer2.IsSplitterFixed = False

            ''Put back the minimise size to the original
            KryptonSplitContainer2.Panel2MinSize = 100

            ''Calculate the correct splitter we want to put back
            KryptonSplitContainer2.SplitterDistance = KryptonSplitContainer2.Height - _heightUpDown - KryptonSplitContainer2.SplitterWidth
        End If

        KryptonSplitContainer2.ResumeLayout()
    End Sub

    Private Sub AddTaskButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddTaskButton.Click
        NewTaskForm.SetMasterControl(m_master_control)
        NewTaskForm.m_can_overwrite_task = False
        NewTaskForm.ShowDialog()
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        NewTaskForm.SetMasterControl(m_master_control)
        NewTaskForm.ShowDialog()
    End Sub

    Private Sub checkRunOnStartup()

        If My.Settings.RunOnStartupFlag = True Then
            RunOnStartupToolStripMenuItem.Checked = True
            createRegistryKey()
        ElseIf My.Settings.RunOnStartupFlag = False Then
            RunOnStartupToolStripMenuItem.Checked = False
        End If

    End Sub


    Private Sub checkLanguage()

        Select Case My.Settings.LanguageFlag
            Case "Greek"
                flagCheckSet.CheckedIndex = 1
            Case "English"
                flagCheckSet.CheckedIndex = 0
        End Select

        langBackgroundWorker.RunWorkerAsync()

    End Sub

    'expands the tree view nodes Task and History on startup
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        m_scheduled_tasks__datagrid_restrictions = New List(Of String)
        m_log_datagrid_restrictions = New List(Of String)

        KryptonManager.GlobalPaletteMode = My.Settings.PalletteSetting

        'checks which pallette mode has been chosen
        checkPalletteMode()


        m_master_control = New ALMasterControl()
        m_master_control.Init()

        fillEnglishWords()
        fillGreekWords()

        CheckMissedTasks()

        ScheduledTasksDataGridView.Columns.Clear()
        LogDataGridView.Columns.Clear()

        Timer.Start()

        m_master_control.StartProgramLoop()

        checkIfTasksAreEmpty()
        checkRunOnStartup()

        'handles the errors regarding multithreading and variables
        Control.CheckForIllegalCrossThreadCalls = False



        'is responsible for the change of Language
        'according to the user's choice, even after the applications was closed
        languageOnStartTimer.Start()

    End Sub


    'checks which pallette mode has been chosen
    Private Sub checkPalletteMode()
        Select Case My.Settings.PalletteSetting
            Case PaletteModeManager.Office2010Black
                HandlePalletteModeMenuItemsCheck(True, False, False, False, False, False)
            Case PaletteModeManager.Office2010Blue
                HandlePalletteModeMenuItemsCheck(False, True, False, False, False, False)
            Case PaletteModeManager.Office2010Silver
                HandlePalletteModeMenuItemsCheck(False, False, True, False, False, False)
            Case PaletteModeManager.Office2007Black
                HandlePalletteModeMenuItemsCheck(False, False, False, True, False, False)
            Case PaletteModeManager.Office2007Blue
                HandlePalletteModeMenuItemsCheck(False, False, False, False, True, False)
            Case PaletteModeManager.Office2007Silver
                HandlePalletteModeMenuItemsCheck(False, False, False, False, False, True)
        End Select
    End Sub

    'handles the check signs in the ToolStripMenuItems
    Private Sub HandlePalletteModeMenuItemsCheck(ByVal office2010Black As Boolean, ByVal office2010Blue As Boolean, _
                                                 ByVal office2010Silver As Boolean, ByVal office2007Black As Boolean, _
                                                 ByVal office2007Blue As Boolean, ByVal office2007Silver As Boolean)

        office2010BlackToolStripMenuItem.Checked = office2010Black
        office2010BlueToolStripMenuItem.Checked = office2010Blue
        office2010SilverToolStripMenuItem.Checked = office2010Silver
        office2007BlackToolStripMenuItem.Checked = office2007Black
        office2007BlueToolStripMenuItem.Checked = office2007Blue
        office2007SilverToolStripMenuItem.Checked = office2007Silver


    End Sub

    'checks if no task exists in the ScheduledTasks DataGridView
    'if so, prompts the user accordingly
    'and asks him if he wants to add one
    Private Sub checkIfTasksAreEmpty()
        'get the scheduler tasks table 
        Dim scheduler_table As DataTable = m_master_control.GetFromATableAsDataTable("[Scheduler Tasks]", {"Task_ID as ID", "Type", "Program_Path as Task", "Next_Run as [Next Execution]", "Period", "Status", "Description", "End_Date"})

        If (scheduler_table.Rows.Count = 0) And _
        (My.Settings.NoScheduledTaskDialogFlag = True) Then

            If My.Settings.LanguageFlag.Equals("Greek") Then

                With NoScheduledTaskDialog
                    .CheckboxText = grWords(92)
                    .MainInstruction = grWords(93)
                    .WindowTitle = grWords(94)
                    .Content = "Απ' ό,τι φαίνεται δεν έχεις κάποια προγραμματισμένη εργασία." & vbCrLf & "Θα ήθελες να προσθέσεις μια τώρα;"
                End With

            ElseIf My.Settings.LanguageFlag.Equals("English") Then

                With NoScheduledTaskDialog
                    .CheckboxText = engWords(92)
                    .MainInstruction = engWords(93)
                    .WindowTitle = engWords(94)
                    .Content = "It seems that you don't have a task scheduled." & vbCrLf & "Would you like to add a task now?"
                End With

            End If


            If NoScheduledTaskDialog.ShowDialog() = DialogResult.Yes Then
                NewTaskForm.SetMasterControl(m_master_control)
                NewTaskForm.ShowDialog()
            End If

            If NoScheduledTaskDialog.CheckboxState = True Then
                My.Settings.NoScheduledTaskDialogFlag = False
            End If

        End If
        My.Settings.Save()
    End Sub

    'changes the default action of the X button
    'instead of closing the programm it hides it in the tray
    Private Sub MainForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        Me.ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        Me.Show()
    End Sub

    Private Sub ExitContextMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitContextMenuItem.Click

        TrayIcon.Dispose()

        'Me.Close() doesn't work because 
        'it is captured by the FormCLosing event
        System.Windows.Forms.Application.Exit()

    End Sub

    Private Sub TrayIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TrayIcon.MouseDoubleClick
        Me.ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        Me.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click

        TrayIcon.Dispose()

        'Me.Close() doesn't work because 
        'it is captured by the FormCLosing event
        System.Windows.Forms.Application.Exit()

    End Sub

    Private Sub LogButtonSpecExportToPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogButtonSpecExportToPDF.Click
        exportToPDF(LogDataGridView)
    End Sub

    Friend Sub exportToPDF(ByRef datagridview As ComponentFactory.Krypton.Toolkit.KryptonDataGridView)

        'You can export any DataGridView control, no matter managed or not by the extension
        Dim pdfExporter As DGVEPdfExporter = New DGVEPdfExporter()
        Dim dialog As DGVEBaseExportSettingsEditorForm = DGVEExportSettingsEditorFormBuilder.CreateWrappingForm(pdfExporter)
        dialog.Settings = New DGVEPdfExportSettings()
        If (DialogResult.OK <> dialog.ShowDialog()) Then
            Return
        End If

        AddHandler pdfExporter.ExportFailed, AddressOf exporter_ExportFailed
        pdfExporter.Export(datagridview, dialog.Settings)



    End Sub

    Private Sub exporter_ExportFailed(ByVal sender As Object, ByVal e As CompletIT.Windows.Forms.Export.ExportFailedEventArgs)
        'Show message box with the occured exception 
        MessageBox.Show(e.Exception.Message)
    End Sub


#Region "View ToolStrip MenuItems click-events"
    Private Sub office2010BlackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles office2010BlackToolStripMenuItem.Click

        changePalletteMode(1)
        changeLabelColors(1)

    End Sub

    Private Sub office2010BlueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles office2010BlueToolStripMenuItem.Click

        changePalletteMode(2)
        changeLabelColors(2)

    End Sub

    Private Sub office2010SilverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles office2010SilverToolStripMenuItem.Click

        changePalletteMode(3)
        changeLabelColors(3)

    End Sub

    Private Sub office2007BlackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles office2007BlackToolStripMenuItem.Click

        changePalletteMode(4)
        changeLabelColors(4)

    End Sub

    Private Sub office2007BlueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles office2007BlueToolStripMenuItem.Click

        changePalletteMode(5)
        changeLabelColors(5)

    End Sub

    Private Sub office2007SilverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles office2007SilverToolStripMenuItem.Click

        changePalletteMode(6)
        changeLabelColors(6)

    End Sub
#End Region

    'changes the pallette mode to the one that the user chose
    Private Sub changePalletteMode(ByVal i As Integer)

        Select Case i
            Case 1
                My.Settings.PalletteSetting = PaletteModeManager.Office2010Black
                HandlePalletteModeMenuItemsCheck(True, False, False, False, False, False)
            Case 2
                My.Settings.PalletteSetting = PaletteModeManager.Office2010Blue
                HandlePalletteModeMenuItemsCheck(False, True, False, False, False, False)
            Case 3
                My.Settings.PalletteSetting = PaletteModeManager.Office2010Silver
                HandlePalletteModeMenuItemsCheck(False, False, True, False, False, False)
                changeLabelColors(3)
            Case 4
                My.Settings.PalletteSetting = PaletteModeManager.Office2007Black
                HandlePalletteModeMenuItemsCheck(False, False, False, True, False, False)
            Case 5
                My.Settings.PalletteSetting = PaletteModeManager.Office2007Blue
                HandlePalletteModeMenuItemsCheck(False, False, False, False, True, False)
            Case 6
                My.Settings.PalletteSetting = PaletteModeManager.Office2007Silver
                HandlePalletteModeMenuItemsCheck(False, False, False, False, False, True)
        End Select

        'saves the changes to My.Settings
        'so that they remain after the program starts again
        My.Settings.Save()
        KryptonManager.GlobalPaletteMode = My.Settings.PalletteSetting

    End Sub

    'changes the labels' and rectangleShapes' color
    Protected Friend Sub changeLabelColors(ByVal i As Integer)
        Select Case i
            Case 1, 4
                NewTaskForm.KindOfTaskLabel.StateNormal.ShortText.Color1 = Color.Yellow
                NewTaskForm.ServiceLabel.StateCommon.ShortText.Color1 = Color.Yellow
                NewTaskForm.KryptonLabel1.StateNormal.ShortText.Color1 = Color.Yellow
                NewTaskForm.KryptonLabel2.StateCommon.ShortText.Color1 = Color.White
                NewTaskForm.KryptonLabel3.StateNormal.ShortText.Color1 = Color.Yellow
                NewTaskForm.DateLabel.StateCommon.ShortText.Color1 = Color.White
                NewTaskForm.chooseFileLabel.StateNormal.ShortText.Color1 = Color.Yellow
                NewTaskForm.TypeOfTaskLabel.StateNormal.ShortText.Color1 = Color.Yellow
                NewTaskForm.Label1.StateCommon.ShortText.Color1 = Color.White
                NewTaskForm.Label2.StateCommon.ShortText.Color1 = Color.White
                NewTaskForm.RectangleShape1.BorderColor = Color.Yellow
                NewTaskForm.RectangleShape2.BorderColor = Color.Yellow
                NewTaskForm.RectangleShape3.BorderColor = Color.Yellow
                NewTaskForm.RectangleShape4.BorderColor = Color.Yellow
                NewTaskForm.RectangleShape5.BorderColor = Color.Yellow

                MoreOptionsForm.SetEndDateGroupBox.StateNormal.Content.ShortText.Color1 = Color.Yellow
                MoreOptionsForm.DescriptionGroupBox.StateCommon.Content.ShortText.Color1 = Color.Yellow
                MoreOptionsForm.TimeOpenGroupBox.StateCommon.Content.ShortText.Color1 = Color.Yellow
                MoreOptionsForm.TaskMissedGroupBox.StateNormal.Content.ShortText.Color1 = Color.Yellow
                MoreOptionsForm.TaskMissedGroupBox.StateNormal.Content.LongText.Color1 = Color.Yellow
                MoreOptionsForm.StateGroupBox.StateNormal.Content.ShortText.Color1 = Color.Yellow
                MoreOptionsForm.NeverEndRadioButton.StateCommon.ShortText.Color1 = Color.White
                MoreOptionsForm.EndAtRadioButton.StateCommon.ShortText.Color1 = Color.White
                MoreOptionsForm.RunWhenPcOpensRadioButton.StateCommon.ShortText.Color1 = Color.White
                MoreOptionsForm.DisplayDialogAskingRadioButton.StateCommon.ShortText.Color1 = Color.White
                MoreOptionsForm.DoNothingRadioButton.StateCommon.ShortText.Color1 = Color.White
                MoreOptionsForm.ActiveRadioButton.StateCommon.ShortText.Color1 = Color.White
                MoreOptionsForm.InactiveRadioButton.StateCommon.ShortText.Color1 = Color.White
                MoreOptionsForm.KryptonLabel1.StateCommon.ShortText.Color1 = Color.White
                MoreOptionsForm.KryptonLabel1.StateCommon.LongText.Color1 = Color.Silver

                My.Settings.LabelColorsFlag = Convert.ToInt16(1)

            Case 2, 3, 5, 6
                NewTaskForm.KindOfTaskLabel.StateNormal.ShortText.Color1 = Color.Black
                NewTaskForm.ServiceLabel.StateCommon.ShortText.Color1 = Color.Black
                NewTaskForm.KryptonLabel1.StateNormal.ShortText.Color1 = Color.Black
                NewTaskForm.KryptonLabel2.StateCommon.ShortText.Color1 = Color.Black
                NewTaskForm.KryptonLabel3.StateNormal.ShortText.Color1 = Color.Black
                NewTaskForm.DateLabel.StateCommon.ShortText.Color1 = Color.Black
                NewTaskForm.chooseFileLabel.StateNormal.ShortText.Color1 = Color.Black
                NewTaskForm.TypeOfTaskLabel.StateNormal.ShortText.Color1 = Color.Black
                NewTaskForm.Label1.StateCommon.ShortText.Color1 = Color.Black
                NewTaskForm.Label2.StateCommon.ShortText.Color1 = Color.Black
                NewTaskForm.RectangleShape1.BorderColor = Color.Black
                NewTaskForm.RectangleShape2.BorderColor = Color.Black
                NewTaskForm.RectangleShape3.BorderColor = Color.Black
                NewTaskForm.RectangleShape4.BorderColor = Color.Black
                NewTaskForm.RectangleShape5.BorderColor = Color.Black

                MoreOptionsForm.SetEndDateGroupBox.StateNormal.Content.ShortText.Color1 = Color.Black
                MoreOptionsForm.DescriptionGroupBox.StateCommon.Content.ShortText.Color1 = Color.Black
                MoreOptionsForm.TimeOpenGroupBox.StateCommon.Content.ShortText.Color1 = Color.Black
                MoreOptionsForm.TaskMissedGroupBox.StateNormal.Content.ShortText.Color1 = Color.Black
                MoreOptionsForm.TaskMissedGroupBox.StateNormal.Content.LongText.Color1 = Color.Black
                MoreOptionsForm.StateGroupBox.StateNormal.Content.ShortText.Color1 = Color.Black
                MoreOptionsForm.NeverEndRadioButton.StateCommon.ShortText.Color1 = Color.Black
                MoreOptionsForm.EndAtRadioButton.StateCommon.ShortText.Color1 = Color.Black
                MoreOptionsForm.RunWhenPcOpensRadioButton.StateCommon.ShortText.Color1 = Color.Black
                MoreOptionsForm.DisplayDialogAskingRadioButton.StateCommon.ShortText.Color1 = Color.Black
                MoreOptionsForm.DoNothingRadioButton.StateCommon.ShortText.Color1 = Color.Black
                MoreOptionsForm.ActiveRadioButton.StateCommon.ShortText.Color1 = Color.Black
                MoreOptionsForm.InactiveRadioButton.StateCommon.ShortText.Color1 = Color.Black
                MoreOptionsForm.KryptonLabel1.StateCommon.ShortText.Color1 = Color.Black
                MoreOptionsForm.KryptonLabel1.StateCommon.LongText.Color1 = Color.DimGray

                My.Settings.LabelColorsFlag = Convert.ToInt16(3)
        End Select

        My.Settings.Save()
        KryptonManager.GlobalPaletteMode = My.Settings.PalletteSetting

    End Sub


    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick

        'in case we need_to_update_datagrids(because we pressed something in the tree navigator) or because the database is changed
        If m_need_to_update_datagrids Or m_master_control.m_scheduler_tasks_has_changed Then

            'get the scheduler tasks table 
            Dim scheduler_table As DataTable = m_master_control.GetFromATableAsDataTable("[Scheduler Tasks]", {"Task_ID as ID", "Type", "Program_Path as Task", "Next_Run as [Next Execution]", "Status", "Description", "End_Date"}, m_scheduled_tasks__datagrid_restrictions.ToArray())
            'create a new table which contains a task of each program(that way we can use internally many tasks to represent a single complex task)
            Dim list_of_programs As New List(Of String)
            Dim scheduler_table_to_show = scheduler_table.Copy()
            scheduler_table_to_show.Rows.Clear()

            Dim scheduler_table_rows As DataRow() = scheduler_table.Select("", "[Next Execution] ASC")
            For Each task As DataRow In scheduler_table_rows
                If Not (list_of_programs.Contains(task("Task"))) Then
                    list_of_programs.Add(task("Task"))
                    scheduler_table_to_show.ImportRow(task)
                End If

            Next

            Dim test_table As DataTable = ScheduledTasksDataGridView.DataSource

            'create the sceduler tasks data grid view

            ScheduledTasksDataGridView.DataSource = scheduler_table_to_show.Copy()
            ScheduledTasksDataGridView.AutoResizeColumns()
            m_master_control.m_scheduler_tasks_has_changed = False

            'makes sure no row is selected
            'ScheduledTasksDataGridView.ClearSelection()

        End If


        If m_need_to_update_datagrids Or m_master_control.m_log_has_changed Then
            'create the log grid view
            Dim log_table As DataTable = m_master_control.GetFromATableAsDataTable("Log", {"Action_ID as [Event ID]", "Action_Date as [Date & Time]", "Program_Name as Task", "Details"}, m_log_datagrid_restrictions.ToArray())
            Dim test_table As DataTable = LogDataGridView.DataSource

            LogDataGridView.DataSource = log_table.Copy()
            LogDataGridView.AutoResizeColumns()
            m_master_control.m_log_has_changed = False

            'sorts the Log by EventID descending order
            'so that the newest events show up on top
            LogDataGridView.Sort(LogDataGridView.Columns("Event ID"), System.ComponentModel.ListSortDirection.Descending)

            'makes sure no row is selected
            LogDataGridView.ClearSelection()

        End If

        m_need_to_update_datagrids = False

    End Sub


    Private Sub NavigationTreeView_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles NavigationTreeView.NodeMouseClick

        m_need_to_update_datagrids = True
        Dim tree_full_path As String = e.Node.Tag.ToString()

        If tree_full_path.Contains("Tasks") Then
            'it is about tasks
            m_scheduled_tasks__datagrid_restrictions = New List(Of String)
            'active or inactive???
            If tree_full_path.Contains("Active") Then
                m_scheduled_tasks__datagrid_restrictions.Add("Status = true")
            ElseIf tree_full_path.Contains("Inactive") Then
                m_scheduled_tasks__datagrid_restrictions.Add("Status = false")
            End If


            'what period does it have?? Daily,weekly, mothly, yearly or it is to run just once?
            If tree_full_path.Contains("Once") Then
                m_scheduled_tasks__datagrid_restrictions.Add("Period Like '0/0/0'")
            ElseIf tree_full_path.Contains("Daily") Then
                m_scheduled_tasks__datagrid_restrictions.Add("Period LIKE '[!0,!7,!14,!21,!28]/0/0'")
            ElseIf tree_full_path.Contains("Weekly") Then
                m_scheduled_tasks__datagrid_restrictions.Add("Period LIKE '%/0/0'")
            ElseIf tree_full_path.Contains("Monthly") Then
                m_scheduled_tasks__datagrid_restrictions.Add("Period LIKE '0/%/0'")
            ElseIf tree_full_path.Contains("Yearly") Then
                m_scheduled_tasks__datagrid_restrictions.Add("Period LIKE '0/0/%'")
            End If


            'what type is it? EXE,FILE or SERVICE
            If tree_full_path.Contains("Executable") Then
                m_scheduled_tasks__datagrid_restrictions.Add("Type = 'EXE'")
            ElseIf tree_full_path.Contains("File") Then
                m_scheduled_tasks__datagrid_restrictions.Add("Type = 'FILE'")
            ElseIf tree_full_path.Contains("Service") Then
                m_scheduled_tasks__datagrid_restrictions.Add("Type = 'SERVICE'")
            End If


        ElseIf tree_full_path.Contains("History") Then
            'it is about log/History
            m_log_datagrid_restrictions = New List(Of String)
            If tree_full_path.Contains("Added") Then
                m_log_datagrid_restrictions.Add("Details Like 'Task Added%'")
            ElseIf tree_full_path.Contains("Removed") Then
                m_log_datagrid_restrictions.Add("Details Like 'Task deleted%'")
            ElseIf tree_full_path.Contains("Successful") Then
                m_log_datagrid_restrictions.Add("Details Like '%True'")
            ElseIf tree_full_path.Contains("Unsuccessful") Then
                m_log_datagrid_restrictions.Add("Details Like '%False'")

            End If

        End If

    End Sub

    Private Sub ScheduledTasksDataGridView_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ScheduledTasksDataGridView.MouseDown

        m__row_clicked = ScheduledTasksDataGridView.HitTest(e.Location.X, e.Location.Y).RowIndex

        If e.Button = Windows.Forms.MouseButtons.Right AndAlso m__row_clicked >= 0 Then

            ScheduledTasksDataGridView.ClearSelection()
            ScheduledTasksDataGridView.Rows(m__row_clicked).Selected = True
            ScheduledTasksDataGridView.ContextMenuStrip = ScheduledTasksContextMenu

        ElseIf m__row_clicked < 0 Then
            ScheduledTasksDataGridView.ContextMenuStrip = Nothing
            Exit Sub
        End If

        'makes the Edit,Delete and Run Now buttons enabled
        'and their respective context menu items
        handleEditDeleteRunButtons(True)

    End Sub

    'handles the state of the Edit, Delete and Run Now buttons
    'and their respective context menu items
    Private Sub handleEditDeleteRunButtons(ByVal state As Boolean)
        EditTaskButton.Enabled = state
        DeleteTaskButton.Enabled = state
        RunNowButton.Enabled = state

        EditToolStripMenuItem.Enabled = state
        DeleteToolStripMenuItem.Enabled = state
        RunNowToolStripMenuItem.Enabled = state
    End Sub

    Private Sub ExportToPDFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToPDFContextMenuItem.Click
        exportToPDF(LogDataGridView)
    End Sub

    Private Sub LogDataGridView_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LogDataGridView.MouseDown


        m__row_clicked = LogDataGridView.HitTest(e.Location.X, e.Location.Y).RowIndex

        If e.Button = Windows.Forms.MouseButtons.Right AndAlso m__row_clicked >= 0 Then

            With LogDataGridView
                .ClearSelection()
                .Rows(m__row_clicked).Selected = True
                .ContextMenuStrip = LogContextMenu
            End With

        ElseIf m__row_clicked < 0 Then
            LogDataGridView.ContextMenuStrip = Nothing
            Exit Sub

        End If
    End Sub

    Private Sub DeleteTaskButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteTaskButton.Click
        deleteTask()
        ScheduledTasksDataGridView.Rows(0).Selected = True
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteContextMenuItem.Click
        deleteTask()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        deleteTask()
    End Sub

    Private Sub deleteTask()

        Dim result As DialogResult = DeleteTaskDialog.ShowDialog()

        If result = DialogResult.Yes Then
            m_master_control.DeleteTask(ScheduledTasksDataGridView.SelectedRows(0).Cells(2).Value.ToString())
        ElseIf result = DialogResult.No Then
            Exit Sub
        End If

    End Sub


    Private Sub ClearLogToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearLogContextMenuItem.Click
        'clears olokliro to Log
        m_master_control.ClearLog()
    End Sub

    Private Sub RemoveEntryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoveEntryContextMenuItem.Click
        'Removes tin selected entry
        m_master_control.RemoveEntryFromLog(LogDataGridView.SelectedRows(0).Cells(0).Value.ToString())

    End Sub


    Private Sub RunNowButton_Click(sender As System.Object, e As System.EventArgs) Handles RunNowButton.Click
        RunNowTask()
    End Sub

    Private Sub RunNowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RunNowContextMenuItem.Click
        RunNowTask()
    End Sub

    Private Sub RunNowTask()
        'runs the selected task now
        m_master_control.RunTask(ScheduledTasksDataGridView.SelectedRows(0).Cells(2).Value.ToString(), _
                                 ScheduledTasksDataGridView.SelectedRows(0).Cells(1).Value.ToString())

    End Sub


    Private Sub EditTaskButton_Click(sender As System.Object, e As System.EventArgs) Handles EditTaskButton.Click
        editTask()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditContextMenuItem.Click
        editTask()
    End Sub

#Region "edit task methods"
    'set the type and the path in the new task form
    Private Sub SetTypeAndPathForEdit(ByRef a_task As ALATasks)
        Dim type As String = a_task.type
        Dim full_path As String = a_task.program_full_path
        If type.Equals("EXE") Then
            NewTaskForm.ExecutableCheckButton.Checked = True
            NewTaskForm.chooseFileTextBox.Text = full_path

        ElseIf type.Equals("FILE") Then
            NewTaskForm.FileCheckButton.Checked = True
            NewTaskForm.chooseFileTextBox.Text = full_path

        ElseIf type.Equals("SERVICE") Then
            NewTaskForm.ServiceCheckButton.Checked = True
            NewTaskForm.ListServices()
            NewTaskForm.ServicesDataGridView.Visible = True

            'selects the appropriate row 
            NewTaskForm.ServicesDataGridView.CurrentCell = NewTaskForm.ServicesDataGridView.Rows(getServiceRow(full_path)).Cells(0)

        End If

    End Sub
    Private Sub SetStartDateForEdit(ByRef a_list_of_tasks As List(Of ALATasks))
        a_list_of_tasks.Sort()
        NewTaskForm.DatePicker.Value = a_list_of_tasks(0).next_run_date
        NewTaskForm.TimePicker.Value = a_list_of_tasks(0).next_run_date

    End Sub
    'sets period and period related thing in new tasks form
    Private Sub SetPeriodForEdit(ByRef a_task As ALATasks, ByRef a_object_type_return As String)
        'fixed or periodic tasks
        NewTaskForm.RecurrencePanel.Show()
        Dim object_type As String = a_task.GetType().ToString()

        NewTaskForm.WeekdaysDropDownButton.Visible = False
        NewTaskForm.MonthDaysDropDownButton.Visible = False
        NewTaskForm.MonthsDropDownButton.Visible = False

        If object_type.Contains("ALFixedDateTasks") Then
            NewTaskForm.OnceCheckButton.Checked = True
            a_object_type_return = "Fixed"
            NewTaskForm.RecurrencePanel.Visible = False
        Else

            Dim task As ALPeriodicTasks = a_task
            If task.m_period_in_days <> 0 Then
                'weekly tasks
                If task.m_period_in_days Mod 7 = 0 Then
                    NewTaskForm.WeeklyCheckButton.Checked = True
                    a_object_type_return = "Weekly"
                    If My.Settings.LanguageFlag.Equals("Greek") Then
                        NewTaskForm.Label2.Text = "εβδομάδες"
                    Else
                        NewTaskForm.Label2.Text = "weeks"
                    End If
                    NewTaskForm.KryptonNumericUpDown1.Value = Integer.Parse(task.m_period_in_days / 7)
                    NewTaskForm.WeekdaysDropDownButton.Visible = True
                Else
                    NewTaskForm.DailyCheckButton.Checked = True
                    a_object_type_return = "Daily"
                    If My.Settings.LanguageFlag.Equals("Greek") Then
                        NewTaskForm.Label2.Text = "μέρες"
                    Else
                        NewTaskForm.Label2.Text = "days"
                    End If
                    NewTaskForm.KryptonNumericUpDown1.Value = task.m_period_in_days

                End If

            ElseIf task.m_period_in_months <> 0 Then
                NewTaskForm.MonthlyCheckButton.Checked = True
                a_object_type_return = "Monthly"
                If My.Settings.LanguageFlag.Equals("Greek") Then
                    NewTaskForm.Label2.Text = "μήνες"
                Else
                    NewTaskForm.Label2.Text = "months"
                End If
                NewTaskForm.KryptonNumericUpDown1.Value = task.m_period_in_months
                NewTaskForm.MonthDaysDropDownButton.Visible = True
            ElseIf task.m_period_in_years <> 0 Then
                NewTaskForm.YearlyCheckButton.Checked = True
                a_object_type_return = "Yearly"
                If My.Settings.LanguageFlag.Equals("Greek") Then
                    NewTaskForm.Label2.Text = "χρόνια"
                Else
                    NewTaskForm.Label2.Text = "years"
                End If
                NewTaskForm.KryptonNumericUpDown1.Value = task.m_period_in_years
                NewTaskForm.MonthsDropDownButton.Visible = True
                NewTaskForm.MonthDaysDropDownButton.Visible = True

            End If
        End If

    End Sub
    'sets the weekly specifications on new task form
    Private Sub SetWeeklyDateSpecificationsForEdit(ByRef a_list_of_tasks As List(Of ALATasks))
        For Each task As ALATasks In a_list_of_tasks
            NewTaskForm.RecurrencePanel.Show()
            Dim the_task As ALPeriodicTasks = task
            Dim day_of_week = the_task.next_run_date.DayOfWeek
            DirectCast(NewTaskForm.WeekdaysContextMenu.Items(day_of_week), KryptonContextMenuCheckBox).Checked = True
        Next
    End Sub
    'sets the monthly specifications on new task form
    Private Sub SetMontlhyDateSpecificationsForEdit(ByRef a_list_of_tasks As List(Of ALATasks))
        For Each task As ALATasks In a_list_of_tasks
            Dim the_task As ALPeriodicTasks = task
            Dim day_of_month = the_task.next_run_date.Day - 1
            DirectCast(NewTaskForm.MonthDaysContextMenu.Items(day_of_month), KryptonContextMenuCheckBox).Checked = True
        Next
    End Sub
    'sets the yearly specifications on new task form
    Private Sub SetYearlyDateSpecificationsForEdit(ByRef a_list_of_tasks As List(Of ALATasks))
        For Each task As ALATasks In a_list_of_tasks
            Dim the_task As ALPeriodicTasks = task
            'month days
            Dim day_of_month = the_task.next_run_date.Day - 1
            DirectCast(NewTaskForm.MonthDaysContextMenu.Items(day_of_month), KryptonContextMenuCheckBox).Checked = True

            'months
            Dim month = the_task.next_run_date.Month - 1
            DirectCast(NewTaskForm.MonthsContextMenu.Items(month), KryptonContextMenuCheckBox).Checked = True
        Next
    End Sub

    'set variables in more options form
    Private Sub SetMoreOptionsForEdit(ByRef a_task As ALATasks)
        MoreOptionsForm.DescriptionTextBox.Text = a_task.description
        MoreOptionsForm.MinutesUpDown.Value = a_task.closes_after_x_minutes
        MoreOptionsForm.InactiveRadioButton.Checked = Not a_task.GetStatus()
        MoreOptionsForm.ActiveRadioButton.Checked = a_task.GetStatus()
        If a_task.if_not_run.Equals("RUN") Then
            MoreOptionsForm.RunWhenPcOpensRadioButton.Checked = True
        ElseIf a_task.if_not_run.Equals("DIALOG") Then
            MoreOptionsForm.DisplayDialogAskingRadioButton.Checked = True
        ElseIf a_task.if_not_run.Equals("NOTHING") Then
            MoreOptionsForm.DoNothingRadioButton.Checked = True
        End If
        If a_task.end_date.Equals(New Date(2099, 12, 31)) Then
            MoreOptionsForm.NeverEndRadioButton.Checked = True
        Else
            MoreOptionsForm.EndAtRadioButton.Checked = True
            MoreOptionsForm.EndAtDateTimePicker.Value = a_task.end_date
        End If
    End Sub
    'edits the task
    Private Sub editTask()



        Dim program_path As String = ScheduledTasksDataGridView.SelectedRows(0).Cells(2).Value.ToString()
        Dim list_of_tasks As List(Of ALATasks) = m_master_control.GetTasksWithFullPath(program_path)

        SetTypeAndPathForEdit(list_of_tasks(0))

        SetStartDateForEdit(list_of_tasks)


        Dim object_type As New String("")
        SetPeriodForEdit(list_of_tasks(0), object_type)


        'set the date specifications for the task
        Select Case object_type
            Case "Weekly"

                SetWeeklyDateSpecificationsForEdit(list_of_tasks)
            Case "Monthly"

                SetMontlhyDateSpecificationsForEdit(list_of_tasks)

            Case "Yearly"

                SetYearlyDateSpecificationsForEdit(list_of_tasks)
        End Select

        SetMoreOptionsForEdit(list_of_tasks(0))

        'set the languahe and make the form visible
        NewTaskForm.SetMasterControl(m_master_control)
        NewTaskForm.m_can_overwrite_task = True
        NewTaskForm.changeLanguageNewTaskForm(My.Settings.LanguageFlag)
        NewTaskForm.ShowDialog()

    End Sub
#End Region

    Private Function getServiceRow(ByVal path As String)
        Dim svcs As ServiceController() = ServiceController.GetServices()
        Dim row As Integer = 0

        For Each svc As ServiceController In svcs
            row = row + 1

            If svc.DisplayName.ToString.Equals(path) Then
                Exit For
            End If

        Next (svc)

        Return row - 1
    End Function

    'if Navigator is clicked, scheduled tasks selected row gets unselected
    'and so Edit, Delete and Run functions get disabled
    Private Sub NavigationTreeView_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavigationTreeView.Enter
        ScheduledTasksDataGridView.ClearSelection()
        handleEditDeleteRunButtons(False)
    End Sub

    'if Log is clicked, scheduled tasks selected row gets unselected
    'and so Edit, Delete and Run functions get disabled
    Private Sub LogDataGridView_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogDataGridView.Enter
        ScheduledTasksDataGridView.ClearSelection()
        handleEditDeleteRunButtons(False)
    End Sub

    Private Sub ScheduledTasksDataGridView_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScheduledTasksDataGridView.Enter
        LogDataGridView.ClearSelection()
    End Sub

    Private Sub ViewHistoryContextMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewHistoryContextMenuItem.Click

        Dim form As ViewHistoryForm = New ViewHistoryForm
        form.Show()

    End Sub

    Private Sub createRegistryKey()
        Dim wsh
        wsh = CreateObject("WScript.Shell")
        wsh.RegWrite("HKLM\Software\Microsoft\Windows\CurrentVersion\Run\AssUI", Application.ExecutablePath.ToString())
    End Sub

    Private Sub deleteRegistryKey()
        Dim wsh
        wsh = CreateObject("WScript.Shell")
        wsh.RegDelete("HKLM\Software\Microsoft\Windows\CurrentVersion\Run\AssUI")
    End Sub

    Private Sub RunOnStartupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunOnStartupToolStripMenuItem.Click
        If RunOnStartupToolStripMenuItem.Checked = False Then
            My.Settings.RunOnStartupFlag = False
            deleteRegistryKey()
        Else
            My.Settings.RunOnStartupFlag = True
            createRegistryKey()
        End If
        My.Settings.Save()

    End Sub

    'fills the greek dictionary
    Private Sub fillGreekWords()
        With grWords
            .Add("Προσθήκη")
            .Add("Πρόσθεσε Εργασία")
            .Add("Επεξεργασία")
            .Add("Επεξεργάσου την Εργασία")
            .Add("Διαγραφή")
            .Add("Διάγραψε την Εργασία")
            .Add("Εκτέλεση")
            .Add("Εκτέλεσε τώρα την Εργασία")
            .Add("Αρχείο")
            .Add("Τρέχει στην Εκκίνηση")
            .Add("Έξοδος")
            .Add("Εργασία")
            .Add("Εμφάνιση")
            .Add("Περί")
            .Add("Προγραμματισμένες Εργασίες")
            .Add("Τύπος")
            .Add("Επόμενη Εκτέλεση")
            .Add("Κατάσταση")
            .Add("Περιγραφή")
            .Add("Τελευταία Εκτέλεση")
            .Add("Ιστορικό")
            .Add("ID Γεγονότος")
            .Add("Ημερομηνία & Ώρα")
            .Add("Αφαίρεση Καταχώρησης")
            .Add("Εξαγωγή σε αρχείο PDF")
            .Add("Εκκαθάριση Ιστορικού")
            .Add("Εργασίες")
            .Add("Εκτελέσιμο")
            .Add("Υπηρεσία")
            .Add("Μια Φορά")
            .Add("Ημερήσιες")
            .Add("Εβδομαδιαίες")
            .Add("Μηνιαίες")
            .Add("Ετήσιες")
            .Add("Ενεργές")
            .Add("Ανενεργές")
            .Add("Προστέθηκε")
            .Add("Αφαιρέθηκε")
            .Add("Επιτυχής")
            .Add("Ανεπιτυχής")
            .Add("Αναζήτηση")
            .Add("Μια Φορά")
            .Add("Ημερήσια")
            .Add("Εβδομαδιαία")
            .Add("Μηνιαία")
            .Add("Ετήσια")
            .Add("Μερες της Εβδομάδας")
            .Add("Μέρες του Μήνα")
            .Add("Μήνες")
            .Add("Αποθήκευση")
            .Add("Περισσότερα")
            .Add("Περισσότερες Επιλογές")
            .Add("Όνομα")
            .Add("Όρισε ημερομηνία λήξης")
            .Add("Ποτέ")
            .Add("Μετά από")
            .Add("επαναλήψεις")
            .Add("Την")
            .Add("Αν χαθεί η εργασία")
            .Add("(Η/Υ ήταν κλειστός)")
            .Add("Να εκτελεστεί όταν ανοίξει ο Η/Υ")
            .Add("Να εμφανίζεται παράθυρο που να με ρωτάει")
            .Add("Να μη συμβαίνει τίποτα")
            .Add("Εισαγωγή Περιγραφής για την εργασία")
            .Add("Ενεργή")
            .Add("Ανενεργή")
            .Add("Πόση ώρα θα παραμείνει το πρόγραμμα ανοιχτό;")
            .Add("λεπτά")
            .Add("(0 = δε θα κλείσει ποτέ)")
            .Add("Διαγραφή Εργασίας")
            .Add("Είσαι σίγουρος ότι θέλεις να διαγράψεις αυτή την εργασία;")
            .Add("Καλως ήρθες")
            .Add("Πρόσθεσε Εργασία")
            .Add("Να μην εμφανιστεί ξανά αυτό το παράθυρο")
            .Add("Επιτυχία!!!")
            .Add("Η εργασία αποθηκεύτηκε επιτυχώς!")
            .Add("Αποθήκευση Νέας Εργασίας")
            .Add("Είσαι σίγουρος ότι θέλεις να αποθηκεύσεις αυτή την εργασία;")
            .Add("Η ώρα άλλαξε αυτόματα")
            .Add("Τι είδους εργασία θέλεις να προσθέσεις;")
            .Add("Παρακαλώ επιλέξτε μια Υπηρεσία")
            .Add("Παρακαλώ επιλέξτε ένα αρχείο")
            .Add("Παρακαλώ επιλέξτε την αρχική ημερομηνία και ώρα")
            .Add("Ημ/νία:")
            .Add("Ώρα:")
            .Add("Τι τύπος εργασίας θέλετε να είναι; ")
            .Add("Παρακαλώ επιλέξτε τη συχνότητα της εργασίας")
            .Add("Κάθε ")
            .Add("μέρες")
            .Add("Δες το ιστορικό της")
            .Add("Ιστορικό της εργασίας: ")
            .Add("Περιηγητής")
            .Add("Να μην εμφανιστεί ξανά αυτό το παράθυρο")
            .Add("Πρόσθεσε εργασία")
            .Add("Καλως ήλθες")
            .Add("Προσοχή!")
            .Add("Η εργασία υπάρχει ήδη!")
            .Add("Επίλεξε μια άλλη ή επεξεργάσου την υπάρχουσα")
        End With
    End Sub

    'returns the greek dictionary
    Friend Function getGreekDictionary() As List(Of String)
        Return grWords
    End Function

    'fills the english dictionary
    Private Sub fillEnglishWords()
        With engWords
            .Add("Add Task")
            .Add("Add New Task")
            .Add("Edit Task")
            .Add("Edit Selected Task")
            .Add("Delete Task")
            .Add("Delete selected Task")
            .Add("Run Now")
            .Add("Run selected Task Now")
            .Add("File")
            .Add("Run on Startup")
            .Add("Exit")
            .Add("Task")
            .Add("View")
            .Add("About")
            .Add("Scheduled Tasks")
            .Add("Type")
            .Add("Next Execution")
            .Add("Status")
            .Add("Description")
            .Add("End_Date")
            .Add("Log")
            .Add("Event ID")
            .Add("Date & Time")
            .Add("Remove Entry")
            .Add("Export to PDF")
            .Add("Clear Log")
            .Add("Tasks")
            .Add("Executable")
            .Add("Service")
            .Add("Once")
            .Add("Daily")
            .Add("Weekly")
            .Add("Monthly")
            .Add("Yearly")
            .Add("Active")
            .Add("Inactive")
            .Add("Added")
            .Add("Removed")
            .Add("Successful")
            .Add("Unsuccessful")
            .Add("Browse")
            .Add("Once")
            .Add("Daily")
            .Add("Weekly")
            .Add("Monthly")
            .Add("Yearly")
            .Add("Weekdays")
            .Add("Month Days")
            .Add("Months")
            .Add("Save")
            .Add("More Options")
            .Add("Customize your task even more")
            .Add("Name")
            .Add("Set End Date")
            .Add("Never End")
            .Add("End after")
            .Add("occurences")
            .Add("End at")
            .Add("If task is missed")
            .Add("(PC was closed)")
            .Add("Run when PC opens")
            .Add("Display dialog asking")
            .Add("Do Nothing")
            .Add("Enter a description for your task")
            .Add("Active")
            .Add("Inactive")
            .Add("How much time will the program remain open?")
            .Add("minutes")
            .Add("(0 = will never close)")
            .Add("Delete Task")
            .Add("Are you sure you want to completely remove this task?")
            .Add("Welcome")
            .Add("Add Task")
            .Add("Do not show this window again")
            .Add("Success!!!")
            .Add("Task saved successfully!")
            .Add("Save New Task")
            .Add("Are you sure you want to save this task?")
            .Add("Time Changed")
            .Add("What kind of task would like to add?")
            .Add("Please choose a Service")
            .Add("Please choose a file")
            .Add("Please choose start date and time for the task!")
            .Add("Date:")
            .Add("Time:")
            .Add("What type of task do you want it to be? ")
            .Add("Please choose the recurrence of the task")
            .Add("Every ")
            .Add("days")
            .Add("View History")
            .Add("History of task: ")
            .Add("Navigator")
            .Add("Do not show this window again")
            .Add("Add Task")
            .Add("Welcome")
            .Add("Warning!")
            .Add("Task Already Exists!")
            .Add("Choose a different task or edit the existing one.")
        End With

    End Sub

    'returns the english dictionary
    Friend Function getEnglishDictionary() As List(Of String)
        Return engWords
    End Function

    Private Sub greekFlagCheckButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles greekFlagCheckButton.Click
        My.Settings.LanguageFlag = "Greek"
        langBackgroundWorker.RunWorkerAsync()
    End Sub

    Private Sub USFlagCheckButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USFlagCheckButton.Click
        My.Settings.LanguageFlag = "English"
        langBackgroundWorker.RunWorkerAsync()
    End Sub

    'does the actual change of language
    'in a different thread, so our window doesn't get stuck
    Private Sub langBackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles langBackgroundWorker.DoWork
        Dim dictionary As New List(Of String)
        Select Case My.Settings.LanguageFlag
            Case "Greek"
                dictionary = getGreekDictionary()
                USFlagCheckButton.Enabled = False    'so the user can't press it, because exceptions arise
            Case "English"
                dictionary = getEnglishDictionary()
                greekFlagCheckButton.Enabled = False 'so the user can't press it, because exceptions arise
        End Select

        '========================= MAIN FORM ========================================

        'Main Buttons-------------------------------------------------------
        AddTaskButton.Text = dictionary(0)
        EditTaskButton.Text = dictionary(2)
        DeleteTaskButton.Text = dictionary(4)
        RunNowButton.Text = dictionary(6)

        With ToolTip1
            .SetToolTip(AddTaskButton, dictionary(1))
            .SetToolTip(EditTaskButton, dictionary(3))
            .SetToolTip(DeleteTaskButton, dictionary(5))
            .SetToolTip(RunNowButton, dictionary(7))
        End With
        'End Main Butonns---------------------------------------------------

        'ToolStrip MenuItems------------------------------------------------
        FileToolStripMenuItem.Text = dictionary(8)
        RunOnStartupToolStripMenuItem.Text = dictionary(9)
        ExitToolStripMenuItem1.Text = dictionary(10)

        TaskToolStripMenuItem.Text = dictionary(11)
        AddToolStripMenuItem.Text = dictionary(0)
        EditToolStripMenuItem.Text = dictionary(2)
        DeleteToolStripMenuItem.Text = dictionary(4)
        RunNowToolStripMenuItem.Text = dictionary(6)

        ViewToolStripMenuItem.Text = dictionary(12)
        AboutToolStripMenuItem.Text = dictionary(13)
        'End ToolStrip MenuItems--------------------------------------------

        'ScheduledTasks DataGridView----------------------------------------
        ScheduledTasksHeaderGroup.ValuesPrimary.Heading = dictionary(14)
        With ScheduledTasksDataGridView
            .Columns(1).HeaderText = dictionary(15)
            .Columns(2).HeaderText = dictionary(11)
            .Columns(3).HeaderText = dictionary(16)
            .Columns(4).HeaderText = dictionary(17)
            .Columns(5).HeaderText = dictionary(18)
            .Columns(6).HeaderText = dictionary(19)
            .AutoResizeColumns()
        End With

        EditContextMenuItem.Text = dictionary(2)
        DeleteContextMenuItem.Text = dictionary(4)
        RunNowContextMenuItem.Text = dictionary(6)
        ViewHistoryContextMenuItem.Text = dictionary(89)
        'End ScheduledTasks DataGridView------------------------------------

        'LogDataGridView DataGridView----------------------------------------
        LogHeaderGroup.ValuesPrimary.Heading = dictionary(20)
        With LogDataGridView
            .Columns(0).HeaderText = dictionary(21)
            .Columns(1).HeaderText = dictionary(22)
            .Columns(2).HeaderText = dictionary(11)
            .Columns(3).HeaderText = dictionary(18)
            .AutoResizeColumns()
        End With

        RemoveEntryContextMenuItem.Text = dictionary(23)
        ExportToPDFContextMenuItem.Text = dictionary(24)
        RunNowContextMenuItem.Text = dictionary(6)
        ClearLogContextMenuItem.Text = dictionary(25)
        'End LogDataGridView DataGridView------------------------------------

        'TreeView-----------------------------------------------------------
        NavigateHeaderGroup.ValuesPrimary.Heading = dictionary(91)
        NavigationTreeView.Nodes(0).Text = dictionary(26)
        NavigationTreeView.Nodes(1).Text = dictionary(20)

        For Each node In NavigationTreeView.Nodes(1).Nodes
            If node.tag.ToString.Contains("Added") Then
                node.text = dictionary(36)
                Continue For
            ElseIf node.tag.ToString.Contains("Removed") Then
                node.text = dictionary(37)
                Continue For
            ElseIf node.tag.ToString.Contains("Successful") Then
                node.text = dictionary(38)
                Continue For
            ElseIf node.tag.ToString.Contains("Unsuccessful") Then
                node.text = dictionary(39)
                Continue For
            End If
        Next

        For Each node In NavigationTreeView.Nodes(0).Nodes

            For Each subnode In node.Nodes

                For Each subsubnode In subnode.Nodes

                    If subsubnode.tag.ToString.Contains("Executable") Then
                        subsubnode.text = dictionary(27)
                        Continue For
                    ElseIf subsubnode.tag.ToString.Contains("File") Then
                        subsubnode.text = dictionary(8)
                        Continue For
                    ElseIf subsubnode.tag.ToString.Contains("Service") Then
                        subsubnode.text = dictionary(28)
                        Continue For
                    End If

                Next

                If subnode.tag.ToString.Contains("Once") Then
                    subnode.text = dictionary(29)
                    Continue For
                ElseIf subnode.tag.ToString.Contains("Daily") Then
                    subnode.text = dictionary(30)
                    Continue For
                ElseIf subnode.tag.ToString.Contains("Weekly") Then
                    subnode.text = dictionary(31)
                    Continue For
                ElseIf subnode.tag.ToString.Contains("Monthly") Then
                    subnode.text = dictionary(32)
                    Continue For
                ElseIf subnode.tag.ToString.Contains("Yearly") Then
                    subnode.text = dictionary(33)
                    Continue For
                End If

            Next

            If node.tag.ToString.Contains("Active") Then
                node.text = dictionary(34)
                Continue For
            ElseIf node.tag.ToString.Contains("Inactive") Then
                node.text = dictionary(35)
            End If

        Next

        'End TreeView-----------------------------------------------

        'No Scheduled Tasks task dialog---------
        With NoScheduledTaskDialog
            .WindowTitle = dictionary(71)
            .MainInstruction = dictionary(72)
            .CheckboxText = dictionary(73)
        End With
        'end No Scheduled Tasks task dialog----

        'Delete task dialog------------------------------
        With DeleteTaskDialog
            .WindowTitle = dictionary(4)
            .MainInstruction = dictionary(69)
            .Content = dictionary(70)
        End With
        'end delete task --------------------------------

        'END ========================= MAIN FORM =====================================

        My.Settings.Save()
    End Sub

    Private Sub langBackgroundWorker_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles langBackgroundWorker.RunWorkerCompleted
        USFlagCheckButton.Enabled = True
        greekFlagCheckButton.Enabled = True
    End Sub

    'it executes once
    'the time that ScheduledTasks DataGridView is completely filled
    'then it changes the language according to the user's choice
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles languageOnStartTimer.Tick

        If ScheduledTasksDataGridView.RowCount > 0 Then
            checkLanguage()
            languageOnStartTimer.Stop()
        End If

    End Sub


    Private Sub CheckMissedTasks()

        Dim tasks_that_are_missed As List(Of ALATasks) = m_master_control.CheckTasks()

        For Each task As ALATasks In tasks_that_are_missed
            If task.if_not_run = "RUN" Then
                m_master_control.RunTask(task.program_full_path, task.type)

            ElseIf task.if_not_run = "DIALOG" Then

                If My.Settings.LanguageFlag.Equals("Greek") Then

                    With MissedTasksTaskDialog
                        .MainInstruction = "Πως να χειριστώ τη χαμένη εργασία;"
                        .WindowTitle = "Χάθηκε η Εργασία!"
                        .Content = "Η εργασία: " + task.program_full_path + " χάθηκε!" + vbCrLf + "Θέλεις να την τρέξω τώρα;"
                    End With

                ElseIf My.Settings.LanguageFlag.Equals("English") Then

                    MissedTasksTaskDialog.Content = "Task: " + task.program_full_path + " got missed!" + vbCrLf + "Do you want me to run it now?"

                End If

                If MissedTasksTaskDialog.ShowDialog = DialogResult.Yes Then
                    m_master_control.RunTask(task.program_full_path, task.type)
                End If

            End If

            m_master_control.UpdateNextRuns()

        Next

    End Sub

    Private Sub ButtonSpecHeaderGroup3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSpecHeaderGroup3.Click

        saveToXML_FileDialog.ShowDialog()

        Dim dt As New DataTable
        dt = LogDataGridView.DataSource
        dt.TableName = "LOG"
        dt.WriteXml(saveToXML_FileDialog.FileName)
    End Sub
End Class


