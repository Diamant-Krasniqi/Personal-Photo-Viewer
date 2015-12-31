
Option Strict On
Public Class Rogner
#Region " Déclaration"
    Private gIdRegion As New clsRegion()
    Private WithEvents pic As clsPicId ' picture qui va contenir l'image
    Dim pixel As Integer = 180 'résolution ppp
    Dim img As Image
    Dim couleur As Color 'rectangle de sélection
    Dim t1, t2, t3, t4 As Decimal
#End Region
    Private Class clsPicId
        Inherits PictureBox
        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)
        End Sub
    End Class
#Region "Ouverture et fermeture"
    Private Sub Rogner_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.couleur = couleur
        My.Settings.Save()
        Me.Controls.Remove(pic)
    End Sub
    Private Sub Rogner_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pic = New clsPicId
        Me.Controls.Add(pic)
        couleur = My.Settings.couleur
        gIdRegion.selectfree = False
        pic.Top = btnRotate.Bottom + 50
        pic.Left = 20
        pic.Width = Me.Width - 40
        pic.Height = Me.Height - pic.Top - 40
        pic.SizeMode = PictureBoxSizeMode.StretchImage
        pic.BorderStyle = BorderStyle.Fixed3D
        pic.ImageLocation = Me.Text
        img = Image.FromFile(Me.Text)
        pixel = CInt(img.HorizontalResolution)
        lblresol.Text = CStr(pixel) & " ppp"
        lbllarg.Text = "Largeur: " & CStr(img.Width) & " px"
        lbllarg_cm.Text = CStr((img.Width / pixel) * 2.54)
        lblhaut.Text = "Hauteur: " & CStr(img.Height) & " px"
        lblhaut_cm.Text = CStr((img.Height / pixel) * 2.54)
        btnRotate.Enabled = True
        txtcm_h.Text = "10"
        txtcm_w.Text = "15"
        ToolTip1.SetToolTip(cmdinvers, "Mode Portrait")
        ToolTip1.SetToolTip(cmdrevers, "Mode Portrait")
    End Sub
    Private Sub lbllarg_cm_TextChanged(sender As Object, e As System.EventArgs) Handles lbllarg_cm.TextChanged
        lbllarg_cm.Text = Format(lbllarg_cm.Text, "Fixed")
    End Sub
    Private Sub lblhaut_cm_TextChanged(sender As Object, e As System.EventArgs) Handles lblhaut_cm.TextChanged
        lblhaut_cm.Text = Format(lblhaut_cm.Text, "Fixed")
    End Sub
    Private Sub btnRotate_Click(sender As System.Object, e As System.EventArgs) Handles btnRotate.Click
        pic.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        NewImageWasLoaded()
        pic.Refresh()
        btnRotate.Enabled = False
    End Sub
    Private Sub help_Click(sender As System.Object, e As System.EventArgs) Handles help.Click
        Form1.HelpToolStripButton.PerformClick()
    End Sub
#End Region
#Region "Rectangle de sélection"
    Private Sub NewImageWasLoaded()
        ResizeImage()
    End Sub
    Private Sub ResizeImage()
        If Not pic.Image Is Nothing Then
            Dim ratio As Double = pic.Image.PhysicalDimension.Width / pic.Image.PhysicalDimension.Height
            If pic.Width > pic.Height * ratio Then
                pic.Width = CInt(pic.Height * ratio)
            Else
                pic.Height = CInt(pic.Width / ratio)
            End If
            gIdRegion.Bounds = pic.DisplayRectangle
        End If
    End Sub
    Private Sub pic_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pic.Paint
        gIdRegion.Draw(e.Graphics, couleur)
    End Sub
    Private Sub pic_LoadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles pic.LoadCompleted
        NewImageWasLoaded()
    End Sub
    Private Sub pic_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pic.MouseDown
        If rdbfree.Checked = False Then
            gIdRegion.ratio = CSng(CDbl(lblpx_w.Text) / CDbl(lblpx_h.Text))
        End If
        gIdRegion.CheckMouseDown(e.Location, pic)
    End Sub
    Private Sub pic_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic.MouseMove
        gIdRegion.CheckMouseMove(e.Location, pic)
    End Sub
    Private Sub pic_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic.MouseUp
        gIdRegion.CheckMouseUp(e.Location, pic)
    End Sub

    Private Function RegionToPixels() As RectangleF
        Dim factorH As Double = pic.Image.PhysicalDimension.Width / pic.Width
        Dim factorV As Double = pic.Image.PhysicalDimension.Height / pic.Height
        RegionToPixels = gIdRegion.ScaledRectF(factorH, factorV)
    End Function
    Private Sub btncolor_Click(sender As System.Object, e As System.EventArgs) Handles btncolor.Click
        Dim myColorDialog As New ColorDialog()
        With myColorDialog

            .AllowFullOpen = True

            .ShowHelp = True
            .AllowFullOpen = True
            .FullOpen = True
            .AnyColor = True

            .Color = couleur

            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                couleur = .Color
            End If
        End With
    End Sub
