Imports AssLogic
Public Class TestingForm
    Dim m_master_control As ALMasterControl



    Private Sub TestingForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        m_master_control = New ALMasterControl

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'create a core ONLY for testing purposes
        Dim m_core As New ALCore
        m_core.KillProgram(TextBox1.Text)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'create a core ONLY for testing purposes
        Dim m_core As New ALCore
        m_core.RunFullPathProgram(TextBox1.Text)
    End Sub
End Class