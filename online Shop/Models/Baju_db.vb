Imports MySql.Data.MySqlClient
Public Class Baju_db

    Public id_baju As Integer
    Public nama_baju As String
    Public ukuran_baju As String
    Public jenis_kain As String
    Public harga As Integer
    Public url As String

    'simpan data ke database
    Sub Simpan()
        Call buka()
        Dim input As String = "insert into baju values ('" & id_baju & "','" &
            nama_baju & "','" & ukuran_baju & "','" & jenis_kain & "','" & harga & "', '" & url & "')"
        cmd = New MySqlCommand(input, conn)
        cmd.ExecuteNonQuery()
    End Sub

    Sub Delete()
        Call buka()
        Dim hapus As String = "Delete from baju where id_baju = '" & id_baju & "' "
        cmd = New MySqlCommand(hapus, conn)
        cmd.ExecuteNonQuery()
    End Sub


End Class
