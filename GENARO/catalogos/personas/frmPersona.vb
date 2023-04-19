Option Explicit On
Imports MyLIB

Public Class frmPersona
    Private scdpersona As String = ""  'Clave de la persona
    Private oPersona As Persona    'objeto con las propiedades y metodos de las personas
    Private obus As Catalogos
    Private outil As Utilerias
    Private bSoloLectura As Boolean 'Bandera de solo lectura

    ''' <summary>
    ''' PROPIEDAD: Clave de la persona
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdpersona() As String
        Get
            Return scdpersona
        End Get
        Set(ByVal pscd As String)
            scdpersona = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Bandera de solo lectura
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

    Private Sub frmPersona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro

        Try
            'PASO 1: Inicializa objetos de negocio 
            oparent = Me.ParentForm
            obus = New Catalogos(oparent.conexion)
            outil = New Utilerias

            If Me.SoloLectura Then
                Me.btnGrabar.Visible = False
            End If

            Consultar_Persona()
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPersona.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub Consultar_Persona()
        If Not Me.cdpersona.Equals("") Then
            oPersona = obus.getPersona(Me.cdpersona)
            txtclave.Text = oPersona.cdpersona
            txtnombre.Text = oPersona.nbpersona
            cbotipo.SelectedIndex = cbotipo.FindString(oPersona.cdtipo)
            txtRfc.Text = oPersona.cdrfc
            txtUsuario.Text = oPersona.cdusuario
            txtTelCasa.Text = oPersona.nutelcasa
            txtteloficina.Text = oPersona.nuteloficina
            txtempresa.Text = oPersona.nbempresa
            txtemail.Text = oPersona.nbemail
            txtcomentario.Text = oPersona.comment
        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click

        If Not Valida_Informacion() Then Exit Sub
        Try
            oPersona = New Persona
            oPersona.cdpersona = txtclave.Text
            oPersona.nbpersona = txtnombre.Text
            oPersona.cdtipo = cbotipo.SelectedItem
            oPersona.cdrfc = txtRfc.Text
            oPersona.cdusuario = txtUsuario.Text
            oPersona.nutelcasa = txtTelCasa.Text
            oPersona.nuteloficina = txtteloficina.Text
            oPersona.nbempresa = txtempresa.Text
            oPersona.nbemail = txtemail.Text
            oPersona.comment = txtcomentario.Text
            obus.savePersona(oPersona)
            MsgBox("Se grabaron los datos de la persona Exitosamente!", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
            Me.Close()
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPersona.btnGrabar_Click()", "Ocurrio un error al grabar la información de la persona")
            outil.ShowException(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Función para validar la información capturada en el sistema
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Valida_Informacion() As Boolean
        If cbotipo.SelectedIndex < 0 Then
            MsgBox("Es necesario seleccionar el tipo de persona que se trata", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Return False
        End If
        If txtRfc.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar el rfc", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Return False
        End If
        If txtUsuario.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar la clave del usuario", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Return False
        End If
        If txtTelCasa.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar el teléfono de casa", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Return False
        End If
        If txtteloficina.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar el teléfono de oficina", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Return False
        End If
        If txtnombre.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar el Nombre Completo", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Return False
        End If
        If txtempresa.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar el Nombre de la Empresa", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Return False
        End If
        If txtemail.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar el EMail", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Return False
        End If
        If txtcomentario.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar algun comentario", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Return False
        End If
        Return True
    End Function

End Class