Option Explicit On

Imports MyLIB

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class frmgenerahibernate
    Inherits System.Windows.Forms.Form
    Private omdipa As MDIGenaro
    Private ozip As ZipArchivo
    Private outil As Utilerias
    Private ipagina As Integer = 1
    Private obus As Catalogos
    Private oxmlconfig As Nodo = Nothing

    Const COL_BUSCLASE_TABLA As Integer = 0
    Const COL_BUSCLASE_SELECTONE As Integer = 1
    Const COL_BUSCLASE_SELECTSOME As Integer = 2
    Const COL_BUSCLASE_SELECTALL As Integer = 3
    Const COL_BUSCLASE_DELETE As Integer = 4
    Const COL_BUSCLASE_UPDATE As Integer = 5
    Const COL_BUSCLASE_INSERT As Integer = 6
    Const COL_BUSCLASE_CLASE As Integer = 7
    Const COL_BUSCLASE_CAMPOS As Integer = 8

    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents btnsiguiente As System.Windows.Forms.Button
    Friend WithEvents btnanterior As System.Windows.Forms.Button
    Friend WithEvents btnterminar As System.Windows.Forms.Button
    'objeto que tiene los encabezados para las clases

    Friend WithEvents grbpaso3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbofuentedatos As System.Windows.Forms.ComboBox
    Friend WithEvents grbpaso2 As System.Windows.Forms.GroupBox
    Friend WithEvents btncargarestilo As System.Windows.Forms.Button
    Friend WithEvents txtfhcreacion As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtnbautor As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtnbide As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtnblenguaje As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtnbestilo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents grbpaso4 As System.Windows.Forms.GroupBox
    Friend WithEvents griddbentidades As System.Windows.Forms.DataGridView
    Friend WithEvents btnExtraer As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents grbpaso1 As System.Windows.Forms.GroupBox
    Friend WithEvents grbpaso5 As System.Windows.Forms.GroupBox
    Friend WithEvents lstestilo As System.Windows.Forms.ListBox
    Friend WithEvents grbpaso7 As System.Windows.Forms.GroupBox
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents lstdebug As System.Windows.Forms.ListBox
    Friend WithEvents prbgenaro As System.Windows.Forms.ProgressBar
    Friend WithEvents radunoauno As System.Windows.Forms.RadioButton
    Friend WithEvents radtodoenuno As System.Windows.Forms.RadioButton
    Friend WithEvents grbpaso6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnexaminar As System.Windows.Forms.Button
    Friend WithEvents txtdirectory As System.Windows.Forms.TextBox
    Friend WithEvents chkconfig As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtmasknegocio As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdirnegocio As System.Windows.Forms.TextBox
    Friend WithEvents txtdirdao As System.Windows.Forms.TextBox
    Friend WithEvents txtdirbeans As System.Windows.Forms.TextBox
    Friend WithEvents picdirnegocio As System.Windows.Forms.PictureBox
    Friend WithEvents picdirdao As System.Windows.Forms.PictureBox
    Friend WithEvents picdirbeans As System.Windows.Forms.PictureBox
    Friend WithEvents cboregla As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcomment As System.Windows.Forms.TextBox
    Friend WithEvents chkdebug As System.Windows.Forms.CheckBox
    Friend WithEvents chkcontexto As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents picdirmap As System.Windows.Forms.PictureBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtdirmap As System.Windows.Forms.TextBox
    Friend WithEvents chknombre As System.Windows.Forms.CheckBox
    Friend WithEvents btnconfig As System.Windows.Forms.Button


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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmgenerahibernate))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.btnsiguiente = New System.Windows.Forms.Button()
        Me.btnanterior = New System.Windows.Forms.Button()
        Me.btnterminar = New System.Windows.Forms.Button()
        Me.grbpaso3 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbofuentedatos = New System.Windows.Forms.ComboBox()
        Me.grbpaso2 = New System.Windows.Forms.GroupBox()
        Me.txtcomment = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btncargarestilo = New System.Windows.Forms.Button()
        Me.txtfhcreacion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtnbautor = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtnbide = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtnblenguaje = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtnbestilo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.grbpaso4 = New System.Windows.Forms.GroupBox()
        Me.chknombre = New System.Windows.Forms.CheckBox()
        Me.cboregla = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.griddbentidades = New System.Windows.Forms.DataGridView()
        Me.btnExtraer = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grbpaso1 = New System.Windows.Forms.GroupBox()
        Me.lstestilo = New System.Windows.Forms.ListBox()
        Me.grbpaso5 = New System.Windows.Forms.GroupBox()
        Me.chkconfig = New System.Windows.Forms.CheckBox()
        Me.btnconfig = New System.Windows.Forms.Button()
        Me.radunoauno = New System.Windows.Forms.RadioButton()
        Me.radtodoenuno = New System.Windows.Forms.RadioButton()
        Me.grbpaso7 = New System.Windows.Forms.GroupBox()
        Me.chkdebug = New System.Windows.Forms.CheckBox()
        Me.chkcontexto = New System.Windows.Forms.CheckBox()
        Me.lstdebug = New System.Windows.Forms.ListBox()
        Me.prbgenaro = New System.Windows.Forms.ProgressBar()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.grbpaso6 = New System.Windows.Forms.GroupBox()
        Me.picdirmap = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtdirmap = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.picdirnegocio = New System.Windows.Forms.PictureBox()
        Me.picdirdao = New System.Windows.Forms.PictureBox()
        Me.picdirbeans = New System.Windows.Forms.PictureBox()
        Me.txtdirnegocio = New System.Windows.Forms.TextBox()
        Me.txtdirdao = New System.Windows.Forms.TextBox()
        Me.txtdirbeans = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmasknegocio = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnexaminar = New System.Windows.Forms.Button()
        Me.txtdirectory = New System.Windows.Forms.TextBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbpaso3.SuspendLayout()
        Me.grbpaso2.SuspendLayout()
        Me.grbpaso4.SuspendLayout()
        CType(Me.griddbentidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbpaso1.SuspendLayout()
        Me.grbpaso5.SuspendLayout()
        Me.grbpaso7.SuspendLayout()
        Me.grbpaso6.SuspendLayout()
        CType(Me.picdirmap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picdirnegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picdirdao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picdirbeans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(5, 12)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(164, 105)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 7
        Me.LogoPictureBox.TabStop = False
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsiguiente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnsiguiente.Location = New System.Drawing.Point(365, 318)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(81, 23)
        Me.btnsiguiente.TabIndex = 15
        Me.btnsiguiente.Text = "Siguiente >"
        '
        'btnanterior
        '
        Me.btnanterior.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnanterior.Location = New System.Drawing.Point(232, 318)
        Me.btnanterior.Name = "btnanterior"
        Me.btnanterior.Size = New System.Drawing.Size(67, 23)
        Me.btnanterior.TabIndex = 13
        Me.btnanterior.Text = "< Regresar"
        '
        'btnterminar
        '
        Me.btnterminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnterminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnterminar.Location = New System.Drawing.Point(544, 318)
        Me.btnterminar.Name = "btnterminar"
        Me.btnterminar.Size = New System.Drawing.Size(81, 23)
        Me.btnterminar.TabIndex = 14
        Me.btnterminar.Text = "Terminar"
        '
        'grbpaso3
        '
        Me.grbpaso3.Controls.Add(Me.Label15)
        Me.grbpaso3.Controls.Add(Me.cbofuentedatos)
        Me.grbpaso3.Location = New System.Drawing.Point(175, 12)
        Me.grbpaso3.Name = "grbpaso3"
        Me.grbpaso3.Size = New System.Drawing.Size(485, 293)
        Me.grbpaso3.TabIndex = 18
        Me.grbpaso3.TabStop = False
        Me.grbpaso3.Text = " PASO 3:  Origen de definición de entidades ..."
        Me.grbpaso3.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Fuente de datos:"
        '
        'cbofuentedatos
        '
        Me.cbofuentedatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofuentedatos.FormattingEnabled = True
        Me.cbofuentedatos.Location = New System.Drawing.Point(23, 66)
        Me.cbofuentedatos.Name = "cbofuentedatos"
        Me.cbofuentedatos.Size = New System.Drawing.Size(445, 21)
        Me.cbofuentedatos.TabIndex = 5
        '
        'grbpaso2
        '
        Me.grbpaso2.Controls.Add(Me.txtcomment)
        Me.grbpaso2.Controls.Add(Me.Label8)
        Me.grbpaso2.Controls.Add(Me.btncargarestilo)
        Me.grbpaso2.Controls.Add(Me.txtfhcreacion)
        Me.grbpaso2.Controls.Add(Me.Label13)
        Me.grbpaso2.Controls.Add(Me.txtnbautor)
        Me.grbpaso2.Controls.Add(Me.Label12)
        Me.grbpaso2.Controls.Add(Me.txtnbide)
        Me.grbpaso2.Controls.Add(Me.Label11)
        Me.grbpaso2.Controls.Add(Me.txtnblenguaje)
        Me.grbpaso2.Controls.Add(Me.Label10)
        Me.grbpaso2.Controls.Add(Me.txtnbestilo)
        Me.grbpaso2.Controls.Add(Me.Label14)
        Me.grbpaso2.Location = New System.Drawing.Point(175, 12)
        Me.grbpaso2.Name = "grbpaso2"
        Me.grbpaso2.Size = New System.Drawing.Size(485, 293)
        Me.grbpaso2.TabIndex = 21
        Me.grbpaso2.TabStop = False
        Me.grbpaso2.Text = " PASO 2:  Información General del estilo seleccionado..."
        Me.grbpaso2.Visible = False
        '
        'txtcomment
        '
        Me.txtcomment.Location = New System.Drawing.Point(10, 164)
        Me.txtcomment.Multiline = True
        Me.txtcomment.Name = "txtcomment"
        Me.txtcomment.ReadOnly = True
        Me.txtcomment.Size = New System.Drawing.Size(466, 115)
        Me.txtcomment.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label8.Location = New System.Drawing.Point(6, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 17)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Comentarios  : "
        '
        'btncargarestilo
        '
        Me.btncargarestilo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncargarestilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncargarestilo.Location = New System.Drawing.Point(333, 35)
        Me.btncargarestilo.Name = "btncargarestilo"
        Me.btncargarestilo.Size = New System.Drawing.Size(146, 22)
        Me.btncargarestilo.TabIndex = 29
        Me.btncargarestilo.Text = "Cargar Configuración de Estilo..."
        Me.btncargarestilo.UseVisualStyleBackColor = True
        '
        'txtfhcreacion
        '
        Me.txtfhcreacion.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtfhcreacion.Location = New System.Drawing.Point(333, 70)
        Me.txtfhcreacion.Name = "txtfhcreacion"
        Me.txtfhcreacion.ReadOnly = True
        Me.txtfhcreacion.Size = New System.Drawing.Size(146, 20)
        Me.txtfhcreacion.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label13.Location = New System.Drawing.Point(235, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 17)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Fecha Creación  : "
        '
        'txtnbautor
        '
        Me.txtnbautor.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtnbautor.Location = New System.Drawing.Point(333, 101)
        Me.txtnbautor.Name = "txtnbautor"
        Me.txtnbautor.ReadOnly = True
        Me.txtnbautor.Size = New System.Drawing.Size(146, 20)
        Me.txtnbautor.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label12.Location = New System.Drawing.Point(235, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 17)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Autor  : "
        '
        'txtnbide
        '
        Me.txtnbide.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtnbide.Location = New System.Drawing.Point(66, 101)
        Me.txtnbide.Name = "txtnbide"
        Me.txtnbide.ReadOnly = True
        Me.txtnbide.Size = New System.Drawing.Size(163, 20)
        Me.txtnbide.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label11.Location = New System.Drawing.Point(6, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "IDE  : "
        '
        'txtnblenguaje
        '
        Me.txtnblenguaje.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtnblenguaje.Location = New System.Drawing.Point(66, 70)
        Me.txtnblenguaje.Name = "txtnblenguaje"
        Me.txtnblenguaje.ReadOnly = True
        Me.txtnblenguaje.Size = New System.Drawing.Size(163, 20)
        Me.txtnblenguaje.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label10.Location = New System.Drawing.Point(6, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 17)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Lenguaje  : "
        '
        'txtnbestilo
        '
        Me.txtnbestilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnbestilo.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtnbestilo.Location = New System.Drawing.Point(66, 38)
        Me.txtnbestilo.Name = "txtnbestilo"
        Me.txtnbestilo.ReadOnly = True
        Me.txtnbestilo.Size = New System.Drawing.Size(163, 20)
        Me.txtnbestilo.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label14.Location = New System.Drawing.Point(6, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 14)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Estilo  : "
        '
        'grbpaso4
        '
        Me.grbpaso4.Controls.Add(Me.chknombre)
        Me.grbpaso4.Controls.Add(Me.cboregla)
        Me.grbpaso4.Controls.Add(Me.Label7)
        Me.grbpaso4.Controls.Add(Me.griddbentidades)
        Me.grbpaso4.Controls.Add(Me.btnExtraer)
        Me.grbpaso4.Location = New System.Drawing.Point(174, 13)
        Me.grbpaso4.Name = "grbpaso4"
        Me.grbpaso4.Size = New System.Drawing.Size(486, 299)
        Me.grbpaso4.TabIndex = 23
        Me.grbpaso4.TabStop = False
        Me.grbpaso4.Text = "PASO 4: Extracción de Entidades"
        Me.grbpaso4.Visible = False
        '
        'chknombre
        '
        Me.chknombre.AutoSize = True
        Me.chknombre.Checked = True
        Me.chknombre.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chknombre.Location = New System.Drawing.Point(317, 44)
        Me.chknombre.Name = "chknombre"
        Me.chknombre.Size = New System.Drawing.Size(163, 17)
        Me.chknombre.TabIndex = 34
        Me.chknombre.Text = "Considerar nombre anteriores"
        Me.chknombre.UseVisualStyleBackColor = True
        '
        'cboregla
        '
        Me.cboregla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboregla.FormattingEnabled = True
        Me.cboregla.Location = New System.Drawing.Point(125, 18)
        Me.cboregla.Name = "cboregla"
        Me.cboregla.Size = New System.Drawing.Size(352, 21)
        Me.cboregla.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Regla de Conversión : "
        '
        'griddbentidades
        '
        Me.griddbentidades.AllowUserToAddRows = False
        Me.griddbentidades.AllowUserToDeleteRows = False
        Me.griddbentidades.AllowUserToResizeRows = False
        Me.griddbentidades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.griddbentidades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.griddbentidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.griddbentidades.DefaultCellStyle = DataGridViewCellStyle2
        Me.griddbentidades.Location = New System.Drawing.Point(11, 65)
        Me.griddbentidades.MultiSelect = False
        Me.griddbentidades.Name = "griddbentidades"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.griddbentidades.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.griddbentidades.RowHeadersVisible = False
        Me.griddbentidades.Size = New System.Drawing.Size(466, 218)
        Me.griddbentidades.TabIndex = 1
        '
        'btnExtraer
        '
        Me.btnExtraer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExtraer.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtraer.Location = New System.Drawing.Point(11, 41)
        Me.btnExtraer.Name = "btnExtraer"
        Me.btnExtraer.Size = New System.Drawing.Size(85, 22)
        Me.btnExtraer.TabIndex = 0
        Me.btnExtraer.Text = "Extraer..."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Estilo :"
        '
        'grbpaso1
        '
        Me.grbpaso1.Controls.Add(Me.lstestilo)
        Me.grbpaso1.Controls.Add(Me.Label9)
        Me.grbpaso1.Location = New System.Drawing.Point(175, 12)
        Me.grbpaso1.Name = "grbpaso1"
        Me.grbpaso1.Size = New System.Drawing.Size(485, 293)
        Me.grbpaso1.TabIndex = 12
        Me.grbpaso1.TabStop = False
        Me.grbpaso1.Text = " PASO 1:  Selección del estilo de programación"
        '
        'lstestilo
        '
        Me.lstestilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstestilo.FormattingEnabled = True
        Me.lstestilo.ItemHeight = 16
        Me.lstestilo.Location = New System.Drawing.Point(60, 24)
        Me.lstestilo.Name = "lstestilo"
        Me.lstestilo.Size = New System.Drawing.Size(406, 164)
        Me.lstestilo.TabIndex = 20
        '
        'grbpaso5
        '
        Me.grbpaso5.Controls.Add(Me.chkconfig)
        Me.grbpaso5.Controls.Add(Me.btnconfig)
        Me.grbpaso5.Controls.Add(Me.radunoauno)
        Me.grbpaso5.Controls.Add(Me.radtodoenuno)
        Me.grbpaso5.Location = New System.Drawing.Point(174, 12)
        Me.grbpaso5.Name = "grbpaso5"
        Me.grbpaso5.Size = New System.Drawing.Size(492, 298)
        Me.grbpaso5.TabIndex = 27
        Me.grbpaso5.TabStop = False
        Me.grbpaso5.Text = "PASO 5 : Configuración de la organización de los métodos de negocio "
        Me.grbpaso5.Visible = False
        '
        'chkconfig
        '
        Me.chkconfig.AutoSize = True
        Me.chkconfig.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.chkconfig.Location = New System.Drawing.Point(15, 237)
        Me.chkconfig.Name = "chkconfig"
        Me.chkconfig.Size = New System.Drawing.Size(197, 17)
        Me.chkconfig.TabIndex = 22
        Me.chkconfig.Text = "Configuración particular del lenguaje"
        Me.chkconfig.UseVisualStyleBackColor = True
        '
        'btnconfig
        '
        Me.btnconfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnconfig.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnconfig.Location = New System.Drawing.Point(286, 233)
        Me.btnconfig.Name = "btnconfig"
        Me.btnconfig.Size = New System.Drawing.Size(160, 23)
        Me.btnconfig.TabIndex = 20
        Me.btnconfig.Text = "Configuración del Lenguaje ..."
        Me.btnconfig.UseVisualStyleBackColor = True
        '
        'radunoauno
        '
        Me.radunoauno.AutoSize = True
        Me.radunoauno.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radunoauno.Location = New System.Drawing.Point(21, 44)
        Me.radunoauno.Name = "radunoauno"
        Me.radunoauno.Size = New System.Drawing.Size(284, 17)
        Me.radunoauno.TabIndex = 19
        Me.radunoauno.Text = "Capa de negocio y datos separados para cada entidad"
        Me.radunoauno.UseVisualStyleBackColor = True
        '
        'radtodoenuno
        '
        Me.radtodoenuno.AutoSize = True
        Me.radtodoenuno.Checked = True
        Me.radtodoenuno.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radtodoenuno.Location = New System.Drawing.Point(21, 24)
        Me.radtodoenuno.Name = "radtodoenuno"
        Me.radtodoenuno.Size = New System.Drawing.Size(257, 17)
        Me.radtodoenuno.TabIndex = 18
        Me.radtodoenuno.TabStop = True
        Me.radtodoenuno.Text = "Capa de negocio y datos en un solo componente"
        Me.radtodoenuno.UseVisualStyleBackColor = True
        '
        'grbpaso7
        '
        Me.grbpaso7.Controls.Add(Me.chkdebug)
        Me.grbpaso7.Controls.Add(Me.chkcontexto)
        Me.grbpaso7.Controls.Add(Me.lstdebug)
        Me.grbpaso7.Controls.Add(Me.prbgenaro)
        Me.grbpaso7.Controls.Add(Me.btnGenerar)
        Me.grbpaso7.Location = New System.Drawing.Point(175, 9)
        Me.grbpaso7.Name = "grbpaso7"
        Me.grbpaso7.Size = New System.Drawing.Size(491, 297)
        Me.grbpaso7.TabIndex = 30
        Me.grbpaso7.TabStop = False
        Me.grbpaso7.Text = "PASO 7 :  Generación de capa de persistencia "
        Me.grbpaso7.Visible = False
        '
        'chkdebug
        '
        Me.chkdebug.AutoSize = True
        Me.chkdebug.Location = New System.Drawing.Point(333, 46)
        Me.chkdebug.Name = "chkdebug"
        Me.chkdebug.Size = New System.Drawing.Size(96, 17)
        Me.chkdebug.TabIndex = 28
        Me.chkdebug.Text = "Mostrar Debug"
        Me.chkdebug.UseVisualStyleBackColor = True
        '
        'chkcontexto
        '
        Me.chkcontexto.AutoSize = True
        Me.chkcontexto.Location = New System.Drawing.Point(333, 28)
        Me.chkcontexto.Name = "chkcontexto"
        Me.chkcontexto.Size = New System.Drawing.Size(146, 17)
        Me.chkcontexto.TabIndex = 27
        Me.chkcontexto.Text = "Mostrar Contexto General"
        Me.chkcontexto.UseVisualStyleBackColor = True
        '
        'lstdebug
        '
        Me.lstdebug.FormattingEnabled = True
        Me.lstdebug.Location = New System.Drawing.Point(14, 101)
        Me.lstdebug.Name = "lstdebug"
        Me.lstdebug.Size = New System.Drawing.Size(465, 186)
        Me.lstdebug.TabIndex = 10
        '
        'prbgenaro
        '
        Me.prbgenaro.Location = New System.Drawing.Point(13, 72)
        Me.prbgenaro.Name = "prbgenaro"
        Me.prbgenaro.Size = New System.Drawing.Size(466, 23)
        Me.prbgenaro.TabIndex = 9
        '
        'btnGenerar
        '
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGenerar.Location = New System.Drawing.Point(14, 41)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(138, 23)
        Me.btnGenerar.TabIndex = 8
        Me.btnGenerar.Text = "Generar..."
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'grbpaso6
        '
        Me.grbpaso6.Controls.Add(Me.picdirmap)
        Me.grbpaso6.Controls.Add(Me.Label17)
        Me.grbpaso6.Controls.Add(Me.txtdirmap)
        Me.grbpaso6.Controls.Add(Me.Label16)
        Me.grbpaso6.Controls.Add(Me.picdirnegocio)
        Me.grbpaso6.Controls.Add(Me.picdirdao)
        Me.grbpaso6.Controls.Add(Me.picdirbeans)
        Me.grbpaso6.Controls.Add(Me.txtdirnegocio)
        Me.grbpaso6.Controls.Add(Me.txtdirdao)
        Me.grbpaso6.Controls.Add(Me.txtdirbeans)
        Me.grbpaso6.Controls.Add(Me.Label5)
        Me.grbpaso6.Controls.Add(Me.Label4)
        Me.grbpaso6.Controls.Add(Me.Label3)
        Me.grbpaso6.Controls.Add(Me.txtmasknegocio)
        Me.grbpaso6.Controls.Add(Me.Label18)
        Me.grbpaso6.Controls.Add(Me.Label2)
        Me.grbpaso6.Controls.Add(Me.Label1)
        Me.grbpaso6.Controls.Add(Me.btnexaminar)
        Me.grbpaso6.Controls.Add(Me.txtdirectory)
        Me.grbpaso6.Location = New System.Drawing.Point(172, 13)
        Me.grbpaso6.Name = "grbpaso6"
        Me.grbpaso6.Size = New System.Drawing.Size(491, 297)
        Me.grbpaso6.TabIndex = 31
        Me.grbpaso6.TabStop = False
        Me.grbpaso6.Text = "PASO 6 :  Rutas y Nombres de Componentes "
        Me.grbpaso6.Visible = False
        '
        'picdirmap
        '
        Me.picdirmap.Image = CType(resources.GetObject("picdirmap.Image"), System.Drawing.Image)
        Me.picdirmap.Location = New System.Drawing.Point(466, 216)
        Me.picdirmap.Name = "picdirmap"
        Me.picdirmap.Size = New System.Drawing.Size(19, 17)
        Me.picdirmap.TabIndex = 52
        Me.picdirmap.TabStop = False
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(13, 218)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 15)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "Mapeos xml"
        '
        'txtdirmap
        '
        Me.txtdirmap.Location = New System.Drawing.Point(203, 215)
        Me.txtdirmap.Name = "txtdirmap"
        Me.txtdirmap.ReadOnly = True
        Me.txtdirmap.Size = New System.Drawing.Size(260, 20)
        Me.txtdirmap.TabIndex = 50
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(13, 192)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 17)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "Clases dao"
        '
        'picdirnegocio
        '
        Me.picdirnegocio.Image = CType(resources.GetObject("picdirnegocio.Image"), System.Drawing.Image)
        Me.picdirnegocio.Location = New System.Drawing.Point(466, 243)
        Me.picdirnegocio.Name = "picdirnegocio"
        Me.picdirnegocio.Size = New System.Drawing.Size(19, 18)
        Me.picdirnegocio.TabIndex = 48
        Me.picdirnegocio.TabStop = False
        '
        'picdirdao
        '
        Me.picdirdao.Image = CType(resources.GetObject("picdirdao.Image"), System.Drawing.Image)
        Me.picdirdao.Location = New System.Drawing.Point(466, 189)
        Me.picdirdao.Name = "picdirdao"
        Me.picdirdao.Size = New System.Drawing.Size(19, 20)
        Me.picdirdao.TabIndex = 47
        Me.picdirdao.TabStop = False
        '
        'picdirbeans
        '
        Me.picdirbeans.Image = CType(resources.GetObject("picdirbeans.Image"), System.Drawing.Image)
        Me.picdirbeans.Location = New System.Drawing.Point(466, 163)
        Me.picdirbeans.Name = "picdirbeans"
        Me.picdirbeans.Size = New System.Drawing.Size(19, 20)
        Me.picdirbeans.TabIndex = 46
        Me.picdirbeans.TabStop = False
        '
        'txtdirnegocio
        '
        Me.txtdirnegocio.Location = New System.Drawing.Point(203, 241)
        Me.txtdirnegocio.Name = "txtdirnegocio"
        Me.txtdirnegocio.ReadOnly = True
        Me.txtdirnegocio.Size = New System.Drawing.Size(260, 20)
        Me.txtdirnegocio.TabIndex = 44
        '
        'txtdirdao
        '
        Me.txtdirdao.Location = New System.Drawing.Point(203, 189)
        Me.txtdirdao.Name = "txtdirdao"
        Me.txtdirdao.ReadOnly = True
        Me.txtdirdao.Size = New System.Drawing.Size(260, 20)
        Me.txtdirdao.TabIndex = 43
        '
        'txtdirbeans
        '
        Me.txtdirbeans.Location = New System.Drawing.Point(203, 163)
        Me.txtdirbeans.Name = "txtdirbeans"
        Me.txtdirbeans.ReadOnly = True
        Me.txtdirbeans.Size = New System.Drawing.Size(260, 20)
        Me.txtdirbeans.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(294, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 18)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Directorio"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(84, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Mascara"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(14, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Beans (pojo)"
        '
        'txtmasknegocio
        '
        Me.txtmasknegocio.Location = New System.Drawing.Point(67, 241)
        Me.txtmasknegocio.Name = "txtmasknegocio"
        Me.txtmasknegocio.Size = New System.Drawing.Size(129, 20)
        Me.txtmasknegocio.TabIndex = 35
        Me.txtmasknegocio.Text = "BUSClase"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(13, 244)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 17)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Negocio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(396, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Seleccione el DIRECTORIO RAIZ a partir de donde se dejarán los componentes..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "NOMBRADO y LOCALIZACIÓN de componentes:"
        '
        'btnexaminar
        '
        Me.btnexaminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnexaminar.Location = New System.Drawing.Point(16, 68)
        Me.btnexaminar.Name = "btnexaminar"
        Me.btnexaminar.Size = New System.Drawing.Size(138, 23)
        Me.btnexaminar.TabIndex = 23
        Me.btnexaminar.Text = "Examinar..."
        Me.btnexaminar.UseVisualStyleBackColor = True
        '
        'txtdirectory
        '
        Me.txtdirectory.Location = New System.Drawing.Point(17, 42)
        Me.txtdirectory.Name = "txtdirectory"
        Me.txtdirectory.ReadOnly = True
        Me.txtdirectory.Size = New System.Drawing.Size(446, 20)
        Me.txtdirectory.TabIndex = 22
        '
        'frmgenerahibernate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(673, 358)
        Me.Controls.Add(Me.btnsiguiente)
        Me.Controls.Add(Me.btnanterior)
        Me.Controls.Add(Me.btnterminar)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.grbpaso4)
        Me.Controls.Add(Me.grbpaso3)
        Me.Controls.Add(Me.grbpaso2)
        Me.Controls.Add(Me.grbpaso1)
        Me.Controls.Add(Me.grbpaso5)
        Me.Controls.Add(Me.grbpaso6)
        Me.Controls.Add(Me.grbpaso7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmgenerahibernate"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "WIZART ! de Persistencia HIBERNATE"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbpaso3.ResumeLayout(False)
        Me.grbpaso3.PerformLayout()
        Me.grbpaso2.ResumeLayout(False)
        Me.grbpaso2.PerformLayout()
        Me.grbpaso4.ResumeLayout(False)
        Me.grbpaso4.PerformLayout()
        CType(Me.griddbentidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbpaso1.ResumeLayout(False)
        Me.grbpaso1.PerformLayout()
        Me.grbpaso5.ResumeLayout(False)
        Me.grbpaso5.PerformLayout()
        Me.grbpaso7.ResumeLayout(False)
        Me.grbpaso7.PerformLayout()
        Me.grbpaso6.ResumeLayout(False)
        Me.grbpaso6.PerformLayout()
        CType(Me.picdirmap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picdirnegocio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picdirdao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picdirbeans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmgenerahibernate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oxmlmain As Nodo
        Dim oxmlestilos As Nodo
        Dim oxmlreglas As Nodo
        Dim cestilos As Collection
        Dim cftes As Collection
        Dim ocol As Collection

        Try
            'PASO 1: Inicializa los valores
            omdipa = Me.ParentForm
            obus = New Catalogos(omdipa.conexion)
            outil = New Utilerias
            ozip = New ZipArchivo(omdipa.configuracion)
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")
            oxmlreglas = oxmlmain.getPrimerNodo("convertidor-db2code")
            cestilos = oxmlestilos.Buscar("estilo", "tipo", "hibernate")

            'PASO 2: Llena el catálogo de estilos
            For Each oestilo As Nodo In cestilos
                Me.lstestilo.Items.Add(oestilo.getValue("estilo.clave") & " - " & oestilo.getValue("estilo.nombre"))
            Next

            'PASO 3: LLena el catálogo de fuentes de datos
            cftes = obus.getFuenteDatos(New Criterio)
            For Each ofte As FuenteDato In cftes
                Me.cbofuentedatos.Items.Add(ofte.cdfuentedato & " - " & ofte.nbfuentedato)
            Next

            'PASO 4: Llena el catálogo de reglas de conversión
            ocol = oxmlreglas.getNodo("conversion")
            For Each onodo As Nodo In ocol
                Me.cboregla.Items.Add(onodo.getValue("conversion.clave") & " - " & onodo.getValue("conversion.nombre"))
            Next

            'PASO 5: Concluye
            Me.lstestilo.SelectedIndex = 0
            Me.cbofuentedatos.SelectedIndex = 0

        Catch ex As HANYException
            Me.Cursor = Cursors.Default
            ex.add("MyGENARO.frmgenerarhibernate.frmgenerahibernate_Load()", "Ocurrio un error al cargar Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            Me.Cursor = Cursors.Default
            outil.ShowException(New HANYException("MyGENARO.frmgenerarhibernatefrmgenerahibernate_Load()", "Ocurrio un error al cargar Pantalla [" & ex1.ToString & "]"))
        End Try
    End Sub

    Public Sub Configura_GridEntidades()
        griddbentidades.Rows.Clear()
        griddbentidades.Columns.Clear()
        griddbentidades.Columns.Add("nbentidad", "Nombre Entidad")
        griddbentidades.Columns.Add("nbcampo", "Campo")
        griddbentidades.Columns.Add("tipodato", "Tipo de dato")
        griddbentidades.Columns.Add("llave", "Llave")
        griddbentidades.Columns.Add("tpvariable", "Tipo de variable")
        griddbentidades.Columns.Add("nbvariable", "Clase ó variable")
        griddbentidades.Columns.Add("comment", "Comentario")

        griddbentidades.Columns.Item("nbentidad").Width = 120
        griddbentidades.Columns.Item("nbentidad").ReadOnly = True
        griddbentidades.Columns.Item("nbcampo").Width = 120
        griddbentidades.Columns.Item("nbcampo").ReadOnly = True
        griddbentidades.Columns.Item("tipodato").Width = 80
        griddbentidades.Columns.Item("tipodato").ReadOnly = True
        griddbentidades.Columns.Item("llave").Width = 30
        griddbentidades.Columns.Item("llave").ReadOnly = True
        griddbentidades.Columns.Item("tpvariable").Width = 50
        griddbentidades.Columns.Item("nbvariable").Width = 80
        griddbentidades.Columns.Item("comment").Width = 300
        griddbentidades.Columns.Item("nbentidad").SortMode = DataGridViewColumnSortMode.NotSortable
        griddbentidades.Columns.Item("nbcampo").SortMode = DataGridViewColumnSortMode.NotSortable
        griddbentidades.Columns.Item("tipodato").SortMode = DataGridViewColumnSortMode.NotSortable
        griddbentidades.Columns.Item("llave").SortMode = DataGridViewColumnSortMode.NotSortable
        griddbentidades.Columns.Item("tpvariable").SortMode = DataGridViewColumnSortMode.NotSortable
        griddbentidades.Columns.Item("nbvariable").SortMode = DataGridViewColumnSortMode.NotSortable
        griddbentidades.Columns.Item("comment").SortMode = DataGridViewColumnSortMode.NotSortable

    End Sub

    Private Sub Cambia_pagina()
        If ipagina < 1 Then ipagina = 1
        If ipagina > 7 Then ipagina = 7

        If ipagina = 1 Then
            grbpaso1.Visible = True
            grbpaso2.Visible = False
            grbpaso3.Visible = False
            grbpaso4.Visible = False
            grbpaso5.Visible = False
            grbpaso6.Visible = False
            grbpaso7.Visible = False
        End If
        If ipagina = 2 Then
            grbpaso1.Visible = False
            grbpaso2.Visible = True
            grbpaso3.Visible = False
            grbpaso4.Visible = False
            grbpaso5.Visible = False
            grbpaso6.Visible = False
            grbpaso7.Visible = False
        End If
        If ipagina = 3 Then
            grbpaso1.Visible = False
            grbpaso2.Visible = False
            grbpaso3.Visible = True
            grbpaso4.Visible = False
            grbpaso5.Visible = False
            grbpaso6.Visible = False
            grbpaso7.Visible = False
        End If
        If ipagina = 4 Then
            grbpaso1.Visible = False
            grbpaso2.Visible = False
            grbpaso3.Visible = False
            grbpaso4.Visible = True
            grbpaso5.Visible = False
            grbpaso6.Visible = False
            grbpaso7.Visible = False
        End If
        If ipagina = 5 Then
            grbpaso1.Visible = False
            grbpaso2.Visible = False
            grbpaso3.Visible = False
            grbpaso4.Visible = False
            grbpaso5.Visible = True
            grbpaso6.Visible = False
            grbpaso7.Visible = False
        End If
        If ipagina = 6 Then
            grbpaso1.Visible = False
            grbpaso2.Visible = False
            grbpaso3.Visible = False
            grbpaso4.Visible = False
            grbpaso5.Visible = False
            grbpaso6.Visible = True
            grbpaso7.Visible = False
        End If
        If ipagina = 7 Then
            grbpaso1.Visible = False
            grbpaso2.Visible = False
            grbpaso3.Visible = False
            grbpaso4.Visible = False
            grbpaso5.Visible = False
            grbpaso6.Visible = False
            grbpaso7.Visible = True
        End If
    End Sub

    Private Sub btnsiguiente_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsiguiente.Click
        ipagina = ipagina + 1
        Call Cambia_pagina()
    End Sub

    Private Sub btnanterior_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnanterior.Click
        ipagina = ipagina - 1
        Call Cambia_pagina()
    End Sub

    Private Sub btnterminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnterminar.Click
        Me.Close()
    End Sub

    Private Sub btncargarestilo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncargarestilo.Click
        Dim oxmlmain As Nodo
        Dim oxmlestilo As Nodo
        Dim oxmlestilos As Nodo
        Dim oxmllenguaje As Nodo
        Dim oxmlgeneral As Nodo
        Dim oxmlmodel As Nodo

        oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
        oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")
        oxmlestilo = oxmlmain.BuscarPrimero("estilo", "clave", outil.Toma_Token(1, Me.lstestilo.SelectedItem, "-"))
        oxmllenguaje = New Nodo(ozip.getFileInflated(oxmlestilo.getValue("directorio") & oxmlestilo.getValue("configuracion")))
        oxmlgeneral = oxmllenguaje.getPrimerNodo("general")
        oxmlmodel = oxmllenguaje.getPrimerNodo("model")

        Me.txtnbestilo.Text = outil.Toma_Token(2, Me.lstestilo.SelectedItem, "-")
        Me.txtnblenguaje.Text = oxmlgeneral.getValue("general.lenguaje")
        Me.txtfhcreacion.Text = oxmlgeneral.getValue("general.fecha_creacion")
        Me.txtnbide.Text = oxmlgeneral.getValue("general.ide")
        Me.txtnbautor.Text = oxmlgeneral.getValue("general.autor")
        Me.txtcomment.Text = oxmlgeneral.getValue("general.comment")

    End Sub

    ''' <summary>
    ''' Procedimiento para procesar las entidades a partir de una lista que pertenecen a una
    ''' fuente de datos
    ''' </summary>
    ''' <param name="sfte">nombre de la fuente</param>
    ''' <param name="sentidades">entidades</param>
    ''' <remarks></remarks>
    Private Sub procesa_fte_to_grid(ByVal sfte As String, ByVal sentidades As String)
        Dim oxmlmain, oxmlestilo As Nodo
        Dim oxmlestilos As Nodo
        Dim oxmlreglas, oxmlregla, oxmlconvert As Nodo
        Dim ocentidades As Collection
        Dim occampos As Collection

        Try
            'PASO 1: Se inicializa el estilo de programación
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")
            oxmlestilo = oxmlmain.BuscarPrimero("estilo", "clave", outil.Toma_Token(1, Me.lstestilo.SelectedItem, "-"))

            'PASO 2: Se inicializa la regla de conversión
            oxmlreglas = oxmlmain.getPrimerNodo("convertidor-db2code")
            oxmlregla = oxmlreglas.BuscarPrimero("conversion", "clave", outil.Toma_Token(1, Me.cboregla.SelectedItem, "-"))
            oxmlconvert = New Nodo(ozip.getFileInflated(oxmlregla.getValue("directorio") & oxmlregla.getValue("configuracion")))

            Call Configura_GridEntidades()
            ocentidades = outil.CAparta_Tokens(sentidades, ",")
            For Each sentidad As String In ocentidades
                Dim oentidad As EntidaDato
                oentidad = obus.getEntidaDato(sfte, sentidad)
                griddbentidades.Rows.Add(oentidad.nbentidadato, "", "", "", "", IIf(oentidad.nbclase.Equals(""), Me.getnbclase_fromtabla(sentidad), IIf(chknombre.Checked, oentidad.nbclase, Me.getnbclase_fromtabla(sentidad))), IIf(oentidad.txclasecomment.Equals(""), oentidad.txcomment, oentidad.txclasecomment))
                occampos = obus.getEntidaDatoCampos(sfte, sentidad)
                For Each ocampo As EntidaDatoCampo In occampos
                    Dim oxmltipo As Nodo = oxmlconvert.BuscarPrimero("tipodato", "origendb", ocampo.cdtpdatofisico.ToLower)
                    Dim snbtipovar As String = ""
                    Dim snbvariable As String = ""
                    If oxmltipo Is Nothing Then
                        snbtipovar = "NO_CONVERTIDO"
                        snbvariable = outil.Quita_Caracter(ocampo.nbcampo.ToLower, "_")
                    Else
                        snbtipovar = oxmltipo.getValue("tipodato.tipovariable")
                        snbvariable = oxmltipo.getValue("tipodato.iniciacon") & outil.Quita_Caracter(ocampo.nbcampo.ToLower, "_")
                    End If
                    griddbentidades.Rows.Add("", ocampo.nbcampo, ocampo.cdtpdatofisico, IIf(ocampo.isllave, "*", ""), snbtipovar, IIf(ocampo.nbvariable.Equals(""), snbvariable, IIf(chknombre.Checked, ocampo.nbvariable, snbvariable)), ocampo.txcomment)
                Next
            Next
        Catch ex As HANYException
            Me.Cursor = Cursors.Default
            ex.add("MyGENARO.frmgenerarhibernate.procesa_fte_to_grid()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            Me.Cursor = Cursors.Default
            outil.ShowException(New HANYException("MyGENARO.frmgenerarhibernate.procesa_fte_to_grid()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try
    End Sub

    ''' <summary>
    ''' Metodo para consultar el detalle de las clases en una colección
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Private Function getEntidades() As Collection
        Dim iren As Integer
        Dim stabla As String
        Dim sfte As String
        Dim ocol As Collection = New Collection
        Try
            sfte = outil.Toma_Token(1, Me.cbofuentedatos.SelectedItem, "-")
            For iren = 0 To griddbentidades.Rows.Count - 1
                stabla = griddbentidades.Item("nbentidad", iren).Value
                If stabla <> "" Then
                    Dim oentidad As EntidaDato = obus.getEntidaDato(sfte, stabla)
                    oentidad.nbclase = griddbentidades.Item("nbvariable", iren).Value
                    oentidad.txclasecomment = griddbentidades.Item("comment", iren).Value
                    oentidad.ccampos = obus.getEntidaDatoCampos(sfte, stabla)
                    ocol.Add(oentidad)
                End If
            Next iren
        Catch ex As HANYException
            Me.Cursor = Cursors.Default
            ex.add("MyGENARO.frmgenerarhibernate.getEntidades()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            Me.Cursor = Cursors.Default
            outil.ShowException(New HANYException("MyGENARO.frmgenerarhibernate.getEntidades()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try

        Return ocol
    End Function

    ''' <summary>
    ''' Metodo para consultar las variables de una clase en particular
    ''' </summary>
    ''' <param name="psclase">Nombre de la clase</param>
    ''' <param name="pstabla">Nombre de la tabla</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function getVariables(ByVal psclase As String, ByVal pstabla As String) As Collection
        Dim iren, icla As Integer
        Dim ocol As Collection = New Collection

        Try
            For iren = 0 To griddbentidades.Rows.Count - 1
                If griddbentidades.Item("nbentidad", iren).Value.Equals(pstabla) And griddbentidades.Item("nbvariable", iren).Value.Equals(psclase) Then
                    For icla = iren + 1 To griddbentidades.Rows.Count - 1
                        If Not griddbentidades.Item("nbentidad", icla).Value.Equals("") Then Exit For
                        Dim ovar As Variable = New Variable
                        Dim ocampo As EntidaDatoCampo = obus.getEntidaDatoCampo(outil.Toma_Token(1, cbofuentedatos.Text, "-"), pstabla, griddbentidades.Item("nbcampo", icla).Value)
                        ovar.nombre = griddbentidades.Item("nbvariable", icla).Value
                        ovar.dbcampo = griddbentidades.Item("nbcampo", icla).Value
                        ovar.tipo = griddbentidades.Item("tpvariable", icla).Value
                        ovar.nulongitud = ocampo.nulongitud
                        ovar.nudecimales = ocampo.nudecimales
                        ovar.llave = IIf(griddbentidades.Item("llave", icla).Value.Equals("*"), True, False)
                        ovar.comment = griddbentidades.Item("comment", icla).Value
                        ocol.Add(ovar)
                    Next
                End If
            Next iren
        Catch ex As HANYException
            Me.Cursor = Cursors.Default
            ex.add("MyGENARO.frmgenerarhibernate.getVariables()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            Me.Cursor = Cursors.Default
            outil.ShowException(New HANYException("MyGENARO.frmgenerarhibernate.getVariables()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try

        Return ocol
    End Function

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Dim sfilecontent As String
        Dim oxmlmain, oxmlestilo, oxmllenguaje, oxmlmeta As Nodo
        Dim oxmldatos, oxmlestilos, oxmlmodel, oxmlibrerias As Nodo
        Dim ocentidades As Collection
        Dim oclibrerias As Collection
        Dim icounter As Integer
        Dim bErrorFatal As Boolean
        Dim spath As String
        Dim ometa As MetacodigoReader
        Dim cclases As Collection
        Dim sxmlall As String
        Dim salldebug As String

        Try
            'PASO 1: Incializa todo...
            sxmlall = ""
            If Not validaTodosInsumos() Then Exit Sub
            ocentidades = Me.getEntidades()
            prbgenaro.Minimum = 0
            prbgenaro.Maximum = 0
            lstdebug.Items.Clear()
            icounter = 0
            spath = ""
            salldebug = ""
            bErrorFatal = False
            cclases = New Collection
            Me.Cursor = Cursors.WaitCursor

            'PASO 2: Lee el archivo de configuración
            outil.addToListDebug(lstdebug, "PASO 01: Se lee la configuración de la generación...")
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")
            oxmlestilo = oxmlmain.BuscarPrimero("estilo", "clave", outil.Toma_Token(1, Me.lstestilo.SelectedItem, "-"))
            oxmllenguaje = New Nodo(ozip.getFileInflated(oxmlestilo.getValue("directorio") & oxmlestilo.getValue("configuracion")))
            oxmlibrerias = oxmllenguaje.getPrimerNodo("librerias")
            oclibrerias = oxmlibrerias.getNodo("libreria")

            'PASO 3: Lee el meta-código para la generación del mapeo en XML
            prbgenaro.Maximum = (ocentidades.Count * 3) + oclibrerias.Count + IIf(Me.radtodoenuno.Checked, 2, 0) + IIf(Me.radunoauno.Checked, ocentidades.Count * 2, 0)
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "PASO 02: Genera los mapeos en xml...")
            ometa = New MetacodigoReader()
            oxmlmodel = oxmllenguaje.getPrimerNodo("model")
            oxmlmeta = oxmlmodel.BuscarPrimero("codigo", "nombre", "mapeo")
            ometa.file = oxmlmeta.getValue("archivo")
            ometa.source = ozip.getFileInflated(oxmlestilo.getValue("directorio") & oxmlmeta.getValue("archivo"))
            spath = IIf(Me.txtdirmap.Text.Equals(""), Me.txtdirectory.Text, Me.txtdirmap.Text.Replace("...", Me.txtdirectory.Text))

            'PASO 4: Genera el código necesario 
            For Each oent As EntidaDato In ocentidades
                Dim oclase As Clase = New Clase
                oclase.name = oent.nbclase
                oclase.comment = oent.txcomment
                oclase.entidato = oent
                oclase.variables = Me.getVariables(oclase.name, oent.nbentidadato)
                oxmldatos = New Nodo(oclase.GetXML())
                oxmldatos.addNodoEn("clase", oxmlconfig)
                sfilecontent = ometa.Interpreta(oxmldatos.GetXML())
                sxmlall = sxmlall & oxmldatos.GetXML()
                If chkdebug.Checked Then salldebug = salldebug & "Archivo: " & oclase.name & oxmlmeta.getValue("extension") & vbLf & ometa.getdebug()
                If Not outil.EscribeNuevoArchivo(spath & "/" & oclase.name & oxmlmeta.getValue("extension"), sfilecontent) Then
                    outil.addToListDebug(lstdebug, "  Error Generando : " & oclase.name & oxmlmeta.getValue("extension"))
                    bErrorFatal = True
                Else
                    outil.addToListDebug(lstdebug, "  Generando : " & oclase.name & oxmlmeta.getValue("extension"))
                End If

                'PASO 4.1: Actualiza la información de la entidad de datos + de cada campo
                obus.saveEntidaDato(oent)
                For Each ovar As Variable In oclase.variables
                    Dim ocampo As EntidaDatoCampo = obus.getEntidaDatoCampo(oent.cdfuentedato, oent.nbentidadato, ovar.dbcampo)
                    If Not ocampo Is Nothing Then
                        ocampo.nbvariable = ovar.nombre
                        obus.saveEntidaDatoCampo(ocampo)
                    End If
                Next
                cclases.Add(oclase)
                icounter = icounter + 1
                'prbgenaro.Value = icounter
            Next

            'PASO 5: Lee el meta-código para la generación de beans de datos
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "PASO 03: Genera los beans de datos...")
            ometa = New MetacodigoReader()
            oxmlmodel = oxmllenguaje.getPrimerNodo("model")
            oxmlmeta = oxmlmodel.BuscarPrimero("codigo", "nombre", "bean")
            ometa.file = oxmlmeta.getValue("archivo")
            ometa.source = ozip.getFileInflated(oxmlestilo.getValue("directorio") & oxmlmeta.getValue("archivo"))
            spath = IIf(Me.txtdirbeans.Text.Equals(""), Me.txtdirectory.Text, Me.txtdirbeans.Text.Replace("...", Me.txtdirectory.Text))

            'PASO 6: Genera el código necesario 
            For Each oclase As Clase In cclases
                oxmldatos = New Nodo(oclase.GetXML())
                oxmldatos.addNodoEn("clase", oxmlconfig)
                sfilecontent = ometa.Interpreta(oxmldatos.GetXML())
                If chkdebug.Checked Then salldebug = salldebug & " Archivo: " & oclase.name & oxmlmeta.getValue("extension") & vbLf & ometa.getdebug()
                If Not outil.EscribeNuevoArchivo(spath & "/" & oclase.name & oxmlmeta.getValue("extension"), sfilecontent) Then
                    outil.addToListDebug(lstdebug, "  Error Generando : " & oclase.name & oxmlmeta.getValue("extension"))
                    bErrorFatal = True
                Else
                    outil.addToListDebug(lstdebug, "  Generando : " & oclase.name & oxmlmeta.getValue("extension"))
                End If
                icounter = icounter + 1
                'prbgenaro.Value = icounter
            Next

            'PASO 7: Lee el meta-código para la generación de las clases DAO
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "PASO 04: Genera los metodos dao...")
            ometa = New MetacodigoReader()
            oxmlmodel = oxmllenguaje.getPrimerNodo("model")
            oxmlmeta = oxmlmodel.BuscarPrimero("codigo", "nombre", "dao")
            ometa.file = oxmlmeta.getValue("archivo")
            ometa.source = ozip.getFileInflated(oxmlestilo.getValue("directorio") & oxmlmeta.getValue("archivo"))
            spath = IIf(Me.txtdirdao.Text.Equals(""), Me.txtdirectory.Text, Me.txtdirdao.Text.Replace("...", Me.txtdirectory.Text))

            'PASO 8: Genera el código necesario 
            For Each oclase As Clase In cclases
                oxmldatos = New Nodo(oclase.GetXML())
                oxmldatos.addNodoEn("clase", oxmlconfig)
                sfilecontent = ometa.Interpreta(oxmldatos.GetXML())
                If chkdebug.Checked Then salldebug = salldebug & " Archivo: " & oclase.name & "DAO" & oxmlmeta.getValue("extension") & vbLf & ometa.getdebug()
                If Not outil.EscribeNuevoArchivo(spath & "/" & oclase.name & "DAO" & oxmlmeta.getValue("extension"), sfilecontent) Then
                    outil.addToListDebug(lstdebug, "  Error Generando : " & oclase.name & oxmlmeta.getValue("extension"))
                    bErrorFatal = True
                Else
                    outil.addToListDebug(lstdebug, "  Generando : " & oclase.name & "DAO" & oxmlmeta.getValue("extension"))
                End If
                icounter = icounter + 1
                'prbgenaro.Value = icounter
            Next

            'PASO 8: Lee el meta-código para la generación de las Primer Key
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "PASO 05: Genera las clases primary key...")
            ometa = New MetacodigoReader()
            oxmlmodel = oxmllenguaje.getPrimerNodo("model")
            oxmlmeta = oxmlmodel.BuscarPrimero("codigo", "nombre", "beanid")
            ometa.file = oxmlmeta.getValue("archivo")
            ometa.source = ozip.getFileInflated(oxmlestilo.getValue("directorio") & oxmlmeta.getValue("archivo"))
            spath = IIf(Me.txtdirbeans.Text.Equals(""), Me.txtdirectory.Text, Me.txtdirbeans.Text.Replace("...", Me.txtdirectory.Text))

            'PASO 8: Genera el código necesario 
            For Each oclase As Clase In cclases
                If oclase.entidato.gethasLlaveCompuesta() Then
                    oxmldatos = New Nodo(oclase.GetXML())
                    oxmldatos.addNodoEn("clase", oxmlconfig)
                    sfilecontent = ometa.Interpreta(oxmldatos.GetXML())
                    If chkdebug.Checked Then salldebug = salldebug & " Archivo: " & oclase.name & "Id" & oxmlmeta.getValue("extension") & vbLf & ometa.getdebug()
                    If Not outil.EscribeNuevoArchivo(spath & "/" & oclase.name & "Id" & oxmlmeta.getValue("extension"), sfilecontent) Then
                        outil.addToListDebug(lstdebug, "  Error Generando : " & oclase.name & oxmlmeta.getValue("extension"))
                        bErrorFatal = True
                    Else
                        outil.addToListDebug(lstdebug, "  Generando : " & oclase.name & "Id" & oxmlmeta.getValue("extension"))
                    End If
                    icounter = icounter + 1
                    'prbgenaro.Value = icounter
                End If
            Next

            'PASO 11: Termina...
            If chkcontexto.Checked Then outil.Preveer(sxmlall)
            If chkdebug.Checked Then outil.Preveer(salldebug)

            outil.addToListDebug(lstdebug, "")
            lstdebug.TopIndex = lstdebug.Items.Count - 1
            If bErrorFatal Then
                outil.addToListDebug(lstdebug, "! PROCESO CON ERRORES !")
                MsgBox("! Proceso terminado CON ERRORES !", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
            Else
                outil.addToListDebug(lstdebug, "! PROCESO TERMINADO EXITOSAMENTE !")
                MsgBox("! Proceso terminado Exitosamente !", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
            End If

        Catch ex As HANYException
            Me.Cursor = Cursors.Default
            ex.add("MyGENARO.frmgenerarhibernate.btnGenerar_Click()", "Ocurrio un error al generar código hibernate")
            outil.ShowException(ex)
        Catch ex1 As Exception
            Me.Cursor = Cursors.Default
            outil.ShowException(New HANYException("MyGENARO.frmgenerarhibernate.btnGenerar_Click()", "Ocurrio un error al generar código hibernate [" & ex1.ToString & "]"))
        End Try
        Me.Cursor = Cursors.Default

    End Sub

    Private Function validaTodosInsumos() As Boolean

        'PASO 1: Valida la configuración particular del lenguaje
        If oxmlconfig Is Nothing Then
            MsgBox("Es necesario configurar las particularidades del lenguaje", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
            Return False
        End If

        'PASO 2: Valida los los datos capturados
        If Trim(Me.txtdirectory.Text.Trim.Equals("")) Then
            MsgBox("Es necesario seleccionar el directorio raiz donde se grabaran los componentes", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
            Return False
        End If

        'PASO 3: Valida la mascara de negocio
        If Trim(Me.txtmasknegocio.Text.Trim.Equals("")) Then
            MsgBox("Es necesario ingresar la mascara para nombrar las clases de negocio", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
            Return False
        End If
        If Me.txtmasknegocio.Text.IndexOf(".") > 0 Then
            MsgBox("El nombre del componente de negocio, no puede tener extensión", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
            Return False
        End If

        Return True
    End Function

    Private Sub btnexaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexaminar.Click
        FolderBrowserDialog.SelectedPath = Comun.STR_DIRECTORIO
        If (FolderBrowserDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Me.txtdirectory.Text = FolderBrowserDialog.SelectedPath
            Comun.STR_DIRECTORIO = Me.txtdirectory.Text
        End If
    End Sub

    Private Sub btnconfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfig.Click
        Dim ofrm As frmWizard
        Dim oxmlmain, oxmlestilos, oxmlestilo, oxmllenguaje As Nodo
        Dim oxmlwizard As Nodo

        Try

            'PASO 1: Inicializa los valores
            ofrm = New frmWizard()
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")
            oxmlestilo = oxmlmain.BuscarPrimero("estilo", "clave", outil.Toma_Token(1, Me.lstestilo.SelectedItem, "-"))
            oxmllenguaje = New Nodo(ozip.getFileInflated(oxmlestilo.getValue("directorio") & oxmlestilo.getValue("configuracion")))

            'PASO 2: Lee los parámetros propios de la plataforma
            oxmlwizard = New Nodo(ozip.getFileInflated(oxmlestilo.getValue("directorio") & oxmllenguaje.getValue("code.general.wizard")))
            ofrm.xmlvalues = oxmlconfig
            ofrm.xmlin = oxmlwizard.GetXML()
            ofrm.ShowDialog()
            If ofrm.xmlout.Trim.Equals("") Then
                oxmlconfig = Nothing
                chkconfig.Checked = False
                Exit Sub
            End If

            'PASO 3: Termina...
            oxmlconfig = New Nodo(ofrm.xmlout)
            chkconfig.Checked = True
            ofrm = Nothing

        Catch ex As HANYException
            ex.add("MyGENARO.frmgenerarhibernate.btnconfig_Click()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmgenerarhibernate.btnconfig_Click()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Sub

    Private Sub picdirbeans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picdirbeans.Click
        If Me.txtdirectory.Text.Trim.Equals("") Then
            MsgBox("Es necesario seleccionar un directorio raiz donde escribir los componentes", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        FolderBrowserDialog.SelectedPath = Me.txtdirectory.Text
        If (FolderBrowserDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim sdir As String
            sdir = FolderBrowserDialog.SelectedPath
            If sdir.Equals(Me.txtdirectory.Text) Then
                Me.txtdirbeans.Text = ""
                Exit Sub
            End If
            Me.txtdirbeans.Text = sdir.Replace(Me.txtdirectory.Text, "...")
        End If
    End Sub

    Private Sub picdirnegocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picdirnegocio.Click
        If Me.txtdirectory.Text.Trim.Equals("") Then
            MsgBox("Es necesario seleccionar un directorio raiz donde escribir los componentes", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        FolderBrowserDialog.SelectedPath = Me.txtdirectory.Text
        If (FolderBrowserDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim sdir As String
            sdir = FolderBrowserDialog.SelectedPath
            If sdir.Equals(Me.txtdirectory.Text) Then
                Me.txtdirnegocio.Text = ""
                Exit Sub
            End If
            Me.txtdirnegocio.Text = sdir.Replace(Me.txtdirectory.Text, "...")
        End If
    End Sub

    Private Sub radtodoenuno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radtodoenuno.CheckedChanged
        If radtodoenuno.Checked Then
            Me.txtmasknegocio.Text = "BUSClase"
        End If
    End Sub

    Private Sub radunoauno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radunoauno.CheckedChanged
        If radunoauno.Checked Then
            Me.txtmasknegocio.Text = "BUS{entidad}"
        End If
    End Sub

    'METODO: para obtener el nombre de la tabla a partir de un nombre de tabla
    Public Function getnbclase_fromtabla(ByVal snom As String) As String
        Dim sclase As String
        Dim sresult As String
        Dim oc As Collection

        Try
            'PASO 1: Inicializa
            sclase = LCase(snom)
            oc = outil.CAparta_Tokens(sclase, "_")
            sresult = ""

            'PASO 2: Recorre el nombre
            If oc.Count > 0 Then
                For Each sparte As String In oc
                    sresult = sresult & sparte.Substring(0, 1).ToUpper & Mid(sparte, 2).ToLower
                Next
            End If

        Catch ex As HANYException
            ex.add("MyGENARO.frmgenerarhibernate.getnbclase_fromtabla()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmgenerarhibernate.getnbclase_fromtabla()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

        'PASO 3: Termina
        Return sresult
    End Function

    Private Sub btnExtraer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtraer.Click
        Try
            'PASO 1: Valida los insumos
            If Me.cboregla.SelectedIndex < 0 Then
                MsgBox("Es necesario que seleccione una regla de conversión", MsgBoxStyle.Information, "ATL Tools Suit")
                Exit Sub
            End If

            'PASO 2: Si se trata de un origen desde una fuente de datos
            Dim ofrm As frmListEntidades
            ofrm = New frmListEntidades
            ofrm.WindowState = FormWindowState.Normal
            ofrm.sfuente = outil.Toma_Token(1, Me.cbofuentedatos.SelectedItem, "-")
            ofrm.oconexion = omdipa.conexion
            ofrm.ShowDialog()
            If ofrm.sentidades.Equals("CANCEL") Then Exit Sub
            Call procesa_fte_to_grid(outil.Toma_Token(1, Me.cbofuentedatos.SelectedItem, "-"), ofrm.sentidades)
        Catch ex As HANYException
            Me.Cursor = Cursors.Default
            ex.add("MyGENARO.frmgenerarhibernate.btnExtraer_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            Me.Cursor = Cursors.Default
            outil.ShowException(New HANYException("MyGENARO.frmgenerarhibernate.btnExtraer_Click()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub picdirdao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picdirdao.Click
        If Me.txtdirectory.Text.Trim.Equals("") Then
            MsgBox("Es necesario seleccionar un directorio raiz donde escribir los componentes", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        FolderBrowserDialog.SelectedPath = Me.txtdirectory.Text
        If (FolderBrowserDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim sdir As String
            sdir = FolderBrowserDialog.SelectedPath
            If sdir.Equals(Me.txtdirectory.Text) Then
                Me.txtdirdao.Text = ""
                Exit Sub
            End If
            Me.txtdirdao.Text = sdir.Replace(Me.txtdirectory.Text, "...")
        End If
    End Sub

    Private Sub picdirmap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picdirmap.Click
        If Me.txtdirectory.Text.Trim.Equals("") Then
            MsgBox("Es necesario seleccionar un directorio raiz donde escribir los componentes", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        FolderBrowserDialog.SelectedPath = Me.txtdirectory.Text
        If (FolderBrowserDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim sdir As String
            sdir = FolderBrowserDialog.SelectedPath
            If sdir.Equals(Me.txtdirectory.Text) Then
                Me.txtdirdao.Text = ""
                Exit Sub
            End If
            Me.txtdirmap.Text = sdir.Replace(Me.txtdirectory.Text, "...")
        End If
    End Sub
End Class
