Option Explicit On
Imports System.IO
Imports ComponentAce.Compression.Archiver
Imports ComponentAce.Compression.ZipForge

''' <summary>
''' Clase de Utilerias para la operación de archivos .zip
''' </summary>
''' <remarks>
''' </remarks>
Public Class ZipArchivo
    Dim sname As String  'Nombre del archivo zip
    Dim ozipForge As ZipForge

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New(ByVal sfilename As String)
        Me.Open(sfilename)
    End Sub

    ''' <summary>
    ''' PROPIEDAD: Nombre del archivo zip
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property name() As String
        Get
            Return sname
        End Get
        Set(ByVal psval As String)
            sname = psval
        End Set
    End Property

    ''' <summary>
    ''' Procedimiento para cerrar una archivo .zip
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Function Close() As Boolean
        Try
            ozipForge.CloseArchive()
        Catch e As Exception
            Return False
        End Try
        Return True
    End Function

    ''' <summary>
    ''' Procedimiento para abir un archivo zip
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Function Open() As Boolean
        Try
            ozipForge = New ZipForge()
            ozipForge.FileName = sname
            ozipForge.OpenArchive(FileMode.Open)
        Catch ex1 As Exception
            Throw New HANYException("MAPEADOR.ZipArchivo.Open()", "Ocurrio un error al leer el archivo ZIP [" & ex1.ToString & "]")
        End Try
    End Function

    ''' <summary>
    ''' Procedimiento para abir un archivo zip
    ''' </summary>
    ''' <param name="sfilename">Nombre del archivo</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Function Open(ByVal sfilename As String) As Boolean
        Try
            Me.sname = sfilename
            ozipForge = New ZipForge()
            ozipForge.FileName = sname
            ozipForge.OpenArchive(FileMode.Open)
        Catch ex1 As Exception
            Throw New HANYException("MAPEADOR.ZipArchivo.Open(filename)", "Ocurrio un error al leer el archivo ZIP [" & ex1.ToString & "]")
        End Try
    End Function

    ''' <summary>
    ''' Procedimiento para descompactar un archivo zip en un directorio en particular
    ''' </summary>
    ''' <param name="ozip">objeto con el archivo zip</param>
    ''' <param name="spath">ruta donde descompactar</param>
    ''' <remarks></remarks>
    Public Sub UnzipIn(ByRef ozip As ZipArchivo, ByVal spath As String)
        Try
            ozipForge.BaseDir = spath
            ozipForge.Options.StorePath = StorePathMode.RelativePath
            ozipForge.ExtractFiles("*.*")

        Catch ex1 As Exception
            Throw New HANYException("MAPEADOR.ZipArchivo.UnzipIn(2)", "Ocurrio un error al consultar los archivos [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para descompactar un archivo zip en un directorio en particular
    ''' </summary>
    ''' <param name="spath">ruta donde descompactar</param>
    ''' <remarks></remarks>
    Public Sub UnzipIn(ByVal spath As String)
        Try
            Me.UnzipIn(Me, spath)
        Catch ex1 As Exception
            Throw New HANYException("MAPEADOR.ZipArchivo.UnzipIn(1)", "Ocurrio un error al consultar los archivos [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para consultar el contenido de un archivo en particular
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks>
    ''' Ejemplo:
    '''   Dim ofrm As frmeditor = New frmeditor()
    '''   Dim ozip As ZipArchivo = New ZipArchivo("c:\hola.zip")
    '''   ofrm.rtbeditor.Text = ozip.getFileInflated("tels.txt")
    '''   ofrm.Show()
    ''' </remarks>
    Public Function getFileInflated(ByVal sentry As String) As String
        Dim sres As String = ""
        Try
            ozipForge.ExtractToString(sentry, sres)
        Catch ex1 As Exception
            Throw New HANYException("MAPEADOR.ZipArchivo.getFileInflated(1)", "Ocurrio un error al extraer el contenido de un archivo [" & ex1.ToString & "]")
        End Try
        Return sres
    End Function

    ''' <summary>
    ''' Procedimiento para crear un archivo ZIP 
    ''' </summary>
    ''' <param name="zipPath">ruta del archivo zip</param>
    ''' <param name="spathtozip">Ruta donde se encuentran los archivos a zipear</param>
    ''' <returns>Boolean</returns>
    ''' <remarks>
    ''' Ejemplo:
    '''    Dim oc As System.Collections.ArrayList = New System.Collections.ArrayList
    '''    Dim ozipfile As ZipArchivo = New ZipArchivo
    '''    oc.Add("c:\metacodigo.txt")
    '''    oc.Add("c:\LogDebug.txt")
    '''    oc.Add("c:\rmurga\tels.txt")
    '''    ozipfile.Create("c:\hola.zip", oc)
    ''' </remarks>
    Public Function Create(ByVal zipPath As String, ByVal spathtozip As String) As Boolean
        Try
            ozipForge = New ZipForge()
            ozipForge.FileName = zipPath
            ozipForge.OpenArchive(System.IO.FileMode.Create)
            ozipForge.BaseDir = spathtozip
            ozipForge.AddFiles("*.xml")
            ozipForge.CloseArchive()
        Catch ex1 As Exception
            Throw New HANYException("MAPEADOR.ZipArchivo.Create()", "Ocurrio un error al crear un archivo zip [" & ex1.ToString & "]")
            Return False
        End Try
        Return True
    End Function

    ''' <summary>
    ''' Procedimiento para evaluar la existencia de un archivo
    ''' </summary>
    ''' <param name="sentry">nombre del archivo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ExisteArchivo(ByVal sentry As String) As Boolean
        Dim archiveItem As ComponentAce.Compression.Archiver.ArchiveItem = New ComponentAce.Compression.Archiver.ArchiveItem()
        Dim bsiexiste As Boolean = False
        Try
            If ozipForge.FindFirst(sentry, archiveItem) Then bsiexiste = True
        Catch ex As Exception
            Throw New HANYException("MyLIB.ZipArchivo.ExisteArchivo()", "Ocurrio un error al validar la existencia del archivo [" & ex.ToString & "]")
        End Try
        Return bsiexiste
    End Function

    ''' <summary>
    ''' Procedimiento para escribir un archivo desencriptado en un target en particular
    ''' </summary>
    ''' <param name="sentry">nombre de la entrada</param>
    ''' <param name="starget">target donde escribir</param>
    ''' <returns>boolean</returns>
    ''' <remarks></remarks>
    Public Function writeFileInflated(ByVal sentry As String, ByVal starget As String) As Boolean
        Dim oarchive As ComponentAce.Compression.Archiver.ArchiveItem = New ComponentAce.Compression.Archiver.ArchiveItem()
        Dim fs As System.IO.FileStream
        Dim bw As System.IO.BinaryWriter
        Dim i As Integer
        Dim ilong As Long

        Try
            If ozipForge.FindFirst(sentry, oarchive) Then
                Dim data(oarchive.UncompressedSize) As Byte
                ilong = ozipForge.ExtractToBuffer(sentry, data)
                fs = New System.IO.FileStream(starget, System.IO.FileMode.Create)
                bw = New BinaryWriter(fs)
                For i = 0 To ilong - 1
                    bw.Write(data(i))
                Next
                bw.Close()
                fs.Close()
            End If
        Catch e As Exception
            Throw New HANYException("MyLIB.ZipArchivo.writeFileInflated()", "Ocurrio un error al escribir el archivo [" & e.ToString & "]")
        End Try
        Return True
    End Function


End Class   'fin clase [UtileriasZip]
