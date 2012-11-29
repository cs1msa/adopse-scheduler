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
                Dim new_pids As List(Of Integer) = m_command_line_handler.GetPids(program)
                pid = new_pids(0)
            End If

        End If
        'returns the pid
        a_pid_return = pid


    End Sub

    'kill a program using the pid or the same of the program
    Public Sub KillProgram(ByVal a_progam As String)
        m_command_line_handler.KillProgram(a_program:=a_progam)
    End Sub

    'check if a program runs using pid or program_name
    Public Function CheckIfRuns(ByVal a_progam As String, Optional ByRef a_memory_use_return As Integer = -1)
        Return m_command_line_handler.CheckIfRuns(a_progam, a_memory_use_return)

    End Function






End Class
