Public Class anaform
    Private Sub anaform_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.IsMdiContainer = True

        Dim child1 As New personeller()
        child1.MdiParent = Me
        child1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.IsMdiContainer = True
        Dim child1 As New müşteriler()
        child1.MdiParent = Me
        child1.Show()
    End Sub


End Class