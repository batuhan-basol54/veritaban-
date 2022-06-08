Imports MySql.Data.MySqlClient
Public Class Form1

    Dim conn As New MySql.Data.MySqlClient.MySqlConnection
    Dim myConnectionString As String



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mysql'le bağlantı kurma 
        myConnectionString = "server=localhost;" _
                    & "uid=root;" _
                    & "pwd=1234;" _
                    & "port=5454;" _
                    & "database=Batuhan"
        conn.ConnectionString = myConnectionString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'mysql bağlı mı değılmı
        Try
            conn.Open()
            MessageBox.Show(conn.State.ToString())
            conn.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public vr As New MySqlCommand

    Private Sub calistir(ByVal sql As String)
        conn.Open()
        vr.Connection = conn
        vr.CommandText = sql
        vr.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Function raporla(ByVal sorgu As String) As DataTable

        conn.Open()
        Dim adp As New MySqlDataAdapter(sorgu, conn)
        Dim dtTemp As New DataTable()
        adp.Fill(dtTemp)
        raporla = dtTemp
        conn.Close()

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim slc As New DataTable()
        slc = raporla("select * from personeller where p_kullanici='" + TextBox1.Text + "'")
        If (slc.Rows.Count > 0) Then
            If slc.Rows(0)("p_sifre").ToString = TextBox2.Text Then

                anaform.Show()
                Me.Hide()
            Else
                MessageBox.Show("Kullanıcı şifresi hatalı")
            End If
        Else
            MessageBox.Show("Kullanıcı Yok")
        End If

    End Sub
End Class
