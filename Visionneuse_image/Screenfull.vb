Option Strict On
Public Class Screenfull
    Private Sub Screenfull_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form1.Timer1.Stop()
    End Sub
    Private Sub Screenfull_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Picdiapo.Image = Form1.picLeft.Image 'affiche l'image
    End Sub
End Class