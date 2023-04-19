Option Explicit On
Imports MyLIB
Imports System.Windows.Forms

Public Class frmProyecto
    Private obus As Catalogos
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
            End If

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmProyecto.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmProyecto.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
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
            ex.add("MyCATALOGOS.frmProyecto.Consultar_Proyecto()", "Ocurrio un error al consultar el proyecto")
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
            ex.add("MyCATALOGOS.frmProyecto.btngengrabar_Click()", "Ocurrio un error al grabar los datos del proyecto")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub btnpantload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpantload.Click
        Load_gridpantallas(Me.cdproject)
    End Sub

    Private Sub Load_gridpantallas(ByVal scdreporte As String)
        Dim cpants As Collection

        Try
            gridpantallas.Rows.Clear()
            gridpantallas.Columns.Clear()
            gridpantallas.Columns.Add("clave", "Clave de Pantalla")
            gridpantallas.Columns.Add("nombre", "Nombre de la Pantalla")
            gridpantallas.Columns.Add("codigo", "Codigo")
            gridpantallas.Columns.Add("objetivo", "Objetivo")
            gridpantallas.Columns.Add("comment", "Comentario")

            gridpantallas.Columns.Item("clave").Width = 60
            gridpantallas.Columns.Item("nombre").Width = 300
            gridpantallas.Columns.Item("codigo").Width = 70
            gridpantallas.Columns.Item("objetivo").Width = 200
            gridpantallas.Columns.Item("comment").Width = 200

            gridpantallas.Columns.Item("clave").SortMode = DataGridViewColumnSortMode.NotSortable
            gridpantallas.Columns.Item("nombre").SortMode = DataGridViewColumnSortMode.NotSortable
            gridpantallas.Columns.Item("codigo").SortMode = DataGridViewColumnSortMode.NotSortable
            gridpantallas.Columns.Item("objetivo").SortMode = DataGridViewColumnSortMode.NotSortable
            gridpantallas.Columns.Item("comment").SortMode = DataGridViewColumnSortMode.NotSortable

            cpants = obus.getPantallas(scdreporte)

            For Each opant As Pantalla In cpants
                gridpantallas.Rows.Add(opant.cdpantalla, opant.nbpantalla, opant.cdcodigo, opant.txobjetivo, opant.txcomment)
            Next
            txttotpantallas.Text = "Un total de " & cpants.Count & " pantallas"

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmProyecto.Load_gridpantallas()", "Ocurrio un error al leer las pantallas")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub btnpantdetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpantdetalle.Click
        If Me.gridpantallas.SelectedRows.Count > 0 Then
            Try
                Dim ofrm As frmPantalla
                ofrm = New frmPantalla
                ofrm.MdiParent = Me.ParentForm
                ofrm.cdproject = Me.cdproject
                ofrm.cdpantalla = Me.gridpantallas.SelectedRows.Item(0).Cells("clave").Value
                ofrm.Show()
            Catch ex As Exception
                MsgBox("EXCEPCION : " & ex.Message)
            End Try
        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btnpantadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpantadd.Click
        Dim ofrm As frmaddpantalla
        ofrm = New frmaddpantalla
        ofrm.MdiParent = Me.ParentForm
        ofrm.cdproject = Me.cdproject
        ofrm.Show()
    End Sub

    Private Sub btnrepdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrepdel.Click
        Try
            If Me.gridreportes.SelectedRows.Count > 0 Then
                obus.delReporte(Me.cdproject, Me.gridreportes.SelectedRows.Item(0).Cells("clave").Value)
                MsgBox("Se ha eliminado el registro del reporte del proyecto", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
                Load_gridreportes(Me.cdproject)
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmProyecto.btnrepdel_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub btnrepadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrepadd.Click
        Dim ofrm As frmaddreporte
        ofrm = New frmaddreporte
        ofrm.MdiParent = Me.ParentForm
        ofrm.cdproject = Me.cdproject
        ofrm.Show()
    End Sub

    Private Sub btnrepsload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrepsload.Click
        Load_gridreportes(Me.cdproject)
    End Sub

    Private Sub Load_gridreportes(ByVal scdreporte As String)
        Dim creps As Collection

        Try
            gridreportes.Rows.Clear()
            gridreportes.Columns.Clear()
            gridreportes.Columns.Add("clave", "Clave del Reporte")
            gridreportes.Columns.Add("nombre", "Nombre del Reporte")
            gridreportes.Columns.Add("codigo", "Codigo")
            gridreportes.Columns.Add("objetivo", "Objetivo")
            gridreportes.Columns.Add("comment", "Comentario")

            gridreportes.Columns.Item(0).Width = 50
            gridreportes.Columns.Item(1).Width = 200
            gridreportes.Columns.Item(2).Width = 60
            gridreportes.Columns.Item(3).Width = 200
            gridreportes.Columns.Item(4).Width = 200

            gridreportes.Columns.Item(0).SortMode = DataGridViewColumnSortMode.NotSortable
            gridreportes.Columns.Item(1).SortMode = DataGridViewColumnSortMode.NotSortable
            gridreportes.Columns.Item(2).SortMode = DataGridViewColumnSortMode.NotSortable
            gridreportes.Columns.Item(3).SortMode = DataGridViewColumnSortMode.NotSortable
            gridreportes.Columns.Item(4).SortMode = DataGridViewColumnSortMode.NotSortable

            creps = obus.getReportes(scdreporte)

            For Each orep As Reporte In creps
                gridreportes.Rows.Add(orep.cdreporte, orep.nbreporte, orep.cdcodigo, orep.txobjetivo, orep.txcomment)
            Next
            txttotreportes.Text = "Un total de " & creps.Count & " reportes"
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmProyecto.Load_gridreportes()", "Ocurrio un error al leer los reportes")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub btnrepdetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrepdetalle.Click
        If Me.gridreportes.SelectedRows.Count > 0 Then
            Try
                Dim ofrm As frmReporte
                ofrm = New frmReporte
                ofrm.MdiParent = Me.ParentForm
                ofrm.cdproject = Me.cdproject
                ofrm.cdreporte = Me.gridreportes.SelectedRows.Item(0).Cells("clave").Value
                ofrm.Show()
            Catch ex As Exception
                MsgBox("EXCEPCION : " & ex.Message)
            End Try
        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btnpantdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpantdel.Click
        Try
            If Me.gridpantallas.SelectedRows.Count > 0 Then
                If obus.delPantalla(Me.cdproject, Me.gridpantallas.SelectedRows.Item(0).Cells("clave").Value) Then
                    MsgBox("Se ha eliminado el registro de la pantalla del proyecto", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
                    Load_gridpantallas(Me.cdproject)
                Else
                    MsgBox(obus.mensaje, MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
                End If
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmProyecto.btnpantdel_Click()", "Ocurrio un error al eliminar una pantalla")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddfuente.Click
        Dim ofrm As frmaddproyectofuentedato
        ofrm = New frmaddproyectofuentedato
        ofrm.MdiParent = Me.ParentForm
        ofrm.cdproject = Me.cdproject
        ofrm.Show()
    End Sub

    Private Sub btnfteload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfteload.Click
        Load_gridfuentedatos(Me.cdproject)
    End Sub

    Private Sub Load_gridfuentedatos(ByVal sproyecto As String)
        Dim cftes As Collection

        Try
            dgvfuentedatos.Rows.Clear()
            dgvfuentedatos.Columns.Clear()
            dgvfuentedatos.Columns.Add("scdproyecto", "Clave del Proyecto")
            dgvfuentedatos.Columns.Add("scdfuentedato", "Clave de la Fuente de Datos")
            dgvfuentedatos.Columns.Add("snbfuente", "Nombre de la Fuente")
            dgvfuentedatos.Columns.Add("stpfuente", "Tipo de Fuente")
            dgvfuentedatos.Columns.Add("stxcomment", "Comentario")
            dgvfuentedatos.Columns.Item("snbfuente").Width = 300
            dgvfuentedatos.Columns.Item("stxcomment").Width = 300
            dgvfuentedatos.Columns.Item("scdproyecto").SortMode = DataGridViewColumnSortMode.NotSortable
            dgvfuentedatos.Columns.Item("scdfuentedato").SortMode = DataGridViewColumnSortMode.NotSortable
            dgvfuentedatos.Columns.Item("snbfuente").SortMode = DataGridViewColumnSortMode.NotSortable
            dgvfuentedatos.Columns.Item("stpfuente").SortMode = DataGridViewColumnSortMode.NotSortable
            dgvfuentedatos.Columns.Item("stxcomment").SortMode = DataGridViewColumnSortMode.NotSortable

            cftes = obus.getProyectoFuenteDatos(Me.cdproject)

            For Each opryfte As ProyectoFuenteDato In cftes
                Dim ofte As FuenteDato = obus.getFuenteDato(opryfte.cdfuentedato)
                dgvfuentedatos.Rows.Add(Me.cdproject, opryfte.cdfuentedato, ofte.nbfuentedato, ofte.tpfuentedato, opryfte.txcomment)
            Next
            txttotfuentes.Text = "Un total de " & cftes.Count & " fuentes de datos"
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmProyecto.Load_gridfuentedatos()", "Ocurrio un error al leer las fuentes de datos")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub btndelfuente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelfuente.Click
        Try
            If Me.dgvfuentedatos.SelectedRows.Count > 0 Then
                If obus.delProyectoFuenteDato(Me.cdproject, Me.dgvfuentedatos.SelectedRows.Item(0).Cells(1).Value) Then
                    MsgBox("Se ha eliminado el registro de la fuente de datos para el proyecto", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
                    Load_gridfuentedatos(Me.cdproject)
                Else
                    MsgBox("Existio un error al eliminar la fuente de datos", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
                End If
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmProyecto.btndelfuente_Click()", "Ocurrio un error al eliminar una fuente de datos")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub btnftedetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnftedetalle.Click
        Dim ofrm As frmListEntidades
        If Me.dgvfuentedatos.SelectedRows.Count > 0 Then
            Dim oantes As Collection
            Dim santes As String = ""
            Dim odespues As Collection

            oantes = obus.getProyectoFuenteDatoEntidades(Me.scdproject, Me.dgvfuentedatos.SelectedRows.Item(0).Cells(1).Value)
            For Each oentidad As ProyectoFuenteDatoEntidad In oantes
                santes = outil.Anade_Token(santes, oentidad.nbentidadato, ",")
            Next

            ofrm = New frmListEntidades
            ofrm.sentidades = santes
            ofrm.oconexion = omdipa.conexion
            ofrm.sfuente = Me.dgvfuentedatos.SelectedRows.Item(0).Cells(1).Value
            ofrm.ShowDialog()
            If ofrm.sentidades.Equals("CANCEL") Then Exit Sub
            odespues = outil.CAparta_Tokens(ofrm.sentidades, ",")
            obus.delProyectoFuenteDatoEntidades(Me.scdproject, Me.dgvfuentedatos.SelectedRows.Item(0).Cells(1).Value)
            For Each oent As String In odespues
                Dim opentidad As ProyectoFuenteDatoEntidad = New ProyectoFuenteDatoEntidad
                opentidad.cdproyecto = Me.scdproject
                opentidad.cdfuentedato = Me.dgvfuentedatos.SelectedRows.Item(0).Cells(1).Value
                opentidad.nbentidadato = oent
                obus.addProyectoFuenteDatoEntidad(opentidad)
            Next
        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btnavload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnavload.Click
        Load_gridNavegaciones(Me.cdproject)
    End Sub

    Private Sub Load_gridNavegaciones(ByVal scdproyecto As String)
        Dim cnavs As Collection
        Try
            gridNavegacion.Rows.Clear()
            gridNavegacion.Columns.Clear()
            gridNavegacion.Columns.Add("scdesde", "Pantalla Inicial")
            gridNavegacion.Columns.Add("scdhasta", "Pantalla Final")
            gridNavegacion.Columns.Add("tipo", "Tipo")
            gridNavegacion.Columns.Add("stopen", "Open Window")

            gridNavegacion.Columns.Item("scdesde").Width = 300
            gridNavegacion.Columns.Item("scdhasta").Width = 300

            gridNavegacion.Columns.Item("scdesde").SortMode = DataGridViewColumnSortMode.NotSortable
            gridNavegacion.Columns.Item("scdhasta").SortMode = DataGridViewColumnSortMode.NotSortable
            gridNavegacion.Columns.Item("tipo").SortMode = DataGridViewColumnSortMode.NotSortable
            gridNavegacion.Columns.Item("stopen").SortMode = DataGridViewColumnSortMode.NotSortable

            cnavs = obus.getNavegaciones(scdproyecto)

            For Each onav As Navegacion In cnavs
                Dim odesde As Pantalla = obus.getPantalla(scdproyecto, onav.cdesde)
                Dim ohasta As Pantalla = obus.getPantalla(scdproyecto, onav.cdhasta)
                gridNavegacion.Rows.Add(onav.cdesde & "-" & odesde.nbpantalla, onav.cdhasta & "-" & ohasta.nbpantalla, onav.tpnavegacion, onav.stopenwindow)
            Next
            txtnavegacion.Text = "Un total de " & cnavs.Count & " Navegaciones"
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmProyecto.Load_gridNavegaciones()", "Ocurrio un error al leer la navegación")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmProyecto.Load_gridNavegaciones()", "Ocurrio un error al leer la navegación [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub btnavdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnavdel.Click
        Try
            If Me.gridNavegacion.SelectedRows.Count > 0 Then
                obus.delNavegacion(Me.cdproject, outil.Toma_Token(1, Me.gridNavegacion.SelectedRows.Item(0).Cells("scdesde").Value, "-"), outil.Toma_Token(1, Me.gridNavegacion.SelectedRows.Item(0).Cells("scdhasta").Value, "-"))
                MsgBox("Se ha eliminado el registro de la navegación del proyecto", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
                Me.Load_gridNavegaciones(Me.cdproject)
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmProyecto.btnavdel_Click()", "Ocurrio un error al eliminar la navegación")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub btnavadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnavadd.Click
        Dim ofrm As frmaddNavegacion
        ofrm = New frmaddNavegacion
        ofrm.MdiParent = Me.ParentForm
        ofrm.cdproject = Me.cdproject
        ofrm.Show()
    End Sub

    Private Sub btnavdetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnavdetalle.Click
        If Me.gridNavegacion.SelectedRows.Count > 0 Then
            Try
                Dim ofrm As frmNavegacion
                ofrm = New frmNavegacion
                ofrm.MdiParent = Me.ParentForm
                ofrm.cdproject = Me.cdproject
                ofrm.cdesde = outil.Toma_Token(1, Me.gridNavegacion.SelectedRows.Item(0).Cells("scdesde").Value, "-")
                ofrm.cdhasta = outil.Toma_Token(1, Me.gridNavegacion.SelectedRows.Item(0).Cells("scdhasta").Value, "-")
                ofrm.Show()
            Catch ex As Exception
                MsgBox("EXCEPCION : " & ex.Message)
            End Try
        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub

End Class
