Public Class ALMonthlyTasks
    Inherits ALATasks

    Sub New(ByVal a_full_path As String, ByVal a_date As Date)
        MyBase.New(a_full_path, a_date)
    End Sub

    Public Overrides Sub UpdateNextRun()
        m_next_run = m_next_run.AddMonths(1)
    End Sub
End Class
