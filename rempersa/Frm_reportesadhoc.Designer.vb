<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_reportesadhoc
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cmbremates = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbMes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbAño = New System.Windows.Forms.ComboBox()
        Me.BtnLibroVenta = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ChkNominas = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbFremates = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbMesl = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbAñol = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Txtnliquidacion = New System.Windows.Forms.TextBox()
        Me.Btnliquidacion = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SkyBlue
        Me.Button1.Location = New System.Drawing.Point(21, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(214, 21)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Generar Reporte de Remate"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Cmbremates
        '
        Me.Cmbremates.FormattingEnabled = True
        Me.Cmbremates.Location = New System.Drawing.Point(242, 19)
        Me.Cmbremates.Name = "Cmbremates"
        Me.Cmbremates.Size = New System.Drawing.Size(121, 21)
        Me.Cmbremates.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cmbremates)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 53)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lotes"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.CmbMes)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CmbAño)
        Me.GroupBox2.Controls.Add(Me.BtnLibroVenta)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(468, 53)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Libro de Ventas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(314, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mes"
        '
        'CmbMes
        '
        Me.CmbMes.FormattingEnabled = True
        Me.CmbMes.Location = New System.Drawing.Point(317, 24)
        Me.CmbMes.Name = "CmbMes"
        Me.CmbMes.Size = New System.Drawing.Size(121, 21)
        Me.CmbMes.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(187, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Año"
        '
        'CmbAño
        '
        Me.CmbAño.FormattingEnabled = True
        Me.CmbAño.Location = New System.Drawing.Point(190, 25)
        Me.CmbAño.Name = "CmbAño"
        Me.CmbAño.Size = New System.Drawing.Size(121, 21)
        Me.CmbAño.TabIndex = 1
        '
        'BtnLibroVenta
        '
        Me.BtnLibroVenta.BackColor = System.Drawing.Color.SkyBlue
        Me.BtnLibroVenta.Location = New System.Drawing.Point(22, 25)
        Me.BtnLibroVenta.Name = "BtnLibroVenta"
        Me.BtnLibroVenta.Size = New System.Drawing.Size(90, 21)
        Me.BtnLibroVenta.TabIndex = 0
        Me.BtnLibroVenta.Text = "Libro de Ventas"
        Me.BtnLibroVenta.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ChkNominas)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.CmbFremates)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 114)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(468, 60)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Libro de Ventas Facturas por Remate"
        '
        'ChkNominas
        '
        Me.ChkNominas.AutoSize = True
        Me.ChkNominas.Location = New System.Drawing.Point(373, 32)
        Me.ChkNominas.Name = "ChkNominas"
        Me.ChkNominas.Size = New System.Drawing.Size(67, 17)
        Me.ChkNominas.TabIndex = 3
        Me.ChkNominas.Text = "Nominas"
        Me.ChkNominas.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Remates"
        '
        'CmbFremates
        '
        Me.CmbFremates.FormattingEnabled = True
        Me.CmbFremates.Location = New System.Drawing.Point(242, 29)
        Me.CmbFremates.Name = "CmbFremates"
        Me.CmbFremates.Size = New System.Drawing.Size(121, 21)
        Me.CmbFremates.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SkyBlue
        Me.Button2.Location = New System.Drawing.Point(22, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 38)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Libro de Ventas Facturas por Remate"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.CmbMesl)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.CmbAñol)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 177)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(468, 77)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Libro de Ventas Liquidaciones por Remate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(314, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Mes"
        '
        'CmbMesl
        '
        Me.CmbMesl.FormattingEnabled = True
        Me.CmbMesl.Location = New System.Drawing.Point(317, 38)
        Me.CmbMesl.Name = "CmbMesl"
        Me.CmbMesl.Size = New System.Drawing.Size(121, 21)
        Me.CmbMesl.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(187, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Año"
        '
        'CmbAñol
        '
        Me.CmbAñol.FormattingEnabled = True
        Me.CmbAñol.Location = New System.Drawing.Point(190, 39)
        Me.CmbAñol.Name = "CmbAñol"
        Me.CmbAñol.Size = New System.Drawing.Size(121, 21)
        Me.CmbAñol.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SkyBlue
        Me.Button3.Location = New System.Drawing.Point(22, 25)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 44)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Libro de Ventas Liquidaciones "
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Txtnliquidacion)
        Me.GroupBox5.Controls.Add(Me.Btnliquidacion)
        Me.GroupBox5.Location = New System.Drawing.Point(5, 256)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(468, 96)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detalle Liquidaciones"
        '
        'Txtnliquidacion
        '
        Me.Txtnliquidacion.Location = New System.Drawing.Point(243, 38)
        Me.Txtnliquidacion.Name = "Txtnliquidacion"
        Me.Txtnliquidacion.Size = New System.Drawing.Size(100, 20)
        Me.Txtnliquidacion.TabIndex = 1
        Me.Txtnliquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btnliquidacion
        '
        Me.Btnliquidacion.BackColor = System.Drawing.Color.SkyBlue
        Me.Btnliquidacion.Location = New System.Drawing.Point(7, 19)
        Me.Btnliquidacion.Name = "Btnliquidacion"
        Me.Btnliquidacion.Size = New System.Drawing.Size(136, 56)
        Me.Btnliquidacion.TabIndex = 0
        Me.Btnliquidacion.Text = "Generar Detalle Liquidacion"
        Me.Btnliquidacion.UseVisualStyleBackColor = False
        '
        'Frm_reportesadhoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 440)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_reportesadhoc"
        Me.Text = "Generador de Reportes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Cmbremates As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbAño As System.Windows.Forms.ComboBox
    Friend WithEvents BtnLibroVenta As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmbFremates As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ChkNominas As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbMesl As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmbAñol As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Btnliquidacion As System.Windows.Forms.Button
    Friend WithEvents Txtnliquidacion As System.Windows.Forms.TextBox
End Class
