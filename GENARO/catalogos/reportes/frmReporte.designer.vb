<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtmainame = New System.Windows.Forms.TextBox()
        Me.txtmainclave = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.cmdgrabar = New System.Windows.Forms.Button()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtobjetivo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnimagen = New System.Windows.Forms.Button()
        Me.txtimagen = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboprogramador = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboanalista = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbostconstruc = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbostanalisis = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabCriterios = New System.Windows.Forms.TabPage()
        Me.txttotbotones = New System.Windows.Forms.TextBox()
        Me.btnbotdetalle = New System.Windows.Forms.Button()
        Me.btnbotload = New System.Windows.Forms.Button()
        Me.btnbotdel = New System.Windows.Forms.Button()
        Me.btnbotadd = New System.Windows.Forms.Button()
        Me.gridBotones = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tabCampos = New System.Windows.Forms.TabPage()
        Me.botarrdetalle = New System.Windows.Forms.Button()
        Me.btncamarrdel = New System.Windows.Forms.Button()
        Me.btncamarradd = New System.Windows.Forms.Button()
        Me.gridarreglos = New System.Windows.Forms.DataGridView()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txttotcampos = New System.Windows.Forms.TextBox()
        Me.botcamdetalle = New System.Windows.Forms.Button()
        Me.btncamload = New System.Windows.Forms.Button()
        Me.btncamdel = New System.Windows.Forms.Button()
        Me.btncamadd = New System.Windows.Forms.Button()
        Me.gridcampos = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tabImagen = New System.Windows.Forms.TabPage()
        Me.btnimagemax = New System.Windows.Forms.Button()
        Me.btnstaffload = New System.Windows.Forms.Button()
        Me.picpreview = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtnbproyecto = New System.Windows.Forms.TextBox()
        Me.txtcdproyecto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        Me.tabCriterios.SuspendLayout()
        CType(Me.gridBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCampos.SuspendLayout()
        CType(Me.gridarreglos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridcampos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabImagen.SuspendLayout()
        CType(Me.picpreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtmainame
        '
        Me.txtmainame.Location = New System.Drawing.Point(197, 37)
        Me.txtmainame.Name = "txtmainame"
        Me.txtmainame.ReadOnly = True
        Me.txtmainame.Size = New System.Drawing.Size(377, 20)
        Me.txtmainame.TabIndex = 21
        '
        'txtmainclave
        '
        Me.txtmainclave.Location = New System.Drawing.Point(91, 37)
        Me.txtmainclave.Name = "txtmainclave"
        Me.txtmainclave.ReadOnly = True
        Me.txtmainclave.Size = New System.Drawing.Size(100, 20)
        Me.txtmainclave.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Reporte :"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabGeneral)
        Me.TabControl1.Controls.Add(Me.tabCriterios)
        Me.TabControl1.Controls.Add(Me.tabCampos)
        Me.TabControl1.Controls.Add(Me.tabImagen)
        Me.TabControl1.Location = New System.Drawing.Point(25, 79)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(648, 343)
        Me.TabControl1.TabIndex = 18
        '
        'tabGeneral
        '
        Me.tabGeneral.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabGeneral.Controls.Add(Me.cmdgrabar)
        Me.tabGeneral.Controls.Add(Me.txtComentario)
        Me.tabGeneral.Controls.Add(Me.Label13)
        Me.tabGeneral.Controls.Add(Me.txtobjetivo)
        Me.tabGeneral.Controls.Add(Me.Label12)
        Me.tabGeneral.Controls.Add(Me.btnimagen)
        Me.tabGeneral.Controls.Add(Me.txtimagen)
        Me.tabGeneral.Controls.Add(Me.Label11)
        Me.tabGeneral.Controls.Add(Me.txtcodigo)
        Me.tabGeneral.Controls.Add(Me.Label9)
        Me.tabGeneral.Controls.Add(Me.cboprogramador)
        Me.tabGeneral.Controls.Add(Me.Label8)
        Me.tabGeneral.Controls.Add(Me.cboanalista)
        Me.tabGeneral.Controls.Add(Me.Label7)
        Me.tabGeneral.Controls.Add(Me.cbostconstruc)
        Me.tabGeneral.Controls.Add(Me.Label6)
        Me.tabGeneral.Controls.Add(Me.cbostanalisis)
        Me.tabGeneral.Controls.Add(Me.Label5)
        Me.tabGeneral.Controls.Add(Me.txtnombre)
        Me.tabGeneral.Controls.Add(Me.Label3)
        Me.tabGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGeneral.Size = New System.Drawing.Size(640, 317)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "General"
        '
        'cmdgrabar
        '
        Me.cmdgrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdgrabar.Location = New System.Drawing.Point(552, 12)
        Me.cmdgrabar.Name = "cmdgrabar"
        Me.cmdgrabar.Size = New System.Drawing.Size(75, 23)
        Me.cmdgrabar.TabIndex = 24
        Me.cmdgrabar.Text = "Grabar"
        Me.cmdgrabar.UseVisualStyleBackColor = True
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(387, 196)
        Me.txtComentario.MaxLength = 1000
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentario.Size = New System.Drawing.Size(240, 103)
        Me.txtComentario.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(322, 199)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Comentario : "
        '
        'txtobjetivo
        '
        Me.txtobjetivo.Location = New System.Drawing.Point(75, 196)
        Me.txtobjetivo.MaxLength = 400
        Me.txtobjetivo.Multiline = True
        Me.txtobjetivo.Name = "txtobjetivo"
        Me.txtobjetivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobjetivo.Size = New System.Drawing.Size(241, 103)
        Me.txtobjetivo.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 199)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Objetivo : "
        '
        'btnimagen
        '
        Me.btnimagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnimagen.Font = New System.Drawing.Font("Arial", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimagen.Location = New System.Drawing.Point(596, 157)
        Me.btnimagen.Name = "btnimagen"
        Me.btnimagen.Size = New System.Drawing.Size(31, 20)
        Me.btnimagen.TabIndex = 19
        Me.btnimagen.Text = "..."
        Me.btnimagen.UseVisualStyleBackColor = True
        '
        'txtimagen
        '
        Me.txtimagen.Location = New System.Drawing.Point(75, 157)
        Me.txtimagen.MaxLength = 200
        Me.txtimagen.Name = "txtimagen"
        Me.txtimagen.Size = New System.Drawing.Size(515, 20)
        Me.txtimagen.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Imagen : "
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(75, 120)
        Me.txtcodigo.MaxLength = 20
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(145, 20)
        Me.txtcodigo.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Codigo : "
        '
        'cboprogramador
        '
        Me.cboprogramador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboprogramador.FormattingEnabled = True
        Me.cboprogramador.Location = New System.Drawing.Point(75, 83)
        Me.cboprogramador.Name = "cboprogramador"
        Me.cboprogramador.Size = New System.Drawing.Size(320, 21)
        Me.cboprogramador.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Programor : "
        '
        'cboanalista
        '
        Me.cboanalista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboanalista.FormattingEnabled = True
        Me.cboanalista.Location = New System.Drawing.Point(75, 50)
        Me.cboanalista.Name = "cboanalista"
        Me.cboanalista.Size = New System.Drawing.Size(320, 21)
        Me.cboanalista.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Analista : "
        '
        'cbostconstruc
        '
        Me.cbostconstruc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbostconstruc.FormattingEnabled = True
        Me.cbostconstruc.Location = New System.Drawing.Point(496, 83)
        Me.cbostconstruc.Name = "cbostconstruc"
        Me.cbostconstruc.Size = New System.Drawing.Size(131, 21)
        Me.cbostconstruc.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(401, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Estatus Construc : "
        '
        'cbostanalisis
        '
        Me.cbostanalisis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbostanalisis.FormattingEnabled = True
        Me.cbostanalisis.Location = New System.Drawing.Point(496, 49)
        Me.cbostanalisis.Name = "cbostanalisis"
        Me.cbostanalisis.Size = New System.Drawing.Size(131, 21)
        Me.cbostanalisis.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(401, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Estatus Analisis : "
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(75, 14)
        Me.txtnombre.MaxLength = 60
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(320, 20)
        Me.txtnombre.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombre : "
        '
        'tabCriterios
        '
        Me.tabCriterios.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabCriterios.Controls.Add(Me.txttotbotones)
        Me.tabCriterios.Controls.Add(Me.btnbotdetalle)
        Me.tabCriterios.Controls.Add(Me.btnbotload)
        Me.tabCriterios.Controls.Add(Me.btnbotdel)
        Me.tabCriterios.Controls.Add(Me.btnbotadd)
        Me.tabCriterios.Controls.Add(Me.gridBotones)
        Me.tabCriterios.Controls.Add(Me.Label14)
        Me.tabCriterios.Location = New System.Drawing.Point(4, 22)
        Me.tabCriterios.Name = "tabCriterios"
        Me.tabCriterios.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCriterios.Size = New System.Drawing.Size(640, 317)
        Me.tabCriterios.TabIndex = 1
        Me.tabCriterios.Text = "Criterios"
        Me.tabCriterios.UseVisualStyleBackColor = True
        '
        'txttotbotones
        '
        Me.txttotbotones.Location = New System.Drawing.Point(186, 240)
        Me.txttotbotones.Name = "txttotbotones"
        Me.txttotbotones.ReadOnly = True
        Me.txttotbotones.Size = New System.Drawing.Size(356, 20)
        Me.txttotbotones.TabIndex = 30
        Me.txttotbotones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnbotdetalle
        '
        Me.btnbotdetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnbotdetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbotdetalle.Location = New System.Drawing.Point(90, 240)
        Me.btnbotdetalle.Name = "btnbotdetalle"
        Me.btnbotdetalle.Size = New System.Drawing.Size(89, 20)
        Me.btnbotdetalle.TabIndex = 29
        Me.btnbotdetalle.Text = "ver detalle"
        Me.btnbotdetalle.UseVisualStyleBackColor = True
        '
        'btnbotload
        '
        Me.btnbotload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnbotload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbotload.Location = New System.Drawing.Point(37, 240)
        Me.btnbotload.Name = "btnbotload"
        Me.btnbotload.Size = New System.Drawing.Size(47, 20)
        Me.btnbotload.TabIndex = 28
        Me.btnbotload.Text = "load"
        Me.btnbotload.UseVisualStyleBackColor = True
        '
        'btnbotdel
        '
        Me.btnbotdel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnbotdel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbotdel.Location = New System.Drawing.Point(548, 240)
        Me.btnbotdel.Name = "btnbotdel"
        Me.btnbotdel.Size = New System.Drawing.Size(25, 20)
        Me.btnbotdel.TabIndex = 27
        Me.btnbotdel.Text = "-"
        Me.btnbotdel.UseVisualStyleBackColor = True
        '
        'btnbotadd
        '
        Me.btnbotadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnbotadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbotadd.Location = New System.Drawing.Point(579, 240)
        Me.btnbotadd.Name = "btnbotadd"
        Me.btnbotadd.Size = New System.Drawing.Size(25, 20)
        Me.btnbotadd.TabIndex = 26
        Me.btnbotadd.Text = "+"
        Me.btnbotadd.UseVisualStyleBackColor = True
        '
        'gridBotones
        '
        Me.gridBotones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridBotones.Location = New System.Drawing.Point(37, 84)
        Me.gridBotones.MultiSelect = False
        Me.gridBotones.Name = "gridBotones"
        Me.gridBotones.ReadOnly = True
        Me.gridBotones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridBotones.Size = New System.Drawing.Size(567, 150)
        Me.gridBotones.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(37, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(567, 23)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "CRITERIOS"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabCampos
        '
        Me.tabCampos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabCampos.Controls.Add(Me.botarrdetalle)
        Me.tabCampos.Controls.Add(Me.btncamarrdel)
        Me.tabCampos.Controls.Add(Me.btncamarradd)
        Me.tabCampos.Controls.Add(Me.gridarreglos)
        Me.tabCampos.Controls.Add(Me.Label18)
        Me.tabCampos.Controls.Add(Me.txttotcampos)
        Me.tabCampos.Controls.Add(Me.botcamdetalle)
        Me.tabCampos.Controls.Add(Me.btncamload)
        Me.tabCampos.Controls.Add(Me.btncamdel)
        Me.tabCampos.Controls.Add(Me.btncamadd)
        Me.tabCampos.Controls.Add(Me.gridcampos)
        Me.tabCampos.Controls.Add(Me.Label15)
        Me.tabCampos.Location = New System.Drawing.Point(4, 22)
        Me.tabCampos.Name = "tabCampos"
        Me.tabCampos.Size = New System.Drawing.Size(640, 317)
        Me.tabCampos.TabIndex = 2
        Me.tabCampos.Text = "Campos"
        Me.tabCampos.UseVisualStyleBackColor = True
        '
        'botarrdetalle
        '
        Me.botarrdetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.botarrdetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botarrdetalle.Location = New System.Drawing.Point(310, 97)
        Me.botarrdetalle.Name = "botarrdetalle"
        Me.botarrdetalle.Size = New System.Drawing.Size(89, 20)
        Me.botarrdetalle.TabIndex = 43
        Me.botarrdetalle.Text = "ver detalle"
        Me.botarrdetalle.UseVisualStyleBackColor = True
        '
        'btncamarrdel
        '
        Me.btncamarrdel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncamarrdel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncamarrdel.Location = New System.Drawing.Point(310, 71)
        Me.btncamarrdel.Name = "btncamarrdel"
        Me.btncamarrdel.Size = New System.Drawing.Size(25, 20)
        Me.btncamarrdel.TabIndex = 42
        Me.btncamarrdel.Text = "-"
        Me.btncamarrdel.UseVisualStyleBackColor = True
        '
        'btncamarradd
        '
        Me.btncamarradd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncamarradd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncamarradd.Location = New System.Drawing.Point(310, 45)
        Me.btncamarradd.Name = "btncamarradd"
        Me.btncamarradd.Size = New System.Drawing.Size(25, 20)
        Me.btncamarradd.TabIndex = 41
        Me.btncamarradd.Text = "+"
        Me.btncamarradd.UseVisualStyleBackColor = True
        '
        'gridarreglos
        '
        Me.gridarreglos.AllowUserToAddRows = False
        Me.gridarreglos.AllowUserToDeleteRows = False
        Me.gridarreglos.AllowUserToOrderColumns = True
        Me.gridarreglos.AllowUserToResizeRows = False
        Me.gridarreglos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.gridarreglos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridarreglos.Location = New System.Drawing.Point(37, 45)
        Me.gridarreglos.Name = "gridarreglos"
        Me.gridarreglos.ReadOnly = True
        Me.gridarreglos.RowHeadersVisible = False
        Me.gridarreglos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gridarreglos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridarreglos.Size = New System.Drawing.Size(267, 72)
        Me.gridarreglos.TabIndex = 40
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(37, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(362, 23)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "ARREGLOS"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txttotcampos
        '
        Me.txttotcampos.Location = New System.Drawing.Point(132, 274)
        Me.txttotcampos.Name = "txttotcampos"
        Me.txttotcampos.ReadOnly = True
        Me.txttotcampos.Size = New System.Drawing.Size(410, 20)
        Me.txttotcampos.TabIndex = 30
        Me.txttotcampos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'botcamdetalle
        '
        Me.botcamdetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.botcamdetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botcamdetalle.Location = New System.Drawing.Point(37, 275)
        Me.botcamdetalle.Name = "botcamdetalle"
        Me.botcamdetalle.Size = New System.Drawing.Size(89, 20)
        Me.botcamdetalle.TabIndex = 29
        Me.botcamdetalle.Text = "ver detalle"
        Me.botcamdetalle.UseVisualStyleBackColor = True
        '
        'btncamload
        '
        Me.btncamload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncamload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncamload.Location = New System.Drawing.Point(455, 20)
        Me.btncamload.Name = "btncamload"
        Me.btncamload.Size = New System.Drawing.Size(149, 22)
        Me.btncamload.TabIndex = 28
        Me.btncamload.Text = "carga de arreglos y campos"
        Me.btncamload.UseVisualStyleBackColor = True
        '
        'btncamdel
        '
        Me.btncamdel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncamdel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncamdel.Location = New System.Drawing.Point(548, 273)
        Me.btncamdel.Name = "btncamdel"
        Me.btncamdel.Size = New System.Drawing.Size(25, 20)
        Me.btncamdel.TabIndex = 27
        Me.btncamdel.Text = "-"
        Me.btncamdel.UseVisualStyleBackColor = True
        '
        'btncamadd
        '
        Me.btncamadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncamadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncamadd.Location = New System.Drawing.Point(579, 273)
        Me.btncamadd.Name = "btncamadd"
        Me.btncamadd.Size = New System.Drawing.Size(25, 20)
        Me.btncamadd.TabIndex = 26
        Me.btncamadd.Text = "+"
        Me.btncamadd.UseVisualStyleBackColor = True
        '
        'gridcampos
        '
        Me.gridcampos.AllowUserToAddRows = False
        Me.gridcampos.AllowUserToDeleteRows = False
        Me.gridcampos.AllowUserToOrderColumns = True
        Me.gridcampos.AllowUserToResizeRows = False
        Me.gridcampos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridcampos.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.gridcampos.Location = New System.Drawing.Point(37, 156)
        Me.gridcampos.MultiSelect = False
        Me.gridcampos.Name = "gridcampos"
        Me.gridcampos.ReadOnly = True
        Me.gridcampos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridcampos.Size = New System.Drawing.Size(567, 113)
        Me.gridcampos.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(37, 130)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(567, 23)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "CAMPOS"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabImagen
        '
        Me.tabImagen.Controls.Add(Me.btnimagemax)
        Me.tabImagen.Controls.Add(Me.btnstaffload)
        Me.tabImagen.Controls.Add(Me.picpreview)
        Me.tabImagen.Location = New System.Drawing.Point(4, 22)
        Me.tabImagen.Name = "tabImagen"
        Me.tabImagen.Size = New System.Drawing.Size(640, 317)
        Me.tabImagen.TabIndex = 3
        Me.tabImagen.Text = "Imagen"
        Me.tabImagen.UseVisualStyleBackColor = True
        '
        'btnimagemax
        '
        Me.btnimagemax.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnimagemax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimagemax.Location = New System.Drawing.Point(590, 285)
        Me.btnimagemax.Name = "btnimagemax"
        Me.btnimagemax.Size = New System.Drawing.Size(47, 20)
        Me.btnimagemax.TabIndex = 20
        Me.btnimagemax.Text = "Max"
        Me.btnimagemax.UseVisualStyleBackColor = True
        '
        'btnstaffload
        '
        Me.btnstaffload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnstaffload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstaffload.Location = New System.Drawing.Point(3, 12)
        Me.btnstaffload.Name = "btnstaffload"
        Me.btnstaffload.Size = New System.Drawing.Size(47, 20)
        Me.btnstaffload.TabIndex = 19
        Me.btnstaffload.Text = "load"
        Me.btnstaffload.UseVisualStyleBackColor = True
        '
        'picpreview
        '
        Me.picpreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picpreview.Location = New System.Drawing.Point(56, 12)
        Me.picpreview.Name = "picpreview"
        Me.picpreview.Size = New System.Drawing.Size(528, 293)
        Me.picpreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picpreview.TabIndex = 0
        Me.picpreview.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(586, 9)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 23)
        Me.btnSalir.TabIndex = 17
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtnbproyecto
        '
        Me.txtnbproyecto.Location = New System.Drawing.Point(197, 11)
        Me.txtnbproyecto.Name = "txtnbproyecto"
        Me.txtnbproyecto.ReadOnly = True
        Me.txtnbproyecto.Size = New System.Drawing.Size(377, 20)
        Me.txtnbproyecto.TabIndex = 16
        '
        'txtcdproyecto
        '
        Me.txtcdproyecto.Location = New System.Drawing.Point(91, 11)
        Me.txtcdproyecto.Name = "txtcdproyecto"
        Me.txtcdproyecto.ReadOnly = True
        Me.txtcdproyecto.Size = New System.Drawing.Size(100, 20)
        Me.txtcdproyecto.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Proyecto :"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'frmReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 434)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtmainame)
        Me.Controls.Add(Me.txtmainclave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtnbproyecto)
        Me.Controls.Add(Me.txtcdproyecto)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReporte"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "GENARO - Detalle de un reporte"
        Me.TabControl1.ResumeLayout(False)
        Me.tabGeneral.ResumeLayout(False)
        Me.tabGeneral.PerformLayout()
        Me.tabCriterios.ResumeLayout(False)
        Me.tabCriterios.PerformLayout()
        CType(Me.gridBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCampos.ResumeLayout(False)
        Me.tabCampos.PerformLayout()
        CType(Me.gridarreglos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridcampos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabImagen.ResumeLayout(False)
        CType(Me.picpreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtmainame As System.Windows.Forms.TextBox
    Friend WithEvents txtmainclave As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabGeneral As System.Windows.Forms.TabPage
    Friend WithEvents cmdgrabar As System.Windows.Forms.Button
    Friend WithEvents txtComentario As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtobjetivo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnimagen As System.Windows.Forms.Button
    Friend WithEvents txtimagen As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboprogramador As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboanalista As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbostconstruc As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbostanalisis As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tabCriterios As System.Windows.Forms.TabPage
    Friend WithEvents txttotbotones As System.Windows.Forms.TextBox
    Friend WithEvents btnbotdetalle As System.Windows.Forms.Button
    Friend WithEvents btnbotload As System.Windows.Forms.Button
    Friend WithEvents btnbotdel As System.Windows.Forms.Button
    Friend WithEvents btnbotadd As System.Windows.Forms.Button
    Friend WithEvents gridBotones As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tabCampos As System.Windows.Forms.TabPage
    Friend WithEvents txttotcampos As System.Windows.Forms.TextBox
    Friend WithEvents botcamdetalle As System.Windows.Forms.Button
    Friend WithEvents btncamload As System.Windows.Forms.Button
    Friend WithEvents btncamdel As System.Windows.Forms.Button
    Friend WithEvents btncamadd As System.Windows.Forms.Button
    Friend WithEvents gridcampos As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tabImagen As System.Windows.Forms.TabPage
    Friend WithEvents btnimagemax As System.Windows.Forms.Button
    Friend WithEvents btnstaffload As System.Windows.Forms.Button
    Friend WithEvents picpreview As System.Windows.Forms.PictureBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtnbproyecto As System.Windows.Forms.TextBox
    Friend WithEvents txtcdproyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents botarrdetalle As System.Windows.Forms.Button
    Friend WithEvents btncamarrdel As System.Windows.Forms.Button
    Friend WithEvents btncamarradd As System.Windows.Forms.Button
    Friend WithEvents gridarreglos As System.Windows.Forms.DataGridView
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
