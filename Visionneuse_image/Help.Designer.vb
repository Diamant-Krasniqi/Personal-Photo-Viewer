<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Help))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cmdclose = New System.Windows.Forms.Button()
        Me.cmdopen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(9, 25)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(732, 502)
        Me.TextBox1.TabIndex = 11
        '
        'cmdclose
        '
        Me.cmdclose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdclose.Location = New System.Drawing.Point(338, 535)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(75, 23)
        Me.cmdclose.TabIndex = 15
        Me.cmdclose.Text = "Fermer"
        Me.cmdclose.UseVisualStyleBackColor = True
        '
        'cmdopen
        '
        Me.cmdopen.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdopen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdopen.Location = New System.Drawing.Point(240, 490)
        Me.cmdopen.Name = "cmdopen"
        Me.cmdopen.Size = New System.Drawing.Size(104, 23)
        Me.cmdopen.TabIndex = 16
        Me.cmdopen.Text = "Codes Sources"
        Me.cmdopen.UseVisualStyleBackColor = True
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 570)
        Me.Controls.Add(Me.cmdopen)
        Me.Controls.Add(Me.cmdclose)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Help"
        Me.Text = "Aide"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents cmdopen As System.Windows.Forms.Button
End Class
