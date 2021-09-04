<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_liquidacionElectre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_liquidacionElectre))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_limpiar = New System.Windows.Forms.Button()
        Me.Btn_buscar = New System.Windows.Forms.Button()
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
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Txt_nrliqui = New System.Windows.Forms.TextBox()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Cmb_remates = New System.Windows.Forms.ComboBox()
        Me.Lbl_tiporema = New System.Windows.Forms.Label()
        Me.Lbl_fecharema = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Rdb_mandante = New System.Windows.Forms.RadioButton()
        Me.Rdb_remate = New System.Windows.Forms.RadioButton()
        Me.Lst_clientes = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_porcentaje = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Chk_detalle = New System.Windows.Forms.CheckBox()
        Me.Btn_recalcular = New System.Windows.Forms.Button()
        Me.Chk_afecto = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Mth_calendario = New System.Windows.Forms.MonthCalendar()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Btn_informe = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dtg_lotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_limpiar)
        Me.GroupBox1.Controls.Add(Me.Btn_buscar)
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
        Me.GroupBox1.Location = New System.Drawing.Point(245, -1)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(958, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Btn_limpiar
        '
        Me.Btn_limpiar.Location = New System.Drawing.Point(862, 87)
        Me.Btn_limpiar.Name = "Btn_limpiar"
        Me.Btn_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_limpiar.TabIndex = 13
        Me.Btn_limpiar.Text = "Limpiar"
        Me.Btn_limpiar.UseVisualStyleBackColor = True
        '
        'Btn_buscar
        '
        Me.Btn_buscar.Location = New System.Drawing.Point(862, 52)
        Me.Btn_buscar.Name = "Btn_buscar"
        Me.Btn_buscar.Size = New System.Drawing.Size(75, 24)
        Me.Btn_buscar.TabIndex = 12
        Me.Btn_buscar.Text = "Buscar"
        Me.Btn_buscar.UseVisualStyleBackColor = True
        '
        'Txt_Comuna
        '
        Me.Txt_Comuna.Location = New System.Drawing.Point(647, 89)
        Me.Txt_Comuna.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_Comuna.Name = "Txt_Comuna"
        Me.Txt_Comuna.Size = New System.Drawing.Size(208, 23)
        Me.Txt_Comuna.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(575, 91)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Comuna"
        '
        'Txt_giro
        '
        Me.Txt_giro.Location = New System.Drawing.Point(320, 15)
        Me.Txt_giro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_giro.Name = "Txt_giro"
        Me.Txt_giro.Size = New System.Drawing.Size(295, 23)
        Me.Txt_giro.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(282, 18)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Giro"
        '
        'Txt_rut
        '
        Me.Txt_rut.Location = New System.Drawing.Point(647, 51)
        Me.Txt_rut.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_rut.Name = "Txt_rut"
        Me.Txt_rut.Size = New System.Drawing.Size(208, 23)
        Me.Txt_rut.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(575, 59)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Rut"
        '
        'Txt_direccion
        '
        Me.Txt_direccion.Location = New System.Drawing.Point(93, 90)
        Me.Txt_direccion.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_direccion.Name = "Txt_direccion"
        Me.Txt_direccion.Size = New System.Drawing.Size(473, 23)
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
        Me.Txt_razonsocial.Location = New System.Drawing.Point(93, 60)
        Me.Txt_razonsocial.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_razonsocial.Name = "Txt_razonsocial"
        Me.Txt_razonsocial.Size = New System.Drawing.Size(473, 23)
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
        Me.Txt_nrofactura.Location = New System.Drawing.Point(110, 15)
        Me.Txt_nrofactura.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_nrofactura.Name = "Txt_nrofactura"
        Me.Txt_nrofactura.Size = New System.Drawing.Size(151, 23)
        Me.Txt_nrofactura.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro Liquidacion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 188)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Mandante"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Dtg_lotes)
        Me.GroupBox2.Location = New System.Drawing.Point(242, 130)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(919, 251)
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
        Me.Dtg_lotes.Size = New System.Drawing.Size(911, 229)
        Me.Dtg_lotes.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Txt_nrliqui)
        Me.GroupBox3.Controls.Add(Me.Txt_ila)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Txt_publicidad)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Txt_fletes)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Txt_lotes)
        Me.GroupBox3.Controls.Add(Me.Txt_liquido)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Txt_impuestorec)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Txt_comision)
        Me.GroupBox3.Controls.Add(Me.Txt_iva)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Txt_neto)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(630, 388)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(490, 247)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(347, 51)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 14)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "N° de Liqu."
        '
        'Txt_nrliqui
        '
        Me.Txt_nrliqui.Location = New System.Drawing.Point(421, 47)
        Me.Txt_nrliqui.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_nrliqui.Name = "Txt_nrliqui"
        Me.Txt_nrliqui.Size = New System.Drawing.Size(65, 23)
        Me.Txt_nrliqui.TabIndex = 33
        '
        'Txt_ila
        '
        Me.Txt_ila.Location = New System.Drawing.Point(131, 127)
        Me.Txt_ila.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_ila.Name = "Txt_ila"
        Me.Txt_ila.Size = New System.Drawing.Size(208, 23)
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
        Me.Txt_publicidad.Size = New System.Drawing.Size(208, 23)
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
        Me.Txt_fletes.Size = New System.Drawing.Size(208, 23)
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
        Me.Txt_lotes.Size = New System.Drawing.Size(65, 23)
        Me.Txt_lotes.TabIndex = 25
        '
        'Txt_liquido
        '
        Me.Txt_liquido.Location = New System.Drawing.Point(131, 214)
        Me.Txt_liquido.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_liquido.Name = "Txt_liquido"
        Me.Txt_liquido.Size = New System.Drawing.Size(208, 23)
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
        Me.Txt_impuestorec.Size = New System.Drawing.Size(208, 23)
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
        Me.Txt_comision.Size = New System.Drawing.Size(208, 23)
        Me.Txt_comision.TabIndex = 15
        Me.Txt_comision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_iva
        '
        Me.Txt_iva.Location = New System.Drawing.Point(131, 98)
        Me.Txt_iva.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_iva.Name = "Txt_iva"
        Me.Txt_iva.Size = New System.Drawing.Size(208, 23)
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
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(508, 489)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.Lst_clientes)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(2, -1)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(238, 611)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 366)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(226, 233)
        Me.DataGridView1.TabIndex = 21
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Cmb_remates)
        Me.GroupBox6.Controls.Add(Me.Lbl_tiporema)
        Me.GroupBox6.Controls.Add(Me.Lbl_fecharema)
        Me.GroupBox6.Location = New System.Drawing.Point(9, 84)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(229, 101)
        Me.GroupBox6.TabIndex = 20
        Me.GroupBox6.TabStop = False
        '
        'Cmb_remates
        '
        Me.Cmb_remates.FormattingEnabled = True
        Me.Cmb_remates.Location = New System.Drawing.Point(7, 21)
        Me.Cmb_remates.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Cmb_remates.Name = "Cmb_remates"
        Me.Cmb_remates.Size = New System.Drawing.Size(186, 23)
        Me.Cmb_remates.TabIndex = 14
        '
        'Lbl_tiporema
        '
        Me.Lbl_tiporema.AutoSize = True
        Me.Lbl_tiporema.Location = New System.Drawing.Point(7, 74)
        Me.Lbl_tiporema.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_tiporema.Name = "Lbl_tiporema"
        Me.Lbl_tiporema.Size = New System.Drawing.Size(83, 15)
        Me.Lbl_tiporema.TabIndex = 17
        Me.Lbl_tiporema.Text = "Tipo Remate"
        '
        'Lbl_fecharema
        '
        Me.Lbl_fecharema.AutoSize = True
        Me.Lbl_fecharema.Location = New System.Drawing.Point(7, 50)
        Me.Lbl_fecharema.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_fecharema.Name = "Lbl_fecharema"
        Me.Lbl_fecharema.Size = New System.Drawing.Size(92, 15)
        Me.Lbl_fecharema.TabIndex = 16
        Me.Lbl_fecharema.Text = "Fecha Remate"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Rdb_mandante)
        Me.GroupBox5.Controls.Add(Me.Rdb_remate)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 11)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(229, 72)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        '
        'Rdb_mandante
        '
        Me.Rdb_mandante.AutoSize = True
        Me.Rdb_mandante.Location = New System.Drawing.Point(67, 41)
        Me.Rdb_mandante.Name = "Rdb_mandante"
        Me.Rdb_mandante.Size = New System.Drawing.Size(106, 19)
        Me.Rdb_mandante.TabIndex = 1
        Me.Rdb_mandante.Text = "Por Mandante"
        Me.Rdb_mandante.UseVisualStyleBackColor = True
        '
        'Rdb_remate
        '
        Me.Rdb_remate.AutoSize = True
        Me.Rdb_remate.Checked = True
        Me.Rdb_remate.Location = New System.Drawing.Point(67, 22)
        Me.Rdb_remate.Name = "Rdb_remate"
        Me.Rdb_remate.Size = New System.Drawing.Size(95, 19)
        Me.Rdb_remate.TabIndex = 0
        Me.Rdb_remate.TabStop = True
        Me.Rdb_remate.Text = "Por Remate"
        Me.Rdb_remate.UseVisualStyleBackColor = True
        '
        'Lst_clientes
        '
        Me.Lst_clientes.FormattingEnabled = True
        Me.Lst_clientes.ItemHeight = 15
        Me.Lst_clientes.Location = New System.Drawing.Point(7, 206)
        Me.Lst_clientes.Name = "Lst_clientes"
        Me.Lst_clientes.Size = New System.Drawing.Size(225, 154)
        Me.Lst_clientes.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 142)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Remate"
        '
        'Txt_porcentaje
        '
        Me.Txt_porcentaje.Location = New System.Drawing.Point(508, 441)
        Me.Txt_porcentaje.Name = "Txt_porcentaje"
        Me.Txt_porcentaje.Size = New System.Drawing.Size(100, 23)
        Me.Txt_porcentaje.TabIndex = 5
        Me.Txt_porcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(505, 424)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 14)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "% Comision"
        '
        'Chk_detalle
        '
        Me.Chk_detalle.AutoSize = True
        Me.Chk_detalle.Location = New System.Drawing.Point(511, 406)
        Me.Chk_detalle.Name = "Chk_detalle"
        Me.Chk_detalle.Size = New System.Drawing.Size(119, 19)
        Me.Chk_detalle.TabIndex = 20
        Me.Chk_detalle.Text = "Detalle Adjunto"
        Me.Chk_detalle.UseVisualStyleBackColor = True
        '
        'Btn_recalcular
        '
        Me.Btn_recalcular.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_recalcular.Location = New System.Drawing.Point(508, 464)
        Me.Btn_recalcular.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_recalcular.Name = "Btn_recalcular"
        Me.Btn_recalcular.Size = New System.Drawing.Size(100, 27)
        Me.Btn_recalcular.TabIndex = 21
        Me.Btn_recalcular.Text = "Recalcular"
        Me.Btn_recalcular.UseVisualStyleBackColor = True
        '
        'Chk_afecto
        '
        Me.Chk_afecto.AutoSize = True
        Me.Chk_afecto.Checked = True
        Me.Chk_afecto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_afecto.Location = New System.Drawing.Point(430, 405)
        Me.Chk_afecto.Name = "Chk_afecto"
        Me.Chk_afecto.Size = New System.Drawing.Size(72, 19)
        Me.Chk_afecto.TabIndex = 22
        Me.Chk_afecto.Text = "Afectos"
        Me.Chk_afecto.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(508, 515)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 53)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Vista Preliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Mth_calendario
        '
        Me.Mth_calendario.Location = New System.Drawing.Point(247, 430)
        Me.Mth_calendario.Name = "Mth_calendario"
        Me.Mth_calendario.TabIndex = 25
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(243, 408)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(122, 14)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Fecha de Liquidacion"
        '
        'Btn_informe
        '
        Me.Btn_informe.BackColor = System.Drawing.Color.SkyBlue
        Me.Btn_informe.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_informe.Image = CType(resources.GetObject("Btn_informe.Image"), System.Drawing.Image)
        Me.Btn_informe.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_informe.Location = New System.Drawing.Point(508, 566)
        Me.Btn_informe.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_informe.Name = "Btn_informe"
        Me.Btn_informe.Size = New System.Drawing.Size(100, 61)
        Me.Btn_informe.TabIndex = 30
        Me.Btn_informe.Text = "Informe de Liquidacion"
        Me.Btn_informe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_informe.UseVisualStyleBackColor = False
        '
        'Frm_liquidacionElectre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1209, 641)
        Me.Controls.Add(Me.Btn_informe)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Mth_calendario)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Chk_afecto)
        Me.Controls.Add(Me.Btn_recalcular)
        Me.Controls.Add(Me.Chk_detalle)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Txt_porcentaje)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Frm_liquidacionElectre"
        Me.Text = "Imprimir"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Dtg_lotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
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
    Friend WithEvents Txt_impuestorec As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Txt_comision As System.Windows.Forms.TextBox
    Friend WithEvents Txt_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Txt_neto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_tiporema As System.Windows.Forms.Label
    Friend WithEvents Lbl_fecharema As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Cmb_remates As System.Windows.Forms.ComboBox
    Friend WithEvents Lst_clientes As System.Windows.Forms.ListBox
    Friend WithEvents Txt_liquido As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Txt_lotes As System.Windows.Forms.TextBox
    Friend WithEvents Txt_porcentaje As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Txt_publicidad As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Txt_fletes As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Chk_detalle As System.Windows.Forms.CheckBox
    Friend WithEvents Btn_recalcular As System.Windows.Forms.Button
    Friend WithEvents Chk_afecto As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Rdb_mandante As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_remate As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Btn_limpiar As System.Windows.Forms.Button
    Public WithEvents Txt_rut As System.Windows.Forms.TextBox
    Public WithEvents Txt_direccion As System.Windows.Forms.TextBox
    Public WithEvents Txt_razonsocial As System.Windows.Forms.TextBox
    Public WithEvents Txt_Comuna As System.Windows.Forms.TextBox
    Public WithEvents Txt_giro As System.Windows.Forms.TextBox
    Friend WithEvents Txt_ila As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Mth_calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Txt_nrliqui As System.Windows.Forms.TextBox
    Friend WithEvents Btn_informe As System.Windows.Forms.Button
End Class
