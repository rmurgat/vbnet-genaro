<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaddproyectofuentedato
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
        Me.txtcomentario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbofuente = New System.Windows.Forms.ComboBox()
        Me.cmdgrabar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtcomentario
        '
        Me.txtcomentario.Location = New System.Drawing.Point(81, 43)
        Me.txtcomentario.MaxLength = 1000
        Me.txtcomentario.Multiline = True
        Me.txtcomentario.Name = "txtcomentario"
        Me.txtcomentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtcomentario.Size = New System.Drawing.Size(483, 79)
        Me.txtcomentario.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Comentario :"
        '
        'cbofuente
        '
        Me.cbofuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofuente.FormattingEnabled = True
        Me.cbofuente.Location = New System.Drawing.Point(81, 12)
        Me.cbofuente.Name = "cbofuente"
        Me.cbofuente.Size = New System.Drawing.Size(483, 21)
        Me.cbofuente.TabIndex = 51
        '
        'cmdgrabar
        '
        Me.cmdgrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdgrabar.Location = New System.Drawing.Point(580, 43)
        Me.cmdgrabar.Name = "cmdgrabar"
        Me.cmdgrabar.Size = New System.Drawing.Size(87, 23)
        Me.cmdgrabar.TabIndex = 50
        Me.cmdgrabar.Text = "Grabar"
        Me.cmdgrabar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(580, 10)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 23)
        Me.btnSalir.TabIndex = 49
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Fuente :"
        '
        'frmaddproyectofuentedato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 134)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtcomentario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbofuente)
        Me.Controls.Add(Me.cmdgrabar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmaddproyectofuentedato"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Alta de una fuente de datos al proyecto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcomentario As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbofuente As System.Windows.Forms.ComboBox
    Friend WithEvents cmdgrabar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
