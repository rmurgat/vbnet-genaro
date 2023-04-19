Option Explicit On
Imports MyLIB

Public Class frmReporte
    Private obus As Catalogos
    Private scdproject As String        'Clave del proyecto
    Private scdreporte As String       'Clave de la pantalla
    Private oproject As Proyecto        'Objeto que tiene las propiedades del proyecto
    Private oreporte As Reporte         'Objeto que tiene las propiedades del reporte
    Private outil As Utilerias          'Utilerias del sistema
    Private bSoloLectura As Boolean     'bandera de solo lectura

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
    ''' PROPIEDAD: Clave del reporte
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdreporte() As String
        Get
            Return scdreporte
        End Get
        Set(ByVal pscd As String)
            scdreporte = pscd
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

    Private Sub frmReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro
        Dim cstanalisis As Collection
        Dim cstconstruccion As Collection
        Dim canalistas As Collection
        Dim cprogramers As Collection
        Dim ocrit As Criterio

        oparent = Me.ParentForm

        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            obus = New Catalogos(oparent.conexion)
            outil = New Utilerias
            ocrit = New Criterio

            'PASO 2: Consulta los estatus del analisis
            cstanalisis = obus.getStAnalisis()
            For Each ost As Estatus In cstanalisis
                cbostanalisis.Items.Add(ost.clave & " - " & ost.nombre)
            Next

            'PASO 3: Consulta los estatus de la construcción
            cstconstruccion = obus.getStConstruccion
            For Each ost As Estatus In cstconstruccion
                cbostconstruc.Items.Add(ost.clave & " - " & ost.nombre)
            Next

            'PASO 4: Consulta los analistas involucrados en este proyecto
            ocrit.cdproyecto = Me.cdproject
            ocrit.cdrolstaff = "'" & Comun.STR_ROLANALISTA & "','" & Comun.STR_ROLPROGANALISTA & "'"
            canalistas = obus.getStaffs(ocrit)
            cboanalista.Items.Add("000000 - DESCONOCIDO")
            For Each ostaff As Staff In canalistas
                cboanalista.Items.Add(ostaff.cdpersona & " - " & ostaff.nbpersona)
            Next

            ocrit.cdrolstaff = "'" & Comun.STR_ROLPROGRAMADOR & "','" & Comun.STR_ROLPROGANALISTA & "'"
            cprogramers = obus.getStaffs(ocrit)
            cboprogramador.Items.Add("000000 - DESCONOCIDO")
            For Each ostaff As Staff In cprogramers
                cboprogramador.Items.Add(ostaff.cdpersona & " - " & ostaff.nbpersona)
            Next

            'PASO 5: Consulta los datos del proyecto y la pantalla
            oproject = obus.getProyecto(Me.cdproject)
            oreporte = obus.getReporte(Me.cdproject, Me.cdreporte)
            txtcdproyecto.Text = oproject.cdproyecto
            txtnbproyecto.Text = oproject.nbproyecto
            txtmainclave.Text = oreporte.cdreporte
            txtmainame.Text = oreporte.nbreporte
            txtnombre.Text = oreporte.nbreporte
            cbostanalisis.SelectedIndex = Me.cbostanalisis.FindString(oreporte.cdstanalisis)
            cbostconstruc.SelectedIndex = Me.cbostconstruc.FindString(oreporte.cdstconstruccion)
            cboanalista.SelectedIndex = Me.cboanalista.FindString(oreporte.cdanalista)
            cboprogramador.SelectedIndex = Me.cboprogramador.FindString(oreporte.cdprogramador)
            txtcodigo.Text = oreporte.cdcodigo
            txtimagen.Text = oreporte.nbimagefile
            txtobjetivo.Text = oreporte.txobjetivo
            txtComentario.Text = oreporte.txcomment

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmReporte.frmReporte_Load()", "Ocurrio un error al cargar la pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdgrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgrabar.Click
        Try
            oreporte = New Reporte
            oreporte.cdproyecto = Me.cdproject
            oreporte.cdreporte = Me.cdreporte
            oreporte.cdstanalisis = outil.Toma_Token(1, Me.cbostanalisis.SelectedItem, "-")
            oreporte.cdstconstruccion = outil.Toma_Token(1, Me.cbostconstruc.SelectedItem, "-")
            oreporte.cdanalista = outil.Toma_Token(1, Me.cboanalista.SelectedItem, "-")
            oreporte.cdprogramador = outil.Toma_Token(1, Me.cboprogramador.SelectedItem, "-")
            oreporte.cdcodigo = Me.txtcodigo.Text
            oreporte.nbreporte = Me.txtnombre.Text
            oreporte.nbimagefile = Me.txtimagen.Text
            oreporte.txobjetivo = Me.txtobjetivo.Text
            oreporte.txcomment = Me.txtComentario.Text

            'PASO 2: actualiza la información del proyecto
            obus.saveReporte(oreporte)
            Me.txtmainame.Text = oreporte.nbreporte
            MsgBox("Fué un exito la actualización del reporte", MsgBoxStyle.Information, "HANYGEN SOFTWARE")

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmReporte.cmdgrabar_Click()", "Ocurrio un error al grabar los datos del reporte")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub btnstaffload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstaffload.Click
        If outil.Existe_Archivo(oreporte.nbimagefile) Then
            Me.picpreview.Load(oreporte.nbimagefile)
        Else
            MsgBox("El archivo [" & oreporte.nbimagefile & "] no existe", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btnimagemax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimagemax.Click
        If outil.Existe_Archivo(oreporte.nbimagefile) Then
            Dim ofrm As frmImagen
            ofrm = New frmImagen
            ofrm.MdiParent = Me.ParentForm
            ofrm.Paint_FileImagen(oreporte.nbimagefile)
            ofrm.Show()
        Else
            MsgBox("El archivo [" & oreporte.nbimagefile & "] no existe", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btnimagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimagen.Click
        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "GIF (*.gif)|*.gif|JPEG (*.jpg,*.jpeg,*.jpe,*.jfif)|*.jpg,*.jpeg,*.jpe,*.jfif"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Me.txtimagen.Text = OpenFileDialog.FileName
        End If

    End Sub

    Private Sub btncamload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncamload.Click
        Load_gridcampos(Me.cdproject, Me.cdreporte)
        Call Consulta_Arreglos()
    End Sub

    Private Sub Consulta_Arreglos()
        Dim carreglos As Collection
        Try
            gridarreglos.Rows.Clear()
            gridarreglos.Columns.Clear()
            gridarreglos.Columns.Add("clave", "Clave")
            gridarreglos.Columns.Add("nombre", "Nombre")
            gridarreglos.Columns.Item(0).Width = 60
            gridarreglos.Columns.Item(1).Width = 200
            carreglos = obus.getReporteArreglos(Me.cdproject, Me.cdreporte)
            For Each oarr As ReporteArreglo In carreglos
                gridarreglos.Rows.Add(oarr.cdarreglo, oarr.nbarreglo)
            Next
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmReporte.Consulta_Arreglos()", "Ocurrio un error")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub Load_gridcampos(ByVal scdproject As String, ByVal scdreporte As String)
        Dim ccampos As Collection

        Try
            gridcampos.Rows.Clear()
            gridcampos.Columns.Clear()
            gridcampos.Columns.Add("scdproyecto", "Clave del Proyecto")
            gridcampos.Columns.Add("scdreporte", "Clave del Reporte")
            gridcampos.Columns.Add("scdcampo", "Clave del Campo")
            gridcampos.Columns.Add("snbcampo", "Nombre del Campo")
            gridcampos.Columns.Add("stxcomment", "Comentario")

            gridcampos.Columns.Item(3).Width = 200
            gridcampos.Columns.Item(4).Width = 200

            ccampos = obus.getReporteCampos(scdproject, scdreporte)
            For Each ocam As ReporteCampo In ccampos
                gridcampos.Rows.Add(ocam.cdproyecto, ocam.cdreporte, ocam.cdcampo, ocam.nbcampo, ocam.txcomment)
            Next

            txttotcampos.Text = "Un total de " & ccampos.Count & " campos"
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmReporte.Load_gridcampos()", "Ocurrio un error al leer los campos")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub botcamdetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botcamdetalle.Click
        If Me.gridcampos.SelectedRows.Count > 0 Then
            Try
                Dim ofrm As frmReporteCampo
                ofrm = New frmReporteCampo
                ofrm.MdiParent = Me.ParentForm
                ofrm.cdproject = Me.cdproject
                ofrm.cdreporte = Me.cdreporte
                ofrm.cdcampo = Me.gridcampos.SelectedRows.Item(0).Cells(2).Value
                ofrm.Show()
            Catch ex As Exception
                MsgBox("EXCEPCION : " & ex.Message)
            End Try

        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btncamdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncamdel.Click
        Try
            If Me.gridcampos.SelectedRows.Count > 0 Then
                obus.delReporteCampo(Me.cdproject, Me.cdreporte, Me.gridcampos.SelectedRows.Item(0).Cells(2).Value)
                MsgBox("Se ha eliminado el registro del campo del reporte", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
                Load_gridcampos(Me.cdproject, Me.cdreporte)
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmReporte.btncamdel_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub btncamadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncamadd.Click
        Dim ofrm As frmReporteCampo
        ofrm = New frmReporteCampo
        ofrm.MdiParent = Me.ParentForm
        ofrm.cdproject = Me.cdproject
        ofrm.cdreporte = Me.cdreporte
        ofrm.Show()
    End Sub

    Private Sub BindingNavigator1_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnbotload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbotload.Click

    End Sub

    Private Sub btncamarrdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncamarrdel.Click
        Try
            If Me.gridarreglos.SelectedRows.Count > 0 Then
                obus.delReporteArreglo(Me.cdproject, Me.cdreporte, Me.gridarreglos.SelectedRows.Item(0).Cells("clave").Value)
                MsgBox("Se ha eliminado el arreglo del reporte", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
                Call Consulta_Arreglos()
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmReporte.btncamarrdel_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub botarrdetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botarrdetalle.Click
        If Me.gridarreglos.SelectedRows.Count > 0 Then
            Dim ofrm As frmReporteArreglo
            ofrm = New frmReporteArreglo
            ofrm.MdiParent = Me.ParentForm
            ofrm.cdproject = Me.cdproject
            ofrm.cdreporte = Me.cdreporte
            ofrm.cdarreglo = Me.gridarreglos.SelectedRows.Item(0).Cells("clave").Value
            ofrm.Show()
        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btncamarradd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncamarradd.Click
        Dim ofrm As frmaddArreglo
        ofrm = New frmaddArreglo
        ofrm.MdiParent = Me.ParentForm
        ofrm.cdproject = Me.cdproject
        ofrm.cdreporte = Me.cdreporte
        ofrm.Show()
    End Sub
End Class