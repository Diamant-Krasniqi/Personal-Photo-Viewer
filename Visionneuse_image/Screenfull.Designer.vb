<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Screenfull
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Screenfull))
        Me.Picdiapo = New System.Windows.Forms.PictureBox()
        CType(Me.Picdiapo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picdiapo
        '
        Me.Picdiapo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Picdiapo.Location = New System.Drawing.Point(12, 12)
        Me.Picdiapo.Name = "Picdiapo"
        Me.Picdiapo.Size = New System.Drawing.Size(457, 320)
        Me.Picdiapo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picdiapo.TabIndex = 0
        Me.Picdiapo.TabStop = False
        '
        'Screenfull
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 344)
        Me.Controls.Add(Me.Picdiapo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Screenfull"
        Me.Text = "Diaporama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Picdiapo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Picdiapo As System.Windows.Forms.PictureBox
End Class
