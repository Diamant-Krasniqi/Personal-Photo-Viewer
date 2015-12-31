<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lstvItem = New System.Windows.Forms.ListView()
        Me.imglst = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdactualise = New System.Windows.Forms.Button()
        Me.cmdhorizontal = New System.Windows.Forms.Button()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.cmdmode = New System.Windows.Forms.Button()
        Me.cmdsupp = New System.Windows.Forms.Button()
        Me.cmdzoom = New System.Windows.Forms.Button()
        Me.nudiapo = New System.Windows.Forms.NumericUpDown()
        Me.cmddiapo = New System.Windows.Forms.Button()
        Me.cmdrotate = New System.Windows.Forms.Button()
        Me.cmdsuiv = New System.Windows.Forms.Button()
        Me.cmdpreced = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.picLeft = New System.Windows.Forms.PictureBox()
        Me.picdelete = New System.Windows.Forms.PictureBox()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStriptxtchemin = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLargeur = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripHauteur = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButtonNB = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonsepia = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonredim = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStriprogner = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonmenu = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.nudiapo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picdelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvItem
        '
        Me.lstvItem.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstvItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstvItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lstvItem.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstvItem.HoverSelection = True
        Me.lstvItem.LargeImageList = Me.imglst
        Me.lstvItem.Location = New System.Drawing.Point(16, 10)
        Me.lstvItem.MultiSelect = False
        Me.lstvItem.Name = "lstvItem"
        Me.lstvItem.Size = New System.Drawing.Size(187, 561)
        Me.lstvItem.SmallImageList = Me.imglst
        Me.lstvItem.TabIndex = 142
        Me.lstvItem.UseCompatibleStateImageBehavior = False
        '
        'imglst
        '
        Me.imglst.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imglst.ImageSize = New System.Drawing.Size(100, 100)
        Me.imglst.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.cmdactualise)
        Me.Panel1.Controls.Add(Me.cmdhorizontal)
        Me.Panel1.Controls.Add(Me.HScrollBar1)
        Me.Panel1.Controls.Add(Me.VScrollBar1)
        Me.Panel1.Controls.Add(Me.cmdmode)
        Me.Panel1.Controls.Add(Me.cmdsupp)
        Me.Panel1.Controls.Add(Me.cmdzoom)
        Me.Panel1.Controls.Add(Me.nudiapo)
        Me.Panel1.Controls.Add(Me.cmddiapo)
        Me.Panel1.Controls.Add(Me.cmdrotate)
        Me.Panel1.Controls.Add(Me.cmdsuiv)
        Me.Panel1.Controls.Add(Me.cmdpreced)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.lstvItem)
        Me.Panel1.Controls.Add(Me.picLeft)
        Me.Panel1.Controls.Add(Me.picdelete)
        Me.Panel1.Location = New System.Drawing.Point(12, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(945, 608)
        Me.Panel1.TabIndex = 143
        '
        'cmdactualise
        '
        Me.cmdactualise.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdactualise.BackColor = System.Drawing.Color.Transparent
        Me.cmdactualise.BackgroundImage = CType(resources.GetObject("cmdactualise.BackgroundImage"), System.Drawing.Image)
        Me.cmdactualise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdactualise.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdactualise.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdactualise.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdactualise.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdactualise.Font = New System.Drawing.Font("Wingdings 3", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdactualise.Location = New System.Drawing.Point(81, 580)
        Me.cmdactualise.Name = "cmdactualise"
        Me.cmdactualise.Size = New System.Drawing.Size(28, 28)
        Me.cmdactualise.TabIndex = 168
        Me.ToolTip1.SetToolTip(Me.cmdactualise, "Actualiser")
        Me.cmdactualise.UseVisualStyleBackColor = False
        Me.cmdactualise.Visible = False
        '
        'cmdhorizontal
        '
        Me.cmdhorizontal.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdhorizontal.BackColor = System.Drawing.Color.Transparent
        Me.cmdhorizontal.BackgroundImage = CType(resources.GetObject("cmdhorizontal.BackgroundImage"), System.Drawing.Image)
        Me.cmdhorizontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdhorizontal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdhorizontal.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdhorizontal.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdhorizontal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdhorizontal.Font = New System.Drawing.Font("Wingdings 3", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdhorizontal.Location = New System.Drawing.Point(77, 580)
        Me.cmdhorizontal.Name = "cmdhorizontal"
        Me.cmdhorizontal.Size = New System.Drawing.Size(28, 28)
        Me.cmdhorizontal.TabIndex = 167
        Me.ToolTip1.SetToolTip(Me.cmdhorizontal, "Retournement horizontal")
        Me.cmdhorizontal.UseVisualStyleBackColor = False
        Me.cmdhorizontal.Visible = False
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HScrollBar1.Location = New System.Drawing.Point(209, 554)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(719, 17)
        Me.HScrollBar1.TabIndex = 165
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VScrollBar1.Location = New System.Drawing.Point(928, 0)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 571)
        Me.VScrollBar1.TabIndex = 145
        '
        'cmdmode
        '
        Me.cmdmode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdmode.BackColor = System.Drawing.Color.Transparent
        Me.cmdmode.BackgroundImage = Global.Visionneuse_image.My.Resources.Resources.image_resize
        Me.cmdmode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdmode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdmode.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdmode.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdmode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdmode.Font = New System.Drawing.Font("Wingdings 3", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdmode.Location = New System.Drawing.Point(208, 580)
        Me.cmdmode.Name = "cmdmode"
        Me.cmdmode.Size = New System.Drawing.Size(28, 28)
        Me.cmdmode.TabIndex = 164
        Me.ToolTip1.SetToolTip(Me.cmdmode, "Taille réelle")
        Me.cmdmode.UseVisualStyleBackColor = False
        Me.cmdmode.Visible = False
        '
        'cmdsupp
        '
        Me.cmdsupp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdsupp.BackColor = System.Drawing.Color.Transparent
        Me.cmdsupp.BackgroundImage = Global.Visionneuse_image.My.Resources.Resources.Shell32132
        Me.cmdsupp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdsupp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdsupp.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdsupp.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdsupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdsupp.Font = New System.Drawing.Font("Wingdings 3", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdsupp.Location = New System.Drawing.Point(140, 580)
        Me.cmdsupp.Name = "cmdsupp"
        Me.cmdsupp.Size = New System.Drawing.Size(28, 28)
        Me.cmdsupp.TabIndex = 163
        Me.ToolTip1.SetToolTip(Me.cmdsupp, "Delete")
        Me.cmdsupp.UseVisualStyleBackColor = False
        Me.cmdsupp.Visible = False
        '
        'cmdzoom
        '
        Me.cmdzoom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdzoom.BackColor = System.Drawing.Color.Transparent
        Me.cmdzoom.BackgroundImage = CType(resources.GetObject("cmdzoom.BackgroundImage"), System.Drawing.Image)
        Me.cmdzoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdzoom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdzoom.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdzoom.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdzoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdzoom.Font = New System.Drawing.Font("Wingdings 3", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdzoom.Location = New System.Drawing.Point(174, 580)
        Me.cmdzoom.Name = "cmdzoom"
        Me.cmdzoom.Size = New System.Drawing.Size(28, 28)
        Me.cmdzoom.TabIndex = 162
        Me.ToolTip1.SetToolTip(Me.cmdzoom, "Zoom sur l'image")
        Me.cmdzoom.UseVisualStyleBackColor = False
        Me.cmdzoom.Visible = False
        '
        'nudiapo
        '
        Me.nudiapo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudiapo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.nudiapo.Location = New System.Drawing.Point(242, 583)
        Me.nudiapo.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudiapo.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudiapo.Name = "nudiapo"
        Me.nudiapo.ReadOnly = True
        Me.nudiapo.Size = New System.Drawing.Size(37, 20)
        Me.nudiapo.TabIndex = 161
        Me.ToolTip1.SetToolTip(Me.nudiapo, "Intervalle diapo en secondes")
        Me.nudiapo.Value = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudiapo.Visible = False
        '
        'cmddiapo
        '
        Me.cmddiapo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmddiapo.BackgroundImage = Global.Visionneuse_image.My.Resources.Resources.diapo
        Me.cmddiapo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmddiapo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmddiapo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddiapo.Location = New System.Drawing.Point(285, 577)
        Me.cmddiapo.Name = "cmddiapo"
        Me.cmddiapo.Size = New System.Drawing.Size(28, 28)
        Me.cmddiapo.TabIndex = 160
        Me.ToolTip1.SetToolTip(Me.cmddiapo, "Démarrer le diaporama")
        Me.cmddiapo.UseVisualStyleBackColor = True
        Me.cmddiapo.Visible = False
        '
        'cmdrotate
        '
        Me.cmdrotate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdrotate.BackColor = System.Drawing.Color.Transparent
        Me.cmdrotate.BackgroundImage = CType(resources.GetObject("cmdrotate.BackgroundImage"), System.Drawing.Image)
        Me.cmdrotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdrotate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdrotate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdrotate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdrotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdrotate.Font = New System.Drawing.Font("Wingdings 3", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdrotate.Location = New System.Drawing.Point(111, 580)
        Me.cmdrotate.Name = "cmdrotate"
        Me.cmdrotate.Size = New System.Drawing.Size(28, 28)
        Me.cmdrotate.TabIndex = 159
        Me.ToolTip1.SetToolTip(Me.cmdrotate, "Rotation à droite")
        Me.cmdrotate.UseVisualStyleBackColor = False
        Me.cmdrotate.Visible = False
        '
        'cmdsuiv
        '
        Me.cmdsuiv.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdsuiv.BackColor = System.Drawing.Color.Transparent
        Me.cmdsuiv.BackgroundImage = Global.Visionneuse_image.My.Resources.Resources.previous
        Me.cmdsuiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdsuiv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdsuiv.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdsuiv.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdsuiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdsuiv.Font = New System.Drawing.Font("Wingdings 3", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdsuiv.Location = New System.Drawing.Point(643, 578)
        Me.cmdsuiv.Name = "cmdsuiv"
        Me.cmdsuiv.Size = New System.Drawing.Size(28, 28)
        Me.cmdsuiv.TabIndex = 158
        Me.ToolTip1.SetToolTip(Me.cmdsuiv, "Next")
        Me.cmdsuiv.UseVisualStyleBackColor = False
        '
        'cmdpreced
        '
        Me.cmdpreced.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdpreced.BackColor = System.Drawing.Color.Transparent
        Me.cmdpreced.BackgroundImage = Global.Visionneuse_image.My.Resources.Resources.back_NB
        Me.cmdpreced.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdpreced.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdpreced.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdpreced.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdpreced.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdpreced.Font = New System.Drawing.Font("Wingdings 3", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdpreced.Location = New System.Drawing.Point(402, 577)
        Me.cmdpreced.Name = "cmdpreced"
        Me.cmdpreced.Size = New System.Drawing.Size(28, 28)
        Me.cmdpreced.TabIndex = 157
        Me.ToolTip1.SetToolTip(Me.cmdpreced, "Before")
        Me.cmdpreced.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(33, 585)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(187, 13)
        Me.ProgressBar1.TabIndex = 155
        Me.ProgressBar1.Visible = False
        '
        'picLeft
        '
        Me.picLeft.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picLeft.BackColor = System.Drawing.Color.MediumPurple
        Me.picLeft.BackgroundImage = CType(resources.GetObject("picLeft.BackgroundImage"), System.Drawing.Image)
        Me.picLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picLeft.Location = New System.Drawing.Point(209, 10)
        Me.picLeft.Name = "picLeft"
        Me.picLeft.Size = New System.Drawing.Size(720, 561)
        Me.picLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLeft.TabIndex = 143
        Me.picLeft.TabStop = False
        '
        'picdelete
        '
        Me.picdelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picdelete.Location = New System.Drawing.Point(700, 459)
        Me.picdelete.Name = "picdelete"
        Me.picdelete.Size = New System.Drawing.Size(100, 92)
        Me.picdelete.TabIndex = 166
        Me.picdelete.TabStop = False
        Me.picdelete.Visible = False
        '
        'ToolStrip
        '
        Me.ToolStrip.BackColor = System.Drawing.Color.Silver
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripButton, Me.SaveToolStripButton, Me.HelpToolStripButton, Me.ToolStripLabel1, Me.ToolStriptxtchemin, Me.ToolStripLargeur, Me.ToolStripHauteur, Me.ToolStripButtonNB, Me.ToolStripButtonsepia, Me.ToolStripButtonredim, Me.ToolStripComboBox1, Me.ToolStriprogner, Me.ToolStripButtonmenu, Me.ToolStripButton1})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(969, 26)
        Me.ToolStrip.TabIndex = 144
        Me.ToolStrip.Text = "ToolStrip"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.OpenToolStripButton.Margin = New System.Windows.Forms.Padding(40, 1, 0, 2)
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 23)
        Me.OpenToolStripButton.Text = "Ouvrir"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.SaveToolStripButton.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 23)
        Me.SaveToolStripButton.Text = "Enregistrer"
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 23)
        Me.HelpToolStripButton.Text = "Aide"
        Me.HelpToolStripButton.Visible = False
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Margin = New System.Windows.Forms.Padding(9, 1, 0, 2)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripLabel1.Text = "NUMBER"
        Me.ToolStripLabel1.ToolTipText = "NUMBER"
        '
        'ToolStriptxtchemin
        '
        Me.ToolStriptxtchemin.BackColor = System.Drawing.Color.Silver
        Me.ToolStriptxtchemin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolStriptxtchemin.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ToolStriptxtchemin.Margin = New System.Windows.Forms.Padding(73, 0, 1, 0)
        Me.ToolStriptxtchemin.Name = "ToolStriptxtchemin"
        Me.ToolStriptxtchemin.ReadOnly = True
        Me.ToolStriptxtchemin.Size = New System.Drawing.Size(150, 26)
        Me.ToolStriptxtchemin.Text = "NAME"
        Me.ToolStriptxtchemin.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolStriptxtchemin.ToolTipText = "NAME"
        '
        'ToolStripLargeur
        '
        Me.ToolStripLargeur.AutoSize = False
        Me.ToolStripLargeur.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLargeur.Name = "ToolStripLargeur"
        Me.ToolStripLargeur.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripLargeur.Text = "WIDTH"
        Me.ToolStripLargeur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripLargeur.ToolTipText = "WIDTH"
        Me.ToolStripLargeur.Visible = False
        '
        'ToolStripHauteur
        '
        Me.ToolStripHauteur.AutoSize = False
        Me.ToolStripHauteur.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ToolStripHauteur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripHauteur.Name = "ToolStripHauteur"
        Me.ToolStripHauteur.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripHauteur.Text = "HEIGHT"
        Me.ToolStripHauteur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripHauteur.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.ToolStripHauteur.ToolTipText = "HEIGHT"
        Me.ToolStripHauteur.Visible = False
        '
        'ToolStripButtonNB
        '
        Me.ToolStripButtonNB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonNB.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButtonNB.Image = CType(resources.GetObject("ToolStripButtonNB.Image"), System.Drawing.Image)
        Me.ToolStripButtonNB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonNB.Margin = New System.Windows.Forms.Padding(70, 1, 0, 2)
        Me.ToolStripButtonNB.Name = "ToolStripButtonNB"
        Me.ToolStripButtonNB.Size = New System.Drawing.Size(144, 23)
        Me.ToolStripButtonNB.Text = "BLACK AND WHITE"
        '
        'ToolStripButtonsepia
        '
        Me.ToolStripButtonsepia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonsepia.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButtonsepia.Image = CType(resources.GetObject("ToolStripButtonsepia.Image"), System.Drawing.Image)
        Me.ToolStripButtonsepia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonsepia.Margin = New System.Windows.Forms.Padding(120, 1, 0, 2)
        Me.ToolStripButtonsepia.Name = "ToolStripButtonsepia"
        Me.ToolStripButtonsepia.Size = New System.Drawing.Size(54, 23)
        Me.ToolStripButtonsepia.Text = "SEPIA"
        '
        'ToolStripButtonredim
        '
        Me.ToolStripButtonredim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonredim.Image = Global.Visionneuse_image.My.Resources.Resources.Collapse
        Me.ToolStripButtonredim.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonredim.Name = "ToolStripButtonredim"
        Me.ToolStripButtonredim.Size = New System.Drawing.Size(23, 23)
        Me.ToolStripButtonredim.Text = "Redimensionner"
        Me.ToolStripButtonredim.ToolTipText = "Redimensionner en cm"
        Me.ToolStripButtonredim.Visible = False
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(75, 26)
        Me.ToolStripComboBox1.ToolTipText = "Choisissez votre dimension en cm"
        Me.ToolStripComboBox1.Visible = False
        '
        'ToolStriprogner
        '
        Me.ToolStriprogner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStriprogner.Image = CType(resources.GetObject("ToolStriprogner.Image"), System.Drawing.Image)
        Me.ToolStriprogner.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStriprogner.Name = "ToolStriprogner"
        Me.ToolStriprogner.Size = New System.Drawing.Size(23, 23)
        Me.ToolStriprogner.Text = "Rogner l'image"
        Me.ToolStriprogner.Visible = False
        '
        'ToolStripButtonmenu
        '
        Me.ToolStripButtonmenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonmenu.Image = CType(resources.GetObject("ToolStripButtonmenu.Image"), System.Drawing.Image)
        Me.ToolStripButtonmenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonmenu.Name = "ToolStripButtonmenu"
        Me.ToolStripButtonmenu.Size = New System.Drawing.Size(23, 23)
        Me.ToolStripButtonmenu.Text = "Creer menu contextuel"
        Me.ToolStripButtonmenu.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 23)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.Visible = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Photo Viewer"
        Me.NotifyIcon1.Visible = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Photo Viewer"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(969, 662)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "  PHOTO VIEWER"
        Me.Panel1.ResumeLayout(False)
        CType(Me.nudiapo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picdelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstvItem As System.Windows.Forms.ListView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents picLeft As System.Windows.Forms.PictureBox
    Friend WithEvents imglst As System.Windows.Forms.ImageList
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStriptxtchemin As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLargeur As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripHauteur As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ToolStripButtonNB As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonsepia As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmdsuiv As System.Windows.Forms.Button
    Friend WithEvents cmdpreced As System.Windows.Forms.Button
    Friend WithEvents cmdrotate As System.Windows.Forms.Button
    Friend WithEvents cmddiapo As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents nudiapo As System.Windows.Forms.NumericUpDown
    Friend WithEvents ToolStripButtonredim As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cmdzoom As System.Windows.Forms.Button
    Friend WithEvents cmdsupp As System.Windows.Forms.Button
    Friend WithEvents cmdmode As System.Windows.Forms.Button
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents picdelete As System.Windows.Forms.PictureBox
    Friend WithEvents cmdhorizontal As System.Windows.Forms.Button
    Friend WithEvents ToolStriprogner As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdactualise As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButtonmenu As ToolStripButton
End Class
