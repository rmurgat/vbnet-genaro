Option Explicit On

Imports MyLIB

Public Class frmFrontSyncValor
    Private outil As Utilerias
    Private cClases As Collection = New Collection     'Colección de clases
    Private cObjetos As Collection = New Collection    'Colección de objetos
    Private cVariables As Collection = New Collection   'Colección de variables
    Private cHtmlInputs As Collection = New Collection  'Colección de inputs de html
    Private sresult As String = ""  'resultado de la selección de uno solo
    Private stipo As String = ""    'tipo de valor
    Private sclase As String = ""    'Clase del objeto

    ''' <summary>
    ''' PROPIEDAD: Colección de clases
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property Clases() As Collection
        Get
            Return cClases
        End Get
        Set(ByVal pcval As Collection)
            cClases = pcval
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Colección de objetos
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property Objetos() As Collection
        Get
            Return cObjetos
        End Get
        Set(ByVal pcval As Collection)
            cObjetos = pcval
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Colección de variables
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property Variables() As Collection
        Get
            Return cVariables
        End Get
        Set(ByVal pcval As Collection)
            cVariables = pcval
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Colección de inputs de html
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property HtmlInputs() As Collection
        Get
            Return cHtmlInputs
        End Get
        Set(ByVal pcval As Collection)
            cHtmlInputs = pcval
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

    ''' <summary>
    ''' PROPIEDAD: tipo de valor
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property tipo() As String
        Get
            Return stipo
        End Get
        Set(ByVal psval As String)
            stipo = psval.Trim
        End Set
    End Property   'Private sclase As String = ""    'Clase del objeto

    ''' <summary>
    ''' PROPIEDAD: Clase del objeto
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property clase() As String
        Get
            Return sclase
        End Get
        Set(ByVal psval As String)
            sclase = psval.Trim
        End Set
    End Property

    Private Sub radconstante_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radconstante.CheckedChanged
        If radconstante.Checked Then
            txtconstante.Enabled = True
            cbovariable.SelectedIndex = -1
            cbovariable.Enabled = False
            cbohtml.Enabled = False
            cbohtml.SelectedIndex = -1
            lblparobj.Enabled = False
            lblparprop.Enabled = False
            picobjeto.Enabled = False
            picobjetodel.Enabled = False
            picobjetoprop.Enabled = False
            picobjetopropdel.Enabled = False
            txtobjeto.Text = ""
            txtobjetotipo.Text = ""
            txtobjetoprop.Text = ""
        End If

    End Sub

    Private Sub radvariable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radvariable.CheckedChanged
        If radvariable.Checked Then
            cbovariable.Enabled = True
            cbohtml.Enabled = False
            cbohtml.SelectedIndex = -1
            txtconstante.Text = ""
            txtconstante.Enabled = False
            lblparobj.Enabled = False
            lblparprop.Enabled = False
            picobjeto.Enabled = False
            picobjetodel.Enabled = False
            picobjetoprop.Enabled = False
            picobjetopropdel.Enabled = False
            txtobjeto.Text = ""
            txtobjetotipo.Text = ""
            txtobjetoprop.Text = ""
        End If
    End Sub

    Private Sub radobjeto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radobjeto.CheckedChanged
        If radobjeto.Checked Then
            txtconstante.Text = ""
            txtconstante.Enabled = False
            cbovariable.SelectedIndex = -1
            cbovariable.Enabled = False
            cbohtml.Enabled = False
            cbohtml.SelectedIndex = -1
            lblparobj.Enabled = True
            lblparprop.Enabled = True
            picobjeto.Enabled = True
            picobjetodel.Enabled = True
            picobjetoprop.Enabled = True
            picobjetopropdel.Enabled = True
        End If
    End Sub

    Private Sub picobjeto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjeto.Click
        Dim sresult As String
        'PASO 1: Muestra las opciones
        sresult = outil.SelectOne(Selecciona_Objetos())
        If sresult.Equals("CANCEL") Then Exit Sub
        txtobjeto.Text = outil.Toma_Token(1, sresult, "|")
        txtobjetotipo.Text = outil.Toma_Token(2, sresult, "|")
    End Sub

    Private Sub frmFrontSyncValor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            outil = New Utilerias

            For Each ovar As Variable In cVariables
                cbovariable.Items.Add(ovar.nombre & "                       |" & ovar.tipo)
            Next

            For Each otag As HTMLTag In Me.HtmlInputs
                cbohtml.Items.Add(otag.id)
            Next

        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontSyncValor.Load()", "Ocurrio un error al cargar la pantalla")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub picobjetodel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjetodel.Click
        txtobjeto.Text = ""
        txtobjetotipo.Text = ""
        txtobjetoprop.Text = ""
    End Sub

    Private Sub picobjetoprop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjetoprop.Click
        Dim sresult As String

        'PASO 1: inicializa los valores
        If Me.txtobjetotipo.Text.Equals("") Then
            MsgBox("Es necesario que primero seleccione el objeto que participa", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        'PASO 2: Muestra las opciones
        sresult = outil.SelectOne(Selecciona_Methods(Me.txtobjetotipo.Text))
        If sresult.Equals("CANCEL") Then Exit Sub
        txtobjetoprop.Text = outil.Toma_Token(1, sresult, "|")

    End Sub

    Private Sub picobjetopropdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picobjetopropdel.Click
        txtobjetoprop.Text = ""
    End Sub

    ''' <summary>
    ''' Función para seleccionar los metodos que participan en un objeto
    ''' </summary>
    ''' <param name="sclase"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Selecciona_Methods(ByVal sclase As String) As String
        Dim smethods As String = ""

        For Each oc As Clase In cClases
            If oc.name.Equals(sclase) Then
                For Each om As Metodo In oc.methods
                    If om.ispublico() Then smethods = outil.Anade_Token(smethods, om.nombre & " - " & om.declaracion, "|")
                Next
            End If
        Next
        Return smethods
    End Function

    ''' <summary>
    ''' Función para seleccionar entre los nombres de objetos
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Selecciona_Objetos() As String
        Dim sobjetos As String = ""
        For Each obj As Variable In cObjetos
            sobjetos = outil.Anade_Token(sobjetos, obj.nombre & "-" & obj.tipo, "|")
        Next
        Return sobjetos
    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        sresult = "CANCEL"
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If radconstante.Checked Then
            If txtconstante.Text.Trim.Equals("") Then
                MsgBox("Es necesario ingresar el valor de la constante", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                Exit Sub
            End If
            sresult = txtconstante.Text.Trim
            stipo = "CONSTANTE"
        End If
        If radvariable.Checked Then
            If cbovariable.SelectedIndex < 0 Then
                MsgBox("Es necesario ingresar la variable para asignar", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                Exit Sub
            End If
            sresult = outil.Toma_Token(1, cbovariable.SelectedItem, "|")
            stipo = "VARIABLE"
            sclase = outil.Toma_Token(2, cbovariable.SelectedItem, "|")
        End If
        If radhtml.Checked Then
            If cbohtml.SelectedIndex < 0 Then
                MsgBox("Es necesario ingresar el control html para asignar", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                Exit Sub
            End If
            sresult = cbohtml.SelectedItem
            stipo = "HTML"
        End If
        If radobjeto.Checked Then
            If txtobjeto.Text.Trim.Equals("") Then
                MsgBox("Es necesario ingresar el objeto para asignar", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                Exit Sub
            End If
            sresult = txtobjeto.Text.Trim & IIf(txtobjetoprop.Text.Trim.Equals(""), "", "." & txtobjetoprop.Text & "()")
            stipo = "OBJETO"
            sclase = txtobjetotipo.Text.Trim
        End If
        Me.Close()
    End Sub

    Private Sub radhtml_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radhtml.CheckedChanged
        If radhtml.Checked Then
            cbohtml.Enabled = True
            cbovariable.Enabled = False
            cbovariable.SelectedIndex = -1
            txtconstante.Text = ""
            txtconstante.Enabled = False
            lblparobj.Enabled = False
            lblparprop.Enabled = False
            picobjeto.Enabled = False
            picobjetodel.Enabled = False
            picobjetoprop.Enabled = False
            picobjetopropdel.Enabled = False
            txtobjeto.Text = ""
            txtobjetotipo.Text = ""
            txtobjetoprop.Text = ""
        End If
    End Sub

End Class