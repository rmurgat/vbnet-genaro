Option Explicit On

Imports MyLIB

Public Class frmPantallaEvento1
    Private obus As Catalogos
    Private scdproject As String = ""   'Clave del proyecto
    Private scdpantalla As String = ""  'Clave de la pantalla
    Private scdmetobject As String = "" 'Clave del metodo del objeto
    Private scdsincronia As String = "" 'Clave de la sincronia
    Private oproject As Proyecto        'Objeto que tiene las propiedades del proyecto
    Private opantalla As Pantalla       'Objeto que tiene las propiedades de la pantalla
    Private oevento As PantallaEvento   'Objeto que tiene las propiedades y metodos de un metodo del objeto
    Private oevesinc As SincroniaEvento 'Objeto que tiene la sincronización de un evento en particular
    Private outil As Utilerias
    Private omdipa As MDIGenaro
    Private cClases As Collection = New Collection     'Colección de clases
    Private cObjetos As Collection = New Collection    'Colección de objetos
    Private cVariables As Collection = New Collection   'Colección de variables
    Private cFunsjavascript As Collection = New Collection 'Funciones javascript
    Private cNavegacion As Collection = New Collection  'Colección de navegación
    Private cHtmlInputs As Collection = New Collection  'Colección de inputs de html
    Private bvalidretorno As Boolean = False

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
    ''' PROPIEDAD: Clave del campo
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdmetobject() As String
        Get
            Return scdmetobject
        End Get
        Set(ByVal pscd As String)
            scdmetobject = pscd
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
            If pscd Is Nothing Then Exit Property
            scdsincronia = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Especificación de los objetos
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property Clases() As Collection
        Get
            Return cClases
        End Get
        Set(ByVal obj As Collection)
            cClases = obj
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Listado de objetos
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property Variables() As Collection
        Get
            Return cVariables
        End Get
        Set(ByVal obj As Collection)
            cVariables = obj
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Colección de objetos
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property Objetos() As Collection
        Get
            Return cObjetos
        End Get
        Set(ByVal obj As Collection)
            cObjetos = obj
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Funciones javascript
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property Funsjavascript() As Collection
        Get
            Return cFunsjavascript
        End Get
        Set(ByVal pcval As Collection)
            cFunsjavascript = pcval
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Colección de navegación
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property Navegacion() As Collection
        Get
            Return cNavegacion
        End Get
        Set(ByVal pcval As Collection)
            cNavegacion = pcval
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Colección de inputs de html
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property HtmlInputs() As Collection
        Get
            Return cHtmlInputs
        End Get
        Set(ByVal pcval As Collection)
            cHtmlInputs = pcval
        End Set
    End Property

    Private Sub cbometodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboevento.SelectedIndexChanged
        Dim oxml As Nodo
        Dim oparams As Nodo
        Dim cparams As Collection
        Dim icounter As Integer

        If cboevento.SelectedIndex < 0 Then Exit Sub
        If Me.cdsincronia.Equals("") Then
            tabejecucion.Enabled = False
            tabpersistencia.Enabled = False
        Else
            tabejecucion.Enabled = True
            tabpersistencia.Enabled = True
        End If

        Try
            'PASO 1: Realiza la consulta del metodo
            oevento = obus.getPantallaEvento(Me.cdproject, Me.cdpantalla, outil.Toma_Token(1, Me.cboevento.SelectedItem, "-"))
            oevesinc = obus.getSincroniaEvento(Me.cdsincronia, Me.cdproject, Me.cdpantalla, outil.Toma_Token(1, Me.cboevento.SelectedItem, "-"))
            If oevento Is Nothing Then Exit Sub
            If oevesinc Is Nothing Then oevesinc = New SincroniaEvento()

            'PASO 2: Asigna los valores
            txtClave.Text = oevento.cdevento
            txtNombre.Text = oevento.nbevento
            txtcomment.Text = oevento.txcomment
            cbotipo.SelectedIndex = cbotipo.FindString(oevento.cdtpevento)

            'PASO 3: Lee la configuración de sincronización
            If oevesinc.xmlevento.Equals("") Then Exit Sub
            oxml = New Nodo(oevesinc.xmlevento)

            'PASO 4: Asigna los valores de HTML
            radserver.Checked = IIf(oxml.getValue("evehtml.exeservidor").Equals("Si"), True, False)
            radsrvbrow.Checked = IIf(oxml.getValue("evehtml.exesrvbrow").Equals("Si"), True, False)
            radbrowser.Checked = IIf(oxml.getValue("evehtml.exebrowser").Equals("Si"), True, False)

            If radsrvbrow.Checked Then
                cbojavascript.SelectedIndex = cbojavascript.FindString(oxml.getValue("evehtml.funjavascript"))
                If cbojavascript.SelectedIndex = -1 Then cbojavascript.Text = oxml.getValue("evehtml.funjavascript")
                chkvalidar.Checked = IIf(oxml.getValue("evehtml.valjavascript").Equals("Si"), True, False)
                Me.cbonavegara.SelectedIndex = cbonavegara.FindString(oxml.getValue("evehtml.navegar.navtarget"))
            End If

            If radbrowser.Checked Then
                cbojavascript2.SelectedIndex = cbojavascript2.FindString(oxml.getValue("evehtml.funjavascript"))
                If cbojavascript2.SelectedIndex = -1 Then cbojavascript2.Text = oxml.getValue("evehtml.funjavascript")
                chkvalidar2.Checked = IIf(oxml.getValue("evehtml.valjavascript").Equals("Si"), True, False)
                Me.cbonavegara2.SelectedIndex = cbonavegara2.FindString(oxml.getValue("evehtml.navegar.navtarget"))
            End If

            txtevento.Text = oxml.getValue("evehtml.srvevento")
            chkvalidar.Checked = IIf(oxml.getValue("evehtml.valjavascript").Equals("Si"), True, False)

            'PASO 5: Asigna los valores de OBJECT
            txtobjclase.Text = oxml.getValue("eveobject.nbclase")
            txtobjmethod.Text = oxml.getValue("eveobject.nbmethod")
            txtobjres.Text = oxml.getValue("eveobject.nbobjetores")
            If oxml.getValue("eveobject.tieneretorno").Equals("Si") Then bvalidretorno = True
            cbobjeto.SelectedIndex = cbobjeto.FindString(oxml.getValue("eveobject.nbobjetomet"))

            'PASO 6: Asigna los parámetros de la llamada al método
            icounter = 1
            oparams = oxml.getPrimerNodo("eveobject.eveparams")
            If oparams Is Nothing Then Exit Sub
            cparams = oparams.getNodo("eveparam")
            For Each onodo As Nodo In cparams
                grdparams.Rows.Add(icounter, onodo.getValue("eveparam.declara"), onodo.getValue("eveparam.valor"), onodo.getValue("eveparam.tipovalor"), onodo.getValue("eveparam.clasevalor"))
                icounter = icounter + 1
            Next
        Catch ex As HANYException
            ex.add("MyGENARO.frmPantallaEvento.cbometodo_SelectedIndexChanged()", "Ocurrio un error al leer la información de un evento")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub cmdgrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgrabar.Click
        Dim sxml As String
        Dim cpar As Collection

        'PASO 1: Inicializa los valores
        cpar = Leer_Parametros()

        'PASO 2: Valida los datos generales de los campos
        If Not Valida_DatosGenerales() Then Exit Sub

        'PASO 3: Asigna los valores al objeto
        Try
            oevento = New PantallaEvento
            oevesinc = New SincroniaEvento

            oevesinc.cdsincronia = Me.cdsincronia
            oevesinc.cdproyecto = Me.cdproject
            oevesinc.cdpantalla = Me.cdpantalla
            oevesinc.cdevento = outil.Toma_Token(1, Me.cboevento.SelectedItem, "-")
            oevento.cdproyecto = Me.cdproject
            oevento.cdpantalla = Me.cdpantalla
            oevento.cdevento = outil.Toma_Token(1, Me.cboevento.SelectedItem, "-")
            oevento.cdtpevento = outil.Toma_Token(1, Me.cbotipo.SelectedItem, "-")
            oevento.nbevento = Me.txtNombre.Text
            oevento.txcomment = Me.txtcomment.Text

            'PASO 3: Arma el XML con la configuración HTML
            sxml = "<evehtml>"
            sxml = sxml & "<exeservidor>" & IIf(radserver.Checked, "Si", "No") & "</exeservidor>"
            sxml = sxml & "<exesrvbrow>" & IIf(radsrvbrow.Checked, "Si", "No") & "</exesrvbrow>"
            sxml = sxml & "<exebrowser>" & IIf(radbrowser.Checked, "Si", "No") & "</exebrowser>"
            If radsrvbrow.Checked Then
                sxml = sxml & "<valjavascript>" & IIf(Me.chkvalidar.Checked, "Si", "No") & "</valjavascript>"
                sxml = sxml & "<funjavascript>" & outil.Toma_Token(1, Me.cbojavascript.Text, "-") & "</funjavascript>"
                sxml = sxml & "<navegara>" & IIf(Not Me.cbonavegara.Text.Equals(""), "Si", "No") & "</navegara>"
                sxml = sxml & "<srvevento>" & Me.txtevento.Text & "</srvevento>"
                If Not Me.cbonavegara.Text.Equals("") Then
                    Dim onav As Navegacion
                    Dim cpars As Collection
                    onav = obus.getNavegacion(Me.cdproject, Me.cdpantalla, outil.Toma_Token(1, Me.cbonavegara.Text, "-"))
                    cpars = obus.getNavegacionParams(Me.cdproject, Me.cdpantalla, outil.Toma_Token(1, Me.cbonavegara.Text, "-"))
                    sxml = sxml & "<navegar>"
                    sxml = sxml & "<navtarget>" & outil.Toma_Token(1, Me.cbonavegara.Text, "-") & "</navtarget>"
                    sxml = sxml & "<navtipo>" & onav.tpnavegacion & "</navtipo>"
                    sxml = sxml & "<navopenwin>" & IIf(onav.stopenwindow, "Si", "No") & "</navopenwin>"
                    sxml = sxml & "<navparams>"
                    For Each op As NavegacionParam In cpars
                        sxml = sxml & "<navparam>"
                        sxml = sxml & "<navparnombre>" & op.nbparam & "</navparnombre>"
                        sxml = sxml & "<navparvalor>" & op.txconstante & "</navparvalor>"
                        sxml = sxml & "</navparam>"
                    Next
                    sxml = sxml & "</navparams>"
                    sxml = sxml & "</navegar>"
                End If
            End If
            If radbrowser.Checked Then
                sxml = sxml & "<valjavascript>" & IIf(Me.chkvalidar2.Checked, "Si", "No") & "</valjavascript>"
                sxml = sxml & "<funjavascript>" & outil.Toma_Token(1, Me.cbojavascript2.Text, "-") & "</funjavascript>"
                sxml = sxml & "<navegara>" & IIf(Not Me.cbonavegara2.Text.Equals(""), "Si", "No") & "</navegara>"
                sxml = sxml & "<srvevento></srvevento>"
                If Not Me.cbonavegara2.Text.Equals("") Then
                    Dim onav As Navegacion
                    Dim cpars As Collection
                    onav = obus.getNavegacion(Me.cdproject, Me.cdpantalla, outil.Toma_Token(1, Me.cbonavegara2.Text, "-"))
                    cpars = obus.getNavegacionParams(Me.cdproject, Me.cdpantalla, outil.Toma_Token(1, Me.cbonavegara2.Text, "-"))
                    sxml = sxml & "<navegar>"
                    sxml = sxml & "<navtarget>" & outil.Toma_Token(1, Me.cbonavegara2.Text, "-") & "</navtarget>"
                    sxml = sxml & "<navtipo>" & onav.tpnavegacion & "</navtipo>"
                    sxml = sxml & "<navopenwin>" & IIf(onav.stopenwindow, "Si", "No") & "</navopenwin>"
                    sxml = sxml & "<navparams>"
                    For Each op As NavegacionParam In cpars
                        sxml = sxml & "<navparam>"
                        sxml = sxml & "<navparnombre>" & op.nbparam & "</navparnombre>"
                        sxml = sxml & "<navparvalor>" & op.txconstante & "</navparvalor>"
                        sxml = sxml & "</navparam>"
                    Next
                    sxml = sxml & "</navparams>"
                    sxml = sxml & "</navegar>"
                End If
            End If
            sxml = sxml & "</evehtml>"
            sxml = sxml & "<eveobject>"
            sxml = sxml & "<nbclase>" & Me.txtobjclase.Text.Trim & "</nbclase>"
            sxml = sxml & "<nbmethod>" & Me.txtobjmethod.Text.Trim & "</nbmethod>"
            sxml = sxml & "<nbobjetores>" & Me.txtobjres.Text.Trim & "</nbobjetores>"
            sxml = sxml & "<nbobjetomet>" & Me.cbobjeto.Text.Trim & "</nbobjetomet>"
            sxml = sxml & "<tieneretorno>" & IIf(bvalidretorno, "Si", "No") & "</tieneretorno>"
            sxml = sxml & "<eveparams>"
            For Each op As MetodoParametro In cpar
                sxml = sxml & "<eveparam>"
                sxml = sxml & "<declara>" & op.parametro & "</declara>"
                sxml = sxml & "<tienevalor>" & IIf(op.valor.Equals(""), "No", "Si") & "</tienevalor>"
                sxml = sxml & "<valor>" & op.valor & "</valor>"
                sxml = sxml & "<tipovalor>" & op.tipo & "</tipovalor>"
                sxml = sxml & "<clasevalor>" & op.clase & "</clasevalor>"
                sxml = sxml & "</eveparam>"
            Next
            sxml = sxml & "</eveparams>"
            sxml = sxml & "</eveobject>"
            oevesinc.xmlevento = sxml

            'PASO 4: Valida que no se repita la función de javascript y el evento en otra pantalla
            'Dim ceventos As Collection
            'ceventos = obus.getPantallaEventos(Me.cdproject, Me.cdpantalla)
            'For Each oeve As PantallaEvento In ceventos
            'If oeve.cdevento <> oevento.cdevento Then
            'Dim onodo As Nodo
            'onodo = New Nodo(oeve.xmlobject)
            'If Me.txtevento.Text.Trim.Equals(onodo.getValue("evento.nbevento")) Then
            'MsgBox("Ya existe un evento registrado con ese mismo nombre en pantalla", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
            'Exit Sub
            'End If
            'If Me.txtjavascript.Text.Trim.Equals(onodo.getValue("evento.javascript")) Then
            'MsgBox("Ya existe un evento registrado con esa misma función javascript en pantalla", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
            'Exit Sub
            'End If
            'End If
            'Next

            'PASO 5: graba la información del metodo
            obus.savePantallaEvento(oevento)
            If Not oevesinc.cdsincronia.Equals("") Then obus.saveSincroniaEvento(oevesinc)
            MsgBox("La información del evento fué grabada exitosamente", MsgBoxStyle.Information, "HANYGEN SOFTWARE")

        Catch ex As HANYException
            ex.add("MyGENARO.frmPantallaEvento.cmdgrabar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    ''' <summary>
    ''' Valida los datos generales de la forma
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Private Function Valida_DatosGenerales() As Boolean
        If txtNombre.Text.Trim.Equals("") Then
            MsgBox("Es necesario que ingrese el nombre del evento", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Return False
        End If
        If cbotipo.SelectedIndex = -1 Then
            MsgBox("Es necesario que seleccionar un tipo de evento", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Return False
        End If

        If radsrvbrow.Checked Then
            If cbojavascript.Text.Equals("") Then
                MsgBox("Es necesario que seleccionar una función javascript", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                Return False
            End If
            If txtevento.Text.Trim.Equals("") Then
                MsgBox("Es necesario que se ingrese el nombre del evento en el servidor", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                Return False
            End If
        End If

        If radbrowser.Checked Then
            If cbojavascript2.Text.Equals("") Then
                MsgBox("Es necesario que seleccionar una función javascript", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                Return False
            End If
        End If

        Return True
    End Function

    ''' <summary>
    ''' Función para leer los parámetros del método
    ''' </summary>
    ''' <remarks></remarks>
    Private Function Leer_Parametros() As Collection
        Dim iren As Integer
        Dim cpars As Collection

        'PASO 1: Inicializa...
        cpars = New Collection

        'PASO 2: Lee aquellos objetos automáticos
        For iren = 0 To grdparams.Rows.Count - 1
            Dim obj As MetodoParametro
            obj = New MetodoParametro()
            obj.parametro = grdparams.Item("param", iren).Value
            obj.valor = grdparams.Item("valor", iren).Value
            obj.tipo = grdparams.Item("tipo", iren).Value
            obj.clase = grdparams.Item("clase", iren).Value
            If Not obj.parametro.Equals("") Then cpars.Add(obj)
        Next iren

        'PASO 3: Termina
        Return cpars
    End Function

    Private Sub frmPantallaEvento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ctipocampos As Collection
        Dim cmetobjects As Collection
        Dim ctipos As Collection

        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            outil = New Utilerias
            omdipa = Me.ParentForm
            obus = New Catalogos(omdipa.conexion)
            oproject = obus.getProyecto(Me.cdproject)
            opantalla = obus.getPantalla(Me.cdproject, Me.cdpantalla)
            cmetobjects = obus.getPantallaEventos(Me.cdproject, Me.cdpantalla)
            ctipocampos = obus.getTpCampos()

            'PASO 2: Asígna los valores del proyecto
            txtcdproyecto.Text = oproject.cdproyecto
            txtnbproyecto.Text = oproject.nbproyecto
            txtcdpantalla.Text = opantalla.cdpantalla
            txtnbpantalla.Text = opantalla.nbpantalla

            'PASO 3: Llena el catálogo de metodos
            For Each om As PantallaEvento In cmetobjects
                Me.cboevento.Items.Add(om.cdevento & " - " & om.nbevento)
            Next

            'PASO 4: Llena el catálogo de tipos de evento
            ctipos = obus.getTpEventos()
            For Each otp As TpEvento In ctipos
                Me.cbotipo.Items.Add(otp.clave & " - " & otp.nombre)
            Next

            'PASO 5: Llena el catálogo de objetos
            Me.cbobjeto.Items.Add("")
            For Each obj As Variable In cObjetos
                Me.cbobjeto.Items.Add(obj.nombre)
            Next

            'PASO 6: Llena el catálogo de funciones
            Me.cbojavascript.Items.Add("")
            Me.cbojavascript2.Items.Add("")
            For Each sfun As String In Me.cFunsjavascript
                Me.cbojavascript.Items.Add(outil.RefillSpaces(sfun, 20) & "-se sustituye la actual!")
                Me.cbojavascript2.Items.Add(outil.RefillSpaces(sfun, 20) & "-se sustituye la actual!")
            Next

            'PASO 7: Llena el catálogo de navegación
            Me.cbonavegara.Items.Add("")
            Me.cbonavegara2.Items.Add("")
            For Each oNav As Navegacion In Me.cNavegacion
                Dim opant As Pantalla
                opant = obus.getPantalla(Me.cdproject, oNav.cdhasta)
                Me.cbonavegara.Items.Add(oNav.cdhasta & " - " & opant.nbpantalla)
                Me.cbonavegara2.Items.Add(oNav.cdhasta & " - " & opant.nbpantalla)
            Next

            'PASO 8: Configura los parámetros
            grdparams.Rows.Clear()
            grdparams.Columns.Clear()
            grdparams.Columns.Add("num", "#")
            grdparams.Columns.Add("param", "Parámetro")
            grdparams.Columns.Add("valor", "valor")
            grdparams.Columns.Add("tipo", "tipo")
            grdparams.Columns.Add("clase", "clase")
            grdparams.Columns.Item("num").Width = 30
            grdparams.Columns.Item("param").Width = 250
            grdparams.Columns.Item("valor").Width = 60
            grdparams.Columns.Item("tipo").Width = 60
            grdparams.Columns.Item("clase").Width = 60

            'PASO 9: En caso de traer información del evento
            If Not Me.cdmetobject.Equals("") Then Me.cboevento.SelectedIndex = cboevento.FindString(Me.cdmetobject)
        Catch ex As HANYException
            ex.add("MyGENARO.frmPantallaEvento.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub picobjclase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjclase.Click
        Dim sresult As String
        Dim sclases As String

        'PASO 1: inicializa los valores
        sclases = ""

        'PASO 2: recorre el arreglo de clases
        For Each oc As Clase In cClases
            sclases = outil.Anade_Token(sclases, oc.name, "|")
        Next

        'PASO 3: Muestra las opciones
        sresult = outil.SelectOne(sclases)
        If sresult.Equals("CANCEL") Then Exit Sub
        txtobjclase.Text = outil.Toma_Token(1, sresult, "|")
    End Sub

    Private Sub picobjclasedel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjclasedel.Click
        txtobjclase.Text = ""
        txtobjmethod.Text = ""
    End Sub

    Private Sub picobjmethod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjmethod.Click
        Dim sresult As String
        Dim sparams As String
        Dim cparams As Collection
        Dim ipos As Integer

        'PASO 1: inicializa los valores
        grdparams.Rows.Clear()
        If Me.txtobjclase.Text.Equals("") Then
            MsgBox("Es necesario que primero seleccione la clase de donde sacará el dato", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        'PASO 2: Muestra las opciones
        sresult = outil.SelectOne(Selecciona_Methods(txtobjclase.Text))
        If sresult.Equals("CANCEL") Then Exit Sub
        txtobjmethod.Text = outil.Toma_Token(1, sresult, "|")
        If outil.Toma_Token(3, sresult, "|").Trim.Equals("RETURN") Then bvalidretorno = True

        'PASO 3: Substrae los parámetros
        ipos = 1
        sparams = outil.getStrBetween(outil.Toma_Token(2, sresult, "|"), "(", ")")
        cparams = outil.CAparta_Tokens(sparams, ",")
        For Each spar As String In cparams
            grdparams.Rows.Add(ipos, spar, "", "")
            ipos = ipos + 1
        Next
    End Sub

    Private Sub picobjmethoddel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjmethoddel.Click
        txtobjmethod.Text = ""
    End Sub

    Private Sub picobjres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjres.Click
        Dim sresult As String
        sresult = outil.SelectOne(Me.Selecciona_Objetos() & "|" & Selecciona_Variables())
        If sresult.Equals("CANCEL") Then Exit Sub
        txtobjres.Text = outil.Toma_Token(1, sresult, "|")
    End Sub

    Private Sub picobjresdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjresdel.Click
        txtobjres.Text = ""
    End Sub

    Private Sub chkservidor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim snombre As String
        snombre = txtNombre.Text.Replace(" ", "-")
        'rmt        lblevento.Enabled = chkservidor.Checked
        'rmt        txtevento.Enabled = chkservidor.Checked
        'rmt        txtevento.Text = IIf(Me.chkservidor.Checked, outil.Toma_Token(1, snombre, "-"), "")
    End Sub

    Private Sub radbrowser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radsrvbrow.CheckedChanged
        grpsrvbrow.Enabled = True
        grpbrowser.Enabled = False
        IniCtrlsEjecucion()
    End Sub

    Private Sub radserver_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radserver.CheckedChanged
        grpsrvbrow.Enabled = False
        grpbrowser.Enabled = False
        Call IniCtrlsEjecucion()
    End Sub

    Private Sub radbrowser_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbrowser.CheckedChanged
        grpsrvbrow.Enabled = False
        grpbrowser.Enabled = True
        Call IniCtrlsEjecucion()
    End Sub

    Private Sub IniCtrlsEjecucion()
        If Not grpsrvbrow.Enabled Then
            chkvalidar.Checked = False
            cbojavascript.SelectedIndex = -1
            cbonavegara.SelectedIndex = -1
            txtevento.Text = ""
        End If

        If Not grpbrowser.Enabled Then
            cbojavascript2.SelectedIndex = -1
            cbonavegara2.SelectedIndex = -1
            chkvalidar2.Checked = False

            txtobjclase.Text = ""
            txtobjmethod.Text = ""
            txtobjres.Text = ""
            cbobjeto.SelectedIndex = -1
            grdparams.Rows.Clear()
        End If
    End Sub

    Private Sub btnparamvalor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnparamvalor.Click
        Dim sresult As String

        If Me.grdparams.SelectedRows.Count > 0 Then
            sresult = SelectOneValor(Me.grdparams.SelectedRows.Item(0).Cells("valor").Value, Me.Clases, Me.Variables, Me.Objetos, Me.HtmlInputs)
            If sresult.Equals("CANCEL") Then Exit Sub
            Me.grdparams.SelectedRows.Item(0).Cells("valor").Value = outil.Toma_Token(1, sresult, "|")
            Me.grdparams.SelectedRows.Item(0).Cells("tipo").Value = outil.Toma_Token(2, sresult, "|")
            Me.grdparams.SelectedRows.Item(0).Cells("clase").Value = outil.Toma_Token(3, sresult, "|")
        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub

    ''' <summary>
    ''' Función para seleccionar los metodos que participan en un objeto
    ''' </summary>
    ''' <param name="sclase"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Selecciona_Methods(ByVal sclase As String) As String
        Dim smethods As String = ""

        For Each oc As Clase In cClases
            If oc.name.Equals(sclase) Then
                For Each om As Metodo In oc.methods
                    If om.ispublico() Then smethods = outil.Anade_Token(smethods, om.nombre & " - " & om.declaracion & " - " & IIf(om.hasretorno, "RETURN", "NADA"), "|")
                Next
            End If
        Next
        Return smethods
    End Function

    ''' <summary>
    ''' Función para seleccionar entre los nombres de objetos
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Private Function Selecciona_Objetos() As String
        Dim sobjetos As String = ""
        For Each obj As Variable In cObjetos
            sobjetos = outil.Anade_Token(sobjetos, obj.nombre & "-" & obj.tipo, "|")
        Next
        Return sobjetos
    End Function

    ''' <summary>
    ''' Function para regresar todas las variables
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Private Function Selecciona_Variables() As String
        Dim svars As String = ""
        For Each obj As Variable In cVariables
            svars = outil.Anade_Token(svars, obj.nombre & "-" & obj.tipo, "|")
        Next
        Return svars
    End Function

    ''' <summary>
    ''' Procedimiento para seleccionar un valor en particular
    ''' </summary>
    ''' <param name="sactual"></param>
    ''' <param name="cclass"></param>
    ''' <param name="cvars"></param>
    ''' <param name="cobjs"></param>
    ''' <param name="chtml"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function SelectOneValor(ByVal sactual As String, ByRef cclass As Collection, ByRef cvars As Collection, ByRef cobjs As Collection, ByRef chtml As Collection) As String
        Dim ofrm As frmFrontSyncValor

        ofrm = New frmFrontSyncValor()
        ofrm.txtactual.Text = sactual
        ofrm.Clases = cclass
        ofrm.Variables = cvars
        ofrm.Objetos = cobjs
        ofrm.HtmlInputs = chtml
        ofrm.ShowDialog()
        If ofrm.result.Equals("CANCEL") Then Return "CANCEL"
        Return ofrm.result & "|" & ofrm.tipo & "|" & ofrm.clase
    End Function

End Class