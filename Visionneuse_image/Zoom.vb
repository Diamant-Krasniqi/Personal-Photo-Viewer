Option Strict On
Public Class Zoom
    Private Sub TrackBarzoom_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBarzoom.Scroll
        Dim y, x As Integer
        If piczoom.Image Is Nothing Then Exit Sub
        With Me.Panel1
            .AutoScroll = True
            .AutoScrollMinSize = New Size(piczoom.Width, piczoom.Height)
            .Dock = DockStyle.Fill
        End With
        Me.ToolTip1.SetToolTip(TrackBarzoom, "Zoom X " & TrackBarzoom.Value) 'On affiche l'info
        piczoom.Height = y + (50 * TrackBarzoom.Value)
        piczoom.Width = x + (50 * TrackBarzoom.Value)
        'Centrage de l'image pendant le zoom
        piczoom.Left = CInt((Panel1.Width - 1 * piczoom.Width) / 2)
        piczoom.Top = CInt((Panel1.Height - 1 * piczoom.Height) / 2)
    End Sub
    Private Sub Zoom_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.piczoom.Image = Form1.picLeft.Image 'affiche l'image
    End Sub
End Class