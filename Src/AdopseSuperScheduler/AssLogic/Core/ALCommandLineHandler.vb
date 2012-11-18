
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
        StartInfo.UseShellExecute = False 'required to redirect

        m_cmd_process.StartInfo = StartInfo
    End Sub

    'sets the path and the program, starts a new thread to open the program
    Public Sub RunProgram(ByVal a_path As String, ByVal a_program As String)
        m_path = a_path
        m_program = a_program
        Dim CMD As New Threading.Thread(AddressOf RunProgramThread)
        CMD.Start()
    End Sub


    Public Function GetLastCommandOutput()
        Return m_last_command_output
    End Function


    'runs the program
    Private Sub RunProgramThread()


        m_cmd_process.Start()
        Dim SR As System.IO.StreamReader = m_cmd_process.StandardOutput
        Dim SW As System.IO.StreamWriter = m_cmd_process.StandardInput
        SW.WriteLine("cd " & m_path)    'the path of the program
        SW.WriteLine(m_program)  'the program you wish to run.....
        SW.WriteLine("exit") 'exits command prompt window
        m_last_command_output = SR.ReadToEnd 'returns results of the command window
        SW.Close()
        SR.Close()
    End Sub




End Class
