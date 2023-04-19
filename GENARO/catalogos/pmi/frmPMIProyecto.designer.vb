<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPMIProyecto
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmainclave = New System.Windows.Forms.TextBox()
        Me.txtmainame = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.cboEstatus = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btngengrabar = New System.Windows.Forms.Button()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboEmpresa = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboPMP = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tafStaff = New System.Windows.Forms.TabPage()
        Me.gridstaff = New System.Windows.Forms.DataGridView()
        Me.txttotstaff = New System.Windows.Forms.TextBox()
        Me.btnstaffverdetalle = New System.Windows.Forms.Button()
        Me.btnstaffload = New System.Windows.Forms.Button()
        Me.btndelfile = New System.Windows.Forms.Button()
        Me.btnaddfile = New System.Windows.Forms.Button()
        Me.lblstaff = New System.Windows.Forms.Label()
        Me.tabSteackHolders = New System.Windows.Forms.TabPage()
        Me.gridSteackholders = New System.Windows.Forms.DataGridView()
        Me.txttotsteackholders = New System.Windows.Forms.TextBox()
        Me.btnsteackdetalle = New System.Windows.Forms.Button()
        Me.btnstackload = New System.Windows.Forms.Button()
        Me.btnsteackdel = New System.Windows.Forms.Button()
        Me.btnstackadd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabRiesgos = New System.Windows.Forms.TabPage()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tabAlcance = New System.Windows.Forms.TabPage()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tabJunta = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gridJunta = New System.Windows.Forms.DataGridView()
        Me.txtjuntas = New System.Windows.Forms.TextBox()
        Me.btnjuntaver = New System.Windows.Forms.Button()
        Me.btnjuntasload = New System.Windows.Forms.Button()
        Me.btnjuntadel = New System.Windows.Forms.Button()
        Me.btnjuntadd = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SteackholderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        Me.tafStaff.SuspendLayout()
        CType(Me.gridstaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSteackHolders.SuspendLayout()
        CType(Me.gridSteackholders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRiesgos.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAlcance.SuspendLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabJunta.SuspendLayout()
        CType(Me.gridJunta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SteackholderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave :"
        '
        'txtmainclave
        '
        Me.txtmainclave.Location = New System.Drawing.Point(60, 13)
        Me.txtmainclave.Name = "txtmainclave"
        Me.txtmainclave.ReadOnly = True
        Me.txtmainclave.Size = New System.Drawing.Size(100, 20)
        Me.txtmainclave.TabIndex = 1
        '
        'txtmainame
        '
        Me.txtmainame.Location = New System.Drawing.Point(166, 13)
        Me.txtmainame.Name = "txtmainame"
        Me.txtmainame.ReadOnly = True
        Me.txtmainame.Size = New System.Drawing.Size(400, 20)
        Me.txtmainame.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabGeneral)
        Me.TabControl1.Controls.Add(Me.tafStaff)
        Me.TabControl1.Controls.Add(Me.tabSteackHolders)
        Me.TabControl1.Controls.Add(Me.tabRiesgos)
        Me.TabControl1.Controls.Add(Me.tabAlcance)
        Me.TabControl1.Controls.Add(Me.tabJunta)
        Me.TabControl1.Location = New System.Drawing.Point(17, 58)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(648, 341)
        Me.TabControl1.TabIndex = 4
        '
        'tabGeneral
        '
        Me.tabGeneral.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabGeneral.Controls.Add(Me.cboEstatus)
        Me.tabGeneral.Controls.Add(Me.Label15)
        Me.tabGeneral.Controls.Add(Me.btngengrabar)
        Me.tabGeneral.Controls.Add(Me.txtComentario)
        Me.tabGeneral.Controls.Add(Me.Label10)
        Me.tabGeneral.Controls.Add(Me.txtIva)
        Me.tabGeneral.Controls.Add(Me.Label9)
        Me.tabGeneral.Controls.Add(Me.txtPrecio)
        Me.tabGeneral.Controls.Add(Me.Label8)
        Me.tabGeneral.Controls.Add(Me.cboEmpresa)
        Me.tabGeneral.Controls.Add(Me.Label7)
        Me.tabGeneral.Controls.Add(Me.cboPMP)
        Me.tabGeneral.Controls.Add(Me.Label6)
        Me.tabGeneral.Controls.Add(Me.cboCliente)
        Me.tabGeneral.Controls.Add(Me.Label5)
        Me.tabGeneral.Controls.Add(Me.txtclave)
        Me.tabGeneral.Controls.Add(Me.Label4)
        Me.tabGeneral.Controls.Add(Me.txtnombre)
        Me.tabGeneral.Controls.Add(Me.Label3)
        Me.tabGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGeneral.Size = New System.Drawing.Size(640, 315)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "General"
        Me.tabGeneral.UseVisualStyleBackColor = True
        '
        'cboEstatus
        '
        Me.cboEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstatus.FormattingEnabled = True
        Me.cboEstatus.Location = New System.Drawing.Point(411, 17)
        Me.cboEstatus.Name = "cboEstatus"
        Me.cboEstatus.Size = New System.Drawing.Size(199, 21)
        Me.cboEstatus.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(340, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Estatus :"
        '
        'btngengrabar
        '
        Me.btngengrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btngengrabar.Location = New System.Drawing.Point(535, 272)
        Me.btngengrabar.Name = "btngengrabar"
        Me.btngengrabar.Size = New System.Drawing.Size(75, 23)
        Me.btngengrabar.TabIndex = 19
        Me.btngengrabar.Text = "Grabar"
        Me.btngengrabar.UseVisualStyleBackColor = True
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(343, 115)
        Me.txtComentario.MaxLength = 1000
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentario.Size = New System.Drawing.Size(267, 134)
        Me.txtComentario.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(340, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Comentarios :"
        '
        'txtIva
        '
        Me.txtIva.Location = New System.Drawing.Point(79, 221)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(127, 20)
        Me.txtIva.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(12, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "IVA :"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(79, 185)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(127, 20)
        Me.txtPrecio.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(12, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Precio :"
        '
        'cboEmpresa
        '
        Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(79, 148)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(175, 21)
        Me.cboEmpresa.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(12, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Empresa :"
        '
        'cboPMP
        '
        Me.cboPMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPMP.FormattingEnabled = True
        Me.cboPMP.Location = New System.Drawing.Point(79, 115)
        Me.cboPMP.Name = "cboPMP"
        Me.cboPMP.Size = New System.Drawing.Size(224, 21)
        Me.cboPMP.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(12, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "PMP :"
        '
        'cboCliente
        '
        Me.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(79, 80)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(224, 21)
        Me.cboCliente.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Cliente :"
        '
        'txtclave
        '
        Me.txtclave.Location = New System.Drawing.Point(79, 20)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.ReadOnly = True
        Me.txtclave.Size = New System.Drawing.Size(100, 20)
        Me.txtclave.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Clave :"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(79, 46)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(433, 20)
        Me.txtnombre.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre :"
        '
        'tafStaff
        '
        Me.tafStaff.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tafStaff.Controls.Add(Me.gridstaff)
        Me.tafStaff.Controls.Add(Me.txttotstaff)
        Me.tafStaff.Controls.Add(Me.btnstaffverdetalle)
        Me.tafStaff.Controls.Add(Me.btnstaffload)
        Me.tafStaff.Controls.Add(Me.btndelfile)
        Me.tafStaff.Controls.Add(Me.btnaddfile)
        Me.tafStaff.Controls.Add(Me.lblstaff)
        Me.tafStaff.Location = New System.Drawing.Point(4, 22)
        Me.tafStaff.Name = "tafStaff"
        Me.tafStaff.Padding = New System.Windows.Forms.Padding(3)
        Me.tafStaff.Size = New System.Drawing.Size(640, 315)
        Me.tafStaff.TabIndex = 1
        Me.tafStaff.Text = "Staff"
        Me.tafStaff.UseVisualStyleBackColor = True
        '
        'gridstaff
        '
        Me.gridstaff.AllowUserToAddRows = False
        Me.gridstaff.AllowUserToDeleteRows = False
        Me.gridstaff.AllowUserToOrderColumns = True
        Me.gridstaff.AllowUserToResizeRows = False
        Me.gridstaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridstaff.Location = New System.Drawing.Point(38, 58)
        Me.gridstaff.Name = "gridstaff"
        Me.gridstaff.ReadOnly = True
        Me.gridstaff.RowHeadersVisible = False
        Me.gridstaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridstaff.Size = New System.Drawing.Size(568, 159)
        Me.gridstaff.TabIndex = 24
        '
        'txttotstaff
        '
        Me.txttotstaff.Location = New System.Drawing.Point(188, 222)
        Me.txttotstaff.Name = "txttotstaff"
        Me.txttotstaff.ReadOnly = True
        Me.txttotstaff.Size = New System.Drawing.Size(357, 20)
        Me.txttotstaff.TabIndex = 20
        Me.txttotstaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnstaffverdetalle
        '
        Me.btnstaffverdetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnstaffverdetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstaffverdetalle.Location = New System.Drawing.Point(92, 223)
        Me.btnstaffverdetalle.Name = "btnstaffverdetalle"
        Me.btnstaffverdetalle.Size = New System.Drawing.Size(89, 20)
        Me.btnstaffverdetalle.TabIndex = 19
        Me.btnstaffverdetalle.Text = "ver detalle"
        Me.btnstaffverdetalle.UseVisualStyleBackColor = True
        '
        'btnstaffload
        '
        Me.btnstaffload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnstaffload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstaffload.Location = New System.Drawing.Point(39, 223)
        Me.btnstaffload.Name = "btnstaffload"
        Me.btnstaffload.Size = New System.Drawing.Size(47, 20)
        Me.btnstaffload.TabIndex = 18
        Me.btnstaffload.Text = "load"
        Me.btnstaffload.UseVisualStyleBackColor = True
        '
        'btndelfile
        '
        Me.btndelfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndelfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelfile.Location = New System.Drawing.Point(550, 223)
        Me.btndelfile.Name = "btndelfile"
        Me.btndelfile.Size = New System.Drawing.Size(25, 20)
        Me.btndelfile.TabIndex = 17
        Me.btndelfile.Text = "-"
        Me.btndelfile.UseVisualStyleBackColor = True
        '
        'btnaddfile
        '
        Me.btnaddfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnaddfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddfile.Location = New System.Drawing.Point(581, 223)
        Me.btnaddfile.Name = "btnaddfile"
        Me.btnaddfile.Size = New System.Drawing.Size(25, 20)
        Me.btnaddfile.TabIndex = 16
        Me.btnaddfile.Text = "+"
        Me.btnaddfile.UseVisualStyleBackColor = True
        '
        'lblstaff
        '
        Me.lblstaff.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblstaff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblstaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstaff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblstaff.Location = New System.Drawing.Point(39, 32)
        Me.lblstaff.Name = "lblstaff"
        Me.lblstaff.Size = New System.Drawing.Size(567, 23)
        Me.lblstaff.TabIndex = 14
        Me.lblstaff.Text = "PERSONAS EN STAFF"
        Me.lblstaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabSteackHolders
        '
        Me.tabSteackHolders.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabSteackHolders.Controls.Add(Me.gridSteackholders)
        Me.tabSteackHolders.Controls.Add(Me.txttotsteackholders)
        Me.tabSteackHolders.Controls.Add(Me.btnsteackdetalle)
        Me.tabSteackHolders.Controls.Add(Me.btnstackload)
        Me.tabSteackHolders.Controls.Add(Me.btnsteackdel)
        Me.tabSteackHolders.Controls.Add(Me.btnstackadd)
        Me.tabSteackHolders.Controls.Add(Me.Label2)
        Me.tabSteackHolders.Location = New System.Drawing.Point(4, 22)
        Me.tabSteackHolders.Name = "tabSteackHolders"
        Me.tabSteackHolders.Size = New System.Drawing.Size(640, 315)
        Me.tabSteackHolders.TabIndex = 2
        Me.tabSteackHolders.Text = "SteackHolders"
        Me.tabSteackHolders.UseVisualStyleBackColor = True
        '
        'gridSteackholders
        '
        Me.gridSteackholders.AllowUserToAddRows = False
        Me.gridSteackholders.AllowUserToDeleteRows = False
        Me.gridSteackholders.AllowUserToOrderColumns = True
        Me.gridSteackholders.AllowUserToResizeRows = False
        Me.gridSteackholders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSteackholders.Location = New System.Drawing.Point(36, 68)
        Me.gridSteackholders.Name = "gridSteackholders"
        Me.gridSteackholders.ReadOnly = True
        Me.gridSteackholders.RowHeadersVisible = False
        Me.gridSteackholders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridSteackholders.Size = New System.Drawing.Size(568, 165)
        Me.gridSteackholders.TabIndex = 25
        '
        'txttotsteackholders
        '
        Me.txttotsteackholders.Location = New System.Drawing.Point(186, 238)
        Me.txttotsteackholders.Name = "txttotsteackholders"
        Me.txttotsteackholders.ReadOnly = True
        Me.txttotsteackholders.Size = New System.Drawing.Size(356, 20)
        Me.txttotsteackholders.TabIndex = 24
        Me.txttotsteackholders.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnsteackdetalle
        '
        Me.btnsteackdetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsteackdetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsteackdetalle.Location = New System.Drawing.Point(90, 239)
        Me.btnsteackdetalle.Name = "btnsteackdetalle"
        Me.btnsteackdetalle.Size = New System.Drawing.Size(89, 20)
        Me.btnsteackdetalle.TabIndex = 23
        Me.btnsteackdetalle.Text = "ver detalle"
        Me.btnsteackdetalle.UseVisualStyleBackColor = True
        '
        'btnstackload
        '
        Me.btnstackload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnstackload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstackload.Location = New System.Drawing.Point(37, 239)
        Me.btnstackload.Name = "btnstackload"
        Me.btnstackload.Size = New System.Drawing.Size(47, 20)
        Me.btnstackload.TabIndex = 22
        Me.btnstackload.Text = "load"
        Me.btnstackload.UseVisualStyleBackColor = True
        '
        'btnsteackdel
        '
        Me.btnsteackdel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsteackdel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsteackdel.Location = New System.Drawing.Point(548, 237)
        Me.btnsteackdel.Name = "btnsteackdel"
        Me.btnsteackdel.Size = New System.Drawing.Size(25, 20)
        Me.btnsteackdel.TabIndex = 21
        Me.btnsteackdel.Text = "-"
        Me.btnsteackdel.UseVisualStyleBackColor = True
        '
        'btnstackadd
        '
        Me.btnstackadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnstackadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstackadd.Location = New System.Drawing.Point(579, 237)
        Me.btnstackadd.Name = "btnstackadd"
        Me.btnstackadd.Size = New System.Drawing.Size(25, 20)
        Me.btnstackadd.TabIndex = 20
        Me.btnstackadd.Text = "+"
        Me.btnstackadd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(37, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(567, 23)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "PERSONAS COMO STEACKHOLDERS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabRiesgos
        '
        Me.tabRiesgos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabRiesgos.Controls.Add(Me.Button7)
        Me.tabRiesgos.Controls.Add(Me.Button8)
        Me.tabRiesgos.Controls.Add(Me.DataGridView5)
        Me.tabRiesgos.Controls.Add(Me.Label13)
        Me.tabRiesgos.Location = New System.Drawing.Point(4, 22)
        Me.tabRiesgos.Name = "tabRiesgos"
        Me.tabRiesgos.Size = New System.Drawing.Size(640, 315)
        Me.tabRiesgos.TabIndex = 5
        Me.tabRiesgos.Text = "Riesgos"
        Me.tabRiesgos.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(548, 239)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(25, 20)
        Me.Button7.TabIndex = 33
        Me.Button7.Text = "-"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(579, 239)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(25, 20)
        Me.Button8.TabIndex = 32
        Me.Button8.Text = "+"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'DataGridView5
        '
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(37, 83)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(567, 150)
        Me.DataGridView5.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(37, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(567, 23)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "RIESGOS"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabAlcance
        '
        Me.tabAlcance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabAlcance.Controls.Add(Me.Button9)
        Me.tabAlcance.Controls.Add(Me.Button10)
        Me.tabAlcance.Controls.Add(Me.DataGridView6)
        Me.tabAlcance.Controls.Add(Me.Label14)
        Me.tabAlcance.Location = New System.Drawing.Point(4, 22)
        Me.tabAlcance.Name = "tabAlcance"
        Me.tabAlcance.Size = New System.Drawing.Size(640, 315)
        Me.tabAlcance.TabIndex = 6
        Me.tabAlcance.Text = "Alcance"
        Me.tabAlcance.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(548, 239)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(25, 20)
        Me.Button9.TabIndex = 37
        Me.Button9.Text = "-"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(579, 239)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(25, 20)
        Me.Button10.TabIndex = 36
        Me.Button10.Text = "+"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'DataGridView6
        '
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Location = New System.Drawing.Point(37, 83)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.Size = New System.Drawing.Size(567, 150)
        Me.DataGridView6.TabIndex = 35
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(37, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(567, 23)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "ALCANCES"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabJunta
        '
        Me.tabJunta.Controls.Add(Me.Label11)
        Me.tabJunta.Controls.Add(Me.gridJunta)
        Me.tabJunta.Controls.Add(Me.txtjuntas)
        Me.tabJunta.Controls.Add(Me.btnjuntaver)
        Me.tabJunta.Controls.Add(Me.btnjuntasload)
        Me.tabJunta.Controls.Add(Me.btnjuntadel)
        Me.tabJunta.Controls.Add(Me.btnjuntadd)
        Me.tabJunta.Location = New System.Drawing.Point(4, 22)
        Me.tabJunta.Name = "tabJunta"
        Me.tabJunta.Size = New System.Drawing.Size(640, 315)
        Me.tabJunta.TabIndex = 7
        Me.tabJunta.Text = "Juntas"
        Me.tabJunta.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(36, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(567, 23)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "JUNTAS"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gridJunta
        '
        Me.gridJunta.AllowUserToAddRows = False
        Me.gridJunta.AllowUserToDeleteRows = False
        Me.gridJunta.AllowUserToOrderColumns = True
        Me.gridJunta.AllowUserToResizeRows = False
        Me.gridJunta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridJunta.Location = New System.Drawing.Point(36, 65)
        Me.gridJunta.Name = "gridJunta"
        Me.gridJunta.ReadOnly = True
        Me.gridJunta.RowHeadersVisible = False
        Me.gridJunta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridJunta.Size = New System.Drawing.Size(568, 159)
        Me.gridJunta.TabIndex = 30
        '
        'txtjuntas
        '
        Me.txtjuntas.Location = New System.Drawing.Point(186, 229)
        Me.txtjuntas.Name = "txtjuntas"
        Me.txtjuntas.ReadOnly = True
        Me.txtjuntas.Size = New System.Drawing.Size(357, 20)
        Me.txtjuntas.TabIndex = 29
        Me.txtjuntas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnjuntaver
        '
        Me.btnjuntaver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnjuntaver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnjuntaver.Location = New System.Drawing.Point(90, 230)
        Me.btnjuntaver.Name = "btnjuntaver"
        Me.btnjuntaver.Size = New System.Drawing.Size(89, 20)
        Me.btnjuntaver.TabIndex = 28
        Me.btnjuntaver.Text = "ver detalle"
        Me.btnjuntaver.UseVisualStyleBackColor = True
        '
        'btnjuntasload
        '
        Me.btnjuntasload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnjuntasload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnjuntasload.Location = New System.Drawing.Point(37, 230)
        Me.btnjuntasload.Name = "btnjuntasload"
        Me.btnjuntasload.Size = New System.Drawing.Size(47, 20)
        Me.btnjuntasload.TabIndex = 27
        Me.btnjuntasload.Text = "load"
        Me.btnjuntasload.UseVisualStyleBackColor = True
        '
        'btnjuntadel
        '
        Me.btnjuntadel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnjuntadel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnjuntadel.Location = New System.Drawing.Point(548, 230)
        Me.btnjuntadel.Name = "btnjuntadel"
        Me.btnjuntadel.Size = New System.Drawing.Size(25, 20)
        Me.btnjuntadel.TabIndex = 26
        Me.btnjuntadel.Text = "-"
        Me.btnjuntadel.UseVisualStyleBackColor = True
        '
        'btnjuntadd
        '
        Me.btnjuntadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnjuntadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnjuntadd.Location = New System.Drawing.Point(579, 230)
        Me.btnjuntadd.Name = "btnjuntadd"
        Me.btnjuntadd.Size = New System.Drawing.Size(25, 20)
        Me.btnjuntadd.TabIndex = 25
        Me.btnjuntadd.Text = "+"
        Me.btnjuntadd.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(578, 11)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmPMIProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 410)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtmainame)
        Me.Controls.Add(Me.txtmainclave)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPMIProyecto"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GENARO - Información de un Proyecto"
        Me.TabControl1.ResumeLayout(False)
        Me.tabGeneral.ResumeLayout(False)
        Me.tabGeneral.PerformLayout()
        Me.tafStaff.ResumeLayout(False)
        Me.tafStaff.PerformLayout()
        CType(Me.gridstaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSteackHolders.ResumeLayout(False)
        Me.tabSteackHolders.PerformLayout()
        CType(Me.gridSteackholders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRiesgos.ResumeLayout(False)
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAlcance.ResumeLayout(False)
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabJunta.ResumeLayout(False)
        Me.tabJunta.PerformLayout()
        CType(Me.gridJunta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SteackholderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmainclave As System.Windows.Forms.TextBox
    Friend WithEvents txtmainame As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tafStaff As System.Windows.Forms.TabPage
    Friend WithEvents tabSteackHolders As System.Windows.Forms.TabPage
    Friend WithEvents tabRiesgos As System.Windows.Forms.TabPage
    Friend WithEvents tabAlcance As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtclave As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboPMP As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents txtComentario As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtIva As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btngengrabar As System.Windows.Forms.Button
    Friend WithEvents lblstaff As System.Windows.Forms.Label
    Friend WithEvents btndelfile As System.Windows.Forms.Button
    Friend WithEvents btnaddfile As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents DataGridView6 As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnstaffload As System.Windows.Forms.Button
    Friend WithEvents btnstaffverdetalle As System.Windows.Forms.Button
    Friend WithEvents btnsteackdetalle As System.Windows.Forms.Button
    Friend WithEvents btnstackload As System.Windows.Forms.Button
    Friend WithEvents btnsteackdel As System.Windows.Forms.Button
    Friend WithEvents btnstackadd As System.Windows.Forms.Button
    Friend WithEvents txttotstaff As System.Windows.Forms.TextBox
    Friend WithEvents txttotsteackholders As System.Windows.Forms.TextBox
    Private WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SteackholderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cboEstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents gridstaff As System.Windows.Forms.DataGridView
    Friend WithEvents gridSteackholders As System.Windows.Forms.DataGridView
    Friend WithEvents tabJunta As System.Windows.Forms.TabPage
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents gridJunta As System.Windows.Forms.DataGridView
    Friend WithEvents txtjuntas As System.Windows.Forms.TextBox
    Friend WithEvents btnjuntaver As System.Windows.Forms.Button
    Friend WithEvents btnjuntasload As System.Windows.Forms.Button
    Friend WithEvents btnjuntadel As System.Windows.Forms.Button
    Friend WithEvents btnjuntadd As System.Windows.Forms.Button

End Class
