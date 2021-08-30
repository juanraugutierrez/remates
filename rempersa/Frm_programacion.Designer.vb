Imports Calendar

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_programacion
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
        Dim DrawTool1 As Calendar.DrawTool = New Calendar.DrawTool()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.Texto = New System.Windows.Forms.RichTextBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Fecha_fin = New System.Windows.Forms.DateTimePicker()
        Me.fecha_inicio = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DayView1 = New Calendar.DayView()
        Me.GroupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(625, 11)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(626, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 46)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Nueva Programacion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.label6)
        Me.GroupBox1.Controls.Add(Me.label5)
        Me.GroupBox1.Controls.Add(Me.comboBox1)
        Me.GroupBox1.Controls.Add(Me.Texto)
        Me.GroupBox1.Controls.Add(Me.groupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(619, 193)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(308, 12)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(78, 13)
        Me.label6.TabIndex = 19
        Me.label6.Text = "Observaciones"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(8, 144)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(52, 13)
        Me.label5.TabIndex = 18
        Me.label5.Text = "Mantante"
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(6, 160)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(296, 21)
        Me.comboBox1.TabIndex = 17
        '
        'Texto
        '
        Me.Texto.Location = New System.Drawing.Point(313, 28)
        Me.Texto.Name = "Texto"
        Me.Texto.Size = New System.Drawing.Size(296, 153)
        Me.Texto.TabIndex = 16
        Me.Texto.Text = ""
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Controls.Add(Me.label1)
        Me.groupBox2.Controls.Add(Me.Fecha_fin)
        Me.groupBox2.Controls.Add(Me.fecha_inicio)
        Me.groupBox2.Location = New System.Drawing.Point(6, 19)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(296, 117)
        Me.groupBox2.TabIndex = 10
        Me.groupBox2.TabStop = False
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
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(65, 13)
        Me.label1.TabIndex = 13
        Me.label1.Text = "Fecha Inicio"
        '
        'Fecha_fin
        '
        Me.Fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha_fin.Location = New System.Drawing.Point(16, 79)
        Me.Fecha_fin.Name = "Fecha_fin"
        Me.Fecha_fin.Size = New System.Drawing.Size(245, 20)
        Me.Fecha_fin.TabIndex = 11
        '
        'fecha_inicio
        '
        Me.fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha_inicio.Location = New System.Drawing.Point(16, 27)
        Me.fecha_inicio.Name = "fecha_inicio"
        Me.fecha_inicio.Size = New System.Drawing.Size(245, 20)
        Me.fecha_inicio.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DayView1)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 227)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1054, 394)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Programaciones"
        '
        'DayView1
        '
        DrawTool1.DayView = Me.DayView1
        Me.DayView1.ActiveTool = DrawTool1
        Me.DayView1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.DayView1.Location = New System.Drawing.Point(6, 28)
        Me.DayView1.Name = "DayView1"
        Me.DayView1.SelectionEnd = New Date(CType(0, Long))
        Me.DayView1.SelectionStart = New Date(CType(0, Long))
        Me.DayView1.Size = New System.Drawing.Size(1042, 356)
        Me.DayView1.StartDate = New Date(CType(0, Long))
        Me.DayView1.TabIndex = 2
        Me.DayView1.Text = "DayView1"
        '
        'Frm_programacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 642)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Name = "Frm_programacion"
        Me.Text = "programacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Public WithEvents Fecha_fin As System.Windows.Forms.DateTimePicker
    Public WithEvents fecha_inicio As System.Windows.Forms.DateTimePicker
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Public WithEvents Texto As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DayView1 As Calendar.DayView
End Class
