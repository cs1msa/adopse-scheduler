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
        Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.EndAfterRadioButton = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.NeverEndRadioButton = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.EndAtRadioButton = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.KryptonGroupBox2 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.KryptonRadioButton2 = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.KryptonRadioButton4 = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.EndAfterNumericUpDown = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.occurencesLabel = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.EndAtDateTimePicker = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.KryptonGroupBox3 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.RunWhenPcOpensRadioButton = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.DisplayDialogAskingRadioButton = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.DoNothingRadioButton = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox1.Panel.SuspendLayout()
        Me.KryptonGroupBox1.SuspendLayout()
        CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox2.Panel.SuspendLayout()
        Me.KryptonGroupBox2.SuspendLayout()
        CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox3.Panel.SuspendLayout()
        Me.KryptonGroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonGroupBox3)
        Me.KryptonPanel.Controls.Add(Me.KryptonGroupBox2)
        Me.KryptonPanel.Controls.Add(Me.KryptonGroupBox1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(292, 395)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicPanel
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 12)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.EndAtDateTimePicker)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.occurencesLabel)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.EndAfterNumericUpDown)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.EndAtRadioButton)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.NeverEndRadioButton)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.EndAfterRadioButton)
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(277, 109)
        Me.KryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.KryptonGroupBox1.StateCommon.Border.Color2 = System.Drawing.Color.White
        Me.KryptonGroupBox1.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonGroupBox1.TabIndex = 0
        Me.KryptonGroupBox1.Text = "Set End Date"
        Me.KryptonGroupBox1.Values.Heading = "Set End Date"
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Black
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
        'EndAtRadioButton
        '
        Me.EndAtRadioButton.Location = New System.Drawing.Point(9, 57)
        Me.EndAtRadioButton.Name = "EndAtRadioButton"
        Me.EndAtRadioButton.Size = New System.Drawing.Size(57, 20)
        Me.EndAtRadioButton.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.EndAtRadioButton.TabIndex = 2
        Me.EndAtRadioButton.Values.Text = "End at "
        '
        'KryptonGroupBox2
        '
        Me.KryptonGroupBox2.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicPanel
        Me.KryptonGroupBox2.Location = New System.Drawing.Point(3, 136)
        Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
        '
        'KryptonGroupBox2.Panel
        '
        Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonRadioButton4)
        Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonRadioButton2)
        Me.KryptonGroupBox2.Size = New System.Drawing.Size(167, 53)
        Me.KryptonGroupBox2.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.KryptonGroupBox2.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonGroupBox2.TabIndex = 1
        Me.KryptonGroupBox2.Text = "State"
        Me.KryptonGroupBox2.Values.Heading = "State"
        '
        'KryptonRadioButton2
        '
        Me.KryptonRadioButton2.Checked = True
        Me.KryptonRadioButton2.Location = New System.Drawing.Point(9, 3)
        Me.KryptonRadioButton2.Name = "KryptonRadioButton2"
        Me.KryptonRadioButton2.Size = New System.Drawing.Size(56, 20)
        Me.KryptonRadioButton2.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonRadioButton2.TabIndex = 0
        Me.KryptonRadioButton2.Values.Text = "Active"
        '
        'KryptonRadioButton4
        '
        Me.KryptonRadioButton4.Location = New System.Drawing.Point(87, 3)
        Me.KryptonRadioButton4.Name = "KryptonRadioButton4"
        Me.KryptonRadioButton4.Size = New System.Drawing.Size(64, 20)
        Me.KryptonRadioButton4.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonRadioButton4.TabIndex = 1
        Me.KryptonRadioButton4.Values.Text = "Inactive"
        '
        'EndAfterNumericUpDown
        '
        Me.EndAfterNumericUpDown.Location = New System.Drawing.Point(87, 31)
        Me.EndAfterNumericUpDown.Name = "EndAfterNumericUpDown"
        Me.EndAfterNumericUpDown.Size = New System.Drawing.Size(36, 22)
        Me.EndAfterNumericUpDown.TabIndex = 3
        Me.EndAfterNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'occurencesLabel
        '
        Me.occurencesLabel.Location = New System.Drawing.Point(139, 33)
        Me.occurencesLabel.Name = "occurencesLabel"
        Me.occurencesLabel.Size = New System.Drawing.Size(71, 20)
        Me.occurencesLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.occurencesLabel.TabIndex = 4
        Me.occurencesLabel.Values.Text = "occurences"
        '
        'EndAtDateTimePicker
        '
        Me.EndAtDateTimePicker.Location = New System.Drawing.Point(72, 56)
        Me.EndAtDateTimePicker.Name = "EndAtDateTimePicker"
        Me.EndAtDateTimePicker.Size = New System.Drawing.Size(203, 21)
        Me.EndAtDateTimePicker.TabIndex = 5
        '
        'KryptonGroupBox3
        '
        Me.KryptonGroupBox3.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicPanel
        Me.KryptonGroupBox3.Location = New System.Drawing.Point(3, 216)
        Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
        '
        'KryptonGroupBox3.Panel
        '
        Me.KryptonGroupBox3.Panel.Controls.Add(Me.RunWhenPcOpensRadioButton)
        Me.KryptonGroupBox3.Panel.Controls.Add(Me.DisplayDialogAskingRadioButton)
        Me.KryptonGroupBox3.Panel.Controls.Add(Me.DoNothingRadioButton)
        Me.KryptonGroupBox3.Size = New System.Drawing.Size(277, 109)
        Me.KryptonGroupBox3.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.KryptonGroupBox3.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonGroupBox3.TabIndex = 2
        Me.KryptonGroupBox3.Text = "If task is missed"
        Me.KryptonGroupBox3.Values.Description = "(PC was closed)"
        Me.KryptonGroupBox3.Values.Heading = "If task is missed"
        '
        'RunWhenPcOpensRadioButton
        '
        Me.RunWhenPcOpensRadioButton.Location = New System.Drawing.Point(9, 16)
        Me.RunWhenPcOpensRadioButton.Name = "RunWhenPcOpensRadioButton"
        Me.RunWhenPcOpensRadioButton.Size = New System.Drawing.Size(131, 20)
        Me.RunWhenPcOpensRadioButton.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.RunWhenPcOpensRadioButton.TabIndex = 6
        Me.RunWhenPcOpensRadioButton.Values.Text = "Run when PC opens"
        '
        'DisplayDialogAskingRadioButton
        '
        Me.DisplayDialogAskingRadioButton.Checked = True
        Me.DisplayDialogAskingRadioButton.Location = New System.Drawing.Point(9, 42)
        Me.DisplayDialogAskingRadioButton.Name = "DisplayDialogAskingRadioButton"
        Me.DisplayDialogAskingRadioButton.Size = New System.Drawing.Size(138, 20)
        Me.DisplayDialogAskingRadioButton.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.DisplayDialogAskingRadioButton.TabIndex = 7
        Me.DisplayDialogAskingRadioButton.Values.Text = "Display dialog asking"
        '
        'DoNothingRadioButton
        '
        Me.DoNothingRadioButton.Location = New System.Drawing.Point(9, 68)
        Me.DoNothingRadioButton.Name = "DoNothingRadioButton"
        Me.DoNothingRadioButton.Size = New System.Drawing.Size(87, 20)
        Me.DoNothingRadioButton.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.DoNothingRadioButton.TabIndex = 8
        Me.DoNothingRadioButton.Values.Text = "Do Nothing"
        '
        'MoreOptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 395)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MoreOptionsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "More Options"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.Panel.ResumeLayout(False)
        Me.KryptonGroupBox1.Panel.PerformLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.ResumeLayout(False)
        CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox2.Panel.ResumeLayout(False)
        Me.KryptonGroupBox2.Panel.PerformLayout()
        CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox2.ResumeLayout(False)
        CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox3.Panel.ResumeLayout(False)
        Me.KryptonGroupBox3.Panel.PerformLayout()
        CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox3.ResumeLayout(False)
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
    Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents EndAtRadioButton As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents NeverEndRadioButton As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents EndAfterRadioButton As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents KryptonGroupBox2 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents KryptonRadioButton4 As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents KryptonRadioButton2 As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents EndAtDateTimePicker As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents occurencesLabel As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents EndAfterNumericUpDown As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonGroupBox3 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents RunWhenPcOpensRadioButton As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents DisplayDialogAskingRadioButton As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents DoNothingRadioButton As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
End Class