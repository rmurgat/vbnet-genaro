Option Explicit On
Imports MyLIB

Public Class frmaddPantallaCampo
    Private obus As Catalogos
    Private scdproject As String = ""   'Clave del proyecto
    Private scdpantalla As String = ""  'Clave de la pantalla
    Private oproject As Proyecto        'Objeto que tiene las propiedades del proyecto
    Private opantalla As Pantalla       'Objeto que tiene las propiedades de la pantalla
    Private ocampo As PantallaCampo             'Objeto que tiene las propiedades y metodos de un campo
    Private outil As Utilerias

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

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmCampo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro
        Dim ctipocampos As Collection
        Dim carreglos As Collection

        outil = New Utilerias
        oparent = Me.ParentForm

        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            obus = New Catalogos(oparent.conexion)
            oproject = obus.getProyecto(Me.cdproject)
            opantalla = obus.getPantalla(Me.cdproject, Me.cdpantalla)
            carreglos = obus.getPantallarreglos(Me.cdproject, Me.cdpantalla)

            'PASO 2: Llena los datos del proyecto y pantalla
            txtcdproyecto.Text = oproject.cdproyecto
            txtnbproyecto.Text = oproject.nbproyecto
            txtcdpantalla.Text = opantalla.cdpantalla
            txtnbpantalla.Text = opantalla.nbpantalla

            'PASO 3: Llena el catálogo de tipos de campo
            ctipocampos = obus.getTpCampos()
            For Each ost As Estatus In ctipocampos
                Me.cbotipo.Items.Add(ost.clave & " - " & ost.nombre)
            Next

            'PASO 5: Llena el catálogo de arreglos
            Me.cboarreglo.Items.Add("")
            For Each oarr As Pantallarreglo In carreglos
                Me.cboarreglo.Items.Add(oarr.cdarreglo & " - " & oarr.nbarreglo)
            Next

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmaddPantallaCampo.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub cmdgrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgrabar.Click
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

        Try
            ocampo = New PantallaCampo
            ocampo.cdproyecto = Me.cdproject
            ocampo.cdpantalla = Me.cdpantalla
            ocampo.nulongitud = Me.txtlongitud.Text
            ocampo.nudecimales = Me.txtdecimales.Text
            ocampo.cdtpcampo = outil.Toma_Token(1, Me.cbotipo.SelectedItem, "-")
            ocampo.cdarreglo = outil.Toma_Token(1, Me.cboarreglo.SelectedItem, "-")
            ocampo.nbcampo = Me.txtNombre.Text
            ocampo.txcomment = Me.txtcomentario.Text
            ocampo.tpinoutput = IIf(radinput.Checked, Comun.TIPO_CAMPO_INPUT, Comun.TIPO_CAMPO_OUTPUT)

            obus.savePantallaCampo(ocampo)
            MsgBox("La información del campo fué grabada exitosamente", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
            Me.Close()

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmaddPantallaCampo.cmdgrabar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmaddPantallaCampo.cmdgrabar_Click()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub
End Class