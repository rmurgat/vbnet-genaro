<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDBwizLoadReference
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDBwizLoadReference))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnsiguiente = New System.Windows.Forms.Button()
        Me.btnanterior = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.grbpaso1 = New System.Windows.Forms.GroupBox()
        Me.btnfuente = New System.Windows.Forms.Button()
        Me.cboftedatos = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.grbpaso3 = New System.Windows.Forms.GroupBox()
        Me.gridTablas = New System.Windows.Forms.DataGridView()
        Me.btnExtraer = New System.Windows.Forms.Button()
        Me.grbpaso2 = New System.Windows.Forms.GroupBox()
        Me.txtddl = New System.Windows.Forms.RichTextBox()
        Me.btnfile = New System.Windows.Forms.Button()
        Me.txtfile = New System.Windows.Forms.TextBox()
        Me.raddll = New System.Windows.Forms.RadioButton()
        Me.radarchivo = New System.Windows.Forms.RadioButton()
        Me.cboestilo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbpaso4 = New System.Windows.Forms.GroupBox()
        Me.chkdelref = New System.Windows.Forms.CheckBox()
        Me.lstdebug = New System.Windows.Forms.ListBox()
        Me.btngrabar = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbpaso1.SuspendLayout()
        Me.grbpaso3.SuspendLayout()
        CType(Me.gridTablas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbpaso2.SuspendLayout()
        Me.grbpaso4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.19231!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.80769!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnsiguiente, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnanterior, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btncerrar, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(201, 312)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(457, 34)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsiguiente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnsiguiente.Location = New System.Drawing.Point(114, 5)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(81, 23)
        Me.btnsiguiente.TabIndex = 2
        Me.btnsiguiente.Text = "Siguiente >"
        '
        'btnanterior
        '
        Me.btnanterior.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnanterior.Location = New System.Drawing.Point(14, 5)
        Me.btnanterior.Name = "btnanterior"
        Me.btnanterior.Size = New System.Drawing.Size(67, 23)
        Me.btnanterior.TabIndex = 0
        Me.btnanterior.Text = "< Regresar"
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncerrar.Location = New System.Drawing.Point(294, 5)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(81, 23)
        Me.btncerrar.TabIndex = 1
        Me.btncerrar.Text = "Cerrar"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(3, 12)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(181, 121)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 14
        Me.LogoPictureBox.TabStop = False
        '
        'grbpaso1
        '
        Me.grbpaso1.Controls.Add(Me.btnfuente)
        Me.grbpaso1.Controls.Add(Me.cboftedatos)
        Me.grbpaso1.Controls.Add(Me.TextBox3)
        Me.grbpaso1.Location = New System.Drawing.Point(196, 12)
        Me.grbpaso1.Name = "grbpaso1"
        Me.grbpaso1.Size = New System.Drawing.Size(467, 291)
        Me.grbpaso1.TabIndex = 18
        Me.grbpaso1.TabStop = False
        Me.grbpaso1.Text = " PASO 1: Seleccione el nombre de la fuente de datos"
        '
        'btnfuente
        '
        Me.btnfuente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfuente.Location = New System.Drawing.Point(347, 91)
        Me.btnfuente.Name = "btnfuente"
        Me.btnfuente.Size = New System.Drawing.Size(103, 20)
        Me.btnfuente.TabIndex = 12
        Me.btnfuente.Text = "Ver Fuente..."
        Me.btnfuente.UseVisualStyleBackColor = True
        '
        'cboftedatos
        '
        Me.cboftedatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboftedatos.FormattingEnabled = True
        Me.cboftedatos.Location = New System.Drawing.Point(17, 64)
        Me.cboftedatos.Name = "cboftedatos"
        Me.cboftedatos.Size = New System.Drawing.Size(433, 21)
        Me.cboftedatos.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(17, 42)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(91, 16)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.Text = "Fuente de Datos : "
        '
        'grbpaso3
        '
        Me.grbpaso3.Controls.Add(Me.gridTablas)
        Me.grbpaso3.Controls.Add(Me.btnExtraer)
        Me.grbpaso3.Location = New System.Drawing.Point(196, 12)
        Me.grbpaso3.Name = "grbpaso3"
        Me.grbpaso3.Size = New System.Drawing.Size(467, 291)
        Me.grbpaso3.TabIndex = 26
        Me.grbpaso3.TabStop = False
        Me.grbpaso3.Text = " PASO 3: Extracción de definición de entidades"
        Me.grbpaso3.Visible = False
        '
        'gridTablas
        '
        Me.gridTablas.AllowUserToAddRows = False
        Me.gridTablas.AllowUserToDeleteRows = False
        Me.gridTablas.AllowUserToResizeColumns = False
        Me.gridTablas.AllowUserToResizeRows = False
        Me.gridTablas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridTablas.CausesValidation = False
        Me.gridTablas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.gridTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridTablas.Location = New System.Drawing.Point(19, 59)
        Me.gridTablas.MultiSelect = False
        Me.gridTablas.Name = "gridTablas"
        Me.gridTablas.ReadOnly = True
        Me.gridTablas.RowHeadersVisible = False
        Me.gridTablas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridTablas.Size = New System.Drawing.Size(442, 226)
        Me.gridTablas.TabIndex = 2
        '
        'btnExtraer
        '
        Me.btnExtraer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExtraer.Location = New System.Drawing.Point(19, 28)
        Me.btnExtraer.Name = "btnExtraer"
        Me.btnExtraer.Size = New System.Drawing.Size(85, 24)
        Me.btnExtraer.TabIndex = 1
        Me.btnExtraer.Text = "Extraer..."
        '
        'grbpaso2
        '
        Me.grbpaso2.Controls.Add(Me.txtddl)
        Me.grbpaso2.Controls.Add(Me.btnfile)
        Me.grbpaso2.Controls.Add(Me.txtfile)
        Me.grbpaso2.Controls.Add(Me.raddll)
        Me.grbpaso2.Controls.Add(Me.radarchivo)
        Me.grbpaso2.Controls.Add(Me.cboestilo)
        Me.grbpaso2.Controls.Add(Me.Label1)
        Me.grbpaso2.Location = New System.Drawing.Point(196, 12)
        Me.grbpaso2.Name = "grbpaso2"
        Me.grbpaso2.Size = New System.Drawing.Size(467, 291)
        Me.grbpaso2.TabIndex = 31
        Me.grbpaso2.TabStop = False
        Me.grbpaso2.Text = " PASO 2: Ingrese el Lenguaje de Definición de datos"
        Me.grbpaso2.Visible = False
        '
        'txtddl
        '
        Me.txtddl.Location = New System.Drawing.Point(13, 98)
        Me.txtddl.Name = "txtddl"
        Me.txtddl.Size = New System.Drawing.Size(444, 160)
        Me.txtddl.TabIndex = 9
        Me.txtddl.Text = ""
        '
        'btnfile
        '
        Me.btnfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfile.Location = New System.Drawing.Point(374, 68)
        Me.btnfile.Name = "btnfile"
        Me.btnfile.Size = New System.Drawing.Size(83, 23)
        Me.btnfile.TabIndex = 8
        Me.btnfile.Text = "Examinar..."
        Me.btnfile.UseVisualStyleBackColor = True
        '
        'txtfile
        '
        Me.txtfile.Location = New System.Drawing.Point(13, 42)
        Me.txtfile.Name = "txtfile"
        Me.txtfile.ReadOnly = True
        Me.txtfile.Size = New System.Drawing.Size(444, 20)
        Me.txtfile.TabIndex = 7
        '
        'raddll
        '
        Me.raddll.AutoSize = True
        Me.raddll.Location = New System.Drawing.Point(13, 74)
        Me.raddll.Name = "raddll"
        Me.raddll.Size = New System.Drawing.Size(126, 17)
        Me.raddll.TabIndex = 5
        Me.raddll.Text = "A partir de este Script"
        Me.raddll.UseVisualStyleBackColor = True
        '
        'radarchivo
        '
        Me.radarchivo.AutoSize = True
        Me.radarchivo.Checked = True
        Me.radarchivo.Location = New System.Drawing.Point(16, 19)
        Me.radarchivo.Name = "radarchivo"
        Me.radarchivo.Size = New System.Drawing.Size(61, 17)
        Me.radarchivo.TabIndex = 4
        Me.radarchivo.TabStop = True
        Me.radarchivo.Text = "Archivo"
        Me.radarchivo.UseVisualStyleBackColor = True
        '
        'cboestilo
        '
        Me.cboestilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboestilo.FormattingEnabled = True
        Me.cboestilo.Location = New System.Drawing.Point(127, 264)
        Me.cboestilo.Name = "cboestilo"
        Me.cboestilo.Size = New System.Drawing.Size(330, 21)
        Me.cboestilo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Estilo de la Definición : "
        '
        'grbpaso4
        '
        Me.grbpaso4.Controls.Add(Me.chkdelref)
        Me.grbpaso4.Controls.Add(Me.lstdebug)
        Me.grbpaso4.Controls.Add(Me.btngrabar)
        Me.grbpaso4.Location = New System.Drawing.Point(190, 12)
        Me.grbpaso4.Name = "grbpaso4"
        Me.grbpaso4.Size = New System.Drawing.Size(473, 291)
        Me.grbpaso4.TabIndex = 34
        Me.grbpaso4.TabStop = False
        Me.grbpaso4.Text = " PASO 4: Grabar Fuente de datos "
        Me.grbpaso4.Visible = False
        '
        'chkdelref
        '
        Me.chkdelref.AutoSize = True
        Me.chkdelref.Location = New System.Drawing.Point(232, 59)
        Me.chkdelref.Name = "chkdelref"
        Me.chkdelref.Size = New System.Drawing.Size(215, 17)
        Me.chkdelref.TabIndex = 16
        Me.chkdelref.Text = "Eliminar referencias de tablas implicadas"
        Me.chkdelref.UseVisualStyleBackColor = True
        '
        'lstdebug
        '
        Me.lstdebug.FormattingEnabled = True
        Me.lstdebug.Location = New System.Drawing.Point(19, 76)
        Me.lstdebug.Name = "lstdebug"
        Me.lstdebug.Size = New System.Drawing.Size(428, 199)
        Me.lstdebug.TabIndex = 15
        '
        'btngrabar
        '
        Me.btngrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btngrabar.Location = New System.Drawing.Point(19, 28)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(157, 24)
        Me.btngrabar.TabIndex = 1
        Me.btngrabar.Text = "Grabar Referencias ..."
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'frmDBwizLoadReference
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 358)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.grbpaso3)
        Me.Controls.Add(Me.grbpaso1)
        Me.Controls.Add(Me.grbpaso4)
        Me.Controls.Add(Me.grbpaso2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDBwizLoadReference"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "WIZARD ! para carga de Referencias desde Lenguaje de Definición de Datos..."
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbpaso1.ResumeLayout(False)
        Me.grbpaso1.PerformLayout()
        Me.grbpaso3.ResumeLayout(False)
        CType(Me.gridTablas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbpaso2.ResumeLayout(False)
        Me.grbpaso2.PerformLayout()
        Me.grbpaso4.ResumeLayout(False)
        Me.grbpaso4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnsiguiente As System.Windows.Forms.Button
    Friend WithEvents btnanterior As System.Windows.Forms.Button
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents grbpaso1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboftedatos As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents grbpaso3 As System.Windows.Forms.GroupBox
    Friend WithEvents gridTablas As System.Windows.Forms.DataGridView
    Friend WithEvents btnExtraer As System.Windows.Forms.Button
    Friend WithEvents grbpaso2 As System.Windows.Forms.GroupBox
    Friend WithEvents grbpaso4 As System.Windows.Forms.GroupBox
    Friend WithEvents lstdebug As System.Windows.Forms.ListBox
    Friend WithEvents btngrabar As System.Windows.Forms.Button
    Friend WithEvents btnfuente As System.Windows.Forms.Button
    Friend WithEvents cboestilo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents radarchivo As System.Windows.Forms.RadioButton
    Friend WithEvents raddll As System.Windows.Forms.RadioButton
    Friend WithEvents txtfile As System.Windows.Forms.TextBox
    Friend WithEvents btnfile As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtddl As System.Windows.Forms.RichTextBox
    Friend WithEvents chkdelref As System.Windows.Forms.CheckBox
End Class
