<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_nuevaprograma
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.button1 = New System.Windows.Forms.Button()
        Me.fecha_fin = New System.Windows.Forms.DateTimePicker()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.fecha_inicio = New System.Windows.Forms.DateTimePicker()
        Me.button2 = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.Texto = New System.Windows.Forms.RichTextBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button1.Location = New System.Drawing.Point(9, 387)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(83, 42)
        Me.button1.TabIndex = 4
        Me.button1.Text = "Aceptar"
        Me.button1.UseVisualStyleBackColor = True
        '
        'fecha_fin
        '
        Me.fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha_fin.Location = New System.Drawing.Point(16, 79)
        Me.fecha_fin.Name = "fecha_fin"
        Me.fecha_fin.Size = New System.Drawing.Size(245, 20)
        Me.fecha_fin.TabIndex = 11
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(6, 191)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(78, 13)
        Me.label6.TabIndex = 15
        Me.label6.Text = "Observaciones"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(6, 145)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(52, 13)
        Me.label5.TabIndex = 14
        Me.label5.Text = "Mantante"
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(6, 161)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(296, 21)
        Me.comboBox1.TabIndex = 11
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(65, 13)
        Me.label1.TabIndex = 13
        Me.label1.Text = "Fecha Inicio"
        '
        'fecha_inicio
        '
        Me.fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha_inicio.Location = New System.Drawing.Point(16, 27)
        Me.fecha_inicio.Name = "fecha_inicio"
        Me.fecha_inicio.Size = New System.Drawing.Size(245, 20)
        Me.fecha_inicio.TabIndex = 9
        '
        'button2
        '
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button2.Location = New System.Drawing.Point(219, 387)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(83, 42)
        Me.button2.TabIndex = 5
        Me.button2.Text = "Cancelar"
        Me.button2.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(13, 63)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(62, 13)
        Me.label2.TabIndex = 14
        Me.label2.Text = "Fecha Final"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.comboBox1)
        Me.groupBox1.Controls.Add(Me.Texto)
        Me.groupBox1.Controls.Add(Me.groupBox2)
        Me.groupBox1.Location = New System.Drawing.Point(0, 2)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(312, 370)
        Me.groupBox1.TabIndex = 3
        Me.groupBox1.TabStop = False
        '
        'Texto
        '
        Me.Texto.Location = New System.Drawing.Point(6, 207)
        Me.Texto.Name = "Texto"
        Me.Texto.Size = New System.Drawing.Size(296, 143)
        Me.Texto.TabIndex = 10
        Me.Texto.Text = ""
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Controls.Add(Me.label1)
        Me.groupBox2.Controls.Add(Me.fecha_fin)
        Me.groupBox2.Controls.Add(Me.fecha_inicio)
        Me.groupBox2.Location = New System.Drawing.Point(6, 9)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(296, 117)
        Me.groupBox2.TabIndex = 9
        Me.groupBox2.TabStop = False
        '
        'Frm_nuevaprograma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 434)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "Frm_nuevaprograma"
        Me.Text = "Frm_nuevaprograma"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents button1 As System.Windows.Forms.Button
    Public WithEvents fecha_fin As System.Windows.Forms.DateTimePicker
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Public WithEvents fecha_inicio As System.Windows.Forms.DateTimePicker
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents Texto As System.Windows.Forms.RichTextBox
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
End Class
