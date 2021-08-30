<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_facturaelect
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Dtg_lotes = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Txt_liquido = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Txt_garantia = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Txt_ila = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Txt_nrodefacturas = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Txt_lotes = New System.Windows.Forms.TextBox()
        Me.Txt_comision = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txt_iva = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txt_cargo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txt_total = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_neto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Btn_actualizar = New System.Windows.Forms.Button()
        Me.Lst_clientes = New System.Windows.Forms.ListBox()
        Me.Lbl_tiporema = New System.Windows.Forms.Label()
        Me.Lbl_fecharema = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Cmb_remates = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Rdb_factura = New System.Windows.Forms.RadioButton()
        Me.Rdb_prefactura = New System.Windows.Forms.RadioButton()
        Me.Btn_imprimir = New System.Windows.Forms.Button()
        Me.Cmb_pago = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Chk_afecto = New System.Windows.Forms.CheckBox()
        Me.Chk_cargos = New System.Windows.Forms.CheckBox()
        Me.Chk_comision = New System.Windows.Forms.CheckBox()
        Me.ChkIla = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dtg_lotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(203, -1)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(917, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(827, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Btn_limpiar
        '
        Me.Btn_limpiar.Location = New System.Drawing.Point(827, 16)
        Me.Btn_limpiar.Name = "Btn_limpiar"
        Me.Btn_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_limpiar.TabIndex = 13
        Me.Btn_limpiar.Text = "Limpiar"
        Me.Btn_limpiar.UseVisualStyleBackColor = True
        '
        'Btn_buscaclientes
        '
        Me.Btn_buscaclientes.Location = New System.Drawing.Point(157, 579)
        Me.Btn_buscaclientes.Name = "Btn_buscaclientes"
        Me.Btn_buscaclientes.Size = New System.Drawing.Size(208, 23)
        Me.Btn_buscaclientes.TabIndex = 12
        Me.Btn_buscaclientes.Text = "Buscar Clientes"
        Me.Btn_buscaclientes.UseVisualStyleBackColor = True
        '
        'Txt_Comuna
        '
        Me.Txt_Comuna.Location = New System.Drawing.Point(594, 91)
        Me.Txt_Comuna.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_Comuna.Name = "Txt_Comuna"
        Me.Txt_Comuna.Size = New System.Drawing.Size(208, 23)
        Me.Txt_Comuna.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(522, 93)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Comuna"
        '
        'Txt_giro
        '
        Me.Txt_giro.Location = New System.Drawing.Point(313, 15)
        Me.Txt_giro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_giro.Name = "Txt_giro"
        Me.Txt_giro.Size = New System.Drawing.Size(295, 23)
        Me.Txt_giro.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(275, 18)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Giro"
        '
        'Txt_rut
        '
        Me.Txt_rut.Location = New System.Drawing.Point(593, 63)
        Me.Txt_rut.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_rut.Name = "Txt_rut"
        Me.Txt_rut.Size = New System.Drawing.Size(208, 23)
        Me.Txt_rut.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(522, 61)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Rut"
        '
        'Txt_direccion
        '
        Me.Txt_direccion.Location = New System.Drawing.Point(129, 90)
        Me.Txt_direccion.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_direccion.Name = "Txt_direccion"
        Me.Txt_direccion.Size = New System.Drawing.Size(389, 23)
        Me.Txt_direccion.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Direccion"
        '
        'Txt_razonsocial
        '
        Me.Txt_razonsocial.Location = New System.Drawing.Point(129, 60)
        Me.Txt_razonsocial.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_razonsocial.Name = "Txt_razonsocial"
        Me.Txt_razonsocial.Size = New System.Drawing.Size(389, 23)
        Me.Txt_razonsocial.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Razon Social"
        '
        'Txt_nrofactura
        '
        Me.Txt_nrofactura.Location = New System.Drawing.Point(125, 15)
        Me.Txt_nrofactura.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_nrofactura.Name = "Txt_nrofactura"
        Me.Txt_nrofactura.Size = New System.Drawing.Size(132, 23)
        Me.Txt_nrofactura.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro Factura"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 191)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Dtg_lotes)
        Me.GroupBox2.Location = New System.Drawing.Point(205, 129)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(915, 228)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Dtg_lotes
        '
        Me.Dtg_lotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtg_lotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dtg_lotes.Location = New System.Drawing.Point(4, 19)
        Me.Dtg_lotes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Dtg_lotes.Name = "Dtg_lotes"
        Me.Dtg_lotes.Size = New System.Drawing.Size(907, 206)
        Me.Dtg_lotes.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Txt_liquido)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Txt_garantia)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Txt_ila)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Txt_nrodefacturas)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Txt_lotes)
        Me.GroupBox3.Controls.Add(Me.Txt_comision)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Txt_iva)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Txt_cargo)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Txt_total)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Txt_neto)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(591, 363)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(529, 249)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'Txt_liquido
        '
        Me.Txt_liquido.Location = New System.Drawing.Point(130, 215)
        Me.Txt_liquido.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_liquido.Name = "Txt_liquido"
        Me.Txt_liquido.Size = New System.Drawing.Size(208, 23)
        Me.Txt_liquido.TabIndex = 33
        Me.Txt_liquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 224)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 14)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Liquido"
        '
        'Txt_garantia
        '
        Me.Txt_garantia.Location = New System.Drawing.Point(130, 187)
        Me.Txt_garantia.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_garantia.Name = "Txt_garantia"
        Me.Txt_garantia.Size = New System.Drawing.Size(208, 23)
        Me.Txt_garantia.TabIndex = 31
        Me.Txt_garantia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 196)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 14)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Garantia"
        '
        'Txt_ila
        '
        Me.Txt_ila.Location = New System.Drawing.Point(130, 128)
        Me.Txt_ila.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_ila.Name = "Txt_ila"
        Me.Txt_ila.Size = New System.Drawing.Size(208, 23)
        Me.Txt_ila.TabIndex = 29
        Me.Txt_ila.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 137)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(25, 14)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "ILA"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(347, 55)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 14)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "N° de Fact."
        '
        'Txt_nrodefacturas
        '
        Me.Txt_nrodefacturas.Location = New System.Drawing.Point(451, 51)
        Me.Txt_nrodefacturas.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_nrodefacturas.Name = "Txt_nrodefacturas"
        Me.Txt_nrodefacturas.Size = New System.Drawing.Size(65, 23)
        Me.Txt_nrodefacturas.TabIndex = 27
        Me.Txt_nrodefacturas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.Txt_lotes.Location = New System.Drawing.Point(451, 15)
        Me.Txt_lotes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_lotes.Name = "Txt_lotes"
        Me.Txt_lotes.Size = New System.Drawing.Size(65, 23)
        Me.Txt_lotes.TabIndex = 25
        Me.Txt_lotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_comision
        '
        Me.Txt_comision.Location = New System.Drawing.Point(131, 42)
        Me.Txt_comision.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_comision.Name = "Txt_comision"
        Me.Txt_comision.Size = New System.Drawing.Size(208, 23)
        Me.Txt_comision.TabIndex = 19
        Me.Txt_comision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 51)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 14)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Comision"
        '
        'Txt_iva
        '
        Me.Txt_iva.Location = New System.Drawing.Point(131, 99)
        Me.Txt_iva.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_iva.Name = "Txt_iva"
        Me.Txt_iva.Size = New System.Drawing.Size(208, 23)
        Me.Txt_iva.TabIndex = 17
        Me.Txt_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 79)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 14)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Cargo de Facturacion"
        '
        'Txt_cargo
        '
        Me.Txt_cargo.Location = New System.Drawing.Point(131, 70)
        Me.Txt_cargo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_cargo.Name = "Txt_cargo"
        Me.Txt_cargo.Size = New System.Drawing.Size(208, 23)
        Me.Txt_cargo.TabIndex = 15
        Me.Txt_cargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 108)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 14)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Iva"
        '
        'Txt_total
        '
        Me.Txt_total.Location = New System.Drawing.Point(131, 158)
        Me.Txt_total.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_total.Name = "Txt_total"
        Me.Txt_total.Size = New System.Drawing.Size(208, 23)
        Me.Txt_total.TabIndex = 11
        Me.Txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 167)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 14)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Total"
        '
        'Txt_neto
        '
        Me.Txt_neto.Location = New System.Drawing.Point(131, 15)
        Me.Txt_neto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_neto.Name = "Txt_neto"
        Me.Txt_neto.Size = New System.Drawing.Size(208, 23)
        Me.Txt_neto.TabIndex = 9
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Btn_actualizar)
        Me.GroupBox4.Controls.Add(Me.Lst_clientes)
        Me.GroupBox4.Controls.Add(Me.Lbl_tiporema)
        Me.GroupBox4.Controls.Add(Me.Lbl_fecharema)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Cmb_remates)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(1, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 357)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'Btn_actualizar
        '
        Me.Btn_actualizar.Location = New System.Drawing.Point(7, 146)
        Me.Btn_actualizar.Name = "Btn_actualizar"
        Me.Btn_actualizar.Size = New System.Drawing.Size(186, 23)
        Me.Btn_actualizar.TabIndex = 19
        Me.Btn_actualizar.Text = "Actualizar"
        Me.Btn_actualizar.UseVisualStyleBackColor = True
        '
        'Lst_clientes
        '
        Me.Lst_clientes.FormattingEnabled = True
        Me.Lst_clientes.ItemHeight = 15
        Me.Lst_clientes.Location = New System.Drawing.Point(7, 206)
        Me.Lst_clientes.Name = "Lst_clientes"
        Me.Lst_clientes.Size = New System.Drawing.Size(186, 139)
        Me.Lst_clientes.TabIndex = 18
        '
        'Lbl_tiporema
        '
        Me.Lbl_tiporema.AutoSize = True
        Me.Lbl_tiporema.Location = New System.Drawing.Point(7, 90)
        Me.Lbl_tiporema.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_tiporema.Name = "Lbl_tiporema"
        Me.Lbl_tiporema.Size = New System.Drawing.Size(57, 15)
        Me.Lbl_tiporema.TabIndex = 17
        Me.Lbl_tiporema.Text = "T. Rmte."
        '
        'Lbl_fecharema
        '
        Me.Lbl_fecharema.AutoSize = True
        Me.Lbl_fecharema.Location = New System.Drawing.Point(7, 73)
        Me.Lbl_fecharema.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_fecharema.Name = "Lbl_fecharema"
        Me.Lbl_fecharema.Size = New System.Drawing.Size(56, 15)
        Me.Lbl_fecharema.TabIndex = 16
        Me.Lbl_fecharema.Text = "F. Rmte."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 21)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Remate"
        '
        'Cmb_remates
        '
        Me.Cmb_remates.FormattingEnabled = True
        Me.Cmb_remates.Location = New System.Drawing.Point(7, 39)
        Me.Cmb_remates.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Cmb_remates.Name = "Cmb_remates"
        Me.Cmb_remates.Size = New System.Drawing.Size(186, 23)
        Me.Cmb_remates.TabIndex = 14
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.Btn_imprimir)
        Me.GroupBox5.Location = New System.Drawing.Point(311, 363)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(259, 81)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Rdb_factura)
        Me.GroupBox6.Controls.Add(Me.Rdb_prefactura)
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
        Me.Rdb_factura.Location = New System.Drawing.Point(161, 12)
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
        Me.Rdb_prefactura.Location = New System.Drawing.Point(6, 12)
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
        Me.Btn_imprimir.Location = New System.Drawing.Point(72, 50)
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
        Me.Cmb_pago.Location = New System.Drawing.Point(316, 480)
        Me.Cmb_pago.Name = "Cmb_pago"
        Me.Cmb_pago.Size = New System.Drawing.Size(247, 23)
        Me.Cmb_pago.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(314, 462)
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
        Me.Chk_afecto.Location = New System.Drawing.Point(211, 380)
        Me.Chk_afecto.Name = "Chk_afecto"
        Me.Chk_afecto.Size = New System.Drawing.Size(65, 19)
        Me.Chk_afecto.TabIndex = 21
        Me.Chk_afecto.Text = "Afecto"
        Me.Chk_afecto.UseVisualStyleBackColor = True
        '
        'Chk_cargos
        '
        Me.Chk_cargos.AutoSize = True
        Me.Chk_cargos.Checked = True
        Me.Chk_cargos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_cargos.Location = New System.Drawing.Point(211, 405)
        Me.Chk_cargos.Name = "Chk_cargos"
        Me.Chk_cargos.Size = New System.Drawing.Size(68, 19)
        Me.Chk_cargos.TabIndex = 22
        Me.Chk_cargos.Text = "Cargos"
        Me.Chk_cargos.UseVisualStyleBackColor = True
        '
        'Chk_comision
        '
        Me.Chk_comision.AutoSize = True
        Me.Chk_comision.Checked = True
        Me.Chk_comision.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_comision.Location = New System.Drawing.Point(211, 430)
        Me.Chk_comision.Name = "Chk_comision"
        Me.Chk_comision.Size = New System.Drawing.Size(82, 19)
        Me.Chk_comision.TabIndex = 23
        Me.Chk_comision.Text = "Comision"
        Me.Chk_comision.UseVisualStyleBackColor = True
        '
        'ChkIla
        '
        Me.ChkIla.AutoSize = True
        Me.ChkIla.Location = New System.Drawing.Point(212, 455)
        Me.ChkIla.Name = "ChkIla"
        Me.ChkIla.Size = New System.Drawing.Size(41, 19)
        Me.ChkIla.TabIndex = 24
        Me.ChkIla.Text = "Ila"
        Me.ChkIla.UseVisualStyleBackColor = True
        '
        'Frm_facturaelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1125, 624)
        Me.Controls.Add(Me.ChkIla)
        Me.Controls.Add(Me.Chk_comision)
        Me.Controls.Add(Me.Chk_cargos)
        Me.Controls.Add(Me.Chk_afecto)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Cmb_pago)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Frm_facturaelect"
        Me.Text = "Imprimir"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Dtg_lotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Dtg_lotes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_comision As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Txt_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Txt_cargo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Txt_total As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Txt_neto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_tiporema As System.Windows.Forms.Label
    Friend WithEvents Lbl_fecharema As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Cmb_remates As System.Windows.Forms.ComboBox
    Friend WithEvents Lst_clientes As System.Windows.Forms.ListBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Txt_lotes As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Txt_nrodefacturas As System.Windows.Forms.TextBox
    Friend WithEvents Btn_buscaclientes As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Rdb_factura As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_prefactura As System.Windows.Forms.RadioButton
    Friend WithEvents Btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents Btn_actualizar As System.Windows.Forms.Button
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
    Friend WithEvents Chk_cargos As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_comision As System.Windows.Forms.CheckBox
    Friend WithEvents Txt_ila As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Txt_liquido As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Txt_garantia As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ChkIla As System.Windows.Forms.CheckBox
End Class
