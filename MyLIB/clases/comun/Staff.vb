Option Explicit On

''' <summary>
''' Clase que tiene las propiedades y metodos propios del Staff
''' </summary>
''' <company>ATL Solutions</company>
''' <project>VBNET_Proyecto</project>
''' <autor>Rubén Murga Tapia</autor>
''' <created>18-Mayo-2008  12:00 am</created>
''' <remarks></remarks>
Public Class Staff
    Private scdproyecto As String = ""  ' Clave del Proyecto
    Private scdstaff As String = ""     ' Clave del Staff
    Private scdpersona As String = ""   ' Clave de la persona
    Private snbpersona As String = ""   ' Nombre de la persona
    Private scdrolstaff As String = ""  ' Clave del rol del staff
    Private snbrolstaff As String = ""  ' Nombre del rol del staff
    Private stxcomment As String = ""   ' Comentario


    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' PROPIEDAD:  Clave del Proyecto
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
    ''' PROPIEDAD:  Clave del Staff
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdstaff() As String
        Get
            Return scdstaff
        End Get
        Set(ByVal pscd As String)
            scdstaff = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Clave de la persona
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdpersona() As String
        Get
            Return scdpersona
        End Get
        Set(ByVal pscd As String)
            scdpersona = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Nombre de la persona
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbpersona() As String
        Get
            Return snbpersona
        End Get
        Set(ByVal psnb As String)
            snbpersona = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Clave del rol del staff
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdrolstaff() As String
        Get
            Return scdrolstaff
        End Get
        Set(ByVal pscd As String)
            scdrolstaff = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Nombre del rol del staff
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbrolstaff() As String
        Get
            Return snbrolstaff
        End Get
        Set(ByVal psnb As String)
            snbrolstaff = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Comentario
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property txcomment() As String
        Get
            Return stxcomment
        End Get
        Set(ByVal pstx As String)
            stxcomment = pstx.Trim
        End Set
    End Property

End Class  'fin clase [Staff]