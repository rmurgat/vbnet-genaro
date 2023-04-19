Option Explicit On
''' <summary>
''' Clase que tiene las propiedades y metodos propios de los campos que pertenecen al reporte
''' </summary>
''' <company>ATL Solutions</company>
''' <project>VBNET_Proyecto</project>
''' <autor>Rubén Murga Tapia</autor>
''' <created>18-Mayo-2008  12:00 am</created>
''' <remarks></remarks>
Public Class ReporteCampo
    Private scdproyecto As String = ""  ' Clave del proyecto
    Private scdreporte As String = ""   ' Clave del reporte
    Private snbcampo As String = ""     ' Nombre del campo
    Private scdcampo As String = ""     ' Clave del campo
    Private scdtpcampo As String = ""   ' Tipo del campo
    Private scdarreglo As String = ""   ' Clave del arreglo
    Private stxcomment As String = ""   ' Comentarios respecto al campo
    Private inudecimales As Integer = 0 ' Número de decimales

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' PROPIEDAD: Clave del proyecto
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdproyecto() As String
        Get
            Return scdproyecto
        End Get
        Set(ByVal pscd As String)
            scdproyecto = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave del reporte
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdreporte() As String
        Get
            Return scdreporte
        End Get
        Set(ByVal pscd As String)
            scdreporte = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave del campo
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdcampo() As String
        Get
            Return scdcampo
        End Get
        Set(ByVal pscd As String)
            scdcampo = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave del arreglo
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdarreglo() As String
        Get
            Return scdarreglo
        End Get
        Set(ByVal pscd As String)
            scdarreglo = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Nombre del campo
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbcampo() As String
        Get
            Return snbcampo
        End Get
        Set(ByVal psnb As String)
            snbcampo = psnb
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Tipo del campo
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdtpcampo() As String
        Get
            Return scdtpcampo
        End Get
        Set(ByVal pscd As String)
            scdtpcampo = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Comentarios respecto al campo
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property txcomment() As String
        Get
            Return stxcomment
        End Get
        Set(ByVal pstx As String)
            stxcomment = pstx
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Número de decimales
    ''' </summary>
    ''' <value>Integer</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nudecimales() As Integer
        Get
            Return inudecimales
        End Get
        Set(ByVal pival As Integer)
            inudecimales = pival
        End Set
    End Property

End Class  'fin clase [ReporteCampo]
