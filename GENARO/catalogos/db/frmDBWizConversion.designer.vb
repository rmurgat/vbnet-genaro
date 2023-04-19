<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDBWizConversion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDBWizConversion))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnsiguiente = New System.Windows.Forms.Button()
        Me.btnanterior = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.grbpaso1 = New System.Windows.Forms.GroupBox()
        Me.cboftedestino = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnfuente = New System.Windows.Forms.Button()
        Me.cbofteorigen = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.grbpaso2 = New System.Windows.Forms.GroupBox()
        Me.gridTipos = New System.Windows.Forms.DataGridView()
        Me.btncargatipos = New System.Windows.Forms.Button()
        Me.grbpaso3 = New System.Windows.Forms.GroupBox()
        Me.lstdebug = New System.Windows.Forms.ListBox()
        Me.btnconvertir = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbpaso1.SuspendLayout()
        Me.grbpaso2.SuspendLayout()
        CType(Me.gridTipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbpaso3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.20126!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.79874!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnsiguiente, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnanterior, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btncerrar, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(191, 240)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(372, 34)
        Me.TableLayoutPanel1.TabIndex = 23
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsiguiente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnsiguiente.Location = New System.Drawing.Point(106, 5)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(81, 23)
        Me.btnsiguiente.TabIndex = 2
        Me.btnsiguiente.Text = "Siguiente >"
        '
        'btnanterior
        '
        Me.btnanterior.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnanterior.Location = New System.Drawing.Point(12, 5)
        Me.btnanterior.Name = "btnanterior"
        Me.btnanterior.Size = New System.Drawing.Size(76, 23)
        Me.btnanterior.TabIndex = 0
        Me.btnanterior.Text = "< Regresar"
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncerrar.Location = New System.Drawing.Point(242, 5)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(81, 23)
        Me.btncerrar.TabIndex = 1
        Me.btncerrar.Text = "Cerrar"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(6, 12)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(178, 116)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 22
        Me.LogoPictureBox.TabStop = False
        '
        'grbpaso1
        '
        Me.grbpaso1.Controls.Add(Me.cboftedestino)
        Me.grbpaso1.Controls.Add(Me.TextBox1)
        Me.grbpaso1.Controls.Add(Me.btnfuente)
        Me.grbpaso1.Controls.Add(Me.cbofteorigen)
        Me.grbpaso1.Controls.Add(Me.TextBox3)
        Me.grbpaso1.Location = New System.Drawing.Point(191, 12)
        Me.grbpaso1.Name = "grbpaso1"
        Me.grbpaso1.Size = New System.Drawing.Size(372, 214)
        Me.grbpaso1.TabIndex = 24
        Me.grbpaso1.TabStop = False
        Me.grbpaso1.Text = " PASO 1: Seleccione la fuente de datos ORIGEN y DESTINO"
        '
        'cboftedestino
        '
        Me.cboftedestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboftedestino.FormattingEnabled = True
        Me.cboftedestino.Location = New System.Drawing.Point(11, 144)
        Me.cboftedestino.Name = "cboftedestino"
        Me.cboftedestino.Size = New System.Drawing.Size(357, 21)
        Me.cboftedestino.TabIndex = 15
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(11, 122)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(150, 16)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Text = "Fuente de Datos DESTINO : "
        '
        'btnfuente
        '
        Me.btnfuente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfuente.Location = New System.Drawing.Point(260, 72)
        Me.btnfuente.Name = "btnfuente"
        Me.btnfuente.Size = New System.Drawing.Size(103, 20)
        Me.btnfuente.TabIndex = 13
        Me.btnfuente.Text = "Ver Fuente..."
        Me.btnfuente.UseVisualStyleBackColor = True
        '
        'cbofteorigen
        '
        Me.cbofteorigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofteorigen.FormattingEnabled = True
        Me.cbofteorigen.Location = New System.Drawing.Point(7, 46)
        Me.cbofteorigen.Name = "cbofteorigen"
        Me.cbofteorigen.Size = New System.Drawing.Size(357, 21)
        Me.cbofteorigen.TabIndex = 9
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
        Me.TextBox3.Text = "Fuente de Datos ORIGEN : "
        '
        'grbpaso2
        '
        Me.grbpaso2.Controls.Add(Me.gridTipos)
        Me.grbpaso2.Controls.Add(Me.btncargatipos)
        Me.grbpaso2.Location = New System.Drawing.Point(191, 12)
        Me.grbpaso2.Name = "grbpaso2"
        Me.grbpaso2.Size = New System.Drawing.Size(372, 214)
        Me.grbpaso2.TabIndex = 25
        Me.grbpaso2.TabStop = False
        Me.grbpaso2.Text = " PASO 2: Ingrese la regla de CONVERSION"
        Me.grbpaso2.Visible = False
        '
        'gridTipos
        '
        Me.gridTipos.AllowUserToAddRows = False
        Me.gridTipos.AllowUserToDeleteRows = False
        Me.gridTipos.AllowUserToResizeRows = False
        Me.gridTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridTipos.Location = New System.Drawing.Point(7, 46)
        Me.gridTipos.Name = "gridTipos"
        Me.gridTipos.RowHeadersVisible = False
        Me.gridTipos.Size = New System.Drawing.Size(353, 150)
        Me.gridTipos.TabIndex = 14
        '
        'btncargatipos
        '
        Me.btncargatipos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncargatipos.Location = New System.Drawing.Point(6, 19)
        Me.btncargatipos.Name = "btncargatipos"
        Me.btncargatipos.Size = New System.Drawing.Size(199, 21)
        Me.btncargatipos.TabIndex = 13
        Me.btncargatipos.Text = "Carga todos los tipos a considerar..."
        Me.btncargatipos.UseVisualStyleBackColor = True
        '
        'grbpaso3
        '
        Me.grbpaso3.Controls.Add(Me.lstdebug)
        Me.grbpaso3.Controls.Add(Me.btnconvertir)
        Me.grbpaso3.Controls.Add(Me.TextBox4)
        Me.grbpaso3.Location = New System.Drawing.Point(190, 12)
        Me.grbpaso3.Name = "grbpaso3"
        Me.grbpaso3.Size = New System.Drawing.Size(371, 214)
        Me.grbpaso3.TabIndex = 27
        Me.grbpaso3.TabStop = False
        Me.grbpaso3.Text = "PASO 3: Conversión de tipos de datos"
        Me.grbpaso3.Visible = False
        '
        'lstdebug
        '
        Me.lstdebug.FormattingEnabled = True
        Me.lstdebug.Location = New System.Drawing.Point(7, 95)
        Me.lstdebug.Name = "lstdebug"
        Me.lstdebug.Size = New System.Drawing.Size(356, 108)
        Me.lstdebug.TabIndex = 9
        '
        'btnconvertir
        '
        Me.btnconvertir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnconvertir.Location = New System.Drawing.Point(7, 64)
        Me.btnconvertir.Name = "btnconvertir"
        Me.btnconvertir.Size = New System.Drawing.Size(113, 23)
        Me.btnconvertir.TabIndex = 8
        Me.btnconvertir.Text = "Convertir"
        Me.btnconvertir.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Location = New System.Drawing.Point(7, 25)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(356, 33)
        Me.TextBox4.TabIndex = 7
        Me.TextBox4.Text = "En este paso se crean las entidades en otra fuente de datos convirtiendo los dato" & _
            "s en base la regla."
        '
        'frmDBWizConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 286)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.grbpaso2)
        Me.Controls.Add(Me.grbpaso1)
        Me.Controls.Add(Me.grbpaso3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmDBWizConversion"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "WIZARD ! Para la conversión de tipo de datos"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbpaso1.ResumeLayout(False)
        Me.grbpaso1.PerformLayout()
        Me.grbpaso2.ResumeLayout(False)
        CType(Me.gridTipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbpaso3.ResumeLayout(False)
        Me.grbpaso3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnsiguiente As System.Windows.Forms.Button
    Friend WithEvents btnanterior As System.Windows.Forms.Button
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents grbpaso1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnfuente As System.Windows.Forms.Button
    Friend WithEvents cbofteorigen As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents grbpaso2 As System.Windows.Forms.GroupBox
    Friend WithEvents btncargatipos As System.Windows.Forms.Button
    Friend WithEvents gridTipos As System.Windows.Forms.DataGridView
    Friend WithEvents cboftedestino As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents grbpaso3 As System.Windows.Forms.GroupBox
    Friend WithEvents lstdebug As System.Windows.Forms.ListBox
    Friend WithEvents btnconvertir As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
End Class
