﻿Public MustInherit Class ALATasks
    Implements IComparable
    Protected m_id As Integer
    Protected m_next_run As Date      'the date this tasks is supposed to run

    Protected m_full_path As String   'contains prorgam name and path

    Protected m_status As Boolean     'is the task active??
    Protected m_description As String 'description of the task
    Protected m_close_after As Integer 'in minutes

    Protected m_if_not_run As String    '"RUN-DIALOG-NOTHING"
    Protected m_end_date As Date        'the date that this tasks it being diactivated

    Protected m_type As String

    Protected m_running As Boolean      'is the program running now?

    Protected m_last_run As Date        'when was the date that the program last started to run
    Sub New(ByVal a_id As Integer, ByVal a_full_path As String, ByVal a_date As Date, ByVal a_status As Boolean, ByVal a_description As String, ByVal a_close_after As Integer, _
            ByVal a_if_not_run As String, ByVal a_end_date As Date, ByVal a_type As String)
        m_id = a_id
        m_full_path = a_full_path
        m_next_run = a_date
        m_status = a_status
        m_description = a_description
        m_close_after = a_close_after
        m_if_not_run = a_if_not_run
        m_end_date = a_end_date
        m_type = a_type
        m_running = False
    End Sub


    MustOverride Sub UpdateNextRun()    'updates depend on the type of the task

    Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
        Dim other As ALATasks = DirectCast(obj,  _
            ALATasks)

        Return Me.m_next_run.CompareTo(other.next_run_date)
    End Function

    Public Function GetStatus() As Boolean
        Return m_status
    End Function


    Public Property end_date As Date
        Get
            Return m_end_date
        End Get
        Set(ByVal value As Date)
            m_end_date = value
        End Set
    End Property

    Public Property description As String
        Get
            Return m_description
        End Get
        Set(ByVal value As String)
            m_description = value
        End Set
    End Property

    Public Property if_not_run As String
        Get
            Return m_if_not_run
        End Get
        Set(ByVal value As String)
            m_if_not_run = value
        End Set
    End Property

    Public Property is_running As Boolean
        Get
            Return m_running
        End Get
        Set(ByVal value As Boolean)
            m_running = value
            If value Then
                m_last_run = Date.Now
            End If

        End Set
    End Property

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




    Public ReadOnly Property id As Integer
        Get
            Return m_id
        End Get
    End Property

    Public Property type As String
        Get
            Return m_type
        End Get
        Set(ByVal value As String)
            m_type = value
        End Set
    End Property

    Public Property closes_after_x_minutes As Integer
        Get
            Return m_close_after
        End Get
        Set(ByVal value As Integer)
            m_close_after = value
        End Set
    End Property

    Public ReadOnly Property last_run As Date
        Get
            Return m_last_run
        End Get

    End Property
End Class

