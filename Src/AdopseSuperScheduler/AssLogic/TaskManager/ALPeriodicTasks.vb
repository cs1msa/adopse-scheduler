Public Class ALPeriodicTasks
    Inherits ALATasks
    Dim m_period_in_days As UInteger
    Dim m_period_in_months As Integer
    Dim m_period_in_years As Integer

    Sub New(ByVal a_id As Integer, ByVal a_full_path As String, ByVal a_date As Date, ByVal a_status As Boolean, _
                        ByVal a_end_date As Date, _
                        Optional ByVal a_if_not_run As String = "DIALOG", _
                        Optional ByVal a_description As String = "", _
                        Optional ByVal a_close_after As Integer = 0, _
                        Optional ByVal a_period_in_days As UInteger = 0, _
                        Optional ByVal a_period_in_months As UInteger = 0, _
                        Optional ByVal a_period_in_years As UInteger = 0)

        MyBase.New(a_id, a_full_path, a_date, a_status, a_description, a_close_after, a_if_not_run, a_end_date)
        m_period_in_days = a_period_in_days
        m_period_in_months = a_period_in_months
        m_period_in_years = a_period_in_years

    End Sub

    Public Overrides Sub UpdateNextRun()
        m_next_run = m_next_run.AddDays(m_period_in_days)
        m_next_run = m_next_run.AddMonths(m_period_in_months)
        m_next_run = m_next_run.AddYears(m_period_in_years)

        If m_next_run.CompareTo(m_end_date) >= 0 Then
            m_status = False

        End If
    End Sub
End Class
