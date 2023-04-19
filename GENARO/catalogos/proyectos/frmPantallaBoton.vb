Option Explicit On
Imports MyLIB

Public Class frmPantallaBoton
    Private obus As Catalogos
    Private scdproject As String = ""   'Clave del proyecto
    Private scdpantalla As String = ""  'Clave de la pantalla
    Private scdboton As String = ""     'Clave del boton
    Private oproject As Proyecto        'Objeto que tiene las propiedades del proyecto
    Private opantalla As Pantalla       'Objeto que tiene las propiedades de la pantalla
    Private oboton As PantallaBoton             'Objeto que tiene las propiedades y metodos de un boton
    Private bSoloLectura As Boolean     'bandera de solo lectura
    Private outil As Utilerias          'Utilerias del sistema

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
    ''' PROPIEDAD: Clave del boton
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdboton() As String
        Get
            Return scdboton
        End Get
        Set(ByVal pscd As String)
            scdboton = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: bandera de solo lectura
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property SoloLectura() As Boolean
        Get
            Return bSoloLectura
        End Get
        Set(ByVal pbval As Boolean)
            bSoloLectura = pbval
        End Set
    End Property

    Private Sub frmBoton_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro

        Try
            oparent = Me.ParentForm
            outil = New Utilerias

            'PASO 1: Incializa los objetos de negocio y utilerias
            obus = New Catalogos(oparent.conexion)
            oproject = obus.getProyecto(Me.cdproject)
            opantalla = obus.getPantalla(Me.cdproject, Me.cdpantalla)

            txtcdproyecto.Text = oproject.cdproyecto
            txtnbproyecto.Text = oproject.nbproyecto
            txtcdpantalla.Text = opantalla.cdpantalla
            txtnbpantalla.Text = opantalla.nbpantalla

            Consulta_Boton()
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPantallaBoton.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para consulta la informaciónd e un boton
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Consulta_Boton()
        If Not Me.cdboton.Equals("") Then
            oboton = obus.getPantallaBoton(Me.cdproject, Me.cdpantalla, Me.cdboton)
            txtcdboton.Text = Me.cdboton
            txtNombre.Text = oboton.nbboton
            txtcomentario.Text = oboton.txcomment
        End If
    End Sub

    Private Sub cmdgrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgrabar.Click
        Me.txtNombre.Text = Me.txtNombre.Text.ToUpper
        If Me.txtNombre.Text.Trim.Equals("") Then
            MsgBox("Es necesario que ingrese el nombre del boton", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        Try
            oboton = New PantallaBoton
            oboton.cdproyecto = Me.cdproject
            oboton.cdpantalla = Me.cdpantalla
            oboton.cdboton = Me.cdboton
            oboton.nbboton = Me.txtNombre.Text
            oboton.txcomment = Me.txtcomentario.Text

            obus.saveBoton(oboton)
            MsgBox("La información del boton fué grabada exitosamente", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
            Me.Close()

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPantallaBoton.cmdgrabar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmPantallaBoton.cmdgrabar_Click()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class