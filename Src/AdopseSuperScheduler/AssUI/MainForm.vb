Imports ComponentFactory.Krypton.Toolkit
Imports AssLogic
Imports CompletIT.Windows.Forms.Export.Pdf
Imports CompletIT.Windows.Forms.Export



Public Class MainForm

    Dim m_master_control As ALMasterControl

    Dim m_scheduled_tasks__datagrid_restrictions As List(Of String)
    Dim m_log_datagrid_restrictions As List(Of String)
    Dim m_need_to_update_datagrids As Boolean = True

    Private _widthLeftRight As Integer
    Private _heightUpDown As Integer




    Private Sub ButtonSpecHeaderGroup1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSpecHeaderGroup1.Click
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

    Private Sub ButtonSpecHeaderGroup2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSpecHeaderGroup2.Click
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

    Private Sub AddTaskButton_Click(sender As System.Object, e As System.EventArgs) Handles AddTaskButton.Click
        NewTaskForm.SetMasterControl(m_master_control)
        NewTaskForm.ShowDialog()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddToolStripMenuItem.Click
        NewTaskForm.SetMasterControl(m_master_control)
        NewTaskForm.ShowDialog()
    End Sub


    'expands the tree view nodes Task and History on startup
    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        m_scheduled_tasks__datagrid_restrictions = New List(Of String)
        m_log_datagrid_restrictions = New List(Of String)

        KryptonManager.GlobalPaletteMode = My.Settings.PalletteSetting

        'checks which pallette mode has been chosen
        checkPalletteMode()

        'changes the labels' and rectangleShapes' color
        changeLabelColors(My.Settings.LabelColorsFlag)

        m_master_control = New ALMasterControl()
        m_master_control.Init()
        ScheduledTasksDataGridView.Columns.Clear()
        LogDataGridView.Columns.Clear()

        Timer.Start()

        m_master_control.StartProgramLoop()


        NavigationTreeView.Nodes(0).Expand()
        NavigationTreeView.Nodes(1).Expand()


        checkIfTasksAreEmpty()

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

            NoScheduledTaskDialog.Content = "It seems that you don't have a task scheduled." & vbCrLf & "Would you like to add a task now?"
            Dim result As DialogResult = NoScheduledTaskDialog.ShowDialog()

            If result = DialogResult.Yes Then
                NewTaskForm.SetMasterControl(m_master_control)
                NewTaskForm.ShowDialog()
            End If

            If NoScheduledTaskDialog.CheckboxState = True Then
                My.Settings.NoScheduledTaskDialogFlag = False
            End If

        End If
    End Sub

    'changes the default action of the X button
    'instead of closing the programm it hides it in the tray
    Private Sub MainForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub ExitContextMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitContextMenuItem.Click

        TrayIcon.Dispose()

        'Me.Close() doesn't work because 
        'it is captured by the FormCLosing event
        System.Windows.Forms.Application.Exit()

    End Sub

    Private Sub TrayIcon_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles TrayIcon.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem1.Click

        TrayIcon.Dispose()

        'Me.Close() doesn't work because 
        'it is captured by the FormCLosing event
        System.Windows.Forms.Application.Exit()

    End Sub

    Private Sub LogButtonSpecExportToPDF_Click(sender As System.Object, e As System.EventArgs) Handles LogButtonSpecExportToPDF.Click

        exportToPDF()

    End Sub

    Private Sub exportToPDF()

        'You can export any DataGridView control, no matter managed or not by the extension
        Dim pdfExporter As DGVEPdfExporter = New DGVEPdfExporter()
        Dim dialog As DGVEBaseExportSettingsEditorForm = DGVEExportSettingsEditorFormBuilder.CreateWrappingForm(pdfExporter)
        dialog.Settings = New DGVEPdfExportSettings()
        If (DialogResult.OK <> dialog.ShowDialog()) Then
            Return
        End If

        AddHandler pdfExporter.ExportFailed, AddressOf exporter_ExportFailed
        pdfExporter.Export(LogDataGridView, dialog.Settings)

    End Sub

    Private Sub exporter_ExportFailed(ByVal sender As Object, ByVal e As CompletIT.Windows.Forms.Export.ExportFailedEventArgs)
        'Show message box with the occured exception 
        MessageBox.Show(e.Exception.Message)
    End Sub

    Private Sub office2010BlackToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles office2010BlackToolStripMenuItem.Click

        changePalletteMode(1)
        changeLabelColors(1)

    End Sub

    Private Sub office2010BlueToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles office2010BlueToolStripMenuItem.Click

        changePalletteMode(2)
        changeLabelColors(2)

    End Sub

    Private Sub office2010SilverToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles office2010SilverToolStripMenuItem.Click

        changePalletteMode(3)
        changeLabelColors(3)

    End Sub

    Private Sub office2007BlackToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles office2007BlackToolStripMenuItem.Click

        changePalletteMode(4)
        changeLabelColors(4)

    End Sub

    Private Sub office2007BlueToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles office2007BlueToolStripMenuItem.Click

        changePalletteMode(5)
        changeLabelColors(5)

    End Sub

    Private Sub office2007SilverToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles office2007SilverToolStripMenuItem.Click

        changePalletteMode(6)
        changeLabelColors(6)

    End Sub

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
    Private Sub changeLabelColors(ByVal i As Integer)
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
                MoreOptionsForm.EndAfterRadioButton.StateCommon.ShortText.Color1 = Color.White
                MoreOptionsForm.EndAtRadioButton.StateCommon.ShortText.Color1 = Color.White
                MoreOptionsForm.occurencesLabel.StateCommon.ShortText.Color1 = Color.White
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
                MoreOptionsForm.EndAfterRadioButton.StateCommon.ShortText.Color1 = Color.Black
                MoreOptionsForm.occurencesLabel.StateCommon.ShortText.Color1 = Color.Black
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
            For Each task As DataRow In scheduler_table.Rows
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

        End If



        If m_need_to_update_datagrids Or m_master_control.m_log_has_changed Then
            'create the log grid view
            Dim log_table As DataTable = m_master_control.GetFromATableAsDataTable("Log", {"Action_ID as [Event ID]", "Action_Date as [Date & Time]", "Program_Name as Task", "Details"}, m_log_datagrid_restrictions.ToArray())
            Dim test_table As DataTable = LogDataGridView.DataSource

            LogDataGridView.DataSource = log_table.Copy()
            LogDataGridView.AutoResizeColumns()
            m_master_control.m_log_has_changed = False
        End If

        m_need_to_update_datagrids = False

    End Sub


    Private Sub NavigationTreeView_NodeMouseClick(sender As System.Object, e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles NavigationTreeView.NodeMouseClick
        m_need_to_update_datagrids = True
        Dim tree_full_path As String = e.Node.FullPath


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

    Private Sub ScheduledTasksDataGridView_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles ScheduledTasksDataGridView.MouseDown

        Dim rowClicked As Integer
        rowClicked = ScheduledTasksDataGridView.HitTest(e.Location.X, e.Location.Y).RowIndex

        If e.Button = Windows.Forms.MouseButtons.Right AndAlso rowClicked >= 0 Then

            ScheduledTasksDataGridView.ClearSelection()
            ScheduledTasksDataGridView.Rows(rowClicked).Selected = True
            ScheduledTasksDataGridView.ContextMenuStrip = ScheduledTasksContextMenu

        ElseIf rowClicked < 0 Then
            ScheduledTasksDataGridView.ContextMenuStrip = Nothing
            Exit Sub
        End If

        EditTaskButton.Enabled = True
        DeleteTaskButton.Enabled = True
        RunNowButton.Enabled = True

        EditToolStripMenuItem.Enabled = True
        DeleteToolStripMenuItem.Enabled = True
        RunNowToolStripMenuItem.Enabled = True

    End Sub

    Private Sub ExportToPDFToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportToPDFContextMenuItem.Click
        exportToPDF()
    End Sub

    Private Sub LogDataGridView_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles LogDataGridView.MouseDown

        Dim rowClicked As Integer
        rowClicked = LogDataGridView.HitTest(e.Location.X, e.Location.Y).RowIndex

        If e.Button = Windows.Forms.MouseButtons.Right AndAlso rowClicked >= 0 Then

            LogDataGridView.ClearSelection()
            LogDataGridView.Rows(rowClicked).Selected = True
            LogDataGridView.ContextMenuStrip = LogContextMenu

        ElseIf rowClicked < 0 Then
            LogDataGridView.ContextMenuStrip = Nothing
            Exit Sub

        End If
    End Sub

    Private Sub DeleteTaskButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteTaskButton.Click
        deleteTask()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteContextMenuItem.Click
        deleteTask()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        deleteTask()
    End Sub

    'BIZELIS EDW
    Private Sub deleteTask()

        Dim result As DialogResult = DeleteTaskDialog.ShowDialog()

        If result = DialogResult.Yes Then

            'edw o kwdikas pou kanei delete to task

        ElseIf result = DialogResult.No Then

            Exit Sub

        End If

    End Sub

    'BIZELIS EDW
    Private Sub ClearLogToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearLogContextMenuItem.Click
        'clears olokliro to Log
    End Sub

    'BIZELIS EDW
    Private Sub RemoveEntryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoveEntryContextMenuItem.Click
        'Removes tin selected entry
        'LogDataGridView.CurrentRow logika
    End Sub

    Private Sub RunNowButton_Click(sender As System.Object, e As System.EventArgs) Handles RunNowButton.Click
        RunNowTask()
    End Sub

    Private Sub RunNowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RunNowContextMenuItem.Click
        RunNowTask()
    End Sub

    'BIZELIS EDW
    Private Sub RunNowTask()
        'runs the selected task now
    End Sub

    Private Sub EditTaskButton_Click(sender As System.Object, e As System.EventArgs) Handles EditTaskButton.Click
        editTask()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditContextMenuItem.Click
        editTask()
    End Sub

    'BIZELIS EDW
    Private Sub editTask()
        'edits the task
    End Sub

End Class
