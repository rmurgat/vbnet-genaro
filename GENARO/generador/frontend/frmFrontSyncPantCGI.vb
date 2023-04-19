Option Explicit On

Imports MyLIB
Imports mshtml
Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmFrontSyncPantCGI
    Private obus As Catalogos
    Private scdproject As String             'Clave del proyecto
    Private scdpantalla As String            'Clave de la pantalla
    Private scdsincronia As String           'Clave de la sincronia
    Private oproject As Proyecto             'Objeto que tiene las propiedades del proyecto
    Private opantalla As Pantalla            'Objeto que tiene las propiedades de la pantalla
    Private outil As Utilerias               'Utilerias del sistema
    Private omdipa As MDIGenaro
    Private ipagina As Integer = 1
    Private cClases As Collection = New Collection     'Colección de clases
    Private cClasesUsadas As Collection = New Collection
    Private ozip As ZipArchivo = New MyLIB.ZipArchivo
    Private ohtml As HTMLReader
    Private oconfig As ConfigXML
    Private osincronia As Sincronia

    ''' <summary>
    ''' PROPIEDAD: Clave del proyecto
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdproject() As String
        Get
            Return scdproject
        End Get
        Set(ByVal pscd As String)
            scdproject = pscd
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
    ''' PROPIEDAD: Clave de la sincronia
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdsincronia() As String
        Get
            Return scdsincronia
        End Get
        Set(ByVal pscd As String)
            scdsincronia = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Colección de clases
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property Clases() As Collection
        Get
            Return cClases
        End Get
        Set(ByVal pcval As Collection)
            If pcval Is Nothing Then
                cClases = New Collection
                Exit Property
            End If
            cClases = pcval
        End Set
    End Property

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Grabar_Informacion()
        Me.Close()
    End Sub

    Private Function Identifica_Variables() As Collection
        Dim cvariables As Collection
        Dim cnavs As Collection
        Dim svariables As String
        Dim ovaropcion As Variable

        Try
            'PASO 1: Inicializa el grid de variables
            svariables = ""
            cvariables = New Collection

            'PASO 2: Crea un parámetro por default sopcion
            outil.addToListDebug(lstobjdebug, " [ Identificando variables ] ")
            ovaropcion = New Variable
            ovaropcion.nombre = "sopcion"
            ovaropcion.tipo = "_PAPOST_"
            ovaropcion.valor = "hidopcion"
            ovaropcion.comment = "Default de operación"
            cvariables.Add(ovaropcion)

            'PASO 3: Identifica las variables utilizadas en la navegación
            outil.addToListDebug(lstobjdebug, "PASO 1: Variables Usadas en navegación")
            cnavs = obus.getNavegaDesdeDestino(Me.cdproject, Me.cdpantalla)

            For Each onav As Navegacion In cnavs
                Dim cobjets As Collection = obus.getNavegacionParams(Me.cdproject, onav.cdesde, onav.cdhasta)
                For Each obj As NavegacionParam In cobjets
                    Dim svar As String = "s" & obj.nbparam.Substring(3)
                    If svariables.IndexOf(svar & ",") < 0 Then
                        Dim ovar As Variable = New Variable
                        ovar.nombre = svar
                        ovar.tipo = "_PA" & onav.tpnavegacion & "_"
                        ovar.valor = obj.nbparam
                        ovar.comment = "Parámetro de navegación"
                        outil.addToListDebug(lstobjdebug, "  " & svar)
                        cvariables.Add(ovar)
                        svariables = svariables & svar & ","
                    End If
                Next
            Next

            'PASO 4: Termina
            Return cvariables
        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.Identifica_Variables()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontSyncPantCGI.Identifica_Variables()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Function

    ''' <summary>
    ''' Función para leer todas aquellas clases que han sido definidas para ser usadas
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Private Function Leer_ClasesUsadas() As Collection
        Dim i As Integer
        Dim col As Collection = New Collection
        Dim sobj As String

        Try
            For i = 0 To Me.lstclasUsadas.Items.Count - 1
                sobj = Me.lstclasUsadas.Items.Item(i)
                For Each ocla As Clase In cClases
                    If ocla.name.Equals(sobj) Then col.Add(ocla)
                Next
            Next
            Return col
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontSyncPantCGI.Leer_ClasesUsadas()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Function

    ''' <summary>
    ''' Función para leer todas aquellas clases que han sido definidas para ser usadas
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Private Function Leer_TiposClasesUsadas() As Collection
        Dim i As Integer
        Dim col As Collection = New Collection
        Dim sobj As String

        Try
            For i = 0 To Me.lstclasUsadas.Items.Count - 1
                sobj = Me.lstclasUsadas.Items.Item(i)
                col.Add(sobj)
            Next
            Return col
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontSyncPantCGI.Leer_TiposClasesUsadas()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Function

    ''' <summary>
    ''' Función para leer aquellos objetos que han sido identificados
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Private Function Leer_VariablesIdentificadas() As Collection
        Dim iren As Integer
        Dim cvars As Collection
        cvars = New Collection

        Try
            For iren = 0 To grdobjinge.Rows.Count - 1
                Dim obj As Variable
                obj = New Variable()
                obj.nombre = grdobjinge.Item("objeto", iren).Value
                obj.tipo = grdobjinge.Item("tipo", iren).Value
                obj.valor = grdobjinge.Item("valor", iren).Value
                obj.comment = grdobjinge.Item("comment", iren).Value
                If Not obj.nombre.Equals("") Then cvars.Add(obj)
            Next iren
            Return cvars
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontSyncPantCGI.Leer_VariablesIdentificadas()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Function

    ''' <summary>
    ''' Función para leer las funciones en javascript desde el prototipo
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Private Function Leer_FuncionesJavaScript() As Collection
        Dim iren As Integer
        Dim cfuns As Collection
        cfuns = New Collection
        Try
            For iren = 0 To grdhtmlfunciones.Rows.Count - 1
                Dim sfun As String
                sfun = grdhtmlfunciones.Item("funcion", iren).Value
                If Not sfun.Equals("") Then cfuns.Add(sfun)
            Next iren
            Return cfuns
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontSyncPantCGI.Leer_FuncionesJavaScript()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Function

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmFrontWizSyncPantalla2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oxmlmain, oxmlestilos, oxmlestilo As Nodo
        Dim cfuns As Collection

        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            outil = New Utilerias
            omdipa = Me.ParentForm
            obus = New Catalogos(omdipa.conexion)
            ozip.Open(omdipa.configuracion)
            oconfig = New ConfigXML(ozip)
            outil = New Utilerias
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")

            'PASO 2: Termina
            osincronia = obus.getSincronia(Me.cdsincronia, Me.cdproject)
            oxmlestilo = oxmlestilos.BuscarPrimero("estilo", "clave", osincronia.cdestilogenera)
            txtestiloFrontEnd.Text = osincronia.cdestilogenera & " - " & oxmlestilo.getValue("estilo.nombre")

            'PASO 3: Llena el catálogo de funciones
            cfuns = oconfig.getFunciones(osincronia.cdestilogenera)
            For Each oxmlfun As Nodo In cfuns
                cboCodigoFuncion.Items.Add(oxmlfun.getValue("funcion.clave") + " - " + oxmlfun.getValue("funcion.nombre"))
            Next

            'PASO 4: Consulta y pinta los datos de la pantalla
            Call Consulta_DatosPantalla()
            Call Pinta_TodasLasClases()

        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.Load()", "Ocurrio un error al cargar la pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    ''' <summary>
    ''' Procedimiento para pintar las clases
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Pinta_TodasLasClases()
        Dim sclases As String

        Try
            'inicializa...
            sclases = ""

            'PASO 1: Arma una cadena con las clases usadas
            lstclasUsadas.Items.Clear()
            For Each sclase As String In cClasesUsadas
                sclases = sclases & sclase & ","
            Next

            'PASO 1: Carga todas las clases que se han leido
            lstclasTodas.Items.Clear()
            For Each oclase As Clase In cClases
                If sclases.IndexOf(oclase.name) < 0 Then lstclasTodas.Items.Add(oclase.name)
            Next

            'PASO 2: Carga las clases usadas
            lstclasUsadas.Items.Clear()
            For Each sclase As String In cClasesUsadas
                lstclasUsadas.Items.Add(sclase)
            Next

        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontSyncPantCGI.Pinta_TodasLasClases()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Sub

    Private Sub Consulta_DatosPantalla()
        Dim osincronia As SincroniaPantalla
        Dim oxmlconfig, oxmlobjs, oxmlvars, oxmlclases As Nodo
        Dim cNodos As Collection
        Dim cobjs As Collection
        Dim cvars As Collection

        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            omdipa = Me.ParentForm
            obus = New Catalogos(omdipa.conexion)
            outil = New Utilerias
            cobjs = New Collection
            cvars = New Collection

            'PASO 2: Consulta los datos de la pantalla
            oproject = obus.getProyecto(Me.cdproject)
            opantalla = obus.getPantalla(Me.cdproject, Me.cdpantalla)
            osincronia = obus.getSincroniaPantalla(Me.cdsincronia, Me.cdproject, Me.cdpantalla)
            If osincronia Is Nothing Then osincronia = New SincroniaPantalla()

            txthtmfile.Text = osincronia.nbhtmlfile
            txtcomponente.Text = osincronia.nbcomponente
            txthtmforma.Text = osincronia.nbhtmlforma
            oxmlconfig = New Nodo(osincronia.xmlpantalla)
            If osincronia.xmlpantalla.Equals("") Then Exit Sub

            'PASO 3: Carga las clases utilizadas
            oxmlclases = oxmlconfig.getPrimerNodo("clases")
            If Not oxmlclases Is Nothing Then
                cNodos = oxmlclases.getNodo("clase")
                For Each oxmlcla As Nodo In cNodos
                    cClasesUsadas.Add(oxmlcla.getValue("clase.nbclase"))
                    lstclasUsadas.Items.Add(oxmlcla.getValue("clase.nbclase"))
                Next
            End If

            'PASO 4: Leo los objetos (solo si hay)
            oxmlobjs = oxmlconfig.getPrimerNodo("objetos")
            If Not oxmlobjs Is Nothing Then
                cNodos = oxmlobjs.getNodo("variable")
                For Each oxmlvar As Nodo In cNodos
                    Dim ovar As Variable = New Variable
                    ovar.nombre = oxmlvar.getValue("variable.nombre")
                    ovar.tipo = oxmlvar.getValue("variable.tipo")
                    ovar.valor = oxmlvar.getValue("variable.valor")
                    ovar.comment = oxmlvar.getValue("variable.comentario")
                    If Not ovar.nombre.Equals("") Then cobjs.Add(ovar)
                Next
            End If
            Call Load_gridobjetos(cobjs)

            'PASO 5: Leo las variables (solo si hay)
            oxmlvars = oxmlconfig.getPrimerNodo("variables")
            If Not oxmlvars Is Nothing Then
                cNodos = oxmlvars.getNodo("variable")
                For Each oxmlvar As Nodo In cNodos
                    Dim ovar As Variable = New Variable
                    ovar.nombre = oxmlvar.getValue("variable.nombre")
                    ovar.tipo = oxmlvar.getValue("variable.tipo")
                    ovar.valor = oxmlvar.getValue("variable.valor")
                    ovar.comment = oxmlvar.getValue("variable.comentario")
                    If Not ovar.nombre.Equals("") Then cvars.Add(ovar)
                Next
            End If
            Call Load_gridvariables(cvars)

            'PASO 6: Si existe un archivo HTML, entonces lo leo
            If Not Me.txthtmfile.Text.Trim.Equals("") Then
                If outil.Existe_Archivo(Me.txthtmfile.Text.Trim) Then
                    Call Leer_ArchivoHTML(Me.txthtmfile.Text.Trim)
                End If
            End If

            'PASO 7: Se coloca las opciones de codificación
            If Not osincronia.cdestilofuncion.Equals("") Then cboCodigoFuncion.SelectedIndex = cboCodigoFuncion.FindString(osincronia.cdestilofuncion)

        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.Consulta_DatosPantalla()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontSyncPantCGI.Consulta_DatosPantalla()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
    End Sub

    Private Sub cmdclasusar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclasusar.Click
        Dim iindex As Integer
        iindex = Me.lstclasTodas.SelectedIndex
        Me.lstclasUsadas.Items.Add(Me.lstclasTodas.Items.Item(iindex))
        Me.lstclasTodas.Items.RemoveAt(iindex)
    End Sub

    Private Sub cmdclasquitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclasquitar.Click
        Dim iindex As Integer
        iindex = Me.lstclasUsadas.SelectedIndex
        Me.lstclasTodas.Items.Add(Me.lstclasUsadas.Items.Item(iindex))
        Me.lstclasUsadas.Items.RemoveAt(iindex)
    End Sub

    Private Sub cmdclasusartodas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclasusartodas.Click
        Dim i As Integer
        For i = 0 To Me.lstclasTodas.Items.Count - 1
            Me.lstclasUsadas.Items.Add(Me.lstclasTodas.Items.Item(i))
        Next
        Me.lstclasTodas.Items.Clear()
    End Sub

    Private Sub cmdclasquitartodas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclasquitartodas.Click
        Dim i As Integer
        For i = 0 To Me.lstclasUsadas.Items.Count - 1
            Me.lstclasTodas.Items.Add(Me.lstclasUsadas.Items.Item(i))
        Next
        Me.lstclasUsadas.Items.Clear()
    End Sub

    Private Sub btnhtmcodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhtmcodigo.Click
        Dim ofrm As frmeditor
        Try
            If Me.txthtmfile.Text.Trim.Equals("") Then
                MsgBox("Es necesario que seleccione un archivo", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                Exit Sub
            End If
            If Not outil.Existe_Archivo(Me.txthtmfile.Text.Trim) Then
                MsgBox("La página HTML que se pretende visualizar, ! no existe !", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                Exit Sub
            End If
            ofrm = New frmeditor()
            ofrm.Show()
            If Not ofrm.Carga_Archivo(Me.txthtmfile.Text) Then ofrm.Close()

        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.btnhtmcodigo_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmFrontSyncPantCGI.btnhtmcodigo_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnhtmimagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhtmimagen.Click
        If outil.Existe_Archivo(opantalla.nbimagefile) Then
            Dim ofrm As frmImagen
            ofrm = New frmImagen
            ofrm.MdiParent = Me.ParentForm
            ofrm.Paint_FileImagen(opantalla.nbimagefile)
            ofrm.Show()
        Else
            MsgBox("El archivo [" & opantalla.nbimagefile & "] no existe", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btnhtmBrowser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhtmBrowser.Click
        Dim ofrm As frmWEBBrowser = New frmWEBBrowser()

        If Me.txthtmfile.Text.Trim.Equals("") Then
            MsgBox("Es necesario que seleccione un archivo", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        If Not outil.Existe_Archivo(Me.txthtmfile.Text.Trim) Then
            MsgBox("La página HTML que se pretende visualizar, ! no existe !", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        ofrm.Show()
        ofrm.Pinta_HTML(Me.txthtmfile.Text)
    End Sub

    Private Sub cmdevread_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdevread.Click
        Call Load_grdeventos()
    End Sub

    Private Sub Load_grdeventos()
        Dim ceventos As Collection

        Try
            'PASO 1: agrega las columnas
            grdeventos.Rows.Clear()
            grdeventos.Columns.Clear()
            grdeventos.Columns.Add("cdevento", "Clave")
            grdeventos.Columns.Add("nbevento", "Nombre")
            grdeventos.Columns.Add("txcomment", "Comentario")

            'PASO 2: Define el ancho y sortmode de las columnas
            grdeventos.Columns.Item("cdevento").Width = 80
            grdeventos.Columns.Item("nbevento").Width = 200
            grdeventos.Columns.Item("txcomment").Width = 325
            grdeventos.Columns.Item("cdevento").SortMode = DataGridViewColumnSortMode.NotSortable
            grdeventos.Columns.Item("nbevento").SortMode = DataGridViewColumnSortMode.NotSortable
            grdeventos.Columns.Item("txcomment").SortMode = DataGridViewColumnSortMode.NotSortable

            ceventos = obus.getPantallaEventos(Me.cdproject, Me.cdpantalla)

            For Each omet As PantallaEvento In ceventos
                grdeventos.Rows.Add(omet.cdevento, omet.nbevento, omet.txcomment)
            Next
            txteventos.Text = "Un total de " & ceventos.Count & " eventos"
            If ceventos.Count > 0 Then
                cmdevsyncevento.Enabled = True
                cmdeventodel.Enabled = True
            End If
            cmdeventoadd.Enabled = True

        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.Load_grdeventos()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontSyncPantCGI.Load_grdeventos()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Sub

    Private Sub cmdevsyncevento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdevsyncevento.Click

        Try
            If Me.grdeventos.SelectedRows.Count > 0 Then
                Dim ofrm As frmPantallaEvento1
                ofrm = New frmPantallaEvento1
                ofrm.MdiParent = Me.ParentForm
                ofrm.cdproject = Me.cdproject
                ofrm.cdpantalla = Me.cdpantalla
                ofrm.cdmetobject = Me.grdeventos.SelectedRows.Item(0).Cells("cdevento").Value
                ofrm.cdsincronia = Me.cdsincronia
                ofrm.Clases = Leer_ClasesUsadas()
                ofrm.Objetos = Leer_ObjIdentificados()
                ofrm.Variables = Leer_VariablesIdentificadas()
                ofrm.Funsjavascript = Leer_FuncionesJavaScript()
                ofrm.Navegacion = obus.getNavegaciones(Me.cdproject, Me.cdpantalla)
                ofrm.Show()
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.cmdevsyncevento_Click()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As HANYException
            outil.ShowException(New HANYException("MyGENARO.frmFrontSyncPantCGI.cmdevsyncevento_Click()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub cmdeventodel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeventodel.Click
        Try
            If Me.grdeventos.SelectedRows.Count > 0 Then
                obus.delPantallaEvento(Me.cdproject, Me.cdpantalla, Me.grdeventos.SelectedRows.Item(0).Cells("cdevento").Value)
                MsgBox("Se ha eliminado el llamado al evento de la pantalla", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
                Call Load_grdeventos()
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.cmdeventodel_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmFrontSyncPantCGI.cmdeventodel_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub cmdeventoadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeventoadd.Click
        Dim ofrm As frmaddPantallaEvento1
        ofrm = New frmaddPantallaEvento1
        ofrm.MdiParent = Me.ParentForm
        ofrm.cdproject = Me.cdproject
        ofrm.cdpantalla = Me.cdpantalla
        ofrm.Show()
    End Sub

    Private Sub Load_gridobjetos(ByRef cobjets As Collection)
        Dim oselect As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn()
        Dim cTipos As Collection
        Dim bencontro As Boolean
        Try
            'PASO 0: Inicializa
            cTipos = Me.Leer_TiposClasesUsadas()

            'PASO 1: Arma el combo definido para tipos de objeto
            oselect.Name = "tipo"
            oselect.HeaderText = "Tipo"
            oselect.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            oselect.Width = 100
            oselect.Items.Add("")
            cTipos.Add("_LISTA_")
            For Each stipo As String In cTipos
                oselect.Items.Add(stipo)
            Next

            'PASO 2: Formatea el grid de variables automaticas
            grdobjautoma.Rows.Clear()
            grdobjautoma.Columns.Clear()
            grdobjautoma.Columns.Add("objeto", "Nombre")
            grdobjautoma.Columns.Add(oselect)
            grdobjautoma.Columns.Add("valor", "Valor Inicial")
            grdobjautoma.Columns.Add("comment", "Comentario")
            grdobjautoma.Columns.Item(0).Width = 100
            grdobjautoma.Columns.Item(3).Width = 380
            grdobjautoma.Columns.Item("objeto").SortMode = DataGridViewColumnSortMode.NotSortable
            grdobjautoma.Columns.Item("tipo").SortMode = DataGridViewColumnSortMode.NotSortable
            grdobjautoma.Columns.Item("valor").SortMode = DataGridViewColumnSortMode.NotSortable
            grdobjautoma.Columns.Item("comment").SortMode = DataGridViewColumnSortMode.NotSortable

            'PASO 4: Recorre la colección de variables automáticas
            For Each ovar As Variable In cobjets
                bencontro = False
                For Each stipo As String In cTipos
                    If ovar.tipo.Equals(stipo) Then bencontro = True
                Next
                If Not bencontro Then ovar.tipo = ""
                grdobjautoma.Rows.Add(ovar.nombre, ovar.tipo, ovar.valor, ovar.comment)
            Next
            txtobjautoma.Text = "Hay un total de " & cobjets.Count & " objetos automáticos"
        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.Load_gridobjetos()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontSyncPantCGI.Load_gridobjetos()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Sub

    Private Sub btnhtmexaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhtmexaminar.Click
        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de HTML (*.html)|*.html|Archivos de HTM (*.htm)|*.htm"
        If Me.txthtmfile.Text.Equals("") Then
            OpenFileDialog.InitialDirectory = Comun.STR_DIRECTORIO
        Else
            OpenFileDialog.FileName = Me.txthtmfile.Text
        End If
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Me.txthtmfile.Text = OpenFileDialog.FileName
            Comun.STR_DIRECTORIO = OpenFileDialog.RestoreDirectory
        End If
    End Sub

    Private Sub btniosyncin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btniosyncin.Click
        Try
            If Me.grdioinputs.SelectedRows.Count > 0 Then
                Dim ofrm As frmPantallaCampo1
                ofrm = New frmPantallaCampo1
                ofrm.MdiParent = Me.ParentForm
                ofrm.cdproject = Me.cdproject
                ofrm.cdpantalla = Me.cdpantalla
                ofrm.cdcampo = Me.grdioinputs.SelectedRows.Item(0).Cells("cdcatalogo").Value
                ofrm.cdsincronia = Me.cdsincronia
                ofrm.txtidhtml.Text = Me.grdioinputs.SelectedRows.Item(0).Cells("id").Value
                ofrm.txtnbhtml.Text = Me.grdioinputs.SelectedRows.Item(0).Cells("nombre").Value
                ofrm.txttaghtml.Text = Me.grdioinputs.SelectedRows.Item(0).Cells("tag").Value
                ofrm.txttphtml.Text = Me.grdioinputs.SelectedRows.Item(0).Cells("tipo").Value
                ofrm.Clases = Leer_ClasesUsadas()
                ofrm.Variables = Leer_ObjIdentificados()
                ofrm.Show()
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.btniosyncin_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmFrontSyncPantCGI.btniosyncin_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnhtmread_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhtmread.Click

        Try
            'PASO 1: Valida que tenga escrito algo
            If txthtmfile.Text.Trim.Equals("") Then
                MsgBox("Es necesario primero ingresar el archivo del prototipo !", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
                Exit Sub
            End If

            'PASO 2: Valida que exista el archivo
            If Not outil.Existe_Archivo(Me.txthtmfile.Text) Then
                MsgBox("El archivo del prototipo no existe en la ruta indicada !", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                Exit Sub
            End If

            'PASO 3: Procede a la lectura 
            Call Leer_ArchivoHTML(Me.txthtmfile.Text)

        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.btnhtmread_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmFrontSyncPantCGI.btnhtmread_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub Leer_ArchivoHTML(ByVal snbhtml As String)
        Dim cnavs As Collection
        Dim cforms As Collection
        Dim cinputs As Collection
        Dim cbotones As Collection
        Dim cfuncs As Collection
        Dim icounter As Integer

        Try
            'PASO 1: Lee el contenido del archivo html
            ohtml = New HTMLReader()
            ohtml.Carga(snbhtml)

            'PASO 2: Formatea el grid de inputs/outputs
            grdhtmtags.Rows.Clear()
            grdhtmtags.Columns.Clear()
            grdhtmtags.Columns.Add("num", "#")
            grdhtmtags.Columns.Add("id", "Id")
            grdhtmtags.Columns.Add("nombre", "Nombre")
            grdhtmtags.Columns.Add("tag", "TAG")
            grdhtmtags.Columns.Add("tipo", "Tipo")
            grdhtmtags.Columns.Add("valor", "Valor")
            grdhtmtags.Columns.Item("num").Width = 30
            grdhtmtags.Columns.Item("id").Width = 115
            grdhtmtags.Columns.Item("nombre").Width = 115
            grdhtmtags.Columns.Item("tag").Width = 70
            grdhtmtags.Columns.Item("tipo").Width = 70
            grdhtmtags.Columns.Item("valor").Width = 200
            grdhtmtags.Columns.Item("num").SortMode = DataGridViewColumnSortMode.NotSortable
            grdhtmtags.Columns.Item("id").SortMode = DataGridViewColumnSortMode.NotSortable
            grdhtmtags.Columns.Item("nombre").SortMode = DataGridViewColumnSortMode.NotSortable
            grdhtmtags.Columns.Item("tag").SortMode = DataGridViewColumnSortMode.NotSortable
            grdhtmtags.Columns.Item("tipo").SortMode = DataGridViewColumnSortMode.NotSortable
            grdhtmtags.Columns.Item("valor").SortMode = DataGridViewColumnSortMode.NotSortable

            grdhtmnavega.Rows.Clear()
            grdhtmnavega.Columns.Clear()
            grdhtmnavega.Columns.Add("num", "#")
            grdhtmnavega.Columns.Add("html", "HTML")
            grdhtmnavega.Columns.Item("num").Width = 20
            grdhtmnavega.Columns.Item("html").Width = 300
            grdhtmnavega.Columns.Item("num").SortMode = DataGridViewColumnSortMode.NotSortable
            grdhtmnavega.Columns.Item("html").SortMode = DataGridViewColumnSortMode.NotSortable

            grdhtmbotones.Rows.Clear()
            grdhtmbotones.Columns.Clear()
            grdhtmbotones.Columns.Add("num", "#")
            grdhtmbotones.Columns.Add("id", "Id")
            grdhtmbotones.Columns.Add("action", "Accion")
            grdhtmbotones.Columns.Item("num").Width = 20
            grdhtmbotones.Columns.Item("id").Width = 100
            grdhtmbotones.Columns.Item("action").Width = 230
            grdhtmbotones.Columns.Item("num").SortMode = DataGridViewColumnSortMode.NotSortable
            grdhtmbotones.Columns.Item("id").SortMode = DataGridViewColumnSortMode.NotSortable
            grdhtmbotones.Columns.Item("action").SortMode = DataGridViewColumnSortMode.NotSortable

            grdhtmlfunciones.Rows.Clear()
            grdhtmlfunciones.Columns.Clear()
            grdhtmlfunciones.Columns.Add("num", "#")
            grdhtmlfunciones.Columns.Add("funcion", "Función")
            grdhtmlfunciones.Columns.Item("num").Width = 20
            grdhtmlfunciones.Columns.Item("funcion").Width = 330
            grdhtmlfunciones.Columns.Item("num").SortMode = DataGridViewColumnSortMode.NotSortable
            grdhtmlfunciones.Columns.Item("funcion").SortMode = DataGridViewColumnSortMode.NotSortable

            'PASO 3: Consulta la forma
            cforms = ohtml.GetTags("form")
            Dim iforms As Integer = 0
            For Each otag As HTMLTag In cforms
                Me.txthtmforma.Text = otag.nombre
                iforms = iforms + 1
            Next
            If iforms > 1 Then
                MsgBox("Existio un error al leer el HTML, ya que un archivo solo puede contener una forma", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
                Exit Sub
            End If

            'PASO 4: Consulta todos los TAG...
            icounter = 1
            cinputs = ohtml.GetallTags()
            For Each oinput As HTMLTag In cinputs
                If Not oinput.id.Equals("") Then
                    grdhtmtags.Rows.Add(icounter, oinput.id, oinput.nombre, oinput.tag, oinput.tipo, oinput.valor)
                    icounter = icounter + 1
                End If
            Next

            'PASO 9: Consulta de log TAG input-button...
            icounter = 1
            cbotones = ohtml.GetTags("input", "button")
            For Each oboton As HTMLTag In cbotones
                If Not oboton.id.Equals("") Then
                    Me.grdhtmbotones.Rows.Add(icounter, oboton.id, "")
                    icounter = icounter + 1
                End If
            Next

            'PASO 10: Busca hacia donde navegan
            icounter = 1
            cnavs = ohtml.GetNavegacion()
            For Each shtml As String In cnavs
                grdhtmnavega.Rows.Add(icounter, shtml)
                icounter = icounter + 1
            Next

            'PASO 11: Busca las funciones
            icounter = 1
            cfuncs = ohtml.GetJavaScriptFunctions()
            For Each sfun As String In cfuncs
                grdhtmlfunciones.Rows.Add(icounter, sfun)
                icounter = icounter + 1
            Next

        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.Leer_ArchivoHTML()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontSyncPantCGI.Leer_ArchivoHTML()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Call Grabar_Informacion()
            MsgBox("Se grabo la información de configuración para la pantalla !", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.btnGuardar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para grabar la información de la sincronización en el HTML
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Grabar_Informacion()
        Dim sxml As String
        Dim cvars As Collection
        Dim cobjs As Collection
        Dim cclases As Collection
        Dim osincronia As SincroniaPantalla

        'PASO 1: realiza las validaciones
        If Me.txtcomponente.Text.IndexOf(".") > -1 Then
            MsgBox("Es importante que el nombre del componente no tenga extensión.", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        Try
            'PASO 2: Inicializa valores
            sxml = ""
            cvars = Leer_VariablesIdentificadas()
            cobjs = Leer_ObjIdentificados()
            osincronia = obus.getSincroniaPantalla(Me.cdsincronia, Me.cdproject, Me.cdpantalla)
            If osincronia Is Nothing Then osincronia = New SincroniaPantalla()

            'PASO 3: Inicia armando la sincronización
            osincronia.cdsincronia = Me.cdsincronia
            osincronia.cdproyecto = Me.cdproject
            osincronia.cdpantalla = Me.cdpantalla
            osincronia.cdestilofuncion = outil.Toma_Token(1, Me.cboCodigoFuncion.SelectedItem, "-")

            'PASO 4: Recorre los objetos para meterlos en una configuración xml
            sxml = "<objetos>"
            For Each ovar As Variable In cobjs
                sxml = sxml & ovar.GetXML()
            Next
            sxml = sxml & "</objetos>"
            osincronia.xmlpantalla = sxml

            'PASO 5: Recorre las variables para meterlas a una configuración xml
            sxml = "<variables>"
            For Each ovar As Variable In cvars
                sxml = sxml & ovar.GetXML()
            Next
            sxml = sxml & "</variables>"
            osincronia.xmlpantalla = osincronia.xmlpantalla & sxml

            'PASO 6: Recorre las clases que participan solo en esta pantalla
            sxml = "<clases>"
            cclases = Leer_ClasesUsadas()
            For Each ocla As Clase In cclases
                sxml = sxml & ocla.GetXML()
            Next
            sxml = sxml & "</clases>"
            osincronia.xmlpantalla = osincronia.xmlpantalla & sxml

            'PASO 7: graba el archivo XML que se ha seleccionado
            osincronia.nbhtmlfile = Me.txthtmfile.Text
            osincronia.nbcomponente = Me.txtcomponente.Text
            osincronia.nbhtmlforma = Me.txthtmforma.Text

            'PASO 8: Termina 
            obus.saveSincroniaPantalla(osincronia)

        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.Grabar_Informacion()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontSyncPantCGI.Grabar_Informacion()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Sub


    Private Sub Consulta_Entradas()
        Dim cinputs As Collection

        If ohtml Is Nothing Then
            MsgBox("Para llenar esta cuadricula es necesario primero cargar el HTML en la primer pestaña", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        Try
            cinputs = ohtml.GetAllInputTags()

            'PASO 1: Inicializa el grid
            grdioinputs.Rows.Clear()
            grdioinputs.Columns.Clear()
            grdioinputs.Columns.Add("id", "Id")
            grdioinputs.Columns.Add("nombre", "Nombre")
            grdioinputs.Columns.Add("tag", "tag")
            grdioinputs.Columns.Add("tipo", "tipo")
            grdioinputs.Columns.Add("catalogo", "En Catalogo")

            'PASO 2: Agrega una columna tipo checkbox
            Dim osync As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn(False)
            osync.Name = "sync"
            osync.HeaderText = "Sincronizado"
            osync.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            grdioinputs.Columns.Add(osync)
            grdioinputs.Columns.Add("cdcatalogo", "")

            'PASO 3: Define el ancho y modosort de las columnas
            grdioinputs.Columns.Item("id").Width = 100
            grdioinputs.Columns.Item("nombre").Width = 120
            grdioinputs.Columns.Item("tag").Width = 100
            grdioinputs.Columns.Item("tipo").Width = 100
            grdioinputs.Columns.Item("catalogo").Width = 200
            grdioinputs.Columns.Item("sync").Width = 150
            grdioinputs.Columns.Item("cdcatalogo").Visible = False

            grdioinputs.Columns.Item("id").SortMode = DataGridViewColumnSortMode.NotSortable
            grdioinputs.Columns.Item("nombre").SortMode = DataGridViewColumnSortMode.NotSortable
            grdioinputs.Columns.Item("tag").SortMode = DataGridViewColumnSortMode.NotSortable
            grdioinputs.Columns.Item("tipo").SortMode = DataGridViewColumnSortMode.NotSortable
            grdioinputs.Columns.Item("catalogo").SortMode = DataGridViewColumnSortMode.NotSortable
            grdioinputs.Columns.Item("sync").SortMode = DataGridViewColumnSortMode.NotSortable

            'PASO 4: Escribe los TAG en el grid
            For Each oinput As HTMLTag In cinputs
                Dim bsync As Boolean = True
                Dim ocampo As PantallaCampo = obus.getPantallaCampobyId(Me.cdproject, Me.cdpantalla, Me.cdsincronia, oinput.id)
                If ocampo Is Nothing Then
                    ocampo = New PantallaCampo
                    bsync = False
                End If
                If Not oinput.id.Equals("") Then grdioinputs.Rows.Add(oinput.id, oinput.nombre, oinput.tag, oinput.tipo, ocampo.nbcampo, bsync, ocampo.cdcampo)
            Next

            'PASO 5: Termina
            btniosyncin.Enabled = True

        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.Consulta_Entradas()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontSyncPantCGI.Consulta_Entradas()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Sub

    Private Sub Consulta_Salidas()
        Dim coutputs As Collection

        If ohtml Is Nothing Then
            MsgBox("Para llenar esta cuadricula es necesario primero cargar el HTML en la primer pestaña", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        Try
            'PASO 1: Inicializa el grid
            grdiooutputs.Rows.Clear()
            grdiooutputs.Columns.Clear()
            grdiooutputs.Columns.Add("id", "Id")
            grdiooutputs.Columns.Add("nombre", "Nombre")
            grdiooutputs.Columns.Add("tag", "tag")
            grdiooutputs.Columns.Add("catalogo", "En Catalogo")

            'PASO 2: Agrega una columna tipo checkbox
            Dim osync As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn(False)
            osync.Name = "sync"
            osync.HeaderText = "Sincronizado"
            osync.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            grdiooutputs.Columns.Add(osync)
            grdiooutputs.Columns.Add("cdcatalogo", "")

            'PASO 3: Define el ancho y sort mode de las columnas
            grdiooutputs.Columns.Item("id").Width = 100
            grdiooutputs.Columns.Item("nombre").Width = 120
            grdiooutputs.Columns.Item("tag").Width = 100
            grdiooutputs.Columns.Item("catalogo").Width = 200
            grdiooutputs.Columns.Item("sync").Width = 150
            grdiooutputs.Columns.Item("cdcatalogo").Visible = False
            grdiooutputs.Columns.Item("id").SortMode = DataGridViewColumnSortMode.NotSortable
            grdiooutputs.Columns.Item("nombre").SortMode = DataGridViewColumnSortMode.NotSortable
            grdiooutputs.Columns.Item("tag").SortMode = DataGridViewColumnSortMode.NotSortable
            grdiooutputs.Columns.Item("catalogo").SortMode = DataGridViewColumnSortMode.NotSortable
            grdiooutputs.Columns.Item("sync").SortMode = DataGridViewColumnSortMode.NotSortable

            'PASO 4: Consulta de los TAG Input-text...
            coutputs = ohtml.GetAllOutputTags()
            For Each output As HTMLTag In coutputs
                Dim bsync As Boolean = True
                Dim ocampo As PantallaCampo = obus.getPantallaCampobyId(Me.cdproject, Me.cdpantalla, Me.cdsincronia, output.id)
                If ocampo Is Nothing Then
                    ocampo = New PantallaCampo
                    bsync = False
                End If
                If Not output.id.Equals("") Then grdiooutputs.Rows.Add(output.id, output.nombre, output.tag, ocampo.nbcampo, bsync, ocampo.cdcampo)
            Next

            'PASO 5: Termina
            btniosyncout.Enabled = True

        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.Consulta_Salidas()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontSyncPantCGI.Consulta_Salidas()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Sub

    Private Sub btnobjgenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnobjgenerar.Click
        Dim cobjs As Collection
        Try
            lstobjdebug.Items.Clear()
            cobjs = Identifica_Objetos()
            Call Load_gridobjetos(cobjs)
        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.btnobjgenerar_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmFrontSyncPantCGI.btnobjgenerar_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub btniosyncout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btniosyncout.Click
        Try
            If Me.grdiooutputs.SelectedRows.Count > 0 Then
                Dim ofrm As frmPantallaCampo1
                ofrm = New frmPantallaCampo1
                ofrm.MdiParent = Me.ParentForm
                ofrm.cdproject = Me.cdproject
                ofrm.cdpantalla = Me.cdpantalla
                ofrm.cdcampo = Me.grdiooutputs.SelectedRows.Item(0).Cells("cdcatalogo").Value
                ofrm.cdsincronia = Me.cdsincronia
                ofrm.txtidhtml.Text = Me.grdiooutputs.SelectedRows.Item(0).Cells("id").Value
                ofrm.txtnbhtml.Text = Me.grdiooutputs.SelectedRows.Item(0).Cells("nombre").Value
                ofrm.txttaghtml.Text = Me.grdiooutputs.SelectedRows.Item(0).Cells("tag").Value
                ofrm.Clases = Leer_ClasesUsadas()
                ofrm.Variables = Leer_ObjIdentificados()
                ofrm.Show()
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.btniosyncout_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmFrontSyncPantCGI.btniosyncout_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnavload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnavload.Click
        Load_gridNavegaciones(Me.cdproject, Me.cdpantalla)
    End Sub

    Private Sub Load_gridNavegaciones(ByVal scdproyecto As String, ByVal scdpantalla As String)
        Dim cnavs As Collection

        Try
            gridNavegacion.Rows.Clear()
            gridNavegacion.Columns.Clear()
            gridNavegacion.Columns.Add("shasta", "Pantalla Final")
            gridNavegacion.Columns.Add("tipo", "Tipo")
            gridNavegacion.Columns.Add("stopen", "Open Window")
            gridNavegacion.Columns.Item("shasta").Width = 300
            gridNavegacion.Columns.Item("shasta").SortMode = DataGridViewColumnSortMode.NotSortable
            gridNavegacion.Columns.Item("tipo").SortMode = DataGridViewColumnSortMode.NotSortable
            gridNavegacion.Columns.Item("stopen").SortMode = DataGridViewColumnSortMode.NotSortable

            cnavs = obus.getNavegaciones(scdproyecto, scdpantalla)

            For Each onav As Navegacion In cnavs
                Dim ohasta As Pantalla = obus.getPantalla(scdproyecto, onav.cdhasta)
                gridNavegacion.Rows.Add(onav.cdhasta & " - " & ohasta.nbpantalla, onav.tpnavegacion, onav.stopenwindow)
            Next

            gridnavfrom.Rows.Clear()
            gridnavfrom.Columns.Clear()
            gridnavfrom.Columns.Add("sdesde", "Pantalla Inicial")
            gridnavfrom.Columns.Add("tipo", "Tipo")
            gridnavfrom.Columns.Add("stopen", "Open Window")
            gridnavfrom.Columns.Item("sdesde").Width = 300
            gridnavfrom.Columns.Item("sdesde").SortMode = DataGridViewColumnSortMode.NotSortable
            gridnavfrom.Columns.Item("tipo").SortMode = DataGridViewColumnSortMode.NotSortable
            gridnavfrom.Columns.Item("stopen").SortMode = DataGridViewColumnSortMode.NotSortable

            cnavs = obus.getNavegaDesdeDestino(scdproyecto, scdpantalla)

            For Each onav As Navegacion In cnavs
                Dim odesde As Pantalla = obus.getPantalla(scdproyecto, onav.cdesde)
                gridnavfrom.Rows.Add(odesde.cdpantalla & " - " & odesde.nbpantalla, onav.tpnavegacion, onav.stopenwindow)
            Next
        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.Load_gridNavegaciones()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontSyncPantCGI.Load_gridNavegaciones()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Sub

    Private Sub btnavdetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnavdetalle.Click
        Try
            If Me.gridNavegacion.SelectedRows.Count > 0 Then

                Dim ofrm As frmNavegacion1
                ofrm = New frmNavegacion1
                ofrm.MdiParent = Me.ParentForm
                ofrm.cdproject = Me.cdproject
                ofrm.cdesde = Me.cdpantalla
                ofrm.InputTags = ohtml.GetAllInputTags()
                ofrm.cdhasta = outil.Toma_Token(1, Me.gridNavegacion.SelectedRows.Item(0).Cells("shasta").Value, "-")
                ofrm.Show()

            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.btnavdetalle_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmFrontSyncPantCGI.btnavdetalle_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnavdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnavdel.Click
        Try
            If Me.gridNavegacion.SelectedRows.Count > 0 Then
                obus.delNavegacion(Me.cdproject, Me.cdpantalla, outil.Toma_Token(1, Me.gridNavegacion.SelectedRows.Item(0).Cells("shasta").Value, "-"))
                MsgBox("Se ha eliminado el registro de la navegación", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
                Me.Load_gridNavegaciones(Me.cdproject, Me.cdpantalla)
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.btnavdel_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmFrontSyncPantCGI.btnavdel_Click()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub btnavadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnavadd.Click
        Dim ofrm As frmaddNavegacion1
        ofrm = New frmaddNavegacion1
        ofrm.MdiParent = Me.ParentForm
        ofrm.cdproject = Me.cdproject
        ofrm.cddesde = Me.cdpantalla
        ofrm.Show()
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SaveFileDialog1.Title = "Grabar Como..."
        SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog1.Filter = "Todos (*.*)|*.*"
        If (SaveFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Me.txtcomponente.Text = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub btnavdetalle2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnavdetalle2.Click
        Try
            If Me.gridnavfrom.SelectedRows.Count > 0 Then

                Dim ofrm As frmNavegacion1
                ofrm = New frmNavegacion1
                ofrm.MdiParent = Me.ParentForm
                ofrm.cdproject = Me.cdproject
                ofrm.cdhasta = Me.cdpantalla
                ofrm.cdesde = outil.Toma_Token(1, Me.gridnavfrom.SelectedRows.Item(0).Cells("sdesde").Value, "-")
                ofrm.Show()
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As Exception
            outil.ShowException(New HANYException("MyGENARO.frmFrontSyncPantCGI.btnavdetalle2_Click()", "Ocurrio un error [" & ex.ToString & "]"))
        End Try

    End Sub

    ''' <summary>
    ''' Función para leer los botones desde el HTML
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Private Function Leer_BotonesHTML() As Collection
        Dim iren As Integer
        Dim cbotons As Collection
        cbotons = New Collection
        Try
            For iren = 0 To grdhtmbotones.Rows.Count - 1
                Dim obj As HTMLTag
                obj = New HTMLTag()
                obj.id = grdhtmbotones.Item("id", iren).Value
                obj.nombre = 1
                obj.tag = 1
                obj.tipo = 1
                obj.valor = grdhtmbotones.Item("action", iren).Value
                cbotons.Add(obj)
            Next
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontSyncPantCGI.Leer_BotonesHTML()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
        Return cbotons
    End Function

    ''' <summary>
    ''' Función para leer aquellos objetos que están identificados
    ''' </summary>
    ''' <remarks></remarks>
    Private Function Leer_ObjIdentificados() As Collection
        Dim iren As Integer
        Dim cobjets As Collection

        Try
            'PASO 1: Inicializa...
            cobjets = New Collection

            'PASO 2: Lee aquellos objetos automáticos
            For iren = 0 To grdobjautoma.Rows.Count - 1
                Dim obj As Variable
                obj = New Variable()
                obj.nombre = grdobjautoma.Item("objeto", iren).Value
                obj.tipo = grdobjautoma.Item("tipo", iren).Value
                obj.valor = grdobjautoma.Item("valor", iren).Value
                obj.comment = grdobjautoma.Item("comment", iren).Value
                If Not obj.nombre.Equals("") Then cobjets.Add(obj)
            Next iren

        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontSyncPantCGI.Leer_ObjIdentificados()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

        'PASO 3: Termina
        Return cobjets

    End Function

    Private Function Identifica_Objetos() As Collection
        Dim ccampos As Collection
        Dim ceventos As Collection
        Dim cobjetos As Collection
        Dim carreglos As Collection
        Dim sobjects As String

        Try
            'PASO 1: Inicializa el grid de variables
            sobjects = ""
            cobjetos = New Collection
            outil.addToListDebug(lstobjdebug, " [ Identificando objetos ] ")

            'PASO 2: Identifica las variables por medio de los eventos solicitados
            outil.addToListDebug(lstobjdebug, "PASO 1: requeridos en eventos")
            ceventos = obus.getPantallaEventos(Me.cdproject, Me.cdpantalla)
            For Each oevento As PantallaEvento In ceventos
                Dim oxml As Nodo
                Dim sobj As String
                Dim oeventosinc As SincroniaEvento

                outil.addToListDebug(lstobjdebug, "   Evento [" & oevento.nbevento & "]")

                'PASO 2.1: Lee la sincronización del evento
                oeventosinc = obus.getSincroniaEvento(Me.cdsincronia, Me.cdproject, Me.cdpantalla, oevento.cdevento)
                If oeventosinc Is Nothing Then
                    outil.addToListDebug(lstobjdebug, "   ...Evento no sincronizado!")
                    Continue For
                End If
                oxml = New Nodo(oeventosinc.xmlevento())

                'PASO 2.1: Si se trata de una ejecución en el servidor ...
                If oxml.getValue("evehtml.exeservidor").Trim.Equals("Si") Or oxml.getValue("evehtml.exesrvbrow").Trim.Equals("Si") Then
                    If oxml.getValue("eveobject.nbclase").Trim.Equals("") Then
                        outil.addToListDebug(lstobjdebug, "   ...Evento no sincronizado!")
                        Continue For
                    End If
                    sobj = "obus" & oxml.getValue("eveobject.nbclase")
                    If sobjects.IndexOf(sobj & ",") < 0 Then
                        Dim ovar As Variable = New Variable
                        ovar.nombre = sobj
                        ovar.tipo = oxml.getValue("eveobject.nbclase")
                        ovar.valor = "_VACIO_"
                        ovar.comment = "Objeto tipo " & oxml.getValue("eveobject.nbclase")
                        outil.addToListDebug(lstobjdebug, "  " & sobj)
                        If Not ovar.tipo.Trim.Equals("") Then cobjetos.Add(ovar)
                        sobjects = sobjects & sobj & ","
                    End If
                End If
            Next

            'PASO 3: Identifica las variables por medio de los objetos usados en campos de la pantalla
            outil.addToListDebug(lstobjdebug, "PASO 2: Usados en pantalla")
            ccampos = obus.getPantallaCampoSinArreglo(Me.cdproject, Me.cdpantalla)
            For Each ocampo As PantallaCampo In ccampos
                Dim oxml As Nodo
                Dim sobj As String
                Dim ocamposinc As SincroniaCampo

                outil.addToListDebug(lstobjdebug, "   Campo [" & ocampo.nbcampo & "]")
                ocamposinc = obus.getSincroniaCampo(Me.cdsincronia, Me.cdproject, Me.cdpantalla, ocampo.cdcampo)
                If ocamposinc Is Nothing Then
                    outil.addToListDebug(lstobjdebug, "   ...Campo no sincronizado!")
                    Continue For
                End If
                oxml = New Nodo(ocamposinc.xmlcampo)
                If Not oxml.getValue("object.nbclase").Trim.Equals("") Then
                    sobj = "o" & oxml.getValue("object.nbclase")
                    If sobjects.IndexOf(sobj & ",") < 0 Then
                        Dim ovar As Variable = New Variable
                        ovar.nombre = sobj
                        ovar.tipo = oxml.getValue("object.nbclase")
                        ovar.valor = "_VACIO_"
                        ovar.comment = "Objeto tipo " & oxml.getValue("object.nbclase")
                        outil.addToListDebug(lstobjdebug, "  " & sobj)
                        If Not ovar.tipo.Equals("") Then cobjetos.Add(ovar)
                        sobjects = sobjects & sobj & ","
                    End If
                End If
                If Not oxml.getValue("objectlist.nbclase").Trim.Equals("") Then
                    sobj = "c" & oxml.getValue("objectlist.nbclase") & "s"
                    If sobjects.IndexOf(sobj & ",") < 0 Then
                        Dim ovar As Variable = New Variable
                        ovar.nombre = sobj
                        ovar.tipo = "_LISTA_"
                        ovar.valor = "_VACIO_"
                        ovar.comment = "Colección de objetos tipo " & oxml.getValue("objectlist.nbclase")
                        outil.addToListDebug(lstobjdebug, "  " & sobj)
                        If Not ovar.tipo.Equals("") Then cobjetos.Add(ovar)
                        sobjects = sobjects & sobj & ","
                    End If
                End If
            Next

            'PASO 4: Identifica los objetos tipo _LIST_ a partir de los arreglos de la pantalla
            outil.addToListDebug(lstobjdebug, "PASO 3: Objetos de acuerdo a los arreglos")
            carreglos = obus.getPantallarreglos(Me.cdproject, Me.cdpantalla)
            For Each oarr As Pantallarreglo In carreglos
                Dim osincronia As SincroniArreglo
                Dim sobj As String

                outil.addToListDebug(lstobjdebug, "   Arreglo [" & oarr.nbarreglo & "]")
                osincronia = obus.getSincroniArreglo(Me.cdsincronia, Me.cdproject, Me.cdpantalla, oarr.cdarreglo)
                If osincronia Is Nothing Then
                    outil.addToListDebug(lstobjdebug, "   ...Arreglo no sincronizado!")
                    Continue For
                End If
                If Not osincronia.tpelement.Equals("") Then
                    sobj = "c" & osincronia.tpelement & "s"
                    If sobjects.IndexOf(sobj & ",") < 0 Then
                        Dim ovar As Variable = New Variable
                        ovar.nombre = sobj
                        ovar.tipo = "_LISTA_"
                        ovar.valor = "_VACIO_"
                        ovar.comment = "Colección de objetos tipo " & osincronia.tpelement
                        If Not ovar.tipo.Equals("") Then cobjetos.Add(ovar)
                        sobjects = sobjects & sobj & ","
                    End If

                End If
            Next


        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.Identifica_Objetos()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontSyncPantCGI.Identifica_Objetos()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

        'PASO 4: Termina
        Return cobjetos
    End Function

    Private Sub Load_gridvariables(ByRef cvars As Collection)
        Dim oselect As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn()
        Dim cTipos As Collection
        Dim bencontro As Boolean

        Try
            'PASO 0: Inicializa
            cTipos = Me.Leer_TiposClasesUsadas()

            'PASO 1: Arma el combo definido para tipos de objeto
            oselect.Name = "tipo"
            oselect.HeaderText = "Tipo"
            oselect.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            oselect.Width = 100

            cTipos.Add("_ENTERO_")
            cTipos.Add("_CADENA_")
            cTipos.Add("_LISTA_")
            cTipos.Add("_PAGET_")
            cTipos.Add("_PAPOST_")

            oselect.Items.Add("")
            For Each stipo As String In cTipos
                oselect.Items.Add(stipo)
            Next

            'PASO 3: Formatea el grid de variables de ingenieria
            grdobjinge.Rows.Clear()
            grdobjinge.Columns.Clear()
            grdobjinge.Columns.Add("objeto", "Nombre")
            grdobjinge.Columns.Add(oselect)
            grdobjinge.Columns.Add("valor", "Valor Inicial")
            grdobjinge.Columns.Add("comment", "Comentario")
            grdobjinge.Columns.Item(0).Width = 100
            grdobjinge.Columns.Item(3).Width = 380
            grdobjinge.Columns.Item("objeto").SortMode = DataGridViewColumnSortMode.NotSortable
            grdobjinge.Columns.Item("tipo").SortMode = DataGridViewColumnSortMode.NotSortable
            grdobjinge.Columns.Item("valor").SortMode = DataGridViewColumnSortMode.NotSortable
            grdobjinge.Columns.Item("comment").SortMode = DataGridViewColumnSortMode.NotSortable

            'PASO 4: Recorre la colección de variables automáticas
            For Each ovar As Variable In cvars
                bencontro = False
                For Each stipo As String In cTipos
                    If ovar.tipo.Equals(stipo) Then bencontro = True
                Next
                If Not bencontro Then ovar.tipo = ""
                grdobjinge.Rows.Add(ovar.nombre, ovar.tipo, ovar.valor, ovar.comment)
            Next

        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontSyncPantCGI.Load_gridvariables()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Sub

    Private Sub btnCodigoGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCodigoGenerar.Click
        Dim ohtml As Html2CGI
        Dim sxmlgen As String
        Dim scdestilo As String
        Dim oxmlCGI, oxmlparametros, oxmextras, oxmfinal As Nodo
        Dim ometa As MetacodigoReader
        Dim ocextras As Collection
        Dim sfilecontent As String
        Dim salldebug As String


        Try
            'PASO 1: Iniciando
            oconfig = New ConfigXML(ozip)
            scdestilo = outil.Toma_Token(1, Me.txtestiloFrontEnd.Text, "-")
            oxmlCGI = oconfig.getUnEstiloProgramacion(scdestilo)
            oxmlparametros = oxmlCGI.getPrimerNodo("code.parametros")
            Call Inicializa_TabPages()

            'PASO 2: Voy a traer la información relativa a la pantalla
            opantalla = obus.getPantallaSinc(Me.cdsincronia, Me.cdproject, Me.cdpantalla)
            If opantalla.sincronia Is Nothing Then
                MsgBox("Es necesario que la pantalla se encuentre en estatus de sincronizada", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                Exit Sub
            End If
            If Not opantalla.sincronia.estatus.Equals(Comun.ST_SINCRONIZADO_HTML) Then
                MsgBox("Es necesario que la pantalla se encuentre en estatus de sincronizada", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                Exit Sub
            End If

            'PASO 3: Inicializa valores
            sxmlgen = ""
            ohtml = New Html2CGI
            Me.Cursor = Cursors.WaitCursor
            ohtml.estilo = outil.Toma_Token(1, Me.txtestiloFrontEnd.Text, "-")
            ohtml.procesador = outil.Toma_Token(1, Me.cboCodigoFuncion.SelectedItem, "-")
            ohtml.zipconfig = ozip

            'PASO 4: Define el xml para los datos generales
            sxmlgen = "<general>"
            sxmlgen = sxmlgen & "<nbcomponente>" & opantalla.sincronia.nbcomponente & "</nbcomponente>"
            sxmlgen = sxmlgen & "<extcgi>" & oxmlparametros.BuscarPrimero("parametro", "nombre", "extension-cgi").getValue("parametro.valor") & "</extcgi>"
            sxmlgen = sxmlgen & "<cdproyecto>" & oproject.cdproyecto & "</cdproyecto>"
            sxmlgen = sxmlgen & "<nbproyecto>" & oproject.nbproyecto & "</nbproyecto>"
            sxmlgen = sxmlgen & "<nbempresa>" & oproject.nbempresa & "</nbempresa>"
            sxmlgen = sxmlgen & "<nbcliente>" & oproject.nbcliente & "</nbcliente>"
            sxmlgen = sxmlgen & "</general>"

            'PASO 5: Lee el archivo html desde el prototipo
            If Not ohtml.Carga(opantalla.sincronia.nbhtmlfile) Then
                Me.Cursor = Cursors.Default
                MsgBox("! ERROR ! La pantalla [" & scdpantalla & "] sin relación con su HTML", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
                Exit Sub
            End If

            'PASO 6: Lee la información a detalle para la pantalla
            opantalla.Arreglos = obus.getPantallarreglosSinc(Me.cdsincronia, Me.cdproject, Me.cdpantalla)
            opantalla.Campos = obus.getPantallaCamposSinc(Me.cdsincronia, Me.cdproject, Me.cdpantalla)
            opantalla.Eventos = obus.getPantallaEventosSinc(Me.cdsincronia, Me.cdproject, Me.cdpantalla)

            'PASO 7: Recorre los campos para crear las validaciones...
            oxmfinal = New Nodo(sxmlgen & opantalla.GetXML())
            ohtml.SetXML(oxmfinal.GetXML())
            Me.txtCodigo.Text = ohtml.generaCGI()
            salldebug = ohtml.getdebug()

            'PASO 8: Ahora realiza un procesamiento de todos los códigos llamados extras
            oxmextras = oxmlCGI.getPrimerNodo("extras")
            ocextras = oxmextras.getNodo("extra")
            For Each oxmlext As Nodo In ocextras
                Dim otab As TabPage
                Dim otxtcode As RichTextBox
                ometa = New MetacodigoReader()
                otxtcode = New RichTextBox()
                otxtcode.Height = 276
                otxtcode.Width = 695
                otab = New TabPage(outil.Remplaza_Caracter(oxmlext.getValue("extra.extension"), "*", oxmfinal.getValue("general.nbcomponente")))
                ometa.file = oxmlext.getValue("extra.archivo")
                ometa.source = ozip.getFileInflated(oxmlCGI.getValue("estilo.directorio") & oxmlext.getValue("extra.archivo"))
                sfilecontent = ometa.Interpreta(oxmfinal.GetXML())
                salldebug = salldebug & vbLf & ometa.getdebug
                tabcodes.TabPages.Add(otab)
                otab.Controls.Add(otxtcode)
                otxtcode.Text = sfilecontent
                otxtcode.ContextMenuStrip = cmenueditor
            Next

            'PASO 8: Termina...
            If chkcontexto.Checked Then outil.Preveer(oxmfinal.GetXML())
            If chkdebug.Checked Then outil.Preveer(salldebug)
            Me.Cursor = Cursors.Default

        Catch ex As HANYException
            Me.Cursor = Cursors.Default
            ex.add("MyGENARO.frmFrontSyncPantCGI.btnCodigoGenerar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            Me.Cursor = Cursors.Default
            outil.ShowException(New HANYException("MyGENARO.frmFrontSyncPantCGI.btnCodigoGenerar_Click()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub Inicializa_TabPages()
        Dim icount As Integer
        icount = Me.tabcodes.TabPages.Count
        txtCodigo.Text = ""
        While icount > 1
            Me.tabcodes.TabPages.RemoveAt(icount - 1)
            icount = icount - 1
        End While
    End Sub

    Private Sub btnCalificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalificar.Click
        Dim ofrm As frmFronCalificaSync
        ofrm = New frmFronCalificaSync()
        ofrm.conexion = omdipa.conexion
        ofrm.cdproject = Me.cdproject
        ofrm.cdpantalla = Me.cdpantalla
        ofrm.cdsincronia = Me.cdsincronia
        ofrm.ShowDialog()
    End Sub

    Private Sub Consulta_Arreglos()
        Dim carreglos As Collection
        Try
            gridarreglos.Rows.Clear()
            gridarreglos.Columns.Clear()
            gridarreglos.Columns.Add("clave", "Clave")
            gridarreglos.Columns.Add("nombre", "Nombre")
            gridarreglos.Columns.Item("clave").Width = 60
            gridarreglos.Columns.Item("nombre").Width = 200
            gridarreglos.Columns.Item("clave").SortMode = DataGridViewColumnSortMode.NotSortable
            gridarreglos.Columns.Item("nombre").SortMode = DataGridViewColumnSortMode.NotSortable

            carreglos = obus.getPantallarreglos(Me.cdproject, Me.cdpantalla)
            For Each oarr As Pantallarreglo In carreglos
                gridarreglos.Rows.Add(oarr.cdarreglo, oarr.nbarreglo)
            Next
            btniosincinarray.Enabled = IIf(carreglos.Count > 0, True, False)
        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.Consulta_Arreglos()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontSyncPantCGI.Consulta_Arreglos()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
    End Sub

    Private Sub btniosincinarray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btniosincinarray.Click
        Try
            If Me.gridarreglos.SelectedRows.Count > 0 Then
                Dim ofrm As frmPantallaArreglo1
                ofrm = New frmPantallaArreglo1
                ofrm.MdiParent = Me.ParentForm
                ofrm.cdproject = Me.cdproject
                ofrm.cdpantalla = Me.cdpantalla
                ofrm.cdarreglo = Me.gridarreglos.SelectedRows.Item(0).Cells("clave").Value
                ofrm.cdsincronia = Me.cdsincronia
                ofrm.Clases = Leer_ClasesUsadas()
                ofrm.Variables = Leer_ObjIdentificados()
                ofrm.HTMLRows = Leer_HTMLRenglones()
                ofrm.Show()
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.btniosincinarray_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmFrontSyncPantCGI.btniosincinarray_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try
    End Sub

    ''' <summary>
    ''' Función para leer los renglones HTML 
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Private Function Leer_HTMLRenglones() As Collection
        Dim iren As Integer
        Dim ocol As Collection

        ocol = New Collection
        For iren = 0 To Me.grdhtmtags.Rows.Count - 1
            If Me.grdhtmtags.Item("tag", iren).Value.Equals("TR") Then ocol.Add(Me.grdhtmtags.Item("id", iren).Value)
        Next
        Return ocol
    End Function


    Private Sub btnioread_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnioread.Click
        Try
            Call Consulta_Arreglos()
            Call Consulta_Entradas()
            Call Consulta_Salidas()
        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.btnioread_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub btndelsincronia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelsincronia.Click
        Try
            obus.delSincroniaPantalla(Me.cdsincronia, Me.cdproject, Me.cdpantalla)
            MsgBox("Se ha eliminado la sincronización actual para la pantalla !", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.btndelsincronia_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub objvardefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles objvardefault.Click
        Dim cvars As Collection

        Try
            lstobjdebug.Items.Clear()
            cvars = Identifica_Variables()
            Call Load_gridvariables(cvars)
        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncPantCGI.objvardefault_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmFrontSyncPantCGI.objvardefault_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub Opcion1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opcion1ToolStripMenuItem.Click
        outil.Preveer(Me.cmenueditor.SourceControl.Text)
    End Sub

End Class