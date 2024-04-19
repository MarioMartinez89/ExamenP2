<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TxBuser = New System.Windows.Forms.TextBox()
        Me.TxBnombrec = New System.Windows.Forms.TextBox()
        Me.TxBtelc = New System.Windows.Forms.TextBox()
        Me.TxBemailc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btguardar = New System.Windows.Forms.Button()
        Me.Btedit = New System.Windows.Forms.Button()
        Me.Btborrar = New System.Windows.Forms.Button()
        Me.Btsalir = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btbuscar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxBuser
        '
        Me.TxBuser.Location = New System.Drawing.Point(88, 60)
        Me.TxBuser.Name = "TxBuser"
        Me.TxBuser.Size = New System.Drawing.Size(100, 20)
        Me.TxBuser.TabIndex = 0
        '
        'TxBnombrec
        '
        Me.TxBnombrec.Location = New System.Drawing.Point(130, 145)
        Me.TxBnombrec.Name = "TxBnombrec"
        Me.TxBnombrec.Size = New System.Drawing.Size(100, 20)
        Me.TxBnombrec.TabIndex = 2
        '
        'TxBtelc
        '
        Me.TxBtelc.Location = New System.Drawing.Point(130, 192)
        Me.TxBtelc.Name = "TxBtelc"
        Me.TxBtelc.Size = New System.Drawing.Size(100, 20)
        Me.TxBtelc.TabIndex = 3
        '
        'TxBemailc
        '
        Me.TxBemailc.Location = New System.Drawing.Point(130, 240)
        Me.TxBemailc.Name = "TxBemailc"
        Me.TxBemailc.Size = New System.Drawing.Size(100, 20)
        Me.TxBemailc.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre Contacto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Telefono Contacto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Email Contacto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(92, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Datos de Contacto"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(297, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(491, 229)
        Me.DataGridView1.TabIndex = 10
        '
        'Btguardar
        '
        Me.Btguardar.Location = New System.Drawing.Point(297, 314)
        Me.Btguardar.Name = "Btguardar"
        Me.Btguardar.Size = New System.Drawing.Size(75, 23)
        Me.Btguardar.TabIndex = 11
        Me.Btguardar.Text = "Guardar"
        Me.Btguardar.UseVisualStyleBackColor = True
        '
        'Btedit
        '
        Me.Btedit.Location = New System.Drawing.Point(503, 314)
        Me.Btedit.Name = "Btedit"
        Me.Btedit.Size = New System.Drawing.Size(75, 23)
        Me.Btedit.TabIndex = 12
        Me.Btedit.Text = "Editar"
        Me.Btedit.UseVisualStyleBackColor = True
        '
        'Btborrar
        '
        Me.Btborrar.Location = New System.Drawing.Point(610, 314)
        Me.Btborrar.Name = "Btborrar"
        Me.Btborrar.Size = New System.Drawing.Size(75, 23)
        Me.Btborrar.TabIndex = 13
        Me.Btborrar.Text = "Borrar"
        Me.Btborrar.UseVisualStyleBackColor = True
        '
        'Btsalir
        '
        Me.Btsalir.Location = New System.Drawing.Point(713, 314)
        Me.Btsalir.Name = "Btsalir"
        Me.Btsalir.Size = New System.Drawing.Size(75, 23)
        Me.Btsalir.TabIndex = 14
        Me.Btsalir.Text = "Salir"
        Me.Btsalir.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(350, 429)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 15
        '
        'Btbuscar
        '
        Me.Btbuscar.Location = New System.Drawing.Point(403, 314)
        Me.Btbuscar.Name = "Btbuscar"
        Me.Btbuscar.Size = New System.Drawing.Size(75, 23)
        Me.Btbuscar.TabIndex = 16
        Me.Btbuscar.Text = "Buscar"
        Me.Btbuscar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btbuscar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Btsalir)
        Me.Controls.Add(Me.Btborrar)
        Me.Controls.Add(Me.Btedit)
        Me.Controls.Add(Me.Btguardar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxBemailc)
        Me.Controls.Add(Me.TxBtelc)
        Me.Controls.Add(Me.TxBnombrec)
        Me.Controls.Add(Me.TxBuser)
        Me.Name = "Form1"
        Me.Text = "Agenda de contactos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxBuser As TextBox
    Friend WithEvents TxBnombrec As TextBox
    Friend WithEvents TxBtelc As TextBox
    Friend WithEvents TxBemailc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Btguardar As Button
    Friend WithEvents Btedit As Button
    Friend WithEvents Btborrar As Button
    Friend WithEvents Btsalir As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Btbuscar As Button
End Class
