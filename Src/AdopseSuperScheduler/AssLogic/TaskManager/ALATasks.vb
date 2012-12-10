Public MustInherit Class ALATasks
    Implements IComparable
    Protected m_next_run As Date      'the date this tasks is supposed to run

    Protected m_full_path As String   'contains prorgam name and path

    Sub New(ByVal a_full_path As String, ByVal a_date As Date)
        m_full_path = a_full_path
        m_next_run = a_date
    End Sub


    MustOverride Sub UpdateNextRun()    'updates depend on the type of the task

    Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
        Dim other As ALATasks = DirectCast(obj,  _
            ALATasks)

        Return Me.m_next_run.CompareTo(other.next_run_date)
    End Function


    Public Property program_full_path() As String
        Get
            Return m_full_path
        End Get
        Set(ByVal value As String)
            m_full_path = value
        End Set
    End Property

    Public ReadOnly Property next_run_date As Date
        Get
            Return m_next_run
        End Get
    End Property


End Class

