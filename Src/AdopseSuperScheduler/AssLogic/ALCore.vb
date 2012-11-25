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
    Public Sub RunFullPathProgram(ByVal a_full_path As String)
        'seperate the path from the program
        If(a_full_path.Contains("\"))
            Dim path_index As String = a_full_path.LastIndexOf("\")
            Dim path As String = a_full_path.Substring(0, path_index)
            Dim program As String = a_full_path.Substring(path_index + 1)


            'open the given program with the given path
            m_command_line_handler.RunProgram(a_path:=path, a_program:=program)



        End If


    End Sub

    'kill a program using the pid or the same of the program
    Public Sub KillProgram(ByVal a_progam As String)
        m_command_line_handler.KillProgram(a_program:=a_progam)
    End Sub

    'check if a program runs using pid or program_name
    Public Function CheckIfRuns(ByVal a_progam As String, Optional ByRef a_memory_use As Integer = -1)
        Return m_command_line_handler.CheckIfRuns(a_progam, a_memory_use)

    End Function






End Class
