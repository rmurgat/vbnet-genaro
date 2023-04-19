<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListEntidades
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
        Me.gridEntidades = New System.Windows.Forms.DataGridView()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.chktodas = New System.Windows.Forms.CheckBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.radTodas = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radMarcadas = New System.Windows.Forms.RadioButton()
        Me.radSinmarcar = New System.Windows.Forms.RadioButton()
        CType(Me.gridEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridEntidades
        '
        Me.gridEntidades.AllowUserToAddRows = False
        Me.gridEntidades.AllowUserToDeleteRows = False
        Me.gridEntidades.AllowUserToResizeColumns = False
        Me.gridEntidades.AllowUserToResizeRows = False
        Me.gridEntidades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridEntidades.Location = New System.Drawing.Point(13, 13)
        Me.gridEntidades.MultiSelect = False
        Me.gridEntidades.Name = "gridEntidades"
        Me.gridEntidades.RowHeadersVisible = False
        Me.gridEntidades.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gridEntidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gridEntidades.Size = New System.Drawing.Size(666, 274)
        Me.gridEntidades.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(522, 318)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(604, 318)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'chktodas
        '
        Me.chktodas.AutoSize = True
        Me.chktodas.Location = New System.Drawing.Point(13, 298)
        Me.chktodas.Name = "chktodas"
        Me.chktodas.Size = New System.Drawing.Size(111, 17)
        Me.chktodas.TabIndex = 3
        Me.chktodas.Text = "Seleccionar todas"
        Me.chktodas.UseVisualStyleBackColor = True
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(161, 321)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(356, 20)
        Me.txttotal.TabIndex = 31
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'radTodas
        '
        Me.radTodas.AutoSize = True
        Me.radTodas.Location = New System.Drawing.Point(464, 298)
        Me.radTodas.Name = "radTodas"
        Me.radTodas.Size = New System.Drawing.Size(55, 17)
        Me.radTodas.TabIndex = 32
        Me.radTodas.Text = "Todas"
        Me.radTodas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(398, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Mostrar : "
        '
        'radMarcadas
        '
        Me.radMarcadas.AutoSize = True
        Me.radMarcadas.Location = New System.Drawing.Point(525, 297)
        Me.radMarcadas.Name = "radMarcadas"
        Me.radMarcadas.Size = New System.Drawing.Size(72, 17)
        Me.radMarcadas.TabIndex = 34
        Me.radMarcadas.Text = "Marcadas"
        Me.radMarcadas.UseVisualStyleBackColor = True
        '
        'radSinmarcar
        '
        Me.radSinmarcar.AutoSize = True
        Me.radSinmarcar.Location = New System.Drawing.Point(603, 297)
        Me.radSinmarcar.Name = "radSinmarcar"
        Me.radSinmarcar.Size = New System.Drawing.Size(76, 17)
        Me.radSinmarcar.TabIndex = 35
        Me.radSinmarcar.Text = "Sin Marcar"
        Me.radSinmarcar.UseVisualStyleBackColor = True
        '
        'frmListEntidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 345)
        Me.ControlBox = False
        Me.Controls.Add(Me.radSinmarcar)
        Me.Controls.Add(Me.radMarcadas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.radTodas)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.chktodas)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.gridEntidades)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmListEntidades"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Selección de Entidades..."
        CType(Me.gridEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridEntidades As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents chktodas As System.Windows.Forms.CheckBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents radTodas As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents radMarcadas As System.Windows.Forms.RadioButton
    Friend WithEvents radSinmarcar As System.Windows.Forms.RadioButton
End Class
