Option Explicit On

Imports MyLIB

Public Class frmFuenteDatos
    Private obus As Catalogos
    Private scdftedatos As String       'Clave de la fuente de datos
    Private ofuentedatos As FuenteDato  'Objeto que tiene las propiedades de una fuente de datos
    Private outil As Utilerias          'Utilerias del sistema
    Private bSoloLectura As Boolean     'bandera de solo lectura

    ''' <summary>
    ''' PROPIEDAD: Clave de la fuente de datos
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdftedatos() As String
        Get
            Return scdftedatos
        End Get
        Set(ByVal pscd As String)
            scdftedatos = pscd
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

    Private Sub frmFuenteDatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro
        Dim cctes As Collection

        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            oparent = Me.ParentForm
            obus = New Catalogos(oparent.conexion)
            outil = New Utilerias

            'PASO 3: LLena el catálogo de clientes
            cctes = obus.getClientes()
            For Each octe As Cliente In cctes
                cboCliente.Items.Add(octe.cdcliente & " - " & octe.nbcliente)
            Next

            Call Consultar_FuenteDeDatos()

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmFuenteDatos.Load()", "Ocurrio un error al cargar la pantalla")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyCATALOGOS.frmFuenteDatos.Load()", "Ocurrio un error al cargar la pantalla [" & ex1.ToString & "]")
        End Try

    End Sub

    ''' <summary>
    ''' Procedimiento para consulta toda la información de un proyecto
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Consultar_FuenteDeDatos()
        Try
            ofuentedatos = obus.getFuenteDato(Me.cdftedatos)
            If ofuentedatos Is Nothing Then
                MsgBox("Existio un error al consulta la información de la fuente de datos [" + Me.scdftedatos + "]", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
                Exit Sub
            End If
            Me.txtmainclave.Text = ofuentedatos.cdfuentedato
            Me.txtmainame.Text = ofuentedatos.nbfuentedato
            Me.txtclave.Text = ofuentedatos.cdfuentedato
            Me.txtnombre.Text = ofuentedatos.nbfuentedato
            Me.cboCliente.SelectedIndex = Me.cboCliente.FindString(ofuentedatos.cdcliente)
            Me.cbotipo.SelectedIndex = Me.cbotipo.FindString(ofuentedatos.tpfuentedato)
            Me.txtconexion.Text = ofuentedatos.cdconexion
            Me.txtComentario.Text = ofuentedatos.txcomment
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmFuenteDatos.Consultar_FuenteDeDatos()", "Ocurrio un error al consultar la fuente de datos")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyCATALOGOS.frmFuenteDatos.Consultar_FuenteDeDatos()", "Ocurrio un error al consultar la fuente de datos [" & ex1.ToString & "]")
        End Try
    End Sub

    Private Sub btngengrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngengrabar.Click
        Try
            'PASO 1: Lee los valores 
            ofuentedatos.cdfuentedato = Me.txtclave.Text
            ofuentedatos.nbfuentedato = Me.txtnombre.Text
            ofuentedatos.cdconexion = Me.txtconexion.Text
            ofuentedatos.txcomment = Me.txtComentario.Text
            ofuentedatos.cdcliente = outil.Toma_Token(1, Me.cboCliente.SelectedItem, "-")
            ofuentedatos.tpfuentedato = outil.Toma_Token(1, Me.cbotipo.SelectedItem, "-")

            'PASO 2: actualiza la información del proyecto
            obus.saveFuenteDato(ofuentedatos)
            Me.txtmainame.Text = ofuentedatos.nbfuentedato
            MsgBox("Fué un exito la actualización de la fuente de datos", MsgBoxStyle.Information, "HANYGEN SOFTWARE")

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmFuenteDatos.btngengrabar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmFuenteDatos.btngengrabar_Click()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnentyload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnentyload.Click
        Load_gridentidades(Me.cdftedatos)
    End Sub

    Private Sub Load_gridentidades(ByVal scdftedatos As String)
        Dim centys As Collection

        Try
            gridentidades.Rows.Clear()
            gridentidades.Columns.Clear()
            gridentidades.Columns.Add("snbentidad", "Nombre")
            gridentidades.Columns.Add("stpentidad", "Tipo")
            gridentidades.Columns.Add("stxcomment", "Comentario")
            gridentidades.Columns.Item(0).Width = 200
            gridentidades.Columns.Item(2).Width = 300

            gridentidades.Columns.Item("snbentidad").SortMode = DataGridViewColumnSortMode.NotSortable
            gridentidades.Columns.Item("stpentidad").SortMode = DataGridViewColumnSortMode.NotSortable
            gridentidades.Columns.Item("stxcomment").SortMode = DataGridViewColumnSortMode.NotSortable

            centys = obus.getEntidaDatos(scdftedatos)

            For Each oent As EntidaDato In centys
                'Dim otipo As Tipo = obus.getTpEntidaDato(oent.tpentidadato)
                gridentidades.Rows.Add(oent.nbentidadato, oent.tpentidadato, oent.txcomment)
            Next
            txttotentidades.Text = "Un total de " & centys.Count & " entidades"

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmFuenteDatos.Load_gridentidades()", "Ocurrio un error al consultar las empresas")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyCATALOGOS.frmFuenteDatos.Load_gridentidades()", "Ocurrio un error al consultar las empresas [" & ex1.ToString & "]")
        End Try

    End Sub


    Private Sub btnrepadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrepadd.Click
        Dim ofrm As frmaddentidaddb
        ofrm = New frmaddentidaddb
        ofrm.MdiParent = Me.ParentForm
        ofrm.cdftedatos = Me.cdftedatos
        ofrm.Show()
    End Sub

    Private Sub btnrepdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrepdel.Click
        If Me.gridentidades.SelectedRows.Count > 0 Then
            If obus.delEntidaDato(Me.cdftedatos, Me.gridentidades.SelectedRows.Item(0).Cells(0).Value) Then
                MsgBox("Se ha eliminado el registro de la entidad de datos", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
                Me.Load_gridentidades(Me.cdftedatos)
            Else
                MsgBox("Existio un error al eliminar el registro de la entidad de datos", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
            End If
        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btnrepdetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrepdetalle.Click
        If Me.gridentidades.SelectedRows.Count > 0 Then
            Dim ofrm As frmDBEntidad
            ofrm = New frmDBEntidad
            ofrm.MdiParent = Me.ParentForm
            ofrm.cdftedatos = Me.cdftedatos
            ofrm.nbdbentidad = Me.gridentidades.SelectedRows.Item(0).Cells(0).Value
            ofrm.Show()
        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub
End Class