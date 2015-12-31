Option Strict On

Public Class clsRegion
    Private gRatio As Single                                    ' Width / Height ratio
    Private gDragging As Boolean = False                        ' true if region is being dragged
    Private gDoMoveLeft As Boolean                              ' true if region can move left
    Private gDoMoveTop As Boolean                               ' true if region can move top
    Private gDoMoveRight As Boolean                             ' true if region can move right
    Private gDoMoveBottom As Boolean
    Public selectfree As Boolean

    Private gSavedRegion As RectangleF                          ' region, before dragging it
    Private gMouseDownPt As Point                               ' point where the user first clicked to drag the region
    Private gRegion As New RectangleF(0, 0, 10, 10)             ' bounds, relative to parent control, in centh of inch
    Private gBounds As Rectangle                                ' parent control bounds (dragging region)

    Private Const REGION_INITIAL_POSITION As Double = 1 / 3     ' initial position of region (% total width and height)
    Private Const REGION_PEN_SIZE As Integer = 2                ' region pen size
    Private Const REGION_BOX_OFFSET As Integer = 3              ' drag box half width
    Private Const REGION_BOX_DRAG_OFFSET As Integer = 5         ' width of drag region
    Private Const REGION_MIN_SIZE = 20                          ' in centh of inch
    Dim _c As Color

    Private Sub ConstraintRegionRatio(ByVal doMin As Boolean)
        Dim doAdjustH As Boolean
        Dim dH As Double = 0
        Dim dV As Double = 0

        If gRegion.Width > gRegion.Height * gRatio Then
            doAdjustH = doMin
        Else
            doAdjustH = Not doMin
        End If

        If doAdjustH Then
            dH = gRegion.Height * gRatio - gRegion.Width
        Else
            dV = gRegion.Width / gRatio - gRegion.Height
        End If

        gRegion.Width = CSng(gRegion.Width + dH)
        If gDoMoveRight And Not gDoMoveLeft Then
            ' do nothing
        ElseIf gDoMoveLeft And Not gDoMoveRight Then
            gRegion.Offset(CSng(-dH), 0)
        Else
            gRegion.Offset(CSng(-dH / 2), 0)
        End If

        gRegion.Height = CSng(gRegion.Height + dV)
        If gDoMoveBottom And Not gDoMoveTop Then
            ' do nothing
        ElseIf gDoMoveTop And Not gDoMoveBottom Then
            gRegion.Offset(0, CSng(-dV))
        Else
            gRegion.Offset(0, CSng(-dV / 2))
        End If
    End Sub
    'Nouvelle instance, étant donné son rapport et les limites de contrôle parental;
    ' <parentBounds> seront utilisés pour redimensionner la région; 
    'l'objectif est de maintenir le même ratio d'aspect de la région et, la position, par rapport au contrôle parent, même quand il est redimensionné; 
    '< parentBounds> sera également utilisé comme surface maximale de traîner (ce qui peut être changé dans le futur)
    Public Sub New(ByVal ratio As Single, ByVal parentBounds As Rectangle)
        gRatio = ratio
        gBounds = parentBounds
        gRegion = New Rectangle(CInt(parentBounds.Left + parentBounds.Width * REGION_INITIAL_POSITION), _
                                 CInt(parentBounds.Top + parentBounds.Height * REGION_INITIAL_POSITION), _
                                 CInt(parentBounds.Width * (1 - 2 * REGION_INITIAL_POSITION)), _
                                 CInt(parentBounds.Height * (1 - 2 * REGION_INITIAL_POSITION)))
        ConstraintRegionRatio(True)
    End Sub
    ' nouvelle instance, avec un rapport fixe et limites
    Public Sub New()
        gRatio = 1
        gBounds = New Rectangle(0, 0, 100, 100)
        gRegion = New RectangleF(33, 33, 33, 33)
        ConstraintRegionRatio(True)
    End Sub
    'Obtenez / définir rapport largeur / hauteur
    'note: nouvelle région sera inclus à l'intérieur ancienne région
    Public Property ratio() As Single
        Get
            Return gRatio
        End Get
        Set(ByVal value As Single)
            gRatio = value
            ConstraintRegionRatio(True)
        End Set
    End Property
    ' Obtenez / définir region rectangle
    ' note : ratio de région sera limitée
    Public Property RectF() As RectangleF
        Get
            Return gRegion
        End Get
        Set(ByVal value As RectangleF)
            Dim isBigger As Boolean = value.Contains(gRegion)
            gRegion = value
            ConstraintRegionRatio(Not isBigger)
        End Set
    End Property
    ' dimensionne la région par des facteurs donnés (H et V)
    Public Function ScaledRectF(ByVal factorH As Double, ByVal factorV As Double) As RectangleF
        Dim r As New RectangleF(CSng(gRegion.X * factorH), CSng(gRegion.Y * factorV), _
                                CSng(gRegion.Width * factorH), CSng(gRegion.Height * factorV))
        Return r
    End Function
    ' Obtenez / définir region rectangle (integre rectangle)
    Public Property Rect() As Rectangle
        Get
            Return Rectangle.Round(gRegion)
        End Get
        Set(ByVal value As Rectangle)
            Dim newRegion As New RectangleF(value.Left, value.Top, value.Width, value.Height)
            Me.RectF = newRegion
        End Set
    End Property
    ' Obtenez / définir des bornes de commande de parent
    ' note: met à l'échelle de la région en fonction des nouvelles limites, et le ratio de région sera toujours limitée
    Public Property Bounds() As Rectangle
        Get
            Return gBounds
        End Get
        Set(ByVal value As Rectangle)
            Dim ratioH As Double = value.Width / gBounds.Width
            Dim ratioV As Double = value.Height / gBounds.Height
            gBounds = value
            gRegion.X = CSng(gRegion.X * ratioH)
            gRegion.Y = CSng(gRegion.Y * ratioV)
            gRegion.Width = CSng(gRegion.Width * ratioH)
            gRegion.Height = CSng(gRegion.Height * ratioV)
            ConstraintRegionRatio(ratioH <= 1 Or ratioV <= 1)
        End Set
    End Property
    'Fonction utilisée pour gérer une partie de traînée impact (à la frontière, coin, ou toute la région) sur les événements de souris
    'et à manipuler le curseur de la souris en fonction de cette partie
    Private Function CheckPtInRegion(ByVal pt As Point, ByRef doMoveTop As Boolean, ByRef doMoveLeft As Boolean, _
                                ByRef doMoveBottom As Boolean, ByRef doMoveRight As Boolean, ByRef curs As Cursor) As Boolean
        Dim h As Long = CLng(gRegion.Width)
        Dim v As Long = CLng(gRegion.Height)
        Dim hBox As Long = REGION_PEN_SIZE + 2 * REGION_BOX_DRAG_OFFSET
        Dim vBox As Long = hBox

        Dim aSmallRect As New Rectangle(-REGION_BOX_DRAG_OFFSET, -REGION_BOX_DRAG_OFFSET, CInt(hBox), CInt(vBox))
        Dim aHRect As New Rectangle(0, -REGION_BOX_DRAG_OFFSET, CInt(h), CInt(vBox))
        Dim aVRect As New Rectangle(-REGION_BOX_DRAG_OFFSET, 0, CInt(hBox), CInt(v))

        doMoveLeft = False
        doMoveRight = False
        doMoveTop = False
        doMoveBottom = False

        aSmallRect.Offset(CInt(gRegion.Left), CInt(gRegion.Top))
        aHRect.Offset(CInt(gRegion.Left), CInt(gRegion.Top))
        aVRect.Offset(CInt(gRegion.Left), CInt(gRegion.Top))
        ' top left corner
        If aSmallRect.Contains(pt) Then
            curs = Cursors.SizeNWSE
            doMoveTop = True
            doMoveLeft = True
        Else
            ' top right corner
            aSmallRect.Offset(CInt(h), 0)
            If aSmallRect.Contains(pt) Then
                curs = Cursors.SizeNESW
                doMoveTop = True
                doMoveRight = True
            Else
                ' bottom right corner
                aSmallRect.Offset(0, CInt(v))
                If aSmallRect.Contains(pt) Then
                    curs = Cursors.SizeNWSE
                    doMoveBottom = True
                    doMoveRight = True
                Else
                    ' bottom left corner
                    aSmallRect.Offset(CInt(-h), 0)
                    If aSmallRect.Contains(pt) Then
                        curs = Cursors.SizeNESW
                        doMoveBottom = True
                        doMoveLeft = True
                    Else
                        ' top border
                        If aHRect.Contains(pt) Then
                            curs = Cursors.SizeNS
                            doMoveTop = True
                        Else
                            ' bottom border
                            aHRect.Offset(0, CInt(v))
                            If aHRect.Contains(pt) Then
                                curs = Cursors.SizeNS
                                doMoveBottom = True
                            Else
                                ' left border
                                If aVRect.Contains(pt) Then
                                    curs = Cursors.SizeWE
                                    doMoveLeft = True
                                Else
                                    ' right border
                                    aVRect.Offset(CInt(h), 0)
                                    If aVRect.Contains(pt) Then
                                        curs = Cursors.SizeWE
                                        doMoveRight = True
                                    Else
                                        ' middle
                                        If gRegion.Contains(pt) Then
                                            curs = Cursors.SizeAll
                                            doMoveLeft = True
                                            doMoveRight = True
                                            doMoveTop = True
                                            doMoveBottom = True
                                        Else
                                            curs = Cursors.Default
                                        End If   ' middle
                                    End If   ' right
                                End If   ' left
                            End If   ' bottom
                        End If   ' top
                    End If   ' bottom left
                End If   ' bottom right
            End If   ' top right
        End If   ' top left

        Return (doMoveLeft Or doMoveRight Or doMoveTop Or doMoveBottom)
    End Function
    'Poignées souris enfoncé événement down(commence à faire glisser la région, si nécessaire)
    Public Sub CheckMouseDown(ByVal pt As Point, ByVal ctl As Control)
        If CheckPtInRegion(pt, gDoMoveTop, gDoMoveLeft, gDoMoveBottom, gDoMoveRight, ctl.Cursor) Then
            gMouseDownPt = pt
            gSavedRegion = gRegion
            gDragging = True
        Else
            gDragging = False
        End If
    End Sub
    ' poignées souris événement move (soit juste changer le curseur ou glisser région)
    Public Sub CheckMouseMove(ByVal pt As Point, ByVal ctl As Control)
        Dim doMoveLeft As Boolean
        Dim doMoveRight As Boolean
        Dim doMoveTop As Boolean
        Dim doMoveBottom As Boolean
        Dim oldRegion As RectangleF

        Dim dh As Long
        Dim dv As Long

        If gDragging Then
            dh = pt.X - gMouseDownPt.X
            dv = pt.Y - gMouseDownPt.Y
            oldRegion = gRegion
            gRegion = gSavedRegion
            If gDoMoveLeft Then
                gRegion.Offset(dh, 0)
                gRegion.Width = gRegion.Width - dh
            End If
            If gDoMoveRight Then
                gRegion.Width = gRegion.Width + dh
            End If
            If gDoMoveTop Then
                gRegion.Offset(0, dv)
                gRegion.Height = gRegion.Height - dv
            End If
            If gDoMoveBottom Then
                gRegion.Height = gRegion.Height + dv
            End If
            If selectfree = False Then 'sélection libre = True
                ' rapport largeur / hauteur respectant les proportions
                ConstraintRegionRatio(gSavedRegion.Contains(gRegion))
            End If
            If Not gBounds.Contains(Rectangle.Round(gRegion)) Or _
                        gRegion.Width < 20 Or gRegion.Height < 20 Then
                gRegion = oldRegion
            End If

            ctl.Refresh()
        Else
            CheckPtInRegion(pt, doMoveTop, doMoveLeft, doMoveBottom, doMoveRight, ctl.Cursor)
        End If
    End Sub
    ' poignées souris jusqu'à événement up (extrémités glisser)
    Public Sub CheckMouseUp(ByVal pt As Point, ByVal ctl As Control)
        gDragging = False
    End Sub
    ' tirer région châssis intérieur contrôle parent
    Public Sub Draw(ByVal gr As Graphics, ByVal _c As Color)
        Dim aSmallRect As New System.Drawing.Rectangle(-REGION_BOX_OFFSET, -REGION_BOX_OFFSET, _
                      REGION_PEN_SIZE + REGION_BOX_OFFSET, REGION_PEN_SIZE + REGION_BOX_OFFSET)
        Dim aPen As New System.Drawing.Pen(Color.Black, 2)
        aPen.Color = Color.Red
        gr.DrawRectangle(aPen, Rectangle.Round(gRegion))
        aPen.Color = _c
        aPen.DashStyle = Drawing2D.DashStyle.Dash
        gr.DrawRectangle(aPen, Rectangle.Round(gRegion))
        aPen.Dispose()

        Dim h As Long
        Dim v As Long

        h = CLng(gRegion.Width)
        v = CLng(gRegion.Height)

        aSmallRect.Offset(CInt(gRegion.Left), CInt(gRegion.Top))
        gr.DrawRectangle(Pens.Black, aSmallRect)
        aSmallRect.Offset(CInt(h \ 2), 0)
        gr.DrawRectangle(Pens.Black, aSmallRect)

        aSmallRect.Offset(CInt(h - h \ 2), 0)
        gr.DrawRectangle(Pens.Black, aSmallRect)
        aSmallRect.Offset(0, CInt(v \ 2))
        gr.DrawRectangle(Pens.Black, aSmallRect)

        aSmallRect.Offset(0, CInt(v - v \ 2))
        gr.DrawRectangle(Pens.Black, aSmallRect)
        aSmallRect.Offset(CInt(-h \ 2), 0)
        gr.DrawRectangle(Pens.Black, aSmallRect)

        aSmallRect.Offset(CInt(-h + h \ 2), 0)
        gr.DrawRectangle(Pens.Black, aSmallRect)
        aSmallRect.Offset(0, CInt(-v \ 2))
        gr.DrawRectangle(Pens.Black, aSmallRect)
    End Sub
    Property Couleur As Color
        Set(ByVal value As Color)
            _c = value
        End Set
        Get
            Return _c
        End Get
    End Property
End Class
