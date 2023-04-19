Option Explicit On

Imports MyLIB

Public Class frmPantallaCampo1
    Private obus As Catalogos
    Private scdproject As String = ""   'Clave del proyecto
    Private scdpantalla As String = ""  'Clave de la pantalla
    Private scdcampo As String = ""     'Clave del campo
    Private scdsincronia As String = "" 'Clave de la sincronia
    Private oproject As Proyecto        'Objeto que tiene las propiedades del proyecto
    Private opantalla As Pantalla       'Objeto que tiene las propiedades de la pantalla
    Private ocampo As PantallaCampo             'Objeto que tiene las propiedades y metodos de un campo
    Private ocamposinc As SincroniaCampo        'Objeto que tiene la información de sincronización para un campo
    Private outil As Utilerias
    Private omdipa As MDIGenaro
    Private cClases As Collection = New Collection     'Colección de clases
    Private cVariables As Collection = New Collection     'Colección de variables

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
    Public Property cdcampo() As String
        Get
            Return scdcampo
        End Get
        Set(ByVal pscd As String)
            scdcampo = pscd
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
    ''' PROPIEDAD: Listado de Variables
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

    Private Sub frmFrontsyncinput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ctipocampos As Collection
        Dim ccampos As Collection
        Dim carreglos As Collection

        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            outil = New Utilerias
            omdipa = Me.ParentForm
            obus = New Catalogos(omdipa.conexion)
            oproject = obus.getProyecto(Me.cdproject)
            opantalla = obus.getPantalla(Me.cdproject, Me.cdpantalla)
            ccampos = obus.getPantallaCampos(Me.cdproject, Me.cdpantalla)
            carreglos = obus.getPantallarreglos(Me.cdproject, Me.cdpantalla)
            ctipocampos = obus.getTpCampos()

            'PASO 2: Asígna los valores del proyecto
            txtcdproyecto.Text = oproject.cdproyecto
            txtnbproyecto.Text = oproject.nbproyecto
            txtcdpantalla.Text = opantalla.cdpantalla
            txtnbpantalla.Text = opantalla.nbpantalla

            'PASO 3: Llena el catálogo de campos
            For Each oc As PantallaCampo In ccampos
                Me.cbocampo.Items.Add(oc.cdcampo & " - " & oc.nbcampo)
            Next

            'PASO 4: Llena el catálogo de tipos de campo
            For Each ost As Estatus In ctipocampos
                Me.cbotipo.Items.Add(ost.clave & " - " & ost.nombre)
            Next

            'PASO 5: Llena el catálogo de arreglos
            Me.cboarreglo.Items.Add("")
            For Each oarr As Pantallarreglo In carreglos
                Me.cboarreglo.Items.Add(oarr.cdarreglo & " - " & oarr.nbarreglo)
            Next

            'PASO 5: En caso de traer información del campo
            If Not Me.cdcampo.Equals("") Then Me.cbocampo.SelectedIndex = cbocampo.FindString(Me.cdcampo)

        Catch ex As HANYException
            ex.add("MyGENARO.frmPantallaCampo.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub cbocampo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbocampo.SelectedIndexChanged
        Dim oxml As Nodo

        If Me.cdsincronia.Equals("") Then
            tabhtml.Enabled = False
            tabclasobj.Enabled = False
        Else
            tabhtml.Enabled = True
            tabclasobj.Enabled = True
        End If

        Try
            If cbocampo.SelectedIndex < 0 Then Exit Sub

            'PASO 1: Realiza la consulta del campo
            ocampo = obus.getPantallaCampo(Me.cdproject, Me.cdpantalla, outil.Toma_Token(1, cbocampo.SelectedItem, "-"))
            ocamposinc = obus.getSincroniaCampo(Me.cdsincronia, Me.cdproject, Me.cdpantalla, outil.Toma_Token(1, cbocampo.SelectedItem, "-"))
            If ocampo Is Nothing Then Exit Sub
            If ocamposinc Is Nothing Then ocamposinc = New SincroniaCampo()

            'PASO 2: Asigna los valores
            txtNombre.Text = ocampo.nbcampo
            cbotipo.SelectedIndex = cbotipo.FindString(ocampo.cdtpcampo)
            txtlongitud.Text = ocampo.nulongitud
            txtdecimales.Text = ocampo.nudecimales
            txtcomment.Text = ocampo.txcomment
            radinput.Checked = IIf(ocampo.tpinoutput.Equals(Comun.TIPO_CAMPO_INPUT), True, False)
            radoutput.Checked = IIf(ocampo.tpinoutput.Equals(Comun.TIPO_CAMPO_OUTPUT), True, False)
            cboarreglo.SelectedIndex = cboarreglo.FindString(ocampo.cdarreglo)

            'PASO 3: Lee la configuración de sincronización
            oxml = IIf(ocamposinc.xmlcampo.Equals(""), New Nodo(), New Nodo(ocamposinc.xmlcampo))

            'PASO 4: Asigna los valores de HTML
            chkrequerido.Checked = IIf(oxml.getValue("html.requerido").Equals("Si"), True, False)
            txtmsgrequerido.Text = oxml.getValue("html.msgrequerido")
            chkvalposiciones.Checked = IIf(oxml.getValue("html.validposiciones").Equals("Si"), True, False)
            txtmsgvalposiciones.Text = oxml.getValue("html.msgvalidposiciones")
            chkvalmayora0.Checked = IIf(oxml.getValue("html.validmayor0").Equals("Si"), True, False)
            txtmsgvalmayora0.Text = oxml.getValue("html.msgvalidmayor0")
            chkforzmayusculas.Checked = IIf(oxml.getValue("html.forzarmayuscula").Equals("Si"), True, False)
            chkforzminusculas.Checked = IIf(oxml.getValue("html.forzarminuscula").Equals("Si"), True, False)
            chktratallave.Checked = IIf(oxml.getValue("html.tratallave").Equals("Si"), True, False)

            'PASO 5: Asigna los valores de Object
            txtobjclase.Text = oxml.getValue("object.nbclase")
            txtobjmethodget.Text = oxml.getValue("object.nbmethodget")
            txtobjmethodset.Text = oxml.getValue("object.nbmethodset")
            txtobjobj.Text = oxml.getValue("object.nbobjeto")

            'PASO 6: Si se trata de un combo, lee los valores del llenado
            Me.txtobjllenaclase.Text = oxml.getValue("objectlist.nbclase")
            Me.txtobjllenamethodcve.Text = oxml.getValue("objectlist.nbmethodcve")
            Me.txtobjllenamethodnom.Text = oxml.getValue("objectlist.nbmethodnom")
            Me.txtobjllena.Text = oxml.getValue("objectlist.nbobjeto")

            'PASO 7: Habilita/Deshabilita los objetos de pantalla
            Call Habilita_SegunIO()

            'PASO 8: Habilita/Deshabilita la selección de un objeto en pantalla
            If cboarreglo.SelectedIndex > 0 Then
                'PASO 8.1: Si hay una sincronización, busco la sincronia del arreglo
                If Not Me.cdsincronia.Equals("") Then
                    Dim osinc As SincroniArreglo
                    osinc = obus.getSincroniArreglo(Me.cdsincronia, Me.cdproject, Me.cdpantalla, outil.Toma_Token(1, Me.cboarreglo.SelectedItem, "-"))
                    If osinc Is Nothing Then Exit Sub
                    Me.txtobjobj.Text = osinc.nbelement
                End If
                picobjobj.Visible = False
                picobjobjdel.Visible = False
            Else
                picobjobj.Visible = True
                picobjobjdel.Visible = True
            End If

        Catch ex As HANYException
            ex.add("MyGENARO.frmPantallaCampo.cbocampo_SelectedIndexChanged()", "Ocurrio un error al Leer la información del campo")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub Habilita_SegunIO()
        If radinput.Checked Then
            grpjavascript.Enabled = True
            grpcombo.Enabled = True
            picobjmethodset.Visible = True
            picobjmethodsetdel.Visible = True
        End If
        If radoutput.Checked Then
            grpjavascript.Enabled = False
            grpcombo.Enabled = False
            picobjmethodset.Visible = False
            picobjmethodsetdel.Visible = False
        End If
    End Sub

    Private Sub cmdgrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgrabar.Click
        Dim sxml As String

        'PASO 1: Valida los datos generales de los campos
        If Me.txtNombre.Text.Trim.Equals("") Then
            MsgBox("Es necesario que ingrese el nombre del campo", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        If Me.cbotipo.SelectedIndex < 0 Then
            MsgBox("Es necesario que ingrese el tipo de campo", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        If Not IsNumeric(Me.txtlongitud.Text) Then
            MsgBox("Es necesario que la longitud sea un numero entero", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        If Not IsNumeric(Me.txtdecimales.Text) Then
            MsgBox("Es necesario que los decimales sea un numero entero", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        'PASO 2: Asigna los valores al objeto
        ocampo = New PantallaCampo
        ocamposinc = New SincroniaCampo

        ocamposinc.cdsincronia = Me.cdsincronia
        ocamposinc.cdproyecto = Me.cdproject
        ocamposinc.cdpantalla = Me.cdpantalla
        ocamposinc.cdcampo = outil.Toma_Token(1, Me.cbocampo.SelectedItem, "-")
        ocamposinc.nbidhtml = Me.txtidhtml.Text

        ocampo.cdproyecto = Me.cdproject
        ocampo.cdpantalla = Me.cdpantalla
        ocampo.cdcampo = outil.Toma_Token(1, Me.cbocampo.SelectedItem, "-")
        ocampo.nulongitud = Me.txtlongitud.Text
        ocampo.nudecimales = Me.txtdecimales.Text
        ocampo.cdtpcampo = outil.Toma_Token(1, Me.cbotipo.SelectedItem, "-")
        ocampo.tpinoutput = IIf(radinput.Checked, Comun.TIPO_CAMPO_INPUT, Comun.TIPO_CAMPO_OUTPUT)
        ocampo.nbcampo = Me.txtNombre.Text
        ocampo.txcomment = Me.txtcomment.Text
        ocampo.cdarreglo = outil.Toma_Token(1, Me.cboarreglo.SelectedItem, "-")

        'PASO 3: Arma el XML con la configuración HTML
        Try
            sxml = "<html>"
            sxml = sxml & "<idhtml>" & Me.txtidhtml.Text.Trim & "</idhtml>"
            sxml = sxml & "<nbhtml>" & Me.txtnbhtml.Text.Trim & "</nbhtml>"
            sxml = sxml & "<taghtml>" & Me.txttaghtml.Text.Trim & "</taghtml>"
            sxml = sxml & "<tphtml>" & Me.txttphtml.Text.Trim & "</tphtml>"
            sxml = sxml & "<requerido>" & IIf(Me.chkrequerido.Checked, "Si", "No") & "</requerido>"
            sxml = sxml & "<msgrequerido>" & Me.txtmsgrequerido.Text.Trim & "</msgrequerido>"
            sxml = sxml & "<validposiciones>" & IIf(Me.chkvalposiciones.Checked, "Si", "No") & "</validposiciones>"
            sxml = sxml & "<msgvalidposiciones>" & Me.txtmsgvalposiciones.Text.Trim & "</msgvalidposiciones>"
            sxml = sxml & "<validmayor0>" & IIf(Me.chkvalmayora0.Checked, "Si", "No") & "</validmayor0>"
            sxml = sxml & "<msgvalidmayor0>" & Me.txtmsgvalmayora0.Text.Trim & "</msgvalidmayor0>"
            sxml = sxml & "<forzarmayuscula>" & IIf(Me.chkforzmayusculas.Checked, "Si", "No") & "</forzarmayuscula>"
            sxml = sxml & "<forzarminuscula>" & IIf(Me.chkforzminusculas.Checked, "Si", "No") & "</forzarminuscula>"
            sxml = sxml & "<tratallave>" & IIf(Me.chktratallave.Checked, "Si", "No") & "</tratallave>"
            sxml = sxml & "</html>"
            sxml = sxml & "<object>"
            sxml = sxml & "<nbclase>" & Me.txtobjclase.Text.Trim & "</nbclase>"
            sxml = sxml & "<nbmethodget>" & Me.txtobjmethodget.Text.Trim & "</nbmethodget>"
            sxml = sxml & "<nbmethodset>" & Me.txtobjmethodset.Text.Trim & "</nbmethodset>"
            sxml = sxml & "<nbobjeto>" & Me.txtobjobj.Text.Trim & "</nbobjeto>"
            sxml = sxml & "</object>"
            sxml = sxml & "<objectlist>"
            sxml = sxml & "<nbclase>" & Me.txtobjllenaclase.Text.Trim & "</nbclase>"
            sxml = sxml & "<nbmethodcve>" & Me.txtobjllenamethodcve.Text.Trim & "</nbmethodcve>"
            sxml = sxml & "<nbmethodnom>" & Me.txtobjllenamethodnom.Text.Trim & "</nbmethodnom>"
            sxml = sxml & "<nbobjeto>" & Me.txtobjllena.Text.Trim & "</nbobjeto>"
            sxml = sxml & "</objectlist>"

            ocamposinc.xmlcampo = sxml

            'PASO 4: graba la información de la pantalla
            obus.savePantallaCampo(ocampo)
            If Not ocamposinc.cdsincronia.Equals("") Then obus.saveSincroniaCampo(ocamposinc)
            MsgBox("La información del campo fué grabada exitosamente", MsgBoxStyle.Information, "HANYGEN SOFTWARE")

        Catch ex As HANYException
            ex.add("MyGENARO.frmPantallaCampo.cmdgrabar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub chkrequerido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkrequerido.CheckedChanged
        txtmsgrequerido.Enabled = chkrequerido.Checked
        txtmsgrequerido.Text = IIf(txtmsgrequerido.Enabled, "Es necesario ingresar un valor al campo " & Me.txtNombre.Text.Trim & "!", "")
    End Sub

    Private Sub chkvalposiciones_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkvalposiciones.CheckedChanged
        txtmsgvalposiciones.Enabled = chkvalposiciones.Checked
        txtmsgvalposiciones.Text = IIf(txtmsgvalposiciones.Enabled, "Es obligatorio que el campo " & Me.txtNombre.Text.Trim & " sea de " & Me.txtlongitud.Text & " caracteres !", "")
    End Sub

    Private Sub chkvalmayora0_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkvalmayora0.CheckedChanged
        txtmsgvalmayora0.Enabled = chkvalmayora0.Checked
        txtmsgvalmayora0.Text = IIf(txtmsgvalmayora0.Enabled, "Es obligatorio que el campo " & Me.txtNombre.Text.Trim & " sea mayor a zero !", "")
    End Sub

    Private Sub picobjclase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjclase.Click
        Dim sclases As String
        Dim sresult As String

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

    Private Sub picobjmethodget_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjmethodget.Click
        Dim sresult As String

        'PASO 1: inicializa los valores
        If Me.txtobjclase.Text.Equals("") Then
            MsgBox("Es necesario que primero seleccione la clase de donde sacará el dato", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        'PASO 2: Muestra las opciones
        sresult = outil.SelectOne(Selecciona_Methods(Me.txtobjclase.Text))
        If sresult.Equals("CANCEL") Then Exit Sub
        txtobjmethodget.Text = outil.Toma_Token(1, sresult, "|")
    End Sub

    Private Sub picobjmethodset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjmethodset.Click
        Dim sresult As String

        'PASO 1: inicializa los valores
        If Me.txtobjclase.Text.Equals("") Then
            MsgBox("Es necesario que primero seleccione la clase de donde sacará el dato", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        'PASO 2: Muestra las opciones
        sresult = outil.SelectOne(Selecciona_Methods(Me.txtobjclase.Text))
        If sresult.Equals("CANCEL") Then Exit Sub
        txtobjmethodset.Text = outil.Toma_Token(1, sresult, "|")
    End Sub

    Private Sub btnversync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As frmXMLTree
        ofrm = New frmXMLTree

        'PASO 1: valida que el objeto tenga información
        If ocampo Is Nothing Then Exit Sub

        'PASO 2: Asigna valores e inicializa info
        'RMT ofrm.xml = ocampo.xmlhtml
        ofrm.Text = "Información de la sincronización del campo [" & ocampo.nbcampo & "]"
        ofrm.MdiParent = Me.ParentForm
        ofrm.Show()
    End Sub

    Private Sub picdelclase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picdelclase.Click
        txtobjclase.Text = ""
        txtobjmethodget.Text = ""
        txtobjmethodset.Text = ""
        txtobjllenamethodcve.Text = ""
        txtobjllenamethodnom.Text = ""
    End Sub

    Private Sub picobjmethodgetdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjmethodgetdel.Click
        txtobjmethodget.Text = ""
    End Sub

    Private Sub picobjmethodsetdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjmethodsetdel.Click
        txtobjmethodset.Text = ""
    End Sub

    Private Sub picobjobjdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjobjdel.Click
        txtobjobj.Text = ""
    End Sub

    Private Sub picobjobj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjobj.Click
        Dim sresult As String

        'PASO 1: Muestra las opciones
        sresult = outil.SelectOne(Selecciona_Variables())
        If sresult.Equals("CANCEL") Then Exit Sub
        txtobjobj.Text = outil.Toma_Token(1, sresult, "|")
    End Sub

    Private Function Selecciona_Methods(ByVal sclase As String) As String
        Dim smethods As String = ""

        For Each oc As Clase In cClases
            If oc.name.Equals(sclase) Then
                For Each om As Metodo In oc.methods
                    If om.ispublico() Then smethods = outil.Anade_Token(smethods, om.nombre & "-" & om.declaracion, "|")
                Next
            End If
        Next
        Return smethods
    End Function

    Private Function Selecciona_Variables() As String
        Dim sobjetos As String = ""

        For Each ov As Variable In cVariables
            sobjetos = outil.Anade_Token(sobjetos, ov.nombre, "|")
        Next
        Return sobjetos
    End Function

    Private Sub picobjllenaclasedel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjllenaclasedel.Click
        txtobjllenaclase.Text = ""
    End Sub

    Private Sub txtobjllenadel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtobjllenadel.Click
        txtobjllena.Text = ""
    End Sub

    Private Sub picobjllenaclase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjllenaclase.Click
        Dim sclases As String
        Dim sresult As String

        'PASO 1: inicializa los valores
        sclases = ""

        'PASO 2: recorre el arreglo de clases
        For Each oc As Clase In cClases
            sclases = outil.Anade_Token(sclases, oc.name, "|")
        Next

        'PASO 3: Muestra las opciones
        sresult = outil.SelectOne(sclases)
        If sresult.Equals("CANCEL") Then Exit Sub
        txtobjllenaclase.Text = outil.Toma_Token(1, sresult, "|")
    End Sub

    Private Sub picobjllena_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjllena.Click
        Dim sresult As String

        'PASO 1: Muestra las opciones
        sresult = outil.SelectOne(Selecciona_Variables())
        If sresult.Equals("CANCEL") Then Exit Sub
        txtobjllena.Text = outil.Toma_Token(1, sresult, "|")
    End Sub

    Private Sub picobjllenamethoddel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjllenamethoddel.Click
        txtobjllenamethodnom.Text = ""
    End Sub

    Private Sub picobjllenamethodcvedel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjllenamethodcvedel.Click
        txtobjllenamethodcve.Text = ""
    End Sub

    Private Sub picobjllenamethodcve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjllenamethodcve.Click
        Dim sresult As String

        'PASO 1: inicializa los valores
        If Me.txtobjllenaclase.Text.Equals("") Then
            MsgBox("Es necesario que primero seleccione la clase de donde sacará el dato", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        'PASO 2: Muestra las opciones
        sresult = outil.SelectOne(Selecciona_Methods(Me.txtobjllenaclase.Text))
        If sresult.Equals("CANCEL") Then Exit Sub
        txtobjllenamethodcve.Text = outil.Toma_Token(1, sresult, "|")
    End Sub

    Private Sub picobjllenamethodnom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjllenamethodnom.Click
        Dim sresult As String

        'PASO 1: inicializa los valores
        If Me.txtobjllenaclase.Text.Equals("") Then
            MsgBox("Es necesario que primero seleccione la clase de donde sacará el dato", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        'PASO 2: Muestra las opciones
        sresult = outil.SelectOne(Selecciona_Methods(Me.txtobjllenaclase.Text))
        If sresult.Equals("CANCEL") Then Exit Sub
        txtobjllenamethodnom.Text = outil.Toma_Token(1, sresult, "|")
    End Sub

    Private Sub cboarreglo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboarreglo.SelectedIndexChanged

        'PASO 1: Inicializo el nombre del objeto
        txtobjobj.Text = ""

        'PASO 2: Si ha seleccionado un arreglo, deshabilito el tomar un objeto 
        If cboarreglo.SelectedIndex > 0 Then
            'PASO 3: Si hay una sincronización, busco la sincronia del arreglo
            If Not Me.cdsincronia.Equals("") Then
                Dim osinc As SincroniArreglo
                osinc = obus.getSincroniArreglo(Me.cdsincronia, Me.cdproject, Me.cdpantalla, outil.Toma_Token(1, Me.cboarreglo.SelectedItem, "-"))
                If osinc Is Nothing Then Exit Sub
                Me.txtobjobj.Text = osinc.nbelement
            End If
            picobjobj.Visible = False
            picobjobjdel.Visible = False
        Else
            picobjobj.Visible = True
            picobjobjdel.Visible = True
        End If

    End Sub

    Private Sub radinput_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radinput.CheckedChanged
        Call Habilita_SegunIO()
    End Sub

    Private Sub radoutput_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radoutput.CheckedChanged
        Call Habilita_SegunIO()
    End Sub
End Class