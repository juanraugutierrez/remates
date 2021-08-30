<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_remates
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_remates))
        Me.principal = New System.Windows.Forms.GroupBox()
        Me.Lbl_codigo = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cmb_ejecutivo2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cmb_ejecutivo1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Btn_informes = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Txt_porcefactu = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Txt_pfacturar = New System.Windows.Forms.TextBox()
        Me.Txt_lotesFacturados = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Btn_procesar = New System.Windows.Forms.Button()
        Me.Txt_lotesDesitidos = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Txt_montoFacturado = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Txt_Gimputadaejec2 = New System.Windows.Forms.TextBox()
        Me.Txt_Gimputadaejec1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Txt_GRegistradaejec2 = New System.Windows.Forms.TextBox()
        Me.Txt_GRegistradaejec1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txt_GRejec2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txt_GRejec1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txt_montoAdjudicado = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_lotesSpostor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_lotesAdj = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_nlotes = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Dtp_fecharemate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cmb_tiporemate = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmb_estadoremate = New System.Windows.Forms.ComboBox()
        Me.Btn_adjudicatarios = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Dtg_remates = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Dtp_busca = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtNrembusca = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Btn_eliminar = New System.Windows.Forms.Button()
        Me.Btn_modificar = New System.Windows.Forms.Button()
        Me.Btn_agregar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Rdb_pdf = New System.Windows.Forms.RadioButton()
        Me.Rdb_excel = New System.Windows.Forms.RadioButton()
        Me.principal.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dtg_remates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'principal
        '
        Me.principal.Controls.Add(Me.Lbl_codigo)
        Me.principal.Controls.Add(Me.GroupBox5)
        Me.principal.Controls.Add(Me.Label6)
        Me.principal.Controls.Add(Me.Cmb_ejecutivo2)
        Me.principal.Controls.Add(Me.Label5)
        Me.principal.Controls.Add(Me.Cmb_ejecutivo1)
        Me.principal.Controls.Add(Me.GroupBox4)
        Me.principal.Controls.Add(Me.Txt_direccion)
        Me.principal.Controls.Add(Me.Label4)
        Me.principal.Controls.Add(Me.Label3)
        Me.principal.Controls.Add(Me.Dtp_fecharemate)
        Me.principal.Controls.Add(Me.Label2)
        Me.principal.Controls.Add(Me.Cmb_tiporemate)
        Me.principal.Controls.Add(Me.Label1)
        Me.principal.Controls.Add(Me.Cmb_estadoremate)
        Me.principal.Location = New System.Drawing.Point(5, 3)
        Me.principal.Name = "principal"
        Me.principal.Size = New System.Drawing.Size(1015, 239)
        Me.principal.TabIndex = 0
        Me.principal.TabStop = False
        '
        'Lbl_codigo
        '
        Me.Lbl_codigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbl_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_codigo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_codigo.Location = New System.Drawing.Point(6, 10)
        Me.Lbl_codigo.Name = "Lbl_codigo"
        Me.Lbl_codigo.Size = New System.Drawing.Size(315, 40)
        Me.Lbl_codigo.TabIndex = 17
        Me.Lbl_codigo.Text = "Label21"
        Me.Lbl_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button6)
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 175)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(446, 59)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(365, 23)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "Cierre"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(252, 23)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Papeles"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(171, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Boletas"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(90, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Catalogo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Martillero"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "EJECUTIVO 2"
        '
        'Cmb_ejecutivo2
        '
        Me.Cmb_ejecutivo2.FormattingEnabled = True
        Me.Cmb_ejecutivo2.Location = New System.Drawing.Point(7, 154)
        Me.Cmb_ejecutivo2.Name = "Cmb_ejecutivo2"
        Me.Cmb_ejecutivo2.Size = New System.Drawing.Size(160, 21)
        Me.Cmb_ejecutivo2.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "EJECUTIVO 1"
        '
        'Cmb_ejecutivo1
        '
        Me.Cmb_ejecutivo1.FormattingEnabled = True
        Me.Cmb_ejecutivo1.Location = New System.Drawing.Point(6, 112)
        Me.Cmb_ejecutivo1.Name = "Cmb_ejecutivo1"
        Me.Cmb_ejecutivo1.Size = New System.Drawing.Size(161, 21)
        Me.Cmb_ejecutivo1.TabIndex = 9
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Btn_informes)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Txt_porcefactu)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Txt_pfacturar)
        Me.GroupBox4.Controls.Add(Me.Txt_lotesFacturados)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Btn_procesar)
        Me.GroupBox4.Controls.Add(Me.Txt_lotesDesitidos)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Txt_montoFacturado)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Txt_Gimputadaejec2)
        Me.GroupBox4.Controls.Add(Me.Txt_Gimputadaejec1)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Txt_GRegistradaejec2)
        Me.GroupBox4.Controls.Add(Me.Txt_GRegistradaejec1)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Txt_GRejec2)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Txt_GRejec1)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Txt_montoAdjudicado)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Txt_lotesSpostor)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Txt_lotesAdj)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Txt_nlotes)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(547, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(465, 223)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        '
        'Btn_informes
        '
        Me.Btn_informes.Location = New System.Drawing.Point(297, 198)
        Me.Btn_informes.Name = "Btn_informes"
        Me.Btn_informes.Size = New System.Drawing.Size(75, 23)
        Me.Btn_informes.TabIndex = 39
        Me.Btn_informes.Text = "Informe"
        Me.Btn_informes.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(336, 149)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 13)
        Me.Label23.TabIndex = 38
        Me.Label23.Text = "% Facturado"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Txt_porcefactu
        '
        Me.Txt_porcefactu.Location = New System.Drawing.Point(339, 165)
        Me.Txt_porcefactu.Name = "Txt_porcefactu"
        Me.Txt_porcefactu.Size = New System.Drawing.Size(84, 20)
        Me.Txt_porcefactu.TabIndex = 37
        Me.Txt_porcefactu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(87, 187)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 13)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "Por Facturar"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Txt_pfacturar
        '
        Me.Txt_pfacturar.Location = New System.Drawing.Point(90, 201)
        Me.Txt_pfacturar.Name = "Txt_pfacturar"
        Me.Txt_pfacturar.Size = New System.Drawing.Size(120, 20)
        Me.Txt_pfacturar.TabIndex = 35
        Me.Txt_pfacturar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_lotesFacturados
        '
        Me.Txt_lotesFacturados.Location = New System.Drawing.Point(361, 61)
        Me.Txt_lotesFacturados.Name = "Txt_lotesFacturados"
        Me.Txt_lotesFacturados.Size = New System.Drawing.Size(86, 20)
        Me.Txt_lotesFacturados.TabIndex = 34
        Me.Txt_lotesFacturados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(231, 64)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(122, 13)
        Me.Label21.TabIndex = 33
        Me.Label21.Text = "N° de Lotes  Facturados"
        '
        'Btn_procesar
        '
        Me.Btn_procesar.Location = New System.Drawing.Point(216, 198)
        Me.Btn_procesar.Name = "Btn_procesar"
        Me.Btn_procesar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_procesar.TabIndex = 32
        Me.Btn_procesar.Text = "Procesar"
        Me.Btn_procesar.UseVisualStyleBackColor = True
        '
        'Txt_lotesDesitidos
        '
        Me.Txt_lotesDesitidos.Location = New System.Drawing.Point(361, 35)
        Me.Txt_lotesDesitidos.Name = "Txt_lotesDesitidos"
        Me.Txt_lotesDesitidos.Size = New System.Drawing.Size(86, 20)
        Me.Txt_lotesDesitidos.TabIndex = 31
        Me.Txt_lotesDesitidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(231, 38)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(99, 13)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "N° Lotes Desistidos"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(213, 149)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 13)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Facturado"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Txt_montoFacturado
        '
        Me.Txt_montoFacturado.Location = New System.Drawing.Point(216, 165)
        Me.Txt_montoFacturado.Name = "Txt_montoFacturado"
        Me.Txt_montoFacturado.Size = New System.Drawing.Size(120, 20)
        Me.Txt_montoFacturado.TabIndex = 28
        Me.Txt_montoFacturado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(87, 149)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Adjudicado"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Txt_Gimputadaejec2
        '
        Me.Txt_Gimputadaejec2.Location = New System.Drawing.Point(291, 127)
        Me.Txt_Gimputadaejec2.Name = "Txt_Gimputadaejec2"
        Me.Txt_Gimputadaejec2.Size = New System.Drawing.Size(86, 20)
        Me.Txt_Gimputadaejec2.TabIndex = 26
        Me.Txt_Gimputadaejec2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_Gimputadaejec1
        '
        Me.Txt_Gimputadaejec1.Location = New System.Drawing.Point(291, 104)
        Me.Txt_Gimputadaejec1.Name = "Txt_Gimputadaejec1"
        Me.Txt_Gimputadaejec1.Size = New System.Drawing.Size(86, 20)
        Me.Txt_Gimputadaejec1.TabIndex = 25
        Me.Txt_Gimputadaejec1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(285, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Garantia Imputada"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Txt_GRegistradaejec2
        '
        Me.Txt_GRegistradaejec2.Location = New System.Drawing.Point(184, 126)
        Me.Txt_GRegistradaejec2.Name = "Txt_GRegistradaejec2"
        Me.Txt_GRegistradaejec2.Size = New System.Drawing.Size(86, 20)
        Me.Txt_GRegistradaejec2.TabIndex = 23
        Me.Txt_GRegistradaejec2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_GRegistradaejec1
        '
        Me.Txt_GRegistradaejec1.Location = New System.Drawing.Point(184, 103)
        Me.Txt_GRegistradaejec1.Name = "Txt_GRegistradaejec1"
        Me.Txt_GRegistradaejec1.Size = New System.Drawing.Size(86, 20)
        Me.Txt_GRegistradaejec1.TabIndex = 22
        Me.Txt_GRegistradaejec1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(178, 87)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Garantia Depositada"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Ejecutivo N° 2"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Txt_GRejec2
        '
        Me.Txt_GRejec2.Location = New System.Drawing.Point(90, 127)
        Me.Txt_GRejec2.Name = "Txt_GRejec2"
        Me.Txt_GRejec2.Size = New System.Drawing.Size(86, 20)
        Me.Txt_GRejec2.TabIndex = 19
        Me.Txt_GRejec2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Ejecutivo N° 2"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Txt_GRejec1
        '
        Me.Txt_GRejec1.Location = New System.Drawing.Point(90, 104)
        Me.Txt_GRejec1.Name = "Txt_GRejec1"
        Me.Txt_GRejec1.Size = New System.Drawing.Size(86, 20)
        Me.Txt_GRejec1.TabIndex = 17
        Me.Txt_GRejec1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(87, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Garantia Recibida "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Txt_montoAdjudicado
        '
        Me.Txt_montoAdjudicado.Location = New System.Drawing.Point(90, 165)
        Me.Txt_montoAdjudicado.Name = "Txt_montoAdjudicado"
        Me.Txt_montoAdjudicado.Size = New System.Drawing.Size(120, 20)
        Me.Txt_montoAdjudicado.TabIndex = 15
        Me.Txt_montoAdjudicado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Montos"
        '
        'Txt_lotesSpostor
        '
        Me.Txt_lotesSpostor.Location = New System.Drawing.Point(139, 58)
        Me.Txt_lotesSpostor.Name = "Txt_lotesSpostor"
        Me.Txt_lotesSpostor.Size = New System.Drawing.Size(86, 20)
        Me.Txt_lotesSpostor.TabIndex = 13
        Me.Txt_lotesSpostor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "N° de Lotes  Sin Postor"
        '
        'Txt_lotesAdj
        '
        Me.Txt_lotesAdj.Location = New System.Drawing.Point(139, 35)
        Me.Txt_lotesAdj.Name = "Txt_lotesAdj"
        Me.Txt_lotesAdj.Size = New System.Drawing.Size(86, 20)
        Me.Txt_lotesAdj.TabIndex = 11
        Me.Txt_lotesAdj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "N° deLotes  Adjudicados"
        '
        'Txt_nlotes
        '
        Me.Txt_nlotes.Location = New System.Drawing.Point(139, 9)
        Me.Txt_nlotes.Name = "Txt_nlotes"
        Me.Txt_nlotes.Size = New System.Drawing.Size(86, 20)
        Me.Txt_nlotes.TabIndex = 9
        Me.Txt_nlotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "N° de Lotes"
        '
        'Txt_direccion
        '
        Me.Txt_direccion.Location = New System.Drawing.Point(7, 67)
        Me.Txt_direccion.Name = "Txt_direccion"
        Me.Txt_direccion.Size = New System.Drawing.Size(317, 20)
        Me.Txt_direccion.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Direccion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha del Remate"
        '
        'Dtp_fecharemate
        '
        Me.Dtp_fecharemate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_fecharemate.Location = New System.Drawing.Point(329, 115)
        Me.Dtp_fecharemate.Name = "Dtp_fecharemate"
        Me.Dtp_fecharemate.Size = New System.Drawing.Size(212, 20)
        Me.Dtp_fecharemate.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(328, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo de Remate"
        '
        'Cmb_tiporemate
        '
        Me.Cmb_tiporemate.FormattingEnabled = True
        Me.Cmb_tiporemate.Location = New System.Drawing.Point(330, 67)
        Me.Cmb_tiporemate.Name = "Cmb_tiporemate"
        Me.Cmb_tiporemate.Size = New System.Drawing.Size(212, 21)
        Me.Cmb_tiporemate.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(327, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Estado de Remate"
        '
        'Cmb_estadoremate
        '
        Me.Cmb_estadoremate.FormattingEnabled = True
        Me.Cmb_estadoremate.Location = New System.Drawing.Point(329, 26)
        Me.Cmb_estadoremate.Name = "Cmb_estadoremate"
        Me.Cmb_estadoremate.Size = New System.Drawing.Size(212, 21)
        Me.Cmb_estadoremate.TabIndex = 0
        '
        'Btn_adjudicatarios
        '
        Me.Btn_adjudicatarios.Location = New System.Drawing.Point(229, 19)
        Me.Btn_adjudicatarios.Name = "Btn_adjudicatarios"
        Me.Btn_adjudicatarios.Size = New System.Drawing.Size(86, 23)
        Me.Btn_adjudicatarios.TabIndex = 21
        Me.Btn_adjudicatarios.Text = "Adjudicatarios"
        Me.Btn_adjudicatarios.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Dtg_remates)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 407)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1015, 239)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Dtg_remates
        '
        Me.Dtg_remates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtg_remates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dtg_remates.Location = New System.Drawing.Point(3, 16)
        Me.Dtg_remates.Name = "Dtg_remates"
        Me.Dtg_remates.Size = New System.Drawing.Size(1009, 220)
        Me.Dtg_remates.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dtp_busca)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.TxtNrembusca)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Btn_eliminar)
        Me.GroupBox3.Controls.Add(Me.Btn_modificar)
        Me.GroupBox3.Controls.Add(Me.Btn_agregar)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 330)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1015, 79)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'Dtp_busca
        '
        Me.Dtp_busca.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_busca.Location = New System.Drawing.Point(755, 47)
        Me.Dtp_busca.Name = "Dtp_busca"
        Me.Dtp_busca.Size = New System.Drawing.Size(135, 20)
        Me.Dtp_busca.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(659, 54)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(92, 13)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "Fecha de Remate"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(895, 48)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "Buscar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(659, 28)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 13)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "N° de Remate"
        '
        'TxtNrembusca
        '
        Me.TxtNrembusca.Location = New System.Drawing.Point(755, 22)
        Me.TxtNrembusca.Name = "TxtNrembusca"
        Me.TxtNrembusca.Size = New System.Drawing.Size(135, 20)
        Me.TxtNrembusca.TabIndex = 9
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(895, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Buscar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Btn_eliminar
        '
        Me.Btn_eliminar.Location = New System.Drawing.Point(228, 28)
        Me.Btn_eliminar.Name = "Btn_eliminar"
        Me.Btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_eliminar.TabIndex = 7
        Me.Btn_eliminar.Text = "Eliminar"
        Me.Btn_eliminar.UseVisualStyleBackColor = True
        '
        'Btn_modificar
        '
        Me.Btn_modificar.Location = New System.Drawing.Point(135, 28)
        Me.Btn_modificar.Name = "Btn_modificar"
        Me.Btn_modificar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_modificar.TabIndex = 6
        Me.Btn_modificar.Text = "Modificar"
        Me.Btn_modificar.UseVisualStyleBackColor = True
        '
        'Btn_agregar
        '
        Me.Btn_agregar.Location = New System.Drawing.Point(44, 28)
        Me.Btn_agregar.Name = "Btn_agregar"
        Me.Btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_agregar.TabIndex = 5
        Me.Btn_agregar.Text = "Agregar"
        Me.Btn_agregar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_adjudicatarios)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 246)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1015, 79)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Rdb_pdf)
        Me.GroupBox6.Controls.Add(Me.Rdb_excel)
        Me.GroupBox6.Location = New System.Drawing.Point(4, 10)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 62)
        Me.GroupBox6.TabIndex = 23
        Me.GroupBox6.TabStop = False
        '
        'Rdb_pdf
        '
        Me.Rdb_pdf.AutoSize = True
        Me.Rdb_pdf.Checked = True
        Me.Rdb_pdf.Location = New System.Drawing.Point(113, 22)
        Me.Rdb_pdf.Name = "Rdb_pdf"
        Me.Rdb_pdf.Size = New System.Drawing.Size(41, 17)
        Me.Rdb_pdf.TabIndex = 25
        Me.Rdb_pdf.TabStop = True
        Me.Rdb_pdf.Text = "Pdf"
        Me.Rdb_pdf.UseVisualStyleBackColor = True
        '
        'Rdb_excel
        '
        Me.Rdb_excel.AutoSize = True
        Me.Rdb_excel.Location = New System.Drawing.Point(17, 22)
        Me.Rdb_excel.Name = "Rdb_excel"
        Me.Rdb_excel.Size = New System.Drawing.Size(51, 17)
        Me.Rdb_excel.TabIndex = 24
        Me.Rdb_excel.TabStop = True
        Me.Rdb_excel.Text = "Excel"
        Me.Rdb_excel.UseVisualStyleBackColor = True
        '
        'Frm_remates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1023, 650)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.principal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_remates"
        Me.Text = "Mantenedor de Remates"
        Me.principal.ResumeLayout(False)
        Me.principal.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Dtg_remates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents principal As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Dtg_remates As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNrembusca As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents Btn_modificar As System.Windows.Forms.Button
    Friend WithEvents Btn_agregar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Dtp_fecharemate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cmb_tiporemate As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cmb_estadoremate As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cmb_ejecutivo2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Cmb_ejecutivo1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_procesar As System.Windows.Forms.Button
    Friend WithEvents Txt_lotesDesitidos As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Txt_montoFacturado As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Txt_Gimputadaejec2 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Gimputadaejec1 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Txt_GRegistradaejec2 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_GRegistradaejec1 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Txt_GRejec2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Txt_GRejec1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Txt_montoAdjudicado As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Txt_lotesSpostor As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Txt_lotesAdj As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Txt_nlotes As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Dtp_busca As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Lbl_codigo As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Txt_pfacturar As System.Windows.Forms.TextBox
    Friend WithEvents Txt_lotesFacturados As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Txt_porcefactu As System.Windows.Forms.TextBox
    Friend WithEvents Btn_informes As System.Windows.Forms.Button
    Friend WithEvents Btn_adjudicatarios As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Rdb_pdf As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_excel As System.Windows.Forms.RadioButton
End Class
