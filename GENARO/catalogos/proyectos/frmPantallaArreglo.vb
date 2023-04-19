Option Explicit On

Imports MyLIB

Public Class frmPantallaArreglo
    Private obus As Catalogos
    Private scdproject As String = ""   ' Clave del proyecto
    Private scdpantalla As String = ""  ' Clave de la pantalla
    Private scdarreglo As String = ""   ' Clave del arreglo
    Private oproject As Proyecto        ' Objeto que tiene las propiedades del proyecto
    Private opantalla As Pantalla       ' Objeto que tiene las propiedades de la pantalla
    Private oarreglo As Pantallarreglo  ' Objeto que tiene las propiedades y metodos de un arreglo
    Private outil As Utilerias          ' Utilerias del sistema
    Private scdsincronia As String = "" ' Clave de la sincronia
    Private cClases As Collection = New Collection        ' Colección de clases
    Private cVariables As Collection = New Collection     ' Colección de variables
    Private cHTMLRows As Collection = New Collection      ' Colección de renglones HTML

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
    ''' PROPIEDAD: Clave del arreglo
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdarreglo() As String
        Get
            Return scdarreglo
        End Get
        Set(ByVal pscd As String)
            scdarreglo = pscd
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

    ''' <summary>
    ''' PROPIEDAD: Colección de renglones HTML
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property HTMLRows() As Collection
        Get
            Return cHTMLRows
        End Get
        Set(ByVal obj As Collection)
            cHTMLRows = obj
        End Set
    End Property

    Private Sub frmPantallaArreglo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro
        Dim carreglos As Collection

        Try
            oparent = Me.ParentForm
            outil = New Utilerias

            'PASO 1: Incializa los objetos de negocio y utilerias
            obus = New Catalogos(oparent.conexion)
            oproject = obus.getProyecto(Me.cdproject)
            opantalla = obus.getPantalla(Me.cdproject, Me.cdpantalla)

            'PASO 2: Coloca los valores del proyecto y pantalla
            txtcdproyecto.Text = oproject.cdproyecto
            txtnbproyecto.Text = oproject.nbproyecto
            txtcdpantalla.Text = opantalla.cdpantalla
            txtnbpantalla.Text = opantalla.nbpantalla

            'PASO 3: consulta la información del arreglo
            Consulta_Arreglo()

            'PASO 5: Consulta todos los arreglos de la pantalla
            carreglos = obus.getPantallarreglos(Me.cdproject, Me.cdpantalla)
            For Each oarr As Pantallarreglo In carreglos
                cboarreglo.Items.Add(oarr.cdarreglo & " - " & oarr.nbarreglo)
            Next

            'PASO 6: Coloca todos los renglones de la pantalla
            cboidhtml.Items.Add("")
            For Each srow As String In Me.cHTMLRows
                cboidhtml.Items.Add(srow)
            Next

            'PASO 7: En caso de traer información del arreglo
            If Not Me.cdarreglo.Equals("") Then Me.cboarreglo.SelectedIndex = cboarreglo.FindString(Me.cdarreglo)

        Catch ex As HANYException
            ex.add("MyGENARO.frmPantallaArreglo.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub Consulta_Arreglo()
        Dim osincronia As SincroniArreglo
        Try
            'PASO 1: Consulta la información general del arreglo
            oarreglo = obus.getPantallarreglo(Me.cdproject, Me.cdpantalla, Me.cdarreglo)
            txtNombre.Text = oarreglo.nbarreglo
            txtregistros.Text = oarreglo.nurensxpagina
            chkpaginacion.Checked = IIf(oarreglo.haspaginacion(), True, False)

            'PASO 2: Consulta la sincronia del arreglo
            osincronia = obus.getSincroniArreglo(Me.cdsincronia, Me.cdproject, Me.cdpantalla, Me.cdarreglo)
            If Not osincronia Is Nothing Then
                txtnbElement.Text = osincronia.nbelement
            End If
        Catch ex As HANYException
            ex.add("MyGENARO.frmPantallaArreglo.Consulta_Arreglo()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmPantallaArreglo.Consulta_Arreglo()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
    End Sub

    Private Sub cboarreglo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboarreglo.SelectedIndexChanged
        Dim osincronia As SincroniArreglo
        Dim cinoutputs As Collection

        Try
            'PASO 1: Configura el arreglo
            grdinout.Rows.Clear()
            grdinout.Columns.Clear()
            grdinout.Columns.Add("clave", "Clave")
            grdinout.Columns.Add("nombre", "Nombre")
            grdinout.Columns.Add("tipo", "Tipo")
            grdinout.Columns.Item(0).Width = 50
            grdinout.Columns.Item(1).Width = 290
            grdinout.Columns.Item(2).Width = 50

            'PASO 1: Consulta los datos del arreglo
            oarreglo = obus.getPantallarreglo(Me.cdproject, Me.cdpantalla, outil.Toma_Token(1, cboarreglo.SelectedItem, "-"))
            txtNombre.Text = oarreglo.nbarreglo
            txtregistros.Text = oarreglo.nurensxpagina
            chkpaginacion.Checked = IIf(oarreglo.stpaginacion.Equals(Comun.ST_ACTIVO), True, False)

            'PASO 2: Consulta los datos de la sincronización
            osincronia = obus.getSincroniArreglo(Me.cdsincronia, Me.cdproject, Me.cdpantalla, outil.Toma_Token(1, cboarreglo.SelectedItem, "-"))
            If osincronia Is Nothing Then osincronia = New SincroniArreglo()
            cboidhtml.SelectedIndex = cboidhtml.FindString(osincronia.nbidhtml)
            txtclase.Text = osincronia.tpelement
            txtobjobj.Text = osincronia.nbobject
            radinput.Checked = IIf(oarreglo.tpinoutput.Equals(Comun.TIPO_CAMPO_INPUT), True, False)
            radoutput.Checked = IIf(oarreglo.tpinoutput.Equals(Comun.TIPO_CAMPO_OUTPUT), True, False)

            'PASO 3: Consulta lo arreglos que pertenecen
            cinoutputs = obus.getPantallaCamposbyArreglo(Me.cdproject, Me.cdpantalla, outil.Toma_Token(1, cboarreglo.SelectedItem, "-"))
            For Each ocampo As PantallaCampo In cinoutputs
                grdinout.Rows.Add(ocampo.cdcampo, ocampo.nbcampo, ocampo.tpinoutput)
            Next

        Catch ex As HANYException
            ex.add("MyGENARO.frmPantallaArreglo.cboarreglo_SelectedIndexChanged()", "Ocurrio un error al Leer la información del arreglo")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub cmdgrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgrabar.Click
        Dim osincronia As SincroniArreglo

        If Me.txtNombre.Text.Trim.Equals("") Then
            MsgBox("Es necesario que ingrese el nombre del arreglo", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        If Me.txtregistros.Text.Trim.Equals("") Then
            MsgBox("Es necesario que ingrese el número de registros por pantalla", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        Try
            oarreglo = New Pantallarreglo
            osincronia = New SincroniArreglo

            oarreglo.cdproyecto = Me.cdproject
            oarreglo.cdpantalla = Me.cdpantalla
            oarreglo.cdarreglo = Me.cdarreglo

            oarreglo.nbarreglo = txtNombre.Text
            oarreglo.nurensxpagina = txtregistros.Text
            oarreglo.stpaginacion = IIf(chkpaginacion.Checked, Comun.ST_ACTIVO, Comun.ST_INACTIVO)
            oarreglo.tpinoutput = IIf(radinput.Checked, Comun.TIPO_CAMPO_INPUT, Comun.TIPO_CAMPO_OUTPUT)

            osincronia.cdsincronia = Me.cdsincronia
            osincronia.cdproyecto = Me.cdproject
            osincronia.cdpantalla = Me.cdpantalla
            osincronia.cdarreglo = Me.cdarreglo
            osincronia.nbidhtml = Me.cboidhtml.SelectedItem
            osincronia.tpelement = Me.txtclase.Text
            osincronia.nbelement = Me.txtnbElement.Text
            osincronia.nbobject = Me.txtobjobj.Text

            obus.savePantallarreglo(oarreglo)
            If Not osincronia.cdsincronia.Equals("") Then obus.saveSincroniArreglo(osincronia)
            MsgBox("La información del arreglo fué grabada exitosamente", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
            Me.Close()
        Catch ex As HANYException
            ex.add("MyGENARO.frmPantallaArreglo.cmdgrabar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmPantallaArreglo.cmdgrabar_Click()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try
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
        txtclase.Text = outil.Toma_Token(1, sresult, "|")
    End Sub

    Private Sub picobjobj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjobj.Click
        Dim sresult As String

        'PASO 1: Muestra las opciones
        sresult = outil.SelectOne(Selecciona_Variables())
        If sresult.Equals("CANCEL") Then Exit Sub
        txtobjobj.Text = outil.Toma_Token(1, sresult, "|")
    End Sub

    Private Sub picdelclase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picdelclase.Click
        txtclase.Text = ""
    End Sub

    Private Sub picobjobjdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjobjdel.Click
        txtobjobj.Text = ""
    End Sub

    Private Function Selecciona_Variables() As String
        Dim sobjetos As String = ""

        For Each ov As Variable In cVariables
            sobjetos = outil.Anade_Token(sobjetos, ov.nombre, "|")
        Next
        Return sobjetos
    End Function
End Class