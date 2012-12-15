Imports AssLogic
Public Class TestingForm
    Dim m_master_control As ALMasterControl
    'create a ALTaskManager ONLY for testing purposes
    Dim m_task_manager As New ALTaskManager()


    Private Sub TestingForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        m_master_control = New ALMasterControl
        m_master_control.Init()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'create a command line handler ONLY for testing purposes
        Dim command_line_handler As New ALCommandLineHandler
        Try
            command_line_handler.KillProgram(TextBox1.Text)
        Catch ex As ALProccessNotFoundException
            Label4.Text = "not found proccess:" & ex.Message
        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'create a command line handler ONLY for testing purposes
        Dim command_line_handler As New ALCommandLineHandler
        Try
            command_line_handler.RunProgram(TextBox2.Text, TextBox1.Text)
        Catch ex As AssLogic.ALProgramDoesntExistCMDException
            Label4.Text = "program does not exist: " & ex.Message
        Catch ex2 As AssLogic.ALPathDoesntExistCMDException
            Label4.Text = "path does not exist : " & ex2.Message
        End Try


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'create a query factory ONLY for testing purposes
        Dim database_query_factory As New ALDatabaseQueryFactory
        Dim select_statement = database_query_factory.CreateSelectStatement("log", {"pid", "sname"}, {"pid=1"})

        Dim delete_statement = database_query_factory.CreateDeleteStatement("log", {"pid=1"})

        Dim insert_statement = database_query_factory.CreateInsertStatement("log", {"3", "'takis'", "'malakia'"})

        Dim update_statement = database_query_factory.CreateUpdateStatement("log", {"pid = pid +1"})

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'create a database handler ONLY for testing purposes
        Dim database_handler As New ALDatabaseHandler

        database_handler.ExecuteSelect("Log", {"*"})
        Dim select_query = database_handler.GetSelectResultAsDataTable()
        database_handler.ExecuteSelect("[Scheduler Tasks]", {"*"})
        Dim select_query2 = database_handler.GetSelectResultAsStringList()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'create a database handler ONLY for testing purposes
        Dim database_handler As New ALDatabaseHandler
        'will now work
        database_handler.ExecuteInsert("Log", {"1", "21/12/2012", "'C:/firefox.exe'", "'this is a testing of details'"})
        database_handler.ExecuteInsert("Log", {"2", "1/3/2009", "'C:/chrome.exe'", "'this is a testing of details 2'"})

        database_handler.ExecuteInsert("[Scheduler Tasks]", {"1", "'C:/Firefox.exe'", "'14/12/2012'", "'0/0/0'", "True", "'papar'", "20"})
        database_handler.ExecuteInsert("[Scheduler Tasks]", {"2", "'C:/Chrome.exe'", "'25/12/2012'", "'2/4/0'", "True", "'popor'", "0"})

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'create a database handler ONLY for testing purposes
        Dim database_handler As New ALDatabaseHandler
        database_handler.ExecuteDelete("Log")
        database_handler.ExecuteDelete("[Scheduler Tasks]")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'create a command line handler ONLY for testing purposes
        Dim command_line_handler As New ALCommandLineHandler
        Try
            Dim pid As List(Of Integer) = command_line_handler.GetPids(TextBox1.Text)
            Label4.Text = "pid/s : ="
            For i As Integer = 0 To pid.Count() - 1
                Label4.Text = Label4.Text & pid(i).ToString() & " , "
            Next
        Catch ex As ALProccessNotFoundException
            Label4.Text = "not found proccess:" & ex.Message
        End Try

    End Sub


    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'create a command line handler ONLY for testing purposes
        Dim command_line_handler As New ALCommandLineHandler
        Dim memory_use As Integer
        command_line_handler.CheckIfRuns(TextBox1.Text, memory_use)
        Label4.Text = "memory use : = " & memory_use
    End Sub



    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'create a ALCore ONLY for testing purposes
        Dim core As New ALCore
        Dim memory_use As Integer
        If core.CheckIfRuns(TextBox3.Text, memory_use) Then
            Label5.Text = "It runs and uses : " & memory_use.ToString & "kilobytes of memory)"
        Else
            Label5.Text = "it does not run"
        End If


    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'create a ALCore ONLY for testing purposes
        Dim core As New ALCore
        Dim pid As New Integer
        core.RunFullPathProgram(TextBox3.Text, pid)
        Label5.Text = "pid = " & pid

    End Sub

    

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        'create a ALCore ONLY for testing purposes
        Dim core As New ALCore
        core.KillProgram(TextBox3.Text)
    End Sub



    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

        m_task_manager.AddTask(New ALFixedDateTasks("C:/firefox.exe", New Date(2012, 12, 4, 20, 20, 0), True, "papa", 4))

    End Sub

   
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        m_master_control.CreateTasks("c:/firefox.exe", "30/12/1899 12:00:50 πμ", "3/5/0", False, Date.Now, "DIALOG", "ria", "65")
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        m_master_control.RetrieveTasks()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        'create a database handler ONLY for testing purposes
        Dim database_handler As New ALDatabaseHandler

        database_handler.ExecuteUpdate("[Scheduler Tasks]", {"Program_Path = 'C:/Firefox.exe'"}, {"Task_ID = 2"})

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        m_master_control.Init()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        '' m_master_control.AddTask("c:/Firefox.exe", New Date(2066, 6, 6, 15, 30, 0), True, "just a test", 15, 7)
        'DOES NOT WORK, NEEDS TO BE UPDATED TO THE NEW DATABASE SCHEME
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        m_master_control.DeleteTask("c:/Firefox.exe")
    End Sub
End Class