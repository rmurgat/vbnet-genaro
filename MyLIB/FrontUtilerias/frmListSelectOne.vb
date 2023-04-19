Public Class frmListSelectOne
    Private sresult As String = ""  'resultado de la selección de uno solo
    Private sopciones As String = ""    'conjunto de opciones
    Private copciones As Collection
    Private outil As Utilerias

    ''' <summary>
    ''' PROPIEDAD: conjunto de opciones
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property opciones() As String
        Get
            Return sopciones
        End Get
        Set(ByVal psval As String)
            sopciones = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: resultado de la selección de uno solo
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property result() As String
        Get
            Return sresult
        End Get
        Set(ByVal psval As String)
            sresult = psval.Trim
        End Set
    End Property

    Private Sub frmListSelectOne_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim itokens As Integer

        Try
            outil = New Utilerias
            copciones = outil.CAparta_Tokens(sopciones, "|")
            Me.gridSelectOne.Rows.Clear()
            Me.gridSelectOne.Columns.Clear()
            Me.gridSelectOne.Columns.Add("nombre", "Nombre")
            Me.gridSelectOne.Columns.Add("codigo", "Codigo")
            Me.gridSelectOne.Columns.Add("control", "control")
            Me.gridSelectOne.Columns.Item("nombre").Width = 200
            Me.gridSelectOne.Columns.Item("codigo").Width = 500
            Me.gridSelectOne.Columns.Item("control").Width = 10
            Me.gridSelectOne.Columns.Item("nombre").SortMode = Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.gridSelectOne.Columns.Item("codigo").SortMode = Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.gridSelectOne.Columns.Item("control").SortMode = Windows.Forms.DataGridViewColumnSortMode.NotSortable

            For Each sopc As String In copciones
                itokens = outil.Cuenta_Tokens(sopc, "-")
                If itokens = 1 Then
                    Me.gridSelectOne.Rows.Add(sopc, sopc)
                End If
                If itokens = 2 Then
                    Me.gridSelectOne.Rows.Add(outil.Toma_Token(1, sopc, "-"), outil.Toma_Token(2, sopc, "-"))
                End If
                If itokens = 3 Then
                    Me.gridSelectOne.Rows.Add(outil.Toma_Token(1, sopc, "-"), outil.Toma_Token(2, sopc, "-"), outil.Toma_Token(3, sopc, "-"))
                End If
            Next
            Me.txtopciones.Text = "Un total de " & copciones.Count & " opciones"
        Catch ex As HANYException
            ex.add("MyLIB.frmListSelectOne.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyLIB.frmListSelectOne.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub frmListSelectOne_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.Height < 323 Then Me.Height = 323
        If Me.Width < 515 Then Me.Width = 515
        Me.txtopciones.Top = Me.Height - 60
        Me.btnAceptar.Top = Me.Height - 60
        Me.btnAceptar.Left = Me.Width - Me.btnCancelar.Width - 90
        Me.btnCancelar.Top = Me.Height - 60
        Me.btnCancelar.Left = Me.Width - 80
        Me.gridSelectOne.Height = Me.Height - 75
        Me.gridSelectOne.Width = Me.Width - 30
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.gridSelectOne.SelectedRows.Count > 0 Then
            sresult = Me.gridSelectOne.SelectedRows.Item(0).Cells("nombre").Value & "|" & Me.gridSelectOne.SelectedRows.Item(0).Cells("codigo").Value & "|" & Me.gridSelectOne.SelectedRows.Item(0).Cells("control").Value
            Me.Close()
        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "MyLIB")
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        sresult = "CANCEL"
        Me.Close()
    End Sub
End Class