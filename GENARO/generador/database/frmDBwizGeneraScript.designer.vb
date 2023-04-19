<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDBwizGeneraScript
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDBwizGeneraScript))
        Me.grbpaso4 = New System.Windows.Forms.GroupBox()
        Me.lstdebug = New System.Windows.Forms.ListBox()
        Me.btngenerar = New System.Windows.Forms.Button()
        Me.grbpaso2 = New System.Windows.Forms.GroupBox()
        Me.chktodas = New System.Windows.Forms.CheckBox()
        Me.btnleer = New System.Windows.Forms.Button()
        Me.gridEntidades = New System.Windows.Forms.DataGridView()
        Me.btnsiguiente = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnanterior = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.cbofuente = New System.Windows.Forms.ComboBox()
        Me.grbpaso1 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.grbpaso3 = New System.Windows.Forms.GroupBox()
        Me.chkescribir = New System.Windows.Forms.CheckBox()
        Me.chkpantalla = New System.Windows.Forms.CheckBox()
        Me.btnfile = New System.Windows.Forms.Button()
        Me.txtfile = New System.Windows.Forms.TextBox()
        Me.lblfile = New System.Windows.Forms.Label()
        Me.cboestilo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.grbpaso4.SuspendLayout()
        Me.grbpaso2.SuspendLayout()
        CType(Me.gridEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbpaso1.SuspendLayout()
        Me.grbpaso3.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbpaso4
        '
        Me.grbpaso4.Controls.Add(Me.lstdebug)
        Me.grbpaso4.Controls.Add(Me.btngenerar)
        Me.grbpaso4.Location = New System.Drawing.Point(189, 12)
        Me.grbpaso4.Name = "grbpaso4"
        Me.grbpaso4.Size = New System.Drawing.Size(371, 214)
        Me.grbpaso4.TabIndex = 32
        Me.grbpaso4.TabStop = False
        Me.grbpaso4.Text = "PASO 4: Conversión de tipos de datos"
        Me.grbpaso4.Visible = False
        '
        'lstdebug
        '
        Me.lstdebug.FormattingEnabled = True
        Me.lstdebug.Location = New System.Drawing.Point(7, 56)
        Me.lstdebug.Name = "lstdebug"
        Me.lstdebug.Size = New System.Drawing.Size(356, 147)
        Me.lstdebug.TabIndex = 9
        '
        'btngenerar
        '
        Me.btngenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btngenerar.Location = New System.Drawing.Point(7, 21)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(113, 23)
        Me.btngenerar.TabIndex = 8
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseVisualStyleBackColor = True
        '
        'grbpaso2
        '
        Me.grbpaso2.Controls.Add(Me.chktodas)
        Me.grbpaso2.Controls.Add(Me.btnleer)
        Me.grbpaso2.Controls.Add(Me.gridEntidades)
        Me.grbpaso2.Location = New System.Drawing.Point(190, 12)
        Me.grbpaso2.Name = "grbpaso2"
        Me.grbpaso2.Size = New System.Drawing.Size(372, 214)
        Me.grbpaso2.TabIndex = 31
        Me.grbpaso2.TabStop = False
        Me.grbpaso2.Text = " PASO 2: Seleccione la entidades que participan"
        Me.grbpaso2.Visible = False
        '
        'chktodas
        '
        Me.chktodas.AutoSize = True
        Me.chktodas.Location = New System.Drawing.Point(251, 27)
        Me.chktodas.Name = "chktodas"
        Me.chktodas.Size = New System.Drawing.Size(111, 17)
        Me.chktodas.TabIndex = 24
        Me.chktodas.Text = "Seleccionar todas"
        Me.chktodas.UseVisualStyleBackColor = True
        '
        'btnleer
        '
        Me.btnleer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnleer.Location = New System.Drawing.Point(9, 24)
        Me.btnleer.Name = "btnleer"
        Me.btnleer.Size = New System.Drawing.Size(118, 20)
        Me.btnleer.TabIndex = 23
        Me.btnleer.Text = "Leer Información ..."
        Me.btnleer.UseVisualStyleBackColor = True
        '
        'gridEntidades
        '
        Me.gridEntidades.AllowUserToAddRows = False
        Me.gridEntidades.AllowUserToDeleteRows = False
        Me.gridEntidades.AllowUserToResizeColumns = False
        Me.gridEntidades.AllowUserToResizeRows = False
        Me.gridEntidades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridEntidades.Location = New System.Drawing.Point(9, 50)
        Me.gridEntidades.MultiSelect = False
        Me.gridEntidades.Name = "gridEntidades"
        Me.gridEntidades.RowHeadersVisible = False
        Me.gridEntidades.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gridEntidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gridEntidades.Size = New System.Drawing.Size(354, 153)
        Me.gridEntidades.TabIndex = 21
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsiguiente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnsiguiente.Location = New System.Drawing.Point(100, 5)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(81, 23)
        Me.btnsiguiente.TabIndex = 2
        Me.btnsiguiente.Text = "Siguiente >"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.20126!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.79874!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnsiguiente, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnanterior, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btncerrar, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(189, 237)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(372, 34)
        Me.TableLayoutPanel1.TabIndex = 29
        '
        'btnanterior
        '
        Me.btnanterior.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnanterior.Location = New System.Drawing.Point(10, 5)
        Me.btnanterior.Name = "btnanterior"
        Me.btnanterior.Size = New System.Drawing.Size(76, 23)
        Me.btnanterior.TabIndex = 0
        Me.btnanterior.Text = "< Regresar"
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncerrar.Location = New System.Drawing.Point(238, 5)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(81, 23)
        Me.btncerrar.TabIndex = 1
        Me.btncerrar.Text = "Cerrar"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(170, 106)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 28
        Me.LogoPictureBox.TabStop = False
        '
        'cbofuente
        '
        Me.cbofuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofuente.FormattingEnabled = True
        Me.cbofuente.Location = New System.Drawing.Point(7, 46)
        Me.cbofuente.Name = "cbofuente"
        Me.cbofuente.Size = New System.Drawing.Size(357, 21)
        Me.cbofuente.TabIndex = 9
        '
        'grbpaso1
        '
        Me.grbpaso1.Controls.Add(Me.cbofuente)
        Me.grbpaso1.Controls.Add(Me.TextBox3)
        Me.grbpaso1.Location = New System.Drawing.Point(190, 12)
        Me.grbpaso1.Name = "grbpaso1"
        Me.grbpaso1.Size = New System.Drawing.Size(372, 214)
        Me.grbpaso1.TabIndex = 30
        Me.grbpaso1.TabStop = False
        Me.grbpaso1.Text = " PASO 1: Seleccione la fuente de datos"
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(7, 24)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(137, 16)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.Text = "Fuente de Datos : "
        '
        'grbpaso3
        '
        Me.grbpaso3.Controls.Add(Me.chkescribir)
        Me.grbpaso3.Controls.Add(Me.chkpantalla)
        Me.grbpaso3.Controls.Add(Me.btnfile)
        Me.grbpaso3.Controls.Add(Me.txtfile)
        Me.grbpaso3.Controls.Add(Me.lblfile)
        Me.grbpaso3.Controls.Add(Me.cboestilo)
        Me.grbpaso3.Controls.Add(Me.Label1)
        Me.grbpaso3.Location = New System.Drawing.Point(188, 12)
        Me.grbpaso3.Name = "grbpaso3"
        Me.grbpaso3.Size = New System.Drawing.Size(372, 214)
        Me.grbpaso3.TabIndex = 34
        Me.grbpaso3.TabStop = False
        Me.grbpaso3.Text = " PASO 3:  Archivo de Salida y Estilo de generación"
        '
        'chkescribir
        '
        Me.chkescribir.AutoSize = True
        Me.chkescribir.Location = New System.Drawing.Point(11, 112)
        Me.chkescribir.Name = "chkescribir"
        Me.chkescribir.Size = New System.Drawing.Size(159, 17)
        Me.chkescribir.TabIndex = 16
        Me.chkescribir.Text = "Escribir resultado en archivo"
        Me.chkescribir.UseVisualStyleBackColor = True
        '
        'chkpantalla
        '
        Me.chkpantalla.AutoSize = True
        Me.chkpantalla.Checked = True
        Me.chkpantalla.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkpantalla.Location = New System.Drawing.Point(11, 89)
        Me.chkpantalla.Name = "chkpantalla"
        Me.chkpantalla.Size = New System.Drawing.Size(172, 17)
        Me.chkpantalla.TabIndex = 15
        Me.chkpantalla.Text = "Presentar resultado en pantalla"
        Me.chkpantalla.UseVisualStyleBackColor = True
        '
        'btnfile
        '
        Me.btnfile.Enabled = False
        Me.btnfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfile.Location = New System.Drawing.Point(52, 180)
        Me.btnfile.Name = "btnfile"
        Me.btnfile.Size = New System.Drawing.Size(83, 23)
        Me.btnfile.TabIndex = 14
        Me.btnfile.Text = "Examinar..."
        Me.btnfile.UseVisualStyleBackColor = True
        '
        'txtfile
        '
        Me.txtfile.Enabled = False
        Me.txtfile.Location = New System.Drawing.Point(52, 154)
        Me.txtfile.Name = "txtfile"
        Me.txtfile.ReadOnly = True
        Me.txtfile.Size = New System.Drawing.Size(314, 20)
        Me.txtfile.TabIndex = 13
        '
        'lblfile
        '
        Me.lblfile.AutoSize = True
        Me.lblfile.Enabled = False
        Me.lblfile.Location = New System.Drawing.Point(49, 134)
        Me.lblfile.Name = "lblfile"
        Me.lblfile.Size = New System.Drawing.Size(96, 13)
        Me.lblfile.TabIndex = 12
        Me.lblfile.Text = "Archivo de Salida :"
        '
        'cboestilo
        '
        Me.cboestilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboestilo.FormattingEnabled = True
        Me.cboestilo.Location = New System.Drawing.Point(9, 39)
        Me.cboestilo.Name = "cboestilo"
        Me.cboestilo.Size = New System.Drawing.Size(357, 21)
        Me.cboestilo.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Estilo de Script :"
        '
        'frmDBwizGeneraScript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 283)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.grbpaso1)
        Me.Controls.Add(Me.grbpaso3)
        Me.Controls.Add(Me.grbpaso4)
        Me.Controls.Add(Me.grbpaso2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmDBwizGeneraScript"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Generación de Script a partir de la fuente de datos"
        Me.grbpaso4.ResumeLayout(False)
        Me.grbpaso2.ResumeLayout(False)
        Me.grbpaso2.PerformLayout()
        CType(Me.gridEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbpaso1.ResumeLayout(False)
        Me.grbpaso1.PerformLayout()
        Me.grbpaso3.ResumeLayout(False)
        Me.grbpaso3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbpaso4 As System.Windows.Forms.GroupBox
    Friend WithEvents lstdebug As System.Windows.Forms.ListBox
    Friend WithEvents btngenerar As System.Windows.Forms.Button
    Friend WithEvents grbpaso2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsiguiente As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnanterior As System.Windows.Forms.Button
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents cbofuente As System.Windows.Forms.ComboBox
    Friend WithEvents grbpaso1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents gridEntidades As System.Windows.Forms.DataGridView
    Friend WithEvents btnleer As System.Windows.Forms.Button
    Friend WithEvents chktodas As System.Windows.Forms.CheckBox
    Friend WithEvents grbpaso3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblfile As System.Windows.Forms.Label
    Friend WithEvents cboestilo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnfile As System.Windows.Forms.Button
    Friend WithEvents txtfile As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents chkescribir As System.Windows.Forms.CheckBox
    Friend WithEvents chkpantalla As System.Windows.Forms.CheckBox
End Class
