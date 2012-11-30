Public MustInherit Class ATasks
    Dim m_next_run As Date      'the date this tasks is supposed to run

    Dim m_full_path As String   'contains prorgam name and path

    Sub New(ByVal a_full_path As String, ByVal a_date As Date)
        m_full_path = a_full_path
        m_next_run = a_date
    End Sub


    MustOverride Sub UpdateNextRun()    'updates depend on the type of the task




    Public Property program_full_path() As String
        Get
            Return m_full_path
        End Get
        Set(ByVal value As String)
            m_full_path = value
        End Set
    End Property

    Public ReadOnly Property next_run_date
        Get
            Return m_next_run
        End Get
    End Property


End Class

