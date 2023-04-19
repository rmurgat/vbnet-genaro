Imports Microsoft.VisualBasic

''' <summary>
'''     Clase que tiene la información a detalle de la relacion entre un campo y la referencia a la que pertenece
''' </summary>
''' <empresa>
'''     01 - HANYGEN Software S.A. de C.V. 
''' </empresa>
''' <autor>
'''     Rubén Murga Tapia (06-Dic-2009)
''' </autor>
''' <remarks></remarks>

Public Class Referenciacampo

    Private scdreferencia As String = ""              ' Clave de la referencia
    Private scdfuentedato As String = ""              ' Clave de la fuente de datos
    Private snbentidadato As String = ""              ' Nombre de la entidad de datos
    Private snullavecampo As String = ""              ' Numero o posicion del campo dentro de la referencia
    Private snbcampo As String = ""                   ' Nombre del campo
    Private occampos As Collection                    ' Colección de campos que pertenecen a la referencia

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        occampos = New Collection
    End Sub

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
    ''' PROPIEDAD: Numero o posicion del campo dentro de la referencia
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property nullavecampo() As String
        Get
            Return snullavecampo
        End Get
        Set(ByVal psnu As String)
            If psnu Is Nothing Then
                snullavecampo = ""
                Exit Property
            End If
            snullavecampo = psnu.Trim
        End Set
    End Property
    
    ''' <summary>
    ''' PROPIEDAD: Nombre del campo
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property nbcampo() As String
        Get
            Return snbcampo
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then
                snbcampo = ""
                Exit Property
            End If
            snbcampo = psnb.Trim
        End Set
    End Property
    
    ''' <summary>
    ''' PROPIEDAD: Colección de campos que pertenecen a la referencia
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property ccampos() As Collection
        Get
            Return occampos
        End Get
        Set(ByVal poval As Collection)
            occampos = poval
        End Set
    End Property

End Class   ' fin clase [Referenciacampo]

