<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_mandantes
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
        Me.Btn_limpiar = New System.Windows.Forms.Button()
        Me.Chk_vigente = New System.Windows.Forms.CheckBox()
        Me.Chk_madanto = New System.Windows.Forms.CheckBox()
        Me.Txt_email = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_replegal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_giro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_rut = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cmb_comuna = New System.Windows.Forms.ComboBox()
        Me.Cmb_region = New System.Windows.Forms.ComboBox()
        Me.Txt_telefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_rzonsocial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RdbNombre = New System.Windows.Forms.RadioButton()
        Me.RdbRut = New System.Windows.Forms.RadioButton()
        Me.Btn_buscar = New System.Windows.Forms.Button()
        Me.Txt_buscar = New System.Windows.Forms.TextBox()
        Me.Btn_asignar = New System.Windows.Forms.Button()
        Me.Btn_eliminar = New System.Windows.Forms.Button()
        Me.Btn_modificar = New System.Windows.Forms.Button()
        Me.Btn_agregar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dtg_clientes = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dtg_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_limpiar)
        Me.GroupBox1.Controls.Add(Me.Chk_vigente)
        Me.GroupBox1.Controls.Add(Me.Chk_madanto)
        Me.GroupBox1.Controls.Add(Me.Txt_email)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Txt_replegal)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Txt_giro)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Txt_rut)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Cmb_comuna)
        Me.GroupBox1.Controls.Add(Me.Cmb_region)
        Me.GroupBox1.Controls.Add(Me.Txt_telefono)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_direccion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_rzonsocial)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 196)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Btn_limpiar
        '
        Me.Btn_limpiar.Location = New System.Drawing.Point(764, 167)
        Me.Btn_limpiar.Name = "Btn_limpiar"
        Me.Btn_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_limpiar.TabIndex = 14
        Me.Btn_limpiar.Text = "Limpiar"
        Me.Btn_limpiar.UseVisualStyleBackColor = True
        '
        'Chk_vigente
        '
        Me.Chk_vigente.AutoSize = True
        Me.Chk_vigente.Location = New System.Drawing.Point(118, 151)
        Me.Chk_vigente.Name = "Chk_vigente"
        Me.Chk_vigente.Size = New System.Drawing.Size(62, 17)
        Me.Chk_vigente.TabIndex = 19
        Me.Chk_vigente.Text = "Vigente"
        Me.Chk_vigente.UseVisualStyleBackColor = True
        '
        'Chk_madanto
        '
        Me.Chk_madanto.AutoSize = True
        Me.Chk_madanto.Location = New System.Drawing.Point(25, 151)
        Me.Chk_madanto.Name = "Chk_madanto"
        Me.Chk_madanto.Size = New System.Drawing.Size(68, 17)
        Me.Chk_madanto.TabIndex = 18
        Me.Chk_madanto.Text = "Mandato"
        Me.Chk_madanto.UseVisualStyleBackColor = True
        '
        'Txt_email
        '
        Me.Txt_email.Location = New System.Drawing.Point(622, 115)
        Me.Txt_email.Name = "Txt_email"
        Me.Txt_email.Size = New System.Drawing.Size(232, 20)
        Me.Txt_email.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(619, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "E-mail"
        '
        'Txt_replegal
        '
        Me.Txt_replegal.Location = New System.Drawing.Point(284, 115)
        Me.Txt_replegal.Name = "Txt_replegal"
        Me.Txt_replegal.Size = New System.Drawing.Size(332, 20)
        Me.Txt_replegal.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(281, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Representante Legal"
        '
        'Txt_giro
        '
        Me.Txt_giro.Location = New System.Drawing.Point(478, 35)
        Me.Txt_giro.Name = "Txt_giro"
        Me.Txt_giro.Size = New System.Drawing.Size(376, 20)
        Me.Txt_giro.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(475, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Giro"
        '
        'Txt_rut
        '
        Me.Txt_rut.Location = New System.Drawing.Point(281, 36)
        Me.Txt_rut.Name = "Txt_rut"
        Me.Txt_rut.Size = New System.Drawing.Size(191, 20)
        Me.Txt_rut.TabIndex = 11
        Me.Txt_rut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(278, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Rut"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(579, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Comuna"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(281, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Region"
        '
        'Cmb_comuna
        '
        Me.Cmb_comuna.FormattingEnabled = True
        Me.Cmb_comuna.Location = New System.Drawing.Point(582, 74)
        Me.Cmb_comuna.Name = "Cmb_comuna"
        Me.Cmb_comuna.Size = New System.Drawing.Size(272, 21)
        Me.Cmb_comuna.TabIndex = 7
        '
        'Cmb_region
        '
        Me.Cmb_region.FormattingEnabled = True
        Me.Cmb_region.Location = New System.Drawing.Point(284, 74)
        Me.Cmb_region.Name = "Cmb_region"
        Me.Cmb_region.Size = New System.Drawing.Size(292, 21)
        Me.Cmb_region.TabIndex = 6
        '
        'Txt_telefono
        '
        Me.Txt_telefono.Location = New System.Drawing.Point(25, 115)
        Me.Txt_telefono.Name = "Txt_telefono"
        Me.Txt_telefono.Size = New System.Drawing.Size(250, 20)
        Me.Txt_telefono.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Telefono"
        '
        'Txt_direccion
        '
        Me.Txt_direccion.Location = New System.Drawing.Point(25, 75)
        Me.Txt_direccion.Name = "Txt_direccion"
        Me.Txt_direccion.Size = New System.Drawing.Size(250, 20)
        Me.Txt_direccion.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Direccion"
        '
        'Txt_rzonsocial
        '
        Me.Txt_rzonsocial.Location = New System.Drawing.Point(25, 36)
        Me.Txt_rzonsocial.Name = "Txt_rzonsocial"
        Me.Txt_rzonsocial.Size = New System.Drawing.Size(250, 20)
        Me.Txt_rzonsocial.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Razon Social"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Btn_buscar)
        Me.GroupBox2.Controls.Add(Me.Txt_buscar)
        Me.GroupBox2.Controls.Add(Me.Btn_asignar)
        Me.GroupBox2.Controls.Add(Me.Btn_eliminar)
        Me.GroupBox2.Controls.Add(Me.Btn_modificar)
        Me.GroupBox2.Controls.Add(Me.Btn_agregar)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 203)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(860, 52)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RdbNombre)
        Me.GroupBox3.Controls.Add(Me.RdbRut)
        Me.GroupBox3.Location = New System.Drawing.Point(334, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(152, 36)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        '
        'RdbNombre
        '
        Me.RdbNombre.AutoSize = True
        Me.RdbNombre.Location = New System.Drawing.Point(77, 12)
        Me.RdbNombre.Name = "RdbNombre"
        Me.RdbNombre.Size = New System.Drawing.Size(62, 17)
        Me.RdbNombre.TabIndex = 1
        Me.RdbNombre.TabStop = True
        Me.RdbNombre.Text = "Nombre"
        Me.RdbNombre.UseVisualStyleBackColor = True
        '
        'RdbRut
        '
        Me.RdbRut.AutoSize = True
        Me.RdbRut.Location = New System.Drawing.Point(7, 13)
        Me.RdbRut.Name = "RdbRut"
        Me.RdbRut.Size = New System.Drawing.Size(42, 17)
        Me.RdbRut.TabIndex = 0
        Me.RdbRut.TabStop = True
        Me.RdbRut.Text = "Rut"
        Me.RdbRut.UseVisualStyleBackColor = True
        '
        'Btn_buscar
        '
        Me.Btn_buscar.Location = New System.Drawing.Point(780, 18)
        Me.Btn_buscar.Name = "Btn_buscar"
        Me.Btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_buscar.TabIndex = 13
        Me.Btn_buscar.Text = "Buscar"
        Me.Btn_buscar.UseVisualStyleBackColor = True
        '
        'Txt_buscar
        '
        Me.Txt_buscar.Location = New System.Drawing.Point(515, 21)
        Me.Txt_buscar.Name = "Txt_buscar"
        Me.Txt_buscar.Size = New System.Drawing.Size(250, 20)
        Me.Txt_buscar.TabIndex = 12
        '
        'Btn_asignar
        '
        Me.Btn_asignar.Location = New System.Drawing.Point(249, 18)
        Me.Btn_asignar.Name = "Btn_asignar"
        Me.Btn_asignar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_asignar.TabIndex = 3
        Me.Btn_asignar.Text = "Asignar"
        Me.Btn_asignar.UseVisualStyleBackColor = True
        Me.Btn_asignar.Visible = False
        '
        'Btn_eliminar
        '
        Me.Btn_eliminar.Location = New System.Drawing.Point(168, 18)
        Me.Btn_eliminar.Name = "Btn_eliminar"
        Me.Btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_eliminar.TabIndex = 2
        Me.Btn_eliminar.Text = "Eliminar"
        Me.Btn_eliminar.UseVisualStyleBackColor = True
        '
        'Btn_modificar
        '
        Me.Btn_modificar.Location = New System.Drawing.Point(87, 18)
        Me.Btn_modificar.Name = "Btn_modificar"
        Me.Btn_modificar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_modificar.TabIndex = 1
        Me.Btn_modificar.Text = "Modificar"
        Me.Btn_modificar.UseVisualStyleBackColor = True
        '
        'Btn_agregar
        '
        Me.Btn_agregar.Location = New System.Drawing.Point(6, 18)
        Me.Btn_agregar.Name = "Btn_agregar"
        Me.Btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_agregar.TabIndex = 0
        Me.Btn_agregar.Text = "Agregar"
        Me.Btn_agregar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dtg_clientes)
        Me.GroupBox4.Location = New System.Drawing.Point(2, 251)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(860, 137)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'dtg_clientes
        '
        Me.dtg_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg_clientes.Location = New System.Drawing.Point(3, 16)
        Me.dtg_clientes.Name = "dtg_clientes"
        Me.dtg_clientes.Size = New System.Drawing.Size(854, 118)
        Me.dtg_clientes.TabIndex = 0
        '
        'Frm_mandantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 393)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_mandantes"
        Me.Text = "Mandantes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dtg_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_rzonsocial As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cmb_comuna As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_region As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents Btn_asignar As System.Windows.Forms.Button
    Friend WithEvents Btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents Btn_modificar As System.Windows.Forms.Button
    Friend WithEvents Btn_agregar As System.Windows.Forms.Button
    Friend WithEvents Txt_replegal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Txt_giro As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtg_clientes As System.Windows.Forms.DataGridView

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.Btn_asignar.Enabled = False


        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Friend WithEvents Txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Chk_madanto As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_vigente As System.Windows.Forms.CheckBox
    Friend WithEvents Btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RdbNombre As System.Windows.Forms.RadioButton
    Friend WithEvents RdbRut As System.Windows.Forms.RadioButton
End Class
