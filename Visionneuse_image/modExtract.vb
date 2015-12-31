Option Strict Off

Imports ThumbExtract
Imports System.Runtime.InteropServices

Module modExtract
    Private Declare Function SHGetDesktopFolder Lib "shell32" (ByRef ppDesktopFolder As IShellFolder) As Integer
    Private Declare Unicode Function SHGetPathFromIDList Lib "shell32" ( _
               ByVal pidl As Integer, _
               ByVal pszPath As String) As Integer
    Private Declare Unicode Function ILCreateFromPath Lib "shell32" Alias "#157" ( _
               ByVal lpszPath As String) As Integer
    Private Declare Function ILFree Lib "shell32" Alias "#155" ( _
              ByVal pidl As Integer) As Integer
    Private Declare Function ILClone Lib "shell32" Alias "#18" ( _
              ByVal pidl As Integer) As Integer
    Private Declare Function ILFindLastID Lib "shell32" Alias "#16" ( _
              ByVal pidl As Integer) As Integer
    Private Declare Unicode Function SHGetFileInfo Lib "shell32" Alias "SHGetFileInfoW" ( _
       ByVal pszPath As String, _
       ByVal dwFileAttributes As Integer, _
       ByRef psfi As SHFILEINFO, _
       ByVal cbFileInfo As Integer, _
       ByVal uFlags As SHGFIFLAGS) As Integer


    Public Function CreateBitmapPicture(ByVal hBmp As IntPtr) As System.Drawing.Image
        Return System.Drawing.Image.FromHbitmap(hBmp)
    End Function


    Public Function CreateIconePicture(ByVal hIcon As IntPtr) As System.Drawing.Icon
        Return System.Drawing.Icon.FromHandle(hIcon)
    End Function


    Private Function FilePath(ByVal szFileName As String) As String
        FilePath = Mid(szFileName, 1, InStrRev(szFileName, "\"))
    End Function


    Private Function FileName(ByVal szFileName As String) As String
        FileName = Mid(szFileName, InStrRev(szFileName, "\") + 1)
    End Function


    Private Function GetShellFolder(ByVal szFileName As String, ByRef pidl As Integer) As ThumbExtract.IShellFolder
        Dim folder As ThumbExtract.IShellFolder = Nothing
        Dim item As ThumbExtract.IShellFolder
        Dim szFile, szPath As String
        Dim cEaten As Integer
        Dim pdwAttrib As Integer
        Dim abspidl As Integer
        Dim uuidIShellFolder As New ThumbExtract.UUID



        ReDim uuidIShellFolder.Data4(0 To 7)
        With uuidIShellFolder
            .Data1 = &H214E6&
            .Data4(0) = &HC0
            .Data4(7) = &H46
        End With


        SHGetDesktopFolder(folder)


        If Mid(szFileName, Len(szFileName), 1) = "\" Then
            szFileName = Mid(szFileName, 1, Len(szFileName) - 1)
        End If


        If Len(szFileName) = 2 Then
            szFileName = szFileName & "\"
            szPath = "::{63387CDF-D456-4ED3-BE8D-FD029A9AA53C}"
            szFile = szFileName

        Else
            szPath = FilePath(szFileName)
            szFile = FileName(szFileName)
        End If


        folder.ParseDisplayName(0, 0, szPath, cEaten, pidl, pdwAttrib)

        item = CType(folder.BindToObject(pidl, 0, uuidIShellFolder), IShellFolder)
        ILFree(pidl)


        abspidl = ILCreateFromPath(szFileName)
        pidl = ILFindLastID(abspidl)
        pidl = ILClone(pidl)
        ILFree(abspidl)

        GetShellFolder = item
    End Function


    Private Function getThumbnail(ByVal item As ThumbExtract.IShellFolder, ByVal pidl As Integer) As ThumbExtract.IExtractImage
        On Error Resume Next

        Dim prgf As Integer
        'Dim iid As String
        Dim uuidIExtractImage As New ThumbExtract.UUID

        'init du guid

        ReDim uuidIExtractImage.Data4(0 To 7)
        With uuidIExtractImage
            .Data1 = &HBB2E617C
            .Data2 = &H920S
            .Data3 = &H11D1S
            .Data4(0) = &H9A
            .Data4(1) = &HB
            .Data4(2) = &H0
            .Data4(3) = &HC0
            .Data4(4) = &H4F
            .Data4(5) = &HC2
            .Data4(6) = &HD6
            .Data4(7) = &HC1
        End With


        If pidl <> 0 Then

            getThumbnail = CType(item.GetUIObjectOf(0, 1, pidl, uuidIExtractImage, prgf), IExtractImage)
        Else

            getThumbnail = CType(item.CreateViewObject(0, uuidIExtractImage), IExtractImage)
        End If
    End Function


    Private Function getIcon(ByVal item As ThumbExtract.IShellFolder, ByVal pidl As Integer) As ThumbExtract.IExtractIcon
        On Error Resume Next

        Dim prgf As Integer
        Dim iid As String
        Dim uuidIExtractIcon As New ThumbExtract.UUID

        ReDim uuidIExtractIcon.Data4(0 To 7)
        With uuidIExtractIcon
            .Data1 = &H214FA
            .Data4(0) = &HC0
            .Data4(7) = &H46
        End With

        If pidl <> 0 Then
            getIcon = CType(item.GetUIObjectOf(0, 1, pidl, uuidIExtractIcon, prgf), IExtractIcon)
        Else
            getIcon = CType(item.CreateViewObject(0, uuidIExtractIcon), IExtractIcon)
        End If
    End Function


    Public Function ExtractImage(ByVal szFileName As String, ByVal dwCX As Integer, ByVal dwCY As Integer) As System.Drawing.Bitmap
        On Error Resume Next

        Dim priority As Integer
        Dim requestedColourDepth As Integer
        Dim flags As ThumbExtract.EIEIFLAG
        Dim sz As ThumbExtract.SIZE
        Dim pidl As Integer
        Dim isf As ThumbExtract.IShellFolder
        Dim ie As ThumbExtract.IExtractImage
        Dim ii As ThumbExtract.IExtractIcon
        Dim szPath As String
        Dim pindex As Integer
        Dim Handle As Integer
        Dim shgfi As New ThumbExtract.SHFILEINFO

        requestedColourDepth = 32
        flags = ThumbExtract.EIEIFLAG.IEIFLAG_ASPECT


        isf = GetShellFolder(szFileName, pidl)

        ie = getThumbnail(isf, pidl)

        If ie Is Nothing Then

            ii = getIcon(isf, pidl)


            If Not (ii Is Nothing) Then

                szPath = Space(260)

                Call ii.GetIconLocation(0, szPath, 260, pindex, flags)
                Call ii.Extract(szPath, pindex, Handle, pindex, dwCX + &H10000 * dwCX)

                If Handle = 0 Then
                    SHGetFileInfo(szFileName, 0, shgfi, Marshal.SizeOf(shgfi), ThumbExtract.SHGFIFLAGS.SHGFI_LARGEICON Or ThumbExtract.SHGFIFLAGS.SHGFI_ICON Or SHGFIFLAGS.SHGFI_OVERLAYINDEX)
                    ExtractImage = CreateIconePicture(New IntPtr(shgfi.hIcon)).ToBitmap()
                Else
                    ExtractImage = CreateIconePicture(New IntPtr(Handle)).ToBitmap()
                End If
            Else
                SHGetFileInfo(szFileName, 0, shgfi, Marshal.SizeOf(shgfi), ThumbExtract.SHGFIFLAGS.SHGFI_LARGEICON Or ThumbExtract.SHGFIFLAGS.SHGFI_ICON Or SHGFIFLAGS.SHGFI_OVERLAYINDEX)
                ExtractImage = CreateIconePicture(CType(shgfi.hIcon, IntPtr)).ToBitmap()
            End If


        Else

            sz.cx = dwCX
            sz.cy = dwCY

            szPath = Space(260)
            Call ie.GetLocation(szPath, 260, priority, sz, requestedColourDepth, flags)
            Handle = ie.Extract()


            If Handle = 0 Then

                ii = getIcon(isf, pidl)


                If Not (ii Is Nothing) Then
                    szPath = Space(260)

                    Call ii.GetIconLocation(0, szPath, 260, pindex, flags)
                    Call ii.Extract(szPath, pindex, Handle, 0, dwCX + &H10000 * dwCX)

                    If Handle = 0 Then
                        SHGetFileInfo(szFileName, 0, shgfi, Marshal.SizeOf(shgfi), ThumbExtract.SHGFIFLAGS.SHGFI_LARGEICON Or ThumbExtract.SHGFIFLAGS.SHGFI_ICON)
                        ExtractImage = CreateIconePicture(CType(shgfi.hIcon, IntPtr)).ToBitmap()
                    Else
                        ExtractImage = CreateIconePicture(CType(Handle, IntPtr)).ToBitmap()
                    End If
                Else
                    SHGetFileInfo(szFileName, 0, shgfi, Marshal.SizeOf(shgfi), ThumbExtract.SHGFIFLAGS.SHGFI_LARGEICON Or ThumbExtract.SHGFIFLAGS.SHGFI_ICON)
                    ExtractImage = CreateIconePicture(CType(shgfi.hIcon, IntPtr)).ToBitmap()
                End If
            Else
                ExtractImage = CType(CreateBitmapPicture(CType(Handle, IntPtr)), Bitmap)
            End If
        End If
        ILFree(pidl)
        If Not ExtractImage Is Nothing Then
            ExtractImage.MakeTransparent()
        End If
    End Function
End Module

