<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFrontWizCGI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFrontWizCGI))
        Me.lstdebug = New System.Windows.Forms.ListBox()
        Me.btniniciar = New System.Windows.Forms.Button()
        Me.prbarmado = New System.Windows.Forms.ProgressBar()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.grbpaso5 = New System.Windows.Forms.GroupBox()
        Me.grbpaso4 = New System.Windows.Forms.GroupBox()
        Me.btnexaminar = New System.Windows.Forms.Button()
        Me.txtdirectory = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnsiguiente = New System.Windows.Forms.Button()
        Me.cboproyecto = New System.Windows.Forms.ComboBox()
        Me.btnanterior = New System.Windows.Forms.Button()
        Me.grbpaso1 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.btnterminar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.grbpaso3 = New System.Windows.Forms.GroupBox()
        Me.chklibs = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gridpantalla = New System.Windows.Forms.DataGridView()
        Me.btncargapantallas = New System.Windows.Forms.Button()
        Me.txtpantallas = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.grbpaso2 = New System.Windows.Forms.GroupBox()
        Me.cbosincronia = New System.Windows.Forms.ComboBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbpaso5.SuspendLayout()
        Me.grbpaso4.SuspendLayout()
        Me.grbpaso1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grbpaso3.SuspendLayout()
        CType(Me.gridpantalla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbpaso2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstdebug
        '
        Me.lstdebug.FormattingEnabled = True
        Me.lstdebug.Location = New System.Drawing.Point(6, 104)
        Me.lstdebug.Name = "lstdebug"
        Me.lstdebug.Size = New System.Drawing.Size(369, 134)
        Me.lstdebug.TabIndex = 4
        '
        'btniniciar
        '
        Me.btniniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btniniciar.Location = New System.Drawing.Point(244, 45)
        Me.btniniciar.Name = "btniniciar"
        Me.btniniciar.Size = New System.Drawing.Size(131, 24)
        Me.btniniciar.TabIndex = 3
        Me.btniniciar.Text = "Iniciar generación"
        Me.btniniciar.UseVisualStyleBackColor = True
        '
        'prbarmado
        '
        Me.prbarmado.Location = New System.Drawing.Point(6, 75)
        Me.prbarmado.Name = "prbarmado"
        Me.prbarmado.Size = New System.Drawing.Size(369, 23)
        Me.prbarmado.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(6, 19)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(369, 20)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = "A continuación se van a generar los programas necesarios en CGI "
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(3, 12)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(190, 121)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 44
        Me.LogoPictureBox.TabStop = False
        '
        'grbpaso5
        '
        Me.grbpaso5.Controls.Add(Me.lstdebug)
        Me.grbpaso5.Controls.Add(Me.btniniciar)
        Me.grbpaso5.Controls.Add(Me.prbarmado)
        Me.grbpaso5.Controls.Add(Me.TextBox2)
        Me.grbpaso5.Location = New System.Drawing.Point(194, 9)
        Me.grbpaso5.Name = "grbpaso5"
        Me.grbpaso5.Size = New System.Drawing.Size(393, 253)
        Me.grbpaso5.TabIndex = 48
        Me.grbpaso5.TabStop = False
        Me.grbpaso5.Text = " PASO 5: Generación de los programas "
        Me.grbpaso5.Visible = False
        '
        'grbpaso4
        '
        Me.grbpaso4.Controls.Add(Me.btnexaminar)
        Me.grbpaso4.Controls.Add(Me.txtdirectory)
        Me.grbpaso4.Controls.Add(Me.TextBox1)
        Me.grbpaso4.Location = New System.Drawing.Point(200, 12)
        Me.grbpaso4.Name = "grbpaso4"
        Me.grbpaso4.Size = New System.Drawing.Size(387, 244)
        Me.grbpaso4.TabIndex = 47
        Me.grbpaso4.TabStop = False
        Me.grbpaso4.Text = " PASO 4:  Directorio destino donde grabar programas "
        Me.grbpaso4.Visible = False
        '
        'btnexaminar
        '
        Me.btnexaminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnexaminar.Location = New System.Drawing.Point(6, 69)
        Me.btnexaminar.Name = "btnexaminar"
        Me.btnexaminar.Size = New System.Drawing.Size(113, 23)
        Me.btnexaminar.TabIndex = 4
        Me.btnexaminar.Text = "Examinar..."
        Me.btnexaminar.UseVisualStyleBackColor = True
        '
        'txtdirectory
        '
        Me.txtdirectory.Location = New System.Drawing.Point(6, 40)
        Me.txtdirectory.Name = "txtdirectory"
        Me.txtdirectory.ReadOnly = True
        Me.txtdirectory.Size = New System.Drawing.Size(363, 20)
        Me.txtdirectory.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(6, 19)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(363, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Seleccione el directorio donde se van a escribir los programas del Front-End."
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsiguiente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnsiguiente.Location = New System.Drawing.Point(104, 6)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(81, 23)
        Me.btnsiguiente.TabIndex = 2
        Me.btnsiguiente.Text = "Siguiente >"
        '
        'cboproyecto
        '
        Me.cboproyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboproyecto.FormattingEnabled = True
        Me.cboproyecto.Location = New System.Drawing.Point(79, 39)
        Me.cboproyecto.Name = "cboproyecto"
        Me.cboproyecto.Size = New System.Drawing.Size(290, 21)
        Me.cboproyecto.TabIndex = 9
        '
        'btnanterior
        '
        Me.btnanterior.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnanterior.Location = New System.Drawing.Point(11, 6)
        Me.btnanterior.Name = "btnanterior"
        Me.btnanterior.Size = New System.Drawing.Size(67, 23)
        Me.btnanterior.TabIndex = 0
        Me.btnanterior.Text = "< Regresar"
        '
        'grbpaso1
        '
        Me.grbpaso1.Controls.Add(Me.cboproyecto)
        Me.grbpaso1.Controls.Add(Me.TextBox4)
        Me.grbpaso1.Location = New System.Drawing.Point(199, 21)
        Me.grbpaso1.Name = "grbpaso1"
        Me.grbpaso1.Size = New System.Drawing.Size(393, 244)
        Me.grbpaso1.TabIndex = 45
        Me.grbpaso1.TabStop = False
        Me.grbpaso1.Text = " PASO 1: Seleccione el nombre del proyecto"
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Location = New System.Drawing.Point(17, 42)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(56, 16)
        Me.TextBox4.TabIndex = 8
        Me.TextBox4.Text = "Proyecto : "
        '
        'btnterminar
        '
        Me.btnterminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnterminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnterminar.Location = New System.Drawing.Point(255, 6)
        Me.btnterminar.Name = "btnterminar"
        Me.btnterminar.Size = New System.Drawing.Size(81, 23)
        Me.btnterminar.TabIndex = 1
        Me.btnterminar.Text = "Terminar"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.19231!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.80769!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnsiguiente, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnanterior, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnterminar, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(199, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(393, 35)
        Me.TableLayoutPanel1.TabIndex = 43
        '
        'grbpaso3
        '
        Me.grbpaso3.Controls.Add(Me.chklibs)
        Me.grbpaso3.Controls.Add(Me.Label1)
        Me.grbpaso3.Controls.Add(Me.gridpantalla)
        Me.grbpaso3.Controls.Add(Me.btncargapantallas)
        Me.grbpaso3.Controls.Add(Me.txtpantallas)
        Me.grbpaso3.Location = New System.Drawing.Point(199, 12)
        Me.grbpaso3.Name = "grbpaso3"
        Me.grbpaso3.Size = New System.Drawing.Size(393, 253)
        Me.grbpaso3.TabIndex = 46
        Me.grbpaso3.TabStop = False
        Me.grbpaso3.Text = " PASO 3: Selección de las pantallas a generar "
        Me.grbpaso3.Visible = False
        '
        'chklibs
        '
        Me.chklibs.AutoSize = True
        Me.chklibs.Location = New System.Drawing.Point(7, 227)
        Me.chklibs.Name = "chklibs"
        Me.chklibs.Size = New System.Drawing.Size(106, 17)
        Me.chklibs.TabIndex = 35
        Me.chklibs.Text = "Generar Librerias"
        Me.chklibs.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 26)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Si alguna pantalla del proyecto no está sincronizada, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "no se puede generar el si" & _
            "stema."
        '
        'gridpantalla
        '
        Me.gridpantalla.AllowUserToAddRows = False
        Me.gridpantalla.AllowUserToDeleteRows = False
        Me.gridpantalla.AllowUserToResizeRows = False
        Me.gridpantalla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridpantalla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridpantalla.Location = New System.Drawing.Point(7, 57)
        Me.gridpantalla.Name = "gridpantalla"
        Me.gridpantalla.RowHeadersVisible = False
        Me.gridpantalla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridpantalla.Size = New System.Drawing.Size(374, 164)
        Me.gridpantalla.TabIndex = 4
        '
        'btncargapantallas
        '
        Me.btncargapantallas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncargapantallas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncargapantallas.Location = New System.Drawing.Point(7, 22)
        Me.btncargapantallas.Name = "btncargapantallas"
        Me.btncargapantallas.Size = New System.Drawing.Size(94, 29)
        Me.btncargapantallas.TabIndex = 32
        Me.btncargapantallas.Text = "Cargar Pantallas"
        Me.btncargapantallas.UseVisualStyleBackColor = True
        '
        'txtpantallas
        '
        Me.txtpantallas.Location = New System.Drawing.Point(114, 224)
        Me.txtpantallas.Name = "txtpantallas"
        Me.txtpantallas.ReadOnly = True
        Me.txtpantallas.Size = New System.Drawing.Size(267, 20)
        Me.txtpantallas.TabIndex = 31
        Me.txtpantallas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grbpaso2
        '
        Me.grbpaso2.Controls.Add(Me.cbosincronia)
        Me.grbpaso2.Controls.Add(Me.TextBox5)
        Me.grbpaso2.Location = New System.Drawing.Point(199, 9)
        Me.grbpaso2.Name = "grbpaso2"
        Me.grbpaso2.Size = New System.Drawing.Size(381, 244)
        Me.grbpaso2.TabIndex = 50
        Me.grbpaso2.TabStop = False
        Me.grbpaso2.Text = " PASO 2: Seleccione la sincronización a utilizar"
        Me.grbpaso2.Visible = False
        '
        'cbosincronia
        '
        Me.cbosincronia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosincronia.FormattingEnabled = True
        Me.cbosincronia.Location = New System.Drawing.Point(6, 86)
        Me.cbosincronia.Name = "cbosincronia"
        Me.cbosincronia.Size = New System.Drawing.Size(350, 21)
        Me.cbosincronia.TabIndex = 10
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Location = New System.Drawing.Point(6, 28)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(352, 45)
        Me.TextBox5.TabIndex = 1
        Me.TextBox5.Text = "Antes de llegar hasta la generación del front-end, se deberá seleccionar alguna s" & _
            "incronización que esté registrada y  que se haya realizado contra el prototipo."
        '
        'frmFrontWizCGI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 321)
        Me.ControlBox = False
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.grbpaso3)
        Me.Controls.Add(Me.grbpaso5)
        Me.Controls.Add(Me.grbpaso4)
        Me.Controls.Add(Me.grbpaso2)
        Me.Controls.Add(Me.grbpaso1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFrontWizCGI"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "WIZARD ! todo como un CGI..."
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbpaso5.ResumeLayout(False)
        Me.grbpaso5.PerformLayout()
        Me.grbpaso4.ResumeLayout(False)
        Me.grbpaso4.PerformLayout()
        Me.grbpaso1.ResumeLayout(False)
        Me.grbpaso1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.grbpaso3.ResumeLayout(False)
        Me.grbpaso3.PerformLayout()
        CType(Me.gridpantalla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbpaso2.ResumeLayout(False)
        Me.grbpaso2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstdebug As System.Windows.Forms.ListBox
    Friend WithEvents btniniciar As System.Windows.Forms.Button
    Friend WithEvents prbarmado As System.Windows.Forms.ProgressBar
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents grbpaso5 As System.Windows.Forms.GroupBox
    Friend WithEvents grbpaso4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnexaminar As System.Windows.Forms.Button
    Friend WithEvents txtdirectory As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnsiguiente As System.Windows.Forms.Button
    Friend WithEvents cboproyecto As System.Windows.Forms.ComboBox
    Friend WithEvents btnanterior As System.Windows.Forms.Button
    Friend WithEvents grbpaso1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents btnterminar As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grbpaso3 As System.Windows.Forms.GroupBox
    Friend WithEvents btncargapantallas As System.Windows.Forms.Button
    Friend WithEvents txtpantallas As System.Windows.Forms.TextBox
    Friend WithEvents gridpantalla As System.Windows.Forms.DataGridView
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents grbpaso2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents cbosincronia As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chklibs As System.Windows.Forms.CheckBox
End Class
