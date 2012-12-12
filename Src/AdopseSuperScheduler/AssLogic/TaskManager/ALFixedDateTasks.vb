Public Class ALFixedDateTasks

    Inherits ALATasks

    Sub New(ByVal a_full_path As String, ByVal a_date As Date, ByVal a_status As Boolean, ByVal a_description As String, ByVal a_close_after As Integer)
        MyBase.New(a_full_path, a_date, a_status, a_description, a_close_after)
    End Sub



    Public Overrides Sub UpdateNextRun()

    End Sub
End Class
