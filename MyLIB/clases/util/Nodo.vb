Option Explicit On

Imports System.Text.RegularExpressions

''' <summary>
''' Clase que tiene el objetivo de hacer un parse a un string tipo nodo
''' </summary>
''' <remarks></remarks>
Public Class Nodo
    Private sxml As String  'codigo en xml de todo lo que tiene la definición
    Private outil As Utilerias  'utilerias del sistema

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        outil = New Utilerias
        sxml = ""
    End Sub

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New(ByVal psxml As String)
        outil = New Utilerias
        sxml = psxml
    End Sub

    ''' <summary>
    ''' Procedimiento para consultar el primer nodo
    ''' </summary>
    ''' <param name="snodo">nombre del nodo</param>
    ''' <returns>XMLNodo</returns>
    ''' <remarks></remarks>
    Public Function getPrimerNodo(ByVal snodo As String) As Nodo
        Dim onodos As Collection
        Dim onodo As Nodo = Me
        Dim sxml As String = Me.sxml

        Try
            onodos = outil.CAparta_Tokens(snodo, ".")
            For Each snom As String In onodos
                sxml = outil.getStrBetweenInclude(sxml, "<" & snom & ">", "</" & snom & ">")
            Next
            If sxml = "" Then Return Nothing
        Catch ex As HANYException
            ex.add("MyLIB.Nodo.getPrimerNodo()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Nodo.getPrimerNodo()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
        Return New Nodo(sxml)
    End Function

    ''' <summary>
    ''' Procedimiento para recuperar el valor de una propiedad en particular
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getValue() As String
        Dim o_Matches As MatchCollection
        Dim o_Match As Match
        Dim o_RegExp As Regex = New Regex("<(?<nodo>\w+)>")
        Dim snodo As String

        Try
            o_Matches = o_RegExp.Matches(Me.sxml)
            If o_Matches.Count = 0 Then Return ""
            o_Match = o_Matches.Item(0)
            snodo = o_Match.Groups("nodo").Value
            Return outil.getStrBetween(Me.sxml, "<" & snodo & ">", "</" & snodo & ">")
        Catch ex As HANYException
            ex.add("MyLIB.Nodo.getValue()", "Ocurrio un error")
            Throw ex
        Catch ex As Exception
            Throw New HANYException("MyLIB.Nodo.getValue()", "Ocurrio un error [" & ex.ToString & "]")
        End Try

    End Function

    ''' <summary>
    ''' Función para identificar la existencia de nodos
    ''' </summary>
    ''' <param name="snombre">nombre del nodo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ExistNodo(ByVal snombre As String) As Boolean
        Dim onodos As Collection = outil.CAparta_Tokens(snombre, ".")
        Dim onodo As Nodo = Me

        Try
            For Each snom As String In onodos
                onodo = onodo.getPrimerNodo(snom)
                If Not onodo Is Nothing Then Return True
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Nodo.ExistNodo()", "Ocurrio un error ")
            Throw ex
        Catch ex As Exception
            Throw New HANYException("MyLIB.Nodo.ExistNodo()", "Ocurrio un error [" & ex.ToString & "]")
        End Try

        Return False
    End Function

    ''' <summary>
    ''' Procedimiento para traer directamente el valor de una propiedad
    ''' </summary>
    ''' <param name="snombre">nombre de la propiedad</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function getValue(ByVal snombre As String) As String
        Dim onodos As Collection
        Dim onodo As Nodo = Me
        Dim o_RegExp As Regex
        Dim o_Matches As MatchCollection
        Dim o_Match As Match

        Try

            o_RegExp = New Regex("=(?<name>\w+|\w+\.\w+|\w+\.\w+\.\w+|\w+\.\w+\.\w+.\w+)$")
            o_Matches = o_RegExp.Matches(snombre)

            If o_Matches.Count > 0 Then
                o_Match = o_Matches.Item(0)
                onodos = outil.CAparta_Tokens(o_Match.Groups("name").Value, ".")
                For Each snom As String In onodos
                    onodo = onodo.getPrimerNodo(snom)
                    If onodo Is Nothing Then Return ""
                Next
                Return onodo.getValue()
            End If

            'PASO 2: Resuelve todo aquello que se trate de una sustitución que pasa por función
            o_RegExp = New Regex("=(?<funcion>\w+)\((?<name>\w+|\w+\.\w+|\w+\.\w+\.\w+|\w+\.\w+\.\w+.\w+)(?<par1>,\w+)?(?<par2>,\w+)?\)$")
            o_Matches = o_RegExp.Matches(snombre)
            If o_Matches.Count > 0 Then
                Dim sfuncion As String
                Dim svalor As String
                Dim spar1 As String
                Dim spar2 As String
                o_Match = o_Matches.Item(0)
                sfuncion = o_Match.Groups("funcion").Value.ToLower
                svalor = Me.getValue(o_Match.Groups("name").Value).Trim
                If svalor.Equals("") Then svalor = Me.getValue(o_Match.Groups("name").Value).Trim()
                Select Case sfuncion
                    Case "aminuscula"
                        svalor = svalor.ToLower
                    Case "amayuscula"
                        svalor = svalor.ToUpper
                    Case "trim"
                        svalor = svalor.Trim
                    Case "length"
                        svalor = svalor.Length
                    Case "substring"            'lo necesito para java
                        spar1 = o_Match.Groups("par1").Value
                        spar2 = o_Match.Groups("par2").Value
                        If spar1.Equals("") And spar2.Equals("") Then
                            svalor = "ERROR DE FUNCION"
                            Exit Select
                        End If
                        If spar2.Equals("") Then
                            svalor = svalor.Substring(spar1.Substring(1))
                        Else
                            svalor = svalor.Substring(spar1.Substring(1), spar2.Substring(1))
                        End If
                End Select
                If svalor.Equals("") Then
                    Throw New HANYException("MyLIB.Nodo.getValue(2)", "No se encontro un valor para la propiedad [" & snombre & "]")
                End If
                Return svalor
            End If

            onodos = outil.CAparta_Tokens(snombre, ".")
            For Each snom As String In onodos
                onodo = onodo.getPrimerNodo(snom)
                If onodo Is Nothing Then Return ""
            Next

        Catch ex As HANYException
            ex.add("MyLIB.Nodo.getValue(nb)", "Ocurrio un error ")
            Throw ex
        Catch ex As Exception
            Throw New HANYException("MyLIB.Nodo.getValue(nb)", "Ocurrio un error [" & ex.ToString & "]")
        End Try

        Return onodo.getValue()
    End Function

    ''' <summary>
    ''' Procedimiento para contabilizar el número de nodos encontrados
    ''' </summary>
    ''' <param name="snodo">nombre del nodo</param>
    ''' <returns>Integer</returns>
    ''' <remarks></remarks>
    Public Function getCount(ByVal snodo As String) As Integer
        Dim idx As Integer = sxml.IndexOf("<" & snodo & ">", 0)
        Dim icount As Integer = 0

        Try
            Do While idx > 0
                icount = icount + 1
                idx = sxml.IndexOf("<" & snodo & ">", idx + 1)
            Loop
        Catch ex As HANYException
            ex.add("MyLIB.Nodo.getCount(nb)", "Ocurrio un error ")
            Throw ex
        Catch ex As Exception
            Throw New HANYException("MyLIB.Nodo.getCount(nb)", "Ocurrio un error [" & ex.ToString & "]")
        End Try
        Return icount
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un nodo en particular, pero que te regresa una 
    ''' colección de nodos
    ''' </summary>
    ''' <param name="snodo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getNodo(ByVal snodo As String) As Collection
        Dim sfin As String = "</" & snodo & ">"
        Dim ocol As Collection = New Collection
        Dim idx As Integer = sxml.IndexOf("<" & snodo & ">", 0)
        Dim ifin As Integer = 0

        Try
            Do While idx > 0
                Dim onodo As Nodo
                ifin = sxml.IndexOf(sfin, idx)
                onodo = New Nodo(sxml.Substring(idx, (ifin - idx) + sfin.Length()))
                ocol.Add(onodo)
                idx = sxml.IndexOf("<" & snodo & ">", ifin)
            Loop

        Catch ex As HANYException
            ex.add("MyLIB.Nodo.getNodo(nb)", "Ocurrio un error ")
            Throw ex
        Catch ex As Exception
            Throw New HANYException("MyLIB.Nodo.getNodo(nb)", "Ocurrio un error [" & ex.ToString & "]")
        End Try

        Return ocol
    End Function

    ''' <summary>
    ''' Procedimiento para consultar los nodos raiz de un xml
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getNombreRaiz() As String
        Dim o_Matches As MatchCollection
        Dim o_Match As Match
        Dim o_RegExp As Regex = New Regex("<(?<nodo>\w+)>")

        Try
            o_Matches = o_RegExp.Matches(Me.sxml)
            If o_Matches.Count = 0 Then Return Nothing
            o_Match = o_Matches.Item(0)
            Return o_Match.Groups("nodo").Value

        Catch ex As HANYException
            ex.add("MyLIB.Nodo.getNombreRaiz()", "Ocurrio un error ")
            Throw ex
        Catch ex As Exception
            Throw New HANYException("MyLIB.Nodo.getNombreRaiz()", "Ocurrio un error [" & ex.ToString & "]")
        End Try

    End Function

    ''' <summary>
    ''' Procedimiento para consultar los nodos de ...
    ''' </summary>
    ''' <param name="snodo">nombre del nodo</param>
    ''' <returns>Colección de nodos</returns>
    ''' <remarks></remarks>
    Public Function getNodosDe(ByVal snodo As String) As Collection
        Dim ocol As Collection
        Dim o_Matches As MatchCollection
        Dim o_RegExp As Regex
        Dim onodo As Nodo
        Dim sxml As String

        Try
            'PASO 1: Inicializa los valores...
            ocol = New Collection
            onodo = Me.getPrimerNodo(snodo)
            sxml = onodo.sxml
            o_RegExp = New Regex("<(?<nodo>\w+)>")
            o_Matches = o_RegExp.Matches(onodo.sxml)
            If o_Matches.Count = 0 Then Return ocol

            Do
                ocol.Add(onodo.getPrimerNodo("a"))

            Loop

        Catch ex As HANYException
            ex.add("MyLIB.Nodo.getNodosDe()", "Ocurrio un error ")
            Throw ex
        Catch ex As Exception
            Throw New HANYException("MyLIB.Nodo.getNodosDe()", "Ocurrio un error [" & ex.ToString & "]")
        End Try

        Return ocol
    End Function

    ''' <summary>
    ''' Procedimiento para comparar el valor de un nodo, a un valor en particular
    ''' </summary>
    ''' <param name="snodo">Nombre del Nodo</param>
    ''' <param name="svalor">Valor</param>
    ''' <returns>true/false</returns>
    ''' <remarks></remarks>
    Public Function isValorIgualA(ByVal snodo As String, ByVal svalor As String) As Boolean
        Dim snodoval As String
        Try
            snodoval = Me.getValue(snodo)
            If snodoval.Equals(svalor) Then Return True
        Catch ex As Exception
            Throw New HANYException("MyLIB.Nodo.isValorIgualA()", "Ocurrio un error [" & ex.ToString & "]")
        End Try
        Return False
    End Function

    ''' <summary>
    ''' Procedimiento para comparar el valor de un nodo, a un valor en particular
    ''' </summary>
    ''' <param name="snodo">Nombre del Nodo</param>
    ''' <param name="svalor">Valor</param>
    ''' <returns>true/false</returns>
    ''' <remarks></remarks>
    Public Function isValorDiferenteA(ByVal snodo As String, ByVal svalor As String) As Boolean
        Dim snodoval As String
        Try
            snodoval = Me.getValue(snodo)
            If Not snodoval.Equals(svalor) Then Return True
        Catch ex As Exception
            Throw New HANYException("MyLIB.Nodo.isValorDiferenteA()", "Ocurrio un error [" & ex.ToString & "]")
        End Try
        Return False
    End Function

    ''' <summary>
    ''' Procedimiento para buscar en una coleccion de nodos, que alguno de ellos tenga un valor en particular
    ''' y lo regresa
    ''' </summary>
    ''' <param name="snodo">coleccion de nodos a buscar</param>
    ''' <param name="spropiedad">propiedad</param>
    ''' <param name="svalor">valor de la propiedad</param>
    ''' <returns>Nodo</returns>
    ''' <remarks></remarks>
    Public Function BuscarPrimero(ByVal snodo As String, ByVal spropiedad As String, ByVal svalor As String) As Nodo
        Dim ocol As Collection
        Try
            ocol = Me.getNodo(snodo)
            For Each onodo As Nodo In ocol
                If onodo.isValorIgualA(spropiedad, svalor) Then Return onodo
            Next
        Catch ex As Exception
            Throw New HANYException("MyLIB.Nodo.BuscarPrimero()", "Ocurrio un error [" & ex.ToString & "]")
        End Try
        Return Nothing
    End Function

    ''' <summary>
    ''' Procedimiento para buscar en una coleccion de nodos, que algunos de ellos tenga un valor en particular
    ''' y los regresa
    ''' </summary>
    ''' <param name="snodo">coleccion de nodos a buscar</param>
    ''' <param name="spropiedad">propiedad</param>
    ''' <param name="svalor">valor de la propiedad</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function Buscar(ByVal snodo As String, ByVal spropiedad As String, ByVal svalor As String) As Collection
        Dim ocol As Collection
        Dim ores As Collection = New Collection
        Try
            ocol = Me.getNodo(snodo)
            For Each onodo As Nodo In ocol
                If onodo.isValorIgualA(spropiedad, svalor) Then ores.Add(onodo)
            Next
        Catch ex As Exception
            Throw New HANYException("MyLIB.Nodo.Buscar()", "Ocurrio un error [" & ex.ToString & "]")
        End Try

        Return ores
    End Function

    ''' <summary>
    ''' Procedimiento para buscar en una coleccion de nodos, que algunos de ellos tenga un valor en particular
    ''' y los regresa
    ''' </summary>
    ''' <param name="snodo">coleccion de nodos a buscar</param>
    ''' <param name="spropiedad">propiedad</param>
    ''' <param name="svalor">valor de la propiedad</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function BuscarDiferente(ByVal snodo As String, ByVal spropiedad As String, ByVal svalor As String) As Collection
        Dim ocol As Collection
        Dim ores As Collection = New Collection
        Try
            ocol = Me.getNodo(snodo)
            For Each onodo As Nodo In ocol
                If onodo.isValorDiferenteA(spropiedad, svalor) Then ores.Add(onodo)
            Next
        Catch ex As Exception
            Throw New HANYException("MyLIB.Nodo.BuscarDiferente()", "Ocurrio un error [" & ex.ToString & "]")
        End Try

        Return ores
    End Function

    ''' <summary>
    ''' Procedimiento para agregar un nodo dentro de otro a partir de la propiedad snodo
    ''' </summary>
    ''' <param name="snodo"></param>
    ''' <param name="onodo"></param>
    ''' <remarks></remarks>
    Public Sub addNodoEn(ByVal snodo As String, ByVal onodo As Nodo)
        Try
            Me.sxml = Me.sxml.Replace("</" & snodo & ">", onodo.GetXML() & "</" & snodo & ">")
        Catch ex As Exception
            Throw New HANYException("MyLIB.Nodo.addNodoEn()", "Ocurrio un error [" & ex.ToString & "]")
        End Try

    End Sub

    ''' <summary>
    ''' Procedimiento para agregar un nuevo nodo (al final de la definición actual)
    ''' </summary>
    ''' <param name="onodo">Objeto tipo nodo</param>
    ''' <remarks></remarks>
    Public Sub addNodoNuevo(ByVal onodo As Nodo)
        Try
            Me.sxml = Me.sxml & onodo.GetXML()
        Catch ex As Exception
            Throw New HANYException("MyLIB.Nodo.addNodoNuevo()", "Ocurrio un error [" & ex.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar un nodo
    ''' </summary>
    ''' <param name="snodo">nombre del nodo</param>
    ''' <param name="onodo">nodo que estará inmerso en el valor</param>
    ''' <remarks></remarks>
    Public Sub updNodo(ByVal snodo As String, ByVal onodo As Nodo)
        Dim iini As Integer
        Dim ifin As Integer

        Try
            'PASO 1: Inicializa los valores
            iini = sxml.IndexOf("<" & snodo & ">")
            ifin = sxml.IndexOf("</" & snodo & ">", iini)

            'PASO 2: Remplaza las cadenas
            If ifin < 0 Then Return
            sxml = outil.ReplaceString(sxml, iini + New String("<" & snodo & ">").Length, (ifin - (iini + New String("<" & snodo & ">").Length)), onodo.GetXML())
        Catch ex As Exception
            Throw New HANYException("MyLIB.Nodo.updNodo()", "Ocurrio un error [" & ex.ToString & "]")
        End Try

    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar un nodo en particular
    ''' </summary>
    ''' <param name="snodo">nombre del nodo</param>
    ''' <param name="svalor">valor que tendrá el nodo</param>
    ''' <remarks></remarks>
    Public Sub updNodoValor(ByVal snodo As String, ByVal svalor As String)
        Dim stmp As String
        Dim iini As Integer
        Dim ifin As Integer

        Try
            iini = sxml.IndexOf("<" & snodo & ">")
            ifin = sxml.IndexOf("</" & snodo & ">", iini)
            If ifin < 0 Then Return
            stmp = outil.ReplaceString(sxml, iini + New String("<" & snodo & ">").Length, ifin, svalor)
            sxml = stmp
        Catch ex As Exception
            Throw New HANYException("MyLIB.Nodo.updNodoValor()", "Ocurrio un error [" & ex.ToString & "]")
        End Try

    End Sub

    ''' <summary>
    ''' Procedimiento para asignar un valor xml 
    ''' </summary>
    ''' <param name="sxml"></param>
    ''' <remarks></remarks>
    Public Sub SetXML(ByVal sxml As String)
        If sxml Is Nothing Then
            sxml = ""
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

End Class  'fin clase [Nodo]
