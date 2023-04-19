Option Explicit On 

''' <summary>
''' Clase que tiene las propiedades y metodos de las variables
''' </summary>
''' <remarks></remarks>
Public Class Variable
    Private snombre As String = ""          ' Nombre de la variable que ha sido declarada
    Private stipo As String = ""            ' Tipo de la variable de la que se trata
    Private bllave As Boolean = False       ' Define si la variable se trata de una llave
    Private bformat As Boolean = False      ' Determina si aplica el formato sobre la salida
    Private sin2type As String = ""         ' Se determina aquí si aplica un segundo tipo de entrada
    Private bvalidnull As Boolean = False   ' Determina si valida el null
    Private sdbcampo As String = ""         ' Campo de base de datos
    Private scomment As String = ""         ' Comentario sobre la variable
    Private svalor As String = ""           ' Valor de la variable
    Private inulongitud As Integer = 0      ' Longitud del campo
    Private inudecimales As Integer = 0     ' Número de decimales utilizados en el campo
    Private oCampo As EntidaDatoCampo       ' Objeto que tiene la información relativa al campo de la entidad

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        oCampo = New EntidaDatoCampo
    End Sub

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <param name="sname">nombre de la variable</param>
    ''' <param name="stype">tipo de la variable</param>
    ''' <param name="scomment">comentario</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal sname As String, ByVal stype As String, ByVal scomment As String)
        Me.nombre = sname
        Me.tipo = stype
        Me.comment = scomment
    End Sub

    ''' <summary>
    ''' PROPIEDAD: nombre de la variable que participa en la declaración
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de la propiedad</returns>
    ''' <remarks></remarks>
    Public Property nombre() As String
        Get
            Return snombre
        End Get
        Set(ByVal snb As String)
            If snb Is Nothing Then Exit Property
            snombre = snb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: tipo de variable de la que se trata
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de la propiedad</returns>
    ''' <remarks></remarks>
    Public Property tipo() As String
        Get
            Return stipo
        End Get
        Set(ByVal sty As String)
            If sty Is Nothing Then Exit Property
            stipo = sty.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: formato que debe aplicarse a la salida
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>valor de la propiedad</returns>
    ''' <remarks></remarks>
    Public Property format() As Boolean
        Get
            Return bformat
        End Get
        Set(ByVal bfm As Boolean)
            bformat = bfm
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: define si la variable se trata de una llave
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>valor de la propiedad</returns>
    ''' <remarks></remarks>
    Public Property llave() As Boolean
        Get
            Return bllave
        End Get
        Set(ByVal bk As Boolean)
            bllave = bk
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: tipo 2 para el ingreso de datos
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de la propiedad</returns>
    ''' <remarks></remarks>
    Public Property in2type() As String
        Get
            Return sin2type
        End Get
        Set(ByVal sty As String)
            If sty Is Nothing Then Exit Property
            sin2type = sty
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: define si valida el nulo
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>valor de la propiedad</returns>
    ''' <remarks></remarks>
    Public Property validnull() As Boolean
        Get
            Return bvalidnull
        End Get
        Set(ByVal bva As Boolean)
            bvalidnull = bva
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: nombre de la variable que participa en la declaración
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de la propiedad</returns>
    ''' <remarks></remarks>
    Public Property dbcampo() As String
        Get
            Return sdbcampo
        End Get
        Set(ByVal sdb As String)
            If sdb Is Nothing Then Exit Property
            sdbcampo = sdb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: comentario en la declaración de la variable
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de la propiedad</returns>
    ''' <remarks></remarks>
    Public Property comment() As String
        Get
            Return scomment
        End Get
        Set(ByVal scom As String)
            If scom Is Nothing Then
                scomment = ""
                Exit Property
            End If
            scomment = scom.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Longitud del campo
    ''' </summary>
    ''' <value>Integer</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nulongitud() As Integer
        Get
            Return inulongitud
        End Get
        Set(ByVal pival As Integer)
            inulongitud = pival
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Número de decimales utilizados en el campo
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

    ''' <summary>
    ''' Función para regresar el nombre del metodo GET
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function getnbget() As String
        Dim smethod As String
        smethod = Mid$(snombre, 2)
        Return "get" & smethod
    End Function

    ''' <summary>
    ''' Función para regresar el nombre del metodo SET
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function getnbset() As String
        Dim smethod As String
        smethod = Mid$(snombre, 2)
        Return "set" & smethod
    End Function

    ''' <summary>
    ''' METODO: regresa el nombre del property
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function nbproperty() As String
        nbproperty = Mid$(snombre, 2)
    End Function

    ''' <summary>
    ''' PROPIEDAD: valor de la variable
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property valor() As String
        Get
            Return svalor
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            svalor = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Objeto que tiene la información relativa al campo de la entidad
    ''' </summary>
    ''' <value></value>
    ''' <returns>EntidaDatoCampo</returns>
    ''' <remarks></remarks>
    Public Property Campo() As EntidaDatoCampo
        Get
            Return oCampo
        End Get
        Set(ByVal poval As EntidaDatoCampo)
            oCampo = poval
        End Set
    End Property

    ''' <summary>
    ''' METODO: regresa el nombre del parametro
    ''' </summary>
    ''' <param name="snombre">nombre de variable</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function getnbparam(ByVal snombre As String) As String
        Dim sparam As String = ""
        Dim stp As String
        If snombre.Equals("") Then Return ""
        stp = snombre.Substring(0, 1).ToLower
        If snombre.StartsWith("sfh") Then sparam = "p" + stp + "fh"
        If snombre.StartsWith("scd") Then sparam = "p" + stp + "cd"
        If snombre.StartsWith("sst") Then sparam = "p" + stp + "st"
        If snombre.StartsWith("stp") Then sparam = "p" + stp + "tp"
        If snombre.StartsWith("snb") Then sparam = "p" + stp + "nb"
        If snombre.StartsWith("snu") Then sparam = "p" + stp + "nu"
        If snombre.StartsWith("ict") Then sparam = "p" + stp + "ct"
        If snombre.StartsWith("dto") Then sparam = "p" + stp + "to"
        If snombre.StartsWith("dnu") Then sparam = "p" + stp + "nu"
        If snombre.StartsWith("dim") Then sparam = "p" + stp + "im"
        If snombre.StartsWith("stx") Then sparam = "p" + stp + "tx"
        If sparam = "" Then sparam = "p" + stp + "val"
        getnbparam = sparam
    End Function

    ''' <summary>
    ''' Procedimiento que regresa una interpretación en xml de la variable
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetXML() As String
        Dim sxml As String = ""
        sxml = "<variable>"
        sxml = sxml & "<nombre>" & Me.nombre & "</nombre>"
        sxml = sxml & "<tipo>" & Me.tipo & "</tipo>"
        sxml = sxml & "<valor>" & Me.svalor & "</valor>"
        sxml = sxml & "<llave>" & IIf(Me.bllave, "Si", "No") & "</llave>"
        sxml = sxml & "<dbcampo>" & Me.sdbcampo & "</dbcampo>"
        sxml = sxml & "<dblongitud>" & Me.inulongitud & "</dblongitud>"
        sxml = sxml & "<dbdecimales>" & Me.inudecimales & "</dbdecimales>"
        sxml = sxml & "<formatear>" & IIf(Me.bformat, "Si", "No") & "</formatear>"
        sxml = sxml & "<validanull>" & IIf(Me.bvalidnull, "Si", "No") & "</validanull>"
        sxml = sxml & "<parametro>" & Me.getnbparam(Me.nombre) & "</parametro>"
        sxml = sxml & "<comentario>" & Me.comment & "</comentario>"
        sxml = sxml & "</variable>"
        Return sxml
    End Function

End Class  ' fin clase [Variable]
