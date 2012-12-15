Public Class ALFixedDateTasks

    Inherits ALATasks

    Sub New(ByVal a_full_path As String, ByVal a_date As Date, ByVal a_status As Boolean, _
                        Optional ByVal a_if_not_run As String = "DIALOG", _
                        Optional ByVal a_description As String = "", _
                        Optional ByVal a_close_after As Integer = 0)



        MyBase.New(a_full_path, a_date, a_status, a_description, a_close_after, a_if_not_run, a_date)
    End Sub



    Public Overrides Sub UpdateNextRun()

    End Sub
End Class
