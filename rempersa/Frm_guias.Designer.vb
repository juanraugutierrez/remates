<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_guias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_guias))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdbMandantes = New System.Windows.Forms.RadioButton()
        Me.RdbClientes = New System.Windows.Forms.RadioButton()
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
        Me.Txt_nroguia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.ChkAfecto = New System.Windows.Forms.CheckBox()
        Me.Grp_mandante = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CmbMandante = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txt_vunitario = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txt_descripcion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_unidades = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DtgArticulos = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TxtExcento = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtIva = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtAfecto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MCale = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RdbConVta = New System.Windows.Forms.RadioButton()
        Me.RdbSinVta = New System.Windows.Forms.RadioButton()
        Me.Btn_imprimir = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Grp_mandante.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DtgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.btnLimpiar)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.Btn_buscaclientes)
        Me.GroupBox2.Controls.Add(Me.Txt_Comuna)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Txt_giro)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Txt_rut)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Txt_direccion)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Txt_razonsocial)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Txt_nroguia)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(917, 128)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(811, 70)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(91, 52)
        Me.btnBuscar.TabIndex = 17
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackgroundImage = CType(resources.GetObject("btnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.Location = New System.Drawing.Point(811, 11)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(91, 52)
        Me.btnLimpiar.TabIndex = 16
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdbMandantes)
        Me.GroupBox1.Controls.Add(Me.RdbClientes)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 61)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'RdbMandantes
        '
        Me.RdbMandantes.AutoSize = True
        Me.RdbMandantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbMandantes.Location = New System.Drawing.Point(88, 19)
        Me.RdbMandantes.Name = "RdbMandantes"
        Me.RdbMandantes.Size = New System.Drawing.Size(96, 19)
        Me.RdbMandantes.TabIndex = 1
        Me.RdbMandantes.TabStop = True
        Me.RdbMandantes.Text = "Mandantes"
        Me.RdbMandantes.UseVisualStyleBackColor = True
        '
        'RdbClientes
        '
        Me.RdbClientes.AutoSize = True
        Me.RdbClientes.Checked = True
        Me.RdbClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbClientes.Location = New System.Drawing.Point(6, 19)
        Me.RdbClientes.Name = "RdbClientes"
        Me.RdbClientes.Size = New System.Drawing.Size(77, 19)
        Me.RdbClientes.TabIndex = 0
        Me.RdbClientes.TabStop = True
        Me.RdbClientes.Text = "Clientes"
        Me.RdbClientes.UseVisualStyleBackColor = True
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
        Me.Txt_Comuna.Location = New System.Drawing.Point(587, 101)
        Me.Txt_Comuna.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_Comuna.Name = "Txt_Comuna"
        Me.Txt_Comuna.Size = New System.Drawing.Size(208, 20)
        Me.Txt_Comuna.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(521, 103)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Comuna"
        '
        'Txt_giro
        '
        Me.Txt_giro.Location = New System.Drawing.Point(586, 54)
        Me.Txt_giro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_giro.Name = "Txt_giro"
        Me.Txt_giro.Size = New System.Drawing.Size(208, 20)
        Me.Txt_giro.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(521, 59)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Giro"
        '
        'Txt_rut
        '
        Me.Txt_rut.Location = New System.Drawing.Point(586, 79)
        Me.Txt_rut.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_rut.Name = "Txt_rut"
        Me.Txt_rut.Size = New System.Drawing.Size(208, 20)
        Me.Txt_rut.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(521, 77)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Rut"
        '
        'Txt_direccion
        '
        Me.Txt_direccion.Location = New System.Drawing.Point(129, 100)
        Me.Txt_direccion.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_direccion.Name = "Txt_direccion"
        Me.Txt_direccion.Size = New System.Drawing.Size(389, 20)
        Me.Txt_direccion.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Direccion"
        '
        'Txt_razonsocial
        '
        Me.Txt_razonsocial.Location = New System.Drawing.Point(129, 76)
        Me.Txt_razonsocial.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_razonsocial.Name = "Txt_razonsocial"
        Me.Txt_razonsocial.Size = New System.Drawing.Size(389, 20)
        Me.Txt_razonsocial.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Razon Social"
        '
        'Txt_nroguia
        '
        Me.Txt_nroguia.Location = New System.Drawing.Point(382, 53)
        Me.Txt_nroguia.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_nroguia.Name = "Txt_nroguia"
        Me.Txt_nroguia.Size = New System.Drawing.Size(132, 20)
        Me.Txt_nroguia.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(310, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro Guia"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox4.Controls.Add(Me.btnAgregar)
        Me.GroupBox4.Controls.Add(Me.ChkAfecto)
        Me.GroupBox4.Controls.Add(Me.Grp_mandante)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Txt_vunitario)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Txt_descripcion)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Txt_unidades)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 434)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(915, 125)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackgroundImage = CType(resources.GetObject("btnAgregar.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(809, 23)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 52)
        Me.btnAgregar.TabIndex = 19
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'ChkAfecto
        '
        Me.ChkAfecto.AutoSize = True
        Me.ChkAfecto.Checked = True
        Me.ChkAfecto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkAfecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAfecto.Location = New System.Drawing.Point(738, 40)
        Me.ChkAfecto.Name = "ChkAfecto"
        Me.ChkAfecto.Size = New System.Drawing.Size(65, 19)
        Me.ChkAfecto.TabIndex = 18
        Me.ChkAfecto.Text = "Afecto"
        Me.ChkAfecto.UseVisualStyleBackColor = True
        '
        'Grp_mandante
        '
        Me.Grp_mandante.Controls.Add(Me.Label14)
        Me.Grp_mandante.Controls.Add(Me.CmbMandante)
        Me.Grp_mandante.Location = New System.Drawing.Point(10, 65)
        Me.Grp_mandante.Name = "Grp_mandante"
        Me.Grp_mandante.Size = New System.Drawing.Size(711, 37)
        Me.Grp_mandante.TabIndex = 17
        Me.Grp_mandante.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(7, 15)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 14)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Mandante"
        '
        'CmbMandante
        '
        Me.CmbMandante.FormattingEnabled = True
        Me.CmbMandante.Location = New System.Drawing.Point(126, 12)
        Me.CmbMandante.Name = "CmbMandante"
        Me.CmbMandante.Size = New System.Drawing.Size(574, 21)
        Me.CmbMandante.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(616, 21)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 14)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Valor Unitario"
        '
        'Txt_vunitario
        '
        Me.Txt_vunitario.Location = New System.Drawing.Point(619, 39)
        Me.Txt_vunitario.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_vunitario.Name = "Txt_vunitario"
        Me.Txt_vunitario.Size = New System.Drawing.Size(91, 20)
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
        Me.Txt_descripcion.Size = New System.Drawing.Size(531, 20)
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
        Me.Txt_unidades.Size = New System.Drawing.Size(58, 20)
        Me.Txt_unidades.TabIndex = 10
        Me.Txt_unidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DtgArticulos)
        Me.GroupBox3.Location = New System.Drawing.Point(258, 134)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(663, 180)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        '
        'DtgArticulos
        '
        Me.DtgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DtgArticulos.Location = New System.Drawing.Point(4, 16)
        Me.DtgArticulos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DtgArticulos.Name = "DtgArticulos"
        Me.DtgArticulos.Size = New System.Drawing.Size(655, 161)
        Me.DtgArticulos.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxtExcento)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.TxtIva)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.TxtTotal)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.TxtAfecto)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Location = New System.Drawing.Point(664, 323)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox5.Size = New System.Drawing.Size(253, 106)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        '
        'TxtExcento
        '
        Me.TxtExcento.Location = New System.Drawing.Point(105, 34)
        Me.TxtExcento.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtExcento.Name = "TxtExcento"
        Me.TxtExcento.Size = New System.Drawing.Size(140, 20)
        Me.TxtExcento.TabIndex = 19
        Me.TxtExcento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 40)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 14)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Exento"
        '
        'TxtIva
        '
        Me.TxtIva.Location = New System.Drawing.Point(105, 57)
        Me.TxtIva.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtIva.Name = "TxtIva"
        Me.TxtIva.Size = New System.Drawing.Size(140, 20)
        Me.TxtIva.TabIndex = 17
        Me.TxtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 63)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 14)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Iva"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(105, 80)
        Me.TxtTotal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(140, 20)
        Me.TxtTotal.TabIndex = 11
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 86)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 14)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Total"
        '
        'TxtAfecto
        '
        Me.TxtAfecto.Location = New System.Drawing.Point(105, 12)
        Me.TxtAfecto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtAfecto.Name = "TxtAfecto"
        Me.TxtAfecto.Size = New System.Drawing.Size(140, 20)
        Me.TxtAfecto.TabIndex = 9
        Me.TxtAfecto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 18)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 14)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Afecto"
        '
        'MCale
        '
        Me.MCale.Font = New System.Drawing.Font("Arial Black", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.MCale.Location = New System.Drawing.Point(4, 149)
        Me.MCale.Margin = New System.Windows.Forms.Padding(2)
        Me.MCale.Name = "MCale"
        Me.MCale.TabIndex = 21
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RdbConVta)
        Me.GroupBox6.Controls.Add(Me.RdbSinVta)
        Me.GroupBox6.Controls.Add(Me.Btn_imprimir)
        Me.GroupBox6.Location = New System.Drawing.Point(415, 323)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(246, 106)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        '
        'RdbConVta
        '
        Me.RdbConVta.AutoSize = True
        Me.RdbConVta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbConVta.Location = New System.Drawing.Point(110, 46)
        Me.RdbConVta.Name = "RdbConVta"
        Me.RdbConVta.Size = New System.Drawing.Size(135, 17)
        Me.RdbConVta.TabIndex = 0
        Me.RdbConVta.TabStop = True
        Me.RdbConVta.Text = "Transporte Con Vta"
        Me.RdbConVta.UseVisualStyleBackColor = True
        '
        'RdbSinVta
        '
        Me.RdbSinVta.AutoSize = True
        Me.RdbSinVta.Checked = True
        Me.RdbSinVta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbSinVta.Location = New System.Drawing.Point(110, 14)
        Me.RdbSinVta.Name = "RdbSinVta"
        Me.RdbSinVta.Size = New System.Drawing.Size(129, 17)
        Me.RdbSinVta.TabIndex = 1
        Me.RdbSinVta.TabStop = True
        Me.RdbSinVta.Text = "Transporte sin Vta"
        Me.RdbSinVta.UseVisualStyleBackColor = True
        '
        'Btn_imprimir
        '
        Me.Btn_imprimir.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_imprimir.Image = CType(resources.GetObject("Btn_imprimir.Image"), System.Drawing.Image)
        Me.Btn_imprimir.Location = New System.Drawing.Point(7, 9)
        Me.Btn_imprimir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_imprimir.Name = "Btn_imprimir"
        Me.Btn_imprimir.Size = New System.Drawing.Size(100, 68)
        Me.Btn_imprimir.TabIndex = 4
        Me.Btn_imprimir.Text = "Imprimir"
        Me.Btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_imprimir.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Button2)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.TextBox2)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.TextBox1)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 323)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(403, 106)
        Me.GroupBox7.TabIndex = 26
        Me.GroupBox7.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(277, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 68)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Destino"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 46)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 14)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Patente"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(97, 43)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(151, 20)
        Me.TextBox2.TabIndex = 14
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 22)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 14)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "N Transportista"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(97, 19)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(151, 20)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frm_guias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 569)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.MCale)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Frm_guias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_guias"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Grp_mandante.ResumeLayout(False)
        Me.Grp_mandante.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DtgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_buscaclientes As System.Windows.Forms.Button
    Public WithEvents Txt_Comuna As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Txt_giro As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Txt_razonsocial As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_nroguia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RdbMandantes As System.Windows.Forms.RadioButton
    Friend WithEvents RdbClientes As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Grp_mandante As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CmbMandante As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Txt_vunitario As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Txt_unidades As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DtgArticulos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtExcento As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtIva As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtAfecto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MCale As System.Windows.Forms.MonthCalendar
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents RdbConVta As System.Windows.Forms.RadioButton
    Friend WithEvents RdbSinVta As System.Windows.Forms.RadioButton
    Friend WithEvents Btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ChkAfecto As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Private WithEvents btnLimpiar As System.Windows.Forms.Button
    Private WithEvents btnBuscar As System.Windows.Forms.Button
    Private WithEvents btnAgregar As System.Windows.Forms.Button
End Class
