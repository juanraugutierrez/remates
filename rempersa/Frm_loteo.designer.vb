<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_loteo
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
        Me.Txtbmandante = New System.Windows.Forms.TextBox()
        Me.CmbMandantes = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Txt_sucursal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_preciom = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtValorComercial = New System.Windows.Forms.TextBox()
        Me.Chk_ila = New System.Windows.Forms.CheckBox()
        Me.Chk_Afecto = New System.Windows.Forms.CheckBox()
        Me.Lbl_nlote = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Txt_fecha = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cmb_remate = New System.Windows.Forms.ComboBox()
        Me.Txt_obesrvacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_unidades = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_detalle_especie = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_papeles = New System.Windows.Forms.Button()
        Me.Btn_limpiar = New System.Windows.Forms.Button()
        Me.Btn_sublote = New System.Windows.Forms.Button()
        Me.Txt_busqueda = New System.Windows.Forms.TextBox()
        Me.Btn_buscar = New System.Windows.Forms.Button()
        Me.Btn_eliminar = New System.Windows.Forms.Button()
        Me.Btn_modificar = New System.Windows.Forms.Button()
        Me.Btn_agregar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Dtg_lotes = New System.Windows.Forms.DataGridView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Npasillo = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Dtg_lotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.Npasillo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txtbmandante)
        Me.GroupBox1.Controls.Add(Me.CmbMandantes)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Txt_sucursal)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Txt_preciom)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.Lbl_nlote)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Txt_obesrvacion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_unidades)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txt_detalle_especie)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(977, 218)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "|"
        '
        'Txtbmandante
        '
        Me.Txtbmandante.Location = New System.Drawing.Point(9, 142)
        Me.Txtbmandante.Name = "Txtbmandante"
        Me.Txtbmandante.Size = New System.Drawing.Size(266, 20)
        Me.Txtbmandante.TabIndex = 26
        '
        'CmbMandantes
        '
        Me.CmbMandantes.FormattingEnabled = True
        Me.CmbMandantes.Location = New System.Drawing.Point(8, 168)
        Me.CmbMandantes.Name = "CmbMandantes"
        Me.CmbMandantes.Size = New System.Drawing.Size(265, 21)
        Me.CmbMandantes.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(896, 149)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Txt_sucursal
        '
        Me.Txt_sucursal.Location = New System.Drawing.Point(291, 142)
        Me.Txt_sucursal.Name = "Txt_sucursal"
        Me.Txt_sucursal.Size = New System.Drawing.Size(197, 20)
        Me.Txt_sucursal.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(549, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 16)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Precio Minimo Unitario"
        '
        'Txt_preciom
        '
        Me.Txt_preciom.Location = New System.Drawing.Point(552, 66)
        Me.Txt_preciom.Name = "Txt_preciom"
        Me.Txt_preciom.Size = New System.Drawing.Size(186, 20)
        Me.Txt_preciom.TabIndex = 3
        Me.Txt_preciom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.TxtValorComercial)
        Me.GroupBox5.Controls.Add(Me.Chk_ila)
        Me.GroupBox5.Controls.Add(Me.Chk_Afecto)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 88)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(479, 36)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(241, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Valor Comercial"
        '
        'TxtValorComercial
        '
        Me.TxtValorComercial.Location = New System.Drawing.Point(327, 11)
        Me.TxtValorComercial.Name = "TxtValorComercial"
        Me.TxtValorComercial.Size = New System.Drawing.Size(146, 20)
        Me.TxtValorComercial.TabIndex = 2
        Me.TxtValorComercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Chk_ila
        '
        Me.Chk_ila.AutoSize = True
        Me.Chk_ila.Location = New System.Drawing.Point(86, 13)
        Me.Chk_ila.Name = "Chk_ila"
        Me.Chk_ila.Size = New System.Drawing.Size(37, 17)
        Me.Chk_ila.TabIndex = 1
        Me.Chk_ila.Text = "Ila"
        Me.Chk_ila.UseVisualStyleBackColor = True
        '
        'Chk_Afecto
        '
        Me.Chk_Afecto.AutoSize = True
        Me.Chk_Afecto.Checked = True
        Me.Chk_Afecto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_Afecto.Location = New System.Drawing.Point(6, 13)
        Me.Chk_Afecto.Name = "Chk_Afecto"
        Me.Chk_Afecto.Size = New System.Drawing.Size(57, 17)
        Me.Chk_Afecto.TabIndex = 0
        Me.Chk_Afecto.Text = "Afecto"
        Me.Chk_Afecto.UseVisualStyleBackColor = True
        '
        'Lbl_nlote
        '
        Me.Lbl_nlote.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbl_nlote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_nlote.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nlote.Location = New System.Drawing.Point(552, 106)
        Me.Lbl_nlote.Name = "Lbl_nlote"
        Me.Lbl_nlote.Size = New System.Drawing.Size(186, 88)
        Me.Lbl_nlote.TabIndex = 7
        Me.Lbl_nlote.Text = "Label21"
        Me.Lbl_nlote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Txt_fecha)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Cmb_remate)
        Me.GroupBox4.Location = New System.Drawing.Point(740, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(231, 129)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        '
        'Txt_fecha
        '
        Me.Txt_fecha.Location = New System.Drawing.Point(7, 72)
        Me.Txt_fecha.Name = "Txt_fecha"
        Me.Txt_fecha.Size = New System.Drawing.Size(195, 20)
        Me.Txt_fecha.TabIndex = 18
        Me.Txt_fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Fecha del Remate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Remate"
        '
        'Cmb_remate
        '
        Me.Cmb_remate.FormattingEnabled = True
        Me.Cmb_remate.Location = New System.Drawing.Point(6, 26)
        Me.Cmb_remate.Name = "Cmb_remate"
        Me.Cmb_remate.Size = New System.Drawing.Size(196, 21)
        Me.Cmb_remate.TabIndex = 15
        '
        'Txt_obesrvacion
        '
        Me.Txt_obesrvacion.Location = New System.Drawing.Point(8, 66)
        Me.Txt_obesrvacion.Name = "Txt_obesrvacion"
        Me.Txt_obesrvacion.Size = New System.Drawing.Size(480, 20)
        Me.Txt_obesrvacion.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Observacion"
        '
        'Txt_unidades
        '
        Me.Txt_unidades.Location = New System.Drawing.Point(552, 28)
        Me.Txt_unidades.Name = "Txt_unidades"
        Me.Txt_unidades.Size = New System.Drawing.Size(186, 20)
        Me.Txt_unidades.TabIndex = 2
        Me.Txt_unidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(549, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Unidades"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(288, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Sucursal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Mandante"
        '
        'Txt_detalle_especie
        '
        Me.Txt_detalle_especie.Location = New System.Drawing.Point(8, 26)
        Me.Txt_detalle_especie.Name = "Txt_detalle_especie"
        Me.Txt_detalle_especie.Size = New System.Drawing.Size(480, 20)
        Me.Txt_detalle_especie.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Detalle Especie"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btn_papeles)
        Me.GroupBox2.Controls.Add(Me.Btn_limpiar)
        Me.GroupBox2.Controls.Add(Me.Btn_sublote)
        Me.GroupBox2.Controls.Add(Me.Txt_busqueda)
        Me.GroupBox2.Controls.Add(Me.Btn_buscar)
        Me.GroupBox2.Controls.Add(Me.Btn_eliminar)
        Me.GroupBox2.Controls.Add(Me.Btn_modificar)
        Me.GroupBox2.Controls.Add(Me.Btn_agregar)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 226)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1236, 64)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Btn_papeles
        '
        Me.Btn_papeles.Enabled = False
        Me.Btn_papeles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_papeles.Location = New System.Drawing.Point(500, 20)
        Me.Btn_papeles.Name = "Btn_papeles"
        Me.Btn_papeles.Size = New System.Drawing.Size(75, 23)
        Me.Btn_papeles.TabIndex = 5
        Me.Btn_papeles.Text = "Papeles"
        Me.Btn_papeles.UseVisualStyleBackColor = True
        '
        'Btn_limpiar
        '
        Me.Btn_limpiar.Enabled = False
        Me.Btn_limpiar.Location = New System.Drawing.Point(315, 20)
        Me.Btn_limpiar.Name = "Btn_limpiar"
        Me.Btn_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_limpiar.TabIndex = 4
        Me.Btn_limpiar.Text = "Limpiar"
        Me.Btn_limpiar.UseVisualStyleBackColor = True
        '
        'Btn_sublote
        '
        Me.Btn_sublote.Location = New System.Drawing.Point(231, 20)
        Me.Btn_sublote.Name = "Btn_sublote"
        Me.Btn_sublote.Size = New System.Drawing.Size(75, 23)
        Me.Btn_sublote.TabIndex = 3
        Me.Btn_sublote.Text = "Sub Lote"
        Me.Btn_sublote.UseVisualStyleBackColor = True
        '
        'Txt_busqueda
        '
        Me.Txt_busqueda.Location = New System.Drawing.Point(1058, 19)
        Me.Txt_busqueda.Name = "Txt_busqueda"
        Me.Txt_busqueda.Size = New System.Drawing.Size(80, 20)
        Me.Txt_busqueda.TabIndex = 4
        '
        'Btn_buscar
        '
        Me.Btn_buscar.Location = New System.Drawing.Point(1144, 17)
        Me.Btn_buscar.Name = "Btn_buscar"
        Me.Btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_buscar.TabIndex = 3
        Me.Btn_buscar.Text = "Buscar"
        Me.Btn_buscar.UseVisualStyleBackColor = True
        '
        'Btn_eliminar
        '
        Me.Btn_eliminar.Enabled = False
        Me.Btn_eliminar.Location = New System.Drawing.Point(156, 19)
        Me.Btn_eliminar.Name = "Btn_eliminar"
        Me.Btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_eliminar.TabIndex = 2
        Me.Btn_eliminar.Text = "Eliminar"
        Me.Btn_eliminar.UseVisualStyleBackColor = True
        '
        'Btn_modificar
        '
        Me.Btn_modificar.Enabled = False
        Me.Btn_modificar.Location = New System.Drawing.Point(81, 19)
        Me.Btn_modificar.Name = "Btn_modificar"
        Me.Btn_modificar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_modificar.TabIndex = 1
        Me.Btn_modificar.Text = "Modificar"
        Me.Btn_modificar.UseVisualStyleBackColor = True
        '
        'Btn_agregar
        '
        Me.Btn_agregar.Enabled = False
        Me.Btn_agregar.Location = New System.Drawing.Point(5, 19)
        Me.Btn_agregar.Name = "Btn_agregar"
        Me.Btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_agregar.TabIndex = 0
        Me.Btn_agregar.Text = "Agregar"
        Me.Btn_agregar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dtg_lotes)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 296)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1236, 349)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'Dtg_lotes
        '
        Me.Dtg_lotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtg_lotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dtg_lotes.Location = New System.Drawing.Point(3, 16)
        Me.Dtg_lotes.Name = "Dtg_lotes"
        Me.Dtg_lotes.Size = New System.Drawing.Size(1230, 330)
        Me.Dtg_lotes.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button2)
        Me.GroupBox6.Controls.Add(Me.Npasillo)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Location = New System.Drawing.Point(987, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(253, 219)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(142, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Re-Numerar Lotes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Npasillo
        '
        Me.Npasillo.Location = New System.Drawing.Point(7, 37)
        Me.Npasillo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Npasillo.Name = "Npasillo"
        Me.Npasillo.Size = New System.Drawing.Size(120, 20)
        Me.Npasillo.TabIndex = 0
        Me.Npasillo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Npasillo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Pasillo"
        '
        'Frm_loteo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 645)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_loteo"
        Me.Text = "Loteo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Dtg_lotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.Npasillo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_busqueda As System.Windows.Forms.TextBox
    Friend WithEvents Btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents Btn_modificar As System.Windows.Forms.Button
    Friend WithEvents Btn_agregar As System.Windows.Forms.Button
    Friend WithEvents Txt_detalle_especie As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txt_obesrvacion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_unidades As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Dtg_lotes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cmb_remate As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_nlote As System.Windows.Forms.Label
    Friend WithEvents Txt_fecha As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtValorComercial As System.Windows.Forms.TextBox
    Friend WithEvents Chk_ila As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Afecto As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Txt_preciom As System.Windows.Forms.TextBox
    Friend WithEvents Btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents Btn_sublote As System.Windows.Forms.Button
    Friend WithEvents Txt_sucursal As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Npasillo As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Btn_papeles As System.Windows.Forms.Button
    Friend WithEvents CmbMandantes As System.Windows.Forms.ComboBox
    Friend WithEvents Txtbmandante As System.Windows.Forms.TextBox
End Class
