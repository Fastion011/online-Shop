Imports MySql.Data.MySqlClient
Public Class Celana_db
    Public id_celana As Integer
    Public nama_celana As String
    Public ukuran_celana As String
    Public jenis_kain As String
    Public harga As Integer
    Public url As String

    Sub Simpan()
        Call buka()
        Dim input As String = "insert into celana values ('" & id_celana & "' ,
'" & nama_celana & "', '" & ukuran_celana & "', '" & jenis_kain & "', '" & harga & "', '" & url & "')"

        cmd = New MySqlCommand(input, conn)
        cmd.ExecuteNonQuery()

    End Sub

    Sub Hapus()
        Call buka()
        Dim delete As String = "Delete from celana where id_celana = '" & id_celana & "'"
        cmd = New MySqlCommand(delete, conn)
        cmd.ExecuteNonQuery()

    End Sub

End Class
