<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlistfuentedatos
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
        Me.cbodetalle = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gridatasource = New System.Windows.Forms.DataGridView()
        Me.txttotdatasource = New System.Windows.Forms.TextBox()
        CType(Me.gridatasource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbodetalle
        '
        Me.cbodetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbodetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodetalle.Location = New System.Drawing.Point(16, 334)
        Me.cbodetalle.Name = "cbodetalle"
        Me.cbodetalle.Size = New System.Drawing.Size(86, 20)
        Me.cbodetalle.TabIndex = 25
        Me.cbodetalle.Text = "ver detalle"
        Me.cbodetalle.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(16, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(700, 23)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "FUENTES DE DATOS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btndel
        '
        Me.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.Location = New System.Drawing.Point(660, 334)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(25, 20)
        Me.btndel.TabIndex = 23
        Me.btndel.Text = "-"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(691, 334)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(25, 20)
        Me.btnadd.TabIndex = 22
        Me.btnadd.Text = "+"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(597, 44)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(119, 23)
        Me.btnbuscar.TabIndex = 32
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(597, 15)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(119, 23)
        Me.btnSalir.TabIndex = 31
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'cboCliente
        '
        Me.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(116, 17)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(224, 21)
        Me.cboCliente.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Cliente : "
        '
        'gridatasource
        '
        Me.gridatasource.AllowUserToAddRows = False
        Me.gridatasource.AllowUserToDeleteRows = False
        Me.gridatasource.AllowUserToOrderColumns = True
        Me.gridatasource.AllowUserToResizeRows = False
        Me.gridatasource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridatasource.Location = New System.Drawing.Point(16, 113)
        Me.gridatasource.MultiSelect = False
        Me.gridatasource.Name = "gridatasource"
        Me.gridatasource.ReadOnly = True
        Me.gridatasource.RowHeadersVisible = False
        Me.gridatasource.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridatasource.Size = New System.Drawing.Size(700, 215)
        Me.gridatasource.TabIndex = 33
        '
        'txttotdatasource
        '
        Me.txttotdatasource.Location = New System.Drawing.Point(107, 334)
        Me.txttotdatasource.Name = "txttotdatasource"
        Me.txttotdatasource.ReadOnly = True
        Me.txttotdatasource.Size = New System.Drawing.Size(549, 20)
        Me.txttotdatasource.TabIndex = 34
        Me.txttotdatasource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmlistfuentedatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 373)
        Me.Controls.Add(Me.txttotdatasource)
        Me.Controls.Add(Me.gridatasource)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.cboCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbodetalle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnadd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmlistfuentedatos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Lista de fuentes de datos"
        CType(Me.gridatasource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbodetalle As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btndel As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents cboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gridatasource As System.Windows.Forms.DataGridView
    Friend WithEvents txttotdatasource As System.Windows.Forms.TextBox
End Class
