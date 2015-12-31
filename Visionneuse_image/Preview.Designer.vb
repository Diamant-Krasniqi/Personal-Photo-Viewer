<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Preview))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripsave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripcouleur = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripfonds = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripaleat = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripbalai = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripgribouilli = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripmouche = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStriptache = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStriptissu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.picpreview = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.picpreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripsave, Me.ToolStripcouleur, Me.ToolStripfonds})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(200, 70)
        '
        'ToolStripsave
        '
        Me.ToolStripsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ToolStripsave.Image = CType(resources.GetObject("ToolStripsave.Image"), System.Drawing.Image)
        Me.ToolStripsave.Name = "ToolStripsave"
        Me.ToolStripsave.Size = New System.Drawing.Size(199, 22)
        Me.ToolStripsave.Text = "Enregistrer avec marges"
        Me.ToolStripsave.ToolTipText = "Enregistrer avec marges"
        '
        'ToolStripcouleur
        '
        Me.ToolStripcouleur.Image = CType(resources.GetObject("ToolStripcouleur.Image"), System.Drawing.Image)
        Me.ToolStripcouleur.Name = "ToolStripcouleur"
        Me.ToolStripcouleur.Size = New System.Drawing.Size(199, 22)
        Me.ToolStripcouleur.Text = "Couleur des marges"
        Me.ToolStripcouleur.ToolTipText = "Couleur des marges"
        '
        'ToolStripfonds
        '
        Me.ToolStripfonds.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripaleat, Me.ToolStripbalai, Me.ToolStripgribouilli, Me.ToolStripmouche, Me.ToolStriptache, Me.ToolStriptissu})
        Me.ToolStripfonds.Image = Global.Visionneuse_image.My.Resources.Resources.Aléatoires
        Me.ToolStripfonds.Name = "ToolStripfonds"
        Me.ToolStripfonds.Size = New System.Drawing.Size(199, 22)
        Me.ToolStripfonds.Text = "Fonds d'image"
        Me.ToolStripfonds.ToolTipText = "Fonds d'image"
        '
        'ToolStripaleat
        '
        Me.ToolStripaleat.Image = Global.Visionneuse_image.My.Resources.Resources.Aléatoires
        Me.ToolStripaleat.Name = "ToolStripaleat"
        Me.ToolStripaleat.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripaleat.Text = "Aléatoire"
        Me.ToolStripaleat.ToolTipText = "Aléatoire"
        '
        'ToolStripbalai
        '
        Me.ToolStripbalai.Image = Global.Visionneuse_image.My.Resources.Resources.Balayage
        Me.ToolStripbalai.Name = "ToolStripbalai"
        Me.ToolStripbalai.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripbalai.Text = "Balayage"
        Me.ToolStripbalai.ToolTipText = "Balayage"
        '
        'ToolStripgribouilli
        '
        Me.ToolStripgribouilli.Image = Global.Visionneuse_image.My.Resources.Resources.Gribouillis
        Me.ToolStripgribouilli.Name = "ToolStripgribouilli"
        Me.ToolStripgribouilli.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripgribouilli.Text = "Gribouillis"
        Me.ToolStripgribouilli.ToolTipText = "Gribouillis"
        '
        'ToolStripmouche
        '
        Me.ToolStripmouche.Image = Global.Visionneuse_image.My.Resources.Resources.Mouchetures
        Me.ToolStripmouche.Name = "ToolStripmouche"
        Me.ToolStripmouche.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripmouche.Text = "Mouchetures"
        Me.ToolStripmouche.ToolTipText = "Mouchetures"
        '
        'ToolStriptache
        '
        Me.ToolStriptache.Image = Global.Visionneuse_image.My.Resources.Resources.Taches
        Me.ToolStriptache.Name = "ToolStriptache"
        Me.ToolStriptache.Size = New System.Drawing.Size(144, 22)
        Me.ToolStriptache.Text = "Taches"
        Me.ToolStriptache.ToolTipText = "Taches"
        '
        'ToolStriptissu
        '
        Me.ToolStriptissu.Image = Global.Visionneuse_image.My.Resources.Resources.Tissu
        Me.ToolStriptissu.Name = "ToolStriptissu"
        Me.ToolStriptissu.Size = New System.Drawing.Size(144, 22)
        Me.ToolStriptissu.Text = "Tissus"
        Me.ToolStriptissu.ToolTipText = "Tissu"
        '
        'picpreview
        '
        Me.picpreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picpreview.ContextMenuStrip = Me.ContextMenuStrip1
        Me.picpreview.Location = New System.Drawing.Point(15, 15)
        Me.picpreview.Name = "picpreview"
        Me.picpreview.Size = New System.Drawing.Size(255, 230)
        Me.picpreview.TabIndex = 1
        Me.picpreview.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picpreview, "Clic droit pour les options")
        '
        'Preview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.picpreview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Preview"
        Me.Text = "Preview"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.picpreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripsave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents picpreview As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripcouleur As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripfonds As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripaleat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripbalai As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripgribouilli As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripmouche As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStriptache As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStriptissu As System.Windows.Forms.ToolStripMenuItem
End Class
