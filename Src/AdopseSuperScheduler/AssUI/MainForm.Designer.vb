<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Executable")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("File")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Service")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Once", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Executable")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("File")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Service")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Daily", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Executable")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("File")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Service")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Weekly", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10, TreeNode11})
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Executable")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("File")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Service")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Monthly", New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14, TreeNode15})
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Executable")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("File")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Service")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Yearly", New System.Windows.Forms.TreeNode() {TreeNode17, TreeNode18, TreeNode19})
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Active", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode8, TreeNode12, TreeNode16, TreeNode20})
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Executable")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("File")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Service")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Once", New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode23, TreeNode24})
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Executable")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("File")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Service")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Daily", New System.Windows.Forms.TreeNode() {TreeNode26, TreeNode27, TreeNode28})
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Executable")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("File")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Service")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Weekly", New System.Windows.Forms.TreeNode() {TreeNode30, TreeNode31, TreeNode32})
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Executable")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("File")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Service")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Monthly", New System.Windows.Forms.TreeNode() {TreeNode34, TreeNode35, TreeNode36})
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Executable")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("File")
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Service")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Yearly", New System.Windows.Forms.TreeNode() {TreeNode38, TreeNode39, TreeNode40})
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Inactive", New System.Windows.Forms.TreeNode() {TreeNode25, TreeNode29, TreeNode33, TreeNode37, TreeNode41})
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tasks", New System.Windows.Forms.TreeNode() {TreeNode21, TreeNode42})
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Added")
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Removed")
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Successful")
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Unsuccessful")
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("History", New System.Windows.Forms.TreeNode() {TreeNode44, TreeNode45, TreeNode46, TreeNode47})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LowerPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.NavigateHeaderGroup = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.NavigationTreeView = New ComponentFactory.Krypton.Toolkit.KryptonTreeView()
        Me.KryptonSplitContainer2 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.ScheduledTasksHeaderGroup = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.ScheduledTasksDataGridView = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.taskID_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taskGenre_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Task_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NextExecution_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.close_after = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.end_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogHeaderGroup = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.LogButtonSpecExportToPDF = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.ButtonSpecHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.LogDataGridView = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.EventID_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTime_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaskName_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Details_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.UpperPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.AddTaskButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.RunNowButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.EditTaskButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.DeleteTaskButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.office2010BlackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.office2010BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.office2010SilverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.office2007BlackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.office2007BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.office2007SilverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdopseSuperSchedulerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TrayContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.NoScheduledTaskDialog = New ComponentFactory.Krypton.Toolkit.KryptonTaskDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ScheduledTasksContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunNowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.LowerPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LowerPanel.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.NavigateHeaderGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavigateHeaderGroup.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigateHeaderGroup.Panel.SuspendLayout()
        Me.NavigateHeaderGroup.SuspendLayout()
        CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer2.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer2.Panel2.SuspendLayout()
        Me.KryptonSplitContainer2.SuspendLayout()
        CType(Me.ScheduledTasksHeaderGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScheduledTasksHeaderGroup.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ScheduledTasksHeaderGroup.Panel.SuspendLayout()
        Me.ScheduledTasksHeaderGroup.SuspendLayout()
        CType(Me.ScheduledTasksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogHeaderGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogHeaderGroup.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LogHeaderGroup.Panel.SuspendLayout()
        Me.LogHeaderGroup.SuspendLayout()
        CType(Me.LogDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpperPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UpperPanel.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.TrayContextMenu.SuspendLayout()
        Me.ScheduledTasksContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'LowerPanel
        '
        Me.LowerPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LowerPanel.Controls.Add(Me.KryptonSplitContainer1)
        Me.LowerPanel.Location = New System.Drawing.Point(0, 93)
        Me.LowerPanel.Name = "LowerPanel"
        Me.LowerPanel.Size = New System.Drawing.Size(1036, 484)
        Me.LowerPanel.TabIndex = 0
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.NavigateHeaderGroup)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonSplitContainer2)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1036, 484)
        Me.KryptonSplitContainer1.SplitterDistance = 185
        Me.KryptonSplitContainer1.TabIndex = 0
        '
        'NavigateHeaderGroup
        '
        Me.NavigateHeaderGroup.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup1})
        Me.NavigateHeaderGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigateHeaderGroup.HeaderVisibleSecondary = False
        Me.NavigateHeaderGroup.Location = New System.Drawing.Point(0, 0)
        Me.NavigateHeaderGroup.Name = "NavigateHeaderGroup"
        '
        'NavigateHeaderGroup.Panel
        '
        Me.NavigateHeaderGroup.Panel.Controls.Add(Me.NavigationTreeView)
        Me.NavigateHeaderGroup.Size = New System.Drawing.Size(185, 484)
        Me.NavigateHeaderGroup.TabIndex = 0
        Me.NavigateHeaderGroup.ValuesPrimary.Heading = "Navigator"
        Me.NavigateHeaderGroup.ValuesPrimary.Image = Nothing
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowLeft
        Me.ButtonSpecHeaderGroup1.UniqueName = "ADE89D3B4C6940E368BFC99A4BF2C345"
        '
        'NavigationTreeView
        '
        Me.NavigationTreeView.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuHeading
        Me.NavigationTreeView.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.FormMain
        Me.NavigationTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationTreeView.ItemHeight = 21
        Me.NavigationTreeView.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.InputControl
        Me.NavigationTreeView.Location = New System.Drawing.Point(0, 0)
        Me.NavigationTreeView.Name = "NavigationTreeView"
        TreeNode1.Name = "A_O_ExecutableNode"
        TreeNode1.Text = "Executable"
        TreeNode2.Name = "A_O_FileNode"
        TreeNode2.Text = "File"
        TreeNode3.Name = "A_O_ServiceNode"
        TreeNode3.Text = "Service"
        TreeNode4.Name = "A_OnceNode"
        TreeNode4.Text = "Once"
        TreeNode5.Name = "A_D_ExecutableNode"
        TreeNode5.Text = "Executable"
        TreeNode6.Name = "A_D_FileNode"
        TreeNode6.Text = "File"
        TreeNode7.Name = "A_D_ServiceNode"
        TreeNode7.Text = "Service"
        TreeNode8.Name = "A_DailyNode"
        TreeNode8.Text = "Daily"
        TreeNode9.Name = "A_W_ExecutableNode"
        TreeNode9.Text = "Executable"
        TreeNode10.Name = "A_W_FileNode"
        TreeNode10.Text = "File"
        TreeNode11.Name = "A_W_ServiceNode"
        TreeNode11.Text = "Service"
        TreeNode12.Name = "A_WeeklyNode"
        TreeNode12.Text = "Weekly"
        TreeNode13.Name = "A_M_ExecutableNode"
        TreeNode13.Text = "Executable"
        TreeNode14.Name = "A_M_FileNode"
        TreeNode14.Text = "File"
        TreeNode15.Name = "A_M_ServiceNode"
        TreeNode15.Text = "Service"
        TreeNode16.Name = "A_MonthlyNode"
        TreeNode16.Text = "Monthly"
        TreeNode17.Name = "A_Y_ExecutableNode"
        TreeNode17.Text = "Executable"
        TreeNode18.Name = "A_Y_FileNode"
        TreeNode18.Text = "File"
        TreeNode19.Name = "A_Y_ServiceNode"
        TreeNode19.Text = "Service"
        TreeNode20.Name = "A_YearlyNode"
        TreeNode20.Text = "Yearly"
        TreeNode21.Name = "ActiveNode"
        TreeNode21.Text = "Active"
        TreeNode22.Name = "I_O_ExecutableNode"
        TreeNode22.Text = "Executable"
        TreeNode23.Name = "I_O_FileNode"
        TreeNode23.Text = "File"
        TreeNode24.Name = "I_O_ServiceNode"
        TreeNode24.Text = "Service"
        TreeNode25.Name = "I_OnceNode"
        TreeNode25.Text = "Once"
        TreeNode26.Name = "I_D_ExecutableNode"
        TreeNode26.Text = "Executable"
        TreeNode27.Name = "I_D_FileNode"
        TreeNode27.Text = "File"
        TreeNode28.Name = "I_D_ServiceNode"
        TreeNode28.Text = "Service"
        TreeNode29.Name = "I_DailyNode"
        TreeNode29.Text = "Daily"
        TreeNode30.Name = "I_W_ExecutableNode"
        TreeNode30.Text = "Executable"
        TreeNode31.Name = "I_W_FileNode"
        TreeNode31.Text = "File"
        TreeNode32.Name = "I_W_ServiceNode"
        TreeNode32.Text = "Service"
        TreeNode33.Name = "I_WeeklyNode"
        TreeNode33.Text = "Weekly"
        TreeNode34.Name = "I_M_ExecutableNode"
        TreeNode34.Text = "Executable"
        TreeNode35.Name = "I_M_FileNode"
        TreeNode35.Text = "File"
        TreeNode36.Name = "I_M_ServiceNode"
        TreeNode36.Text = "Service"
        TreeNode37.Name = "I_MonthlyNode"
        TreeNode37.Text = "Monthly"
        TreeNode38.Name = "I_Y_ExecutableNode"
        TreeNode38.Text = "Executable"
        TreeNode39.Name = "I_Y_FileNode"
        TreeNode39.Text = "File"
        TreeNode40.Name = "I_Y_ServiceNode"
        TreeNode40.Text = "Service"
        TreeNode41.Name = "I_YearlyNode"
        TreeNode41.Text = "Yearly"
        TreeNode42.Name = "InactiveNode"
        TreeNode42.Text = "Inactive"
        TreeNode43.Name = "TasksNode"
        TreeNode43.Text = "Tasks"
        TreeNode44.Name = "AddedNode"
        TreeNode44.Text = "Added"
        TreeNode45.Name = "RemovedNode"
        TreeNode45.Text = "Removed"
        TreeNode46.Name = "SuccessfulNode"
        TreeNode46.Text = "Successful"
        TreeNode47.Name = "UnsuccessfulNode"
        TreeNode47.Text = "Unsuccessful"
        TreeNode48.Name = "HistoryNode"
        TreeNode48.Text = "History"
        Me.NavigationTreeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode43, TreeNode48})
        Me.NavigationTreeView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black
        Me.NavigationTreeView.Size = New System.Drawing.Size(183, 452)
        Me.NavigationTreeView.StateCheckedNormal.Node.Back.Color1 = System.Drawing.Color.LemonChiffon
        Me.NavigationTreeView.TabIndex = 1
        '
        'KryptonSplitContainer2
        '
        Me.KryptonSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer2.Name = "KryptonSplitContainer2"
        Me.KryptonSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer2.Panel1
        '
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.ScheduledTasksHeaderGroup)
        '
        'KryptonSplitContainer2.Panel2
        '
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.LogHeaderGroup)
        Me.KryptonSplitContainer2.Size = New System.Drawing.Size(846, 484)
        Me.KryptonSplitContainer2.SplitterDistance = 241
        Me.KryptonSplitContainer2.TabIndex = 0
        '
        'ScheduledTasksHeaderGroup
        '
        Me.ScheduledTasksHeaderGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScheduledTasksHeaderGroup.HeaderVisibleSecondary = False
        Me.ScheduledTasksHeaderGroup.Location = New System.Drawing.Point(0, 0)
        Me.ScheduledTasksHeaderGroup.Name = "ScheduledTasksHeaderGroup"
        '
        'ScheduledTasksHeaderGroup.Panel
        '
        Me.ScheduledTasksHeaderGroup.Panel.Controls.Add(Me.ScheduledTasksDataGridView)
        Me.ScheduledTasksHeaderGroup.Size = New System.Drawing.Size(846, 241)
        Me.ScheduledTasksHeaderGroup.TabIndex = 0
        Me.ScheduledTasksHeaderGroup.ValuesPrimary.Heading = "Scheduled Tasks"
        Me.ScheduledTasksHeaderGroup.ValuesPrimary.Image = CType(resources.GetObject("ScheduledTasksHeaderGroup.ValuesPrimary.Image"), System.Drawing.Image)
        '
        'ScheduledTasksDataGridView
        '
        Me.ScheduledTasksDataGridView.AllowUserToAddRows = False
        Me.ScheduledTasksDataGridView.AllowUserToDeleteRows = False
        Me.ScheduledTasksDataGridView.AllowUserToOrderColumns = True
        Me.ScheduledTasksDataGridView.AllowUserToResizeRows = False
        Me.ScheduledTasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ScheduledTasksDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.taskID_Column, Me.taskGenre_Column, Me.Task_Column, Me.Type_Column, Me.NextExecution_Column, Me.Status_Column, Me.Description_Column, Me.close_after, Me.end_date})
        Me.ScheduledTasksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScheduledTasksDataGridView.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet
        Me.ScheduledTasksDataGridView.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet
        Me.ScheduledTasksDataGridView.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.ScheduledTasksDataGridView.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.ScheduledTasksDataGridView.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.ScheduledTasksDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ScheduledTasksDataGridView.Name = "ScheduledTasksDataGridView"
        Me.ScheduledTasksDataGridView.ReadOnly = True
        Me.ScheduledTasksDataGridView.RowHeadersVisible = False
        Me.ScheduledTasksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ScheduledTasksDataGridView.Size = New System.Drawing.Size(844, 208)
        Me.ScheduledTasksDataGridView.TabIndex = 1
        '
        'taskID_Column
        '
        Me.taskID_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.taskID_Column.DefaultCellStyle = DataGridViewCellStyle1
        Me.taskID_Column.FillWeight = 43.88676!
        Me.taskID_Column.HeaderText = "ID"
        Me.taskID_Column.MinimumWidth = 35
        Me.taskID_Column.Name = "taskID_Column"
        Me.taskID_Column.ReadOnly = True
        Me.taskID_Column.Width = 47
        '
        'taskGenre_Column
        '
        Me.taskGenre_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.taskGenre_Column.FillWeight = 73.15503!
        Me.taskGenre_Column.HeaderText = "Genre"
        Me.taskGenre_Column.MinimumWidth = 100
        Me.taskGenre_Column.Name = "taskGenre_Column"
        Me.taskGenre_Column.ReadOnly = True
        Me.taskGenre_Column.Width = 113
        '
        'Task_Column
        '
        Me.Task_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Task_Column.FillWeight = 70.88963!
        Me.Task_Column.HeaderText = "Task"
        Me.Task_Column.MinimumWidth = 100
        Me.Task_Column.Name = "Task_Column"
        Me.Task_Column.ReadOnly = True
        '
        'Type_Column
        '
        Me.Type_Column.FillWeight = 79.91032!
        Me.Type_Column.HeaderText = "Type"
        Me.Type_Column.MinimumWidth = 60
        Me.Type_Column.Name = "Type_Column"
        Me.Type_Column.ReadOnly = True
        Me.Type_Column.Width = 60
        '
        'NextExecution_Column
        '
        Me.NextExecution_Column.FillWeight = 175.4121!
        Me.NextExecution_Column.HeaderText = "Next Execution"
        Me.NextExecution_Column.MinimumWidth = 150
        Me.NextExecution_Column.Name = "NextExecution_Column"
        Me.NextExecution_Column.ReadOnly = True
        Me.NextExecution_Column.Width = 220
        '
        'Status_Column
        '
        Me.Status_Column.FillWeight = 100.7967!
        Me.Status_Column.HeaderText = "Status"
        Me.Status_Column.MinimumWidth = 65
        Me.Status_Column.Name = "Status_Column"
        Me.Status_Column.ReadOnly = True
        Me.Status_Column.Width = 90
        '
        'Description_Column
        '
        Me.Description_Column.FillWeight = 155.9494!
        Me.Description_Column.HeaderText = "Description"
        Me.Description_Column.Name = "Description_Column"
        Me.Description_Column.ReadOnly = True
        Me.Description_Column.Width = 113
        '
        'close_after
        '
        Me.close_after.HeaderText = "Remaining Runs"
        Me.close_after.Name = "close_after"
        Me.close_after.ReadOnly = True
        '
        'end_date
        '
        Me.end_date.HeaderText = "End Date"
        Me.end_date.Name = "end_date"
        Me.end_date.ReadOnly = True
        '
        'LogHeaderGroup
        '
        Me.LogHeaderGroup.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.LogButtonSpecExportToPDF, Me.ButtonSpecHeaderGroup2})
        Me.LogHeaderGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogHeaderGroup.HeaderVisibleSecondary = False
        Me.LogHeaderGroup.Location = New System.Drawing.Point(0, 0)
        Me.LogHeaderGroup.Name = "LogHeaderGroup"
        '
        'LogHeaderGroup.Panel
        '
        Me.LogHeaderGroup.Panel.Controls.Add(Me.LogDataGridView)
        Me.LogHeaderGroup.Size = New System.Drawing.Size(846, 238)
        Me.LogHeaderGroup.TabIndex = 0
        Me.LogHeaderGroup.ValuesPrimary.Heading = "Log"
        Me.LogHeaderGroup.ValuesPrimary.Image = CType(resources.GetObject("LogHeaderGroup.ValuesPrimary.Image"), System.Drawing.Image)
        '
        'LogButtonSpecExportToPDF
        '
        Me.LogButtonSpecExportToPDF.Image = CType(resources.GetObject("LogButtonSpecExportToPDF.Image"), System.Drawing.Image)
        Me.LogButtonSpecExportToPDF.ToolTipBody = "Export to PDF"
        Me.LogButtonSpecExportToPDF.ToolTipTitle = "Export to PDF"
        Me.LogButtonSpecExportToPDF.UniqueName = "A9F07FE678CB4C4657B37E40141FE193"
        '
        'ButtonSpecHeaderGroup2
        '
        Me.ButtonSpecHeaderGroup2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.ButtonSpecHeaderGroup2.UniqueName = "7B513BF4464A490AC7AAAFA253500D78"
        '
        'LogDataGridView
        '
        Me.LogDataGridView.AllowUserToAddRows = False
        Me.LogDataGridView.AllowUserToDeleteRows = False
        Me.LogDataGridView.AllowUserToOrderColumns = True
        Me.LogDataGridView.AllowUserToResizeRows = False
        Me.LogDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LogDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EventID_Column, Me.DateTime_Column, Me.TaskName_Column, Me.Details_Column})
        Me.LogDataGridView.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet
        Me.LogDataGridView.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet
        Me.LogDataGridView.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.LogDataGridView.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.LogDataGridView.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.LogDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.LogDataGridView.Name = "LogDataGridView"
        Me.LogDataGridView.ReadOnly = True
        Me.LogDataGridView.RowHeadersVisible = False
        Me.LogDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LogDataGridView.Size = New System.Drawing.Size(844, 201)
        Me.LogDataGridView.TabIndex = 0
        '
        'EventID_Column
        '
        Me.EventID_Column.HeaderText = "Event ID"
        Me.EventID_Column.MinimumWidth = 60
        Me.EventID_Column.Name = "EventID_Column"
        Me.EventID_Column.ReadOnly = True
        Me.EventID_Column.Width = 80
        '
        'DateTime_Column
        '
        Me.DateTime_Column.HeaderText = "Date & Time"
        Me.DateTime_Column.MinimumWidth = 150
        Me.DateTime_Column.Name = "DateTime_Column"
        Me.DateTime_Column.ReadOnly = True
        Me.DateTime_Column.Width = 160
        '
        'TaskName_Column
        '
        Me.TaskName_Column.HeaderText = "Task"
        Me.TaskName_Column.MinimumWidth = 100
        Me.TaskName_Column.Name = "TaskName_Column"
        Me.TaskName_Column.ReadOnly = True
        '
        'Details_Column
        '
        Me.Details_Column.HeaderText = "Details"
        Me.Details_Column.MinimumWidth = 200
        Me.Details_Column.Name = "Details_Column"
        Me.Details_Column.ReadOnly = True
        Me.Details_Column.Width = 311
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Black
        '
        'UpperPanel
        '
        Me.UpperPanel.Controls.Add(Me.AddTaskButton)
        Me.UpperPanel.Controls.Add(Me.RunNowButton)
        Me.UpperPanel.Controls.Add(Me.EditTaskButton)
        Me.UpperPanel.Controls.Add(Me.DeleteTaskButton)
        Me.UpperPanel.Controls.Add(Me.MenuStrip)
        Me.UpperPanel.Location = New System.Drawing.Point(0, 0)
        Me.UpperPanel.Name = "UpperPanel"
        Me.UpperPanel.Size = New System.Drawing.Size(1119, 93)
        Me.UpperPanel.TabIndex = 1
        '
        'AddTaskButton
        '
        Me.AddTaskButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile
        Me.AddTaskButton.Location = New System.Drawing.Point(244, 12)
        Me.AddTaskButton.Name = "AddTaskButton"
        Me.AddTaskButton.Size = New System.Drawing.Size(79, 58)
        Me.AddTaskButton.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.AddTaskButton.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.AddTaskButton, "Add New Task")
        Me.AddTaskButton.Values.Image = CType(resources.GetObject("AddTaskButton.Values.Image"), System.Drawing.Image)
        Me.AddTaskButton.Values.Text = "Add Task"
        '
        'RunNowButton
        '
        Me.RunNowButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile
        Me.RunNowButton.Location = New System.Drawing.Point(618, 12)
        Me.RunNowButton.Name = "RunNowButton"
        Me.RunNowButton.Size = New System.Drawing.Size(79, 58)
        Me.RunNowButton.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.RunNowButton.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.RunNowButton, "Run Selected Task Now")
        Me.RunNowButton.Values.Image = CType(resources.GetObject("RunNowButton.Values.Image"), System.Drawing.Image)
        Me.RunNowButton.Values.Text = "Run Now"
        '
        'EditTaskButton
        '
        Me.EditTaskButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditTaskButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile
        Me.EditTaskButton.Location = New System.Drawing.Point(365, 12)
        Me.EditTaskButton.Name = "EditTaskButton"
        Me.EditTaskButton.Size = New System.Drawing.Size(79, 58)
        Me.EditTaskButton.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.EditTaskButton.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.EditTaskButton, "Edit Selected Task")
        Me.EditTaskButton.Values.Image = CType(resources.GetObject("EditTaskButton.Values.Image"), System.Drawing.Image)
        Me.EditTaskButton.Values.Text = "Edit Task"
        '
        'DeleteTaskButton
        '
        Me.DeleteTaskButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile
        Me.DeleteTaskButton.Location = New System.Drawing.Point(489, 12)
        Me.DeleteTaskButton.Name = "DeleteTaskButton"
        Me.DeleteTaskButton.Size = New System.Drawing.Size(79, 58)
        Me.DeleteTaskButton.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.DeleteTaskButton.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.DeleteTaskButton, "Delete Selected Task")
        Me.DeleteTaskButton.Values.Image = CType(resources.GetObject("DeleteTaskButton.Values.Image"), System.Drawing.Image)
        Me.DeleteTaskButton.Values.Text = "Delete Task"
        '
        'MenuStrip
        '
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TaskToolStripMenuItem, Me.ViewToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1119, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddTaskToolStripMenuItem, Me.EditTaskToolStripMenuItem, Me.DeleteTaskToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AddTaskToolStripMenuItem
        '
        Me.AddTaskToolStripMenuItem.Name = "AddTaskToolStripMenuItem"
        Me.AddTaskToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.AddTaskToolStripMenuItem.Text = "Add Task"
        '
        'EditTaskToolStripMenuItem
        '
        Me.EditTaskToolStripMenuItem.Name = "EditTaskToolStripMenuItem"
        Me.EditTaskToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.EditTaskToolStripMenuItem.Text = "Edit Task"
        '
        'DeleteTaskToolStripMenuItem
        '
        Me.DeleteTaskToolStripMenuItem.Name = "DeleteTaskToolStripMenuItem"
        Me.DeleteTaskToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.DeleteTaskToolStripMenuItem.Text = "Delete Task"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(131, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'TaskToolStripMenuItem
        '
        Me.TaskToolStripMenuItem.Name = "TaskToolStripMenuItem"
        Me.TaskToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.TaskToolStripMenuItem.Text = "Task"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.office2010BlackToolStripMenuItem, Me.office2010BlueToolStripMenuItem, Me.office2010SilverToolStripMenuItem, Me.office2007BlackToolStripMenuItem, Me.office2007BlueToolStripMenuItem, Me.office2007SilverToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'office2010BlackToolStripMenuItem
        '
        Me.office2010BlackToolStripMenuItem.Name = "office2010BlackToolStripMenuItem"
        Me.office2010BlackToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.office2010BlackToolStripMenuItem.Text = "Office 2010 - Black"
        '
        'office2010BlueToolStripMenuItem
        '
        Me.office2010BlueToolStripMenuItem.Name = "office2010BlueToolStripMenuItem"
        Me.office2010BlueToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.office2010BlueToolStripMenuItem.Text = "Office 2010 - Blue"
        '
        'office2010SilverToolStripMenuItem
        '
        Me.office2010SilverToolStripMenuItem.Name = "office2010SilverToolStripMenuItem"
        Me.office2010SilverToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.office2010SilverToolStripMenuItem.Text = "Office 2010 - Silver"
        '
        'office2007BlackToolStripMenuItem
        '
        Me.office2007BlackToolStripMenuItem.Name = "office2007BlackToolStripMenuItem"
        Me.office2007BlackToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.office2007BlackToolStripMenuItem.Text = "Office 2007 - Black"
        '
        'office2007BlueToolStripMenuItem
        '
        Me.office2007BlueToolStripMenuItem.Name = "office2007BlueToolStripMenuItem"
        Me.office2007BlueToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.office2007BlueToolStripMenuItem.Text = "Office 2007 - Blue"
        '
        'office2007SilverToolStripMenuItem
        '
        Me.office2007SilverToolStripMenuItem.Name = "office2007SilverToolStripMenuItem"
        Me.office2007SilverToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.office2007SilverToolStripMenuItem.Text = "Office 2007 - Silver"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdopseSuperSchedulerToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AdopseSuperSchedulerToolStripMenuItem
        '
        Me.AdopseSuperSchedulerToolStripMenuItem.Name = "AdopseSuperSchedulerToolStripMenuItem"
        Me.AdopseSuperSchedulerToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.AdopseSuperSchedulerToolStripMenuItem.Text = "Adopse Super Scheduler"
        '
        'TrayIcon
        '
        Me.TrayIcon.ContextMenuStrip = Me.TrayContextMenu
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "ASScheduler"
        Me.TrayIcon.Visible = True
        '
        'TrayContextMenu
        '
        Me.TrayContextMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TrayContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitContextMenuItem})
        Me.TrayContextMenu.Name = "TrayContextMenu"
        Me.TrayContextMenu.Size = New System.Drawing.Size(104, 54)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(100, 6)
        '
        'ExitContextMenuItem
        '
        Me.ExitContextMenuItem.Name = "ExitContextMenuItem"
        Me.ExitContextMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitContextMenuItem.Text = "Exit"
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'NoScheduledTaskDialog
        '
        Me.NoScheduledTaskDialog.CheckboxText = "Do not show this window again"
        Me.NoScheduledTaskDialog.CommonButtons = CType((ComponentFactory.Krypton.Toolkit.TaskDialogButtons.Yes Or ComponentFactory.Krypton.Toolkit.TaskDialogButtons.No), ComponentFactory.Krypton.Toolkit.TaskDialogButtons)
        Me.NoScheduledTaskDialog.Content = Nothing
        Me.NoScheduledTaskDialog.CustomIcon = Global.AssUI.My.Resources.Resources.plus_circle
        Me.NoScheduledTaskDialog.DefaultButton = ComponentFactory.Krypton.Toolkit.TaskDialogButtons.Yes
        Me.NoScheduledTaskDialog.DefaultRadioButton = Nothing
        Me.NoScheduledTaskDialog.FooterHyperlink = Nothing
        Me.NoScheduledTaskDialog.FooterText = Nothing
        Me.NoScheduledTaskDialog.MainInstruction = "Add Task"
        Me.NoScheduledTaskDialog.Tag = Nothing
        Me.NoScheduledTaskDialog.WindowTitle = "Welcome"
        '
        'ScheduledTasksContextMenu
        '
        Me.ScheduledTasksContextMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ScheduledTasksContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.RunNowToolStripMenuItem, Me.ToolStripSeparator3, Me.ViewHistoryToolStripMenuItem})
        Me.ScheduledTasksContextMenu.Name = "ScheduledTasksContestMenu"
        Me.ScheduledTasksContextMenu.Size = New System.Drawing.Size(141, 98)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'RunNowToolStripMenuItem
        '
        Me.RunNowToolStripMenuItem.Name = "RunNowToolStripMenuItem"
        Me.RunNowToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.RunNowToolStripMenuItem.Text = "Run Now"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(137, 6)
        '
        'ViewHistoryToolStripMenuItem
        '
        Me.ViewHistoryToolStripMenuItem.Name = "ViewHistoryToolStripMenuItem"
        Me.ViewHistoryToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ViewHistoryToolStripMenuItem.Text = "View History"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 576)
        Me.Controls.Add(Me.UpperPanel)
        Me.Controls.Add(Me.LowerPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MainForm"
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adopse Super Scheduler"
        CType(Me.LowerPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LowerPanel.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.NavigateHeaderGroup.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigateHeaderGroup.Panel.ResumeLayout(False)
        CType(Me.NavigateHeaderGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigateHeaderGroup.ResumeLayout(False)
        CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.ResumeLayout(False)
        CType(Me.ScheduledTasksHeaderGroup.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ScheduledTasksHeaderGroup.Panel.ResumeLayout(False)
        CType(Me.ScheduledTasksHeaderGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ScheduledTasksHeaderGroup.ResumeLayout(False)
        CType(Me.ScheduledTasksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogHeaderGroup.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LogHeaderGroup.Panel.ResumeLayout(False)
        CType(Me.LogHeaderGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LogHeaderGroup.ResumeLayout(False)
        CType(Me.LogDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpperPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UpperPanel.ResumeLayout(False)
        Me.UpperPanel.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.TrayContextMenu.ResumeLayout(False)
        Me.ScheduledTasksContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LowerPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents NavigateHeaderGroup As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonSplitContainer2 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents ScheduledTasksHeaderGroup As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents LogHeaderGroup As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents NavigationTreeView As ComponentFactory.Krypton.Toolkit.KryptonTreeView
    Friend WithEvents ButtonSpecHeaderGroup2 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents UpperPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TaskToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddTaskButton As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents RunNowButton As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents DeleteTaskButton As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents EditTaskButton As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LogDataGridView As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents TrayIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents TrayContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventID_Column As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTime_Column As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaskName_Column As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Details_Column As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LogButtonSpecExportToPDF As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents AddTaskToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditTaskToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteTaskToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdopseSuperSchedulerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NoScheduledTaskDialog As ComponentFactory.Krypton.Toolkit.KryptonTaskDialog
    Friend WithEvents office2010BlackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents office2010BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents office2010SilverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents office2007BlackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents office2007BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents office2007SilverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ScheduledTasksDataGridView As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents taskID_Column As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents taskGenre_Column As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Task_Column As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type_Column As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NextExecution_Column As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status_Column As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description_Column As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents close_after As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents end_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScheduledTasksContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunNowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
