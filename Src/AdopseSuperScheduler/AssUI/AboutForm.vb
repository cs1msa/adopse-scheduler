Imports ComponentFactory.Krypton.Toolkit

Public Class AboutForm

    Private Sub AboutForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        KryptonManager.GlobalPaletteMode = My.Settings.PalletteSetting

        If KryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Black Or _
                    KryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Black Then

            changeKryptonLabelColors(Color.White)
        Else
            changeKryptonLabelColors(Color.Black)
        End If

    End Sub

    Private Sub KryptonButton1_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton1.Click
        Me.Close()
    End Sub

    Private Sub KryptonLinkLabel1_LinkClicked(sender As System.Object, e As System.EventArgs) Handles KryptonLinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://code.google.com/p/adopse-scheduler/")
    End Sub

    Private Sub changeKryptonLabelColors(color As System.Drawing.Color)
        KryptonLabel2.StateCommon.ShortText.Color1 = color
        KryptonLabel3.StateCommon.ShortText.Color1 = color
        KryptonLabel4.StateCommon.ShortText.Color1 = color
        KryptonLabel5.StateCommon.ShortText.Color1 = color
        KryptonLabel6.StateCommon.ShortText.Color1 = color
        KryptonLabel7.StateCommon.ShortText.Color1 = color
        KryptonLabel8.StateCommon.ShortText.Color1 = color
        KryptonLabel9.StateCommon.ShortText.Color1 = color
        KryptonLabel10.StateCommon.ShortText.Color1 = color
    End Sub


End Class
