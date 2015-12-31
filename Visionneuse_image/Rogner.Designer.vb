<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rogner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rogner))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdrevers = New System.Windows.Forms.Button()
        Me.cmdinvers = New System.Windows.Forms.Button()
        Me.txtpix_h = New System.Windows.Forms.TextBox()
        Me.txtpix_w = New System.Windows.Forms.TextBox()
        Me.rdbfree = New System.Windows.Forms.RadioButton()
        Me.rdbcm = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblpx_w = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblpx_h = New System.Windows.Forms.Label()
        Me.txtcm_w = New System.Windows.Forms.TextBox()
        Me.txtcm_h = New System.Windows.Forms.TextBox()
        Me.rdbpx = New System.Windows.Forms.RadioButton()
        Me.btncolor = New System.Windows.Forms.Button()
        Me.cmdplan = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnRotate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.help = New System.Windows.Forms.Button()
        Me.btnrapercu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblresol = New System.Windows.Forms.Label()
        Me.lblhaut_cm = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblhaut = New System.Windows.Forms.Label()
        Me.lbllarg_cm = New System.Windows.Forms.Label()
        Me.lbllarg = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdrevers)
        Me.GroupBox2.Controls.Add(Me.cmdinvers)
        Me.GroupBox2.Controls.Add(Me.txtpix_h)
        Me.GroupBox2.Controls.Add(Me.txtpix_w)
        Me.GroupBox2.Controls.Add(Me.rdbfree)
        Me.GroupBox2.Controls.Add(Me.rdbcm)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblpx_w)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblpx_h)
        Me.GroupBox2.Controls.Add(Me.txtcm_w)
        Me.GroupBox2.Controls.Add(Me.txtcm_h)
        Me.GroupBox2.Controls.Add(Me.rdbpx)
        Me.GroupBox2.Location = New System.Drawing.Point(264, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(295, 86)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        '
        'cmdrevers
        '
        Me.cmdrevers.BackgroundImage = CType(resources.GetObject("cmdrevers.BackgroundImage"), System.Drawing.Image)
        Me.cmdrevers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdrevers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdrevers.Location = New System.Drawing.Point(60, 60)
        Me.cmdrevers.Name = "cmdrevers"
        Me.cmdrevers.Size = New System.Drawing.Size(33, 25)
        Me.cmdrevers.TabIndex = 49
        Me.cmdrevers.UseVisualStyleBackColor = True
        '
        'cmdinvers
        '
        Me.cmdinvers.BackgroundImage = CType(resources.GetObject("cmdinvers.BackgroundImage"), System.Drawing.Image)
        Me.cmdinvers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdinvers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdinvers.Location = New System.Drawing.Point(60, 20)
        Me.cmdinvers.Name = "cmdinvers"
        Me.cmdinvers.Size = New System.Drawing.Size(33, 25)
        Me.cmdinvers.TabIndex = 48
        Me.cmdinvers.UseVisualStyleBackColor = True
        '
        'txtpix_h
        '
        Me.txtpix_h.Location = New System.Drawing.Point(101, 63)
        Me.txtpix_h.Name = "txtpix_h"
        Me.txtpix_h.Size = New System.Drawing.Size(43, 20)
        Me.txtpix_h.TabIndex = 44
        Me.txtpix_h.Text = "1200"
        '
        'txtpix_w
        '
        Me.txtpix_w.Location = New System.Drawing.Point(6, 63)
        Me.txtpix_w.Name = "txtpix_w"
        Me.txtpix_w.Size = New System.Drawing.Size(43, 20)
        Me.txtpix_w.TabIndex = 43
        Me.txtpix_w.Text = "1600"
        '
        'rdbfree
        '
        Me.rdbfree.AutoSize = True
        Me.rdbfree.Location = New System.Drawing.Point(185, 44)
        Me.rdbfree.Name = "rdbfree"
        Me.rdbfree.Size = New System.Drawing.Size(91, 17)
        Me.rdbfree.TabIndex = 42
        Me.rdbfree.Text = "Sélection libre"
        Me.rdbfree.UseVisualStyleBackColor = True
        '
        'rdbcm
        '
        Me.rdbcm.AutoSize = True
        Me.rdbcm.Checked = True
        Me.rdbcm.Location = New System.Drawing.Point(185, 25)
        Me.rdbcm.Name = "rdbcm"
        Me.rdbcm.Size = New System.Drawing.Size(101, 17)
        Me.rdbcm.TabIndex = 1
        Me.rdbcm.TabStop = True
        Me.rdbcm.Text = "Recadrer en cm"
        Me.rdbcm.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Largeur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Hauteur"
        '
        'lblpx_w
        '
        Me.lblpx_w.AutoSize = True
        Me.lblpx_w.Location = New System.Drawing.Point(6, 48)
        Me.lblpx_w.Name = "lblpx_w"
        Me.lblpx_w.Size = New System.Drawing.Size(0, 13)
        Me.lblpx_w.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(150, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "pixel"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(150, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "cm"
        '
        'lblpx_h
        '
        Me.lblpx_h.AutoSize = True
        Me.lblpx_h.Location = New System.Drawing.Point(101, 48)
        Me.lblpx_h.Name = "lblpx_h"
        Me.lblpx_h.Size = New System.Drawing.Size(0, 13)
        Me.lblpx_h.TabIndex = 33
        '
        'txtcm_w
        '
        Me.txtcm_w.Location = New System.Drawing.Point(6, 24)
        Me.txtcm_w.Name = "txtcm_w"
        Me.txtcm_w.Size = New System.Drawing.Size(43, 20)
        Me.txtcm_w.TabIndex = 28
        Me.txtcm_w.Text = "10"
        '
        'txtcm_h
        '
        Me.txtcm_h.Location = New System.Drawing.Point(101, 24)
        Me.txtcm_h.Name = "txtcm_h"
        Me.txtcm_h.Size = New System.Drawing.Size(43, 20)
        Me.txtcm_h.TabIndex = 32
        Me.txtcm_h.Text = "15"
        '
        'rdbpx
        '
        Me.rdbpx.AutoSize = True
        Me.rdbpx.Location = New System.Drawing.Point(185, 64)
        Me.rdbpx.Name = "rdbpx"
        Me.rdbpx.Size = New System.Drawing.Size(108, 17)
        Me.rdbpx.TabIndex = 0
        Me.rdbpx.Text = "Recadrer en pixel"
        Me.rdbpx.UseVisualStyleBackColor = True
        '
        'btncolor
        '
        Me.btncolor.BackgroundImage = CType(resources.GetObject("btncolor.BackgroundImage"), System.Drawing.Image)
        Me.btncolor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncolor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncolor.Location = New System.Drawing.Point(129, 7)
        Me.btncolor.Name = "btncolor"
        Me.btncolor.Size = New System.Drawing.Size(45, 45)
        Me.btncolor.TabIndex = 42
        Me.ToolTip1.SetToolTip(Me.btncolor, "Couleur rectangle de sélection")
        Me.btncolor.UseVisualStyleBackColor = True
        '
        'cmdplan
        '
        Me.cmdplan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdplan.Location = New System.Drawing.Point(565, 65)
        Me.cmdplan.Name = "cmdplan"
        Me.cmdplan.Size = New System.Drawing.Size(92, 23)
        Me.cmdplan.TabIndex = 48
        Me.cmdplan.Text = "Image 1er plan"
        Me.ToolTip1.SetToolTip(Me.cmdplan, "Utiliser les valeurs de l'image de 1er plan")
        Me.cmdplan.UseVisualStyleBackColor = True
        '
        'btnRotate
        '
        Me.btnRotate.BackgroundImage = Global.Visionneuse_image.My.Resources.Resources.rotate
        Me.btnRotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRotate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRotate.Enabled = False
        Me.btnRotate.Location = New System.Drawing.Point(6, 7)
        Me.btnRotate.Name = "btnRotate"
        Me.btnRotate.Size = New System.Drawing.Size(45, 45)
        Me.btnRotate.TabIndex = 49
        Me.ToolTip1.SetToolTip(Me.btnRotate, "Rotation droite de l'image")
        Me.btnRotate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Location = New System.Drawing.Point(66, 7)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(45, 45)
        Me.btnSave.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.btnSave, "Enregistrez votre image recadrée")
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'help
        '
        Me.help.BackgroundImage = CType(resources.GetObject("help.BackgroundImage"), System.Drawing.Image)
        Me.help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.help.Cursor = System.Windows.Forms.Cursors.Hand
        Me.help.Location = New System.Drawing.Point(588, 13)
        Me.help.Name = "help"
        Me.help.Size = New System.Drawing.Size(45, 45)
        Me.help.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.help, "Aide")
        Me.help.UseVisualStyleBackColor = True
        '
        'btnrapercu
        '
        Me.btnrapercu.BackgroundImage = CType(resources.GetObject("btnrapercu.BackgroundImage"), System.Drawing.Image)
        Me.btnrapercu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnrapercu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrapercu.Location = New System.Drawing.Point(189, 7)
        Me.btnrapercu.Name = "btnrapercu"
        Me.btnrapercu.Size = New System.Drawing.Size(45, 45)
        Me.btnrapercu.TabIndex = 61
        Me.ToolTip1.SetToolTip(Me.btnrapercu, "Aperçu recadrage et cadre image")
        Me.btnrapercu.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnrapercu)
        Me.GroupBox1.Controls.Add(Me.lblresol)
        Me.GroupBox1.Controls.Add(Me.lblhaut_cm)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblhaut)
        Me.GroupBox1.Controls.Add(Me.lbllarg_cm)
        Me.GroupBox1.Controls.Add(Me.lbllarg)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnRotate)
        Me.GroupBox1.Controls.Add(Me.btncolor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 86)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        '
        'lblresol
        '
        Me.lblresol.AutoSize = True
        Me.lblresol.Location = New System.Drawing.Point(186, 72)
        Me.lblresol.Name = "lblresol"
        Me.lblresol.Size = New System.Drawing.Size(0, 13)
        Me.lblresol.TabIndex = 58
        '
        'lblhaut_cm
        '
        Me.lblhaut_cm.AutoSize = True
        Me.lblhaut_cm.Location = New System.Drawing.Point(97, 72)
        Me.lblhaut_cm.Name = "lblhaut_cm"
        Me.lblhaut_cm.Size = New System.Drawing.Size(77, 13)
        Me.lblhaut_cm.TabIndex = 57
        Me.lblhaut_cm.Text = "Hauteur en cm"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(186, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Résolution "
        '
        'lblhaut
        '
        Me.lblhaut.AutoSize = True
        Me.lblhaut.Location = New System.Drawing.Point(98, 55)
        Me.lblhaut.Name = "lblhaut"
        Me.lblhaut.Size = New System.Drawing.Size(76, 13)
        Me.lblhaut.TabIndex = 54
        Me.lblhaut.Text = "Hauteur image"
        '
        'lbllarg_cm
        '
        Me.lbllarg_cm.AutoSize = True
        Me.lbllarg_cm.Location = New System.Drawing.Point(6, 72)
        Me.lbllarg_cm.Name = "lbllarg_cm"
        Me.lbllarg_cm.Size = New System.Drawing.Size(78, 13)
        Me.lbllarg_cm.TabIndex = 56
        Me.lbllarg_cm.Text = "Largeur en  cm"
        '
        'lbllarg
        '
        Me.lbllarg.AutoSize = True
        Me.lbllarg.Location = New System.Drawing.Point(6, 55)
        Me.lbllarg.Name = "lbllarg"
        Me.lbllarg.Size = New System.Drawing.Size(74, 13)
        Me.lbllarg.TabIndex = 53
        Me.lbllarg.Text = "Largeur image"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "cm"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(139, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "cm"
        '
        'Rogner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 585)
        Me.Controls.Add(Me.help)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdplan)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Rogner"
        Me.Text = "Rogner l'image"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdrevers As System.Windows.Forms.Button
    Friend WithEvents cmdinvers As System.Windows.Forms.Button
    Friend WithEvents txtpix_h As System.Windows.Forms.TextBox
    Friend WithEvents txtpix_w As System.Windows.Forms.TextBox
    Friend WithEvents rdbfree As System.Windows.Forms.RadioButton
    Friend WithEvents rdbcm As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblpx_w As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblpx_h As System.Windows.Forms.Label
    Friend WithEvents txtcm_w As System.Windows.Forms.TextBox
    Friend WithEvents txtcm_h As System.Windows.Forms.TextBox
    Friend WithEvents rdbpx As System.Windows.Forms.RadioButton
    Friend WithEvents btncolor As System.Windows.Forms.Button
    Friend WithEvents cmdplan As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnRotate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblhaut_cm As System.Windows.Forms.Label
    Friend WithEvents lbllarg_cm As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblhaut As System.Windows.Forms.Label
    Friend WithEvents lbllarg As System.Windows.Forms.Label
    Friend WithEvents help As System.Windows.Forms.Button
    Friend WithEvents lblresol As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnrapercu As System.Windows.Forms.Button
End Class
