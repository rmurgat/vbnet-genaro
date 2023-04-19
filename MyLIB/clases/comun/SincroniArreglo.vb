Imports Microsoft.VisualBasic

''' <summary>
'''     Clase que contiene los datos de la sincronia para un arreglo
''' </summary>
''' <empresa>
'''     01 - ATL Solutions S.A. de C.V. 
''' </empresa>
''' <autor>
'''     Rubén Murga Tapia (14-Marzo-2009)
''' </autor>
''' <remarks></remarks>

Public Class SincroniArreglo
    Private scdproyecto As String = ""              ' Clave del proyecto
    Private scdpantalla As String = ""              ' Clave de la pantalla
    Private scdarreglo As String = ""               ' Clave del arreglo
    Private scdsincronia As String = ""             ' Clave de la sincronia
    Private snbidhtml As String = ""                ' Id HTML del renglón donde se coloca el arreglo
    Private stpelement As String = ""               ' Tipo/Clase de Elemento
    Private snbelement As String = ""               ' Nombre del Objeto para el Elemento
    Private snbobject As String = ""                ' Nombre del Objeto
    Private sstarreglo As String = ""               ' Estatus del arreglo

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' PROPIEDAD: Clave del proyecto
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdproyecto() As String
        Get
            Return scdproyecto
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then
                scdproyecto = ""
                Exit Property
            End If
            scdproyecto = pscd.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave de la pantalla
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdpantalla() As String
        Get
            Return scdpantalla
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then
                scdpantalla = ""
                Exit Property
            End If
            scdpantalla = pscd.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave del arreglo
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdarreglo() As String
        Get
            Return scdarreglo
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then
                scdarreglo = ""
                Exit Property
            End If
            scdarreglo = pscd.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave de la sincronia
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdsincronia() As String
        Get
            Return scdsincronia
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then
                scdsincronia = ""
                Exit Property
            End If
            scdsincronia = pscd.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Id HTML del renglón donde se coloca el arreglo
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property nbidhtml() As String
        Get
            Return snbidhtml
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then
                snbidhtml = ""
                Exit Property
            End If
            snbidhtml = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Tipo/Clase de Elemento
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property tpelement() As String
        Get
            Return stpelement
        End Get
        Set(ByVal pstp As String)
            If pstp Is Nothing Then
                stpelement = ""
                Exit Property
            End If
            stpelement = pstp.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Nombre del Objeto para el Elemento
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property nbelement() As String
        Get
            Return snbelement
        End Get
        Set(ByVal pstp As String)
            If pstp Is Nothing Then
                snbelement = ""
                Exit Property
            End If
            snbelement = pstp.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Nombre del Objeto
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property nbobject() As String
        Get
            Return snbobject
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then
                snbobject = ""
                Exit Property
            End If
            snbobject = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Estatus del arreglo
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property starreglo() As String
        Get
            Return sstarreglo
        End Get
        Set(ByVal psst As String)
            If psst Is Nothing Then
                sstarreglo = ""
                Exit Property
            End If
            sstarreglo = psst.Trim
        End Set
    End Property


End Class   ' fin clase [SincroniArreglo]

