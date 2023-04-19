Option Explicit On
''' <summary>
''' Clase que tiene las propiedades y metodos propios de una empresa
''' </summary>
''' <company>ATL Solutions</company>
''' <project>VBNET_Proyecto</project>
''' <autor>Rubén Murga Tapia</autor>
''' <created>18-Mayo-2008  12:00 am</created>
''' <remarks></remarks>
Public Class Empresa
    Private scdempresa As String ' Clave de la empresa
    Private snbempresa As String ' Nombre de la empresa
    Private snutelefono As String ' Número de teléfono de la empresa
    Private snbdireccion As String ' Dirección de la empresa
    Private scdrfc As String ' Rfc de la empresa

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' PROPIEDAD: Clave de la empresa
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdempresa() As String
        Get
            Return scdempresa
        End Get
        Set(ByVal pscd As String)
            scdempresa = pscd
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
            snbempresa = psnb
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Número de teléfono de la empresa
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nutelefono() As String
        Get
            Return snutelefono
        End Get
        Set(ByVal psnu As String)
            snutelefono = psnu
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Dirección de la empresa
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbdireccion() As String
        Get
            Return snbdireccion
        End Get
        Set(ByVal psnb As String)
            snbdireccion = psnb
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Rfc de la empresa
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

End Class  'fin clase [Empresa]