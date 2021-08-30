<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_facturaVtas
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btn_limpiar = New System.Windows.Forms.Button()
        Me.Btn_buscaclientes = New System.Windows.Forms.Button()
        Me.Txt_Comuna = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_giro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_rut = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_razonsocial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_nrofactura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Dtg_articulos = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Txt_comision = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_iva = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txt_total = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_neto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Rdb_factura = New System.Windows.Forms.RadioButton()
        Me.Rdb_prefactura = New System.Windows.Forms.RadioButton()
        Me.Btn_imprimir = New System.Windows.Forms.Button()
        Me.Cmb_pago = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Chk_afecto = New System.Windows.Forms.CheckBox()
        Me.Chk_comision = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Grp_mandante = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Cmb_mandante = New System.Windows.Forms.ComboBox()
        Me.btn_ingresar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txt_vunitario = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txt_descripcion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_unidades = New System.Windows.Forms.TextBox()
        Me.MCale = New System.Windows.Forms.MonthCalendar()
        Me.Chk_mandante = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dtg_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Grp_mandante.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Btn_limpiar)
        Me.GroupBox1.Controls.Add(Me.Btn_buscaclientes)
        Me.GroupBox1.Controls.Add(Me.Txt_Comuna)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Txt_giro)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txt_rut)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txt_direccion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_razonsocial)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_nrofactura)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 1)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(1099, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1007, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Btn_limpiar
        '
        Me.Btn_limpiar.Location = New System.Drawing.Point(1007, 16)
        Me.Btn_limpiar.Name = "Btn_limpiar"
        Me.Btn_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_limpiar.TabIndex = 13
        Me.Btn_limpiar.Text = "Limpiar"
        Me.Btn_limpiar.UseVisualStyleBackColor = True
        '
        'Btn_buscaclientes
        '
        Me.Btn_buscaclientes.Location = New System.Drawing.Point(156, 579)
        Me.Btn_buscaclientes.Name = "Btn_buscaclientes"
        Me.Btn_buscaclientes.Size = New System.Drawing.Size(208, 23)
        Me.Btn_buscaclientes.TabIndex = 12
        Me.Btn_buscaclientes.Text = "Buscar Clientes"
        Me.Btn_buscaclientes.UseVisualStyleBackColor = True
        '
        'Txt_Comuna
        '
        Me.Txt_Comuna.Location = New System.Drawing.Point(792, 85)
        Me.Txt_Comuna.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_Comuna.Name = "Txt_Comuna"
        Me.Txt_Comuna.Size = New System.Drawing.Size(208, 23)
        Me.Txt_Comuna.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(720, 87)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Comuna"
        '
        'Txt_giro
        '
        Me.Txt_giro.Location = New System.Drawing.Point(312, 15)
        Me.Txt_giro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_giro.Name = "Txt_giro"
        Me.Txt_giro.Size = New System.Drawing.Size(688, 23)
        Me.Txt_giro.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 18)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Giro"
        '
        'Txt_rut
        '
        Me.Txt_rut.Location = New System.Drawing.Point(791, 57)
        Me.Txt_rut.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_rut.Name = "Txt_rut"
        Me.Txt_rut.Size = New System.Drawing.Size(208, 23)
        Me.Txt_rut.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(720, 55)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Rut"
        '
        'Txt_direccion
        '
        Me.Txt_direccion.Location = New System.Drawing.Point(128, 90)
        Me.Txt_direccion.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_direccion.Name = "Txt_direccion"
        Me.Txt_direccion.Size = New System.Drawing.Size(530, 23)
        Me.Txt_direccion.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Direccion"
        '
        'Txt_razonsocial
        '
        Me.Txt_razonsocial.Location = New System.Drawing.Point(128, 60)
        Me.Txt_razonsocial.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_razonsocial.Name = "Txt_razonsocial"
        Me.Txt_razonsocial.Size = New System.Drawing.Size(530, 23)
        Me.Txt_razonsocial.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Razon Social"
        '
        'Txt_nrofactura
        '
        Me.Txt_nrofactura.Location = New System.Drawing.Point(124, 15)
        Me.Txt_nrofactura.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_nrofactura.Name = "Txt_nrofactura"
        Me.Txt_nrofactura.Size = New System.Drawing.Size(132, 23)
        Me.Txt_nrofactura.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro Factura"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Dtg_articulos)
        Me.GroupBox2.Location = New System.Drawing.Point(250, 131)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(850, 209)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Dtg_articulos
        '
        Me.Dtg_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtg_articulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dtg_articulos.Location = New System.Drawing.Point(4, 19)
        Me.Dtg_articulos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Dtg_articulos.Name = "Dtg_articulos"
        Me.Dtg_articulos.Size = New System.Drawing.Size(842, 187)
        Me.Dtg_articulos.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Txt_comision)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Txt_iva)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Txt_total)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Txt_neto)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(606, 340)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(477, 140)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'Txt_comision
        '
        Me.Txt_comision.Location = New System.Drawing.Point(317, 41)
        Me.Txt_comision.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_comision.Name = "Txt_comision"
        Me.Txt_comision.Size = New System.Drawing.Size(139, 23)
        Me.Txt_comision.TabIndex = 19
        Me.Txt_comision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(218, 50)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 14)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Comision"
        '
        'Txt_iva
        '
        Me.Txt_iva.Location = New System.Drawing.Point(316, 73)
        Me.Txt_iva.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_iva.Name = "Txt_iva"
        Me.Txt_iva.Size = New System.Drawing.Size(139, 23)
        Me.Txt_iva.TabIndex = 17
        Me.Txt_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(217, 82)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 14)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Iva"
        '
        'Txt_total
        '
        Me.Txt_total.Location = New System.Drawing.Point(316, 101)
        Me.Txt_total.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_total.Name = "Txt_total"
        Me.Txt_total.Size = New System.Drawing.Size(139, 23)
        Me.Txt_total.TabIndex = 11
        Me.Txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(217, 110)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 14)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Total"
        '
        'Txt_neto
        '
        Me.Txt_neto.Location = New System.Drawing.Point(316, 15)
        Me.Txt_neto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_neto.Name = "Txt_neto"
        Me.Txt_neto.Size = New System.Drawing.Size(139, 23)
        Me.Txt_neto.TabIndex = 9
        Me.Txt_neto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(217, 24)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 14)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Neto"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.Btn_imprimir)
        Me.GroupBox5.Location = New System.Drawing.Point(288, 343)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(296, 81)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Rdb_factura)
        Me.GroupBox6.Controls.Add(Me.Rdb_prefactura)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(273, 37)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        '
        'Rdb_factura
        '
        Me.Rdb_factura.AutoSize = True
        Me.Rdb_factura.Checked = True
        Me.Rdb_factura.Location = New System.Drawing.Point(160, 12)
        Me.Rdb_factura.Name = "Rdb_factura"
        Me.Rdb_factura.Size = New System.Drawing.Size(70, 19)
        Me.Rdb_factura.TabIndex = 1
        Me.Rdb_factura.TabStop = True
        Me.Rdb_factura.Text = "Factura"
        Me.Rdb_factura.UseVisualStyleBackColor = True
        '
        'Rdb_prefactura
        '
        Me.Rdb_prefactura.AutoSize = True
        Me.Rdb_prefactura.Location = New System.Drawing.Point(5, 12)
        Me.Rdb_prefactura.Name = "Rdb_prefactura"
        Me.Rdb_prefactura.Size = New System.Drawing.Size(94, 19)
        Me.Rdb_prefactura.TabIndex = 0
        Me.Rdb_prefactura.TabStop = True
        Me.Rdb_prefactura.Text = "Pre Factura"
        Me.Rdb_prefactura.UseVisualStyleBackColor = True
        '
        'Btn_imprimir
        '
        Me.Btn_imprimir.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_imprimir.Location = New System.Drawing.Point(71, 50)
        Me.Btn_imprimir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_imprimir.Name = "Btn_imprimir"
        Me.Btn_imprimir.Size = New System.Drawing.Size(100, 27)
        Me.Btn_imprimir.TabIndex = 4
        Me.Btn_imprimir.Text = "Imprimir"
        Me.Btn_imprimir.UseVisualStyleBackColor = True
        '
        'Cmb_pago
        '
        Me.Cmb_pago.FormattingEnabled = True
        Me.Cmb_pago.Location = New System.Drawing.Point(292, 457)
        Me.Cmb_pago.Name = "Cmb_pago"
        Me.Cmb_pago.Size = New System.Drawing.Size(247, 23)
        Me.Cmb_pago.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(290, 439)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 15)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Forma de Pago"
        '
        'Chk_afecto
        '
        Me.Chk_afecto.AutoSize = True
        Me.Chk_afecto.Checked = True
        Me.Chk_afecto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_afecto.Location = New System.Drawing.Point(12, 423)
        Me.Chk_afecto.Name = "Chk_afecto"
        Me.Chk_afecto.Size = New System.Drawing.Size(65, 19)
        Me.Chk_afecto.TabIndex = 21
        Me.Chk_afecto.Text = "Afecto"
        Me.Chk_afecto.UseVisualStyleBackColor = True
        '
        'Chk_comision
        '
        Me.Chk_comision.AutoSize = True
        Me.Chk_comision.Location = New System.Drawing.Point(12, 447)
        Me.Chk_comision.Name = "Chk_comision"
        Me.Chk_comision.Size = New System.Drawing.Size(82, 19)
        Me.Chk_comision.TabIndex = 22
        Me.Chk_comision.Text = "Comision"
        Me.Chk_comision.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Grp_mandante)
        Me.GroupBox4.Controls.Add(Me.btn_ingresar)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Txt_vunitario)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Txt_descripcion)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Txt_unidades)
        Me.GroupBox4.Location = New System.Drawing.Point(1, 502)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1082, 125)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        '
        'Grp_mandante
        '
        Me.Grp_mandante.Controls.Add(Me.Label14)
        Me.Grp_mandante.Controls.Add(Me.Cmb_mandante)
        Me.Grp_mandante.Location = New System.Drawing.Point(73, 63)
        Me.Grp_mandante.Name = "Grp_mandante"
        Me.Grp_mandante.Size = New System.Drawing.Size(648, 57)
        Me.Grp_mandante.TabIndex = 17
        Me.Grp_mandante.TabStop = False
        Me.Grp_mandante.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(26, 11)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 14)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Mandante"
        '
        'Cmb_mandante
        '
        Me.Cmb_mandante.FormattingEnabled = True
        Me.Cmb_mandante.Location = New System.Drawing.Point(29, 28)
        Me.Cmb_mandante.Name = "Cmb_mandante"
        Me.Cmb_mandante.Size = New System.Drawing.Size(601, 23)
        Me.Cmb_mandante.TabIndex = 17
        '
        'btn_ingresar
        '
        Me.btn_ingresar.Location = New System.Drawing.Point(999, 40)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(75, 23)
        Me.btn_ingresar.TabIndex = 16
        Me.btn_ingresar.Text = "Ingresar"
        Me.btn_ingresar.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(856, 23)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 14)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Valor Unitario"
        '
        'Txt_vunitario
        '
        Me.Txt_vunitario.Location = New System.Drawing.Point(859, 41)
        Me.Txt_vunitario.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_vunitario.Name = "Txt_vunitario"
        Me.Txt_vunitario.Size = New System.Drawing.Size(123, 23)
        Me.Txt_vunitario.TabIndex = 14
        Me.Txt_vunitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(73, 23)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 14)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Descripcion"
        '
        'Txt_descripcion
        '
        Me.Txt_descripcion.Location = New System.Drawing.Point(73, 40)
        Me.Txt_descripcion.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_descripcion.Name = "Txt_descripcion"
        Me.Txt_descripcion.Size = New System.Drawing.Size(778, 23)
        Me.Txt_descripcion.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 23)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 14)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Unidades"
        '
        'Txt_unidades
        '
        Me.Txt_unidades.Location = New System.Drawing.Point(7, 40)
        Me.Txt_unidades.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_unidades.Name = "Txt_unidades"
        Me.Txt_unidades.Size = New System.Drawing.Size(58, 23)
        Me.Txt_unidades.TabIndex = 10
        Me.Txt_unidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MCale
        '
        Me.MCale.Font = New System.Drawing.Font("Arial Black", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.MCale.Location = New System.Drawing.Point(1, 150)
        Me.MCale.Name = "MCale"
        Me.MCale.TabIndex = 20
        '
        'Chk_mandante
        '
        Me.Chk_mandante.AutoSize = True
        Me.Chk_mandante.Location = New System.Drawing.Point(12, 472)
        Me.Chk_mandante.Name = "Chk_mandante"
        Me.Chk_mandante.Size = New System.Drawing.Size(92, 19)
        Me.Chk_mandante.TabIndex = 24
        Me.Chk_mandante.Text = "Mercaderia"
        Me.Chk_mandante.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(173, 380)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Frm_facturaVtas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1144, 648)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Chk_mandante)
        Me.Controls.Add(Me.MCale)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Chk_comision)
        Me.Controls.Add(Me.Chk_afecto)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Cmb_pago)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Frm_facturaVtas"
        Me.Text = "Imprimir"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Dtg_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Grp_mandante.ResumeLayout(False)
        Me.Grp_mandante.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_nrofactura As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Dtg_articulos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Txt_total As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Txt_neto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Btn_buscaclientes As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Rdb_factura As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_prefactura As System.Windows.Forms.RadioButton
    Friend WithEvents Btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents Btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Cmb_pago As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents Txt_giro As System.Windows.Forms.TextBox
    Public WithEvents Txt_rut As System.Windows.Forms.TextBox
    Public WithEvents Txt_direccion As System.Windows.Forms.TextBox
    Public WithEvents Txt_razonsocial As System.Windows.Forms.TextBox
    Public WithEvents Txt_Comuna As System.Windows.Forms.TextBox
    Friend WithEvents Chk_afecto As System.Windows.Forms.CheckBox
    Friend WithEvents Txt_comision As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Chk_comision As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Txt_vunitario As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Txt_unidades As System.Windows.Forms.TextBox
    Friend WithEvents btn_ingresar As System.Windows.Forms.Button
    Friend WithEvents MCale As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Cmb_mandante As System.Windows.Forms.ComboBox
    Friend WithEvents Grp_mandante As System.Windows.Forms.GroupBox
    Friend WithEvents Chk_mandante As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
