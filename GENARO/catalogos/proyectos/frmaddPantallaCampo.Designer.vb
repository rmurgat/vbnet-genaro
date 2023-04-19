<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaddPantallaCampo
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
        Me.cmdgrabar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtcomentario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtlongitud = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtcdcampo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnbpantalla = New System.Windows.Forms.TextBox()
        Me.txtcdpantalla = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnbproyecto = New System.Windows.Forms.TextBox()
        Me.txtcdproyecto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbotipo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdecimales = New System.Windows.Forms.TextBox()
        Me.radoutput = New System.Windows.Forms.RadioButton()
        Me.radinput = New System.Windows.Forms.RadioButton()
        Me.cboarreglo = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdgrabar
        '
        Me.cmdgrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdgrabar.Location = New System.Drawing.Point(475, 34)
        Me.cmdgrabar.Name = "cmdgrabar"
        Me.cmdgrabar.Size = New System.Drawing.Size(87, 23)
        Me.cmdgrabar.TabIndex = 49
        Me.cmdgrabar.Text = "Grabar"
        Me.cmdgrabar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(475, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 23)
        Me.btnSalir.TabIndex = 48
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtcomentario
        '
        Me.txtcomentario.Location = New System.Drawing.Point(81, 174)
        Me.txtcomentario.MaxLength = 1000
        Me.txtcomentario.Multiline = True
        Me.txtcomentario.Name = "txtcomentario"
        Me.txtcomentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtcomentario.Size = New System.Drawing.Size(437, 124)
        Me.txtcomentario.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Comentario :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Longitud :"
        '
        'txtlongitud
        '
        Me.txtlongitud.Location = New System.Drawing.Point(81, 148)
        Me.txtlongitud.MaxLength = 20
        Me.txtlongitud.Name = "txtlongitud"
        Me.txtlongitud.Size = New System.Drawing.Size(73, 20)
        Me.txtlongitud.TabIndex = 42
        Me.txtlongitud.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Nombre :"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(81, 89)
        Me.txtNombre.MaxLength = 60
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(437, 20)
        Me.txtNombre.TabIndex = 40
        '
        'txtcdcampo
        '
        Me.txtcdcampo.Location = New System.Drawing.Point(81, 63)
        Me.txtcdcampo.Name = "txtcdcampo"
        Me.txtcdcampo.ReadOnly = True
        Me.txtcdcampo.Size = New System.Drawing.Size(73, 20)
        Me.txtcdcampo.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Campo :"
        '
        'txtnbpantalla
        '
        Me.txtnbpantalla.Location = New System.Drawing.Point(160, 36)
        Me.txtnbpantalla.Name = "txtnbpantalla"
        Me.txtnbpantalla.ReadOnly = True
        Me.txtnbpantalla.Size = New System.Drawing.Size(298, 20)
        Me.txtnbpantalla.TabIndex = 37
        '
        'txtcdpantalla
        '
        Me.txtcdpantalla.Location = New System.Drawing.Point(81, 36)
        Me.txtcdpantalla.Name = "txtcdpantalla"
        Me.txtcdpantalla.ReadOnly = True
        Me.txtcdpantalla.Size = New System.Drawing.Size(73, 20)
        Me.txtcdpantalla.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Pantalla :"
        '
        'txtnbproyecto
        '
        Me.txtnbproyecto.Location = New System.Drawing.Point(160, 6)
        Me.txtnbproyecto.Name = "txtnbproyecto"
        Me.txtnbproyecto.ReadOnly = True
        Me.txtnbproyecto.Size = New System.Drawing.Size(298, 20)
        Me.txtnbproyecto.TabIndex = 34
        '
        'txtcdproyecto
        '
        Me.txtcdproyecto.Location = New System.Drawing.Point(81, 6)
        Me.txtcdproyecto.Name = "txtcdproyecto"
        Me.txtcdproyecto.ReadOnly = True
        Me.txtcdproyecto.Size = New System.Drawing.Size(73, 20)
        Me.txtcdproyecto.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Proyecto :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Tipo :"
        '
        'cbotipo
        '
        Me.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Location = New System.Drawing.Point(81, 116)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(232, 21)
        Me.cbotipo.TabIndex = 51
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(171, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Decimales :"
        '
        'txtdecimales
        '
        Me.txtdecimales.Location = New System.Drawing.Point(240, 148)
        Me.txtdecimales.MaxLength = 20
        Me.txtdecimales.Name = "txtdecimales"
        Me.txtdecimales.Size = New System.Drawing.Size(73, 20)
        Me.txtdecimales.TabIndex = 52
        Me.txtdecimales.Text = "0"
        '
        'radoutput
        '
        Me.radoutput.AutoSize = True
        Me.radoutput.Location = New System.Drawing.Point(441, 137)
        Me.radoutput.Name = "radoutput"
        Me.radoutput.Size = New System.Drawing.Size(63, 17)
        Me.radoutput.TabIndex = 68
        Me.radoutput.Text = "SALIDA"
        Me.radoutput.UseVisualStyleBackColor = True
        '
        'radinput
        '
        Me.radinput.AutoSize = True
        Me.radinput.Checked = True
        Me.radinput.Location = New System.Drawing.Point(441, 117)
        Me.radinput.Name = "radinput"
        Me.radinput.Size = New System.Drawing.Size(77, 17)
        Me.radinput.TabIndex = 67
        Me.radinput.TabStop = True
        Me.radinput.Text = "ENTRADA"
        Me.radinput.UseVisualStyleBackColor = True
        '
        'cboarreglo
        '
        Me.cboarreglo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboarreglo.FormattingEnabled = True
        Me.cboarreglo.Location = New System.Drawing.Point(81, 308)
        Me.cboarreglo.Name = "cboarreglo"
        Me.cboarreglo.Size = New System.Drawing.Size(233, 21)
        Me.cboarreglo.TabIndex = 70
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(17, 311)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 13)
        Me.Label21.TabIndex = 69
        Me.Label21.Text = "Arreglo :"
        '
        'frmaddPantallaCampo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 337)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboarreglo)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.radoutput)
        Me.Controls.Add(Me.radinput)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtdecimales)
        Me.Controls.Add(Me.cbotipo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdgrabar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtcomentario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtlongitud)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtcdcampo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnbpantalla)
        Me.Controls.Add(Me.txtcdpantalla)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnbproyecto)
        Me.Controls.Add(Me.txtcdproyecto)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmaddPantallaCampo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Alta de un nuevo campo de la pantalla"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdgrabar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtcomentario As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtlongitud As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtcdcampo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnbpantalla As System.Windows.Forms.TextBox
    Friend WithEvents txtcdpantalla As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnbproyecto As System.Windows.Forms.TextBox
    Friend WithEvents txtcdproyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbotipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtdecimales As System.Windows.Forms.TextBox
    Friend WithEvents radoutput As System.Windows.Forms.RadioButton
    Friend WithEvents radinput As System.Windows.Forms.RadioButton
    Friend WithEvents cboarreglo As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
End Class
