<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoreOptionsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MoreOptionsForm))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.DescriptionGroupBox = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.DescriptionTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.MoreOptionsOKButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.TaskMissedGroupBox = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.RunWhenPcOpensRadioButton = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.DisplayDialogAskingRadioButton = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.DoNothingRadioButton = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.StateGroupBox = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.InactiveRadioButton = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.ActiveRadioButton = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.SetEndDateGroupBox = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.EndAtDateTimePicker = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.occurencesLabel = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.EndAfterNumericUpDown = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.EndAtRadioButton = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.NeverEndRadioButton = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.EndAfterRadioButton = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TimeOpenGroupBox = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.MinutesUpDown = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.DescriptionGroupBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionGroupBox.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DescriptionGroupBox.Panel.SuspendLayout()
        Me.DescriptionGroupBox.SuspendLayout()
        CType(Me.TaskMissedGroupBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskMissedGroupBox.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TaskMissedGroupBox.Panel.SuspendLayout()
        Me.TaskMissedGroupBox.SuspendLayout()
        CType(Me.StateGroupBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StateGroupBox.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StateGroupBox.Panel.SuspendLayout()
        Me.StateGroupBox.SuspendLayout()
        CType(Me.SetEndDateGroupBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SetEndDateGroupBox.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SetEndDateGroupBox.Panel.SuspendLayout()
        Me.SetEndDateGroupBox.SuspendLayout()
        CType(Me.TimeOpenGroupBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeOpenGroupBox.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TimeOpenGroupBox.Panel.SuspendLayout()
        Me.TimeOpenGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.TimeOpenGroupBox)
        Me.KryptonPanel.Controls.Add(Me.DescriptionGroupBox)
        Me.KryptonPanel.Controls.Add(Me.MoreOptionsOKButton)
        Me.KryptonPanel.Controls.Add(Me.TaskMissedGroupBox)
        Me.KryptonPanel.Controls.Add(Me.StateGroupBox)
        Me.KryptonPanel.Controls.Add(Me.SetEndDateGroupBox)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(560, 308)
        Me.KryptonPanel.TabIndex = 0
        '
        'DescriptionGroupBox
        '
        Me.DescriptionGroupBox.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicPanel
        Me.DescriptionGroupBox.Location = New System.Drawing.Point(12, 155)
        Me.DescriptionGroupBox.Name = "DescriptionGroupBox"
        '
        'DescriptionGroupBox.Panel
        '
        Me.DescriptionGroupBox.Panel.Controls.Add(Me.DescriptionTextBox)
        Me.DescriptionGroupBox.Size = New System.Drawing.Size(341, 63)
        Me.DescriptionGroupBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.DescriptionGroupBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.DescriptionGroupBox.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Yellow
        Me.DescriptionGroupBox.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.DescriptionGroupBox.TabIndex = 6
        Me.DescriptionGroupBox.Text = "Enter a description for your task"
        Me.DescriptionGroupBox.Values.Heading = "Enter a description for your task"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(18, 3)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(282, 20)
        Me.DescriptionTextBox.TabIndex = 0
        Me.DescriptionTextBox.Text = "Your Description ..."
        '
        'MoreOptionsOKButton
        '
        Me.MoreOptionsOKButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile
        Me.MoreOptionsOKButton.Location = New System.Drawing.Point(433, 237)
        Me.MoreOptionsOKButton.Name = "MoreOptionsOKButton"
        Me.MoreOptionsOKButton.Size = New System.Drawing.Size(53, 59)
        Me.MoreOptionsOKButton.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.MoreOptionsOKButton.TabIndex = 3
        Me.MoreOptionsOKButton.Values.Image = CType(resources.GetObject("MoreOptionsOKButton.Values.Image"), System.Drawing.Image)
        Me.MoreOptionsOKButton.Values.Text = "Ok"
        '
        'TaskMissedGroupBox
        '
        Me.TaskMissedGroupBox.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicPanel
        Me.TaskMissedGroupBox.Location = New System.Drawing.Point(326, 23)
        Me.TaskMissedGroupBox.Name = "TaskMissedGroupBox"
        '
        'TaskMissedGroupBox.Panel
        '
        Me.TaskMissedGroupBox.Panel.Controls.Add(Me.RunWhenPcOpensRadioButton)
        Me.TaskMissedGroupBox.Panel.Controls.Add(Me.DisplayDialogAskingRadioButton)
        Me.TaskMissedGroupBox.Panel.Controls.Add(Me.DoNothingRadioButton)
        Me.TaskMissedGroupBox.Size = New System.Drawing.Size(218, 109)
        Me.TaskMissedGroupBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TaskMissedGroupBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.TaskMissedGroupBox.StateNormal.Content.LongText.Color1 = System.Drawing.Color.Yellow
        Me.TaskMissedGroupBox.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Yellow
        Me.TaskMissedGroupBox.TabIndex = 2
        Me.TaskMissedGroupBox.Text = "If task is missed"
        Me.TaskMissedGroupBox.Values.Description = "(PC was closed)"
        Me.TaskMissedGroupBox.Values.Heading = "If task is missed"
        '
        'RunWhenPcOpensRadioButton
        '
        Me.RunWhenPcOpensRadioButton.Location = New System.Drawing.Point(9, 5)
        Me.RunWhenPcOpensRadioButton.Name = "RunWhenPcOpensRadioButton"
        Me.RunWhenPcOpensRadioButton.Size = New System.Drawing.Size(131, 20)
        Me.RunWhenPcOpensRadioButton.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.RunWhenPcOpensRadioButton.TabIndex = 6
        Me.RunWhenPcOpensRadioButton.Values.Text = "Run when PC opens"
        '
        'DisplayDialogAskingRadioButton
        '
        Me.DisplayDialogAskingRadioButton.Checked = True
        Me.DisplayDialogAskingRadioButton.Location = New System.Drawing.Point(9, 31)
        Me.DisplayDialogAskingRadioButton.Name = "DisplayDialogAskingRadioButton"
        Me.DisplayDialogAskingRadioButton.Size = New System.Drawing.Size(138, 20)
        Me.DisplayDialogAskingRadioButton.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.DisplayDialogAskingRadioButton.TabIndex = 7
        Me.DisplayDialogAskingRadioButton.Values.Text = "Display dialog asking"
        '
        'DoNothingRadioButton
        '
        Me.DoNothingRadioButton.Location = New System.Drawing.Point(9, 57)
        Me.DoNothingRadioButton.Name = "DoNothingRadioButton"
        Me.DoNothingRadioButton.Size = New System.Drawing.Size(87, 20)
        Me.DoNothingRadioButton.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.DoNothingRadioButton.TabIndex = 8
        Me.DoNothingRadioButton.Values.Text = "Do Nothing"
        '
        'StateGroupBox
        '
        Me.StateGroupBox.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicPanel
        Me.StateGroupBox.Location = New System.Drawing.Point(377, 155)
        Me.StateGroupBox.Name = "StateGroupBox"
        '
        'StateGroupBox.Panel
        '
        Me.StateGroupBox.Panel.Controls.Add(Me.InactiveRadioButton)
        Me.StateGroupBox.Panel.Controls.Add(Me.ActiveRadioButton)
        Me.StateGroupBox.Size = New System.Drawing.Size(167, 63)
        Me.StateGroupBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.StateGroupBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.StateGroupBox.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Yellow
        Me.StateGroupBox.TabIndex = 1
        Me.StateGroupBox.Text = "State"
        Me.StateGroupBox.Values.Heading = "State"
        '
        'InactiveRadioButton
        '
        Me.InactiveRadioButton.Location = New System.Drawing.Point(83, 3)
        Me.InactiveRadioButton.Name = "InactiveRadioButton"
        Me.InactiveRadioButton.Size = New System.Drawing.Size(64, 20)
        Me.InactiveRadioButton.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.InactiveRadioButton.TabIndex = 1
        Me.InactiveRadioButton.Values.Text = "Inactive"
        '
        'ActiveRadioButton
        '
        Me.ActiveRadioButton.Checked = True
        Me.ActiveRadioButton.Location = New System.Drawing.Point(9, 3)
        Me.ActiveRadioButton.Name = "ActiveRadioButton"
        Me.ActiveRadioButton.Size = New System.Drawing.Size(56, 20)
        Me.ActiveRadioButton.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.ActiveRadioButton.TabIndex = 0
        Me.ActiveRadioButton.Values.Text = "Active"
        '
        'SetEndDateGroupBox
        '
        Me.SetEndDateGroupBox.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicPanel
        Me.SetEndDateGroupBox.Location = New System.Drawing.Point(12, 23)
        Me.SetEndDateGroupBox.Name = "SetEndDateGroupBox"
        '
        'SetEndDateGroupBox.Panel
        '
        Me.SetEndDateGroupBox.Panel.Controls.Add(Me.EndAtDateTimePicker)
        Me.SetEndDateGroupBox.Panel.Controls.Add(Me.occurencesLabel)
        Me.SetEndDateGroupBox.Panel.Controls.Add(Me.EndAfterNumericUpDown)
        Me.SetEndDateGroupBox.Panel.Controls.Add(Me.EndAtRadioButton)
        Me.SetEndDateGroupBox.Panel.Controls.Add(Me.NeverEndRadioButton)
        Me.SetEndDateGroupBox.Panel.Controls.Add(Me.EndAfterRadioButton)
        Me.SetEndDateGroupBox.Size = New System.Drawing.Size(288, 109)
        Me.SetEndDateGroupBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.SetEndDateGroupBox.StateCommon.Border.Color2 = System.Drawing.Color.White
        Me.SetEndDateGroupBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.SetEndDateGroupBox.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Yellow
        Me.SetEndDateGroupBox.TabIndex = 0
        Me.SetEndDateGroupBox.Text = "Set End Date"
        Me.SetEndDateGroupBox.Values.Heading = "Set End Date"
        '
        'EndAtDateTimePicker
        '
        Me.EndAtDateTimePicker.Location = New System.Drawing.Point(72, 56)
        Me.EndAtDateTimePicker.Name = "EndAtDateTimePicker"
        Me.EndAtDateTimePicker.Size = New System.Drawing.Size(203, 21)
        Me.EndAtDateTimePicker.TabIndex = 5
        '
        'occurencesLabel
        '
        Me.occurencesLabel.Location = New System.Drawing.Point(129, 31)
        Me.occurencesLabel.Name = "occurencesLabel"
        Me.occurencesLabel.Size = New System.Drawing.Size(71, 20)
        Me.occurencesLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.occurencesLabel.TabIndex = 4
        Me.occurencesLabel.Values.Text = "occurences"
        '
        'EndAfterNumericUpDown
        '
        Me.EndAfterNumericUpDown.Location = New System.Drawing.Point(87, 31)
        Me.EndAfterNumericUpDown.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.EndAfterNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.EndAfterNumericUpDown.Name = "EndAfterNumericUpDown"
        Me.EndAfterNumericUpDown.Size = New System.Drawing.Size(36, 22)
        Me.EndAfterNumericUpDown.TabIndex = 3
        Me.EndAfterNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.EndAfterNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'EndAtRadioButton
        '
        Me.EndAtRadioButton.Location = New System.Drawing.Point(9, 57)
        Me.EndAtRadioButton.Name = "EndAtRadioButton"
        Me.EndAtRadioButton.Size = New System.Drawing.Size(57, 20)
        Me.EndAtRadioButton.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.EndAtRadioButton.TabIndex = 2
        Me.EndAtRadioButton.Values.Text = "End at "
        '
        'NeverEndRadioButton
        '
        Me.NeverEndRadioButton.Checked = True
        Me.NeverEndRadioButton.Location = New System.Drawing.Point(9, 5)
        Me.NeverEndRadioButton.Name = "NeverEndRadioButton"
        Me.NeverEndRadioButton.Size = New System.Drawing.Size(79, 20)
        Me.NeverEndRadioButton.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.NeverEndRadioButton.TabIndex = 1
        Me.NeverEndRadioButton.Values.Text = "Never End"
        '
        'EndAfterRadioButton
        '
        Me.EndAfterRadioButton.Location = New System.Drawing.Point(9, 31)
        Me.EndAfterRadioButton.Name = "EndAfterRadioButton"
        Me.EndAfterRadioButton.Size = New System.Drawing.Size(72, 20)
        Me.EndAfterRadioButton.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.EndAfterRadioButton.TabIndex = 0
        Me.EndAfterRadioButton.Values.Text = "End after"
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Black
        '
        'TimeOpenGroupBox
        '
        Me.TimeOpenGroupBox.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicPanel
        Me.TimeOpenGroupBox.Location = New System.Drawing.Point(12, 237)
        Me.TimeOpenGroupBox.Name = "TimeOpenGroupBox"
        '
        'TimeOpenGroupBox.Panel
        '
        Me.TimeOpenGroupBox.Panel.Controls.Add(Me.KryptonLabel1)
        Me.TimeOpenGroupBox.Panel.Controls.Add(Me.MinutesUpDown)
        Me.TimeOpenGroupBox.Size = New System.Drawing.Size(341, 59)
        Me.TimeOpenGroupBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TimeOpenGroupBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.TimeOpenGroupBox.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Yellow
        Me.TimeOpenGroupBox.TabIndex = 7
        Me.TimeOpenGroupBox.Text = "How much time will the program remain open?"
        Me.TimeOpenGroupBox.Values.Heading = "How much time will the program remain open?"
        Me.TimeOpenGroupBox.Visible = False
        '
        'MinutesUpDown
        '
        Me.MinutesUpDown.Location = New System.Drawing.Point(87, 3)
        Me.MinutesUpDown.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.MinutesUpDown.Name = "MinutesUpDown"
        Me.MinutesUpDown.Size = New System.Drawing.Size(36, 22)
        Me.MinutesUpDown.TabIndex = 0
        Me.MinutesUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(129, 5)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(171, 20)
        Me.KryptonLabel1.StateCommon.LongText.Color1 = System.Drawing.Color.Silver
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.White
        Me.KryptonLabel1.TabIndex = 6
        Me.KryptonLabel1.Values.ExtraText = "(0 = will never close)"
        Me.KryptonLabel1.Values.Text = "minutes "
        '
        'MoreOptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 308)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MoreOptionsForm"
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "More Options"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.DescriptionGroupBox.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DescriptionGroupBox.Panel.ResumeLayout(False)
        Me.DescriptionGroupBox.Panel.PerformLayout()
        CType(Me.DescriptionGroupBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DescriptionGroupBox.ResumeLayout(False)
        CType(Me.TaskMissedGroupBox.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TaskMissedGroupBox.Panel.ResumeLayout(False)
        Me.TaskMissedGroupBox.Panel.PerformLayout()
        CType(Me.TaskMissedGroupBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TaskMissedGroupBox.ResumeLayout(False)
        CType(Me.StateGroupBox.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StateGroupBox.Panel.ResumeLayout(False)
        Me.StateGroupBox.Panel.PerformLayout()
        CType(Me.StateGroupBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StateGroupBox.ResumeLayout(False)
        CType(Me.SetEndDateGroupBox.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SetEndDateGroupBox.Panel.ResumeLayout(False)
        Me.SetEndDateGroupBox.Panel.PerformLayout()
        CType(Me.SetEndDateGroupBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SetEndDateGroupBox.ResumeLayout(False)
        CType(Me.TimeOpenGroupBox.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TimeOpenGroupBox.Panel.ResumeLayout(False)
        Me.TimeOpenGroupBox.Panel.PerformLayout()
        CType(Me.TimeOpenGroupBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TimeOpenGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents SetEndDateGroupBox As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents EndAtRadioButton As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents NeverEndRadioButton As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents EndAfterRadioButton As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents StateGroupBox As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents InactiveRadioButton As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents ActiveRadioButton As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents EndAtDateTimePicker As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents occurencesLabel As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents EndAfterNumericUpDown As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents TaskMissedGroupBox As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents RunWhenPcOpensRadioButton As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents DisplayDialogAskingRadioButton As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents DoNothingRadioButton As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents MoreOptionsOKButton As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents DescriptionTextBox As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents DescriptionGroupBox As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents TimeOpenGroupBox As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MinutesUpDown As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
End Class
