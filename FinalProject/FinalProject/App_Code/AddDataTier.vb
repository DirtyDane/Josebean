Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Configuration.ConfigurationManager
Imports System.Web
Imports System.Collections
Imports System.Collections.Generic
Public Class AddDataTier
    Dim connString As New SqlClient.SqlConnection(ConnectionStrings("connString").ConnectionString)
    Dim cmdString As New SqlClient.SqlCommand
    Public Function AddPhysician(ByVal Fname As String, ByVal Midinit As String, ByVal Lname As String, ByVal DOB As String, ByVal HmPn As String, ByVal Cell As String, ByVal Gender As String, ByVal Address As String, ByVal City As String, ByVal State As String, ByVal Zip As String) As DataSet
        Try
            'open connection
            connString.Open()
            'THIS COMMENT IS A TEST TO SEE IF THINGS WORK NOW
            'command
            With cmdString
                .Parameters.Clear()
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 900
                .CommandText = "ADD_PHYSICIAN"
                'define input parameter
                .Parameters.Add("@FNAME", SqlDbType.VarChar, 25).Value = Fname
                .Parameters.Add("@LNAME", SqlDbType.VarChar, 25).Value = Lname
                .Parameters.Add("@Gender", SqlDbType.Char, 1).Value = Gender
                .Parameters.Add("@DOB", SqlDbType.Date).Value = DOB
                .Parameters.Add("@HOME_PHONE", SqlDbType.VarChar, 14).Value = HmPn
                .Parameters.Add("@CELL_PHONE", SqlDbType.VarChar, 14).Value = Cell
                .Parameters.Add("@PHY_ADDR", SqlDbType.VarChar, 60).Value = Address
                .Parameters.Add("@PHY_CITY", SqlDbType.VarChar, 30).Value = City
                .Parameters.Add("@PHY_STATE", SqlDbType.Char, 2).Value = State
                .Parameters.Add("@PHY_ZIP", SqlDbType.VarChar, 10).Value = Zip



                'executec command
                .ExecuteNonQuery()
            End With


        Catch ex As Exception

            Throw New ArgumentException(ex.Message)
        Finally
            connString.Close()
        End Try
    End Function
End Class


'Try

''open connection
'connString.Open()

''command
'With cmdString
'.Parameters.Clear()
'.Connection = connString
'.CommandType = CommandType.StoredProcedure
'.CommandTimeout = 900
'.CommandText = "UpdateStudent"
''define input parameter
'.Parameters.Add("@Stu_ID", SqlDbType.VarChar, 6).Value = stuID
'.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fname
'.Parameters.Add("@lname", SqlDbType.VarChar, 25).Value = lname
'.Parameters.Add("@DOB", SqlDbType.DateTime).Value = DOB
'.Parameters.Add("@gender_desc", SqlDbType.Char, 6).Value = gender_desc
'.Parameters.Add("@state", SqlDbType.Char, 2).Value = state


''executec command
'.ExecuteNonQuery()
'End With


'Catch ex As Exception

'Throw New ArgumentException(ex.Message)
'Finally
'connString.Close()

'End Try