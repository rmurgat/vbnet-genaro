Imports Microsoft.VisualBasic

''' <summary>
'''     Clase que tiene las propiedades y metodos para los arreglos de las pantallas
''' </summary>
''' <empresa>
'''     01 - ATL Solutions S.A. de C.V. 
''' </empresa>
''' <autor>
'''     Rubén Murga Tapia (10-Marzo-2009)
''' </autor>
''' <remarks></remarks>
Public Class Pantallarreglo
    Private scdproyecto As String = ""        ' Clave del proyecto
    Private scdpantalla As String = ""        ' Clave de la pantalla
    Private scdarreglo As String = ""         ' Clave del arreglo
    Private stpinoutput As String = ""        ' Tipo input / output
    Private inurensxpagina As Integer = 0     ' Número de renglones por página
    Private snbarreglo As String = ""         ' Nombre del arreglo
    Private sstpaginacion As String = ""      ' Estatus de paginación
    Private osincronia As SincroniArreglo = Nothing   'Objeto con información de sincronización
    Private cCampos As Collection             ' Colección de campos

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        cCampos = New Collection
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
    ''' PROPIEDAD: Tipo input / output
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property tpinoutput() As String
        Get
            Return stpinoutput
        End Get
        Set(ByVal pstp As String)
            If pstp Is Nothing Then Exit Property
            stpinoutput = pstp
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Número de renglones por página
    ''' </summary>
    ''' <value></value>
    ''' <returns>Integer</returns>
    ''' <remarks></remarks>
    Public Property nurensxpagina() As Integer
        Get
            Return inurensxpagina
        End Get
        Set(ByVal pival As Integer)
            inurensxpagina = pival
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Nombre del arreglo
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property nbarreglo() As String
        Get
            Return snbarreglo
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then
                snbarreglo = ""
                Exit Property
            End If
            snbarreglo = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Estatus de paginación
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property stpaginacion() As String
        Get
            Return sstpaginacion
        End Get
        Set(ByVal psst As String)
            If psst Is Nothing Then
                sstpaginacion = ""
                Exit Property
            End If
            sstpaginacion = psst.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Colección de campos
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property Campos() As Collection
        Get
            Return cCampos
        End Get
        Set(ByVal pcval As Collection)
            If pcval Is Nothing Then Exit Property
            cCampos = pcval
        End Set
    End Property



    ''' <summary>
    ''' PROPIEDAD: Objeto con información de sincronización
    ''' </summary>
    ''' <value></value>
    ''' <returns>SincroniaCampo</returns>
    ''' <remarks></remarks>
    Public Property sincronia() As SincroniArreglo
        Get
            Return osincronia
        End Get
        Set(ByVal poval As SincroniArreglo)
            osincronia = poval
        End Set
    End Property

    ''' <summary>
    ''' Función que determina si el arreglo tiene paginación
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Function haspaginacion() As Boolean
        If sstpaginacion.Equals(Comun.ST_ACTIVO) Then Return True
        Return False
    End Function

    ''' <summary>
    ''' Procedimiento para regresar el xml relacionado a este campo
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetXML() As String
        Dim sxml As String

        sxml = "<arreglo>"
        sxml = sxml & "<cdproyecto>" & Me.scdproyecto & "</cdproyecto>"
        sxml = sxml & "<cdpantalla>" & Me.cdpantalla & "</cdpantalla>"
        sxml = sxml & "<cdarreglo>" & Me.scdarreglo & "</cdarreglo>"
        sxml = sxml & "<tpinoutput>" & Me.tpinoutput & "</tpinoutput>"
        sxml = sxml & "<nurensxpagina>" & Me.inurensxpagina & "</nurensxpagina>"
        sxml = sxml & "<nbarreglo>" & Me.snbarreglo & "</nbarreglo>"
        sxml = sxml & "<stpaginacion>" & IIf(Me.stpaginacion.Equals(Comun.ST_ACTIVO), "Si", "No") & "</stpaginacion>"
        If Not osincronia Is Nothing Then
            sxml = sxml & "<nbidhtml>" & osincronia.nbidhtml & "</nbidhtml>"
            sxml = sxml & "<tpelement>" & osincronia.tpelement & "</tpelement>"
            sxml = sxml & "<nbelement>" & osincronia.nbelement & "</nbelement>"
            sxml = sxml & "<nbobject>" & osincronia.nbobject & "</nbobject>"
            sxml = sxml & "<starreglo>" & osincronia.starreglo & "</starreglo>"
        End If
        sxml = sxml & "<arrcampos>"
        For Each ocampo As PantallaCampo In cCampos
            sxml = sxml & ocampo.GetXML()
        Next
        sxml = sxml & "</arrcampos>"
        sxml = sxml & "</arreglo>"
        Return sxml
    End Function

End Class   ' fin clase [Pantallarreglo]

