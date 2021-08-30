Public Class Frm_notacreditoVtas

    Dim rema As New Remate
    Dim factu As New factura
    Dim fa As New facturas
    Public contex As New persaEntities11
    Dim remate As Integer
    Dim detalle As New List(Of DetalleNotaView)

    Dim neto As Long
    Dim iva As Long
    Dim comision As Long
    Dim vcomision As Long
    Dim cargo As Long
    Dim total As Long
    Dim garantia As Long
    Dim liquido As Long
    Public id_clien As Integer
    Public id_comuna As Integer

    Dim cliente As String

    Dim dset As New DataSet
    Dim totales As DataTable





    Private Sub Frm_notacreditoVtas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Normal
            Me.StartPosition = FormStartPosition.CenterParent
        Catch

        End Try


    End Sub

    Sub carga()


    End Sub







    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Btn_imprimir.Click

        Try

            If String.IsNullOrEmpty(TxtNotCre.Text) Then
                Exit Sub
            End If

            Dim cnota As New Ccalculanotacredito
            Dim var = (From cl In contex.clientes Where cl.rut = Txt_rut.Text Select cl).FirstOrDefault()
            Dim ncomuna As String = (From co In contex.comunas Where co.id_comuna = var.id_comuna Select co.comuna).FirstOrDefault().ToString()

            Dim detallenc As New List(Of detalle_factura)
            Dim id As Integer
            For Each t In detalle
                If t.NC Then
                    id = t.Id
                    Dim tt = (From de In contex.detalle_factura Where de.id_detalle = id Select de).FirstOrDefault
                    detallenc.Add(tt)
                    id = 0
                End If
            Next
            cnota.recibe_datosdevmerca(var, detallenc, fa, CInt(TxtNotCre.Text))
            MsgBox("Notas de Credito Generada", MsgBoxStyle.Critical, "Nota de Credito")


        Catch ex As Exception
            MsgBox("Notas de Credito NO Generada", MsgBoxStyle.Critical, "Nota de Credito")
        End Try

        Me.Frm_notacreditoVtas_Load(Me, e)



    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub GroupBox3_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label17_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Btn_actualizar_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub Btn_buscaclientes_Click(sender As System.Object, e As System.EventArgs) Handles Btn_buscaclientes.Click
        Frm_clientes.Btn_asignar.Enabled = True
        Frm_clientes.Btn_asignar.Visible = True
        Frm_clientes.Btn_eliminar.Visible = False

        Frm_clientes.ShowDialog()
    End Sub

    Private Sub Btn_limpiar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_limpiar.Click
        For Each c As Control In Me.GroupBox1.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = String.Empty
            End If
        Next
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Frm_clientes.Btn_asignar.Enabled = True
        Frm_clientes.Btn_asignar.Visible = True
        Frm_clientes.formulario = Me

        Frm_clientes.ShowDialog()
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)

        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Return) Then
            Try
                Dim total As Double = 0
                Dim unidades As Integer = 0
                Dim precio_unitario As Double = 0





            Catch ex As Exception
                MsgBox("Hubo en error al cargar los datos del adjudicatario, revise  y corrija", MsgBoxStyle.Critical, "Adjudicatarios")


            End Try




        End If

    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)


        carga()
        rtotales()


    End Sub

    Sub rtotales()

        neto = 0
        iva = 0
        total = 0

        For Each t In Dtg_item.Rows
            neto += t.Cells(3).value
        Next
        iva = 0


        total = neto + iva

        Me.Txt_neto.Text = Format(neto, "$ #,##0")
        Me.Txt_iva.Text = Format(iva, "$ #,##0")
        Me.Txt_total.Text = Format(total, "$ #,##0")


    End Sub

    Private Sub Rdb_prefactura_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            Dim var = (From f In contex.facturas Where f.nro_factura = TxtNfactura.Text And f.fecha > "01-02-2017" Select f).FirstOrDefault()
            fa = var
            Dim clien = (From cl In contex.clientes Where cl.id_cliente = var.id_cliente Select cl).FirstOrDefault()
            Me.Txt_direccion.Text = clien.direccion.ToUpper()
            Me.Txt_giro.Text = clien.giro.ToUpper()
            Me.Txt_razonsocial.Text = clien.razon_social.ToString()
            Me.Txt_rut.Text = clien.rut.ToUpper()
            Me.TxtFecha.Text = var.fecha.ToString()

            Dim ncomuna As String = (From co In contex.comunas Where co.id_comuna = var.id_comuna Select co.comuna).FirstOrDefault().ToString()
            Me.Txt_Comuna.Text = ncomuna.ToUpper()


            fa = Nothing






            detalle = (From de In contex.detalle_factura Where de.id_factura = var.id_factura Select New DetalleNotaView With {.Id = de.id_detalle, .nro_lote = de.nro_lote, .sublote = de.sub_lote, .descripcion = de.descripcion, .cantidad = de.cantidad, .precioU = de.precio_unitario, .precio = de.precio_total, .NC = False}).ToList()
            Dtg_item.DataSource = detalle
            Dtg_item.RowHeadersVisible = False

            Dim ancho = Me.Dtg_item.Width

            With Me.Dtg_item

                .Columns(1).HeaderText = "N° Lote"
                .Columns(2).HeaderText = "Sub Lote"
                .Columns(3).HeaderText = "Descipcion"
                .Columns(4).HeaderText = "Unidades"
                .Columns(5).HeaderText = "V. Unitario"
                .Columns(6).HeaderText = "V. Total"
                .Columns(7).HeaderText = "N°C°"
                .Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Public Property Id As Integer
                'Public Property nro_lote As Integer
                'Public Property sublote As String
                'Public Property descripcion As String
                'Public Property cantidad As String
                'Public Property precioU As Double
                'Public Property precio As Double
                'Public Property NC As Boolean
                .Columns(0).Visible = False

                .Columns(4).DefaultCellStyle.Format = " #,##0"
                .Columns(5).DefaultCellStyle.Format = "$ #,##0"
                .Columns(6).DefaultCellStyle.Format = "$ #,##0"


                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(1).Width = ancho * 0.07
                .Columns(2).Width = ancho * 0.07
                .Columns(3).Width = ancho * 0.4
                .Columns(4).Width = ancho * 0.08
                .Columns(5).Width = ancho * 0.11
                .Columns(6).Width = ancho * 0.11
                .Columns(7).Width = ancho * 0.09




            End With

        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Private Sub Dtg_item_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dtg_item.CellContentClick
        neto = 0
        iva = 0
        total = 0
        comision = 0

        Dim idl As Integer
        idl = Me.Dtg_item.Rows(e.RowIndex).Cells(0).Value
        For Each t In detalle
            If t.Id = idl Then
                t.NC = Not (t.NC)
            End If
            If t.NC Then
                neto = neto + t.precio
                comision = neto * My.Settings.comision
            End If
        Next

        iva = Math.Ceiling((neto + comision) * 0.19)

        total = neto + +comision + iva

        Me.Txt_neto.Text = neto.ToString("$ #,##0")
        Me.Txt_Comision.Text = comision.ToString("$ #,##0")
        Me.Txt_iva.Text = iva.ToString("$ #,##0")
        Me.Txt_total.Text = total.ToString("$ #,##0")


    End Sub


End Class