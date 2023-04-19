Option Explicit On
Imports MyLIB

Public Class frmQAValidaFuente
    Private ipagina As Integer = 1
    Private outil As Utilerias
    Private omdipa As MDIGenaro
    Private obus As Catalogos

    Private Sub btnterminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnterminar.Click
        Me.Close()
    End Sub

    Private Sub btnanterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnanterior.Click
        ipagina = ipagina - 1
        Call Cambia_pagina()
    End Sub

    Private Sub btnsiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsiguiente.Click
        ipagina = ipagina + 1
        Call Cambia_pagina()
    End Sub

    Private Sub frmQAValidaFuente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cfuentes As Collection

        Try
            'PASO 1: Inicializa la carga...
            outil = New Utilerias
            omdipa = Me.ParentForm
            obus = New Catalogos(omdipa.conexion)
            cfuentes = obus.getFuenteDatos(New Criterio())

            'PASO 2: Llena el catálogo de fuentes de datos
            For Each ofte As FuenteDato In cfuentes
                cbofuente.Items.Add(ofte.cdfuentedato & " - " & ofte.nbfuentedato)
            Next


        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmQAValidaFuente.frmQAValidaFuente.Load()", "Ocurrio un error al cargar pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmQAValidaFuente.frmQAValidaFuente.Load()", "Ocurrio un error al cargar pantalla [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub Cambia_pagina()
        If ipagina < 1 Then ipagina = 1
        If ipagina > 3 Then ipagina = 3

        If ipagina = 1 Then
            grbpaso1.Visible = True
            grbpaso2.Visible = False
            grbpaso3.Visible = False
        End If

        If ipagina = 2 Then
            grbpaso1.Visible = False
            grbpaso2.Visible = True
            grbpaso3.Visible = False
        End If

        If ipagina = 3 Then
            grbpaso1.Visible = False
            grbpaso2.Visible = False
            grbpaso3.Visible = True
        End If
    End Sub

    Private Sub btnClipboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClipboard.Click
        Dim sDatos As String = ""
        Dim i As Integer

        For i = 0 To lstdebug.Items.Count - 1
            sDatos = sDatos & vbCr & vbLf & lstdebug.Items.Item(i).ToString
        Next
        Clipboard.Clear()
        Clipboard.SetText(sDatos)
        MsgBox("Se ha copiado el resultado al portapapeles", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
    End Sub

    Private Sub btnleer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnleer.Click
        If cbofuente.SelectedIndex < 0 Then
            MsgBox("No hay ninguna fuente de datos seleccionada", MsgBoxStyle.Exclamation, "ATL Tools Suit")
            Exit Sub
        End If
        Try
            Call Load_Entidades(outil.Toma_Token(1, Me.cbofuente.SelectedItem.ToString, "-"))
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmQAValidaFuente.btnleer_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmQAValidaFuente.btnleer_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub Load_Entidades(ByVal scdfuente As String)
        Dim centidades As Collection
        Try
            'PASO 1: Inicializa
            clbEntidades.Items.Clear()
            centidades = obus.getEntidaDatos(scdfuente)

            'PASO 2: Inserta las entidades
            For Each oent As EntidaDato In centidades
                Me.clbEntidades.Items.Add(oent.nbentidadato)
            Next

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmQAValidaFuente.Load_Entidades()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyCATALOGOS.frmQAValidaFuente.Load_Entidades()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
    End Sub

    Private Sub chkselectall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkselectall.CheckedChanged
        For i As Integer = 0 To clbEntidades.Items.Count - 1
            clbEntidades.SetItemChecked(i, Me.chkselectall.Checked)
        Next
    End Sub

    Private Sub btniniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btniniciar.Click
        Dim centidades As Collection

        Try
            'PASO 1: Inicializa
            lstdebug.Items.Clear()
            centidades = obus.getEntidaDatos(outil.Toma_Token(1, Me.cbofuente.SelectedItem.ToString, "-"))
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "Iniciando Proceso de Validación")
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "PASO 1: Validando las entidades de datos")

            'PASO 2: Valida las entidades
            For Each oent As EntidaDato In centidades
                If oent.txcomment.Trim.Equals("") Then outil.addToListDebug(lstdebug, " La Entidad [" + oent.nbentidadato + "] no tiene comentarios")
            Next

            'PASO 3: Valida los campos
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "PASO 2: Validando los campos")
            For Each oent As EntidaDato In centidades
                outil.addToListDebug(lstdebug, " EN [" + oent.nbentidadato + "]")
                oent.ccampos = obus.getEntidaDatoCampos(outil.Toma_Token(1, Me.cbofuente.SelectedItem.ToString, "-"), oent.nbentidadato)
                For Each ocam As EntidaDatoCampo In oent.ccampos
                    If ocam.txcomment.Trim.Equals("") Then outil.addToListDebug(lstdebug, "    El campo [" + ocam.nbcampo + "] no tiene comentarios")
                Next
            Next

            'PASO 4: Termina
            btnClipboard.Visible = True
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "!PROCESO TERMINADO!")
            MsgBox("!PROCESO TERMINADO!", MsgBoxStyle.Information, "ATL Tools Suit")

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmQAValidaFuente.btniniciar_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmQAValidaFuente.btniniciar_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try
    End Sub
End Class