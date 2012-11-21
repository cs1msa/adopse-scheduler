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

    Const m_connection_String2 As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\AssDatabase.mdb"
    Const m_connection_String As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Doublecross Black\Desktop\ass team\adopse-scheduler\Src\AdopseSuperScheduler\AssUI\bin\Debug\AssDatabase.mdb"

    Dim m_database_connection As OleDbConnection
    Dim m_database_command As OleDbCommand
    Dim m_data_adapter As OleDbDataAdapter

    Dim m_dataset As DataSet


    Dim m_database_query_factory As ALDatabaseQueryFactory

    Public Sub New()

        m_dataset = New DataSet("Log")
        m_database_query_factory = New ALDatabaseQueryFactory
        m_data_adapter = New OleDbDataAdapter("select * from Log", m_database_connection)
    End Sub

    Public Sub SaveToSourceDatabase()
        Using m_database_connection As New OleDbConnection(m_connection_String)
            
        End Using

    End Sub

    Public Function ExecuteSelect(ByVal a_table As String, ByVal a_columns As String(), ByVal ParamArray a_restrictions As String())
        Using m_database_connection As New OleDbConnection(m_connection_String)

            Dim command_string = m_database_query_factory.CreateSelectStatement(a_table, a_columns, a_restrictions)

            m_database_command = New OleDbCommand(command_string, m_database_connection)

            m_data_adapter.SelectCommand = m_database_command

            m_database_connection.Open()

            Dim data_table As New DataTable
            m_data_adapter.Fill(data_table)

            m_database_connection.Close()

            Dim rowString As New String("")
            For Each i As DataRow In data_table.Rows
                For Each item As Object In i.ItemArray
                    rowString = rowString & item.ToString & " | "

                Next
                rowString = rowString & vbCrLf
            Next


        End Using


        Return (True)
    End Function


    Public Function ExecuteInsert(ByVal a_table As String, ByVal a_values As String())

        Using m_database_connection As New OleDbConnection(m_connection_String)



            m_data_adapter = New OleDbDataAdapter("select * From " & a_table, m_database_connection)
            'create insert command for the adapter
            m_data_adapter.InsertCommand = New OleDbCommand(m_database_query_factory.CreateInsertStatement(a_table, a_values), m_database_connection)
            

            m_database_connection.Open()
            m_data_adapter.InsertCommand.ExecuteNonQuery()
            m_database_connection.Close()

        End Using
        Return True
    End Function

    Public Function ExecuteDelete(ByVal a_table As String, ByVal ParamArray a_restrictions As String())

        Using m_database_connection As New OleDbConnection(m_connection_String)



            m_data_adapter = New OleDbDataAdapter("select * From " & a_table, m_database_connection)
            'create delete command for the adapter
            m_data_adapter.DeleteCommand = New OleDbCommand(m_database_query_factory.CreateDeleteStatement(a_table, a_restrictions), m_database_connection)


            m_database_connection.Open()
            m_data_adapter.DeleteCommand.ExecuteNonQuery()
            m_database_connection.Close()

        End Using
        Return True

    End Function

End Class
