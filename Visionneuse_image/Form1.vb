Option Strict On
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Public Class Form1
#Region "Déclarations"
    Const LVM_FIRST As Integer = &H1000
    Const LVM_SETICONSPACING As Integer = LVM_FIRST + 53
    Public IndexdInsertion As Integer
    Const CtrlMask As Byte = 8
    Public Shared ftype As String = ".gif.GIF.bmp.BMP.jpg.Jpg.jpeg.JPG.png.PNG.tif.TIF.ppm"
    Public Shared imgPaths() As String
    Dim chemin As String
    Dim memochemin As String
    Dim count As Integer
    Dim filedelete As String
    Dim normal As Boolean
    Dim supprime As Boolean

    Dim counter As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
    Dim Key As Microsoft.Win32.RegistryKey
    Dim img As Image

    Dim image_attr As New ImageAttributes
    Dim cm As ColorMatrix
    Dim bm As Bitmap
    Dim gr As Graphics

    Dim ext As String
    Dim r, pixel As Integer
    Dim rapport As Double
#End Region
#Region "Ouverture et fermeture"
    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.WindowState = CBool(Me.WindowState)
        My.Settings.memochemin = memochemin
        My.Settings.filedelete = filedelete
        My.Settings.Save()
        If supprime = True Then
            Process.Start(Application.ExecutablePath)
        End If
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If My.Settings.WindowState Then Me.WindowState = FormWindowState.Maximized
        filedelete = My.Settings.filedelete
        normal = False
       VScrollBar1.Visible = False
        HScrollBar1.Visible = False
        memochemin = My.Settings.memochemin
        ToolStripComboBox1.Text = "15"
        Verification()

        If File.Exists(filedelete) Then
            Try
                supprimer(filedelete, picdelete)
                supprime = False
                filedelete = ""
                chemin = memochemin
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


        For Each s As String In My.Application.CommandLineArgs
            chemin = s
        Next s
        If chemin = "" Then Exit Sub
        affichelistview()
        memochemin = chemin
    End Sub
    Private Sub OpenToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripButton.Click
        Dim opendir As New FolderBrowserDialog
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = 100
        lstvItem.Items.Clear()
        With opendir
            If memochemin = "" Then

            Else
                .SelectedPath = memochemin
                .Description = memochemin
            End If
            .ShowNewFolderButton = False
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                chemin = .SelectedPath
                memochemin = .SelectedPath
                affichelistview()
            Else
                MessageBox.Show("Operation cancelled", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            .Dispose()
        End With
    End Sub
    Private Sub cmdactualise_Click(sender As System.Object, e As System.EventArgs) Handles cmdactualise.Click
        If picLeft.Image Is Nothing Then Exit Sub
        affichelistview()
    End Sub
    Private Sub affichelistview()
        LstFill(chemin)
        If lstvItem.Items.Count = 0 Then Exit Sub
        lstvItem.Items.Item(0).Selected = True
        lstvItem.Focus()
    End Sub
    Private Sub HelpToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles HelpToolStripButton.Click
        Help.Show()
    End Sub
#End Region
#Region "Imageviewer"
    Private Sub LstFill(ByVal ipath As String)
        Dim xx As Integer = 0

        If ipath.Trim.Length = 0 Then
            MessageBox.Show("Le chemin d'accès spécifié n'existe pas. Veuillez recommencer.", "Ouverture dossier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If ipath.EndsWith("\") = False Then
            ipath += "\"
        End If
        If Directory.Exists(ipath) = False Then
            MessageBox.Show("Le chemin d'accès spécifié n'existe pas. Veuillez recommencer.", "Ouverture dossier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Try
            Dim ist As String
            Dim i As Integer = 0
            Dim opt As System.IO.SearchOption = System.IO.SearchOption.TopDirectoryOnly
            Me.Cursor = Cursors.WaitCursor

            With lstvItem
                .BeginUpdate()
                .Clear()
            End With
            imglst.Images.Clear()
            ReDim imgPaths(0)


            For Each ist In Directory.GetFiles(ipath, "*", opt)
                If ftype.Contains(Path.GetExtension(ist)) = True Then
                    ReDim Preserve imgPaths(i)
                    imgPaths(i) = ist
                    Select Case Path.GetExtension(ist)
                        Case Is = ".gif", ".GIF"
                            imglst.Images.Add(My.Resources.gif)
                        Case Is = ".bmp", ".BMP"
                            imglst.Images.Add(My.Resources.bmp)
                        Case Is = ".jpg", ".Jpg", ".JPG", ".jpeg"
                            imglst.Images.Add(My.Resources.jpg)
                        Case Is = ".png", ".PNG"
                            imglst.Images.Add(My.Resources.png)
                        Case Is = ".tif", ".TIF"
                            imglst.Images.Add(My.Resources.tif)
                        Case Is = ".ppm"
                            imglst.Images.Add(My.Resources.ppm)
                    End Select
                    With lstvItem
                        .Items.Add(Path.GetFileNameWithoutExtension(ist), i)
                        .Items.Item(i).SubItems.Add(ist)
                    End With
                    xx += 1
                    i += 1
                End If
            Next
            Me.Cursor = Cursors.Arrow
            lstvItem.EndUpdate()
            Application.DoEvents()

            counter = My.Computer.FileSystem.GetFiles(chemin)
            ProgressBar1.Maximum = counter.Count

            If Me.lstvItem.Items.Count <> 0 Then
                For i = 0 To imglst.Images.Count - 1

                    imglst.Images.Item(i) = ExtractImage(imgPaths(i), 100, 100)
                    lstvItem.RedrawItems(i, i, True)
                    ProgressBar1.Value = i
                    Application.DoEvents()
                Next
                ProgressBar1.Value = counter.Count
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, " Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If lstvItem.Items.Count <> 0 Then
            ToolStripLabel1.Text = CStr(lstvItem.Items.Count) & " images"
        End If
    End Sub
    Private Sub lstvItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvItem.SelectedIndexChanged

        Try
            Dim s As String = lstvItem.SelectedItems(0).SubItems(1).Text
            If File.Exists(s) = True Then
                picLeft.Image = Image.FromFile(s)
                picLeft.SizeMode = PictureBoxSizeMode.Zoom
                img = Image.FromFile(s)
                Me.Text = s
                ext = System.IO.Path.GetExtension(Me.Text)
                ToolStripLargeur.Text = img.Width.ToString
                ToolStripHauteur.Text = img.Height.ToString
                r = CInt(img.VerticalResolution.ToString)
                ToolStriptxtchemin.Text = Path.GetFileNameWithoutExtension(s)
                VScrollBar1.Visible = False
                HScrollBar1.Visible = False
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region
#Region "Enregistrement"
    Private Sub SaveToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripButton.Click
        Try

            If picLeft.Image Is Nothing Then
                MessageBox.Show("No new picture", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim saveFD As SaveFileDialog = New SaveFileDialog
            With saveFD
                .FileName = ToolStriptxtchemin.Text & "_copie"
                .InitialDirectory = chemin

                .Filter = "JPeg Files (*.jpg,*.jpeg)|*.jpg;*.jpeg|Bitmap Files (*.bmp)|*.bmp|Gif Files (*.gif)|*.gif|Png Files (*.png)|*.png|TIFF Files (*.tif)|*.tif"

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    bm = New Bitmap(img.Width, img.Height)
                    bm = CType(img, Bitmap)
                    bm.SetResolution(r, r)
                    Select Case .FileName.EndsWith("")
                        Case .FileName.EndsWith(".jpg", True, Nothing)

                            bm.Save(.FileName, Drawing.Imaging.ImageFormat.Jpeg)
                        Case .FileName.EndsWith(".gif", True, Nothing)

                            bm.Save(.FileName, Drawing.Imaging.ImageFormat.Gif)
                        Case .FileName.EndsWith(".bmp", True, Nothing)

                            bm.Save(.FileName, Drawing.Imaging.ImageFormat.Bmp)
                        Case .FileName.EndsWith(".png", True, Nothing)

                            bm.Save(.FileName, Drawing.Imaging.ImageFormat.Png)
                        Case .FileName.EndsWith(".tif", True, Nothing)

                            bm.Save(.FileName, Drawing.Imaging.ImageFormat.Tiff)
                        Case Else
                            bm.Save(.FileName, Drawing.Imaging.ImageFormat.Jpeg)
                    End Select
                Else
                    MessageBox.Show("Operation cancelled", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                .Dispose()
                Process.Start(IO.Path.GetDirectoryName(.FileName))
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, " Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "Convertir image en Noir et blanc, Sépia, Redimensionner en cm et rogner l'image"

    Private Sub ToolStripButtonNB_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonNB.Click
        If picLeft.Image Is Nothing Then Exit Sub
        Dim rect As Rectangle = Rectangle.Round(picLeft.Image.GetBounds(GraphicsUnit.Pixel))
        Dim wid As Integer = picLeft.Image.Width
        Dim hgt As Integer = picLeft.Image.Height

        bm = New Bitmap(wid, hgt)
        gr = Graphics.FromImage(bm)
        cm = New ColorMatrix(New Single()() _
               {New Single() {0.3, 0.3, 0.3, 0, 0}, _
               New Single() {0.59, 0.59, 0.59, 0, 0}, _
               New Single() {0.11, 0.11, 0.11, 0, 0}, _
               New Single() {0, 0, 0, 1, 0}, _
               New Single() {0, 0, 0, 0, 1}})
        image_attr.SetColorMatrix(cm)
        gr.DrawImage(picLeft.Image, rect, 0, 0, wid, hgt, GraphicsUnit.Pixel, image_attr)
        picLeft.Image = bm
        SaveImage(bm, chemin & "\" & ToolStriptxtchemin.Text & "_NB" & ext, ext, r)
        Process.Start(chemin & "\")

        cmdactualise.PerformClick() 'actualiser listview
    End Sub
    Private Sub ToolStripButtonsepia_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonsepia.Click
        If picLeft.Image Is Nothing Then Exit Sub
        Dim rect As Rectangle = Rectangle.Round(picLeft.Image.GetBounds(GraphicsUnit.Pixel))
        Dim wid As Integer = picLeft.Image.Width
        Dim hgt As Integer = picLeft.Image.Height
        'Sepia
        bm = New Bitmap(wid, hgt)
        gr = Graphics.FromImage(bm)
        cm = New ColorMatrix(New Single()() { _
        New Single() {0.393, 0.349, 0.272, 0, 0}, _
        New Single() {0.769, 0.686, 0.534, 0, 0}, _
        New Single() {0.189, 0.168, 0.131, 0, 0}, _
        New Single() {0, 0, 0, 1, 0}, _
        New Single() {0, 0, 0, 0, 1}})
        image_attr.SetColorMatrix(cm)
        gr.DrawImage(picLeft.Image, rect, 0, 0, wid, hgt, GraphicsUnit.Pixel, image_attr)
        picLeft.Image = bm
        SaveImage(bm, chemin & "\" & ToolStriptxtchemin.Text & "_sepia" & ext, ext, r)
        Process.Start(chemin & "\")

        cmdactualise.PerformClick()
    End Sub
    Private Sub ToolStripButtonredim_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonredim.Click
        If picLeft.Image Is Nothing Then Exit Sub
        pixel = CInt(CDbl(ToolStripComboBox1.Text) * (r * 0.3937))
        If CDbl(ToolStripLargeur.Text) < CDbl(ToolStripHauteur.Text) Then
            rapport = CDbl(ToolStripHauteur.Text) / CDbl(ToolStripLargeur.Text)
            RedimensionnerImage(Me.Text, CInt(CDbl(pixel) / rapport), CInt(pixel))
        Else
            rapport = (CDbl(ToolStripLargeur.Text) / CDbl(ToolStripHauteur.Text))
            RedimensionnerImage(Me.Text, CInt(pixel), CInt(CDbl(pixel) / rapport))
        End If
    End Sub
    Public Sub RedimensionnerImage(ByRef cheminOrigine As String, ByVal largeur As Integer, ByVal hauteur As Integer)

        Dim imageSource As New Bitmap(cheminOrigine)

        Dim bp As New Bitmap(largeur, hauteur)
        Dim gr As Graphics = Graphics.FromImage(bp)

        gr.DrawImage(imageSource, 0, 0, bp.Width + 1, bp.Height + 1)
        SaveImage(bp, chemin & "\" & ToolStriptxtchemin.Text & "_redim" & ext, ext, r)
        Process.Start(chemin & "\")

        cmdactualise.PerformClick()
    End Sub
    Private Sub ToolStriprogner_Click(sender As System.Object, e As System.EventArgs) Handles ToolStriprogner.Click
        If picLeft.Image Is Nothing Then Exit Sub
        Rogner.Text = Me.Text
        Rogner.ShowDialog()
    End Sub

    Public Sub SaveImage(ByVal btmp As Bitmap, ByRef cheminDestination As String, ByVal extension As String, ByVal resolution As Integer)
        btmp.SetResolution(resolution, resolution)

        Select Case extension
            Case ".jpg"
                btmp.Save(cheminDestination, Imaging.ImageFormat.Jpeg)
            Case ".bmp"
                btmp.Save(cheminDestination, Imaging.ImageFormat.Bmp)
            Case ".gif"
                btmp.Save(cheminDestination, Imaging.ImageFormat.Gif)
            Case ".tif"
                btmp.Save(cheminDestination, Imaging.ImageFormat.Tiff)
            Case ".png"
                btmp.Save(cheminDestination, Imaging.ImageFormat.Png)
            Case Else
                btmp.Save(cheminDestination, Imaging.ImageFormat.Jpeg)
        End Select
    End Sub
  #End Region
#Region "Infos métadonnées EXIF"
    Private Sub picLeft_Click(sender As System.Object, e As System.EventArgs) Handles picLeft.Click
        Try
            Dim Repertoire As New System.IO.DirectoryInfo(Me.Text)
            Dim img As Image = Image.FromFile(Me.Text)
            Dim w As Integer = CInt(img.Width)
            Dim h As Integer = CInt(img.Height)
            Dim r As Integer = CInt(img.HorizontalResolution)
            Dim prop As PropertyItem = img.GetPropertyItem(&H9003)
            Dim sDate As String = System.Text.Encoding.ASCII.GetString(prop.Value, 0, prop.Len).TrimEnd(Chr(0))
            Dim dateTimeOriginal As DateTime = DateTime.ParseExact(sDate, "yyyy:MM:dd HH:mm:ss", Nothing)
            Dim prop_2 As PropertyItem = img.GetPropertyItem(&H110)
            Dim result As String = System.Text.Encoding.ASCII.GetString(prop_2.Value, 0, prop.Len).TrimEnd(Chr(0))


            Me.ToolTip1.SetToolTip(Me.picLeft, "Date prise de vue: " & CStr(dateTimeOriginal) & Environment.NewLine _
            & "Modèle camera: " & CStr(result) & Environment.NewLine _
            & "Taille de l'image: " & Me.Text.Length / 100 & " Mo" & Environment.NewLine _
            & "Hauteur de l'image: " & (h) & " px" & Environment.NewLine _
            & "Hauteur en cm: " & Format((h / r) * 2.54, "Fixed") & " cm" & Environment.NewLine _
            & "Largeur de l'image: " & (w) & " px" & Environment.NewLine _
            & "Largeur en cm: " & Format((w / r) * 2.54, "Fixed") & " cm" & Environment.NewLine _
            & "Résolution de l'image: " & (r) & " ppp" & Environment.NewLine _
            & "Date de création: " & Repertoire.CreationTime.ToString & Environment.NewLine _
            & "Dernière modification: " & Repertoire.LastWriteTime.ToString & Environment.NewLine _
            & "Dernier accès: " & Repertoire.LastAccessTime.ToString)
        Catch ex As Exception
            Me.ToolTip1.SetToolTip(Me.picLeft, "Absence de métadonnées EXIF")

        End Try
    End Sub
#End Region
#Region "Dépacement, diapo, zoom, mode normal, retournement horizontal et rotation image"
    Private Sub cmdpreced_Click(sender As System.Object, e As System.EventArgs) Handles cmdpreced.Click
        If picLeft.Image Is Nothing Then Exit Sub
        Dim int As Integer = CInt(lstvItem.SelectedIndices(0).ToString)
        count = lstvItem.Items.Count - 1
        If int = 0 Then
            lstvItem.Items.Item(count).Selected = True
            lstvItem.Items.Item(count).EnsureVisible()
            lstvItem.Focus()
            cmdsuiv.Enabled = True
        Else
            lstvItem.Items.Item(int - 1).Selected = True
            lstvItem.Items.Item(int - 1).EnsureVisible()
            lstvItem.Focus()
        End If
    End Sub
    Private Sub cmdsuiv_Click(sender As System.Object, e As System.EventArgs) Handles cmdsuiv.Click
        If picLeft.Image Is Nothing Then Exit Sub
        Dim int As Integer = CInt(lstvItem.SelectedIndices(0).ToString)
        count = lstvItem.Items.Count - 1
        If int = lstvItem.Items.Count - 1 Then
            lstvItem.Items.Item(0).Selected = True
            lstvItem.Items.Item(0).EnsureVisible()
            lstvItem.Focus()
        Else
            lstvItem.Items.Item(int + 1).Selected = True
            lstvItem.Items.Item(int + 1).EnsureVisible()
            lstvItem.Focus()
        End If
    End Sub
    Private Sub cmdrotate_Click(sender As System.Object, e As System.EventArgs) Handles cmdrotate.Click
        If picLeft.Image Is Nothing Then Exit Sub
        picLeft.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        picLeft.Refresh()
    End Sub
    Private Sub cmdhorizontal_Click(sender As System.Object, e As System.EventArgs) Handles cmdhorizontal.Click
        If picLeft.Image Is Nothing Then Exit Sub
        picLeft.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
        picLeft.Refresh()
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Screenfull.Picdiapo.Image = picLeft.Image
        Screenfull.Text = ToolStriptxtchemin.Text
        cmdsuiv.PerformClick()
    End Sub
    Private Sub cmddiapo_Click(sender As System.Object, e As System.EventArgs) Handles cmddiapo.Click
        If picLeft.Image Is Nothing Then Exit Sub
        Timer1.Interval = CInt(nudiapo.Value * 1000)
        Timer1.Start()
        Screenfull.ShowDialog()
    End Sub
    Private Sub cmdzoom_Click(sender As System.Object, e As System.EventArgs) Handles cmdzoom.Click
        If picLeft.Image Is Nothing Then Exit Sub
        Zoom.ShowDialog()
    End Sub
    Private Sub cmdmode_Click(sender As System.Object, e As System.EventArgs) Handles cmdmode.Click
        If picLeft.Image Is Nothing Then Exit Sub
        HScrollBar1.Maximum = picLeft.Image.Width - picLeft.Width + HScrollBar1.Height
        VScrollBar1.Maximum = picLeft.Image.Height - picLeft.Height + VScrollBar1.Width
        If normal = True Then
            picLeft.SizeMode = PictureBoxSizeMode.Zoom
            VScrollBar1.Visible = False
            HScrollBar1.Visible = False
            normal = False
            ToolTip1.SetToolTip(cmdmode, "Taille réelle")
        Else
            picLeft.SizeMode = PictureBoxSizeMode.Normal
            VScrollBar1.Visible = True
            HScrollBar1.Visible = True
            normal = True
            ToolTip1.SetToolTip(cmdmode, "Rétablir")
        End If
    End Sub
    Private Sub VScrollBar1_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBar1.Scroll
        Dim gphpicLeftBox As Graphics = picLeft.CreateGraphics()
        gphpicLeftBox.DrawImage(picLeft.Image, New Rectangle(0, 0, _
            picLeft.Width - HScrollBar1.Height, _
            picLeft.Height - VScrollBar1.Width), _
            New Rectangle(HScrollBar1.Value, VScrollBar1.Value, _
            picLeft.Width - HScrollBar1.Height, _
            picLeft.Height - VScrollBar1.Width), GraphicsUnit.Pixel)
    End Sub
    Private Sub HScrollBar1_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll
        Dim gphpicLeftBox As Graphics = picLeft.CreateGraphics()
        gphpicLeftBox.DrawImage(picLeft.Image, New Rectangle(0, 0, _
            picLeft.Width - HScrollBar1.Height, _
            picLeft.Height - VScrollBar1.Width), _
            New Rectangle(HScrollBar1.Value, VScrollBar1.Value, _
            picLeft.Width - HScrollBar1.Height, _
            picLeft.Height - VScrollBar1.Width), GraphicsUnit.Pixel)
    End Sub
#End Region
#Region "Supprimer fichier"

    Private Sub cmdsupp_Click(sender As System.Object, e As System.EventArgs) Handles cmdsupp.Click
        If picLeft.Image Is Nothing Then Exit Sub
        filedelete = Me.Text
        supprime = True
        Me.Close()
    End Sub
    Private Sub supprimer(ByVal chemin As String, ByVal pic As PictureBox)
        If Not (pic.Image Is Nothing) Then
            pic.Image.Dispose()
            pic.Image = Nothing
        End If

        Dim MyStream As FileStream = New FileStream(chemin, FileMode.Open)

        pic.Image = Image.FromStream(MyStream)

        MyStream.Close()
        GC.Collect()

        My.Computer.FileSystem.DeleteFile(chemin, UIOption.AllDialogs, RecycleOption.SendToRecycleBin) 'envoie le fichier à la corbeille
        MessageBox.Show("Fichier envoyé à la corbeille", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region
#Region "Menu contextuel"
    Private Sub ToolStripButtonmenu_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonmenu.Click
        If Not IsAdmin() Then
            MessageBox.Show(("La modification du menu contextuel de l'explorateur ne se fera pas car vous n'avez pas les " & _
                "droits d'administrateur." & Environment.NewLine & "Pour modifier cette option, vous devez fermer ce programme " & _
               " et le relancer en tant qu'administrateur."), "Droits d'administrateur", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If ToolStripButtonmenu.Text = "Creer menu contextuel" Then

                My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\Folder\shell\Ouvrir dossier images\command", "", My.Application.Info.DirectoryPath & "\" & "Visionneuse_image.exe " & """%1""")
                MessageBox.Show("Votre clé est créée", "Création clé registre", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ToolStripButtonmenu.Text = "Supprimer menu contextuel"
                ToolStripButtonmenu.ToolTipText = "Supprimer menu contextuel"
            Else

                ToolStripButtonmenu.Text = "Supprimer menu contextuel"
                Key = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("Folder\shell", True)
                Key.DeleteSubKeyTree("Ouvrir dossier images")
                MessageBox.Show("Votre clé est supprimée", "Suppression clé registre", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ToolStripButtonmenu.Text = "Creer menu contextuel"
                ToolStripButtonmenu.ToolTipText = "Creer menu contextuel"
            End If
        End If
    End Sub

    Private Sub Verification()
        Dim test As Microsoft.Win32.RegistryKey = My.Computer.Registry.ClassesRoot.OpenSubKey("\Folder\shell\Ouvrir dossier images\command", False)
        If test Is Nothing Then
            ToolStripButtonmenu.Text = "Creer menu contextuel"
        Else
            ToolStripButtonmenu.Text = "Supprimer menu contextuel"
        End If
    End Sub

    Private Sub ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip.ItemClicked

    End Sub

    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs) Handles ToolStripComboBox1.Click

    End Sub

    Private Sub nudiapo_ValueChanged(sender As Object, e As EventArgs) Handles nudiapo.ValueChanged

    End Sub

    Private Sub ToolStripHauteur_Click(sender As Object, e As EventArgs) Handles ToolStripHauteur.Click

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click

    End Sub

    Private Function IsAdmin() As Boolean
        Return My.User.IsInRole(Microsoft.VisualBasic.ApplicationServices.BuiltInRole.Administrator)
    End Function
#End Region
End Class
