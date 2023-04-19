Option Explicit On
Imports MyLIB

Public Class frmSteackholder
    Private obus As Catalogos
    Private outil As Utilerias
    Private scdproject As String = ""         'Clave del proyecto
    Private scdsteackholder As String = ""     'Clave del steackholder
    Private oproject As Proyecto              'Objeto que tiene las propiedades del proyecto
    Private oSteackholder As Steackholder     'Objeto que tiene las propiedades del staff

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
    ''' PROPIEDAD: Clave del steackholder
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdsteackholder() As String
        Get
            Return scdsteackholder
        End Get
        Set(ByVal pscd As String)
            scdsteackholder = pscd
        End Set
    End Property

    Private Sub frmSteackholder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro
        Dim cpers As Collection

        Try
            'PASO 1: Inicializa objetos de negocio 
            oparent = Me.ParentForm
            obus = New Catalogos(oparent.conexion)
            outil = New Utilerias

            'PASO 2: Consulta los datos del proyecto
            oproject = obus.getProyecto(Me.cdproject)
            Me.lblcdproyecto.Text = oproject.cdproyecto
            Me.txtnbproyecto.Text = oproject.nbproyecto

            'PASO 3: LLena el catálogo de personas
            cpers = obus.getPersonas()
            For Each oper As Persona In cpers
                cboPersona.Items.Add(oper.cdpersona & " - " & oper.nbpersona)
            Next

            Consultar_Steackholder()
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmSteackholder.Load()", "Ocurrio un error al cargar la pantalla")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub Consultar_Steackholder()
        Try
            oproject = obus.getProyecto(Me.cdproject)
            Me.lblcdproyecto.Text = oproject.cdproyecto
            Me.txtnbproyecto.Text = oproject.nbproyecto

            If Not Me.cdsteackholder.Equals("") Then
                oSteackholder = obus.getSteackholder(Me.cdproject, Me.cdsteackholder)
                Me.txtsteackholder.Text = oSteackholder.cdsteackholder
                Me.cboPersona.SelectedIndex = Me.cboPersona.FindString(oSteackholder.cdpersona)
                Me.txtcomentario.Text = oSteackholder.txcomment
            End If
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmSteackholder.Consultar_Steackholder()", "Ocurrio un error en la consulta")
            Throw ex
        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            oSteackholder = New Steackholder()
            oSteackholder.cdproyecto = Me.cdproject
            oSteackholder.cdsteackholder = Me.txtsteackholder.Text.Trim
            oSteackholder.cdpersona = outil.Toma_Token(1, Me.cboPersona.SelectedItem, "-")
            oSteackholder.txcomment = Me.txtcomentario.Text

            obus.saveSteackholder(oSteackholder)
            MsgBox("Se grabo la información del Steackholder Exitosamente!", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
            Me.txtsteackholder.Text = oSteackholder.cdsteackholder
            Me.Close()

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmSteackholder.btnGrabar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub picpersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picpersona.Click
        Dim ofrm As frmPersona

        If Me.cboPersona.SelectedIndex > -1 Then
            ofrm = New frmPersona
            ofrm.MdiParent = Me.ParentForm
            ofrm.cdpersona = outil.Toma_Token(1, Me.cboPersona.SelectedItem, "-")
            ofrm.SoloLectura = True
            ofrm.Show()
        End If
    End Sub

    Private Sub picproyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picproyecto.Click
        Dim ofrm As frmPMIProyecto

        If Not Me.lblcdproyecto.Text.Trim.Equals("") Then
            ofrm = New frmPMIProyecto
            ofrm.MdiParent = Me.ParentForm
            ofrm.cdproject = Me.cdproject
            ofrm.SoloLectura = True
            ofrm.Show()
        End If
    End Sub
End Class