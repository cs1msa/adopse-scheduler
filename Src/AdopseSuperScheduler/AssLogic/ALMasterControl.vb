Public Class ALMasterControl

    Dim m_core As ALCore
    Dim m_task_manager As ALTaskManager

    Public Sub New()
        m_core = New ALCore()
        m_task_manager = New ALTaskManager()
    End Sub

    Public Sub RetrieveTasks()

        Dim tasks_string As New List(Of String)
        tasks_string = m_core.GetFromATableAsStringList("Scheduler Tasks", {"Program_Name", "Run_Date", "Object_Type"})

        Dim m_path As String
        Dim m_date As String
        Dim m_type As String

        For Each row As String In tasks_string
            row.Split("|")
            m_path = row(0).ToString
            m_date = row(1).ToString
            m_type = row(2).ToString

            CreateTasks(m_path, m_date, m_type)
        Next
    End Sub


    Public Sub CreateTasks(ByVal a_path As String, ByVal a_date As String, ByVal a_type As String) 'na proseksw na kanw metatroph apo function se sub an den kanei return

        Dim m_date As Date
        m_date = CDate(Format(a_date, "dd/mm/yyyy"))

        Select Case a_type
            Case "daily"
                Dim m_daily_task As New ALDailyTasks(a_path, m_date)
                m_task_manager.AddTask(m_daily_task)

            Case "weekly"
                Dim m_weekly_task As New ALWeeklyTasks(a_path, m_date)
                m_task_manager.AddTask(m_weekly_task)

            Case "monthly"
                Dim m_monthly_task As New ALMonthlyTasks(a_path, m_date)
                m_task_manager.AddTask(m_monthly_task)

            Case "yearly"
                Dim m_yearly_task As New ALYearlyTasks(a_path, m_date)
                m_task_manager.AddTask(m_yearly_task)

        End Select

    End Sub


    Public Sub RunTasks()
        'na pernei thn wra tou systhmatos. (thn zhtas apo mena) 
        'kai na perneis ta tasks kai na sygrineis tis wres aytonwn me thn wra tou systhmatos... 
        'an einai idia kaleis thn methodo tou core pou leei runProgramm or something
    End Sub


End Class
