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

    Public Sub SortTasks()
        m_task_list.Sort()
    End Sub

    Public Function GetTask(ByVal a_index As Integer) As ALATasks
        If a_index > m_task_list.Count - 1 Then
            Throw New IndexOutOfRangeException()
        End If
        Return m_task_list(a_index)
    End Function

    Public ReadOnly Property Count As UInteger
        Get
            Return m_task_list.Count
        End Get
    End Property

    Public Sub RemoveTasksWithFullPath(ByVal a_full_path As String)
        Dim indexes As List(Of Integer) = IndexesOfTasksWithFullPath(a_full_path)

        For i As Integer = indexes.Count - 1 To 0 Step -1
            m_task_list.RemoveAt(indexes(i))
        Next
    End Sub

    'if there is a task with the given program name it returns true
    Private Function IndexesOfTasksWithFullPath(ByVal a_full_path As String) As List(Of Integer)
        Dim indexes As New List(Of Integer)
        For i As Integer = 0 To m_task_list.Count - 1 Step 1
            If GetTask(i).program_full_path.Contains(a_full_path) Then
                indexes.Add(i)
            End If
        Next
        Return indexes
    End Function
End Class