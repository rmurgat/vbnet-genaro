Option Explicit On

Imports MyLIB

Public Class frmaddPantallaEvento
    Private obus As Catalogos
    Private scdproject As String = ""   'Clave del proyecto
    Private scdpantalla As String = ""  'Clave de la pantalla
    Private oproject As Proyecto        'Objeto que tiene las propiedades del proyecto
    Private opantalla As Pantalla       'Objeto que tiene las propiedades de la pantalla
    Private oevento As PantallaEvento             'Objeto que tiene las propiedades y metodos de un campo
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

    Private Sub frmaddPantallaMetObject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro
        Dim ctipos As Collection

        Try
            'PASO 1: Inicializa los objetos
            outil = New Utilerias
            oparent = Me.ParentForm

            'PASO 2: Incializa los objetos de negocio y utilerias
            obus = New Catalogos(oparent.conexion)
            oproject = obus.getProyecto(Me.cdproject)
            opantalla = obus.getPantalla(Me.cdproject, Me.cdpantalla)

            'PASO 3: Asigna los valores consultados
            txtcdproyecto.Text = oproject.cdproyecto
            txtnbproyecto.Text = oproject.nbproyecto
            txtcdpantalla.Text = opantalla.cdpantalla
            txtnbpantalla.Text = opantalla.nbpantalla

            'PASO 4: Llena el catálogo de tipos de evento
            ctipos = obus.getTpEventos()
            For Each otp As TpEvento In ctipos
                Me.cbotipo.Items.Add(otp.clave & " - " & otp.nombre)
            Next
        Catch ex As HANYException
            ex.add("MyGENARO.frmaddPantallaEvento.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub cmdgrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgrabar.Click
        If Me.txtNombre.Text.Trim.Equals("") Then
            MsgBox("Es necesario que ingrese el nombre del evento", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        If Me.cbotipo.SelectedIndex = -1 Then
            MsgBox("Es necesario que seleccionar un tipo de evento", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        Try
            oevento = New PantallaEvento()
            oevento.cdproyecto = Me.cdproject
            oevento.cdpantalla = Me.cdpantalla
            oevento.cdtpevento = outil.Toma_Token(1, Me.cbotipo.SelectedItem, "-")
            oevento.nbevento = Me.txtNombre.Text
            oevento.txcomment = Me.txtcomentario.Text

            obus.savePantallaEvento(oevento)
            MsgBox("La información del método fué grabada exitosamente", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
            Me.Close()
        Catch ex As HANYException
            ex.add("MyGENARO.frmaddPantallaEvento.cmdgrabar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmaddPantallaEvento.cmdgrabar_Click()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try
    End Sub
End Class