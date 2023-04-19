<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcambiardatabase
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
        Me.txtdatabase = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtdatabase
        '
        Me.txtdatabase.Location = New System.Drawing.Point(102, 15)
        Me.txtdatabase.Name = "txtdatabase"
        Me.txtdatabase.ReadOnly = True
        Me.txtdatabase.Size = New System.Drawing.Size(387, 20)
        Me.txtdatabase.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AllowDrop = True
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Base de datos  :"
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAceptar.Location = New System.Drawing.Point(304, 41)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(117, 23)
        Me.btnAceptar.TabIndex = 17
        Me.btnAceptar.Text = "Aceptar"
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncerrar.Location = New System.Drawing.Point(427, 41)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(117, 23)
        Me.btncerrar.TabIndex = 16
        Me.btncerrar.Text = "Cerrar"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(503, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 20)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Ver..."
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmcambiardatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 71)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.txtdatabase)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmcambiardatabase"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Cambiar conexión a la base de datos..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtdatabase As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
