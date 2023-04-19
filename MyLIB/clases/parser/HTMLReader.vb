Imports System.Text.RegularExpressions
Imports System.IO
Imports mshtml

''' <summary>
''' Clase que tiene las propiedades y metodos de un HTML
''' </summary>
''' <remarks></remarks>
Public Class HTMLReader
    Private sarchivo As String = ""     'Nombre del archivo
    Private scontent As String = ""     'Contenido del archivo
    Private outil As Utilerias
    Dim ohtml As IHTMLDocument2

    'CONSTRUCTOR
    Public Sub New()
        outil = New Utilerias
        ohtml = New HTMLDocumentClass()
    End Sub

    ''' <summary>
    ''' PROPIEDAD: Nombre del archivo
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property archivo() As String
        Get
            Return sarchivo
        End Get
        Set(ByVal psval As String)
            sarchivo = psval.Trim
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Contenido del archivo
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property content() As String
        Get
            Return scontent
        End Get
        Set(ByVal psval As String)
            scontent = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' Función para buscar la primer ocurrencia de un TAG por su Id
    ''' </summary>
    ''' <param name="scontenido">Contenido donde se busca</param>
    ''' <param name="sid">Id que se desea buscar</param>
    ''' <returns>Integer</returns>
    ''' <remarks></remarks>
    Public Function getStartOfTagbyid(ByRef scontenido As String, ByVal sid As String) As Integer
        Dim o_RegExp As Regex
        Dim o_Matches As MatchCollection
        Dim ipos As Integer = 0
        Dim car As Char = ""

        Try
            'PASO 1: Busca el match del id
            o_RegExp = New Regex("id\s*=\s*\""" & sid & "\""")
            o_Matches = o_RegExp.Matches(scontenido)
            If o_Matches.Count <> 1 Then Return -1
            ipos = o_Matches.Item(0).Index

            'PASO 2: Regresa un caracter hasta encontrar <
            While True
                car = scontenido.Substring(ipos, 1)
                If car = "<" Then Exit While
                ipos = ipos - 1
            End While
        Catch ex As HANYException
            ex.add("MyLIB.HTMLReader.indexOfTagbyid()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.HTMLReader.indexOfTagbyid()()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
        Return ipos
    End Function


    ''' <summary>
    ''' Procedimiento para consultar todos los valores actuales de un tag
    ''' </summary>
    ''' <param name="scontenido">contenido de donde se extraen</param>
    ''' <param name="oxmlcampo">información del campo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getTagCurrentValues(ByRef scontenido As String, ByRef oxmlcampo As Nodo) As Nodo
        Dim idxini As Integer
        Dim idxfin As Integer
        Dim stag As String
        Dim svalor As String
        Dim o_RegExp As Regex
        Dim o_Matches As MatchCollection
        Dim o_Match As Match
        Dim stagtype As String
        Dim oxmlResult As Nodo

        Try
            'PASO 1: Inicializa los valores
            oxmlResult = New Nodo()
            idxini = getStartOfTagbyid(scontenido, oxmlcampo.getValue("campo.html.idhtml"))
            o_RegExp = New Regex("\<\s*(?<tipo>\w+)\s")

            'PASO 2: Se identifica el tipo de TAG próximo inmediato posterior
            idxfin = scontenido.IndexOf(">", idxini) + 1
            If idxfin < 0 Then
                Dim ex As HANYException = New HANYException
                ex.add("MyLIB.HTMLReader.getTagCurrentValues()", "MAL FORMADO TAG SELECT HTML [" & oxmlcampo.getValue("campo.html.idhtml") & "] EN ARCHIVO [" & sarchivo & "]")
                Throw ex
            End If
            stag = scontenido.Substring(idxini, idxfin - idxini)
            o_Matches = o_RegExp.Matches(stag)
            o_Match = o_Matches.Item(0)
            stagtype = o_Match.Groups("tipo").Value.ToLower

            'PASO 3: Dependiendo del tipo de tag, se procede a la inclusión de código
            Select Case stagtype
                Case "p"
                Case "input"
                    o_RegExp = New Regex("value\s*=\s*\""(?<valor>\w+)\""")
                    o_Matches = o_RegExp.Matches(scontenido)
                    If o_Matches.Count > 0 Then
                        o_Match = o_Matches.Item(0)
                        svalor = o_Match.Groups("valor").Value
                        If svalor Is Nothing Then svalor = ""
                        If svalor.Equals("") Then svalor = "VALOR"
                        oxmlcampo.addNodoEn("html", New Nodo("<currvalue>" & svalor & "</currvalue>"))
                    End If
                Case "textarea"
                Case "select"
            End Select

        Catch ex As HANYException
            ex.add("MyLIB.HTMLReader.getTagCurrentValues()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.HTMLReader.getTagCurrentValues()()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
        Return oxmlResult
    End Function

    ''' <summary>
    ''' Procedimiento para definir el código que le corresponde a un Tag en particular
    ''' </summary>
    ''' <param name="scontenido">Contenido donde se sustituye el valor</param>
    ''' <param name="oxmlcampo">XML con la definición del campo</param>
    ''' <param name="scode">Codigo a integrar</param>
    ''' <returns>True-False</returns>
    ''' <remarks></remarks>
    Public Function setTagCode(ByRef scontenido As String, ByVal oxmlcampo As Nodo, ByVal scode As String) As Boolean
        Dim idxini As Integer
        Dim idxfin As Integer
        Dim stag As String
        Dim sresult As String
        Dim o_RegExp As Regex
        Dim o_Matches As MatchCollection
        Dim o_Match As Match
        Dim stagtype As String

        Try
            'PASO 1: Inicializa los valores
            idxini = getStartOfTagbyid(scontenido, oxmlcampo.getValue("campo.html.idhtml"))
            If idxini < 0 Then Exit Function
            o_RegExp = New Regex("\<\s*(?<tipo>\w+)\s")

            'PASO 2: Se identifica el tipo de TAG próximo inmediato posterior
            idxfin = scontenido.IndexOf(">", idxini) + 1
            If idxfin < 0 Then
                Dim ex As HANYException = New HANYException
                ex.add("MyLIB.HTMLReader.setTagCode()", "MAL FORMADO TAG SELECT HTML [" & oxmlcampo.getValue("campo.html.idhtml") & "] EN ARCHIVO [" & sarchivo & "]")
                Throw ex
            End If
            stag = scontenido.Substring(idxini, idxfin - idxini)
            o_Matches = o_RegExp.Matches(stag)
            o_Match = o_Matches.Item(0)
            stagtype = o_Match.Groups("tipo").Value.ToLower

            'PASO 3: Dependiendo del tipo de tag, se procede a la inclusión de código
            Select Case stagtype
                Case "p"
                    Dim ifinfin As Integer

                    ifinfin = Me.content.IndexOf("</p>", idxini)
                    scontenido = outil.ReplaceString(scontenido, idxfin, ifinfin, scode)

                Case "input"

                    'Sustituye el atributo con el valor del input() type=text
                    If oxmlcampo.getValue("campo.html.tphtml").Equals("text") Then
                        sresult = Me.Sustituye_Atributo(stag, "value", scode)
                        If sresult.Equals("") Then Return False
                        'scontenido = outil.ReplaceString(scontenido, idxini, idxfin, sresult)

                        'Sustituye el atributo con el valor del length()
                        Dim ilong As Integer
                        Dim idecimales As Integer
                        ilong = oxmlcampo.getValue("campo.nulongitud")
                        idecimales = oxmlcampo.getValue("campo.nudecimales")
                        sresult = Me.Sustituye_Atributo(sresult, "maxlength", ilong + IIf(idecimales > 0, idecimales + 1, 0))
                        If sresult.Equals("") Then Return False
                        scontenido = outil.ReplaceString(scontenido, idxini, idxfin, sresult)
                    End If

                    If oxmlcampo.getValue("campo.html.tphtml").Equals("checkbox") Then
                        sresult = stag.Substring(0, stag.Length - 1) & scode & ">"
                        scontenido = outil.ReplaceString(scontenido, idxini, idxfin, sresult)
                    End If
                    If oxmlcampo.getValue("campo.html.tphtml").Equals("radio") Then
                        sresult = stag.Substring(0, stag.Length - 1) & scode & ">"
                        scontenido = outil.ReplaceString(scontenido, idxini, idxfin, sresult)
                    End If

                Case "textarea"
                    Dim ifinfin As Integer
                    Dim idxiniline As Integer

                    'PASO 1: Encuentro el inicio de la línea
                    For idxiniline = idxini To 0 Step -1
                        If scontenido(idxiniline) = Chr(13) Then Exit For
                    Next

                    'PASO 2: Contabilizo los espacios que hay
                    scode = Me.IdentarConEspacios(scode, (idxini - idxiniline) - 2)

                    ifinfin = scontenido.IndexOf("</textarea>", idxini)
                    If ifinfin < 0 Then
                        Dim ex As HANYException = New HANYException
                        ex.add("MyLIB.HTMLReader.setTagCode()", "MAL FORMADO TAG TEXTAREA HTML [" & oxmlcampo.getValue("campo.html.idhtml") & "] EN ARCHIVO [" & sarchivo & "]")
                        Throw ex
                    End If
                    scontenido = outil.ReplaceString(Me.content, idxfin, ifinfin, scode)

                Case "select"
                    Dim ifinfin As Integer
                    Dim idxiniline As Integer

                    'PASO 1: Encuentro el inicio de la línea
                    For idxiniline = idxini To 0 Step -1
                        If scontenido(idxiniline) = Chr(13) Then Exit For
                    Next

                    'PASO 2: Contabilizo los espacios que hay
                    scode = Me.IdentarConEspacios(scode, (idxini - idxiniline) - 2)

                    ifinfin = scontenido.IndexOf("</select>", idxini)
                    If ifinfin < 0 Then
                        Dim ex As HANYException = New HANYException
                        ex.add("MyLIB.HTMLReader.setTagCode()", "MAL FORMADO TAG SELECT HTML [" & oxmlcampo.getValue("campo.html.idhtml") & "] EN ARCHIVO [" & sarchivo & "]")
                        Throw ex
                    End If
                    scontenido = outil.ReplaceString(Me.content, idxfin, ifinfin, scode)
            End Select

        Catch ex As HANYException
            ex.add("MyLIB.HTMLReader.setTagCode()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.HTMLReader.setTagCode()()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
        Return True
    End Function

    ''' <summary>
    ''' Función para insertar espacios (al principio) de cada renglón
    ''' </summary>
    ''' <param name="scode">codigo</param>
    ''' <param name="iposiciones">posiciones para agregar</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Private Function IdentarConEspacios(ByVal scode As String, ByVal iposiciones As Integer) As String
        Dim alineas() As String = Nothing
        Dim ilineas As Integer
        Dim ilinea As Integer
        Dim slinea As String
        Dim sresult As String

        Try
            'PASO 1: Inicializa valores
            ilineas = Aparta_Tokens(scode, alineas, Chr(13) + Chr(10))
            sresult = ""
            If ilineas = 0 Then Return scode

            'PASO 2: Recorre las lineas
            For ilinea = 1 To ilineas
                slinea = New String(" ", iposiciones) & alineas(ilinea)
                sresult = sresult & slinea & IIf(ilinea < ilineas, vbCrLf, "")
            Next

        Catch ex As HANYException
            ex.add("MyLIB.HTMLReader.IdentarConEspacios()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.HTMLReader.IdentarConEspacios()()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

        'PASO 3: Termina
        Return sresult
    End Function

    ''' <summary>
    ''' Función para sustituir un atributo del tag actual
    ''' </summary>
    ''' <param name="stag">instrucción completa del tag</param>
    ''' <param name="satributo">nombre del atributo</param>
    ''' <param name="svalor">valor del atributo</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Private Function Sustituye_Atributo(ByVal stag As String, ByVal satributo As String, ByVal svalor As String) As String
        Dim idxini As Integer
        Dim idxfin As Integer
        Dim o_RegExp As Regex
        Dim o_Matches As MatchCollection
        Dim sresult As String

        Try
            o_RegExp = New Regex(satributo & "\s*=\s*""")
            o_Matches = o_RegExp.Matches(stag)
            If o_Matches.Count > 0 Then
                idxini = o_Matches.Item(0).Index
                idxfin = stag.IndexOf("""", (idxini + o_Matches.Item(0).Value.Length)) + 1
                sresult = outil.ReplaceString(stag, idxini, idxfin, " " & satributo & "=""" & svalor & """")
            Else
                sresult = stag.Substring(0, stag.Length() - 1) & " " & satributo & "" & svalor & """>"
            End If
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.HTMLReader.Sustituye_Atributo()()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

        Return sresult
    End Function

    ''' <summary>
    ''' Función para sustituir todo el codigo que existe entre 2 tags
    ''' </summary>
    ''' <param name="stagini">tag inicial</param>
    ''' <param name="stagfin">tag final</param>
    ''' <param name="svalor">valor del tag</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Private Function Sustituye_InnerCode(ByVal idxini As Integer, ByVal stagini As String, ByVal stagfin As String, ByVal svalor As String) As Boolean


        Return True
    End Function

    ''' <summary>
    ''' Procedimiento para cargar el contenido de un archivo
    ''' </summary>
    ''' <param name="sfile">nombre del archivo</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Function Carga(ByVal sfile As String) As Boolean
        Dim o_RegExp As Regex
        Dim o_Matches As MatchCollection
        Dim oread As System.IO.StreamReader

        Try
            'PASO 1: Inicializa+
            sarchivo = sfile
            o_RegExp = New Regex("\w+\.(html|htm)")
            o_Matches = o_RegExp.Matches(scontent)

            'PASO 2: lee el archivo
            Try
                oread = New StreamReader(sfile, System.Text.Encoding.GetEncoding(28593))      'Abre el archivo   
                scontent = oread.ReadToEnd.ToString
                ohtml.write(scontent)
                oread.Close()
            Catch e As Exception
                Return False
            End Try
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.HTMLReader.Carga()()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

        Return True
    End Function

    ''' <summary>
    ''' Procedimiento para consultar la navegación del html a cualquier otra pantalla 
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function GetNavegacion() As Collection
        Dim o_RegExp As Regex
        Dim o_Matches As MatchCollection
        Dim o_Match As Match
        Dim ccol As Collection

        Try
            'PASO 1: inicializa
            o_RegExp = New Regex("\w+\.(html|htm)")
            o_Matches = o_RegExp.Matches(scontent)
            ccol = New Collection

            'PASO 2: recorre los match
            For Each o_Match In o_Matches
                ccol.Add(o_Match.Value)
            Next

            'PASO 3: Inserta también el nombre
            o_Matches = o_RegExp.Matches(sarchivo)
            ccol.Add(o_Matches.Item(0).Value)

        Catch ex1 As Exception
            Throw New HANYException("MyLIB.HTMLReader.GetNavegacion()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

        'PASO 4: Termina
        Return ccol
    End Function

    ''' <summary>
    ''' Procedimiento para consultar todos los tags de un archivo HTML
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function GetallTags() As Collection
        Dim ctags As Collection
        Dim allElements As IHTMLElementCollection

        Try
            'PASO 1: Inicializa
            ctags = New Collection
            allElements = ohtml.body.all

            'PASO 2: Recorre los tags
            For Each ohtmltag As IHTMLElement In allElements
                Dim otag As HTMLTag = New HTMLTag
                otag.id = ohtmltag.id
                otag.tag = ohtmltag.tagName
                If Not IsDBNull(ohtmltag.getAttribute("name")) Then otag.nombre = ohtmltag.getAttribute("name")
                If Not IsDBNull(ohtmltag.getAttribute("type")) Then otag.tipo = ohtmltag.getAttribute("type")
                If Not IsDBNull(ohtmltag.getAttribute("value")) Then otag.valor = ohtmltag.getAttribute("value")
                If otag.tag.Equals("A") Then
                    If Not IsDBNull(ohtmltag.getAttribute("HREF")) Then otag.valor = ohtmltag.getAttribute("HREF")
                End If

                ctags.Add(otag)
            Next

        Catch ex1 As Exception
            Throw New HANYException("MyLIB.HTMLReader.GetTags()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

        'PAGO 3: Termina
        Return ctags

    End Function

    ''' <summary>
    ''' Procedimiento para consultar los tags de un archivo html
    ''' </summary>
    ''' <param name="stag">nombre del tag</param>
    ''' <param name="stipo">tipo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetTags(ByVal stag As String, ByVal stipo As String) As Collection
        Dim ctags As Collection
        Dim allElements As IHTMLElementCollection
        Dim allthistags As IHTMLElementCollection

        Try
            'PASO 1: Inicializa
            ctags = New Collection
            allElements = ohtml.body.all
            allthistags = allElements.tags(stag)

            'PASO 2: recorre los tags
            For Each ohtmltag As IHTMLElement In allthistags
                Dim otag As HTMLTag = New HTMLTag
                If Not IsDBNull(ohtmltag.getAttribute("name")) Then otag.nombre = ohtmltag.getAttribute("name")
                If Not IsDBNull(ohtmltag.getAttribute("type")) Then otag.tipo = ohtmltag.getAttribute("type")
                otag.id = ohtmltag.id
                otag.tag = stag
                If stag.ToLower.Equals("input") And otag.tipo.Equals("button") Then otag.action = ohtmltag.innerHTML
                If stag.ToLower.Equals("p") Then otag.valor = ohtmltag.innerText
                If stag.ToLower.Equals("input") Then
                    If Not IsDBNull(ohtmltag.getAttribute("value")) Then otag.valor = ohtmltag.getAttribute("value")
                End If
                If Not stipo.Equals("") Then
                    If otag.tipo.Equals(stipo.ToLower) Then ctags.Add(otag)
                Else
                    ctags.Add(otag)
                End If
            Next

        Catch ex1 As Exception
            Throw New HANYException("MyLIB.HTMLReader.GetTags()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

        'PAGO 3: Termina
        Return ctags
    End Function

    Public Function GetTags(ByVal stag As String) As Collection
        Return GetTags(stag, "")
    End Function

    ''' <summary>
    ''' Función para consultar todas aquellos identificadores de función
    ''' en javascript
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function GetJavaScriptFunctions() As Collection
        Dim cfuncs As Collection
        Dim script As String
        Dim o_RegExp As Regex
        Dim o_Matches As MatchCollection
        Dim o_Match As Match

        Try
            'PASO 1: Inicializa
            cfuncs = New Collection
            o_RegExp = New Regex("function\s+(?<name>\w+)\s*\(")

            'PASO 2: Localiza el segmento de código de javascript
            script = outil.getStrBetween(scontent, "<script", "</script>")

            'PASO 3: Realiza una busqueda de las funciones
            o_Matches = o_RegExp.Matches(script)
            For Each o_Match In o_Matches
                cfuncs.Add(o_Match.Groups("name").Value)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.HTMLReader.GetJavaScriptFunctions()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.HTMLReader.GetJavaScriptFunctions()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

        'PASO N: Termina
        Return cfuncs
    End Function

    ''' <summary>
    ''' Función para rescatar todos los tags de entrada de información
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function GetAllInputTags() As Collection
        Dim coall As Collection
        Dim cinputs As Collection

        'PASO 1: Inicializa variables
        coall = New Collection

        'PASO 2: Consulta los Text
        cinputs = Me.GetTags("input", "text")
        For Each oinput As HTMLTag In cinputs
            coall.Add(oinput)
        Next

        'PASO 3: Consulta de los TAG Input-radio...
        cinputs = Me.GetTags("input", "radio")
        For Each oinput As HTMLTag In cinputs
            coall.Add(oinput)
        Next

        'PASO 3: Consulta de los TAG Input-radio...
        cinputs = Me.GetTags("input", "checkbox")
        For Each oinput As HTMLTag In cinputs
            coall.Add(oinput)
        Next

        'PASO 3: Consulta de los TAG textarea...
        cinputs = Me.GetTags("textarea")
        For Each oinput As HTMLTag In cinputs
            coall.Add(oinput)
        Next

        'PASO 4: Consulta de los TAG Select...
        cinputs = Me.GetTags("select")
        For Each oinput As HTMLTag In cinputs
            coall.Add(oinput)
        Next

        'PASO 5: regresa todas las entradas
        Return coall
    End Function

    ''' <summary>
    ''' Función para rescatar todos los tags de salida de información
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function GetAllOutputTags() As Collection
        Dim coall As Collection
        Dim coutputs As Collection

        'PASO 1: Inicializa variables
        coall = New Collection

        'PASO 4: Consulta de los TAG P...
        coutputs = Me.GetTags("p")
        For Each output As HTMLTag In coutputs
            coall.Add(output)
        Next

        'PASO 5: regresa todas las entradas
        Return coall
    End Function

    ''' <summary>
    ''' Función para consultar la parte de un TAG de HTML
    ''' </summary>
    ''' <param name="spart">nombre de la parte</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getHTMLTagPart(ByVal stag As String, ByVal spart As String) As String
        Return ""
    End Function



End Class 'fin clase [HTMLReader]
