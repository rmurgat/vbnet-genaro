<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFrontSyncValor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFrontSyncValor))
        Me.txtobjetotipo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbovariable = New System.Windows.Forms.ComboBox()
        Me.radconstante = New System.Windows.Forms.RadioButton()
        Me.txtconstante = New System.Windows.Forms.TextBox()
        Me.radvariable = New System.Windows.Forms.RadioButton()
        Me.lblparobj = New System.Windows.Forms.Label()
        Me.picobjetopropdel = New System.Windows.Forms.PictureBox()
        Me.radobjeto = New System.Windows.Forms.RadioButton()
        Me.picobjetoprop = New System.Windows.Forms.PictureBox()
        Me.txtobjeto = New System.Windows.Forms.TextBox()
        Me.txtobjetoprop = New System.Windows.Forms.TextBox()
        Me.picobjeto = New System.Windows.Forms.PictureBox()
        Me.lblparprop = New System.Windows.Forms.Label()
        Me.picobjetodel = New System.Windows.Forms.PictureBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.radhtml = New System.Windows.Forms.RadioButton()
        Me.cbohtml = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtactual = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.picobjetopropdel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picobjetoprop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picobjeto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picobjetodel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtobjetotipo
        '
        Me.txtobjetotipo.Location = New System.Drawing.Point(343, 100)
        Me.txtobjetotipo.Name = "txtobjetotipo"
        Me.txtobjetotipo.ReadOnly = True
        Me.txtobjetotipo.Size = New System.Drawing.Size(120, 20)
        Me.txtobjetotipo.TabIndex = 129
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(308, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 128
        Me.Label11.Text = "Tipo :"
        '
        'cbovariable
        '
        Me.cbovariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovariable.Enabled = False
        Me.cbovariable.FormattingEnabled = True
        Me.cbovariable.Location = New System.Drawing.Point(105, 46)
        Me.cbovariable.Name = "cbovariable"
        Me.cbovariable.Size = New System.Drawing.Size(145, 21)
        Me.cbovariable.TabIndex = 127
        '
        'radconstante
        '
        Me.radconstante.AutoSize = True
        Me.radconstante.Checked = True
        Me.radconstante.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radconstante.Location = New System.Drawing.Point(11, 24)
        Me.radconstante.Name = "radconstante"
        Me.radconstante.Size = New System.Drawing.Size(73, 17)
        Me.radconstante.TabIndex = 115
        Me.radconstante.TabStop = True
        Me.radconstante.Text = "Constante"
        Me.radconstante.UseVisualStyleBackColor = True
        '
        'txtconstante
        '
        Me.txtconstante.Location = New System.Drawing.Point(105, 23)
        Me.txtconstante.Name = "txtconstante"
        Me.txtconstante.Size = New System.Drawing.Size(87, 20)
        Me.txtconstante.TabIndex = 116
        '
        'radvariable
        '
        Me.radvariable.AutoSize = True
        Me.radvariable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radvariable.Location = New System.Drawing.Point(11, 47)
        Me.radvariable.Name = "radvariable"
        Me.radvariable.Size = New System.Drawing.Size(63, 17)
        Me.radvariable.TabIndex = 117
        Me.radvariable.Text = "Variable"
        Me.radvariable.UseVisualStyleBackColor = True
        '
        'lblparobj
        '
        Me.lblparobj.AutoSize = True
        Me.lblparobj.Enabled = False
        Me.lblparobj.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblparobj.Location = New System.Drawing.Point(102, 102)
        Me.lblparobj.Name = "lblparobj"
        Me.lblparobj.Size = New System.Drawing.Size(44, 13)
        Me.lblparobj.TabIndex = 126
        Me.lblparobj.Text = "Objeto :"
        '
        'picobjetopropdel
        '
        Me.picobjetopropdel.Enabled = False
        Me.picobjetopropdel.Image = CType(resources.GetObject("picobjetopropdel.Image"), System.Drawing.Image)
        Me.picobjetopropdel.Location = New System.Drawing.Point(373, 131)
        Me.picobjetopropdel.Name = "picobjetopropdel"
        Me.picobjetopropdel.Size = New System.Drawing.Size(19, 20)
        Me.picobjetopropdel.TabIndex = 125
        Me.picobjetopropdel.TabStop = False
        '
        'radobjeto
        '
        Me.radobjeto.AutoSize = True
        Me.radobjeto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radobjeto.Location = New System.Drawing.Point(11, 98)
        Me.radobjeto.Name = "radobjeto"
        Me.radobjeto.Size = New System.Drawing.Size(56, 17)
        Me.radobjeto.TabIndex = 118
        Me.radobjeto.Text = "Objeto"
        Me.radobjeto.UseVisualStyleBackColor = True
        '
        'picobjetoprop
        '
        Me.picobjetoprop.Enabled = False
        Me.picobjetoprop.Image = CType(resources.GetObject("picobjetoprop.Image"), System.Drawing.Image)
        Me.picobjetoprop.Location = New System.Drawing.Point(343, 131)
        Me.picobjetoprop.Name = "picobjetoprop"
        Me.picobjetoprop.Size = New System.Drawing.Size(24, 20)
        Me.picobjetoprop.TabIndex = 124
        Me.picobjetoprop.TabStop = False
        '
        'txtobjeto
        '
        Me.txtobjeto.Location = New System.Drawing.Point(163, 100)
        Me.txtobjeto.Name = "txtobjeto"
        Me.txtobjeto.ReadOnly = True
        Me.txtobjeto.Size = New System.Drawing.Size(87, 20)
        Me.txtobjeto.TabIndex = 119
        '
        'txtobjetoprop
        '
        Me.txtobjetoprop.Location = New System.Drawing.Point(163, 131)
        Me.txtobjetoprop.Name = "txtobjetoprop"
        Me.txtobjetoprop.ReadOnly = True
        Me.txtobjetoprop.Size = New System.Drawing.Size(174, 20)
        Me.txtobjetoprop.TabIndex = 123
        '
        'picobjeto
        '
        Me.picobjeto.Enabled = False
        Me.picobjeto.Image = CType(resources.GetObject("picobjeto.Image"), System.Drawing.Image)
        Me.picobjeto.Location = New System.Drawing.Point(256, 100)
        Me.picobjeto.Name = "picobjeto"
        Me.picobjeto.Size = New System.Drawing.Size(21, 20)
        Me.picobjeto.TabIndex = 120
        Me.picobjeto.TabStop = False
        '
        'lblparprop
        '
        Me.lblparprop.AutoSize = True
        Me.lblparprop.Enabled = False
        Me.lblparprop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblparprop.Location = New System.Drawing.Point(102, 131)
        Me.lblparprop.Name = "lblparprop"
        Me.lblparprop.Size = New System.Drawing.Size(61, 13)
        Me.lblparprop.TabIndex = 122
        Me.lblparprop.Text = "Propiedad :"
        '
        'picobjetodel
        '
        Me.picobjetodel.Enabled = False
        Me.picobjetodel.Image = CType(resources.GetObject("picobjetodel.Image"), System.Drawing.Image)
        Me.picobjetodel.Location = New System.Drawing.Point(283, 100)
        Me.picobjetodel.Name = "picobjetodel"
        Me.picobjetodel.Size = New System.Drawing.Size(19, 20)
        Me.picobjetodel.TabIndex = 121
        Me.picobjetodel.TabStop = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(344, 7)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 130
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelar.Location = New System.Drawing.Point(431, 7)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 131
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'radhtml
        '
        Me.radhtml.AutoSize = True
        Me.radhtml.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radhtml.Location = New System.Drawing.Point(11, 70)
        Me.radhtml.Name = "radhtml"
        Me.radhtml.Size = New System.Drawing.Size(55, 17)
        Me.radhtml.TabIndex = 132
        Me.radhtml.Text = "HTML"
        Me.radhtml.UseVisualStyleBackColor = True
        '
        'cbohtml
        '
        Me.cbohtml.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbohtml.Enabled = False
        Me.cbohtml.FormattingEnabled = True
        Me.cbohtml.Location = New System.Drawing.Point(105, 69)
        Me.cbohtml.Name = "cbohtml"
        Me.cbohtml.Size = New System.Drawing.Size(145, 21)
        Me.cbohtml.TabIndex = 133
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "Valor Actual :"
        '
        'txtactual
        '
        Me.txtactual.Location = New System.Drawing.Point(120, 10)
        Me.txtactual.Name = "txtactual"
        Me.txtactual.ReadOnly = True
        Me.txtactual.Size = New System.Drawing.Size(214, 20)
        Me.txtactual.TabIndex = 135
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblparprop)
        Me.GroupBox1.Controls.Add(Me.picobjetodel)
        Me.GroupBox1.Controls.Add(Me.picobjeto)
        Me.GroupBox1.Controls.Add(Me.cbohtml)
        Me.GroupBox1.Controls.Add(Me.txtobjetoprop)
        Me.GroupBox1.Controls.Add(Me.radhtml)
        Me.GroupBox1.Controls.Add(Me.txtobjeto)
        Me.GroupBox1.Controls.Add(Me.picobjetoprop)
        Me.GroupBox1.Controls.Add(Me.radobjeto)
        Me.GroupBox1.Controls.Add(Me.txtobjetotipo)
        Me.GroupBox1.Controls.Add(Me.picobjetopropdel)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblparobj)
        Me.GroupBox1.Controls.Add(Me.cbovariable)
        Me.GroupBox1.Controls.Add(Me.radvariable)
        Me.GroupBox1.Controls.Add(Me.radconstante)
        Me.GroupBox1.Controls.Add(Me.txtconstante)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(491, 167)
        Me.GroupBox1.TabIndex = 136
        Me.GroupBox1.TabStop = False
        '
        'frmFrontSyncValor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 224)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtactual)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmFrontSyncValor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Asignación de Valor"
        CType(Me.picobjetopropdel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picobjetoprop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picobjeto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picobjetodel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtobjetotipo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbovariable As System.Windows.Forms.ComboBox
    Friend WithEvents radconstante As System.Windows.Forms.RadioButton
    Friend WithEvents txtconstante As System.Windows.Forms.TextBox
    Friend WithEvents radvariable As System.Windows.Forms.RadioButton
    Friend WithEvents lblparobj As System.Windows.Forms.Label
    Friend WithEvents picobjetopropdel As System.Windows.Forms.PictureBox
    Friend WithEvents radobjeto As System.Windows.Forms.RadioButton
    Friend WithEvents picobjetoprop As System.Windows.Forms.PictureBox
    Friend WithEvents txtobjeto As System.Windows.Forms.TextBox
    Friend WithEvents txtobjetoprop As System.Windows.Forms.TextBox
    Friend WithEvents picobjeto As System.Windows.Forms.PictureBox
    Friend WithEvents lblparprop As System.Windows.Forms.Label
    Friend WithEvents picobjetodel As System.Windows.Forms.PictureBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents radhtml As System.Windows.Forms.RadioButton
    Friend WithEvents cbohtml As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtactual As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
