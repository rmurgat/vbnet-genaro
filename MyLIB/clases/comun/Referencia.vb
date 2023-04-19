Imports Microsoft.VisualBasic

''' <summary>
'''     Clase que tiene el registro de referencias que tiene cada una de las entidades de datos
''' </summary>
''' <empresa>
'''     01 - HANYGEN Software S.A. de C.V. 
''' </empresa>
''' <autor>
'''     Rubén Murga Tapia (06-Dic-2009)
''' </autor>
''' <remarks></remarks>

Public Class Referencia

    Private scdfuentedato As String = ""              ' Clave de la fuente de datos
    Private snbentidadato As String = ""              ' Nombre de la entidad de datos
    Private scdreferencia As String = ""              ' Clave de la referencia
    Private snbreferencia As String = ""              ' Nombre de la referencia
    Private stxcomment As String = ""                 ' Comentarios
    Private ocCampos As Collection                    ' Campos que son referenciados

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        ocCampos = New Collection
    End Sub

    ''' <summary>
    ''' PROPIEDAD: Clave de la fuente de datos
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdfuentedato() As String
        Get
            Return scdfuentedato
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then
                scdfuentedato = ""
                Exit Property
            End If
            scdfuentedato = pscd.Trim
        End Set
    End Property
    
    ''' <summary>
    ''' PROPIEDAD: Nombre de la entidad de datos
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property nbentidadato() As String
        Get
            Return snbentidadato
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then
                snbentidadato = ""
                Exit Property
            End If
            snbentidadato = psnb.Trim
        End Set
    End Property
    
    ''' <summary>
    ''' PROPIEDAD: Clave de la referencia
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdreferencia() As String
        Get
            Return scdreferencia
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then
                scdreferencia = ""
                Exit Property
            End If
            scdreferencia = pscd.Trim
        End Set
    End Property
    
    ''' <summary>
    ''' PROPIEDAD: Nombre de la referencia
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property nbreferencia() As String
        Get
            Return snbreferencia
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then
                snbreferencia = ""
                Exit Property
            End If
            snbreferencia = psnb.Trim
        End Set
    End Property
    
    ''' <summary>
    ''' PROPIEDAD: Comentarios
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property txcomment() As String
        Get
            Return stxcomment
        End Get
        Set(ByVal pstx As String)
            If pstx Is Nothing Then
                stxcomment = ""
                Exit Property
            End If
            stxcomment = pstx.Trim
        End Set
    End Property
    
    ''' <summary>
    ''' PROPIEDAD: Campos que son referenciados
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property cCampos() As Collection
        Get
            Return ocCampos
        End Get
        Set(ByVal poval As Collection)
            ocCampos = poval
        End Set
    End Property

End Class   ' fin clase [Referencia]

