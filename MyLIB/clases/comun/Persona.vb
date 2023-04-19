Option Explicit On

''' <summary>
''' Clase que tiene las propiedades y metodos propios de las Personas registradas en el sistema
''' </summary>
''' <company>ATL Solutions</company>
''' <project>VBNET_Proyecto</project>
''' <autor>Rubén Murga Tapia</autor>
''' <created>18-Mayo-2008  12:00 am</created>
''' <remarks></remarks>
Public Class Persona
    Private snbempresa As String ' Nombre de la empresa
    Private scdtipo As String    ' Tipo de personal
    Private snbemail As String   ' Email de la persona
    Private snbpersona As String ' Nombre de la persona
    Private snutelcasa As String ' Número de teléfono de su casa
    Private snuteloficina As String ' Número de teléfono de su oficina
    Private scdpersona As String ' Clave de la persona
    Private scdusuario As String ' Clave del usuario
    Private scdrfc As String     ' RFC de la persona
    Private scomment As String   ' Comentario de la persona

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub


    ''' <summary>
    ''' PROPIEDAD: Clave de la persona
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
    ''' PROPIEDAD: Nombre de la persona
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
    ''' PROPIEDAD: Nombre de la empresa
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbempresa() As String
        Get
            Return snbempresa
        End Get
        Set(ByVal psnb As String)
            snbempresa = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Tipo de personal
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdtipo() As String
        Get
            Return scdtipo
        End Get
        Set(ByVal pscd As String)
            scdtipo = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Email de la persona
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbemail() As String
        Get
            Return snbemail
        End Get
        Set(ByVal psnb As String)
            snbemail = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Número de teléfono de su casa
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nutelcasa() As String
        Get
            Return snutelcasa
        End Get
        Set(ByVal psnu As String)
            snutelcasa = psnu
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Número de teléfono de su oficina
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nuteloficina() As String
        Get
            Return snuteloficina
        End Get
        Set(ByVal psnu As String)
            snuteloficina = psnu
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave del usuario
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdusuario() As String
        Get
            Return scdusuario
        End Get
        Set(ByVal pscd As String)
            scdusuario = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: RFC de la persona
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdrfc() As String
        Get
            Return scdrfc
        End Get
        Set(ByVal pscd As String)
            scdrfc = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Comentario de la persona
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property comment() As String
        Get
            Return scomment
        End Get
        Set(ByVal psval As String)
            scomment = psval.Trim
        End Set
    End Property

End Class  'fin clase [Persona]