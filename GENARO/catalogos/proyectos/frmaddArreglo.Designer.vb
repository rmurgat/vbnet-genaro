<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaddArreglo
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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdgrabar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.radoutput = New System.Windows.Forms.RadioButton()
        Me.radinput = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(72, 15)
        Me.txtNombre.MaxLength = 60
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(232, 20)
        Me.txtNombre.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Nombre : "
        '
        'cmdgrabar
        '
        Me.cmdgrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdgrabar.Location = New System.Drawing.Point(335, 40)
        Me.cmdgrabar.Name = "cmdgrabar"
        Me.cmdgrabar.Size = New System.Drawing.Size(87, 23)
        Me.cmdgrabar.TabIndex = 71
        Me.cmdgrabar.Text = "Grabar"
        Me.cmdgrabar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(335, 12)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(87, 23)
        Me.btnsalir.TabIndex = 70
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'radoutput
        '
        Me.radoutput.AutoSize = True
        Me.radoutput.Location = New System.Drawing.Point(155, 41)
        Me.radoutput.Name = "radoutput"
        Me.radoutput.Size = New System.Drawing.Size(63, 17)
        Me.radoutput.TabIndex = 73
        Me.radoutput.Text = "SALIDA"
        Me.radoutput.UseVisualStyleBackColor = True
        '
        'radinput
        '
        Me.radinput.AutoSize = True
        Me.radinput.Checked = True
        Me.radinput.Location = New System.Drawing.Point(72, 41)
        Me.radinput.Name = "radinput"
        Me.radinput.Size = New System.Drawing.Size(77, 17)
        Me.radinput.TabIndex = 72
        Me.radinput.TabStop = True
        Me.radinput.Text = "ENTRADA"
        Me.radinput.UseVisualStyleBackColor = True
        '
        'frmaddArreglo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 74)
        Me.ControlBox = False
        Me.Controls.Add(Me.radoutput)
        Me.Controls.Add(Me.radinput)
        Me.Controls.Add(Me.cmdgrabar)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmaddArreglo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Alta de un nuevo arreglo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdgrabar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents radoutput As System.Windows.Forms.RadioButton
    Friend WithEvents radinput As System.Windows.Forms.RadioButton
End Class
