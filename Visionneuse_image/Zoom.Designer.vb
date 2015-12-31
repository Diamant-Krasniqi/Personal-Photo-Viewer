<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Zoom
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Zoom))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.piczoom = New System.Windows.Forms.PictureBox()
        Me.TrackBarzoom = New System.Windows.Forms.TrackBar()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.piczoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarzoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.piczoom)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 474)
        Me.Panel1.TabIndex = 1
        '
        'piczoom
        '
        Me.piczoom.Location = New System.Drawing.Point(3, 0)
        Me.piczoom.Name = "piczoom"
        Me.piczoom.Size = New System.Drawing.Size(783, 471)
        Me.piczoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.piczoom.TabIndex = 0
        Me.piczoom.TabStop = False
        '
        'TrackBarzoom
        '
        Me.TrackBarzoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TrackBarzoom.Location = New System.Drawing.Point(285, 492)
        Me.TrackBarzoom.Maximum = 100
        Me.TrackBarzoom.Minimum = 10
        Me.TrackBarzoom.Name = "TrackBarzoom"
        Me.TrackBarzoom.Size = New System.Drawing.Size(232, 45)
        Me.TrackBarzoom.TabIndex = 164
        Me.TrackBarzoom.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackBarzoom.Value = 10
        '
        'Zoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 559)
        Me.Controls.Add(Me.TrackBarzoom)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "Zoom"
        Me.Text = "Zoom"
        Me.Panel1.ResumeLayout(False)
        CType(Me.piczoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarzoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents piczoom As System.Windows.Forms.PictureBox
    Friend WithEvents TrackBarzoom As System.Windows.Forms.TrackBar
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
