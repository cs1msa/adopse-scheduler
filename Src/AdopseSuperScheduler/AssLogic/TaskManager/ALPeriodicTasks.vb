﻿Public Class ALPeriodicTasks
    Inherits ALATasks
    Dim m_period_in_days As UInteger
    Dim m_period_in_months As Integer
    Dim m_period_in_years As Integer

    Sub New(ByVal a_full_path As String, ByVal a_date As Date, _
            Optional ByVal a_period_in_days As UInteger = 1, _
            Optional ByVal a_period_in_months As UInteger = 0, _
            Optional ByVal a_period_in_years As UInteger = 0)

        MyBase.New(a_full_path, a_date)
        m_period_in_days = a_period_in_days
        m_period_in_months = a_period_in_months
        m_period_in_years = a_period_in_years

    End Sub

    Public Overrides Sub UpdateNextRun()
        m_next_run = m_next_run.AddDays(m_period_in_days)
        m_next_run = m_next_run.AddMonths(m_period_in_months)
        m_next_run = m_next_run.AddYears(m_period_in_years)
    End Sub
End Class