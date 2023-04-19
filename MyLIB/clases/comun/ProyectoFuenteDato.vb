Option Explicit On

Public Class ProyectoFuenteDato
    Private scdproyecto As String = ""   'clave del proyecto
    Private scdfuentedato As String = "" 'clave de la fuente de datos
    Private stxcomment As String = ""    'comenterios

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' PROPIEDAD: clave del proyecto
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdproyecto() As String
        Get
            Return scdproyecto
        End Get
        Set(ByVal pscd As String)
            scdproyecto = pscd.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: clave de la fuente de datos
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdfuentedato() As String
        Get
            Return scdfuentedato
        End Get
        Set(ByVal pscd As String)
            scdfuentedato = pscd.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: comenterios
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property txcomment() As String
        Get
            Return stxcomment
        End Get
        Set(ByVal pstx As String)
            stxcomment = pstx.Trim
        End Set
    End Property

End Class 'fin clase [ProyectoFuenteDato]
