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
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Log", New System.Windows.Forms.TreeNode() {TreeNode44, TreeNode45, TreeNode46, TreeNode47})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.LowerPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.NavigateHeaderGroup = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.NavigationTreeView = New ComponentFactory.Krypton.Toolkit.KryptonTreeView()
        Me.KryptonSplitContainer2 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.ScheduledTasksHeaderGroup = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.ScheduledTasksDataGridView = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.LogHeaderGroup = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.ButtonSpecHeaderGroup3 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.LogButtonSpecExportToPDF = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.ButtonSpecHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.LogDataGridView = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.UpperPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.flagsPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.greekFlagCheckButton = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.USFlagCheckButton = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.RunNowButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.AddTaskButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.DeleteTaskButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.EditTaskButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunOnStartupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunNowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ShowContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.languageOnStartTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ScheduledTasksContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunNowContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewHistoryContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveEntryContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportToPDFContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToXMLContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearLogContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.flagCheckSet = New ComponentFactory.Krypton.Toolkit.KryptonCheckSet(Me.components)
        Me.langBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.MissedTasksTaskDialog = New ComponentFactory.Krypton.Toolkit.KryptonTaskDialog()
        Me.saveToXML_FileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.NoScheduledTaskDialog = New ComponentFactory.Krypton.Toolkit.KryptonTaskDialog()
        Me.DeleteTaskDialog = New ComponentFactory.Krypton.Toolkit.KryptonTaskDialog()
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
        CType(Me.flagsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flagsPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.TrayContextMenu.SuspendLayout()
        Me.ScheduledTasksContextMenu.SuspendLayout()
        Me.LogContextMenu.SuspendLayout()
        CType(Me.flagCheckSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.KryptonSplitContainer1.SplitterDistance = 188
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
        Me.NavigateHeaderGroup.Size = New System.Drawing.Size(188, 484)
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
        TreeNode1.Tag = "Tasks Active Once Executable"
        TreeNode1.Text = "Executable"
        TreeNode2.Name = "A_O_FileNode"
        TreeNode2.Tag = "Tasks Active Once File"
        TreeNode2.Text = "File"
        TreeNode3.Name = "A_O_ServiceNode"
        TreeNode3.Tag = "Tasks Active Once Service"
        TreeNode3.Text = "Service"
        TreeNode4.Name = "A_OnceNode"
        TreeNode4.Tag = "Tasks Active Once"
        TreeNode4.Text = "Once"
        TreeNode5.Name = "A_D_ExecutableNode"
        TreeNode5.Tag = "Tasks Active Daily Executable"
        TreeNode5.Text = "Executable"
        TreeNode6.Name = "A_D_FileNode"
        TreeNode6.Tag = "Tasks Active Daily File"
        TreeNode6.Text = "File"
        TreeNode7.Name = "A_D_ServiceNode"
        TreeNode7.Tag = "Tasks Active Daily Service"
        TreeNode7.Text = "Service"
        TreeNode8.Name = "A_DailyNode"
        TreeNode8.Tag = "Tasks Active Daily"
        TreeNode8.Text = "Daily"
        TreeNode9.Name = "A_W_ExecutableNode"
        TreeNode9.Tag = "Tasks Active Weekly Executable"
        TreeNode9.Text = "Executable"
        TreeNode10.Name = "A_W_FileNode"
        TreeNode10.Tag = "Tasks Active Weekly File"
        TreeNode10.Text = "File"
        TreeNode11.Name = "A_W_ServiceNode"
        TreeNode11.Tag = "Tasks Active Weekly Service"
        TreeNode11.Text = "Service"
        TreeNode12.Name = "A_WeeklyNode"
        TreeNode12.Tag = "Tasks Active Weekly"
        TreeNode12.Text = "Weekly"
        TreeNode13.Name = "A_M_ExecutableNode"
        TreeNode13.Tag = "Tasks Active Monthly Executable"
        TreeNode13.Text = "Executable"
        TreeNode14.Name = "A_M_FileNode"
        TreeNode14.Tag = "Tasks Active Monthly File"
        TreeNode14.Text = "File"
        TreeNode15.Name = "A_M_ServiceNode"
        TreeNode15.Tag = "Tasks Active Monthly Service"
        TreeNode15.Text = "Service"
        TreeNode16.Name = "A_MonthlyNode"
        TreeNode16.Tag = "Tasks Active Monthly "
        TreeNode16.Text = "Monthly"
        TreeNode17.Name = "A_Y_ExecutableNode"
        TreeNode17.Tag = "Tasks Active Yearly Executable"
        TreeNode17.Text = "Executable"
        TreeNode18.Name = "A_Y_FileNode"
        TreeNode18.Tag = "Tasks Active Yearly File"
        TreeNode18.Text = "File"
        TreeNode19.Name = "A_Y_ServiceNode"
        TreeNode19.Tag = "Tasks Active Yearly Service"
        TreeNode19.Text = "Service"
        TreeNode20.Name = "A_YearlyNode"
        TreeNode20.Tag = "Tasks Active Yearly "
        TreeNode20.Text = "Yearly"
        TreeNode21.Name = "ActiveNode"
        TreeNode21.Tag = "Tasks Active"
        TreeNode21.Text = "Active"
        TreeNode22.Name = "I_O_ExecutableNode"
        TreeNode22.Tag = "Tasks Inactive Once Executable"
        TreeNode22.Text = "Executable"
        TreeNode23.Name = "I_O_FileNode"
        TreeNode23.Tag = "Tasks Inactive Once File"
        TreeNode23.Text = "File"
        TreeNode24.Name = "I_O_ServiceNode"
        TreeNode24.Tag = "Tasks Inactive Once Service"
        TreeNode24.Text = "Service"
        TreeNode25.Name = "I_OnceNode"
        TreeNode25.Tag = "Tasks Inactive Once "
        TreeNode25.Text = "Once"
        TreeNode26.Name = "I_D_ExecutableNode"
        TreeNode26.Tag = "Tasks Inactive Daily Executable"
        TreeNode26.Text = "Executable"
        TreeNode27.Name = "I_D_FileNode"
        TreeNode27.Tag = "Tasks Inactive Daily File"
        TreeNode27.Text = "File"
        TreeNode28.Name = "I_D_ServiceNode"
        TreeNode28.Tag = "Tasks Inactive Daily Service"
        TreeNode28.Text = "Service"
        TreeNode29.Name = "I_DailyNode"
        TreeNode29.Tag = "Tasks Inactive Daily "
        TreeNode29.Text = "Daily"
        TreeNode30.Name = "I_W_ExecutableNode"
        TreeNode30.Tag = "Tasks Inactive Weekly Executable"
        TreeNode30.Text = "Executable"
        TreeNode31.Name = "I_W_FileNode"
        TreeNode31.Tag = "Tasks Inactive Weekly File"
        TreeNode31.Text = "File"
        TreeNode32.Name = "I_W_ServiceNode"
        TreeNode32.Tag = "Tasks Inactive Weekly Service"
        TreeNode32.Text = "Service"
        TreeNode33.Name = "I_WeeklyNode"
        TreeNode33.Tag = "Tasks Inactive Weekly "
        TreeNode33.Text = "Weekly"
        TreeNode34.Name = "I_M_ExecutableNode"
        TreeNode34.Tag = "Tasks Inactive Monthly Executable"
        TreeNode34.Text = "Executable"
        TreeNode35.Name = "I_M_FileNode"
        TreeNode35.Tag = "Tasks Inactive Monthly File"
        TreeNode35.Text = "File"
        TreeNode36.Name = "I_M_ServiceNode"
        TreeNode36.Tag = "Tasks Inactive Monthly Service"
        TreeNode36.Text = "Service"
        TreeNode37.Name = "I_MonthlyNode"
        TreeNode37.Tag = "Tasks Inactive Monthly "
        TreeNode37.Text = "Monthly"
        TreeNode38.Name = "I_Y_ExecutableNode"
        TreeNode38.Tag = "Tasks Inactive Yearly Executable"
        TreeNode38.Text = "Executable"
        TreeNode39.Name = "I_Y_FileNode"
        TreeNode39.Tag = "Tasks Inactive Yearly File"
        TreeNode39.Text = "File"
        TreeNode40.Name = "I_Y_ServiceNode"
        TreeNode40.Tag = "Tasks Inactive Yearly Service"
        TreeNode40.Text = "Service"
        TreeNode41.Name = "I_YearlyNode"
        TreeNode41.Tag = "Tasks Inactive Yearly "
        TreeNode41.Text = "Yearly"
        TreeNode42.Name = "InactiveNode"
        TreeNode42.Tag = "Tasks Inactive"
        TreeNode42.Text = "Inactive"
        TreeNode43.Name = "TasksNode"
        TreeNode43.Tag = "Tasks"
        TreeNode43.Text = "Tasks"
        TreeNode44.Name = "AddedNode"
        TreeNode44.Tag = "History Added"
        TreeNode44.Text = "Added"
        TreeNode45.Name = "RemovedNode"
        TreeNode45.Tag = "History Removed"
        TreeNode45.Text = "Removed"
        TreeNode46.Name = "SuccessfulNode"
        TreeNode46.Tag = "History Successful"
        TreeNode46.Text = "Successful"
        TreeNode47.Name = "UnsuccessfulNode"
        TreeNode47.Tag = "History Unsuccessful"
        TreeNode47.Text = "Unsuccessful"
        TreeNode48.Name = "HistoryNode"
        TreeNode48.Tag = "History"
        TreeNode48.Text = "Log"
        Me.NavigationTreeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode43, TreeNode48})
        Me.NavigationTreeView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black
        Me.NavigationTreeView.Size = New System.Drawing.Size(186, 452)
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
        Me.KryptonSplitContainer2.Size = New System.Drawing.Size(843, 484)
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
        Me.ScheduledTasksHeaderGroup.Size = New System.Drawing.Size(843, 241)
        Me.ScheduledTasksHeaderGroup.TabIndex = 0
        Me.ScheduledTasksHeaderGroup.ValuesPrimary.Heading = "Scheduled Tasks"
        Me.ScheduledTasksHeaderGroup.ValuesPrimary.Image = Global.AssUI.My.Resources.Resources.scheduledTasksIcon
        '
        'ScheduledTasksDataGridView
        '
        Me.ScheduledTasksDataGridView.AllowUserToAddRows = False
        Me.ScheduledTasksDataGridView.AllowUserToDeleteRows = False
        Me.ScheduledTasksDataGridView.AllowUserToOrderColumns = True
        Me.ScheduledTasksDataGridView.AllowUserToResizeRows = False
        Me.ScheduledTasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ScheduledTasksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScheduledTasksDataGridView.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet
        Me.ScheduledTasksDataGridView.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet
        Me.ScheduledTasksDataGridView.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.ScheduledTasksDataGridView.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.ScheduledTasksDataGridView.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.ScheduledTasksDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ScheduledTasksDataGridView.MultiSelect = False
        Me.ScheduledTasksDataGridView.Name = "ScheduledTasksDataGridView"
        Me.ScheduledTasksDataGridView.ReadOnly = True
        Me.ScheduledTasksDataGridView.RowHeadersVisible = False
        Me.ScheduledTasksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ScheduledTasksDataGridView.Size = New System.Drawing.Size(841, 208)
        Me.ScheduledTasksDataGridView.TabIndex = 1
        '
        'LogHeaderGroup
        '
        Me.LogHeaderGroup.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup3, Me.LogButtonSpecExportToPDF, Me.ButtonSpecHeaderGroup2})
        Me.LogHeaderGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogHeaderGroup.HeaderVisibleSecondary = False
        Me.LogHeaderGroup.Location = New System.Drawing.Point(0, 0)
        Me.LogHeaderGroup.Name = "LogHeaderGroup"
        '
        'LogHeaderGroup.Panel
        '
        Me.LogHeaderGroup.Panel.Controls.Add(Me.LogDataGridView)
        Me.LogHeaderGroup.Size = New System.Drawing.Size(843, 238)
        Me.LogHeaderGroup.TabIndex = 0
        Me.LogHeaderGroup.ValuesPrimary.Heading = "Log"
        Me.LogHeaderGroup.ValuesPrimary.Image = Global.AssUI.My.Resources.Resources.logIcon
        '
        'ButtonSpecHeaderGroup3
        '
        Me.ButtonSpecHeaderGroup3.Image = Global.AssUI.My.Resources.Resources.xmlIcon
        Me.ButtonSpecHeaderGroup3.UniqueName = "AC4C168F1FDD499411ADDC675808EAF2"
        '
        'LogButtonSpecExportToPDF
        '
        Me.LogButtonSpecExportToPDF.Image = Global.AssUI.My.Resources.Resources.exportToPDFicon
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
        Me.LogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LogDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.LogDataGridView.Size = New System.Drawing.Size(841, 201)
        Me.LogDataGridView.TabIndex = 0
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Black
        '
        'UpperPanel
        '
        Me.UpperPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpperPanel.Controls.Add(Me.flagsPanel)
        Me.UpperPanel.Controls.Add(Me.KryptonPanel1)
        Me.UpperPanel.Controls.Add(Me.MenuStrip)
        Me.UpperPanel.Location = New System.Drawing.Point(0, 0)
        Me.UpperPanel.Name = "UpperPanel"
        Me.UpperPanel.Size = New System.Drawing.Size(1036, 93)
        Me.UpperPanel.TabIndex = 1
        '
        'flagsPanel
        '
        Me.flagsPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flagsPanel.Controls.Add(Me.greekFlagCheckButton)
        Me.flagsPanel.Controls.Add(Me.USFlagCheckButton)
        Me.flagsPanel.Location = New System.Drawing.Point(919, 3)
        Me.flagsPanel.Name = "flagsPanel"
        Me.flagsPanel.Size = New System.Drawing.Size(114, 52)
        Me.flagsPanel.TabIndex = 9
        '
        'greekFlagCheckButton
        '
        Me.greekFlagCheckButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile
        Me.greekFlagCheckButton.Location = New System.Drawing.Point(3, 0)
        Me.greekFlagCheckButton.Name = "greekFlagCheckButton"
        Me.greekFlagCheckButton.Size = New System.Drawing.Size(50, 44)
        Me.greekFlagCheckButton.TabIndex = 7
        Me.greekFlagCheckButton.Values.Image = Global.AssUI.My.Resources.Resources.greekFlag
        Me.greekFlagCheckButton.Values.Text = ""
        '
        'USFlagCheckButton
        '
        Me.USFlagCheckButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile
        Me.USFlagCheckButton.Location = New System.Drawing.Point(59, 0)
        Me.USFlagCheckButton.Name = "USFlagCheckButton"
        Me.USFlagCheckButton.Size = New System.Drawing.Size(50, 44)
        Me.USFlagCheckButton.TabIndex = 8
        Me.USFlagCheckButton.Values.Image = Global.AssUI.My.Resources.Resources.USFlag
        Me.USFlagCheckButton.Values.Text = ""
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.RunNowButton)
        Me.KryptonPanel1.Controls.Add(Me.AddTaskButton)
        Me.KryptonPanel1.Controls.Add(Me.DeleteTaskButton)
        Me.KryptonPanel1.Controls.Add(Me.EditTaskButton)
        Me.KryptonPanel1.Location = New System.Drawing.Point(236, 18)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(504, 75)
        Me.KryptonPanel1.TabIndex = 5
        '
        'RunNowButton
        '
        Me.RunNowButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile
        Me.RunNowButton.Enabled = False
        Me.RunNowButton.Location = New System.Drawing.Point(319, 2)
        Me.RunNowButton.Name = "RunNowButton"
        Me.RunNowButton.Size = New System.Drawing.Size(93, 67)
        Me.RunNowButton.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.RunNowButton.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.RunNowButton, "Run Selected Task Now")
        Me.RunNowButton.Values.Image = Global.AssUI.My.Resources.Resources.runTaskIcon
        Me.RunNowButton.Values.Text = "Run Now"
        '
        'AddTaskButton
        '
        Me.AddTaskButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile
        Me.AddTaskButton.Location = New System.Drawing.Point(3, 3)
        Me.AddTaskButton.Name = "AddTaskButton"
        Me.AddTaskButton.Size = New System.Drawing.Size(93, 67)
        Me.AddTaskButton.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.AddTaskButton.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.AddTaskButton, "Add New Task")
        Me.AddTaskButton.Values.Image = Global.AssUI.My.Resources.Resources.addTaskIcon
        Me.AddTaskButton.Values.Text = "Add Task"
        '
        'DeleteTaskButton
        '
        Me.DeleteTaskButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile
        Me.DeleteTaskButton.Enabled = False
        Me.DeleteTaskButton.Location = New System.Drawing.Point(207, 3)
        Me.DeleteTaskButton.Name = "DeleteTaskButton"
        Me.DeleteTaskButton.Size = New System.Drawing.Size(93, 67)
        Me.DeleteTaskButton.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.DeleteTaskButton.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.DeleteTaskButton, "Delete Selected Task")
        Me.DeleteTaskButton.Values.Image = Global.AssUI.My.Resources.Resources.deleteTaskIcon
        Me.DeleteTaskButton.Values.Text = "Delete Task"
        '
        'EditTaskButton
        '
        Me.EditTaskButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditTaskButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile
        Me.EditTaskButton.Enabled = False
        Me.EditTaskButton.Location = New System.Drawing.Point(102, 3)
        Me.EditTaskButton.Name = "EditTaskButton"
        Me.EditTaskButton.Size = New System.Drawing.Size(93, 67)
        Me.EditTaskButton.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.EditTaskButton.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.EditTaskButton, "Edit Selected Task")
        Me.EditTaskButton.Values.Image = Global.AssUI.My.Resources.Resources.editTaskIcon
        Me.EditTaskButton.Values.Text = "Edit Task"
        '
        'MenuStrip
        '
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TaskToolStripMenuItem, Me.ViewToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1036, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunOnStartupToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'RunOnStartupToolStripMenuItem
        '
        Me.RunOnStartupToolStripMenuItem.CheckOnClick = True
        Me.RunOnStartupToolStripMenuItem.Name = "RunOnStartupToolStripMenuItem"
        Me.RunOnStartupToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.RunOnStartupToolStripMenuItem.Text = "Run On Startup"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(152, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Image = Global.AssUI.My.Resources.Resources.quit
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(155, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'TaskToolStripMenuItem
        '
        Me.TaskToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.RunNowToolStripMenuItem})
        Me.TaskToolStripMenuItem.Name = "TaskToolStripMenuItem"
        Me.TaskToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.TaskToolStripMenuItem.Text = "Task"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Image = Global.AssUI.My.Resources.Resources.addTaskIcon
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Enabled = False
        Me.EditToolStripMenuItem.Image = Global.AssUI.My.Resources.Resources.editTaskIcon
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Enabled = False
        Me.DeleteToolStripMenuItem.Image = Global.AssUI.My.Resources.Resources.deleteTaskIcon
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'RunNowToolStripMenuItem
        '
        Me.RunNowToolStripMenuItem.Enabled = False
        Me.RunNowToolStripMenuItem.Image = Global.AssUI.My.Resources.Resources.runTaskIcon
        Me.RunNowToolStripMenuItem.Name = "RunNowToolStripMenuItem"
        Me.RunNowToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RunNowToolStripMenuItem.Text = "Run Now"
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
        Me.TrayIcon.Text = "Adopse Super Scheduler"
        Me.TrayIcon.Visible = True
        '
        'TrayContextMenu
        '
        Me.TrayContextMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TrayContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowContextMenuItem, Me.ToolStripSeparator2, Me.ExitContextMenuItem})
        Me.TrayContextMenu.Name = "TrayContextMenu"
        Me.TrayContextMenu.Size = New System.Drawing.Size(104, 54)
        '
        'ShowContextMenuItem
        '
        Me.ShowContextMenuItem.Image = CType(resources.GetObject("ShowContextMenuItem.Image"), System.Drawing.Image)
        Me.ShowContextMenuItem.Name = "ShowContextMenuItem"
        Me.ShowContextMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ShowContextMenuItem.Text = "Show"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(100, 6)
        '
        'ExitContextMenuItem
        '
        Me.ExitContextMenuItem.Image = CType(resources.GetObject("ExitContextMenuItem.Image"), System.Drawing.Image)
        Me.ExitContextMenuItem.Name = "ExitContextMenuItem"
        Me.ExitContextMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitContextMenuItem.Text = "Exit"
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'languageOnStartTimer
        '
        Me.languageOnStartTimer.Interval = 400
        '
        'ScheduledTasksContextMenu
        '
        Me.ScheduledTasksContextMenu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.ScheduledTasksContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditContextMenuItem, Me.DeleteContextMenuItem, Me.RunNowContextMenuItem, Me.ToolStripSeparator3, Me.ViewHistoryContextMenuItem})
        Me.ScheduledTasksContextMenu.Name = "ScheduledTasksContestMenu"
        Me.ScheduledTasksContextMenu.Size = New System.Drawing.Size(141, 98)
        '
        'EditContextMenuItem
        '
        Me.EditContextMenuItem.Image = Global.AssUI.My.Resources.Resources.editTaskIcon
        Me.EditContextMenuItem.Name = "EditContextMenuItem"
        Me.EditContextMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.EditContextMenuItem.Text = "Edit"
        '
        'DeleteContextMenuItem
        '
        Me.DeleteContextMenuItem.Image = Global.AssUI.My.Resources.Resources.deleteTaskIcon
        Me.DeleteContextMenuItem.Name = "DeleteContextMenuItem"
        Me.DeleteContextMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.DeleteContextMenuItem.Text = "Delete"
        '
        'RunNowContextMenuItem
        '
        Me.RunNowContextMenuItem.Image = Global.AssUI.My.Resources.Resources.runTaskIcon
        Me.RunNowContextMenuItem.Name = "RunNowContextMenuItem"
        Me.RunNowContextMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.RunNowContextMenuItem.Text = "Run Now"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(137, 6)
        '
        'ViewHistoryContextMenuItem
        '
        Me.ViewHistoryContextMenuItem.Image = Global.AssUI.My.Resources.Resources.logIcon
        Me.ViewHistoryContextMenuItem.Name = "ViewHistoryContextMenuItem"
        Me.ViewHistoryContextMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ViewHistoryContextMenuItem.Text = "View History"
        '
        'LogContextMenu
        '
        Me.LogContextMenu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.LogContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveEntryContextMenuItem, Me.ToolStripSeparator4, Me.ExportToPDFContextMenuItem, Me.ExportToXMLContextMenuItem, Me.ToolStripSeparator5, Me.ClearLogContextMenuItem})
        Me.LogContextMenu.Name = "LogContextMenu"
        Me.LogContextMenu.Size = New System.Drawing.Size(149, 104)
        '
        'RemoveEntryContextMenuItem
        '
        Me.RemoveEntryContextMenuItem.Image = Global.AssUI.My.Resources.Resources.deleteTaskIcon
        Me.RemoveEntryContextMenuItem.Name = "RemoveEntryContextMenuItem"
        Me.RemoveEntryContextMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.RemoveEntryContextMenuItem.Text = "Remove Entry"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(145, 6)
        '
        'ExportToPDFContextMenuItem
        '
        Me.ExportToPDFContextMenuItem.Image = Global.AssUI.My.Resources.Resources.exportToPDFicon
        Me.ExportToPDFContextMenuItem.Name = "ExportToPDFContextMenuItem"
        Me.ExportToPDFContextMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ExportToPDFContextMenuItem.Text = "Export to PDF"
        '
        'ExportToXMLContextMenuItem
        '
        Me.ExportToXMLContextMenuItem.Image = Global.AssUI.My.Resources.Resources.xmlIcon
        Me.ExportToXMLContextMenuItem.Name = "ExportToXMLContextMenuItem"
        Me.ExportToXMLContextMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ExportToXMLContextMenuItem.Text = "Export to XML"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(145, 6)
        '
        'ClearLogContextMenuItem
        '
        Me.ClearLogContextMenuItem.Image = Global.AssUI.My.Resources.Resources.clearLogIcon
        Me.ClearLogContextMenuItem.Name = "ClearLogContextMenuItem"
        Me.ClearLogContextMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ClearLogContextMenuItem.Text = "Clear Log"
        '
        'flagCheckSet
        '
        Me.flagCheckSet.CheckButtons.Add(Me.USFlagCheckButton)
        Me.flagCheckSet.CheckButtons.Add(Me.greekFlagCheckButton)
        '
        'langBackgroundWorker
        '
        '
        'MissedTasksTaskDialog
        '
        Me.MissedTasksTaskDialog.CheckboxText = Nothing
        Me.MissedTasksTaskDialog.CommonButtons = CType((ComponentFactory.Krypton.Toolkit.TaskDialogButtons.Yes Or ComponentFactory.Krypton.Toolkit.TaskDialogButtons.No), ComponentFactory.Krypton.Toolkit.TaskDialogButtons)
        Me.MissedTasksTaskDialog.Content = Nothing
        Me.MissedTasksTaskDialog.DefaultButton = ComponentFactory.Krypton.Toolkit.TaskDialogButtons.Yes
        Me.MissedTasksTaskDialog.DefaultRadioButton = Nothing
        Me.MissedTasksTaskDialog.FooterHyperlink = Nothing
        Me.MissedTasksTaskDialog.FooterText = Nothing
        Me.MissedTasksTaskDialog.Icon = System.Windows.Forms.MessageBoxIcon.Warning
        Me.MissedTasksTaskDialog.MainInstruction = "How should i handle the missed task?"
        Me.MissedTasksTaskDialog.Tag = Nothing
        Me.MissedTasksTaskDialog.WindowTitle = "Missed Task!"
        '
        'saveToXML_FileDialog
        '
        Me.saveToXML_FileDialog.Filter = "XML Files(*.xml)|*.xml"
        Me.saveToXML_FileDialog.InitialDirectory = "System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)"
        '
        'NoScheduledTaskDialog
        '
        Me.NoScheduledTaskDialog.CheckboxText = "Do not show this window again"
        Me.NoScheduledTaskDialog.CommonButtons = CType((ComponentFactory.Krypton.Toolkit.TaskDialogButtons.Yes Or ComponentFactory.Krypton.Toolkit.TaskDialogButtons.No), ComponentFactory.Krypton.Toolkit.TaskDialogButtons)
        Me.NoScheduledTaskDialog.Content = Nothing
        Me.NoScheduledTaskDialog.CustomIcon = Global.AssUI.My.Resources.Resources.addTaskIcon
        Me.NoScheduledTaskDialog.DefaultButton = ComponentFactory.Krypton.Toolkit.TaskDialogButtons.Yes
        Me.NoScheduledTaskDialog.DefaultRadioButton = Nothing
        Me.NoScheduledTaskDialog.FooterHyperlink = Nothing
        Me.NoScheduledTaskDialog.FooterText = Nothing
        Me.NoScheduledTaskDialog.MainInstruction = "Add Task"
        Me.NoScheduledTaskDialog.Tag = Nothing
        Me.NoScheduledTaskDialog.WindowTitle = "Welcome"
        '
        'DeleteTaskDialog
        '
        Me.DeleteTaskDialog.CheckboxText = Nothing
        Me.DeleteTaskDialog.CommonButtons = CType((ComponentFactory.Krypton.Toolkit.TaskDialogButtons.Yes Or ComponentFactory.Krypton.Toolkit.TaskDialogButtons.No), ComponentFactory.Krypton.Toolkit.TaskDialogButtons)
        Me.DeleteTaskDialog.Content = "Are you sure you want to complete remove this task?"
        Me.DeleteTaskDialog.CustomIcon = CType(resources.GetObject("DeleteTaskDialog.CustomIcon"), System.Drawing.Image)
        Me.DeleteTaskDialog.DefaultButton = ComponentFactory.Krypton.Toolkit.TaskDialogButtons.No
        Me.DeleteTaskDialog.DefaultRadioButton = Nothing
        Me.DeleteTaskDialog.FooterHyperlink = Nothing
        Me.DeleteTaskDialog.FooterText = Nothing
        Me.DeleteTaskDialog.MainInstruction = "Delete Task"
        Me.DeleteTaskDialog.Tag = Nothing
        Me.DeleteTaskDialog.WindowTitle = "Delete"
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
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adopse Super Scheduler"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
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
        CType(Me.flagsPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flagsPanel.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.TrayContextMenu.ResumeLayout(False)
        Me.ScheduledTasksContextMenu.ResumeLayout(False)
        Me.LogContextMenu.ResumeLayout(False)
        CType(Me.flagCheckSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ShowContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogButtonSpecExportToPDF As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents AdopseSuperSchedulerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NoScheduledTaskDialog As ComponentFactory.Krypton.Toolkit.KryptonTaskDialog
    Friend WithEvents office2010BlackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents office2010BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents office2010SilverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents office2007BlackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents office2007BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents office2007SilverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents languageOnStartTimer As System.Windows.Forms.Timer
    Friend WithEvents ScheduledTasksDataGridView As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ScheduledTasksContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunNowContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewHistoryContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents LogContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExportToPDFContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearLogContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveEntryContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteTaskDialog As ComponentFactory.Krypton.Toolkit.KryptonTaskDialog
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunNowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunOnStartupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents USFlagCheckButton As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents greekFlagCheckButton As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents flagCheckSet As ComponentFactory.Krypton.Toolkit.KryptonCheckSet
    Friend WithEvents flagsPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents langBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents MissedTasksTaskDialog As ComponentFactory.Krypton.Toolkit.KryptonTaskDialog
    Friend WithEvents ButtonSpecHeaderGroup3 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents saveToXML_FileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ExportToXMLContextMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
