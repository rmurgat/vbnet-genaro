Option Explicit On
Imports MyLIB
Imports System.Data.SQLite

Public Class frmListEntidades
    Public sentidades As String     'entidades seleccionadas
    Public sfuente As String        'nombre de la fuente de datos
    Public oconexion As SQLiteConnection
    Private outil As Utilerias = New MyLIB.Utilerias

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        sentidades = "CANCEL"
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        sentidades = Leer_Marcadas()
        Me.Close()
    End Sub

    Private Sub frmListEntidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.sentidades = Me.sentidades & ","
    End Sub

    Private Sub chktodas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktodas.CheckedChanged
        Dim iren As Integer
        For iren = 0 To gridEntidades.Rows.Count - 1
            gridEntidades.Item("select", iren).Value = chktodas.Checked
        Next iren
    End Sub

    Private Sub Cargar_Registros(ByVal itipo As Integer)
        Dim oselect As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn(False)
        Dim centidades As Collection
        Dim imarcadas As Integer = 0
        Dim obus As Catalogos

        Try
            obus = New Catalogos(oconexion)
            oselect.Name = "select"
            oselect.HeaderText = "Seleccionar"
            oselect.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            oselect.Width = 60
            gridEntidades.Rows.Clear()
            gridEntidades.Columns.Clear()
            gridEntidades.Columns.Insert(0, oselect)
            gridEntidades.Columns.Add("entidad", "Entidad")
            gridEntidades.Columns.Add("tipo", "Tipo")
            gridEntidades.Columns.Add("comment", "Descripción")
            gridEntidades.Columns.Item("entidad").Width = 200
            gridEntidades.Columns.Item("tipo").Width = 100
            gridEntidades.Columns.Item("comment").Width = 290
            gridEntidades.Columns.Item("entidad").ReadOnly = True
            gridEntidades.Columns.Item("tipo").ReadOnly = True
            gridEntidades.Columns.Item("comment").ReadOnly = True
            gridEntidades.Columns.Item("entidad").SortMode = DataGridViewColumnSortMode.NotSortable
            gridEntidades.Columns.Item("tipo").SortMode = DataGridViewColumnSortMode.NotSortable
            gridEntidades.Columns.Item("comment").SortMode = DataGridViewColumnSortMode.NotSortable

            Select Case itipo
                Case 1   'todas
                    centidades = obus.getEntidaDatos(sfuente)
                    For Each oent As EntidaDato In centidades
                        Dim otipo As Tipo = obus.getTpEntidaDato(oent.tpentidadato)
                        Dim bmarcado As Boolean
                        bmarcado = IIf(Me.sentidades.IndexOf(oent.nbentidadato & ",") < 0, False, True)
                        gridEntidades.Rows.Add(bmarcado, oent.nbentidadato, otipo.nombre, oent.txcomment)
                        If bmarcado Then imarcadas = imarcadas + 1
                    Next
                    txttotal.Text = "Total de " & centidades.Count & " Entidades y " & imarcadas & " Marcadas"

                Case 2   'marcadas
                    centidades = obus.getEntidaDatos(sfuente)
                    For Each oent As EntidaDato In centidades
                        Dim otipo As Tipo = obus.getTpEntidaDato(oent.tpentidadato)
                        Dim bmarcado As Boolean
                        bmarcado = IIf(Me.sentidades.IndexOf(oent.nbentidadato & ",") < 0, False, True)
                        If bmarcado Then
                            gridEntidades.Rows.Add(bmarcado, oent.nbentidadato, otipo.nombre, oent.txcomment)
                            imarcadas = imarcadas + 1
                        End If
                    Next
                    txttotal.Text = "Total de " & centidades.Count & " Entidades y " & imarcadas & " Marcadas"

                Case 3   'sin marcar
                    centidades = obus.getEntidaDatos(sfuente)
                    For Each oent As EntidaDato In centidades
                        Dim otipo As Tipo = obus.getTpEntidaDato(oent.tpentidadato)
                        Dim bmarcado As Boolean
                        bmarcado = IIf(Me.sentidades.IndexOf(oent.nbentidadato & ",") < 0, False, True)
                        If Not bmarcado Then
                            gridEntidades.Rows.Add(bmarcado, oent.nbentidadato, otipo.nombre, oent.txcomment)
                            imarcadas = imarcadas + 1
                        End If
                    Next
                    txttotal.Text = "Total de " & centidades.Count & " Entidades y " & imarcadas & " sin Marcar"
            End Select

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmListEntidades.Cargar_Registros()", "Ocurrio un error al cargar los registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyCATALOGOS.frmListEntidades.Cargar_Registros()", "Ocurrio un error al cargar los registros [" & ex1.ToString & "]")
        End Try

    End Sub

    Private Function Leer_Marcadas() As String
        Dim iren As Integer
        Dim smarked As String
        smarked = ""
        For iren = 0 To gridEntidades.Rows.Count - 1
            If gridEntidades.Item("select", iren).Value = True Then
                smarked = outil.Anade_Token(smarked, gridEntidades.Item("entidad", iren).Value, ",")
            End If
        Next iren
        Return smarked
    End Function

    Private Sub radTodas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radTodas.CheckedChanged
        Try
            If radTodas.Checked Then Call Cargar_Registros(1)
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmListEntidades.radTodas_CheckedChanged()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub radMarcadas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMarcadas.CheckedChanged
        Try
            If radMarcadas.Checked Then Call Cargar_Registros(2)
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmListEntidades.radMarcadas_CheckedChanged()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub radSinmarcar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radSinmarcar.CheckedChanged
        Try
            If radSinmarcar.Checked Then Call Cargar_Registros(3)
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmListEntidades.radSinmarcar_CheckedChanged()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub frmListEntidades_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        'Call Cargar_Registros(1)
    End Sub
End Class