#End Region
#Region "Enregistrement"
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If pic.Image Is Nothing Then Exit Sub
        Dim dlgFile As New SaveFileDialog
        Dim sPath As String
        With dlgFile
            sPath = pic.ImageLocation
            .FileName = IO.Path.GetDirectoryName(sPath) & _
                            IO.Path.DirectorySeparatorChar & _
                            IO.Path.GetFileNameWithoutExtension(sPath) & "_Rec"
            .FilterIndex = 1
            .Filter = "JPeg Files (*.jpg,*.jpeg)|*.jpg;*.jpeg|Bitmap Files (*.bmp)|*.bmp|Gif Files (*.gif)|*.gif|Tif Files (*.tif)|*.tif|Png Files (*.png)|*.png"
            .OverwritePrompt = True
            .CheckPathExists = True
            .Title = "Enregistrer Image"
            If .ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim r As RectangleF = RegionToPixels()
                'sélection libre
                If rdbfree.Checked = True Then
                    Dim bm As New Bitmap(CInt(r.Width), CInt(r.Height), pic.Image.PixelFormat)
                    Dim rDest As New RectangleF(0, 0, r.Width, r.Height)
                    Dim g As Graphics = Graphics.FromImage(bm)
                    g.DrawImage(pic.Image, rDest, r, GraphicsUnit.Pixel)
                    g.Dispose()
                    bm.SetResolution(pixel, pixel)

                    saveimg(.FileName, bm)
                    bm.Dispose()
                Else

                    Dim bm As New Bitmap(CInt(lblpx_w.Text), CInt(lblpx_h.Text), pic.Image.PixelFormat)
                    Dim rDest As New RectangleF(0, 0, CSng(lblpx_w.Text), CSng(lblpx_h.Text))
                    Dim g As Graphics = Graphics.FromImage(bm)
                    g.DrawImage(pic.Image, rDest, r, GraphicsUnit.Pixel)
                    g.Dispose()
                    bm.SetResolution(pixel, pixel)

                    saveimg(.FileName, bm)
                    bm.Dispose()
                End If
                Process.Start(IO.Path.GetDirectoryName(.FileName))
                Form1.cmdactualise.PerformClick()
            Else
                MessageBox.Show("Operation cancelled", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            .Dispose()
        End With
        Me.Close()
    End Sub
    Private Sub saveimg(ByVal dest As String, ByVal btm As Bitmap)
        Select Case dest.EndsWith("")
            Case dest.EndsWith(".jpg", True, Nothing)
                btm.Save(dest, System.Drawing.Imaging.ImageFormat.Jpeg)
            Case dest.EndsWith(".gif", True, Nothing)
                btm.Save(dest, System.Drawing.Imaging.ImageFormat.Gif)
            Case dest.EndsWith(".bmp", True, Nothing)
                btm.Save(dest, System.Drawing.Imaging.ImageFormat.Bmp)
            Case dest.EndsWith(".png", True, Nothing)
                btm.Save(dest, System.Drawing.Imaging.ImageFormat.Png)
            Case dest.EndsWith(".tif", True, Nothing)
                btm.Save(dest, System.Drawing.Imaging.ImageFormat.Tiff)
            Case Else
                btm.Save(dest, System.Drawing.Imaging.ImageFormat.Jpeg)
        End Select
    End Sub
#End Region
#Region "Option recadrage"
    Private Sub txtcm_w_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtcm_w.KeyPress
        If Asc(e.KeyChar) = 46 Then e.KeyChar = CChar(",")
        If Asc(e.KeyChar) = 44 And (CType(sender, TextBox).Text.IndexOf(",") > 0 Or CType(sender, TextBox).Text = "") Then e.Handled = False
        txtcm_w.MaxLength = 5

        If (e.KeyChar = ",") Then If (txtcm_w.Text.Contains(",")) Then e.Handled = True
    End Sub
    Private Sub txtcm_w_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcm_w.TextChanged
        If Not IsNumeric(txtcm_w.Text) Then Exit Sub
        If CDbl(txtcm_w.Text) < 1 Then Exit Sub
        lblpx_w.Text = CStr(CDbl(txtcm_w.Text) * (pixel * 0.3937))
    End Sub
    Private Sub txtcm_h_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtcm_h.KeyPress
        If Asc(e.KeyChar) = 46 Then e.KeyChar = CChar(",")
        If Asc(e.KeyChar) = 44 And (CType(sender, TextBox).Text.IndexOf(",") > 0 Or CType(sender, TextBox).Text = "") Then e.Handled = False
        txtcm_h.MaxLength = 5

        If (e.KeyChar = ",") Then If (txtcm_h.Text.Contains(",")) Then e.Handled = True
    End Sub
    Private Sub txtcm_h_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcm_h.TextChanged
        If Not IsNumeric(txtcm_h.Text) Then Exit Sub
        If CDbl(txtcm_h.Text) < 1 Then Exit Sub
        lblpx_h.Text = CStr(CDbl(txtcm_h.Text) * (pixel * 0.3937))
    End Sub
    Private Sub txtpix_w_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtpix_w.TextChanged
        If Not IsNumeric(txtpix_w.Text) Then Exit Sub
        If CDbl(txtpix_w.Text) < 10 Then Exit Sub
        lblpx_w.Text = txtpix_w.Text
    End Sub
    Private Sub txtpix_h_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtpix_h.TextChanged
        If Not IsNumeric(txtpix_h.Text) Then Exit Sub
        If CDbl(txtpix_h.Text) < 10 Then Exit Sub
        lblpx_h.Text = txtpix_h.Text
    End Sub
    Private Sub lblpx_w_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblpx_w.TextChanged
        If CDbl(lblpx_w.Text) > 2500 Then
            lblpx_w.Text = "2500"
        End If
    End Sub
    Private Sub lblpx_h_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblpx_h.TextChanged
        If CDbl(lblpx_h.Text) > 2500 Then
            lblpx_h.Text = "2500"
        End If
    End Sub
    Private Sub rdbfree_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbfree.CheckedChanged
        If rdbfree.Checked = True Then
            gIdRegion.selectfree = True
        Else
            gIdRegion.selectfree = False
        End If
    End Sub
    Private Sub cmdplan_Click(sender As System.Object, e As System.EventArgs) Handles cmdplan.Click
        If pic.Image Is Nothing Then Exit Sub
        If cmdplan.Text = "Image 1er plan" Then
            txtpix_w.Text = "15"
            txtpix_h.Text = "15"
            txtpix_w.Text = CStr(img.Width)
            txtpix_h.Text = CStr(img.Height)
            rdbpx.Checked = True
            cmdplan.Text = "Effacer"
            ToolTip1.SetToolTip(cmdplan, "Effacer les valeurs, sélection libre")
        Else
            cmdplan.Text = "Image 1er plan"
            rdbfree.Checked = True
            ToolTip1.SetToolTip(cmdplan, "Utiliser les valeurs de l'image de 1er plan")
        End If

    End Sub

    Private Sub cmdinvers_Click(sender As System.Object, e As System.EventArgs) Handles cmdinvers.Click
        t1 = CDec(txtcm_w.Text)
        t2 = CDec(txtcm_h.Text)
        txtcm_w.Text = CStr(t2)
        txtcm_h.Text = CStr(t1)
        If txtcm_w.Text > txtcm_h.Text Then
            ToolTip1.SetToolTip(cmdinvers, "Mode Portrait")
        Else
            ToolTip1.SetToolTip(cmdinvers, "Mode Paysage")
        End If
        rdbcm.Checked = True
    End Sub

    Private Sub cmdrevers_Click(sender As System.Object, e As System.EventArgs) Handles cmdrevers.Click
        t3 = CDec(txtpix_w.Text)
        t4 = CDec(txtpix_h.Text)
        txtpix_w.Text = CStr(t4)
        txtpix_h.Text = CStr(t3)
        If txtpix_w.Text > txtpix_h.Text Then
            ToolTip1.SetToolTip(cmdrevers, "Mode Portrait")
        Else
            ToolTip1.SetToolTip(cmdrevers, "Mode Paysage")
        End If
        rdbpx.Checked = True
    End Sub
    Private Sub btnrapercu_Click(sender As System.Object, e As System.EventArgs) Handles btnrapercu.Click
        If pic.Image Is Nothing Then Exit Sub
        Dim r As RectangleF = RegionToPixels()
        Dim bm As New Bitmap(CInt(r.Width), CInt(r.Height), pic.Image.PixelFormat)
        Dim rDest As New RectangleF(0, 0, r.Width, r.Height)
        Dim g As Graphics = Graphics.FromImage(bm)
        g.DrawImage(pic.Image, rDest, r, GraphicsUnit.Pixel)
        g.Dispose()
        Preview.picpreview.Image = bm
        Preview.Width = CInt(r.Width)
        Preview.Height = CInt(r.Height)
        Preview.Text = Me.Text
        Preview.ShowDialog()
        bm.Dispose()
    End Sub
#End Region
End Class