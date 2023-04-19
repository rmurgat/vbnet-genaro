<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFronCalificaSync
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFronCalificaSync))
        Me.grdCalifica = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCalif = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lstdebug = New System.Windows.Forms.ListBox()
        Me.btnClipboard = New System.Windows.Forms.Button()
        CType(Me.grdCalifica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdCalifica
        '
        Me.grdCalifica.AllowUserToAddRows = False
        Me.grdCalifica.AllowUserToDeleteRows = False
        Me.grdCalifica.AllowUserToResizeRows = False
        Me.grdCalifica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grdCalifica.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.grdCalifica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCalifica.Location = New System.Drawing.Point(12, 12)
        Me.grdCalifica.MultiSelect = False
        Me.grdCalifica.Name = "grdCalifica"
        Me.grdCalifica.ReadOnly = True
        Me.grdCalifica.RowHeadersVisible = False
        Me.grdCalifica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdCalifica.Size = New System.Drawing.Size(533, 160)
        Me.grdCalifica.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(410, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Calificación Final"
        '
        'lblCalif
        '
        Me.lblCalif.AutoSize = True
        Me.lblCalif.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCalif.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCalif.Location = New System.Drawing.Point(510, 274)
        Me.lblCalif.Name = "lblCalif"
        Me.lblCalif.Size = New System.Drawing.Size(25, 15)
        Me.lblCalif.TabIndex = 2
        Me.lblCalif.Text = "NO"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(13, 271)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(114, 23)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Iniciar Calificación"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(133, 271)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(61, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lstdebug
        '
        Me.lstdebug.FormattingEnabled = True
        Me.lstdebug.Location = New System.Drawing.Point(12, 178)
        Me.lstdebug.Name = "lstdebug"
        Me.lstdebug.Size = New System.Drawing.Size(533, 82)
        Me.lstdebug.TabIndex = 5
        '
        'btnClipboard
        '
        Me.btnClipboard.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnClipboard.FlatAppearance.BorderSize = 0
        Me.btnClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClipboard.Image = CType(resources.GetObject("btnClipboard.Image"), System.Drawing.Image)
        Me.btnClipboard.Location = New System.Drawing.Point(200, 265)
        Me.btnClipboard.Name = "btnClipboard"
        Me.btnClipboard.Size = New System.Drawing.Size(24, 30)
        Me.btnClipboard.TabIndex = 7
        Me.btnClipboard.UseVisualStyleBackColor = True
        Me.btnClipboard.Visible = False
        '
        'frmFronCalificaSync
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 304)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClipboard)
        Me.Controls.Add(Me.lstdebug)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblCalif)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdCalifica)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFronCalificaSync"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GENARO - Calificación de la Sincronización"
        CType(Me.grdCalifica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdCalifica As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCalif As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lstdebug As System.Windows.Forms.ListBox
    Friend WithEvents btnClipboard As System.Windows.Forms.Button

End Class
