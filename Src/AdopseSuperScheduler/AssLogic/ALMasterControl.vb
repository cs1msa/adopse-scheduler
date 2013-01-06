
Public Class ALMasterControl

    Dim m_core As ALCore
    Dim m_task_manager As ALTaskManager

    Dim m_last_log_id As Integer
    Dim m_last_scheduler_tasks_id As Integer

    Dim m_program_loop_thread_timer As Threading.Timer

    Public m_log_has_changed As Boolean = False
    Public m_scheduler_tasks_has_changed As Boolean = False

    Public Sub New()
        m_core = New ALCore()



        m_task_manager = New ALTaskManager()
    End Sub

    'run this after the constructor
    Public Sub Init()

        Dim data_table As DataTable = m_core.GetFromATableAsDataTable("Log", {"Action_ID"})
        If data_table.Rows.Count <> 0 Then
            m_last_log_id = data_table.Rows(data_table.Rows.Count - 1).Item(0)
        Else
            m_last_log_id = 0
        End If
        data_table = m_core.GetFromATableAsDataTable("[Scheduler Tasks]", {"Task_ID"})
        If data_table.Rows.Count <> 0 Then
            m_last_scheduler_tasks_id = data_table.Rows(data_table.Rows.Count - 1).Item(0)
        Else
            m_last_scheduler_tasks_id = 0
        End If



        RetrieveTasks()
        m_task_manager.SortTasks()

    End Sub


    Public Sub RetrieveTasks()

        Dim tasks_string As New List(Of String)
        tasks_string = m_core.GetFromATableAsStringList("[Scheduler Tasks]", {"Task_ID", "Program_Path", "Next_Run", "Period", "Status", "Description", "Close_After", "If_Not_Run", "End_Date", "Type"})


        For Each row As String In tasks_string
            Dim splitted_row = row.Split("|")
            Dim id = splitted_row(0)
            Dim path = splitted_row(1)
            Dim date_ = splitted_row(2)
            Dim period = splitted_row(3)
            Dim status = splitted_row(4)
            Dim description = splitted_row(5)
            Dim close_after = splitted_row(6)
            Dim if_not_run = splitted_row(7)
            Dim end_date = splitted_row(8)
            Dim type = splitted_row(9)

            CreateTasks(id, path, date_, period, status, end_date, if_not_run, description, close_after, type)
        Next
    End Sub


    Public Sub CreateTasks(ByVal a_id As Integer, ByVal a_path As String, ByVal a_date As String, ByVal a_period As String, _
                           ByVal a_status As String, ByVal a_end_date As Date, ByVal a_if_not_run As String, _
                           ByVal a_description As String, ByVal a_close_after As String, ByVal a_type As String)

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

            Dim task As New ALPeriodicTasks(a_id, a_path, m_date, Boolean.Parse(a_status), a_type, a_end_date, a_if_not_run, a_description, Integer.Parse(a_close_after), _
                                                    UInteger.Parse(splited_period(0)), _
                                                    UInteger.Parse(splited_period(1)), _
                                                    UInteger.Parse(splited_period(2)))
            m_task_manager.AddTask(task)

        Else 'in case there is not a period create a fixed date task
            Dim task As New ALFixedDateTasks(a_id, a_path, m_date, Boolean.Parse(a_status), a_type, a_if_not_run, a_description, Integer.Parse(a_close_after))
            m_task_manager.AddTask(task)
        End If


    End Sub

    'checks the tasks and returns the tasks the should run now or should have runned
    Public Function CheckTasks() As List(Of ALATasks)

        Dim now_date As Date = Date.Now 'System time
        Dim list_to_return As New List(Of ALATasks)
        'if there are tasks in task manager
        If m_task_manager.Count > 0 Then
            For i As UInteger = 0 To m_task_manager.Count - 1 Step 1

                Dim working_task = m_task_manager.GetTask(i)

                'first check if it is supposed to run later
                If working_task.next_run_date.CompareTo(now_date) > 0 Then
                    Exit For
                ElseIf working_task.GetStatus Then
                    'else add them to the list
                    list_to_return.Add(working_task)
                End If

            Next
        End If

        Return list_to_return
    End Function


    'this is the function that will run when the program is idle
    Public Sub ProgramLoop()

        Dim running_tasks As List(Of ALATasks) = m_task_manager.GetRunningTasks()
        CloseTasks(running_tasks)

        Dim tasks_to_run As List(Of ALATasks) = CheckTasks()

        RunTasks(tasks_to_run)




    End Sub

    Public Sub StartProgramLoop()   'which runs once a minute
        Dim timer_call_back_sub As New Threading.TimerCallback(Sub() Me.ProgramLoop())

        m_program_loop_thread_timer = New Threading.Timer(timer_call_back_sub, Me, 0, 60000)
    End Sub



    'runs the tasks that should run
    Public Sub RunTasks(ByRef a_tasks As List(Of ALATasks))



        For Each task As ALATasks In a_tasks
            'run the program
            Try
                Dim success As Boolean = True
                Try

                    If task.type.Equals("EXE") Then
                        m_core.RunFullPathProgram(task.program_full_path)
                    ElseIf task.type.Equals("FILE") Then
                        m_core.RunFile(task.program_full_path)
                    ElseIf task.type.Equals("SERVICE") Then
                        m_core.StartService(task.program_full_path)
                    End If

                Catch ex1 As Exception
                    success = False

                End Try
                If success Then
                    task.is_running = True
                End If

                task.UpdateNextRun()
                'write every thing in the log and update the [scheduler tasks] table
                m_last_log_id = m_last_log_id + 1
                m_core.InsertToTable("Log", {m_last_log_id, "'" & Date.Now & "'", "'" & task.program_full_path & "'", "'Task Run " & " " & task.type & " " & success & "'"})
                m_core.UpdateInTable("[Scheduler Tasks]", {"Status = " & task.GetStatus.ToString(), "Next_Run ='" & task.next_run_date & "'"}, {"Task_ID =" & task.id.ToString})
                m_log_has_changed = True
                m_scheduler_tasks_has_changed = True

            Catch ex As Exception

            End Try
        Next

    End Sub



    Public Sub RunTask(ByVal a_full_path As String, ByVal a_type As String)
        Try

            Dim success As Boolean = True
            Try

                If a_type.Equals("EXE") Then
                    m_core.RunFullPathProgram(a_full_path)
                ElseIf a_type.Equals("FILE") Then
                    m_core.RunFile(a_full_path)
                ElseIf a_type.Equals("SERVICE") Then
                    m_core.StartService(a_full_path)
                End If

            Catch ex1 As Exception
                success = False

            End Try
            
            m_last_log_id = m_last_log_id + 1
            m_core.InsertToTable("Log", {m_last_log_id, "'" & Date.Now & "'", "'" & a_full_path & "'", "'Task Run (user)" & " " & a_type & " " & success & "'"})
            m_log_has_changed = True
        Catch ex As Exception

        End Try

    End Sub



    Public Sub CloseTasks(ByRef a_tasks As List(Of ALATasks))

        For Each task As ALATasks In a_tasks
            Dim closes_after_minutes As Integer = task.closes_after_x_minutes

            'in case the program closed by it self
            If Not m_core.IsRunning(task.program_full_path) Then
                task.is_running = False
                m_last_log_id = m_last_log_id + 1
                m_core.InsertToTable("Log", {m_last_log_id, "'" & Date.Now & "'", "'" & task.program_full_path & "'", "'Task Normally Closed" & " " & task.type & " " & True.ToString & "'"})
                m_log_has_changed = True
                Continue For
            End If

            'if the program did not close by itself and is supposed to close after some time...
            If closes_after_minutes <> 0 Then

                Dim date_that_should_stop_running As Date = task.last_run.AddMinutes(closes_after_minutes)

                Dim success As Boolean = True
                Try

                    If date_that_should_stop_running.CompareTo(Date.Now) <= 0 Then
                        'prorgam killing here
                        If task.type.Equals("EXE") Then
                            m_core.KillProgram(task.program_full_path)
                        ElseIf task.type.Equals("FILE") Then
                            'we have no way of closing a file :P
                        ElseIf task.type.Equals("SERVICE") Then
                            m_core.EndService(task.program_full_path)
                        End If
                    End If


                Catch ex As Exception
                    success = False
                End Try
                If success Then
                    task.is_running = False
                End If

                m_last_log_id = m_last_log_id + 1
                m_core.InsertToTable("Log", {m_last_log_id, "'" & Date.Now & "'", "'" & task.program_full_path & "'", "'Task Force Closed " & task.type & " " & success & "'"})
                m_log_has_changed = True
            End If


        Next

    End Sub

    Public Sub UpdateNextRuns()
        For i = 0 To m_task_manager.Count - 1
            While m_task_manager.GetTask(i).next_run_date.CompareTo(Date.Now) <= 0 And m_task_manager.GetTask(i).GetStatus
                m_task_manager.GetTask(i).UpdateNextRun()
                Try
                    m_core.UpdateInTable("[Scheduler Tasks]", {"Status = " & m_task_manager.GetTask(i).GetStatus.ToString(), "Next_Run ='" & m_task_manager.GetTask(i).next_run_date & "'"}, {"Task_ID =" & m_task_manager.GetTask(i).id.ToString})
                    m_scheduler_tasks_has_changed = True
                Catch ex As Exception

                End Try

            End While
        Next

    End Sub


    'add task

    '-Scheduled tasks
    'Task_ID | Program_Path | Next Run | Status | Description | Close After | If_Not_Run | End_Date


    Public Sub AddTask(ByVal a_full_path As String, ByVal a_date As Date, ByVal a_end_date As Date, ByVal a_status As Boolean, ByVal a_type As String, _
                       Optional ByVal a_description As String = "", _
                       Optional ByVal a_close_after As Integer = 0, _
                       Optional ByVal a_period_in_days As UInteger = 0, _
                       Optional ByVal a_period_in_months As UInteger = 0, _
                       Optional ByVal a_period_in_years As UInteger = 0, _
                       Optional ByVal a_if_not_run As String = "DIALOG", _
                       Optional ByVal a_write_to_log_about_it As Boolean = True)
        Try


            'add the task to the task manager 
            If a_period_in_days = 0 And a_period_in_months = 0 And a_period_in_years = 0 Then
                'if it a fixed date task
                Dim task As New ALFixedDateTasks(m_last_scheduler_tasks_id, a_full_path, a_date, a_status, a_type, a_if_not_run, a_description, a_close_after)
                m_task_manager.AddTask(task)

            Else
                'if it is a periodic task
                Dim task As New ALPeriodicTasks(m_last_scheduler_tasks_id, a_full_path, a_date, a_status, a_type, a_end_date, a_if_not_run, a_description, a_close_after, a_period_in_days, a_period_in_months, a_period_in_years)
                m_task_manager.AddTask(task)
            End If

            m_task_manager.SortTasks()

            'add the task to the database(scheduler tasks)
            'add a log row for the addition

            m_last_scheduler_tasks_id = m_last_scheduler_tasks_id + 1
            m_core.InsertToTable("[Scheduler Tasks]", {m_last_scheduler_tasks_id.ToString(), "'" & a_full_path & "'", "'" & a_date & "'", _
                                                      "'" & a_period_in_days.ToString() & "/" & a_period_in_months.ToString() & "/" & a_period_in_years.ToString() & "'", _
                                                      a_status.ToString(), "'" & a_description & "'", a_close_after.ToString(), _
                                                       "'" & a_if_not_run & "'", "'" & a_end_date & "'", "'" & a_type & "'"})

            If a_write_to_log_about_it Then
                m_last_log_id = m_last_log_id + 1
                m_core.InsertToTable("Log", {m_last_log_id.ToString(), "'" & Date.Now & "'", "'" & a_full_path & "'", "'Task added " & a_type & "'"})
                m_log_has_changed = True
            End If


            m_scheduler_tasks_has_changed = True

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
            m_core.DeleteFromTable("[Scheduler Tasks]", {"Program_Path = '" & a_full_path & "'"})
            m_last_log_id = m_last_log_id + 1

            m_core.InsertToTable("Log", {m_last_log_id.ToString(), "'" & Date.Now & "'", "'" & a_full_path & "'", "'Task deleted  " & a_full_path & "'"})

            m_log_has_changed = True
            m_scheduler_tasks_has_changed = True
        Catch ex As ALDatabaseDeleteException

        Catch ex2 As ALDatabaseInsertException

        End Try


    End Sub


    Public Sub ClearLog()
        Try
            m_core.DeleteFromTable("Log")

            m_log_has_changed = True
        Catch ex As ALDatabaseDeleteException
        End Try

    End Sub

    Public Sub RemoveEntryFromLog(ByVal a_id As String)
        Try

            m_core.DeleteFromTable("Log", {"Action_ID = " & a_id})
            m_log_has_changed = True
        Catch ex As ALDatabaseDeleteException

        End Try
    End Sub

    Public Function GetFromATableAsDataTable(ByVal a_table As String, ByVal a_columns As String(), ByVal ParamArray a_restrictions As String()) As DataTable
        Return m_core.GetFromATableAsDataTable(a_table, a_columns, a_restrictions)
    End Function

    Public Function GetTasksWithFullPath(ByVal a_program_path As String) As List(Of ALATasks)

        Return m_task_manager.GetTasksWithFullPath(a_program_path)

    End Function


End Class
