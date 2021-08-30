<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_garantia
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
        Me.Btn_reporte = New System.Windows.Forms.Button()
        Me.Btn_buscar = New System.Windows.Forms.Button()
        Me.Txt_buscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_nrolotes = New System.Windows.Forms.Label()
        Me.Lbl_tiporema = New System.Windows.Forms.Label()
        Me.Lbl_fecharema = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Cmb_remates = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Btn_grabar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Txt_garantia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl_descripcion = New System.Windows.Forms.Label()
        Me.Lbl_lotem = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_reporte)
        Me.GroupBox1.Controls.Add(Me.Btn_buscar)
        Me.GroupBox1.Controls.Add(Me.Txt_buscar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Lbl_nrolotes)
        Me.GroupBox1.Controls.Add(Me.Lbl_tiporema)
        Me.GroupBox1.Controls.Add(Me.Lbl_fecharema)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Cmb_remates)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 325)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Btn_reporte
        '
        Me.Btn_reporte.Location = New System.Drawing.Point(10, 259)
        Me.Btn_reporte.Name = "Btn_reporte"
        Me.Btn_reporte.Size = New System.Drawing.Size(75, 41)
        Me.Btn_reporte.TabIndex = 23
        Me.Btn_reporte.Text = "Reporte de Garantias"
        Me.Btn_reporte.UseVisualStyleBackColor = True
        '
        'Btn_buscar
        '
        Me.Btn_buscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_buscar.Location = New System.Drawing.Point(218, 192)
        Me.Btn_buscar.Name = "Btn_buscar"
        Me.Btn_buscar.Size = New System.Drawing.Size(92, 32)
        Me.Btn_buscar.TabIndex = 13
        Me.Btn_buscar.Text = "Buscar"
        Me.Btn_buscar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_buscar.UseVisualStyleBackColor = True
        '
        'Txt_buscar
        '
        Me.Txt_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_buscar.Location = New System.Drawing.Point(8, 161)
        Me.Txt_buscar.Name = "Txt_buscar"
        Me.Txt_buscar.Size = New System.Drawing.Size(302, 29)
        Me.Txt_buscar.TabIndex = 22
        Me.Txt_buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 24)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Buscar"
        '
        'Lbl_nrolotes
        '
        Me.Lbl_nrolotes.AutoSize = True
        Me.Lbl_nrolotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nrolotes.Location = New System.Drawing.Point(9, 99)
        Me.Lbl_nrolotes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_nrolotes.Name = "Lbl_nrolotes"
        Me.Lbl_nrolotes.Size = New System.Drawing.Size(67, 16)
        Me.Lbl_nrolotes.TabIndex = 20
        Me.Lbl_nrolotes.Text = "Nro Lote"
        Me.Lbl_nrolotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_tiporema
        '
        Me.Lbl_tiporema.AutoSize = True
        Me.Lbl_tiporema.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_tiporema.Location = New System.Drawing.Point(9, 79)
        Me.Lbl_tiporema.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_tiporema.Name = "Lbl_tiporema"
        Me.Lbl_tiporema.Size = New System.Drawing.Size(98, 16)
        Me.Lbl_tiporema.TabIndex = 19
        Me.Lbl_tiporema.Text = "Tipo Remate"
        '
        'Lbl_fecharema
        '
        Me.Lbl_fecharema.AutoSize = True
        Me.Lbl_fecharema.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_fecharema.Location = New System.Drawing.Point(9, 59)
        Me.Lbl_fecharema.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_fecharema.Name = "Lbl_fecharema"
        Me.Lbl_fecharema.Size = New System.Drawing.Size(109, 16)
        Me.Lbl_fecharema.TabIndex = 18
        Me.Lbl_fecharema.Text = "Fecha Remate"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 16)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Remate"
        '
        'Cmb_remates
        '
        Me.Cmb_remates.FormattingEnabled = True
        Me.Cmb_remates.Location = New System.Drawing.Point(8, 32)
        Me.Cmb_remates.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Cmb_remates.Name = "Cmb_remates"
        Me.Cmb_remates.Size = New System.Drawing.Size(295, 21)
        Me.Cmb_remates.TabIndex = 16
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Lbl_descripcion)
        Me.GroupBox2.Controls.Add(Me.Lbl_lotem)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(325, -2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 330)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(32, 277)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(96, 28)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Impares"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Txt_garantia)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(19, 157)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(586, 107)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Btn_grabar)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Location = New System.Drawing.Point(105, 48)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(290, 55)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        '
        'Btn_grabar
        '
        Me.Btn_grabar.Font = New System.Drawing.Font("Wide Latin", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.Btn_grabar.Location = New System.Drawing.Point(132, 19)
        Me.Btn_grabar.Name = "Btn_grabar"
        Me.Btn_grabar.Size = New System.Drawing.Size(37, 34)
        Me.Btn_grabar.TabIndex = 12
        Me.Btn_grabar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_grabar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Wide Latin", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(209, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 34)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = ">>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Wide Latin", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(15, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Txt_garantia
        '
        Me.Txt_garantia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_garantia.Location = New System.Drawing.Point(148, 16)
        Me.Txt_garantia.Name = "Txt_garantia"
        Me.Txt_garantia.Size = New System.Drawing.Size(207, 29)
        Me.Txt_garantia.TabIndex = 1
        Me.Txt_garantia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Garantía"
        '
        'Lbl_descripcion
        '
        Me.Lbl_descripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Lbl_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_descripcion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_descripcion.Location = New System.Drawing.Point(19, 76)
        Me.Lbl_descripcion.Name = "Lbl_descripcion"
        Me.Lbl_descripcion.Size = New System.Drawing.Size(586, 79)
        Me.Lbl_descripcion.TabIndex = 2
        Me.Lbl_descripcion.Text = "Label3"
        Me.Lbl_descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_lotem
        '
        Me.Lbl_lotem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Lbl_lotem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_lotem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_lotem.Location = New System.Drawing.Point(195, 21)
        Me.Lbl_lotem.Name = "Lbl_lotem"
        Me.Lbl_lotem.Size = New System.Drawing.Size(179, 50)
        Me.Lbl_lotem.TabIndex = 1
        Me.Lbl_lotem.Text = "Label2"
        Me.Lbl_lotem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lote"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(139, 277)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(83, 28)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "Todos"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Frm_garantia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 331)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_garantia"
        Me.Text = "Frm_Garantia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Cmb_remates As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_grabar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Txt_garantia As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents Lbl_lotem As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_nrolotes As System.Windows.Forms.Label
    Friend WithEvents Lbl_tiporema As System.Windows.Forms.Label
    Friend WithEvents Lbl_fecharema As System.Windows.Forms.Label
    Friend WithEvents Btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btn_reporte As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
End Class
