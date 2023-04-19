Option Explicit On

''' <summary>
''' Clase que tiene las propiedades y metodos de los botones de las pantallas
''' </summary>
''' <company>ATL Solutions</company>
''' <project>VBNET_Proyecto</project>
''' <autor>Rubén Murga Tapia</autor>
''' <created>18-Mayo-2008  12:00 am</created>
''' <remarks></remarks>
Public Class PantallaBoton
    Private scdpantalla As String = "" ' Clave de la pantalla
    Private scdproyecto As String = "" ' Clave del proyecto
    Private snbboton As String = ""    ' Nombre del boton
    Private scdboton As String = ""    ' Clave del boton
    Private stxcomment As String = ""  ' Comentarios respecto al boton

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
    ''' PROPIEDAD: Clave de la pantalla
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdpantalla() As String
        Get
            Return scdpantalla
        End Get
        Set(ByVal pscd As String)
            scdpantalla = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave del boton
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdboton() As String
        Get
            Return scdboton
        End Get
        Set(ByVal pscd As String)
            scdboton = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Nombre del boton
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbboton() As String
        Get
            Return snbboton
        End Get
        Set(ByVal psnb As String)
            snbboton = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Comentarios respecto al boton
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

    Public Function GetXML() As String
        Dim sxml As String

        sxml = "<boton>"
        sxml = sxml & "<cdproyecto>" & Me.cdproyecto & "</cdproyecto>"
        sxml = sxml & "<cdpantalla>" & Me.cdpantalla & "</cdpantalla>"
        sxml = sxml & "<cdboton>" & Me.cdboton & "</cdboton>"
        sxml = sxml & "<nbboton>" & Me.nbboton & "</nbboton>"
        sxml = sxml & "<txcomment>" & Me.txcomment & "</txcomment>"
        sxml = sxml & "</boton>"

        Return sxml
    End Function

End Class  'fin clase [Boton]