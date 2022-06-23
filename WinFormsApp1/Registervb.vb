Public Class Registervb
    Private Sub Registervb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Registervb_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Close()
    End Sub

    Private Sub Uaddress_Click(sender As Object, e As EventArgs) Handles Uaddress.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class