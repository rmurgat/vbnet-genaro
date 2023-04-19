Option Explicit On
Imports MyLIB

Public Class frmaddpantalla
    Private obus As Catalogos
    Private scdproject As String = ""   'Clave del proyecto
    Private oproject As Proyecto        'Objeto que tiene las propiedades del proyecto
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

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmaddpantalla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro

        Try
            'PASO 1: Inicializa objetos de negocio 
            oparent = Me.ParentForm
            outil = New Utilerias
            obus = New Catalogos(oparent.conexion)

            'PASO 2: Consulta los datos del proyecto
            oproject = obus.getProyecto(Me.cdproject)
            Me.txtcdproyecto.Text = oproject.cdproyecto
            Me.txtnbproyecto.Text = oproject.nbproyecto
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmaddpantalla.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub cmdgrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgrabar.Click
        Dim obj As Pantalla = New Pantalla
        Me.txtnombre.Text = Me.txtnombre.Text.ToUpper
        If Me.txtnombre.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar el nombre de la pantalla", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        If Me.txtobjetivo.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar el objetivo de la pantalla", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        Try
            obj.cdproyecto = Me.cdproject
            obj.nbpantalla = Me.txtnombre.Text
            obj.txobjetivo = Me.txtobjetivo.Text
            obj.cdstanalisis = "00"
            obj.cdstconstruccion = "00"
            obj.cdanalista = "000000"
            obj.cdprogramador = "000000"
            obj.cdcodigo = "PN000000"
            obj.nbimagefile = "NA"
            obj.txcomment = "Comentario por default"

            obus.savePantalla(obj)
            MsgBox("Se dieron de alta los datos de la nueva pantalla exitosamente", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
            Me.Close()
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmaddpantalla.cmdgrabar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        End Try

    End Sub
End Class