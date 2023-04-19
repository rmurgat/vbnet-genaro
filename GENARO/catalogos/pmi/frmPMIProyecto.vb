Option Explicit On
Imports MyLIB
Imports System.Windows.Forms

Public Class frmPMIProyecto
    Private obus As Catalogos
    Private opmi As BPmi
    Private scdproject As String        'Clave del proyecto
    Private oproject As Proyecto        'Objeto que tiene las propiedades del proyecto
    Private outil As Utilerias          'Utilerias del sistema
    Private bSoloLectura As Boolean     'bandera de solo lectura
    Private omdipa As MDIGenaro

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

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmproject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cempresas As Collection
        Dim cctes As Collection
        Dim cpers As Collection
        Dim cestatus As Collection

        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            omdipa = Me.ParentForm
            obus = New Catalogos(omdipa.conexion)
            opmi = New BPmi(omdipa.conexion)
            outil = New Utilerias

            'PASO 2: LLena el catálogo de empresas
            cempresas = obus.getEmpresas()
            For Each oemp As Empresa In cempresas
                cboEmpresa.Items.Add(oemp.cdempresa & " - " & oemp.nbempresa)
            Next

            'PASO 3: LLena el catálogo de clientes
            cctes = obus.getClientes()
            For Each octe As Cliente In cctes
                cboCliente.Items.Add(octe.cdcliente & " - " & octe.nbcliente)
            Next

            'PASO 4: LLena el catálogo de personas PMP
            cpers = obus.getPersonas()
            For Each oper As Persona In cpers
                cboPMP.Items.Add(oper.cdpersona & " - " & oper.nbpersona)
            Next

            'PASO 5: LLena el catálogo de empresas
            cestatus = obus.getStProyectos()
            For Each ost As Estatus In cestatus
                cboEstatus.Items.Add(ost.clave & " - " & ost.nombre)
            Next

            Consultar_Proyecto()

            If bSoloLectura Then
                btngengrabar.Visible = False
                btndelfile.Visible = False
                btnaddfile.Visible = False
                btnsteackdel.Visible = False
                btnstackadd.Visible = False
                btnsteackdetalle.Visible = False
                btnstaffverdetalle.Visible = False
            End If

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPMIProyectoLoad()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmPMIProyectoLoad()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Procedimiento para consulta toda la información de un proyecto
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Consultar_Proyecto()

        Try
            oproject = obus.getProyecto(Me.cdproject)
            If oproject Is Nothing Then
                MsgBox("Existio un error al consulta la información del proyecto [" + Me.cdproject + "]", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
                Exit Sub
            End If
            Me.txtmainclave.Text = oproject.cdproyecto
            Me.txtmainame.Text = oproject.nbproyecto
            Me.txtclave.Text = oproject.cdproyecto
            Me.txtnombre.Text = oproject.nbproyecto
            Me.txtPrecio.Text = oproject.imprecio
            Me.txtIva.Text = oproject.imiva
            Me.txtComentario.Text = oproject.comment
            Me.cboCliente.SelectedIndex = Me.cboCliente.FindString(oproject.cdcliente)
            Me.cboPMP.SelectedIndex = Me.cboPMP.FindString(oproject.cdpmp)
            Me.cboEmpresa.SelectedIndex = Me.cboEmpresa.FindString(oproject.cdempresa)
            Me.cboEstatus.SelectedIndex = Me.cboEstatus.FindString(oproject.cdstproyecto)
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPMIProyectoConsultar_Proyecto()", "Ocurrio un error al consultar el proyecto")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub btngengrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngengrabar.Click

        Try
            'PASO 1: Lee los valores 
            oproject.nbproyecto = Me.txtnombre.Text
            oproject.imprecio = Me.txtPrecio.Text
            oproject.imiva = Me.txtIva.Text
            oproject.comment = Me.txtComentario.Text
            oproject.cdcliente = outil.Toma_Token(1, Me.cboCliente.SelectedItem, "-")
            oproject.cdpmp = outil.Toma_Token(1, Me.cboPMP.SelectedItem, "-")
            oproject.cdempresa = outil.Toma_Token(1, Me.cboEmpresa.SelectedItem, "-")
            oproject.cdstproyecto = outil.Toma_Token(1, Me.cboEstatus.SelectedItem, "-")

            'PASO 2: actualiza la información del proyecto
            obus.saveProyecto(oproject)
            Me.txtmainame.Text = oproject.nbproyecto
            MsgBox("Fué un exito la actualización  del proyecto", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPMIProyectobtngengrabar_Click()", "Ocurrio un error al grabar los datos del proyecto")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub btnaddfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddfile.Click
        Dim ofrm As frmStaff
        ofrm = New frmStaff
        ofrm.MdiParent = Me.ParentForm
        ofrm.cdproject = Me.cdproject
        ofrm.Show()
    End Sub

    Private Sub btnstaffload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstaffload.Click
        Call Consulta_Staff()
    End Sub

    Private Sub Consulta_Staff()
        Dim cstaff As Collection
        Dim ocrit As Criterio = New Criterio
        Try

            ocrit.cdproyecto = Me.cdproject
            cstaff = obus.getStaffs(ocrit)

            gridstaff.Rows.Clear()
            gridstaff.Columns.Clear()

            gridstaff.Columns.Add("clave", "Clave")
            gridstaff.Columns.Add("nombre", "Nombre")
            gridstaff.Columns.Add("rom", "Rol")
            gridstaff.Columns.Add("comment", "Comentario")

            gridstaff.Columns.Item(0).Width = 60
            gridstaff.Columns.Item(1).Width = 250
            gridstaff.Columns.Item(2).Width = 200
            gridstaff.Columns.Item(3).Width = 200

            gridstaff.Columns.Item(0).SortMode = DataGridViewColumnSortMode.NotSortable
            gridstaff.Columns.Item(1).SortMode = DataGridViewColumnSortMode.NotSortable
            gridstaff.Columns.Item(2).SortMode = DataGridViewColumnSortMode.NotSortable
            gridstaff.Columns.Item(3).SortMode = DataGridViewColumnSortMode.NotSortable

            For Each ostaff As Staff In cstaff
                gridstaff.Rows.Add(ostaff.cdstaff, ostaff.nbpersona, ostaff.nbrolstaff, ostaff.txcomment)
            Next

            txttotstaff.Text = "Un total de " & cstaff.Count & " personas en el staff"

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPMIProyectoConsulta_Staff()", "Ocurrio un error al consultar al staff")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub btndelfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelfile.Click
        Try
            If Me.gridstaff.SelectedRows.Count > 0 Then
                obus.delStaff(Me.cdproject, Me.gridstaff.SelectedRows.Item(0).Cells("clave").Value)
                MsgBox("Se ha eliminado el registro de Staff del proyecto", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
                Call Consulta_Staff()
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPMIProyectobtndelfile_Click()", "Ocurrio un error al eliminar un participante del staff")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub btnstaffverdetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstaffverdetalle.Click
        If Me.gridstaff.SelectedRows.Count > 0 Then
            Dim ofrm As frmStaff
            ofrm = New frmStaff
            ofrm.MdiParent = Me.ParentForm
            ofrm.cdproject = Me.cdproject
            ofrm.cdstaff = Me.gridstaff.SelectedRows.Item(0).Cells("clave").Value
            ofrm.Show()
        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btnstackload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstackload.Click
        Call Consulta_Steackholders()
    End Sub

    Private Sub Consulta_Steackholders()
        Dim csholders As Collection

        Try
            gridSteackholders.Rows.Clear()
            gridSteackholders.Columns.Clear()
            gridSteackholders.Columns.Add("scdsteack", "Clave")
            gridSteackholders.Columns.Add("snbpersona", "Nombre")
            gridSteackholders.Columns.Add("stxcomment", "Comentario")

            gridSteackholders.Columns.Item(1).Width = 200
            gridSteackholders.Columns.Item(2).Width = 200

            gridSteackholders.Columns.Item("scdsteack").SortMode = DataGridViewColumnSortMode.NotSortable
            gridSteackholders.Columns.Item("snbpersona").SortMode = DataGridViewColumnSortMode.NotSortable
            gridSteackholders.Columns.Item("stxcomment").SortMode = DataGridViewColumnSortMode.NotSortable

            csholders = obus.getSteackholders(Me.cdproject)

            For Each osh As Steackholder In csholders
                gridSteackholders.Rows.Add(osh.cdsteackholder, osh.nbpersona, osh.txcomment)
            Next
            txttotsteackholders.Text = "Un total de " & csholders.Count & " personas"

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPMIProyectoConsulta_Steackholders()", "Ocurrio un error al leer las pantallas")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub btnsteackdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsteackdel.Click
        Try
            If Me.gridSteackholders.SelectedRows.Count > 0 Then
                obus.delSteackholder(Me.cdproject, Me.gridSteackholders.SelectedRows.Item(0).Cells("scdsteack").Value)
                MsgBox("Se ha eliminado el registro del Steackholder del proyecto", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
                Call Consulta_Steackholders()
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPMIProyectobtnsteackdel_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub btnstackadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstackadd.Click
        Dim ofrm As frmSteackholder
        ofrm = New frmSteackholder
        ofrm.MdiParent = Me.ParentForm
        ofrm.cdproject = Me.cdproject
        ofrm.Show()
    End Sub

    Private Sub btnsteackdetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsteackdetalle.Click
        If Me.gridSteackholders.SelectedRows.Count > 0 Then
            Dim ofrm As frmSteackholder
            ofrm = New frmSteackholder
            ofrm.MdiParent = Me.ParentForm
            ofrm.cdproject = Me.cdproject
            ofrm.cdsteackholder = Me.gridSteackholders.SelectedRows.Item(0).Cells("scdsteack").Value
            ofrm.Show()
        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btnjuntadel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnjuntadel.Click
        Try
            If Me.gridJunta.SelectedRows.Count > 0 Then
                opmi.delJunta(Me.cdproject, Me.gridJunta.SelectedRows.Item(0).Cells("clave").Value)
                MsgBox("Se ha eliminado el registro de la junta del proyecto", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
                Call Consulta_Staff()
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPMIProyecto.btnjuntadel_Click()", "Ocurrio un error al eliminar un participante del staff")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub btnjuntadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnjuntadd.Click
        Dim ofrm As frmPMIJunta
        ofrm = New frmPMIJunta
        ofrm.MdiParent = Me.ParentForm
        ofrm.cdproject = Me.cdproject
        ofrm.Show()
    End Sub

    Private Sub btnjuntasload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnjuntasload.Click
        Call Consulta_Juntas()
    End Sub

    Private Sub Consulta_Juntas()
        Dim cjuntas As Collection
        Dim ocrit As Criterio

        Try
            ocrit = New Criterio
            ocrit.cdproyecto = Me.cdproject
            cjuntas = opmi.getJuntas(ocrit)

            gridJunta.Rows.Clear()
            gridJunta.Columns.Clear()

            gridJunta.Columns.Add("clave", "Clave")
            gridJunta.Columns.Add("nombre", "Nombre")
            gridJunta.Columns.Add("fecha", "Fecha")
            gridJunta.Columns.Add("estatus", "Estatus")

            gridJunta.Columns.Item(0).Width = 60
            gridJunta.Columns.Item(1).Width = 340
            gridJunta.Columns.Item(2).Width = 100
            gridJunta.Columns.Item(3).Width = 60

            gridJunta.Columns.Item("clave").SortMode = DataGridViewColumnSortMode.NotSortable
            gridJunta.Columns.Item("nombre").SortMode = DataGridViewColumnSortMode.NotSortable
            gridJunta.Columns.Item("fecha").SortMode = DataGridViewColumnSortMode.NotSortable
            gridJunta.Columns.Item("estatus").SortMode = DataGridViewColumnSortMode.NotSortable

            For Each ojunta As Junta In cjuntas
                gridJunta.Rows.Add(ojunta.cdjunta, ojunta.nbjunta, ojunta.fhjunta, ojunta.stjunta)
            Next

            Me.txtjuntas.Text = "Un total de " & cjuntas.Count & " juntas del proyecto"

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPMIProyecto.Consulta_Juntas()", "Ocurrio un error")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub btnjuntaver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnjuntaver.Click
        If Me.gridJunta.SelectedRows.Count > 0 Then
            Dim ofrm As frmPMIJunta
            ofrm = New frmPMIJunta
            ofrm.MdiParent = Me.ParentForm
            ofrm.cdproject = Me.cdproject
            ofrm.cdjunta = Me.gridJunta.SelectedRows.Item(0).Cells("clave").Value
            ofrm.Show()
        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub
End Class
