Imports System.Text.RegularExpressions
Imports System.IO
Imports mshtml

''' <summary>
''' Clase que tiene las propiedades y metodos de un HTML, Está clase también trata 
''' los temas de:
''' 1. Incorporación de validaciones
''' 2. Incorporación de header
''' 3. Incorporación de footer
''' </summary>
''' <remarks>
''' </remarks>
Public Class Html2CGI
    Private ohtml As HTMLReader
    Private outil As Utilerias               ' Utilerias del sistema
    Private ozipconfig As ZipArchivo         ' Objeto que tiene las especificaciones en XML
    Private sestilo As String = ""           ' Estilo de programación
    Private sprocesador As String = ""       ' Configuración procesadora del estilo 
    Private oxmlProcesa As Nodo              ' xml para el procesador
    Private oxmlCGI As Nodo

    Private sfileheader As String = ""       ' Nombre del archivo para el header
    Private sfilefooter As String = ""       ' Nombre del archivo para el footer
    Private sfileinmersohtml As String = ""  ' Nombre del archivo para el inmerso html
    Private sfileiniarray As String = ""     ' Nombre del archivo para el inicio de un array
    Private sfilefinarray As String = ""     ' Nombre del archivo para el fin de un array

    Private smetaheader As String = ""       ' Metacódigo para el header del HTML
    Private smetafooter As String = ""       ' Metacódigo para el footer del HTML
    Private smetainmersohtml As String = ""  ' Metacódigo para las asignaciones
    Private smetainiarray As String = ""     ' Metacódigo para el inicio de un arreglo
    Private smetafinarray As String = ""     ' Metacódigo para el fin de un arreglo
    Private sxml As String = ""              ' Objeto que tiene las especiicaciones en XML
    Private sdebug As String = ""            ' Cadena que tiene el detalle del debug en una conversión

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        outil = New Utilerias
        ohtml = New HTMLReader
    End Sub

    ''' <summary>
    ''' PROPIEDAD: Objeto que tiene las especificaciones en XML
    ''' </summary>
    ''' <value></value>
    ''' <returns>Nodo</returns>
    ''' <remarks></remarks>
    Public Property zipconfig() As ZipArchivo
        Get
            Return ozipconfig
        End Get
        Set(ByVal poval As ZipArchivo)
            ozipconfig = poval
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Estilo de programación
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property estilo() As String
        Get
            Return sestilo
        End Get
        Set(ByVal psval As String)
            sestilo = psval.Trim
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Configuración procesadora del estilo
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property procesador() As String
        Get
            Return sprocesador
        End Get
        Set(ByVal psval As String)
            sprocesador = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <param name="sdir">Nombre del directorio</param>
    ''' <param name="sfile">Nombre del archivo</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal sdir As String, ByVal sfile As String)
        outil = New Utilerias
    End Sub

    ''' <summary>
    ''' Función para regresar el debug
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function getdebug() As String
        Return sdebug
    End Function

    ''' <summary>
    ''' Procedimiento para inicializar un archivo HTML
    ''' </summary>
    ''' <param name="snbfile">Nombre del archivo</param>
    ''' <remarks></remarks>
    Public Function Carga(ByVal snbfile As String) As Boolean
        Return ohtml.Carga(snbfile)
    End Function

    ''' <summary>
    ''' Procedimiento para inicializar un archivo HTML
    ''' </summary>
    ''' <param name="shtml">Nombre del archivo</param>
    ''' <remarks></remarks>
    Public Sub SetHTML(ByVal shtml As String)
        ohtml.content = shtml
    End Sub


    ''' <summary>
    ''' Función para regresar el contenido HTML de un archivo
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetHTML() As String
        Return ohtml.content
    End Function


    ''' <summary>
    ''' Procedimiento para generar el código dentro del HTML 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub generaScriptsInsideHTML()
        Dim oxmlmain, oxmlcampos As Nodo
        Dim ccampos As Collection

        Try
            'PASO 1: Inicializa los valores
            oxmlmain = New Nodo(Me.GetXML())

            'PASO 2: Recorre los campos para asignarle valores en el HTML
            oxmlcampos = oxmlmain.getPrimerNodo("campos")
            ccampos = oxmlcampos.getNodo("campo")
            For Each oxmlcampo As Nodo In ccampos
                Dim scodigo As String
                ohtml.getTagCurrentValues(ohtml.content, oxmlcampo)
                scodigo = Me.generaCodigoxCampo(oxmlcampo)
                sdebug = sdebug & "      SET IDHTML=[" & oxmlcampo.getValue("campo.html.idhtml") & "]=[" & scodigo & "]" & vbLf & vbCr
                ohtml.setTagCode(ohtml.content, oxmlcampo, scodigo)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Html2CGI.generaScriptsInsideHTML()", "Ocurrio un error al insertar codigo INSIDE HTML")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Html2CGI.generaScriptsInsideHTML()", "Ocurrio un error al insertar codigo INSIDE HTML [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Funciónpara generar el codigo por cada campo
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Private Function generaCodigoxCampo(ByVal oxmlcampo As Nodo) As String
        Dim sres As String = ""
        Try
            Dim ometareader As MetacodigoReader
            ometareader = New MetacodigoReader()
            ometareader.source = Me.smetainmersohtml
            ometareader.file = Me.sfileinmersohtml
            ometareader.SetXML(oxmlcampo.GetXML())
            sres = ometareader.Interpreta()
            sdebug = sdebug & ometareader.getdebug()
            Return sres
        Catch ex As HANYException
            ex.add("MyLIB.Html2CGI.generaCodigoxCampo()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Html2CGI.generaCodigoxCampo()", "Ocurrio un error")
        End Try
    End Function

    Public Function generaVariables() As Collection
        Return New Collection
    End Function

    ''' <summary>
    ''' Función para generar el encabezado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub generaEncabezado()
        Dim ometareader As MetacodigoReader
        Dim sres As String = ""
        Try
            ometareader = New MetacodigoReader()
            ometareader.file = Me.sfileheader
            ometareader.source = Me.smetaheader
            ometareader.SetXML(Me.GetXML())
            sres = ometareader.Interpreta() & ohtml.content
            ohtml.content = sres
            sdebug = sdebug & ometareader.getdebug()
        Catch ex As HANYException
            ex.add("MyLIB.Html2CGI.generaEncabezado()", "Ocurrio un error al generar el encabezado")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Html2CGI.generaEncabezado()", "Ocurrio un error al generar el encabezado [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Función para generar el encabezado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub generaPiePagina()
        Dim ometareader As MetacodigoReader
        Try
            ometareader = New MetacodigoReader()
            ometareader.source = Me.smetafooter
            ometareader.SetXML(Me.GetXML())
            ohtml.content = ohtml.content & ometareader.Interpreta()
            sdebug = sdebug & ometareader.getdebug()
        Catch ex As HANYException
            ex.add("MyLIB.Html2CGI.generaPiePagina()", "Ocurrio un error al generar el pie de página")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Html2CGI.generaPiePagina()", "Ocurrio un error al generar el pie de página [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Functión para genera el programa CGI 
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function generaCGI() As String
        Dim svalida As String = ""

        Try
            svalida = Carga_Configuracion()
            If Not svalida.Equals("") Then Return "*** EXISTIERON ERRORES EN LA CONFIGURACIÓN CGI ***" & vbCr & vbCr & svalida

            'PASO 1: Renombro las funciones originales javascript, que han sido reescritas
            sdebug = "!INICIANDO generación CGI!" & vbCr
            sdebug = sdebug & "--------------------------------------------------------------------------------------------------------------------" & vbCr
            sdebug = sdebug & "*** PASO 1: Renombrando funciones javascript anteriores..." & vbCr
            Call RenombraFuncionesJavaScript()

            'PASO 2: Integra los valores a las variables / fuera de un arreglo...
            sdebug = sdebug & "--------------------------------------------------------------------------------------------------------------------" & vbCr
            sdebug = sdebug & "*** PASO 2: Generando el código inmerso en TAGS de HTML..." & vbCr
            Call generaScriptsInsideHTML()

            'PASO 3: Integra el código propio para los arreglos de objetos...
            sdebug = sdebug & "--------------------------------------------------------------------------------------------------------------------" & vbCr
            sdebug = sdebug & "*** PASO 3: Generando el código de los arreglos de HTML..." & vbCr
            Call generaScriptInsideHTMLArreglos()

            'PASO 4: Genera el header de el CGI...
            sdebug = sdebug & "--------------------------------------------------------------------------------------------------------------------" & vbCr
            sdebug = sdebug & "*** PASO 4: Generando el código del encabezado..." & vbCr
            Call generaEncabezado()

            'PASO 5: Genera el pie de pagina del CGI...
            sdebug = sdebug & "--------------------------------------------------------------------------------------------------------------------" & vbCr
            sdebug = sdebug & "*** PASO 5: Generando el código de pie de página..." & vbCr
            Call generaPiePagina()

            'PASO 6: Ahora genera todo el código extra 
            Dim oxmlextras As Nodo
            Dim cextras As Collection

            oxmlextras = oxmlProcesa.getPrimerNodo("extras")
            cextras = oxmlextras.getNodo("extra")
            For Each onodo As Nodo In cextras
                Dim ometa As MetacodigoReader

                ometa = New MetacodigoReader
                ometa.SetXML(Me.GetXML())
                ometa.file = oxmlCGI.getValue("estilo.directorio") & onodo.getValue("extra.archivo")
                ometa.source = ozipconfig.getFileInflated(oxmlCGI.getValue("estilo.directorio") & onodo.getValue("extra.archivo"))
                ohtml.content = ohtml.content.Replace(onodo.getValue("extra.anclaren"), ometa.Interpreta())
                sdebug = sdebug & ometa.getdebug()
            Next

            sdebug = sdebug & "!TERMINA PROCESO!"

            Return ohtml.content
        Catch ex As HANYException
            ex.add("MyLIB.Html2CGI.generaCGI()", "Ocurrio un error al renombrar funciones de javascript")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Html2CGI.generaCGI()", "Ocurrio un error al renombrar funciones de javascript [" & ex1.ToString & "]")
        End Try

    End Function

    ''' <summary>
    ''' Procedimiento para consultar el nombre de la forma
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function getnbforma() As String
        Dim ohtml As IHTMLDocument2
        Dim allElements As IHTMLElementCollection
        Dim allForms As IHTMLElementCollection
        Dim sforma As String

        Try
            ohtml = New HTMLDocumentClass()
            sforma = ""
            ohtml.write(Me.ohtml.content)
            allElements = ohtml.body.all
            allForms = allElements.tags("form")

            For Each oform As IHTMLElement In allForms
                sforma = oform.getAttribute("name")
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Html2CGI.getnbforma()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Html2CGI.getnbforma()", "Ocurrio un error")
        End Try

        Return sforma
    End Function

    ''' <summary>
    ''' Procedimiento para asignar un valor xml 
    ''' </summary>
    ''' <param name="sxml"></param>
    ''' <remarks></remarks>
    Public Sub SetXML(ByVal sxml As String)
        If sxml Is Nothing Then
            Me.sxml = ""
        End If
        Me.sxml = sxml
    End Sub

    ''' <summary>
    ''' Función para regresar el valor de xml
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetXML() As String
        Return Me.sxml
    End Function

    ''' <summary>
    ''' Procedimiento para renombrar las funciones en javascript
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub RenombraFuncionesJavaScript()
        Dim oxmlmain, oxmleventos As Nodo
        Dim ceventos As Collection
        Dim cfuncs As Collection
        Dim o_RegExp As Regex
        Dim o_Matches As MatchCollection
        Dim o_Match As Match
        Dim icounter As Integer

        Try
            'PASO 1: Inicializa los valores
            oxmlmain = New Nodo(Me.GetXML())
            cfuncs = New Collection
            icounter = 1

            'PASO 2: Recorre los eventos para extraer las funciones utilizadas
            oxmleventos = oxmlmain.getPrimerNodo("eventos")
            ceventos = oxmleventos.getNodo("evento")
            For Each oxmlevento As Nodo In ceventos
                Dim sfun As String
                sfun = oxmlevento.getValue("evehtml.funjavascript")
                If Not sfun.Equals("") Then cfuncs.Add(sfun)
            Next

            'PASO 3: Recorre todas las funciones utilizadas, si encuentra una, la renombra
            For Each sfun As String In cfuncs
                o_RegExp = New Regex("function\s+" & sfun & "\s*\(")
                o_Matches = o_RegExp.Matches(ohtml.content)
                For Each o_Match In o_Matches
                    sdebug = sdebug & "  Renombrando funcion " & sfun & "() -> " & sfun & outil.RefillCeros(icounter, 5) & "()" & vbCr
                    ohtml.content = ohtml.content.Replace(o_Match.Value, "function " & sfun & outil.RefillCeros(icounter, 5) & "(")
                    icounter = icounter + 1
                Next
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Html2CGI.RenombraFuncionesJavaScript()", "Ocurrio un error al renombrar funciones de javascript")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Html2CGI.RenombraFuncionesJavaScript()", "Ocurrio un error al renombrar funciones de javascript [" & ex1.ToString & "]")
        End Try

    End Sub

    ''' <summary>
    ''' Procedimiento para generar El Script propio de un arreglo
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub generaScriptInsideHTMLArreglos()
        Dim oxmlmain, oxmlarreglos As Nodo
        Dim oxmlcampos As Nodo
        Dim carreglos As Collection
        Dim ccampos As Collection
        Dim ometaini As MetacodigoReader
        Dim ometafin As MetacodigoReader

        Try
            'PASO 1: Inicializa los valores
            oxmlmain = New Nodo(Me.GetXML())
            ometaini = New MetacodigoReader
            ometaini.source = Me.smetainiarray
            ometafin = New MetacodigoReader
            ometafin.source = Me.smetafinarray

            'PASO 2: Recorre los campos para asignarle valores en el HTML
            oxmlarreglos = oxmlmain.getPrimerNodo("arreglos")
            carreglos = oxmlarreglos.getNodo("arreglo")
            For Each oxmlarreglo As Nodo In carreglos
                Dim idxstart As Integer
                Dim idxend As Integer
                Dim srow As String
                Dim scodeini As String
                Dim scodefin As String

                'PASO 2.1: Inicializa el metacodigo para el este en particular
                ometaini.SetXML(oxmlarreglo.GetXML())
                scodeini = ometaini.Interpreta()
                ometafin.SetXML(oxmlarreglo.GetXML())
                scodefin = ometafin.Interpreta()

                'PASO 2.1: Sustituye cada campo del arreglo
                oxmlcampos = oxmlmain.getPrimerNodo("arrcampos")
                ccampos = oxmlcampos.getNodo("campo")
                For Each oxmlcampo As Nodo In ccampos
                    'If Not oxmlcampo.getValue("campo.tpcampo").Equals("000007") Then
                    ohtml.setTagCode(ohtml.content, oxmlcampo, Me.generaCodigoxCampo(oxmlcampo))
                    'End If
                Next

                'PASO 2.2: Identifica el segmento donde se coloca el arreglo
                idxstart = ohtml.getStartOfTagbyid(ohtml.content, oxmlarreglo.getValue("nbidhtml"))
                idxend = outil.getLastPosNextString(ohtml.content, "</tr>", idxstart)
                srow = ohtml.content.Substring(idxstart, idxend - idxstart)
                ohtml.content = outil.ReplaceString(ohtml.content, idxstart, idxend, scodeini & srow & scodefin)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Html2CGI.generaScriptInsideHTMLArreglos()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Html2CGI.generaScriptInsideHTMLArreglos()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para validar el archivo xml de configuración del lenguaje
    ''' </summary>
    ''' <remarks></remarks>
    Private Function Carga_Configuracion() As String
        Dim oconfig As ConfigXML
        Dim oxmlextras As Nodo
        Dim oxmls, oxml As Nodo
        Dim cextras As Collection
        Dim svalida As String = ""

        Try
            'PASO 1: Inicializa
            oconfig = New ConfigXML(ozipconfig)
            oxmlCGI = oconfig.getUnEstiloProgramacion(Me.estilo)
            oxmlProcesa = oconfig.getUnaFuncion(Me.estilo, Me.procesador)

            'PASO 2: Valida los codigos
            oxmls = oxmlProcesa.getPrimerNodo("codigos")

            'PASO 2.1: Valida el encabezado CGI
            oxml = oxmls.BuscarPrimero("codigo", "nombre", "encabezado-cgi")
            If oxml Is Nothing Then
                svalida = svalida & " [ ] No esta configurado el codigo para el encabezado cgi " & vbCr
            Else
                sfileheader = oxml.getValue("codigo.archivo")
                If Not ozipconfig.ExisteArchivo(oxmlCGI.getValue("estilo.directorio") & sfileheader) Then
                    svalida = svalida & " [ ] No existe el archivo [" & oxmlCGI.getValue("estilo.directorio") & sfileheader & "] de meta-lenguaje para el encabezado cgi " & vbCr
                Else
                    smetaheader = ozipconfig.getFileInflated(oxmlCGI.getValue("estilo.directorio") & sfileheader)
                End If
            End If

            'PASO 2.2: Valida el pie de pagina del cgi
            oxml = oxmls.BuscarPrimero("codigo", "nombre", "piepagina-cgi")
            If oxml Is Nothing Then
                svalida = svalida & " [ ] No esta configurado el codigo para el pié de página cgi " & vbCr
            Else
                sfilefooter = oxml.getValue("codigo.archivo")
                If Not ozipconfig.ExisteArchivo(oxmlCGI.getValue("estilo.directorio") & sfilefooter) Then
                    svalida = svalida & " [ ] No existe el archivo [" & oxmlCGI.getValue("estilo.directorio") & sfilefooter & "] de meta-lenguaje para el pié de página cgi " & vbCr
                Else
                    smetafooter = ozipconfig.getFileInflated(oxmlCGI.getValue("estilo.directorio") & sfilefooter)
                End If
            End If

            'PASO 2.3: Valida el codigo inmerso en html
            oxml = oxmls.BuscarPrimero("codigo", "nombre", "inmerso-en-html")
            If oxml Is Nothing Then
                svalida = svalida & " [ ] No esta configurado el codigo para el código inmerso en html " & vbCr
            Else
                sfileinmersohtml = oxml.getValue("codigo.archivo")
                If Not ozipconfig.ExisteArchivo(oxmlCGI.getValue("estilo.directorio") & sfileinmersohtml) Then
                    svalida = svalida & " [ ] No existe el archivo [" & oxmlCGI.getValue("estilo.directorio") & sfileinmersohtml & "] de meta-lenguaje para el código inmerso en html " & vbCr
                Else
                    smetainmersohtml = ozipconfig.getFileInflated(oxmlCGI.getValue("estilo.directorio") & sfileinmersohtml)
                End If
            End If

            'PASO 2.4: Valida el codigo de inicio del array en html
            oxml = oxmls.BuscarPrimero("codigo", "nombre", "inicio-array-html")
            If oxml Is Nothing Then
                svalida = svalida & " [ ] No esta configurado el codigo para el inicio del array en cgi " & vbCr
            Else
                sfileiniarray = oxml.getValue("codigo.archivo")
                If Not ozipconfig.ExisteArchivo(oxmlCGI.getValue("estilo.directorio") & sfileiniarray) Then
                    svalida = svalida & " [ ] No existe el archivo [" & oxmlCGI.getValue("estilo.directorio") & sfileiniarray & "] de meta-lenguaje para el inicio del array en cgi " & vbCr
                Else
                    smetainiarray = ozipconfig.getFileInflated(oxmlCGI.getValue("estilo.directorio") & sfileiniarray)
                End If
            End If

            'PASO 2.5: Valida el codigo de fin del array en html
            oxml = oxmls.BuscarPrimero("codigo", "nombre", "fin-array-html")
            If oxml Is Nothing Then
                svalida = svalida & " [ ] No esta configurado el codigo para el fin del array en cgi " & vbCr
            Else
                sfilefinarray = oxml.getValue("codigo.archivo")
                If Not ozipconfig.ExisteArchivo(oxmlCGI.getValue("estilo.directorio") & sfilefinarray) Then
                    svalida = svalida & " [ ] No existe el archivo [" & oxmlCGI.getValue("estilo.directorio") & sfilefinarray & "] de meta-lenguaje para el fin del array en cgi " & vbCr
                Else
                    smetafinarray = ozipconfig.getFileInflated(oxmlCGI.getValue("estilo.directorio") & sfilefinarray)
                End If
            End If

            'PASO 2: Valida los extras
            oxmlextras = oxmlProcesa.getPrimerNodo("extras")
            cextras = oxmlextras.getNodo("extra")

            For Each onodo As Nodo In cextras
                If onodo.getValue("extra.archivo").Equals("") Then
                    svalida = svalida & " [ ] No esta configurado el archivo de codigo extra para " & onodo.getValue("extra.nombre") & vbCr
                Else
                    If Not ozipconfig.ExisteArchivo(oxmlCGI.getValue("estilo.directorio") & onodo.getValue("extra.archivo")) Then
                        svalida = svalida & " [ ] No existe el archivo [" & oxmlCGI.getValue("estilo.directorio") & onodo.getValue("extra.archivo") & "] de meta-lenguaje para " & onodo.getValue("extra.nombre") & vbCr
                    End If
                End If
            Next

            Return svalida
        Catch ex As HANYException
            ex.add("MyLIB.Html2CGI.Valida_Configuracion()", "Ocurrio un error al validar la configuración del metalenguaje")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Html2CGI.Valida_Configuracion()", "Ocurrio un error al validar la configuración del metalenguaje [" & ex1.ToString & "]")
        End Try
    End Function

End Class  'fin clase [Html2CGI]
