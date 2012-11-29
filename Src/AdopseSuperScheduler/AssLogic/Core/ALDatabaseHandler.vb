Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Common

'this is a database handler
'the way it is meant to be used is this :
'First we set the table(FROM), optionaly the columns, and optionaly the restrictions(WHERE)
'then we Call "ExecuteSelect", or "ExecuteInsert", or "ExecuteDelete" Functions
'VERY IMPORTANT, IF WE WANT TO ADD SOMETHING WE MUST SPECIFY THE COLUMNS and IN THE CORRECT ORDER
'IF WE WANT TO DELETE SOMETHING WE MUST SPECIFY RESTRICTIONS otherwise THE WHOLE TABLE WILL BE EMPTY
'correct order = when we add values we pass parameters to expexted values
Public Class ALDatabaseHandler

    Const m_connection_String As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\AssDatabase.mdb"

    Dim m_database_connection As OleDbConnection
    Dim m_database_command As OleDbCommand

    Dim m_database_query_factory As ALDatabaseQueryFactory
    Dim m_select_return_table As DataTable


    Public Sub New()
        m_select_return_table = New DataTable()
        m_database_query_factory = New ALDatabaseQueryFactory

    End Sub

    Public Function GetSelectResultAsDataTable()

        Return m_select_return_table

    End Function

    Public Function GetSelectResultAsStringList()


        Dim row_list As New List(Of String)

        Dim counter = 0

        For Each i As DataRow In m_select_return_table.Rows
            Dim row_string As New String("")
            For Each item As Object In i.ItemArray

                row_string = row_string & item.ToString & " | "

            Next
            row_list.Add(row_string)
        Next

        Return row_list
    End Function

    'just creates and executes the select command (does not return anything)
    'use GetSelectResultAsStringList, or GetSelectResultAsDataTable to get results
    Public Sub ExecuteSelect(ByVal a_table As String, ByVal a_columns As String(), ByVal ParamArray a_restrictions As String())


        Using m_database_connection As New OleDbConnection(m_connection_String)

            Dim command_string = m_database_query_factory.CreateSelectStatement(a_table, a_columns, a_restrictions)

            Dim data_adapter As New OleDbDataAdapter(command_string, m_database_connection)


            'connect and use a data_adapter to fill a table with the "select" results
            m_database_connection.Open()

            m_select_return_table.Rows.Clear()
            m_select_return_table.Columns.Clear()
            data_adapter.Fill(m_select_return_table)

            m_database_connection.Close()

        End Using

    End Sub

    'it returns the number of rows affected
    'if 0 something is wrong
    Public Sub ExecuteInsert(ByVal a_table As String, ByVal a_values As String())
        Dim number_of_rows_affected As Integer
        Dim command_string As String
        Using m_database_connection As New OleDbConnection(m_connection_String)

            command_string = m_database_query_factory.CreateInsertStatement(a_table, a_values)

            m_database_command = New OleDbCommand(command_string, m_database_connection)

            'connect and execute
            m_database_connection.Open()
            number_of_rows_affected = m_database_command.ExecuteNonQuery()
            m_database_connection.Close()

        End Using
        If number_of_rows_affected = 0 Then
            Throw New DatabaseInsertException(command_string)
        End If
    End Sub

    'it returns the number of rows affected
    'if 0 something is wrong OR if the row was already deleted
    Public Sub ExecuteDelete(ByVal a_table As String, ByVal ParamArray a_restrictions As String())
        Dim number_of_rows_affected As Integer
        Dim command_string As String
        Using m_database_connection As New OleDbConnection(m_connection_String)

            command_string = m_database_query_factory.CreateDeleteStatement(a_table, a_restrictions)

            m_database_command = New OleDbCommand(command_string, m_database_connection)

            'connect and execute
            m_database_connection.Open()
            number_of_rows_affected = m_database_command.ExecuteNonQuery()
            m_database_connection.Close()

        End Using
        If number_of_rows_affected = 0 Then
            Throw New DatabaseDeleteException(command_string)
        End If
    End Sub

End Class
