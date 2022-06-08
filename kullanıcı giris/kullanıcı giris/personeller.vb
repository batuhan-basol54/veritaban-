Imports MySql.Data.MySqlClient

Public Class personeller

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
        gosterverileri()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        conn.Open() 'MySQL Aç
        vr.Connection = conn 'İçeriden marfomu seç
        vr.CommandText = sql 'Sorgu yaz
        vr.ExecuteNonQuery() 'Çalıştıra bas
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text <> "" And TextBox1.Text <> "" And Textkullan.Text <> "" And Textsifre.Text <> "" Then

            calistir("insert into personeller(p_adsoyad,p_tel,p_kullanici,p_sifre)  values('" + TextBox2.Text + "','" + TextBox1.Text + "','" + Textkullan.Text + "','" + Textsifre.Text + "')")

            gosterverileri()
        Else
            MsgBox("verileri girmelisiniz")
        End If
        TextBox2.Text = ""
        TextBox1.Text = ""
        Textkullan.Text = ""
        Textsifre.Text = ""
    End Sub
    Private Sub gosterverileri()
        Dim dtb As New DataTable()
        ListView1.Items.Clear()
        dtb = raporla("select * from personeller")
        If (dtb.Rows.Count > 0) Then
            For i As Integer = 0 To dtb.Rows.Count - 1
                Dim lst As New ListViewItem
                lst.Text = dtb.Rows(i)("p_id").ToString
                lst.SubItems.Add(dtb.Rows(i)("p_adsoyad").ToString)
                lst.SubItems.Add(dtb.Rows(i)("p_tel").ToString)
                lst.SubItems.Add(dtb.Rows(i)("p_kullanici").ToString)
                lst.SubItems.Add(dtb.Rows(i)("p_sifre").ToString)
                ListView1.Items.Add(lst)
            Next
        End If
    End Sub

    Public Function raporla(ByVal sorgu As String) As DataTable

        conn.Open()
        Dim adp As New MySqlDataAdapter(sorgu, conn)
        Dim dtTemp As New DataTable()
        adp.Fill(dtTemp)
        raporla = dtTemp
        conn.Close()

    End Function



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtpid.Text <> "" And TextBox2.Text <> "" And TextBox1.Text <> "" And Textkullan.Text <> "" And Textsifre.Text <> "" Then
            calistir("update personeller set p_adsoyad='" + TextBox2.Text + "',p_tel='" + TextBox1.Text + "',p_kullanici='" + Textkullan.Text + "',p_sifre='" + Textsifre.Text + "' where  p_id='" + txtpid.Text.ToString + "'")
            txtpid.Text = ""
            TextBox2.Text = ""
            TextBox1.Text = ""
            Textkullan.Text = ""
            Textsifre.Text = ""
            gosterverileri()
        End If
    End Sub





    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim dtb As New DataTable()
            Dim secili As Integer = 0
            Dim secili1 As String = 0

            secili = ListView1.SelectedIndices(0)
            MessageBox.Show(ListView1.Items(secili).SubItems(0).Text)
            secili1 = ListView1.Items(secili).SubItems(0).Text + ListView1.Items(secili).SubItems(1).Text + ListView1.Items(secili).SubItems(2).Text
            If MessageBox.Show(secili1, "kayıt", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                calistir("delete from personeller  where  p_id='" + ListView1.Items(secili).SubItems(0).Text + "'")
                txtsilid.Text = ""
                gosterverileri()
            End If

        End If
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        Dim dtb As New DataTable()
        Dim secili As Integer = 0
        dtb = raporla("select * from personeller")
        secili = ListView1.SelectedIndices(0)
        txtpid.Text = dtb.Rows(secili)(0).ToString
        TextBox2.Text = dtb.Rows(secili)(1).ToString
        TextBox1.Text = dtb.Rows(secili)(2).ToString
        Textkullan.Text = dtb.Rows(secili)(3).ToString
        Textsifre.Text = dtb.Rows(secili)(4).ToString

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub


End Class
