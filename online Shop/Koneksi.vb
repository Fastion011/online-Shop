Imports MySql.Data.MySqlClient
Module Koneksi
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public adapter As MySqlDataAdapter
    Public baca As MySqlDataReader
    Public data As DataSet
    Public str As String
    Public mysql As String

    Sub buka()

        mysql = ("server = localhost ; port = 3306 ; userid = root ; password = ; database = db_online")
        conn = New MySqlConnection(mysql)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub


End Module
