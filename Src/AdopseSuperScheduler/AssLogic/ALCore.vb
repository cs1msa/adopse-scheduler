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
        Dim path_index As String = a_full_path.LastIndexOf("\")
        Dim path As String = a_full_path.Substring(0, path_index)
        Dim program As String = a_full_path.Substring(path_index + 1)

        'open the given program with the given path
        m_command_line_handler.RunProgram(a_path:=path, a_program:=program)

    End Sub






End Class
