Public Class ALMasterControl

    Dim m_core As ALCore
    Dim m_task_manager As ALTaskManager

    Public Sub New()
        m_core = New ALCore()
        m_task_manager = New ALTaskManager()
    End Sub

    Public Sub RetrieveTasks()

        Dim tasks_string As New List(Of String)
        tasks_string = m_core.GetFromATableAsStringList("[Scheduler Tasks]", {"Program_Name", "Run_Date", "Period"})

        Dim path As String
        Dim date_ As String
        Dim period As String

        For Each row As String In tasks_string
            Dim splitted_row = row.Split("|")
            path = splitted_row(0).ToString
            date_ = splitted_row(1).ToString
            period = splitted_row(2).ToString

            CreateTasks(path, date_, period)
        Next
    End Sub


    Public Sub CreateTasks(ByVal a_path As String, ByVal a_date As String, ByVal a_period As String) 'na proseksw na kanw metatroph apo function se sub an den kanei return

        'create the date to send to the task to run
        Dim date_y_m_d As String = a_date.Split(" ")(0)
        Dim date_h_m_s As String = a_date.Split(" ")(1)

        Dim date_minutes As Integer = Integer.Parse(date_h_m_s.Split(":")(1))
        Dim date_hours As Integer = Integer.Parse(date_h_m_s.Split(":")(0))

        Dim date_days As Integer = Integer.Parse(date_y_m_d.Split("/")(0))
        Dim date_months As Integer = Integer.Parse(date_y_m_d.Split("/")(1))
        Dim date_years As Integer = Integer.Parse(date_y_m_d.Split("/")(2))


        Dim m_date As New Date(date_years, date_months, date_days, date_hours, date_minutes, 0)

        'create and add task to task manager
        Dim splited_period = a_period.Split("/")    'example a_period = 4/2/5 <- 4 days, 2 months, 5 years
        'in case there is a period create a periodic task
        If (Not splited_period(0).Equals("0")) Or _
            (Not splited_period(1).Equals("0")) Or _
            (Not splited_period(2).Equals("0")) Then

            Dim m_daily_task As New ALPeriodicTasks(a_path, m_date, _
                                                    UInteger.Parse(splited_period(0)), _
                                                    UInteger.Parse(splited_period(1)), _
                                                    UInteger.Parse(splited_period(2)))
            m_task_manager.AddTask(m_daily_task)

        Else 'in case there is not a period create a fixed date task
            Dim m_daily_task As New ALFixedDateTasks(a_path, m_date)
            m_task_manager.AddTask(m_daily_task)
        End If


    End Sub


    Public Sub RunTasks()
        'na pernei thn wra tou systhmatos. (thn zhtas apo mena) 
        'kai na perneis ta tasks kai na sygrineis tis wres aytonwn me thn wra tou systhmatos... 
        'an einai idia kaleis thn methodo tou core pou leei runProgramm or something
    End Sub


End Class
