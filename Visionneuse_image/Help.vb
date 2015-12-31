Option Strict On
Public Class Help
    Private Sub cmdclose_Click_1(sender As System.Object, e As System.EventArgs) Handles cmdclose.Click
        Me.Hide()
    End Sub
    Private Sub cmdopen_Click_1(sender As System.Object, e As System.EventArgs) Handles cmdopen.Click
        System.Diagnostics.Process.Start("https://github.com/Diamant-Krasniqi")
    End Sub
    Private Sub Aide_Load_1(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Resources.Aide
    End Sub
End Class