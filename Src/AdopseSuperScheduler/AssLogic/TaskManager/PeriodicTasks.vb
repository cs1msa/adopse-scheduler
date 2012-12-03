Public Class PeriodicTasks
    Inherits ATasks
    Dim m_period_in_days As Integer

    Sub New(ByVal a_full_path As String, ByVal a_date As Date, ByVal a_period_in_days As Integer)
        MyBase.New(a_full_path, a_date)
        m_period_in_days = a_period_in_days
    End Sub

    Public Overrides Sub UpdateNextRun()
        m_next_run = m_next_run.AddDays(m_period_in_days)
    End Sub
End Class
