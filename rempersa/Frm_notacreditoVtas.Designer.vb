<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_notacreditoVtas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_notacreditoVtas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.TxtNotCre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Dtg_item = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Txt_Comision = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_iva = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txt_total = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_neto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Btn_imprimir = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtNfactura = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dtg_item, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtFecha)
        Me.GroupBox1.Controls.Add(Me.Label7)
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
        Me.GroupBox1.Controls.Add(Me.TxtNotCre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, -1)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(647, 15)
        Me.TxtFecha.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(208, 23)
        Me.TxtFecha.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(603, 20)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Fecha"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(902, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Btn_limpiar
        '
        Me.Btn_limpiar.Location = New System.Drawing.Point(902, 22)
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
        Me.Txt_giro.Location = New System.Drawing.Point(306, 15)
        Me.Txt_giro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_giro.Name = "Txt_giro"
        Me.Txt_giro.Size = New System.Drawing.Size(295, 23)
        Me.Txt_giro.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(268, 18)
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
        'TxtNotCre
        '
        Me.TxtNotCre.Location = New System.Drawing.Point(134, 15)
        Me.TxtNotCre.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtNotCre.Name = "TxtNotCre"
        Me.TxtNotCre.Size = New System.Drawing.Size(132, 23)
        Me.TxtNotCre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro Nota de Credito"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Dtg_item)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 129)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(998, 222)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Dtg_item
        '
        Me.Dtg_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtg_item.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dtg_item.Location = New System.Drawing.Point(4, 19)
        Me.Dtg_item.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Dtg_item.Name = "Dtg_item"
        Me.Dtg_item.Size = New System.Drawing.Size(990, 200)
        Me.Dtg_item.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Txt_Comision)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Txt_iva)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Txt_total)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Txt_neto)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(517, 352)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(490, 134)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'Txt_Comision
        '
        Me.Txt_Comision.Location = New System.Drawing.Point(131, 40)
        Me.Txt_Comision.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_Comision.Name = "Txt_Comision"
        Me.Txt_Comision.Size = New System.Drawing.Size(208, 23)
        Me.Txt_Comision.TabIndex = 19
        Me.Txt_Comision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 49)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 14)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Comision"
        '
        'Txt_iva
        '
        Me.Txt_iva.Location = New System.Drawing.Point(131, 74)
        Me.Txt_iva.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_iva.Name = "Txt_iva"
        Me.Txt_iva.Size = New System.Drawing.Size(208, 23)
        Me.Txt_iva.TabIndex = 17
        Me.Txt_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 83)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 14)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Iva"
        '
        'Txt_total
        '
        Me.Txt_total.Location = New System.Drawing.Point(131, 100)
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
        Me.Label9.Location = New System.Drawing.Point(7, 109)
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
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox5.Controls.Add(Me.Btn_imprimir)
        Me.GroupBox5.Location = New System.Drawing.Point(256, 352)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(259, 249)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(7, 81)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 5
        '
        'Btn_imprimir
        '
        Me.Btn_imprimir.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_imprimir.Location = New System.Drawing.Point(71, 49)
        Me.Btn_imprimir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_imprimir.Name = "Btn_imprimir"
        Me.Btn_imprimir.Size = New System.Drawing.Size(100, 26)
        Me.Btn_imprimir.TabIndex = 4
        Me.Btn_imprimir.Text = "Imprimir"
        Me.Btn_imprimir.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button2)
        Me.GroupBox6.Controls.Add(Me.TxtNfactura)
        Me.GroupBox6.Location = New System.Drawing.Point(13, 352)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(199, 134)
        Me.GroupBox6.TabIndex = 22
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Factura"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(10, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(183, 79)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Buscar Factura"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TxtNfactura
        '
        Me.TxtNfactura.Location = New System.Drawing.Point(9, 16)
        Me.TxtNfactura.Name = "TxtNfactura"
        Me.TxtNfactura.Size = New System.Drawing.Size(184, 23)
        Me.TxtNfactura.TabIndex = 23
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(43, 15)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(164, 26)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Modificar Cantidades"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Frm_notacreditoVtas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 603)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Frm_notacreditoVtas"
        Me.Text = "Notas de Creditos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Dtg_item, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNotCre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Dtg_item As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Txt_total As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Txt_neto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Btn_buscaclientes As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents Btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents Txt_giro As System.Windows.Forms.TextBox
    Public WithEvents Txt_rut As System.Windows.Forms.TextBox
    Public WithEvents Txt_direccion As System.Windows.Forms.TextBox
    Public WithEvents Txt_razonsocial As System.Windows.Forms.TextBox
    Public WithEvents Txt_Comuna As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TxtNfactura As System.Windows.Forms.TextBox
    Public WithEvents TxtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Txt_Comision As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
