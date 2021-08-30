<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_verliquidacion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Lbl_comuna = New System.Windows.Forms.Label()
        Me.Lbl_direccion = New System.Windows.Forms.Label()
        Me.Lbl_fecha = New System.Windows.Forms.Label()
        Me.Lbl_rut = New System.Windows.Forms.Label()
        Me.Lbl_giro = New System.Windows.Forms.Label()
        Me.Lbl_razonsocial = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nrof = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Dtg_lotes = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Rdb_factura = New System.Windows.Forms.RadioButton()
        Me.Btn_imprimir = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Txt_ila = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Txt_publicidad = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Txt_fletes = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Txt_lotes = New System.Windows.Forms.TextBox()
        Me.Txt_liquido = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Txt_impuestorec = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txt_comision = New System.Windows.Forms.TextBox()
        Me.Txt_iva = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_neto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chKAntiguas = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Dtg_lotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chKAntiguas)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(915, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Lbl_comuna)
        Me.GroupBox7.Controls.Add(Me.Lbl_direccion)
        Me.GroupBox7.Controls.Add(Me.Lbl_fecha)
        Me.GroupBox7.Controls.Add(Me.Lbl_rut)
        Me.GroupBox7.Controls.Add(Me.Lbl_giro)
        Me.GroupBox7.Controls.Add(Me.Lbl_razonsocial)
        Me.GroupBox7.Location = New System.Drawing.Point(221, 7)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(690, 102)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        '
        'Lbl_comuna
        '
        Me.Lbl_comuna.AutoSize = True
        Me.Lbl_comuna.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_comuna.Location = New System.Drawing.Point(28, 79)
        Me.Lbl_comuna.Name = "Lbl_comuna"
        Me.Lbl_comuna.Size = New System.Drawing.Size(60, 20)
        Me.Lbl_comuna.TabIndex = 8
        Me.Lbl_comuna.Text = "Comuna"
        '
        'Lbl_direccion
        '
        Me.Lbl_direccion.AutoSize = True
        Me.Lbl_direccion.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_direccion.Location = New System.Drawing.Point(28, 59)
        Me.Lbl_direccion.Name = "Lbl_direccion"
        Me.Lbl_direccion.Size = New System.Drawing.Size(68, 20)
        Me.Lbl_direccion.TabIndex = 7
        Me.Lbl_direccion.Text = "Direccion"
        '
        'Lbl_fecha
        '
        Me.Lbl_fecha.AutoSize = True
        Me.Lbl_fecha.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_fecha.Location = New System.Drawing.Point(595, 37)
        Me.Lbl_fecha.Name = "Lbl_fecha"
        Me.Lbl_fecha.Size = New System.Drawing.Size(46, 20)
        Me.Lbl_fecha.TabIndex = 6
        Me.Lbl_fecha.Text = "Fecha"
        '
        'Lbl_rut
        '
        Me.Lbl_rut.AutoSize = True
        Me.Lbl_rut.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_rut.Location = New System.Drawing.Point(595, 16)
        Me.Lbl_rut.Name = "Lbl_rut"
        Me.Lbl_rut.Size = New System.Drawing.Size(30, 20)
        Me.Lbl_rut.TabIndex = 5
        Me.Lbl_rut.Text = "Rut"
        '
        'Lbl_giro
        '
        Me.Lbl_giro.AutoSize = True
        Me.Lbl_giro.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_giro.Location = New System.Drawing.Point(28, 36)
        Me.Lbl_giro.Name = "Lbl_giro"
        Me.Lbl_giro.Size = New System.Drawing.Size(36, 20)
        Me.Lbl_giro.TabIndex = 4
        Me.Lbl_giro.Text = "Giro"
        '
        'Lbl_razonsocial
        '
        Me.Lbl_razonsocial.AutoSize = True
        Me.Lbl_razonsocial.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_razonsocial.Location = New System.Drawing.Point(28, 12)
        Me.Lbl_razonsocial.Name = "Lbl_razonsocial"
        Me.Lbl_razonsocial.Size = New System.Drawing.Size(87, 20)
        Me.Lbl_razonsocial.TabIndex = 3
        Me.Lbl_razonsocial.Text = "Razon social"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_nrof)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 56)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "N° Liquidacion"
        '
        'txt_nrof
        '
        Me.txt_nrof.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nrof.Location = New System.Drawing.Point(5, 26)
        Me.txt_nrof.Name = "txt_nrof"
        Me.txt_nrof.Size = New System.Drawing.Size(125, 25)
        Me.txt_nrof.TabIndex = 1
        Me.txt_nrof.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(136, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dtg_lotes)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 122)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(915, 234)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'Dtg_lotes
        '
        Me.Dtg_lotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtg_lotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dtg_lotes.Location = New System.Drawing.Point(4, 16)
        Me.Dtg_lotes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Dtg_lotes.Name = "Dtg_lotes"
        Me.Dtg_lotes.Size = New System.Drawing.Size(907, 215)
        Me.Dtg_lotes.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.Btn_imprimir)
        Me.GroupBox5.Location = New System.Drawing.Point(123, 364)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(259, 81)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Rdb_factura)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 11)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(247, 37)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        '
        'Rdb_factura
        '
        Me.Rdb_factura.AutoSize = True
        Me.Rdb_factura.Checked = True
        Me.Rdb_factura.Location = New System.Drawing.Point(92, 13)
        Me.Rdb_factura.Name = "Rdb_factura"
        Me.Rdb_factura.Size = New System.Drawing.Size(79, 17)
        Me.Rdb_factura.TabIndex = 1
        Me.Rdb_factura.TabStop = True
        Me.Rdb_factura.Text = "Liquidacion"
        Me.Rdb_factura.UseVisualStyleBackColor = True
        '
        'Btn_imprimir
        '
        Me.Btn_imprimir.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_imprimir.Location = New System.Drawing.Point(72, 50)
        Me.Btn_imprimir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_imprimir.Name = "Btn_imprimir"
        Me.Btn_imprimir.Size = New System.Drawing.Size(100, 27)
        Me.Btn_imprimir.TabIndex = 4
        Me.Btn_imprimir.Text = "Imprimir"
        Me.Btn_imprimir.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Txt_ila)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Txt_publicidad)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Txt_fletes)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Txt_lotes)
        Me.GroupBox4.Controls.Add(Me.Txt_liquido)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Txt_impuestorec)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Txt_comision)
        Me.GroupBox4.Controls.Add(Me.Txt_iva)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Txt_neto)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(424, 355)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox4.Size = New System.Drawing.Size(490, 247)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        '
        'Txt_ila
        '
        Me.Txt_ila.Location = New System.Drawing.Point(131, 127)
        Me.Txt_ila.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_ila.Name = "Txt_ila"
        Me.Txt_ila.Size = New System.Drawing.Size(208, 20)
        Me.Txt_ila.TabIndex = 31
        Me.Txt_ila.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(7, 131)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(25, 14)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "ILA"
        '
        'Txt_publicidad
        '
        Me.Txt_publicidad.Location = New System.Drawing.Point(131, 187)
        Me.Txt_publicidad.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_publicidad.Name = "Txt_publicidad"
        Me.Txt_publicidad.Size = New System.Drawing.Size(208, 20)
        Me.Txt_publicidad.TabIndex = 29
        Me.Txt_publicidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(7, 191)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 14)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Publicidad"
        '
        'Txt_fletes
        '
        Me.Txt_fletes.Location = New System.Drawing.Point(131, 161)
        Me.Txt_fletes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_fletes.Name = "Txt_fletes"
        Me.Txt_fletes.Size = New System.Drawing.Size(208, 20)
        Me.Txt_fletes.TabIndex = 27
        Me.Txt_fletes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 165)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 14)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Flete"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(347, 19)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 14)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "N° de Lotes"
        '
        'Txt_lotes
        '
        Me.Txt_lotes.Location = New System.Drawing.Point(421, 15)
        Me.Txt_lotes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_lotes.Name = "Txt_lotes"
        Me.Txt_lotes.Size = New System.Drawing.Size(65, 20)
        Me.Txt_lotes.TabIndex = 25
        '
        'Txt_liquido
        '
        Me.Txt_liquido.Location = New System.Drawing.Point(131, 214)
        Me.Txt_liquido.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_liquido.Name = "Txt_liquido"
        Me.Txt_liquido.Size = New System.Drawing.Size(208, 20)
        Me.Txt_liquido.TabIndex = 21
        Me.Txt_liquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 223)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 14)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Liquido a Pagar"
        '
        'Txt_impuestorec
        '
        Me.Txt_impuestorec.Location = New System.Drawing.Point(131, 42)
        Me.Txt_impuestorec.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_impuestorec.Name = "Txt_impuestorec"
        Me.Txt_impuestorec.Size = New System.Drawing.Size(208, 20)
        Me.Txt_impuestorec.TabIndex = 19
        Me.Txt_impuestorec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 51)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 14)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Impuesto Recaudado"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 79)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 14)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Comision"
        '
        'Txt_comision
        '
        Me.Txt_comision.Location = New System.Drawing.Point(131, 70)
        Me.Txt_comision.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_comision.Name = "Txt_comision"
        Me.Txt_comision.Size = New System.Drawing.Size(208, 20)
        Me.Txt_comision.TabIndex = 15
        Me.Txt_comision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_iva
        '
        Me.Txt_iva.Location = New System.Drawing.Point(131, 98)
        Me.Txt_iva.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_iva.Name = "Txt_iva"
        Me.Txt_iva.Size = New System.Drawing.Size(208, 20)
        Me.Txt_iva.TabIndex = 11
        Me.Txt_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 102)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 14)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Iva"
        '
        'Txt_neto
        '
        Me.Txt_neto.Location = New System.Drawing.Point(131, 15)
        Me.Txt_neto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_neto.Name = "Txt_neto"
        Me.Txt_neto.Size = New System.Drawing.Size(208, 20)
        Me.Txt_neto.TabIndex = 9
        Me.Txt_neto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 24)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 14)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Neto"
        '
        'chKAntiguas
        '
        Me.chKAntiguas.AutoSize = True
        Me.chKAntiguas.Location = New System.Drawing.Point(10, 86)
        Me.chKAntiguas.Name = "chKAntiguas"
        Me.chKAntiguas.Size = New System.Drawing.Size(67, 17)
        Me.chKAntiguas.TabIndex = 2
        Me.chKAntiguas.Text = "Antiguas"
        Me.chKAntiguas.UseVisualStyleBackColor = True
        '
        'Frm_verliquidacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 615)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_verliquidacion"
        Me.Text = "Frm_verliquidacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Dtg_lotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nrof As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Dtg_lotes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Rdb_factura As System.Windows.Forms.RadioButton
    Friend WithEvents Btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_direccion As System.Windows.Forms.Label
    Friend WithEvents Lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents Lbl_rut As System.Windows.Forms.Label
    Friend WithEvents Lbl_giro As System.Windows.Forms.Label
    Friend WithEvents Lbl_razonsocial As System.Windows.Forms.Label
    Friend WithEvents Lbl_comuna As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_ila As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Txt_publicidad As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Txt_fletes As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Txt_lotes As System.Windows.Forms.TextBox
    Friend WithEvents Txt_liquido As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Txt_impuestorec As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Txt_comision As System.Windows.Forms.TextBox
    Friend WithEvents Txt_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Txt_neto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chKAntiguas As System.Windows.Forms.CheckBox
End Class
