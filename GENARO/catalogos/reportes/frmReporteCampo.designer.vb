<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteCampo
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdecimales = New System.Windows.Forms.TextBox()
        Me.cbotipo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdgrabar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtcomentario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtcdcampo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnbreporte = New System.Windows.Forms.TextBox()
        Me.txtcdreporte = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnbproyecto = New System.Windows.Forms.TextBox()
        Me.txtcdproyecto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboarreglo = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(307, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Decimales :"
        '
        'txtdecimales
        '
        Me.txtdecimales.Location = New System.Drawing.Point(385, 127)
        Me.txtdecimales.MaxLength = 20
        Me.txtdecimales.Name = "txtdecimales"
        Me.txtdecimales.Size = New System.Drawing.Size(73, 20)
        Me.txtdecimales.TabIndex = 70
        '
        'cbotipo
        '
        Me.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Location = New System.Drawing.Point(81, 126)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(220, 21)
        Me.cbotipo.TabIndex = 69
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Tipo :"
        '
        'cmdgrabar
        '
        Me.cmdgrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdgrabar.Location = New System.Drawing.Point(475, 44)
        Me.cmdgrabar.Name = "cmdgrabar"
        Me.cmdgrabar.Size = New System.Drawing.Size(87, 23)
        Me.cmdgrabar.TabIndex = 67
        Me.cmdgrabar.Text = "Grabar"
        Me.cmdgrabar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(475, 14)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 23)
        Me.btnSalir.TabIndex = 66
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtcomentario
        '
        Me.txtcomentario.Location = New System.Drawing.Point(81, 181)
        Me.txtcomentario.MaxLength = 1000
        Me.txtcomentario.Multiline = True
        Me.txtcomentario.Name = "txtcomentario"
        Me.txtcomentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtcomentario.Size = New System.Drawing.Size(480, 127)
        Me.txtcomentario.TabIndex = 65
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Comentario :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Nombre :"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(81, 99)
        Me.txtNombre.MaxLength = 60
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(377, 20)
        Me.txtNombre.TabIndex = 62
        '
        'txtcdcampo
        '
        Me.txtcdcampo.Location = New System.Drawing.Point(81, 73)
        Me.txtcdcampo.Name = "txtcdcampo"
        Me.txtcdcampo.ReadOnly = True
        Me.txtcdcampo.Size = New System.Drawing.Size(73, 20)
        Me.txtcdcampo.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Campo :"
        '
        'txtnbreporte
        '
        Me.txtnbreporte.Location = New System.Drawing.Point(160, 46)
        Me.txtnbreporte.Name = "txtnbreporte"
        Me.txtnbreporte.ReadOnly = True
        Me.txtnbreporte.Size = New System.Drawing.Size(298, 20)
        Me.txtnbreporte.TabIndex = 59
        '
        'txtcdreporte
        '
        Me.txtcdreporte.Location = New System.Drawing.Point(81, 46)
        Me.txtcdreporte.Name = "txtcdreporte"
        Me.txtcdreporte.ReadOnly = True
        Me.txtcdreporte.Size = New System.Drawing.Size(73, 20)
        Me.txtcdreporte.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Pantalla :"
        '
        'txtnbproyecto
        '
        Me.txtnbproyecto.Location = New System.Drawing.Point(160, 16)
        Me.txtnbproyecto.Name = "txtnbproyecto"
        Me.txtnbproyecto.ReadOnly = True
        Me.txtnbproyecto.Size = New System.Drawing.Size(298, 20)
        Me.txtnbproyecto.TabIndex = 56
        '
        'txtcdproyecto
        '
        Me.txtcdproyecto.Location = New System.Drawing.Point(81, 16)
        Me.txtcdproyecto.Name = "txtcdproyecto"
        Me.txtcdproyecto.ReadOnly = True
        Me.txtcdproyecto.Size = New System.Drawing.Size(73, 20)
        Me.txtcdproyecto.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Proyecto :"
        '
        'cboarreglo
        '
        Me.cboarreglo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboarreglo.FormattingEnabled = True
        Me.cboarreglo.Location = New System.Drawing.Point(81, 153)
        Me.cboarreglo.Name = "cboarreglo"
        Me.cboarreglo.Size = New System.Drawing.Size(377, 21)
        Me.cboarreglo.TabIndex = 73
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(12, 156)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 13)
        Me.Label21.TabIndex = 72
        Me.Label21.Text = "Arreglo :"
        '
        'frmReporteCampo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 322)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboarreglo)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtdecimales)
        Me.Controls.Add(Me.cbotipo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdgrabar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtcomentario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtcdcampo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnbreporte)
        Me.Controls.Add(Me.txtcdreporte)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnbproyecto)
        Me.Controls.Add(Me.txtcdproyecto)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReporteCampo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Campos de un reporte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtdecimales As System.Windows.Forms.TextBox
    Friend WithEvents cbotipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdgrabar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtcomentario As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtcdcampo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnbreporte As System.Windows.Forms.TextBox
    Friend WithEvents txtcdreporte As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnbproyecto As System.Windows.Forms.TextBox
    Friend WithEvents txtcdproyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboarreglo As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
End Class
