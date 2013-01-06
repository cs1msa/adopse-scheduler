'core operations 
'basic command line communication
'basic database communication
Public Class ALCore

    Dim m_command_line_handler As ALCommandLineHandler
    Dim m_database_handler As ALDatabaseHandler

   

    Public Sub New()

        m_command_line_handler = New ALCommandLineHandler()
        m_database_handler = New ALDatabaseHandler()

    End Sub
    '-------------------------------------Command Line functions-------------------------------------------------------
    'given a full path with the program runs the program
    Public Sub RunFullPathProgram(ByVal a_full_path As String, Optional ByRef a_pid_return As Integer = 0)
        'this is the program pid - it will be returned in the end of function
        Dim pid As Integer = 0
        'seperate the path from the program
        If (a_full_path.Contains("\")) Then
            Dim path_index As String = a_full_path.LastIndexOf("\")
            Dim path As String = a_full_path.Substring(0, path_index)
            Dim program As String = a_full_path.Substring(path_index + 1)



            'open the given program with the given path and get the PID
            If CheckIfRuns(program) Then
                Dim old_pids As List(Of Integer) = m_command_line_handler.GetPids(program)
                m_command_line_handler.RunProgram(a_path:=path, a_program:=program)
                Dim new_pids As List(Of Integer) = m_command_line_handler.GetPids(program)


                'if there is single instanced(one pid - many programs)
                If old_pids.Count = new_pids.Count = 1 Then
                    pid = new_pids(0)
                    'else if it is multinstanced(one pid - one program, many pids for many programs)
                Else
                    'compare all the the contents of the old and new pid lists
                    For i As Integer = 0 To old_pids.Count - 1
                        If Not old_pids(i) = new_pids(i) Then
                            pid = new_pids(i)   'if the new_pids are different in some way that means the difference is the new pid
                            Exit For
                        End If
                    Next
                    'if there was not found any difference for each content of old_pid that means that there is a last new_pid which is the pid we want
                    If pid = 0 Then
                        pid = new_pids(new_pids.Count - 1)
                    End If
                End If
                'if there is no instance of this program running
            Else
                m_command_line_handler.RunProgram(a_path:=path, a_program:=program)
                Dim counter = 0
                While Not m_command_line_handler.CheckIfRuns(program)
                    If counter < 1000000 Then
                        counter = counter + 1
                    Else
                        Exit While
                    End If

                End While
                Dim new_pids As List(Of Integer) = m_command_line_handler.GetPids(program)
                pid = new_pids(0)

            End If

        End If

        'returns the pid
        a_pid_return = pid

    End Sub

    Public Function IsRunning(ByVal a_program_or_service As String) As Boolean
        If a_program_or_service.Contains("\") And a_program_or_service.Contains("exe") Then 'if it is a full path exe check
            a_program_or_service = a_program_or_service.Substring(a_program_or_service.LastIndexOf("\") + 1)
            m_command_line_handler.CheckIfRuns(a_program_or_service)
        Else 'else if it is service or file return true - we cannot know if it runs
            Return True
        End If
        Return True

    End Function

    Public Sub RunFile(ByVal a_file As String)
        If (a_file.Contains("\")) Then
            Dim path_index As String = a_file.LastIndexOf("\")
            Dim path As String = a_file.Substring(0, path_index)
            Dim file As String = a_file.Substring(path_index + 1)
            m_command_line_handler.RunProgram(path, file)
        End If

    End Sub

    'run a service
    Public Sub StartService(ByVal a_service As String)
        m_command_line_handler.StartService(a_service)
    End Sub

    Public Sub EndService(ByVal a_service As String)
        m_command_line_handler.EndService(a_service)
    End Sub

    'kill a program using the pid or the same of the program
    Public Sub KillProgram(ByVal a_progam As String)

        a_progam = a_progam.ToLower()

        If a_progam.Contains("\") And a_progam.Contains("exe") Then 'if it is a full path exe check
            a_progam = a_progam.Substring(a_progam.LastIndexOf("\") + 1)
            m_command_line_handler.KillProgram(a_program:=a_progam)
        End If

    End Sub

    'check if a program runs using pid or program_name
    Public Function CheckIfRuns(ByVal a_progam As String, Optional ByRef a_memory_use_return As Integer = -1)
        Return m_command_line_handler.CheckIfRuns(a_progam, a_memory_use_return)

    End Function


    '-------------------------------------Command Line functions End-------------------------------------------------------






    '-------------------------------------DataBase functions-------------------------------------------------------
    'tables till now are "Log" and "[Scheduler Tasks]"
    'Log : Action_ID, Action_Date, Program_Name, Details
    '[Scheduler Tasks] : Task_ID, Program_Path, Next_Run, Period, Status, Description, Close_After, If_Not_Run, End_Date, Type
    Public Function GetFromATableAsDataTable(ByVal a_table As String, ByVal a_columns As String(), ByVal ParamArray a_restrictions As String()) As DataTable

        m_database_handler.ExecuteSelect(a_table, a_columns, a_restrictions)
        Return m_database_handler.GetSelectResultAsDataTable()

    End Function

    Public Function GetFromATableAsStringList(ByVal a_table As String, ByVal a_columns As String(), ByVal ParamArray a_restrictions As String()) As List(Of String)

        m_database_handler.ExecuteSelect(a_table, a_columns, a_restrictions)
        Return m_database_handler.GetSelectResultAsStringList()

    End Function


    Public Sub InsertToTable(ByVal a_table As String, ByVal a_values As String())
        m_database_handler.ExecuteInsert(a_table, a_values)

    End Sub

    Public Sub DeleteFromTable(ByVal a_table As String, ByVal ParamArray a_restrictions As String())
        m_database_handler.ExecuteDelete(a_table, a_restrictions)

    End Sub

    Public Sub UpdateInTable(ByVal a_table As String, ByVal a_updates As String(), ByVal ParamArray a_restrictions As String())
        m_database_handler.ExecuteUpdate(a_table, a_updates, a_restrictions)
    End Sub

    '-------------------------------------DataBase functions End-------------------------------------------------------


End Class
