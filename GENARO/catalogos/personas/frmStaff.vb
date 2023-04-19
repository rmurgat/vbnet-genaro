Option Explicit On
Imports MyLIB
Imports System.Windows.Forms

Public Class frmStaff
    Private obus As Catalogos
    Private outil As Utilerias
    Private scdproject As String = ""   'Clave del proyecto
    Private scdstaff As String = ""     'Clave del staff
    Private oproject As Proyecto        'Objeto que tiene las propiedades del proyecto
    Private oStaff As Staff             'Objeto que tiene las propiedades del staff

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
    ''' PROPIEDAD: Clave del staff
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdstaff() As String
        Get
            Return scdstaff
        End Get
        Set(ByVal pscd As String)
            scdstaff = pscd
        End Set
    End Property


    Private Sub frmStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro
        Dim cpers As Collection
        Dim croles As Collection

        'PASO 1: Inicializa objetos de negocio 
        Try
            oparent = Me.ParentForm
            obus = New Catalogos(oparent.conexion)
            outil = New Utilerias

            'PASO 2: Consulta los datos del proyecto
            oproject = obus.getProyecto(Me.cdproject)
            Me.lblcdproyecto.Text = oproject.cdproyecto
            Me.txtnbproyecto.Text = oproject.nbproyecto

            'PASO 3: LLena el catálogo de personas PMP
            cpers = obus.getPersonas()
            For Each oper As Persona In cpers
                cboPersona.Items.Add(oper.cdpersona & " - " & oper.nbpersona)
            Next

            'PASO 4: Llena el catálogo de roles
            croles = obus.getRolStaffs()
            For Each orol As Rol In croles
                cborolstaff.Items.Add(orol.clave & " - " & orol.nombre)
            Next

            Consultar_Staff()
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmStaff.Load()", "Ocurrio un error al cargar la pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
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

    Public Sub Consultar_Staff()

        Try
            oproject = obus.getProyecto(Me.cdproject)
            Me.lblcdproyecto.Text = oproject.cdproyecto
            Me.txtnbproyecto.Text = oproject.nbproyecto

            If Not Me.cdstaff.Equals("") Then
                oStaff = obus.getStaff(Me.cdproject, Me.cdstaff)
                Me.txtstaff.Text = oStaff.cdstaff
                Me.cboPersona.SelectedIndex = Me.cboPersona.FindString(oStaff.cdpersona)
                Me.cborolstaff.SelectedIndex = Me.cborolstaff.FindString(oStaff.cdrolstaff)
                Me.txtcomentario.Text = oStaff.txcomment
            End If
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmStaff.Consultar_Staff()", "Ocurrio un error al consultar el staff")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            oStaff = New Staff
            oStaff.cdproyecto = Me.cdproject
            oStaff.cdstaff = Me.cdstaff
            oStaff.cdpersona = outil.Toma_Token(1, Me.cboPersona.SelectedItem, "-")
            oStaff.cdrolstaff = outil.Toma_Token(1, Me.cborolstaff.SelectedItem, "-")
            oStaff.txcomment = Me.txtcomentario.Text

            obus.saveStaff(oStaff)
            MsgBox("Se grabo la información del Staff Exitosamente!", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
            Me.txtstaff.Text = oStaff.cdstaff
            Me.Close()

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmStaff.btnGrabar_Click()", "Ocurrio un error en Pantalla")
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
End Class
