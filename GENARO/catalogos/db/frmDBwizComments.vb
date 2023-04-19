Option Explicit On
Imports MyLIB
Imports System.Text.RegularExpressions
Imports System.IO

Public Class frmDBwizComments
    Private ipagina As Integer = 1
    Private outil As Utilerias = New MyLIB.Utilerias
    Private omdipa As MDIGenaro
    Private obus As Catalogos

    Private Sub btnanterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnanterior.Click
        ipagina = ipagina - 1
        Call Cambia_pagina()
    End Sub

    Private Sub btnsiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsiguiente.Click
        ipagina = ipagina + 1
        Call Cambia_pagina()
    End Sub

    Private Sub Cambia_pagina()
        If ipagina < 1 Then ipagina = 1
        If ipagina > 4 Then ipagina = 4

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

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub frmDBwizloadcomments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cftes As Collection

        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            omdipa = Me.ParentForm
            obus = New Catalogos(omdipa.conexion)
            outil = New Utilerias

            'PASO 2: LLena el catálogo de fuentes de datos
            cftes = obus.getFuenteDatos(New Criterio)
            For Each ofte As FuenteDato In cftes
                cboftedatos.Items.Add(ofte.cdfuentedato & " - " & ofte.nbfuentedato)
            Next
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmDBwizloadcomments.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmDBwizloadcomments.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btncommentfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncommentfile.Click
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Me.txtfile.Text = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub btnfuente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfuente.Click
        If Me.cboftedatos.SelectedIndex > -1 Then
            Dim ofrm As frmFuenteDatos
            ofrm = New frmFuenteDatos
            ofrm.MdiParent = Me.ParentForm
            ofrm.cdftedatos = outil.Toma_Token(1, Me.cboftedatos.SelectedItem.ToString, "-")
            ofrm.Show()
        Else
            MsgBox("No hay ninguna fuente de datos seleccionada", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btnimportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimportar.Click
        Dim oread As System.IO.StreamReader
        Dim sline As String
        Dim icounter As Integer = 1

        oread = Nothing
        Try
            'PASO 1: Inicializa los valores
            Me.Cursor = Cursors.WaitCursor
            lstdebug.Items.Clear()
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "Actualizando los comentarios")
            oread = New StreamReader(Me.txtfile.Text, System.Text.Encoding.GetEncoding(28593))      'Abre el archivo   

            'PASO 2: Actualiza los comentarios
            Do
                sline = oread.ReadLine()
                If sline Is Nothing Then Exit Do
                If Not sline.Trim.Equals("") Then

                    'PASO 2.1: Si se trata de comentarios para campos
                    If radcampo.Checked Then
                        If outil.Cuenta_Tokens(sline, Me.txtcarseparador.Text) = 3 Then
                            Dim obj As EntidaDatoCampo = New EntidaDatoCampo()
                            obj.cdfuentedato = outil.Toma_Token(1, Me.cboftedatos.SelectedItem, "-")
                            obj.nbentidadato = outil.Toma_Token(1, sline, Me.txtcarseparador.Text)
                            obj.nbcampo = outil.Toma_Token(2, sline, Me.txtcarseparador.Text)
                            obj.txcomment = outil.Toma_Token(3, sline, Me.txtcarseparador.Text)
                            obus.updEntidadDatoCampoComment(obj)
                            outil.addToListDebug(lstdebug, "Se actualizo el comentario en entidad [" & obj.nbentidadato & "], campo [" & obj.nbcampo & "]")
                            icounter = icounter + 1
                        Else
                            outil.addToListDebug(lstdebug, "La linea de entrada no corresponde al formato esperado")
                        End If
                    End If

                    'PASO 2.2: Si se trata de comentarios para entidades
                    If radentidad.Checked Then
                        If outil.Cuenta_Tokens(sline, Me.txtcarseparador.Text) = 2 Then
                            Dim obj As EntidaDato = New EntidaDato()
                            obj.cdfuentedato = outil.Toma_Token(1, Me.cboftedatos.SelectedItem, "-")
                            obj.nbentidadato = outil.Toma_Token(1, sline, Me.txtcarseparador.Text)
                            obj.txcomment = outil.Toma_Token(2, sline, Me.txtcarseparador.Text)
                            obus.updEntidadDatoComment(obj)
                            outil.addToListDebug(lstdebug, "Se actualizo el comentario en entidad [" & obj.nbentidadato & "]")
                            icounter = icounter + 1
                        Else
                            outil.addToListDebug(lstdebug, "La linea de entrada no corresponde al formato esperado")
                        End If
                    End If
                End If
            Loop Until sline Is Nothing

            'PASO 3: Termina
            Me.Cursor = Cursors.Default
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "!PROCESO TERMINADO!")
            oread.Close()
            MsgBox("!PROCESO TERMINADO!", MsgBoxStyle.Information, "ATL Tools Suit")

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmDBwizloadcomments.btnimportar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmDBwizloadcomments.btnimportar_Click()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexportar.Click
        Dim centidades As Collection
        Dim ofile As System.IO.StreamWriter
        Dim sline As String
        Dim icounter As Integer = 1
        Dim sfuente As String

        ofile = Nothing
        Try
            'PASO 1: Inicializa los valores
            Me.Cursor = Cursors.WaitCursor
            lstdebug.Items.Clear()
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "Exportación de los comentarios")
            ofile = New StreamWriter(Me.txtfile.Text)      'Abre el archivo
            sfuente = outil.Toma_Token(1, Me.cboftedatos.SelectedItem, "-")

            'PASO 2.1: Si se trata de comentarios para campos
            If radcampo.Checked Then
                centidades = obus.getEntidaDatos(sfuente)
                For Each oent As EntidaDato In centidades
                    oent.ccampos = obus.getEntidaDatoCampos(sfuente, oent.nbentidadato)
                    For Each ocam As EntidaDatoCampo In oent.ccampos
                        ofile.WriteLine(oent.nbentidadato & Me.txtcarseparador.Text & ocam.nbcampo & Me.txtcarseparador.Text & ocam.txcomment)
                        outil.addToListDebug(lstdebug, "   EXPORTANDO campo [" & oent.nbentidadato & "." & ocam.nbcampo & "]")
                    Next
                Next
            End If

            'PASO 2.2: Si se trata de comentarios para entidades
            If radentidad.Checked Then
                centidades = obus.getEntidaDatos(sfuente)
                For Each oent As EntidaDato In centidades
                    ofile.WriteLine(oent.nbentidadato & Me.txtcarseparador.Text & oent.txcomment)
                    outil.addToListDebug(lstdebug, "   EXPORTANDO entidad [" & oent.nbentidadato & "]")
                Next
            End If

            'PASO 3: Termina
            Me.Cursor = Cursors.Default
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "!PROCESO TERMINADO!")
            ofile.Close()
            MsgBox("!PROCESO TERMINADO!", MsgBoxStyle.Information, "ATL Tools Suit")

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmDBwizloadcomments.btnexportar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmDBwizloadcomments.btnexportar_Click()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub
End Class