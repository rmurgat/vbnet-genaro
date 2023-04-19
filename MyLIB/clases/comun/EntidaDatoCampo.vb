Option Explicit On

''' <summary>
''' Clase que tiene las propiedades y metodos de los campos
''' </summary>
''' <company>ATL Solutions</company>
''' <project>VBNET_Proyecto</project>
''' <autor>Rubén Murga Tapia</autor>
''' <created>18-Mayo-2008  12:00 am</created>
''' <remarks></remarks>
Public Class EntidaDatoCampo
    Private scdfuentedato As String = ""    ' Clave de la fuente de datos
    Private snbentidadato As String = ""     ' Nombre de la entidad de datos
    Private snbcampo As String = ""         ' Nombre del campo
    Private icdorden As Integer = 0         ' Clave definida para su ordenamiento
    Private inulongitud As Integer = 0      ' Longitud del campo
    Private inudecimales As Integer = 0     ' Número de decimales utilizados en el campo
    Private sstpermitenulos As String = ""  ' Estatus que determina si el campo permite valores null
    Private sstesllave As String = "IN"     ' Estatus que determina si se trata de una llave primaria
    Private sstesalterna As String = "IN"   ' Bandera que determina si el campo es llave alterna
    Private sstesautoincremento As String = "IN"   ' Bandera que determina si el campo es auto incrementable
    Private sstessecuencia As String = "IN" ' Bandera que determina si el campo es una secuencia
    Private snbsecuencia As String = ""     ' Nombre de la secuencia
    Private scdtpdatofisico As String = ""  ' Clave del tipo de campo
    Private snbvariable As String = ""      ' Nombre de la variable en algún lenguaje
    Private stxcomment As String = ""       ' Comentarios respecto al campo
    Private stxddl As String = ""           ' Texto con la declaración del campo 

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' PROPIEDAD: Clave de la fuente de datos
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdfuentedato() As String
        Get
            Return scdfuentedato
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            scdfuentedato = pscd.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Nombre de la entidad de datos
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbentidadato() As String
        Get
            Return snbentidadato
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then Exit Property
            snbentidadato = psnb.Trim
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
            If psnb Is Nothing Then Exit Property
            snbcampo = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave definida para su ordenamiento
    ''' </summary>
    ''' <value>Integer</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdorden() As Integer
        Get
            Return icdorden
        End Get
        Set(ByVal pival As Integer)
            icdorden = pival
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
    ''' PROPIEDAD: Estatus que determina si el campo permite valores null
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property stpermitenulos() As String
        Get
            Return sstpermitenulos
        End Get
        Set(ByVal psst As String)
            sstpermitenulos = psst
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Estatus que determina si se trata de una llave
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property stesllave() As String
        Get
            Return sstesllave
        End Get
        Set(ByVal psst As String)
            sstesllave = psst
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Bandera que determina si el campo es llave alterna
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property stesalterna() As String
        Get
            Return sstesalterna
        End Get
        Set(ByVal psst As String)
            sstesalterna = psst.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Bandera que determina si el campo es auto incrementable
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property stesautoincremento() As String
        Get
            Return sstesautoincremento
        End Get
        Set(ByVal psst As String)
            sstesautoincremento = psst.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Bandera que determina si el campo es una secuencia
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property stessecuencia() As String
        Get
            Return sstessecuencia
        End Get
        Set(ByVal psst As String)
            sstessecuencia = psst.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Nombre de la secuencia
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property nbsecuencia() As String
        Get
            Return snbsecuencia
        End Get
        Set(ByVal pstx As String)
            snbsecuencia = pstx.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave del tipo de dato fisico
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdtpdatofisico() As String
        Get
            Return scdtpdatofisico
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            scdtpdatofisico = pscd.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Nombre de la variable en algún lenguaje
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbvariable() As String
        Get
            Return snbvariable
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then Exit Property
            snbvariable = psnb.Trim
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
            If pstx Is Nothing Then Exit Property
            stxcomment = pstx.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Texto con la declaración del campo
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property txddl() As String
        Get
            Return stxddl
        End Get
        Set(ByVal pstx As String)
            stxddl = pstx.Trim
        End Set
    End Property

    ''' <summary>
    ''' procedimiento para regresar si se trata de una llave
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function isllave() As Boolean
        If Me.stesllave.Equals("AC") Then Return True
        Return False
    End Function

    ''' <summary>
    ''' procedimiento para regresar si se trata de una llave alterna
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function isllavealterna() As Boolean
        If Me.stesalterna.Equals("AC") Then Return True
        Return False
    End Function

    ''' <summary>
    ''' Procedimiento que regresa una interpretación en xml de la variable
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getxml() As String
        Dim sxml As String = ""
        sxml = "<campo>"
        sxml = sxml & "<cdftedatos>" & Me.cdfuentedato & "</cdftedatos>"
        sxml = sxml & "<nbentidad>" & Me.nbentidadato & "</nbentidad>"
        sxml = sxml & "<nombre>" & Me.nbcampo & "</nombre>"
        sxml = sxml & "<orden>" & Me.cdorden & "</orden>"
        sxml = sxml & "<longitud>" & Me.inulongitud & "</longitud>"
        sxml = sxml & "<decimales>" & Me.inudecimales & "</decimales>"
        sxml = sxml & "<permitenulos>" & Me.stpermitenulos & "</permitenulos>"
        sxml = sxml & "<autoincremento>" & IIf(Me.stesautoincremento.Equals("AC"), "Si", "No") & "</autoincremento>"
        sxml = sxml & "<esecuencia>" & IIf(Me.stessecuencia.Equals("AC"), "Si", "No") & "</esecuencia>"
        sxml = sxml & "<nbsecuencia>" & Me.nbsecuencia & "</nbsecuencia>"
        sxml = sxml & "<llave>" & IIf(Me.stesllave.Equals("AC"), "Si", "No") & "</llave>"
        sxml = sxml & "<tipo>" & Me.cdtpdatofisico.ToLower & "</tipo>"
        sxml = sxml & "<nbvariable>" & Me.snbvariable & "</nbvariable>"
        sxml = sxml & "<comment>" & Me.stxcomment & "</comment>"
        sxml = sxml & "</campo>"
        Return sxml
    End Function

End Class  'fin clase [EntidaDatoCampo]