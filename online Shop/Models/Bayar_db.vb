Imports MySql.Data.MySqlClient
Public Class Bayar_db
    Public nama_baju As String
    Public ukuran_baju As String
    Public jenis_kain As String
    Public harga As Integer
    Public pembayaran As String
    Public jumlah As Integer
    Public total As Integer

    Sub Simpan()

        Call buka()
        Dim input As String = "insert into detail values ('" & nama_baju & "','" & ukuran_baju & "','" & jenis_kain & "','" & harga & "', '" & pembayaran & "', '" & jumlah & "', '" & total & "')"
        cmd = New MySqlCommand(input, conn)
        cmd.ExecuteNonQuery()
    End Sub
End Class
