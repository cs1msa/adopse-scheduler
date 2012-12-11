
Public Class ALDatabaseQueryFactory



    Public Function CreateSelectStatement(ByVal a_table As String, ByVal a_columns As String(), ByVal ParamArray a_restrictions As String())

        Dim statement As String = "Select "
        'add columns of interest
        For i As Integer = 0 To a_columns.Length - 1 Step 1

            statement = statement & a_columns(i)

            If Not i = a_columns.Length - 1 Then
                statement = statement & ", "
            End If

        Next

        statement = statement & " From " & a_table
        If a_restrictions.Length > 0 Then
            statement = statement & " Where "
        End If


        'add restrictions if any
        For i As Integer = 0 To a_restrictions.Length - 1 Step 1

            statement = statement & a_restrictions(i)

            If Not i = a_restrictions.Length - 1 Then
                statement = statement & " AND "
            End If

        Next

        statement = statement & ";"



        Return statement



    End Function


    Public Function CreateDeleteStatement(ByVal a_table As String, ByVal ParamArray a_restrictions As String())

        Dim statement As String = "Delete * From " & a_table

        If a_restrictions.Length > 0 Then
            statement = statement & " Where "
        End If
        'add restrictions / if not any restrictions the table will be emptied
        For i As Integer = 0 To a_restrictions.Length - 1 Step 1

            statement = statement & a_restrictions(i)

            If Not i = a_restrictions.Length - 1 Then
                statement = statement & " AND "
            End If

        Next

        statement = statement & ";"
        Return statement

    End Function


    Public Function CreateInsertStatement(ByVal a_table As String, ByVal a_values As String())


        Dim statement As String = "Insert Into " & a_table
       

        statement = statement & " Values ("

        'add values
        For i As Integer = 0 To a_values.Length - 1 Step 1

            statement = statement & a_values(i)

            If Not i = a_values.Length - 1 Then
                statement = statement & ", "
            End If

        Next

        statement = statement & ");"

        Return statement

    End Function

    Public Function CreateUpdateStatement(ByVal a_table As String, ByVal a_updates As String(), ByVal ParamArray a_restrictions As String())
        Dim statement As String = "Update " & a_table

        statement = statement & " Set "
        'add updates
        For i As Integer = 0 To a_updates.Length - 1 Step 1

            statement = statement & a_updates(i)

            If Not i = a_updates.Length - 1 Then

                statement = statement & ", "
            End If
        Next



        'add restrictions if any

        If a_restrictions.Length > 0 Then
            statement = statement & " Where "
        End If

        For i As Integer = 0 To a_restrictions.Length - 1 Step 1

            statement = statement & a_restrictions(i)

            If Not i = a_restrictions.Length - 1 Then
                statement = statement & " AND "
            End If

        Next

        statement = statement & ";"
        Return statement

    End Function

End Class
