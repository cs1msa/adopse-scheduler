﻿Public Class ALWeeklyTasks
    Inherits ALATasks

    Sub New(ByVal a_full_path As String, ByVal a_date As Date)
        MyBase.New(a_full_path, a_date)
    End Sub

    Public Overrides Sub UpdateNextRun()
        m_next_run = m_next_run.AddDays(7)
    End Sub
End Class
