Public Class ALTaskManager

    Dim m_task_list As List(Of ALATasks)

    Public Sub New()
        m_task_list = New List(Of ALATasks)

    End Sub

    Public Sub AddTask(ByVal a_task As ALATasks)
        If Not m_task_list.Contains(a_task) Then
            m_task_list.Add(a_task)
        End If
    End Sub

    Public Sub RemoveTask(ByVal a_task As ALATasks)
        If m_task_list.Contains(a_task) Then
            m_task_list.Remove(a_task)
        End If
    End Sub

    Public Function GetTask(ByVal a_index As Integer)
        If a_index > m_task_list.Count - 1 Then
            Return 0
        End If
        Return m_task_list(a_index)
    End Function

    Public ReadOnly Property Count As UInteger
        Get
            Return m_task_list.Count
        End Get
    End Property

End Class