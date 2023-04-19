Option Explicit On
Imports MyLIB

Public Class frmPantalla
    Private obus As Catalogos
    Private scdproject As String        'Clave del proyecto
    Private scdpantalla As String       'Clave de la pantalla
    Private oproject As Proyecto        'Objeto que tiene las propiedades del proyecto
    Private opantalla As Pantalla       'Objeto que tiene las propiedades de la pantalla
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

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmPantalla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro
        Dim cstanalisis As Collection
        Dim canalistas As Collection
        Dim cprogramers As Collection
        Dim ocrit As Criterio

        Try
            oparent = Me.ParentForm

            'PASO 1: Incializa los objetos de negocio y utilerias
            obus = New Catalogos(oparent.conexion)
            outil = New Utilerias
            ocrit = New Criterio

            'PASO 2: Consulta los estatus del analisis
            cstanalisis = obus.getStAnalisis()
            For Each ost As Estatus In cstanalisis
                cbostanalisis.Items.Add(ost.clave & " - " & ost.nombre)
            Next

            'PASO 4: Consulta los analistas involucrados en este proyecto
            ocrit.cdproyecto = Me.cdproject
            canalistas = obus.getStaffs(ocrit)
            cboanalista.Items.Add("000000 - DESCONOCIDO")
            For Each ostaff As Staff In canalistas
                cboanalista.Items.Add(ostaff.cdpersona & " - " & ostaff.nbpersona)
            Next

            cprogramers = obus.getStaffs(ocrit)
            cboprogramador.Items.Add("000000 - DESCONOCIDO")
            For Each ostaff As Staff In cprogramers
                cboprogramador.Items.Add(ostaff.cdpersona & " - " & ostaff.nbpersona)
            Next

            'PASO 5: Consulta los datos del proyecto y la pantalla
            oproject = obus.getProyecto(Me.cdproject)
            opantalla = obus.getPantalla(Me.cdproject, Me.cdpantalla)
            txtcdproyecto.Text = oproject.cdproyecto
            txtnbproyecto.Text = oproject.nbproyecto
            txtmainclave.Text = opantalla.cdpantalla
            txtmainame.Text = opantalla.nbpantalla
            txtnombre.Text = opantalla.nbpantalla
            cbostanalisis.SelectedIndex = Me.cbostanalisis.FindString(opantalla.cdstanalisis)
            cboanalista.SelectedIndex = Me.cboanalista.FindString(opantalla.cdanalista)
            cboprogramador.SelectedIndex = Me.cboprogramador.FindString(opantalla.cdprogramador)
            txtcodigo.Text = opantalla.cdcodigo
            txtimagen.Text = opantalla.nbimagefile
            txtobjetivo.Text = opantalla.txobjetivo
            txtComentario.Text = opantalla.txcomment

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPantalla.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmPantalla.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub cmdgrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgrabar.Click

        Try
            opantalla = New Pantalla
            opantalla.cdproyecto = Me.cdproject
            opantalla.cdpantalla = Me.cdpantalla
            opantalla.cdstanalisis = outil.Toma_Token(1, Me.cbostanalisis.SelectedItem, "-")
            opantalla.cdanalista = outil.Toma_Token(1, Me.cboanalista.SelectedItem, "-")
            opantalla.cdprogramador = outil.Toma_Token(1, Me.cboprogramador.SelectedItem, "-")
            opantalla.cdcodigo = Me.txtcodigo.Text
            opantalla.nbpantalla = Me.txtnombre.Text
            opantalla.nbimagefile = Me.txtimagen.Text
            opantalla.txobjetivo = Me.txtobjetivo.Text
            opantalla.txcomment = Me.txtComentario.Text

            'PASO 2: actualiza la información del proyecto
            obus.savePantalla(opantalla)
            Me.txtmainame.Text = opantalla.nbpantalla
            MsgBox("Fué un exito la actualización  de la pantalla", MsgBoxStyle.Information, "HANYGEN SOFTWARE")

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPantalla.cmdgrabar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmPantalla.cmdgrabar_Click()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnimagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimagen.Click
        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "TODO(*.*)|*.*|GIF (*.gif)|*.gif|JPEG (*.jpg,*.jpeg,*.jpe,*.jfif)|*.jpg,*.jpeg,*.jpe,*.jfif,*.JPG"
        If Me.txtimagen.Text.Equals("") Or Me.txtimagen.Text.Equals("NA") Then
            OpenFileDialog.InitialDirectory = Comun.STR_DIRECTORIO
        Else
            OpenFileDialog.FileName = Me.txtimagen.Text
        End If
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Me.txtimagen.Text = OpenFileDialog.FileName
            Comun.STR_DIRECTORIO = OpenFileDialog.RestoreDirectory
        End If
    End Sub

    Private Sub btnstaffload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstaffload.Click
        If outil.Existe_Archivo(opantalla.nbimagefile) Then
            Me.picpreview.Load(opantalla.nbimagefile)
        Else
            MsgBox("El archivo [" & opantalla.nbimagefile & "] no existe", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btnimagemax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimagemax.Click
        If outil.Existe_Archivo(opantalla.nbimagefile) Then
            Dim ofrm As frmImagen
            ofrm = New frmImagen
            ofrm.MdiParent = Me.ParentForm
            ofrm.Paint_FileImagen(opantalla.nbimagefile)
            ofrm.Show()
        Else
            MsgBox("El archivo [" & opantalla.nbimagefile & "] no existe", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btnstackload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbotload.Click
        Call Consulta_Botones()
    End Sub

    Private Sub Consulta_Botones()
        Dim cbotones As Collection

        cbotones = Nothing
        Try
            gridBotones.Rows.Clear()
            gridBotones.Columns.Clear()
            gridBotones.Columns.Add("clave", "Clave")
            gridBotones.Columns.Add("nombre", "Nombre")
            gridBotones.Columns.Add("comment", "Comentario")

            gridBotones.Columns.Item(0).Width = 60
            gridBotones.Columns.Item(1).Width = 150
            gridBotones.Columns.Item(2).Width = 400

            gridBotones.Columns.Item(0).SortMode = DataGridViewColumnSortMode.NotSortable
            gridBotones.Columns.Item(1).SortMode = DataGridViewColumnSortMode.NotSortable
            gridBotones.Columns.Item(2).SortMode = DataGridViewColumnSortMode.NotSortable

            cbotones = obus.getPantallaBotones(Me.cdproject, Me.cdpantalla)

            For Each oboton As PantallaBoton In cbotones
                gridBotones.Rows.Add(oboton.cdboton, oboton.nbboton, oboton.txcomment)
            Next
            Me.txttotbotones.Text = "Un total de " & cbotones.Count & " botones"

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPantalla.Consulta_Botones()", "Ocurrio un error")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub btnbotdetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbotdetalle.Click
        If Me.gridBotones.SelectedRows.Count > 0 Then
            Dim ofrm As frmPantallaBoton
            ofrm = New frmPantallaBoton
            ofrm.MdiParent = Me.ParentForm
            ofrm.cdproject = Me.cdproject
            ofrm.cdpantalla = Me.cdpantalla
            ofrm.cdboton = Me.gridBotones.SelectedRows.Item(0).Cells("clave").Value
            ofrm.Show()
        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btnbotadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbotadd.Click
        Dim ofrm As frmPantallaBoton
        ofrm = New frmPantallaBoton
        ofrm.MdiParent = Me.ParentForm
        ofrm.cdproject = Me.cdproject
        ofrm.cdpantalla = Me.cdpantalla
        ofrm.Show()
    End Sub

    Private Sub btnbotdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbotdel.Click
        Try
            If Me.gridBotones.SelectedRows.Count > 0 Then
                obus.delPantallaBoton(Me.cdproject, Me.cdpantalla, Me.gridBotones.SelectedRows.Item(0).Cells("clave").Value)
                MsgBox("Se ha eliminado el boton de la pantalla", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
                Call Consulta_Botones()
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPantalla.btnbotdel_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub btncamload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncamload.Click
        Call Consulta_Campos()
        Call Consulta_Arreglos()
    End Sub

    Private Sub Consulta_Campos()
        Dim ccampos As Collection

        Try
            gridcampos.Rows.Clear()
            gridcampos.Columns.Clear()
            gridcampos.Columns.Add("clave", "Clave")
            gridcampos.Columns.Add("nombre", "Nombre")
            gridcampos.Columns.Add("comment", "Comentario")

            gridcampos.Columns.Item(0).Width = 60
            gridcampos.Columns.Item(1).Width = 200
            gridcampos.Columns.Item(2).Width = 400

            gridcampos.Columns.Item(0).SortMode = DataGridViewColumnSortMode.NotSortable
            gridcampos.Columns.Item(1).SortMode = DataGridViewColumnSortMode.NotSortable
            gridcampos.Columns.Item(2).SortMode = DataGridViewColumnSortMode.NotSortable

            ccampos = obus.getPantallaCampos(Me.cdproject, Me.cdpantalla)

            For Each ocam As PantallaCampo In ccampos
                gridcampos.Rows.Add(ocam.cdcampo, ocam.nbcampo, ocam.txcomment)
            Next
            txttotcampos.Text = "Un total de " & ccampos.Count & " campos"""

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPantalla.Consulta_Campos()", "Ocurrio un error")
            outil.ShowException(ex)
        End Try
    End Sub


    Private Sub botcamdetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botcamdetalle.Click
        If Me.gridcampos.SelectedRows.Count > 0 Then
            Dim ofrm As frmPantallaCampo
            ofrm = New frmPantallaCampo
            ofrm.MdiParent = Me.ParentForm
            ofrm.cdproject = Me.cdproject
            ofrm.cdpantalla = Me.cdpantalla
            ofrm.cdcampo = Me.gridcampos.SelectedRows.Item(0).Cells("clave").Value
            ofrm.Show()
        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btncamadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncamadd.Click
        Dim ofrm As frmaddPantallaCampo
        ofrm = New frmaddPantallaCampo
        ofrm.MdiParent = Me.ParentForm
        ofrm.cdproject = Me.cdproject
        ofrm.cdpantalla = Me.cdpantalla
        ofrm.Show()
    End Sub

    Private Sub btncamdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncamdel.Click
        Try
            If Me.gridcampos.SelectedRows.Count > 0 Then
                obus.delPantallaCampo(Me.cdproject, Me.cdpantalla, Me.gridcampos.SelectedRows.Item(0).Cells("clave").Value)
                MsgBox("Se ha eliminado el campo de la pantalla", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
                Call Consulta_Campos()
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPantalla.btncamdel_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As frmXMLTree
        ofrm = New frmXMLTree
        ofrm.MdiParent = Me.ParentForm
        ofrm.Show()
    End Sub

    Private Sub Load_grideventos()
        Dim ceventos As Collection

        Try
            grideventos.Rows.Clear()
            grideventos.Columns.Clear()
            grideventos.Columns.Add("clave", "Clave")
            grideventos.Columns.Add("nombre", "Nombre")
            grideventos.Columns.Add("comment", "Comentario")

            grideventos.Columns.Item("clave").Width = 60
            grideventos.Columns.Item("nombre").Width = 200
            grideventos.Columns.Item("comment").Width = 300

            grideventos.Columns.Item("clave").SortMode = DataGridViewColumnSortMode.NotSortable
            grideventos.Columns.Item("nombre").SortMode = DataGridViewColumnSortMode.NotSortable
            grideventos.Columns.Item("comment").SortMode = DataGridViewColumnSortMode.NotSortable

            ceventos = obus.getPantallaEventos(Me.cdproject, Me.cdpantalla)

            For Each omet As PantallaEvento In ceventos
                Me.grideventos.Rows.Add(omet.cdevento, omet.nbevento, omet.txcomment)
            Next
            txteventos.Text = "Un total de " & ceventos.Count & " eventos"
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPantalla.Load_grideventos()", "Ocurrio un error al cargar los eventos")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub btnavload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnavload.Click
        Load_gridNavegaciones(Me.cdproject, Me.cdpantalla)
    End Sub

    Private Sub Load_gridNavegaciones(ByVal scdproject As String, ByVal scdpantalla As String)
        Dim cnavs As Collection

        Try
            gridNavegacion.Rows.Clear()
            gridNavegacion.Columns.Clear()
            gridNavegacion.Columns.Add("scdhasta", "Pantalla Final")
            gridNavegacion.Columns.Add("tipo", "Tipo")
            gridNavegacion.Columns.Add("stopen", "Open Window")

            gridNavegacion.Columns.Item("scdhasta").Width = 300

            gridNavegacion.Columns.Item("scdhasta").SortMode = DataGridViewColumnSortMode.NotSortable
            gridNavegacion.Columns.Item("tipo").SortMode = DataGridViewColumnSortMode.NotSortable
            gridNavegacion.Columns.Item("stopen").SortMode = DataGridViewColumnSortMode.NotSortable

            cnavs = obus.getNavegaciones(scdproject, scdpantalla)

            For Each onav As Navegacion In cnavs
                Dim ohasta As Pantalla = obus.getPantalla(scdproject, onav.cdhasta)
                gridNavegacion.Rows.Add(onav.cdhasta & "-" & ohasta.nbpantalla, onav.tpnavegacion, onav.stopenwindow)
            Next
            txtnavegacion.Text = "Un total de " & cnavs.Count & " Navegaciones"

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPantalla.Load_gridNavegaciones()", "Ocurrio un error al cargar los eventos")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmPantalla.Load_gridNavegaciones()", "Ocurrio un error al cargar los eventos [" & ex1.ToString & "]"))
        End Try


    End Sub

    Private Sub btnavdetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnavdetalle.Click
        If Me.gridNavegacion.SelectedRows.Count > 0 Then
            Try
                Dim ofrm As frmNavegacion
                ofrm = New frmNavegacion
                ofrm.MdiParent = Me.ParentForm
                ofrm.cdproject = Me.cdproject
                ofrm.cdesde = Me.cdpantalla
                ofrm.cdhasta = outil.Toma_Token(1, Me.gridNavegacion.SelectedRows.Item(0).Cells("scdhasta").Value, "-")
                ofrm.Show()
            Catch ex As Exception
                MsgBox("EXCEPCION : " & ex.Message)
            End Try
        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btnavdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnavdel.Click
        Try
            If Me.gridNavegacion.SelectedRows.Count > 0 Then
                obus.delNavegacion(Me.cdproject, Me.cdpantalla, outil.Toma_Token(1, Me.gridNavegacion.SelectedRows.Item(0).Cells("scdhasta").Value, "-"))
                MsgBox("Se ha eliminado el registro de la navegación del proyecto", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
                Me.Load_gridNavegaciones(Me.cdproject, Me.cdpantalla)
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPantalla.btnavdel_Click()", "Ocurrio un error al eliminar la navegación")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub btnavadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnavadd.Click
        Dim ofrm As frmaddNavegacion
        ofrm = New frmaddNavegacion
        ofrm.MdiParent = Me.ParentForm
        ofrm.cdproject = Me.cdproject
        ofrm.cddesde = Me.cdpantalla
        ofrm.Show()
    End Sub

    Private Sub btncamarradd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncamarradd.Click
        Dim ofrm As frmaddArreglo
        ofrm = New frmaddArreglo
        ofrm.MdiParent = Me.ParentForm
        ofrm.cdproject = Me.cdproject
        ofrm.cdpantalla = Me.cdpantalla
        ofrm.Show()
    End Sub


    Private Sub Consulta_Arreglos()
        Dim carreglos As Collection
        Try
            gridarreglos.Rows.Clear()
            gridarreglos.Columns.Clear()
            gridarreglos.Columns.Add("clave", "Clave")
            gridarreglos.Columns.Add("nombre", "Nombre")
            gridarreglos.Columns.Item(0).Width = 60
            gridarreglos.Columns.Item(1).Width = 210
            gridarreglos.Columns.Item(0).SortMode = DataGridViewColumnSortMode.NotSortable
            gridarreglos.Columns.Item(1).SortMode = DataGridViewColumnSortMode.NotSortable

            carreglos = obus.getPantallarreglos(Me.cdproject, Me.cdpantalla)
            For Each oarr As Pantallarreglo In carreglos
                gridarreglos.Rows.Add(oarr.cdarreglo, oarr.nbarreglo)
            Next
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPantalla.Consulta_Arreglos()", "Ocurrio un error")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub btncamarrdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncamarrdel.Click
        Try
            If Me.gridarreglos.SelectedRows.Count > 0 Then
                obus.delPantallarreglo(Me.cdproject, Me.cdpantalla, Me.gridarreglos.SelectedRows.Item(0).Cells("clave").Value)
                MsgBox("Se ha eliminado el arreglo de la pantalla", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
                Call Consulta_Arreglos()
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPantalla.btncamarrdel_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub botarrdetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botarrdetalle.Click
        If Me.gridarreglos.SelectedRows.Count > 0 Then
            Dim ofrm As frmPantallaArreglo
            ofrm = New frmPantallaArreglo
            ofrm.MdiParent = Me.ParentForm
            ofrm.cdproject = Me.cdproject
            ofrm.cdpantalla = Me.cdpantalla
            ofrm.cdarreglo = Me.gridarreglos.SelectedRows.Item(0).Cells("clave").Value
            ofrm.Show()
        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub lkntools_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lkntools.LinkClicked
        Dim ofrm As frmPantallaTools
        ofrm = New frmPantallaTools()
        ofrm.cdproject = Me.cdproject
        ofrm.cdpantalla = Me.cdpantalla
        ofrm.MdiParent = Me.ParentForm
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub

    Private Sub cmdeventoadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeventoadd.Click
        Dim ofrm As frmaddPantallaEvento
        ofrm = New frmaddPantallaEvento
        ofrm.MdiParent = Me.ParentForm
        ofrm.cdproject = Me.cdproject
        ofrm.cdpantalla = Me.cdpantalla
        ofrm.Show()
    End Sub

    Private Sub cmdeventodel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeventodel.Click
        Try
            If Me.grideventos.SelectedRows.Count > 0 Then
                obus.delPantallaEvento(Me.cdproject, Me.cdpantalla, Me.grideventos.SelectedRows.Item(0).Cells("clave").Value)
                MsgBox("Se ha eliminado el llamado al evento de la pantalla", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
                Call Me.Load_grideventos()
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPantalla.cmdeventodel_Click()", "Ocurrio un error al eliminar el evento")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub btneventosload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneventosload.Click
        Call Load_grideventos()
    End Sub

    Private Sub btnmetobjectdetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmetobjectdetalle.Click
        If Me.grideventos.SelectedRows.Count > 0 Then
            Dim ofrm As frmPantallaEvento
            ofrm = New frmPantallaEvento
            ofrm.MdiParent = Me.ParentForm
            ofrm.cdproject = Me.cdproject
            ofrm.cdpantalla = Me.cdpantalla
            'RMT RMT ofrm.cdevento = Me.grideventos.SelectedRows.Item(0).Cells("clave").Value
            ofrm.Show()
        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "MySUIT")
        End If
    End Sub
End Class