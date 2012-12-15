Public Class ALMasterControl

    Dim m_core As ALCore
    Dim m_task_manager As ALTaskManager

    Dim m_last_log_id As Integer
    Dim m_last_scheduler_tasks_id As Integer

    Public Sub New()
        m_core = New ALCore()
        m_task_manager = New ALTaskManager()
    End Sub

    'run this after the constructor
    Public Sub Init()

        Dim data_table As DataTable = m_core.GetFromATableAsDataTable("Log", {"Action_ID"})
        m_last_log_id = data_table.Rows(data_table.Rows.Count - 1).Item(0)
        data_table = m_core.GetFromATableAsDataTable("[Scheduler Tasks]", {"Task_ID"})
        m_last_scheduler_tasks_id = data_table.Rows(data_table.Rows.Count - 1).Item(0)


        RetrieveTasks()
        m_task_manager.SortTasks()

    End Sub


    Public Sub RetrieveTasks()

        Dim tasks_string As New List(Of String)
        tasks_string = m_core.GetFromATableAsStringList("[Scheduler Tasks]", {"Program_Name", "Next_Run", "Period", "Status", "Description", "Close_After"})

        Dim path As String
        Dim date_ As String
        Dim period As String
        Dim status As String
        Dim description As String
        Dim close_after As String
        For Each row As String In tasks_string
            Dim splitted_row = row.Split("|")
            path = splitted_row(0)
            date_ = splitted_row(1)
            period = splitted_row(2)
            status = splitted_row(3)
            description = splitted_row(4)
            close_after = splitted_row(5)

            CreateTasks(path, date_, period, status, description, close_after)
        Next
    End Sub


    Public Sub CreateTasks(ByVal a_path As String, ByVal a_date As String, ByVal a_period As String, ByVal a_status As String, ByVal a_description As String, ByVal a_close_after As String)

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

            Dim task As New ALPeriodicTasks(a_path, m_date, Boolean.Parse(a_status), a_description, Integer.Parse(a_close_after), _
                                                    UInteger.Parse(splited_period(0)), _
                                                    UInteger.Parse(splited_period(1)), _
                                                    UInteger.Parse(splited_period(2)))
            m_task_manager.AddTask(task)

        Else 'in case there is not a period create a fixed date task
            Dim task As New ALFixedDateTasks(a_path, m_date, Boolean.Parse(a_status), a_description, Integer.Parse(a_close_after))
            m_task_manager.AddTask(task)
        End If


    End Sub

    'checks the tasks and returns the tasks the should run now or should have runned
    Public Function CheckTasks() As List(Of ALATasks)

        Dim now_date As Date = Date.Now 'System time
        Dim list_to_return As New List(Of ALATasks)
        For i As UInteger = 0 To m_task_manager.Count - 1 Step 1
            Dim working_task = m_task_manager.GetTask(i)

            'first check if it is supposed to run later
            If working_task.next_run_date.CompareTo(now_date) > 0 Then
                Exit For
            Else
                'else add them to the list
                list_to_return.Add(working_task)
            End If

            'first check if it is supposed to run later
            If working_task.next_run_date.CompareTo(now_date) > 0 Then
                Exit For
            Else
                'else add them to the list
                list_to_return.Add(working_task)
            End If

        Next
        Return list_to_return
    End Function


    'runs the tasks that should run
    Public Sub RunTasks()


        Dim tasks As List(Of ALATasks) = checkTasks()

        For Each task In tasks
            'run the program
            m_core.RunFullPathProgram(task.program_full_path)
            task.UpdateNextRun()

        Next



    End Sub


    'add task

    '-Scheduled tasks
    'Task_ID | Program_Path | Next Run | Status | Description | Close After | If_Not_Run | End_Date


    Public Sub AddTask(ByVal a_full_path As String, ByVal a_date As Date, ByVal a_end_date As Date, ByVal a_status As Boolean, _
                       Optional ByVal a_description As String = "", _
                       Optional ByVal a_close_after As Integer = 0, _
                       Optional ByVal a_period_in_days As UInteger = 0, _
                       Optional ByVal a_period_in_months As UInteger = 0, _
                       Optional ByVal a_period_in_years As UInteger = 0, _
                       Optional ByVal a_if_not_run As String = "RUN")

        'add the task to the task manager 
        If a_period_in_days = 0 And a_period_in_months = 0 And a_period_in_years = 0 Then
            'if it a fixed date task
            Dim task As New ALFixedDateTasks(a_full_path, a_date, a_status, a_description, a_close_after)
            m_task_manager.AddTask(task)

        Else
            'if it is a periodic task
            Dim task As New ALPeriodicTasks(a_full_path, a_date, a_status, a_description, a_close_after, a_period_in_days, a_period_in_months, a_period_in_years)
            m_task_manager.AddTask(task)
        End If

        m_task_manager.SortTasks()

        'add the task to the database(scheduler tasks)
        'add a log row for the addition
        Try
            m_last_log_id = m_last_log_id + 1
            m_last_scheduler_tasks_id = m_last_scheduler_tasks_id + 1
            m_core.InsertToTable("[Scheduler Tasks]", {m_last_scheduler_tasks_id.ToString(), "'" & a_full_path & "'", "'" & a_date & "'", _
                                                      "'" & a_period_in_days.ToString() & "/" & a_period_in_months.ToString() & "/" & a_period_in_years.ToString() & "'", _
                                                      a_status.ToString(), "'" & a_description & "'", a_close_after.ToString()})

            m_core.InsertToTable("Log", {m_last_log_id.ToString(), "'" & Date.Now & "'", "'" & a_full_path & "'", "'added or something like that'"})
        Catch ex As ALDatabaseInsertException

        End Try


    End Sub


    'delete task
    Public Sub DeleteTask(ByVal a_full_path As String)
        'remove it from task manager
        m_task_manager.RemoveTasksWithFullPath(a_full_path)

        'remove it from database(scheduler tasks)
        'add a log row for the deletion 
        Try
            m_core.DeleteFromTable("[Scheduler Tasks]", {"Program_Name = '" & a_full_path & "'"})
            m_last_log_id = m_last_log_id + 1
            m_core.InsertToTable("Log", {m_last_log_id.ToString(), "'" & Date.Now & "'", "'" & a_full_path & "'", "'deleted or something like that'"})

        Catch ex As ALDatabaseDeleteException

        Catch ex2 As ALDatabaseInsertException



        End Try


    End Sub





End Class
