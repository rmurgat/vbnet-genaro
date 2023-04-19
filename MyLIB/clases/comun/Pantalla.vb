Option Explicit On

''' <summary>
''' Clase que tiene las propiedades y metodos propios de las pantallas que se utilizan en un sistema
''' </summary>
''' <company>ATL Solutions</company>
''' <project>VBNET_Proyecto</project>
''' <autor>Rubén Murga Tapia</autor>
''' <created>18-Mayo-2008  12:00 am</created>
''' <remarks></remarks>
Public Class Pantalla
    Private scdpantalla As String = ""       ' Clave de la pantalla
    Private snbimagefile As String = ""      ' Nombre del archivo imagen
    Private stxcomment As String = ""        ' Comentario
    Private stxobjetivo As String = ""       ' Objetivo
    Private snbpantalla As String = ""       ' Nombre de la pantalla
    Private scdanalista As String = ""       ' Clave del analista
    Private snbanalista As String = ""       ' Nombre del analista
    Private scdprogramador As String = ""    ' Clave del programador
    Private snbprogramador As String = ""    ' Nombre del programador
    Private scdproyecto As String = ""       ' Clave del proyecto
    Private scdstconstruccion As String = "" ' Estatus de la construcción
    Private snbstconstruccion As String = "" ' Nombre del Estatus de la construcción
    Private scdstanalisis As String = ""     ' Estatus del analisis
    Private snbstanalisis As String = ""     ' Nombre del Estatus del analisis
    Private scdcodigo As String = ""         ' Codigo para identificar de manera unica una pantalla
    Private cCampos As Collection            ' Colección de campos
    Private cEventos As Collection           ' Colección de eventos
    Private cBotones As Collection           ' Colección de botones
    Private cArreglos As Collection          ' Colección de arreglos
    Private outil As Utilerias               ' Utilerias
    Private osincronia As SincroniaPantalla = Nothing   'Objeto con información de sincronización

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        cCampos = New Collection
        cEventos = New Collection
        cBotones = New Collection
        outil = New Utilerias
        cArreglos = New Collection
    End Sub

    ''' <summary>
    ''' PROPIEDAD:  Clave del proyecto
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
    ''' PROPIEDAD:  Clave de la pantalla
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
    ''' PROPIEDAD:  Nombre de la pantalla
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbpantalla() As String
        Get
            Return snbpantalla
        End Get
        Set(ByVal psnb As String)
            snbpantalla = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Codigo para identificar de manera unica una pantalla
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdcodigo() As String
        Get
            Return scdcodigo
        End Get
        Set(ByVal pscd As String)
            scdcodigo = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Nombre del archivo imagen
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbimagefile() As String
        Get
            Return snbimagefile
        End Get
        Set(ByVal psnb As String)
            snbimagefile = psnb.Trim
        End Set
    End Property

    '' <summary>
    '' Función que regresa solo el nombre del archivo
    '' </summary>
    '' <returns>String</returns>
    '' <remarks></remarks>
    'Public Function getjustnbhtmlfile() As String
    'Dim ilast As Integer
    'Dim snombre As String

    '    ilast = snbhtmlfile.LastIndexOf("\")
    '    snombre = snbhtmlfile.Substring(ilast + 1)
    '    Return outil.Toma_Token(1, snombre, ".")
    'End Function


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

    ''' <summary>
    ''' PROPIEDAD:  Objetivo
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property txobjetivo() As String
        Get
            Return stxobjetivo
        End Get
        Set(ByVal pstx As String)
            stxobjetivo = pstx.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Clave del analista
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdanalista() As String
        Get
            Return scdanalista
        End Get
        Set(ByVal pscd As String)
            scdanalista = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Nombre del analista
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbanalista() As String
        Get
            Return snbanalista
        End Get
        Set(ByVal psnb As String)
            snbanalista = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Clave del programador
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdprogramador() As String
        Get
            Return scdprogramador
        End Get
        Set(ByVal pscd As String)
            scdprogramador = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Nombre del programador
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbprogramador() As String
        Get
            Return snbprogramador
        End Get
        Set(ByVal psnb As String)
            snbprogramador = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Estatus de la construcción
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdstconstruccion() As String
        Get
            Return scdstconstruccion
        End Get
        Set(ByVal pscd As String)
            scdstconstruccion = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Nombre del Estatus de la construcción
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbstconstruccion() As String
        Get
            Return snbstconstruccion
        End Get
        Set(ByVal psnb As String)
            snbstconstruccion = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Estatus del analisis
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdstanalisis() As String
        Get
            Return scdstanalisis
        End Get
        Set(ByVal pscd As String)
            scdstanalisis = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Nombre del Estatus del analisis
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbstanalisis() As String
        Get
            Return snbstanalisis
        End Get
        Set(ByVal psnb As String)
            snbstanalisis = psnb.Trim
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
            cCampos = pcval
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Colección de eventos
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property Eventos() As Collection
        Get
            Return cEventos
        End Get
        Set(ByVal pcval As Collection)
            cEventos = pcval
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Colección de botones
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property Botones() As Collection
        Get
            Return cBotones
        End Get
        Set(ByVal pcval As Collection)
            cBotones = pcval
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Colección de arreglos
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property Arreglos() As Collection
        Get
            Return cArreglos
        End Get
        Set(ByVal pcval As Collection)
            cArreglos = pcval
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Objeto con información de sincronización
    ''' </summary>
    ''' <value></value>
    ''' <returns>SincroniaPantalla</returns>
    ''' <remarks></remarks>
    Public Property sincronia() As SincroniaPantalla
        Get
            Return osincronia
        End Get
        Set(ByVal poval As SincroniaPantalla)
            osincronia = poval
        End Set
    End Property


    Public Function GetXML() As String
        Dim sxml As String

        'PASO 1: Asigna los campos a un arreglo en particular
        Call Asigna_CamposEnArreglo()

        'PASO 2: Imprime la info general de una pantalla
        sxml = "<pantalla>"
        sxml = sxml & "<cdproyecto>" & Me.cdproyecto & "</cdproyecto>"
        sxml = sxml & "<cdpantalla>" & Me.cdpantalla & "</cdpantalla>"
        sxml = sxml & "<nbimagefile>" & Me.nbimagefile & "</nbimagefile>"
        sxml = sxml & "<txcomment>" & Me.txcomment & "</txcomment>"
        sxml = sxml & "<txobjetivo>" & Me.txobjetivo & "</txobjetivo>"
        sxml = sxml & "<cdanalista>" & Me.cdanalista & "</cdanalista>"
        sxml = sxml & "<nbanalista>" & Me.nbanalista & "</nbanalista>"
        sxml = sxml & "<cdprogramador>" & Me.cdprogramador & "</cdprogramador>"
        sxml = sxml & "<nbprogramador>" & Me.nbprogramador & "</nbprogramador>"
        sxml = sxml & "<cdcodigo>" & Me.cdcodigo & "</cdcodigo>"

        'PASO 3: Imprime la info de sincronización de la pantalla
        If Not osincronia Is Nothing Then
            sxml = sxml & "<stsincronia>" & osincronia.estatus & "</stsincronia>"
            sxml = sxml & "<nbhtmlforma>" & osincronia.nbhtmlforma & "</nbhtmlforma>"
            sxml = sxml & "<nbcomponente>" & osincronia.nbcomponente & "</nbcomponente>"
            sxml = sxml & "<nbhtmlfile>" & osincronia.nbhtmlfile & "</nbhtmlfile>"
        End If

        'PASO 4: Imprime la info de los arreglos
        sxml = sxml & "<arreglos>"
        For Each oarreglo As Pantallarreglo In Me.Arreglos
            sxml = sxml & oarreglo.GetXML()
        Next
        sxml = sxml & "</arreglos>"

        'PASO 5: Imprime la info de los campos / solo aquellos fuera de un arreglo
        sxml = sxml & "<campos>"
        For Each ocampo As PantallaCampo In Me.Campos
            If ocampo.cdarreglo.Equals("") Then sxml = sxml & ocampo.GetXML()
        Next
        sxml = sxml & "</campos>"

        'PASO 6: Imprime la info de los eventos
        sxml = sxml & "<eventos>"
        For Each oevento As PantallaEvento In Me.Eventos
            sxml = sxml & oevento.GetXML()
        Next
        sxml = sxml & "</eventos>"

        'PASO 7: Imprime la info total de sincronización
        If Not osincronia Is Nothing Then sxml = sxml & osincronia.xmlpantalla

        sxml = sxml & "</pantalla>"

        Return sxml
    End Function

    ''' <summary>
    ''' Procedimiento para asignar todos los campos que pertenecen a un arreglo
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Asigna_CamposEnArreglo()

        If cArreglos.Count = 0 Then Exit Sub
        For Each oarreglo As Pantallarreglo In cArreglos
            Dim cenarreglo As Collection = New Collection
            For Each ocampo As PantallaCampo In Me.Campos
                If ocampo.cdarreglo.Equals(oarreglo.cdarreglo) Then cenarreglo.Add(ocampo)
            Next
            oarreglo.Campos = cenarreglo
        Next

    End Sub

End Class  'fin clase [Pantalla]