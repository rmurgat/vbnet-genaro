Option Explicit On

Imports MyLIB
Imports System.Text.RegularExpressions

Public Class frmgeneramethods
    Inherits System.Windows.Forms.Form
    Private ozip As ZipArchivo = New ZipArchivo
    Private omdipa As MDIGenaro
    Friend WithEvents chkejemplo As System.Windows.Forms.CheckBox
    Private outil As Utilerias


#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents txtDefinicion As System.Windows.Forms.TextBox
    Friend WithEvents btnGenera As System.Windows.Forms.Button
    Friend WithEvents txtresult As System.Windows.Forms.TextBox
    Friend WithEvents cboestilo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtDefinicion = New System.Windows.Forms.TextBox()
        Me.btnGenera = New System.Windows.Forms.Button()
        Me.txtresult = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboestilo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkejemplo = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtDefinicion
        '
        Me.txtDefinicion.Location = New System.Drawing.Point(11, 47)
        Me.txtDefinicion.Multiline = True
        Me.txtDefinicion.Name = "txtDefinicion"
        Me.txtDefinicion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDefinicion.Size = New System.Drawing.Size(528, 131)
        Me.txtDefinicion.TabIndex = 0
        '
        'btnGenera
        '
        Me.btnGenera.Location = New System.Drawing.Point(440, 186)
        Me.btnGenera.Name = "btnGenera"
        Me.btnGenera.Size = New System.Drawing.Size(102, 23)
        Me.btnGenera.TabIndex = 1
        Me.btnGenera.Text = "Genera"
        '
        'txtresult
        '
        Me.txtresult.Location = New System.Drawing.Point(12, 214)
        Me.txtresult.Multiline = True
        Me.txtresult.Name = "txtresult"
        Me.txtresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtresult.Size = New System.Drawing.Size(528, 131)
        Me.txtresult.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CODIGO GENERADO..."
        '
        'cboestilo
        '
        Me.cboestilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboestilo.FormattingEnabled = True
        Me.cboestilo.Location = New System.Drawing.Point(75, 12)
        Me.cboestilo.Name = "cboestilo"
        Me.cboestilo.Size = New System.Drawing.Size(395, 21)
        Me.cboestilo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Estilo :"
        '
        'chkejemplo
        '
        Me.chkejemplo.AutoSize = True
        Me.chkejemplo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.chkejemplo.Location = New System.Drawing.Point(476, 14)
        Me.chkejemplo.Name = "chkejemplo"
        Me.chkejemplo.Size = New System.Drawing.Size(63, 17)
        Me.chkejemplo.TabIndex = 6
        Me.chkejemplo.Text = "Ejemplo"
        Me.chkejemplo.UseVisualStyleBackColor = True
        '
        'frmgeneramethods
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(564, 357)
        Me.Controls.Add(Me.chkejemplo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboestilo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtresult)
        Me.Controls.Add(Me.btnGenera)
        Me.Controls.Add(Me.txtDefinicion)
        Me.Name = "frmgeneramethods"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Generación de get/set/property desde declaración ..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnGenera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenera.Click
        Dim oxmlmain, oxmlestilos, oxmlestilo, oxmllenguaje, oxmlparametros As Nodo
        Dim oxmlcodigos, oxmlcomment, oxmlmeta As Nodo
        Dim ilineas As Integer
        Dim alineas() As String = Nothing
        Dim ipos As Integer
        Dim ometa As MetacodigoReader
        Dim o_Match As Match
        Dim o_Matches As MatchCollection
        Dim o_RegExp As Regex
        Dim ovar As Variable
        Dim sresult As String = ""

        ometa = New MetacodigoReader
        txtresult.Text = ""
        oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
        oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")
        oxmlestilo = oxmlestilos.BuscarPrimero("estilo", "clave", outil.Toma_Token(1, Me.cboestilo.SelectedItem, "-"))
        oxmllenguaje = New Nodo(ozip.getFileInflated(oxmlestilo.getValue("directorio") & oxmlestilo.getValue("configuracion")))
        oxmlparametros = oxmllenguaje.getPrimerNodo("code.parametros")
        oxmlcodigos = oxmllenguaje.getPrimerNodo("code.model")
        oxmlcomment = oxmlparametros.BuscarPrimero("parametro", "nombre", "caracter_comentario_mismalinea")
        oxmlmeta = oxmlcodigos.BuscarPrimero("codigo", "nombre", "property")
        ometa.source = ozip.getFileInflated(oxmlestilo.getValue("directorio") & oxmlmeta.getValue("archivo"))
        o_RegExp = New Regex(oxmlparametros.BuscarPrimero("parametro", "nombre", "apuntador_declaracion_variable").getValue("valor"))
        ilineas = outil.Aparta_Tokens(txtDefinicion.Text, alineas, Chr(13) + Chr(10))
        If ilineas = 0 Then Exit Sub
        For ipos = 1 To ilineas
            o_Matches = o_RegExp.Matches(alineas(ipos))
            If o_Matches.Count > 0 Then
                o_Match = o_Matches.Item(0)
                ovar = New Variable(o_Match.Groups("nombre").Value, o_Match.Groups("tipo").Value, outil.Toma_Token(2, alineas(ipos), oxmlcomment.getValue("valor")))
                ometa.SetXML(ovar.GetXML())
                sresult = sresult & ometa.Interpreta() & vbCrLf
            End If
        Next ipos
        Me.txtresult.Text = sresult
    End Sub

    Private Sub frmgeneramethods_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oxmlmain As Nodo
        Dim oxmlestilos As Nodo
        Dim cestilos As Collection

        outil = New Utilerias
        omdipa = Me.ParentForm
        ozip.Open(omdipa.configuracion)
        oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
        oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")
        cestilos = oxmlestilos.Buscar("estilo", "tipo", "model")
        For Each oestilo As Nodo In cestilos
            Me.cboestilo.Items.Add(oestilo.getValue("estilo.clave") & " - " & oestilo.getValue("estilo.nombre"))
        Next
        Me.cboestilo.SelectedIndex = 0
    End Sub

    Private Sub chkejemplo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkejemplo.CheckedChanged
        If chkejemplo.Checked Then Consulta_Ejemplo()
        txtresult.Text = ""
    End Sub

    Private Sub cboestilo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboestilo.SelectedIndexChanged
        If chkejemplo.Checked Then Consulta_Ejemplo()
        txtresult.Text = ""
    End Sub

    Private Sub Consulta_Ejemplo()
        Dim oxmlmain, oxmlestilos, oxmlestilo, oxmllenguaje, oxmlparametros, oxmlejemplo As Nodo
        Dim sejemplo As String
        Dim alineas() As String = Nothing
        Dim ilineas, ipos As Integer

        Me.txtDefinicion.Text = ""
        oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
        oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")
        oxmlestilo = oxmlestilos.BuscarPrimero("estilo", "clave", outil.Toma_Token(1, Me.cboestilo.SelectedItem, "-"))
        oxmllenguaje = New Nodo(ozip.getFileInflated(oxmlestilo.getValue("directorio") & oxmlestilo.getValue("configuracion")))
        oxmlparametros = oxmllenguaje.getPrimerNodo("code.parametros")
        oxmlejemplo = oxmlparametros.BuscarPrimero("parametro", "nombre", "ejemplo_declaracion")
        If oxmlejemplo Is Nothing Then
            MsgBox("No se tiene un ejemplo de declaraciones para este estilo de programación", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        sejemplo = oxmlejemplo.getValue("valor")
        ilineas = outil.Aparta_Tokens(sejemplo, alineas, Chr(13) + Chr(10))
        If ilineas = 0 Then Exit Sub
        For ipos = 1 To ilineas
            Me.txtDefinicion.Text = Me.txtDefinicion.Text & Trim(alineas(ipos)) & vbCrLf
        Next
    End Sub
End Class
