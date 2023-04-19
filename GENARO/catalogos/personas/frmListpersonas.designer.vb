<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlistpersonas
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
        Me.components = New System.ComponentModel.Container()
        Me.cbodetalle = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PersonaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnstaffload = New System.Windows.Forms.Button()
        Me.txttotpersonas = New System.Windows.Forms.TextBox()
        Me.gridpersonas = New System.Windows.Forms.DataGridView()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridpersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbodetalle
        '
        Me.cbodetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbodetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodetalle.Location = New System.Drawing.Point(65, 258)
        Me.cbodetalle.Name = "cbodetalle"
        Me.cbodetalle.Size = New System.Drawing.Size(86, 20)
        Me.cbodetalle.TabIndex = 20
        Me.cbodetalle.Text = "ver detalle"
        Me.cbodetalle.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(12, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(743, 23)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "PERSONAS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btndel
        '
        Me.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.Location = New System.Drawing.Point(699, 258)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(25, 20)
        Me.btndel.TabIndex = 17
        Me.btndel.Text = "-"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(730, 258)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(25, 20)
        Me.btnadd.TabIndex = 16
        Me.btnadd.Text = "+"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnstaffload
        '
        Me.btnstaffload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnstaffload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstaffload.Location = New System.Drawing.Point(12, 258)
        Me.btnstaffload.Name = "btnstaffload"
        Me.btnstaffload.Size = New System.Drawing.Size(47, 20)
        Me.btnstaffload.TabIndex = 21
        Me.btnstaffload.Text = "load"
        Me.btnstaffload.UseVisualStyleBackColor = True
        '
        'txttotpersonas
        '
        Me.txttotpersonas.Location = New System.Drawing.Point(157, 258)
        Me.txttotpersonas.Name = "txttotpersonas"
        Me.txttotpersonas.ReadOnly = True
        Me.txttotpersonas.Size = New System.Drawing.Size(536, 20)
        Me.txttotpersonas.TabIndex = 35
        Me.txttotpersonas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gridpersonas
        '
        Me.gridpersonas.AllowUserToAddRows = False
        Me.gridpersonas.AllowUserToDeleteRows = False
        Me.gridpersonas.AllowUserToOrderColumns = True
        Me.gridpersonas.AllowUserToResizeRows = False
        Me.gridpersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridpersonas.Location = New System.Drawing.Point(12, 41)
        Me.gridpersonas.Name = "gridpersonas"
        Me.gridpersonas.ReadOnly = True
        Me.gridpersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridpersonas.Size = New System.Drawing.Size(743, 211)
        Me.gridpersonas.TabIndex = 36
        '
        'frmlistpersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 292)
        Me.Controls.Add(Me.gridpersonas)
        Me.Controls.Add(Me.txttotpersonas)
        Me.Controls.Add(Me.btnstaffload)
        Me.Controls.Add(Me.cbodetalle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnadd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmlistpersonas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Listado de Personas"
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridpersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbodetalle As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btndel As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnstaffload As System.Windows.Forms.Button
    Friend WithEvents PersonaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txttotpersonas As System.Windows.Forms.TextBox
    Friend WithEvents gridpersonas As System.Windows.Forms.DataGridView
End Class
