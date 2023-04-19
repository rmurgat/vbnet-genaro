Option Explicit On

Imports MyLIB

Public Class frmNavegacion1
    Private obus As Catalogos
    Private scdproject As String        'Clave del proyecto
    Private scdesde As String           'Clave de la pantalla desde
    Private scdhasta As String          'Clave de la pantalla hasta
    Private oproyecto As Proyecto
    Private odesde As Pantalla
    Private ohasta As Pantalla
    Private onavegacion As Navegacion
    Private oproject As Proyecto        'Objeto que tiene las propiedades del proyecto
    Private outil As Utilerias          'Utilerias del sistema
    Private omdipa As MDIGenaro
    Private cInputTags As Collection = New Collection   'Tag de inputs

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
    ''' PROPIEDAD: Clave de la pantalla desde
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdesde() As String
        Get
            Return scdesde
        End Get
        Set(ByVal pscd As String)
            scdesde = pscd.Trim
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Clave de la pantalla hasta
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdhasta() As String
        Get
            Return scdhasta
        End Get
        Set(ByVal pscd As String)
            scdhasta = pscd.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Tag de inputs
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property InputTags() As Collection
        Get
            Return cInputTags
        End Get
        Set(ByVal pcval As Collection)
            If pcval Is Nothing Then Exit Property
            cInputTags = pcval
        End Set
    End Property

    Private Sub frmNavegacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            omdipa = Me.ParentForm
            obus = New Catalogos(omdipa.conexion)
            outil = New Utilerias
            oproyecto = obus.getProyecto(Me.cdproject)
            odesde = obus.getPantalla(Me.cdproject, Me.cdesde)
            ohasta = obus.getPantalla(Me.cdproject, Me.cdhasta)
            onavegacion = obus.getNavegacion(Me.cdproject, Me.cdesde, Me.cdhasta)
            txtcdproyecto.Text = oproyecto.cdproyecto
            txtnbproyecto.Text = oproyecto.nbproyecto
            txtcdesde.Text = odesde.cdpantalla
            txtnbdesde.Text = odesde.nbpantalla
            txtcdhasta.Text = ohasta.cdpantalla
            txtnbhasta.Text = ohasta.nbpantalla
            radget.Checked = IIf(onavegacion.tpnavegacion.Equals("GET"), True, False)
            radpost.Checked = IIf(onavegacion.tpnavegacion.Equals("POST"), True, False)
            chknewindow.Checked = IIf(onavegacion.stopenwindow.Equals("AC"), True, False)

            'PASO 2: Inicializa el grid
            Dim oconst As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn(False)
            oconst.Name = "constante"
            oconst.HeaderText = "Constante ?"
            oconst.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            gridparametros.Rows.Clear()
            gridparametros.Columns.Clear()
            gridparametros.Columns.Add("nombre", "Nombre")
            gridparametros.Columns.Add(oconst)
            gridparametros.Columns.Add("valor", "Valor")
            gridparametros.Columns.Item("valor").Width = 250
            gridparametros.Columns.Item("nombre").SortMode = DataGridViewColumnSortMode.NotSortable
            gridparametros.Columns.Item("constante").SortMode = DataGridViewColumnSortMode.NotSortable
            gridparametros.Columns.Item("valor").SortMode = DataGridViewColumnSortMode.NotSortable

            'PASO 2: Lee los parámetros existentes hasta ahora
            Dim cpars As Collection = obus.getNavegacionParams(Me.cdproject, Me.cdesde, Me.cdhasta)
            For Each opar As NavegacionParam In cpars
                Me.gridparametros.Rows.Add(opar.nbparam, IIf(opar.stconstante.Equals("AC"), True, False), opar.txconstante)
            Next
        Catch ex As HANYException
            ex.add("MyGENARO.frmNavegacion.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmNavegacion.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Dim cparams As Collection
        Dim iren As Integer

        Try
            'PASO 1: Inicializa
            cparams = New Collection
            onavegacion.tpnavegacion = IIf(Me.radget.Checked, "GET", "POST")
            onavegacion.stopenwindow = Me.chknewindow.Checked

            'PASO 2: Lee los parámetros
            For iren = 0 To gridparametros.Rows.Count - 1
                Dim obj As NavegacionParam
                obj = New NavegacionParam()
                obj.cdproyecto = Me.cdproject
                obj.cdesde = Me.cdesde
                obj.cdhasta = Me.cdhasta
                obj.nbparam = gridparametros.Item("nombre", iren).Value
                obj.stconstante = gridparametros.Item("constante", iren).Value
                obj.txconstante = gridparametros.Item("valor", iren).Value
                If Not obj.nbparam.Equals("") Then cparams.Add(obj)
            Next iren
            onavegacion.parametros = cparams

            'PASO 3: Graba la información
            obus.saveNavegacion(onavegacion)

            'PASO 4: Elimina los parámetros actuales
            obus.delNavegacionParams(Me.cdproject, Me.cdesde, Me.cdhasta)

            'PASO 5: Agrega otra vez los parámetros
            obus.addNavegacionParams(cparams)

            MsgBox("Se grabo la información de navegación exitosamente", MsgBoxStyle.Information, "HANYGEN SOFTWARE")

        Catch ex As HANYException
            ex.add("MyGENARO.frmNavegacion.btnGrabar_Click()", "Ocurrio un error al grabar los datos de la navegación")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmNavegacion.btnGrabar_Click()", "Ocurrio un error al grabar los datos de la navegación [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnaddall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddall.Click
        For Each otag As HTMLTag In Me.cInputTags
            gridparametros.Rows.Add(otag.id, False, "")
        Next
    End Sub
End Class