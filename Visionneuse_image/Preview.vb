Option Strict On
Imports System.Drawing.Imaging
Imports System.IO.Path
Public Class Preview
    Private Declare Auto Function BitBlt Lib "gdi32.dll" _
 (ByVal pHdc As IntPtr, ByVal iX As Integer, _
 ByVal iY As Integer, ByVal iWidth As Integer, _
 ByVal iHeight As Integer, ByVal pHdcSource As IntPtr, _
 ByVal iXSource As Integer, ByVal iYSource As Integer, _
 ByVal dw As System.Int32) As Boolean
    Private Const SRC As Integer = &HCC0020
    Dim img As Image
    Dim resolution As Integer
    Private Sub ToolStripsave_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripsave.Click
        Dim dlgFile As New SaveFileDialog
        Dim sFilePath As String
        Dim ext As String
        Dim sPath As String
        img = Image.FromFile(Me.Text)
        resolution = CInt(img.VerticalResolution)
        With dlgFile
            sPath = Me.Text
            .FileName = IO.Path.GetDirectoryName(sPath) & _
                            IO.Path.DirectorySeparatorChar & _
                            IO.Path.GetFileNameWithoutExtension(sPath) & "_Marges"
            .FilterIndex = 1
            .Filter = "JPeg Files (*.jpg,*.jpeg)|*.jpg;*.jpeg|Bitmap Files (*.bmp)|*.bmp|Gif Files (*.gif)|*.gif|Tif Files (*.tif)|*.tif|Png Files (*.png)|*.png"
            .OverwritePrompt = True
            .CheckPathExists = True
            .Title = "Enregistrer Image"
            If .ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                sFilePath = .FileName 'chemin de l'image enregistrée
                ext = GetExtension(sFilePath) 'extension seule
                ConvertForm_BMP(Me, sFilePath, ext)
                Process.Start(IO.Path.GetDirectoryName(.FileName)) 'ouverture du répertoire
                Form1.cmdactualise.PerformClick() 'actualiser listview
            Else
                MessageBox.Show("Operation cancelled", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            .Dispose()
        End With
    End Sub

    Public Sub ConvertForm_BMP(ByVal frm As Form, ByVal sFilePath As String, ByVal format As String)
        frm.Refresh()
        frm.Select()
        Dim g As Graphics = frm.CreateGraphics
        Dim ibitMap As New Bitmap(frm.ClientSize.Width, frm.ClientSize.Height, g)
        Dim iBitMap_gr As Graphics = Graphics.FromImage(ibitMap)
        Dim iBitMap_hdc As IntPtr = iBitMap_gr.GetHdc
        Dim me_hdc As IntPtr = g.GetHdc
        BitBlt(iBitMap_hdc, 0, 0, frm.ClientSize.Width, frm.ClientSize.Height, me_hdc, 0, 0, SRC)
        g.ReleaseHdc(me_hdc)
        iBitMap_gr.ReleaseHdc(iBitMap_hdc)
        ibitMap.SetResolution(resolution, resolution) 'resolution origine
        If sFilePath = "" Then Exit Sub
        Select Case format
            Case ".bmp"
                ibitMap.Save(sFilePath, ImageFormat.Bmp)
            Case ".jpg"
                ibitMap.Save(sFilePath, ImageFormat.Jpeg)
            Case ".gif"
                ibitMap.Save(sFilePath, ImageFormat.Gif)
            Case ".png"
                ibitMap.Save(sFilePath, ImageFormat.Png)
            Case ".tif"
                ibitMap.Save(sFilePath, ImageFormat.Tiff)
            Case Else
                ibitMap.Save(sFilePath, ImageFormat.Jpeg)
        End Select
    End Sub
    Private Sub ToolStripcouleur_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripcouleur.Click
        Dim myColorDialog As New ColorDialog()
        With myColorDialog
            'Permet à l'utilisateur de choisir une couleur personnalisée.
            .AllowFullOpen = True
            'Permet à l'utilisateur de recevoir l'aide. (Le défaut est faux.)
            .ShowHelp = True
            .AllowFullOpen = True
            .FullOpen = True
            .AnyColor = True
            'Montre l'élection en couleur initiale 
            .Color = Color.Ivory
            'Actualisez la couleur de boîte de couleur si l'utilisateur clique OK 
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.BackgroundImage = Nothing
                Me.BackColor = .Color
            End If
        End With
    End Sub
    Private Sub ToolStripaleat_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripaleat.Click
        Me.BackgroundImage = My.Resources.Aléatoires
    End Sub
    Private Sub ToolStripbalai_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripbalai.Click
        Me.BackgroundImage = My.Resources.Balayage
    End Sub
    Private Sub ToolStripgribouilli_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripgribouilli.Click
        Me.BackgroundImage = My.Resources.Gribouillis
    End Sub
    Private Sub ToolStripmouche_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripmouche.Click
        Me.BackgroundImage = My.Resources.Mouchetures
    End Sub
    Private Sub ToolStriptache_Click(sender As System.Object, e As System.EventArgs) Handles ToolStriptache.Click
        Me.BackgroundImage = My.Resources.Taches
    End Sub
    Private Sub ToolStriptissu_Click(sender As System.Object, e As System.EventArgs) Handles ToolStriptissu.Click
        Me.BackgroundImage = My.Resources.Tissu
    End Sub
End Class