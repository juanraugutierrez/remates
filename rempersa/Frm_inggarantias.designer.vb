<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_inggarantias
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Txt_fecha = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cmb_remate = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Lbl_totefec = New System.Windows.Forms.Label()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Lbl5 = New System.Windows.Forms.Label()
        Me.Lbl10 = New System.Windows.Forms.Label()
        Me.Lbl50 = New System.Windows.Forms.Label()
        Me.Lbl100 = New System.Windows.Forms.Label()
        Me.Lbl500 = New System.Windows.Forms.Label()
        Me.Lbl1m = New System.Windows.Forms.Label()
        Me.Lbl2m = New System.Windows.Forms.Label()
        Me.Lbl5m = New System.Windows.Forms.Label()
        Me.Lbl10m = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Txt5 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Txt10 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txt50 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txt100 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txt500 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt1m = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt2m = New System.Windows.Forms.TextBox()
        Me.Txt5m = New System.Windows.Forms.TextBox()
        Me.Txt10m = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl20m = New System.Windows.Forms.Label()
        Me.Txt20m = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_ejecutivo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Rdb_impar = New System.Windows.Forms.RadioButton()
        Me.Rdb_par = New System.Windows.Forms.RadioButton()
        Me.Facturas = New System.Windows.Forms.GroupBox()
        Me.Dtg_garantias = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_totlotes = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lbl_nlotes = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Facturas.SuspendLayout()
        CType(Me.Dtg_garantias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Txt_fecha)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Cmb_remate)
        Me.GroupBox4.Location = New System.Drawing.Point(4, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(266, 129)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        '
        'Txt_fecha
        '
        Me.Txt_fecha.Location = New System.Drawing.Point(36, 76)
        Me.Txt_fecha.Name = "Txt_fecha"
        Me.Txt_fecha.Size = New System.Drawing.Size(195, 20)
        Me.Txt_fecha.TabIndex = 18
        Me.Txt_fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Fecha del Remate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Remate"
        '
        'Cmb_remate
        '
        Me.Cmb_remate.FormattingEnabled = True
        Me.Cmb_remate.Location = New System.Drawing.Point(35, 26)
        Me.Cmb_remate.Name = "Cmb_remate"
        Me.Cmb_remate.Size = New System.Drawing.Size(196, 21)
        Me.Cmb_remate.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Lbl_totefec)
        Me.GroupBox2.Controls.Add(Me.Lbl1)
        Me.GroupBox2.Controls.Add(Me.Lbl5)
        Me.GroupBox2.Controls.Add(Me.Lbl10)
        Me.GroupBox2.Controls.Add(Me.Lbl50)
        Me.GroupBox2.Controls.Add(Me.Lbl100)
        Me.GroupBox2.Controls.Add(Me.Lbl500)
        Me.GroupBox2.Controls.Add(Me.Lbl1m)
        Me.GroupBox2.Controls.Add(Me.Lbl2m)
        Me.GroupBox2.Controls.Add(Me.Lbl5m)
        Me.GroupBox2.Controls.Add(Me.Lbl10m)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Txt1)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Txt5)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Txt10)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Txt50)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Txt100)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Txt500)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Txt1m)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Txt2m)
        Me.GroupBox2.Controls.Add(Me.Txt5m)
        Me.GroupBox2.Controls.Add(Me.Txt10m)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Lbl20m)
        Me.GroupBox2.Controls.Add(Me.Txt20m)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(683, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 336)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Efectivo"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(45, 309)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 20)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "Total"
        '
        'Lbl_totefec
        '
        Me.Lbl_totefec.AutoSize = True
        Me.Lbl_totefec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_totefec.Location = New System.Drawing.Point(158, 309)
        Me.Lbl_totefec.Name = "Lbl_totefec"
        Me.Lbl_totefec.Size = New System.Drawing.Size(70, 20)
        Me.Lbl_totefec.TabIndex = 38
        Me.Lbl_totefec.Text = "$      0.-"
        Me.Lbl_totefec.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Location = New System.Drawing.Point(183, 260)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(43, 13)
        Me.Lbl1.TabIndex = 37
        Me.Lbl1.Text = "$      0.-"
        Me.Lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl5
        '
        Me.Lbl5.AutoSize = True
        Me.Lbl5.Location = New System.Drawing.Point(183, 237)
        Me.Lbl5.Name = "Lbl5"
        Me.Lbl5.Size = New System.Drawing.Size(43, 13)
        Me.Lbl5.TabIndex = 36
        Me.Lbl5.Text = "$      0.-"
        Me.Lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl10
        '
        Me.Lbl10.AutoSize = True
        Me.Lbl10.Location = New System.Drawing.Point(183, 215)
        Me.Lbl10.Name = "Lbl10"
        Me.Lbl10.Size = New System.Drawing.Size(43, 13)
        Me.Lbl10.TabIndex = 35
        Me.Lbl10.Text = "$      0.-"
        Me.Lbl10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl50
        '
        Me.Lbl50.AutoSize = True
        Me.Lbl50.Location = New System.Drawing.Point(183, 192)
        Me.Lbl50.Name = "Lbl50"
        Me.Lbl50.Size = New System.Drawing.Size(43, 13)
        Me.Lbl50.TabIndex = 34
        Me.Lbl50.Text = "$      0.-"
        Me.Lbl50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl100
        '
        Me.Lbl100.AutoSize = True
        Me.Lbl100.Location = New System.Drawing.Point(183, 171)
        Me.Lbl100.Name = "Lbl100"
        Me.Lbl100.Size = New System.Drawing.Size(43, 13)
        Me.Lbl100.TabIndex = 33
        Me.Lbl100.Text = "$      0.-"
        Me.Lbl100.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl500
        '
        Me.Lbl500.AutoSize = True
        Me.Lbl500.Location = New System.Drawing.Point(183, 148)
        Me.Lbl500.Name = "Lbl500"
        Me.Lbl500.Size = New System.Drawing.Size(43, 13)
        Me.Lbl500.TabIndex = 32
        Me.Lbl500.Text = "$      0.-"
        Me.Lbl500.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl1m
        '
        Me.Lbl1m.AutoSize = True
        Me.Lbl1m.Location = New System.Drawing.Point(183, 121)
        Me.Lbl1m.Name = "Lbl1m"
        Me.Lbl1m.Size = New System.Drawing.Size(43, 13)
        Me.Lbl1m.TabIndex = 31
        Me.Lbl1m.Text = "$      0.-"
        Me.Lbl1m.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl2m
        '
        Me.Lbl2m.AutoSize = True
        Me.Lbl2m.Location = New System.Drawing.Point(183, 98)
        Me.Lbl2m.Name = "Lbl2m"
        Me.Lbl2m.Size = New System.Drawing.Size(43, 13)
        Me.Lbl2m.TabIndex = 30
        Me.Lbl2m.Text = "$      0.-"
        Me.Lbl2m.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl5m
        '
        Me.Lbl5m.AutoSize = True
        Me.Lbl5m.Location = New System.Drawing.Point(183, 73)
        Me.Lbl5m.Name = "Lbl5m"
        Me.Lbl5m.Size = New System.Drawing.Size(43, 13)
        Me.Lbl5m.TabIndex = 29
        Me.Lbl5m.Text = "$      0.-"
        Me.Lbl5m.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl10m
        '
        Me.Lbl10m.AutoSize = True
        Me.Lbl10m.Location = New System.Drawing.Point(183, 45)
        Me.Lbl10m.Name = "Lbl10m"
        Me.Lbl10m.Size = New System.Drawing.Size(43, 13)
        Me.Lbl10m.TabIndex = 28
        Me.Lbl10m.Text = "$      0.-"
        Me.Lbl10m.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 256)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "$       1.-"
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(94, 253)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(68, 20)
        Me.Txt1.TabIndex = 26
        Me.Txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 233)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "$      5.-"
        '
        'Txt5
        '
        Me.Txt5.Location = New System.Drawing.Point(94, 230)
        Me.Txt5.Name = "Txt5"
        Me.Txt5.Size = New System.Drawing.Size(68, 20)
        Me.Txt5.TabIndex = 24
        Me.Txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 211)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "$    10.-"
        '
        'Txt10
        '
        Me.Txt10.Location = New System.Drawing.Point(94, 208)
        Me.Txt10.Name = "Txt10"
        Me.Txt10.Size = New System.Drawing.Size(68, 20)
        Me.Txt10.TabIndex = 22
        Me.Txt10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 188)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "$    50.-"
        '
        'Txt50
        '
        Me.Txt50.Location = New System.Drawing.Point(94, 185)
        Me.Txt50.Name = "Txt50"
        Me.Txt50.Size = New System.Drawing.Size(68, 20)
        Me.Txt50.TabIndex = 20
        Me.Txt50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "$   100.-"
        '
        'Txt100
        '
        Me.Txt100.Location = New System.Drawing.Point(94, 164)
        Me.Txt100.Name = "Txt100"
        Me.Txt100.Size = New System.Drawing.Size(68, 20)
        Me.Txt100.TabIndex = 18
        Me.Txt100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "$   500.-"
        '
        'Txt500
        '
        Me.Txt500.Location = New System.Drawing.Point(94, 141)
        Me.Txt500.Name = "Txt500"
        Me.Txt500.Size = New System.Drawing.Size(68, 20)
        Me.Txt500.TabIndex = 16
        Me.Txt500.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "$  1.000.-"
        '
        'Txt1m
        '
        Me.Txt1m.Location = New System.Drawing.Point(94, 114)
        Me.Txt1m.Name = "Txt1m"
        Me.Txt1m.Size = New System.Drawing.Size(68, 20)
        Me.Txt1m.TabIndex = 13
        Me.Txt1m.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "$  2.000.-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "$  5.000.-"
        '
        'Txt2m
        '
        Me.Txt2m.Location = New System.Drawing.Point(94, 91)
        Me.Txt2m.Name = "Txt2m"
        Me.Txt2m.Size = New System.Drawing.Size(68, 20)
        Me.Txt2m.TabIndex = 10
        Me.Txt2m.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt5m
        '
        Me.Txt5m.Location = New System.Drawing.Point(94, 66)
        Me.Txt5m.Name = "Txt5m"
        Me.Txt5m.Size = New System.Drawing.Size(68, 20)
        Me.Txt5m.TabIndex = 7
        Me.Txt5m.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt10m
        '
        Me.Txt10m.Location = New System.Drawing.Point(94, 42)
        Me.Txt10m.Name = "Txt10m"
        Me.Txt10m.Size = New System.Drawing.Size(68, 20)
        Me.Txt10m.TabIndex = 4
        Me.Txt10m.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "$ 10.000.-"
        '
        'Lbl20m
        '
        Me.Lbl20m.AutoSize = True
        Me.Lbl20m.Location = New System.Drawing.Point(181, 22)
        Me.Lbl20m.Name = "Lbl20m"
        Me.Lbl20m.Size = New System.Drawing.Size(43, 13)
        Me.Lbl20m.TabIndex = 2
        Me.Lbl20m.Text = "$      0.-"
        Me.Lbl20m.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt20m
        '
        Me.Txt20m.Location = New System.Drawing.Point(94, 19)
        Me.Txt20m.Name = "Txt20m"
        Me.Txt20m.Size = New System.Drawing.Size(68, 20)
        Me.Txt20m.TabIndex = 1
        Me.Txt20m.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "$ 20.000.-"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_ejecutivo)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(683, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 129)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'Txt_ejecutivo
        '
        Me.Txt_ejecutivo.Location = New System.Drawing.Point(6, 83)
        Me.Txt_ejecutivo.Name = "Txt_ejecutivo"
        Me.Txt_ejecutivo.Size = New System.Drawing.Size(254, 20)
        Me.Txt_ejecutivo.TabIndex = 23
        Me.Txt_ejecutivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 16)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Nombre Ejecutivo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Rdb_impar)
        Me.GroupBox3.Controls.Add(Me.Rdb_par)
        Me.GroupBox3.Location = New System.Drawing.Point(41, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(197, 44)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'Rdb_impar
        '
        Me.Rdb_impar.AutoSize = True
        Me.Rdb_impar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_impar.Location = New System.Drawing.Point(125, 18)
        Me.Rdb_impar.Name = "Rdb_impar"
        Me.Rdb_impar.Size = New System.Drawing.Size(56, 17)
        Me.Rdb_impar.TabIndex = 1
        Me.Rdb_impar.TabStop = True
        Me.Rdb_impar.Text = "Impar"
        Me.Rdb_impar.UseVisualStyleBackColor = True
        '
        'Rdb_par
        '
        Me.Rdb_par.AutoSize = True
        Me.Rdb_par.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_par.Location = New System.Drawing.Point(6, 18)
        Me.Rdb_par.Name = "Rdb_par"
        Me.Rdb_par.Size = New System.Drawing.Size(44, 17)
        Me.Rdb_par.TabIndex = 0
        Me.Rdb_par.TabStop = True
        Me.Rdb_par.Text = "Par"
        Me.Rdb_par.UseVisualStyleBackColor = True
        '
        'Facturas
        '
        Me.Facturas.Controls.Add(Me.Dtg_garantias)
        Me.Facturas.Location = New System.Drawing.Point(4, 139)
        Me.Facturas.Name = "Facturas"
        Me.Facturas.Size = New System.Drawing.Size(673, 269)
        Me.Facturas.TabIndex = 20
        Me.Facturas.TabStop = False
        Me.Facturas.Text = "Facturas"
        '
        'Dtg_garantias
        '
        Me.Dtg_garantias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtg_garantias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dtg_garantias.Location = New System.Drawing.Point(3, 16)
        Me.Dtg_garantias.Name = "Dtg_garantias"
        Me.Dtg_garantias.Size = New System.Drawing.Size(667, 250)
        Me.Dtg_garantias.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(427, 448)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Total"
        '
        'Lbl_totlotes
        '
        Me.Lbl_totlotes.AutoSize = True
        Me.Lbl_totlotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_totlotes.Location = New System.Drawing.Point(540, 448)
        Me.Lbl_totlotes.Name = "Lbl_totlotes"
        Me.Lbl_totlotes.Size = New System.Drawing.Size(70, 20)
        Me.Lbl_totlotes.TabIndex = 40
        Me.Lbl_totlotes.Text = "$      0.-"
        Me.Lbl_totlotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Location = New System.Drawing.Point(4, 477)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(944, 55)
        Me.GroupBox5.TabIndex = 42
        Me.GroupBox5.TabStop = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(398, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(121, 29)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Buscar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(806, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 29)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Imprimir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(62, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Grabar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Lbl_nlotes
        '
        Me.Lbl_nlotes.AutoSize = True
        Me.Lbl_nlotes.Location = New System.Drawing.Point(514, 55)
        Me.Lbl_nlotes.Name = "Lbl_nlotes"
        Me.Lbl_nlotes.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_nlotes.TabIndex = 43
        Me.Lbl_nlotes.Text = "      0.-"
        Me.Lbl_nlotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(428, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 16)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "N° de Lotes con Garantia"
        '
        'Frm_inggarantias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 538)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Lbl_nlotes)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Lbl_totlotes)
        Me.Controls.Add(Me.Facturas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "Frm_inggarantias"
        Me.Text = "Frm_inggarantias"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Facturas.ResumeLayout(False)
        CType(Me.Dtg_garantias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_fecha As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cmb_remate As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Lbl_totefec As System.Windows.Forms.Label
    Friend WithEvents Lbl1 As System.Windows.Forms.Label
    Friend WithEvents Lbl5 As System.Windows.Forms.Label
    Friend WithEvents Lbl10 As System.Windows.Forms.Label
    Friend WithEvents Lbl50 As System.Windows.Forms.Label
    Friend WithEvents Lbl100 As System.Windows.Forms.Label
    Friend WithEvents Lbl500 As System.Windows.Forms.Label
    Friend WithEvents Lbl1m As System.Windows.Forms.Label
    Friend WithEvents Lbl2m As System.Windows.Forms.Label
    Friend WithEvents Lbl5m As System.Windows.Forms.Label
    Friend WithEvents Lbl10m As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Txt5 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Txt10 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Txt50 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Txt100 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Txt500 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Txt1m As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt2m As System.Windows.Forms.TextBox
    Friend WithEvents Txt5m As System.Windows.Forms.TextBox
    Friend WithEvents Txt10m As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Lbl20m As System.Windows.Forms.Label
    Friend WithEvents Txt20m As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Rdb_impar As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_par As System.Windows.Forms.RadioButton
    Friend WithEvents Facturas As System.Windows.Forms.GroupBox
    Friend WithEvents Dtg_garantias As System.Windows.Forms.DataGridView
    Friend WithEvents Txt_ejecutivo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lbl_totlotes As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Lbl_nlotes As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
