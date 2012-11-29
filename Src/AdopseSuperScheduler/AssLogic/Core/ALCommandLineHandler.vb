
'contain basic operations for command line
'such as opening/closing programs

Public Class ALCommandLineHandler

    Dim m_cmd_process As Process
    Dim m_path As String
    Dim m_program As String
    Dim m_last_command_output As String

    'creates an instance of process that opens the programs and sets the info needed
    Public Sub New()
        m_cmd_process = New Process

        Dim StartInfo As New System.Diagnostics.ProcessStartInfo
        StartInfo.FileName = "cmd" 'starts cmd window
        StartInfo.RedirectStandardInput = True
        StartInfo.RedirectStandardOutput = True
        StartInfo.RedirectStandardError = True
        StartInfo.CreateNoWindow = True
        StartInfo.UseShellExecute = False 'required to redirect

        m_cmd_process.StartInfo = StartInfo
    End Sub

    Public Function GetLastCommandOutput()
        Return m_last_command_output
    End Function

    'sets the path and the program, starts a new thread to open the program
    Public Sub RunProgram(ByVal a_path As String, ByVal a_program As String)
        m_path = a_path
        m_program = a_program


        If Not ExecuteCMDCommand("cd " & m_path) Then
            Throw New PathDoesntExistCMDException(a_path)
        End If
        If Not ExecuteCMDCommand("cd " & m_path & vbCrLf & m_program) Then
            Throw New ProgramDoesntExistCMDException(a_program)
        End If



    End Sub

    'checks if the program is running, if yes it kills it
    'can use name of the program OR PID, better use pid
    Public Sub KillProgram(ByVal a_program As String)
        m_program = a_program


            Dim output As String = " "
            Dim input As String = "taskkill /IM " & m_program

            If Not ExecuteCMDCommand(input) Then
                Throw New ProccessNotFoundException(a_program)
            End If


    End Sub


    'returns a list of pids
    'one pid if there is one instance of the program...
    'many pids if there are many instanses of the program...
    Public Function GetPids(ByVal a_program As String)
        Dim task_list_output As String = " "
        Dim input As String = "tasklist"
        Dim PID As New List(Of Integer)

        ExecuteCMDCommand(input, task_list_output)


        'there may be more than one open programs with that name
        While task_list_output.Contains(a_program)



            Dim start_of_line = task_list_output.IndexOf(a_program)
            Dim end_of_line = task_list_output.IndexOf(Chr(13), start_of_line)

            Dim line_of_interest = task_list_output.Substring(start_of_line, end_of_line - start_of_line)

            Dim splited_line = line_of_interest.Split({" "}, System.StringSplitOptions.RemoveEmptyEntries)
            line_of_interest = task_list_output.Substring(start_of_line, end_of_line - start_of_line)

            Dim f_part = task_list_output.Substring(0, start_of_line)
            Dim s_part = task_list_output.Substring(end_of_line, task_list_output.Length - end_of_line)


            task_list_output = f_part & s_part

            PID.Add(Integer.Parse(splited_line(1)))

        End While
        If PID.Count = 0 Then
            Throw New ProccessNotFoundException(a_program)
        End If
        Return PID

    End Function

    'checks if a program runs and optionaly returns memory usage
    Public Function CheckIfRuns(ByVal a_program As String, Optional ByRef a_memory_use_return As Integer = vbNull)

        Dim task_list_output As String = " "
        Dim input As String = "tasklist"

        ExecuteCMDCommand(input, task_list_output)

        If task_list_output.Contains(a_program) Then

            'if it is called in a way that needs to know how much memory the program uses
            If Not a_memory_use_return = vbNull Then
                Dim start_of_line = task_list_output.IndexOf(a_program)
                Dim end_of_line = task_list_output.IndexOf(Chr(13), start_of_line)

                Dim line_of_interest = task_list_output.Substring(start_of_line, end_of_line - start_of_line)
                Dim splited_line = line_of_interest.Split(" ")

                a_memory_use_return = splited_line(splited_line.Length - 2)

                m_last_command_output = task_list_output
            End If


            Return True
        End If



        Return False


    End Function

    'runs the cmd command
    Private Function ExecuteCMDCommand(ByVal a_input As String, Optional ByRef a_output As String = vbNullString)
        m_cmd_process.Start()
        Dim SR As System.IO.StreamReader = m_cmd_process.StandardOutput
        Dim SW As System.IO.StreamWriter = m_cmd_process.StandardInput
        Dim SE As System.IO.StreamReader = m_cmd_process.StandardError

        SW.WriteLine(a_input)    'the command we want to execute

        SW.WriteLine("exit") 'exits command prompt window

        'this blog is for cases that error is not passed back and causes the program to halt.. (example : tasklist)
        Dim error_str As New String("")
        Dim output_str As New String("")

        Dim error_reading_thread As New Threading.Thread(Sub() Me.SafeReadToEnd(error_str, SE))
        Dim output_reading_thread As New Threading.Thread(Sub() Me.SafeReadToEnd(output_str, SR))

        error_reading_thread.Start()
        output_reading_thread.Start()

        'if it is a command that doesnt open a program(this is done because opening a program makes it the process and we cant take output nor error)
        'like setting a path(without opening a program),       or killing a proccess,      or calling tasklist 
        'if we want to use more commands we must add them here too
        If (a_input.Contains("cd") And Not a_input.Contains(".")) _
            Or a_input.Contains("taskkill") _
            Or a_input.Contains("tasklist") Then

            'wait until you get an error or an output
            Do While error_str = vbNullString And output_str = vbNullString

            Loop
        End If



        error_reading_thread.Abort()
        output_reading_thread.Abort()


        SW.Close()
        SR.Close()
        SE.Close()

        a_output = output_str
        m_last_command_output = a_output

        If Not error_str = vbNullString Then
            Return False
        End If

        Return True
    End Function


    Private Sub SafeReadToEnd(ByRef a_string As String, ByRef a_reader As System.IO.StreamReader)

        a_string = a_reader.ReadToEnd()

    End Sub

End Class
