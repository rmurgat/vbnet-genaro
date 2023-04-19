<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListSelectOne
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListSelectOne))
        Me.txtopciones = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gridSelectOne = New System.Windows.Forms.DataGridView()
        Me.btnAceptar = New System.Windows.Forms.Button()
        CType(Me.gridSelectOne, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtopciones
        '
        Me.txtopciones.Location = New System.Drawing.Point(13, 266)
        Me.txtopciones.Name = "txtopciones"
        Me.txtopciones.ReadOnly = True
        Me.txtopciones.Size = New System.Drawing.Size(346, 20)
        Me.txtopciones.TabIndex = 6
        Me.txtopciones.Text = "Total de 0 opciones"
        Me.txtopciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(436, 266)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(67, 20)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        '
        'gridSelectOne
        '
        Me.gridSelectOne.AllowUserToAddRows = False
        Me.gridSelectOne.AllowUserToDeleteRows = False
        Me.gridSelectOne.AllowUserToResizeRows = False
        Me.gridSelectOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSelectOne.Location = New System.Drawing.Point(13, 13)
        Me.gridSelectOne.MultiSelect = False
        Me.gridSelectOne.Name = "gridSelectOne"
        Me.gridSelectOne.ReadOnly = True
        Me.gridSelectOne.RowHeadersVisible = False
        Me.gridSelectOne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridSelectOne.Size = New System.Drawing.Size(489, 240)
        Me.gridSelectOne.TabIndex = 8
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(365, 266)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(67, 20)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        '
        'frmListSelectOne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 298)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.gridSelectOne)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtopciones)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListSelectOne"
        Me.Text = "GENARO - Selección de uno..."
        CType(Me.gridSelectOne, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtopciones As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents gridSelectOne As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
End Class
