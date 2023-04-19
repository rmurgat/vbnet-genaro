Option Explicit On

Imports MyLIB

Public Class frmDBEntidad
    Private obus As Catalogos
    Private scdftedatos As String       'Clave de la fuente de datos
    Private snbdbentidad As String      'Nombre de la entidad de datos
    Private odbentidad As EntidaDato     'Objeto que tiene las propiedades de una entidad de datos
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
    ''' PROPIEDAD: Nombre de la entidad de datos
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbdbentidad() As String
        Get
            Return snbdbentidad
        End Get
        Set(ByVal pscd As String)
            snbdbentidad = pscd
        End Set
    End Property

    Private Sub frmDBEntidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro
        Dim ctipos As Collection

        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            oparent = Me.ParentForm
            obus = New Catalogos(oparent.conexion)
            outil = New Utilerias

            'PASO 3: LLena el catálogo de tipos de entidad de datos
            ctipos = obus.getTpEntidaDatos()
            For Each otipo As Tipo In ctipos
                cboTipo.Items.Add(otipo.clave & " - " & otipo.nombre)
            Next

            Call Consultar_EntidadDatos()
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmDBEntidad.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub Consultar_EntidadDatos()
        Try
            odbentidad = obus.getEntidaDato(Me.cdftedatos, Me.nbdbentidad)
            Me.txtmainame.Text = odbentidad.nbentidadato
            Me.txtnombre.Text = odbentidad.nbentidadato
            Me.cboTipo.SelectedIndex = Me.cboTipo.FindString(odbentidad.tpentidadato)
            Me.txtComment.Text = odbentidad.txcomment
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmDBEntidad.Consultar_EntidadDatos()", "Ocurrio un error al consultar las empresas")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyCATALOGOS.frmDBEntidad.Consultar_EntidadDatos()", "Ocurrio un error al consultar las empresas [" & ex1.ToString & "]")
        End Try
    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btncamadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncamadd.Click
        Dim ofrm As frmDBEntidadCampo
        ofrm = New frmDBEntidadCampo
        ofrm.MdiParent = Me.ParentForm
        ofrm.cdftedatos = Me.cdftedatos
        ofrm.nbdbentidad = Me.nbdbentidad
        ofrm.Show()
    End Sub

    Private Sub btncamposload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncamposload.Click
        Load_gridcampos(Me.cdftedatos, Me.nbdbentidad)
    End Sub

    Private Sub Load_gridcampos(ByVal scdftedatos As String, ByVal snbentidad As String)
        Dim ccampos As Collection

        Try
            gridcampos.Rows.Clear()
            gridcampos.Columns.Clear()
            gridcampos.Columns.Add("snbentidad", "Nombre")
            gridcampos.Columns.Add("sllave", "Llave")
            gridcampos.Columns.Add("stpentidad", "Tipo")
            gridcampos.Columns.Add("stxcomment", "Comentario")
            gridcampos.Columns.Item("snbentidad").Width = 100
            gridcampos.Columns.Item("sllave").Width = 40
            gridcampos.Columns.Item("stxcomment").Width = 300
            gridcampos.Columns.Item("snbentidad").SortMode = DataGridViewColumnSortMode.NotSortable
            gridcampos.Columns.Item("sllave").SortMode = DataGridViewColumnSortMode.NotSortable
            gridcampos.Columns.Item("stpentidad").SortMode = DataGridViewColumnSortMode.NotSortable
            gridcampos.Columns.Item("stxcomment").SortMode = DataGridViewColumnSortMode.NotSortable

            ccampos = obus.getEntidaDatoCampos(scdftedatos, snbentidad)

            For Each ocampo As EntidaDatoCampo In ccampos
                gridcampos.Rows.Add(ocampo.nbcampo, IIf(ocampo.isllave, "*", ""), ocampo.cdtpdatofisico, ocampo.txcomment)
            Next
            Me.txttotcampos.Text = "Un total de " & ccampos.Count & " campos"

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmDBEntidad.Load_gridcampos()", "Ocurrio un error al cargar los campos")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmDBEntidad.Load_gridcampos()", "Ocurrio un error al cargar los campos [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub btncamdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncamdel.Click
        Try
            If Me.gridcampos.SelectedRows.Count > 0 Then
                obus.delEntidaDatoCampo(Me.cdftedatos, Me.nbdbentidad, Me.gridcampos.SelectedRows.Item(0).Cells(0).Value)
                MsgBox("Se ha eliminado el campo de la entidad de datos", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
                Me.Load_gridcampos(Me.cdftedatos, Me.nbdbentidad)
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmDBEntidad.btncamdel_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmDBEntidad.btncamdel_Click()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub btncamdetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncamdetalle.Click
        If Me.gridcampos.SelectedRows.Count > 0 Then
            Dim ofrm As frmDBEntidadCampo
            ofrm = New frmDBEntidadCampo
            ofrm.MdiParent = Me.ParentForm
            ofrm.cdftedatos = Me.cdftedatos
            ofrm.nbdbentidad = Me.nbdbentidad
            ofrm.nbdbcampo = Me.gridcampos.SelectedRows.Item(0).Cells(0).Value
            ofrm.Show()
        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btngengrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnentgrabar.Click
        'PASO 1: Lee los valores 
        odbentidad.txcomment = Me.txtComment.Text
        odbentidad.tpentidadato = outil.Toma_Token(1, Me.cboTipo.SelectedItem, "-")

        'PASO 2: actualiza la actualización de la entidad
        Try
            obus.saveEntidaDato(odbentidad)
            MsgBox("Fué un exito la actualización de la entidad", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmDBEntidad.btngengrabar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmDBEntidad.btngengrabar_Click()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub
End Class