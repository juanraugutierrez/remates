Public Class Frm_guias

    Public id_comuna, id_clien As Integer
    Public Ldetalle As List(Of DetalleGuiaView)
    Public i As Integer = 0
    Public MtoAfecto As Long = 0
    Public MtoExcento As Long = 0
    Public MtoIva As Long = 0
    Public MtoTotal As Long = 0


    Public detalle As DetalleGuiaView = Nothing

    Private Shared frmInstance As Frm_guias = Nothing

    Public Shared Function Instance() As Form
        If frmInstance Is Nothing OrElse frmInstance.IsDisposed = True Then
            frmInstance = New Frm_guias
        End If
        frmInstance.BringToFront()
        Return frmInstance
    End Function


    Private Sub Frm_guias_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Ldetalle = New List(Of DetalleGuiaView)
        i = 0
        Me.Text = "Guias de Despacho"
        If RdbClientes.Checked Then
            Grp_mandante.Visible = True
        Else
            Grp_mandante.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

        If RdbClientes.Checked Then
            Frm_clientes.Btn_asignar.Enabled = True
            Frm_clientes.Btn_asignar.Visible = True
            Frm_clientes.RdbNombre.Checked = True
            Frm_clientes.formulario = Me
            Frm_clientes.ShowDialog(Me)
        End If


        If RdbMandantes.Checked Then
            Frm_mandantes.Btn_asignar.Enabled = True
            Frm_mandantes.Btn_asignar.Visible = True
            Frm_mandantes.RdbNombre.Checked = True
            Frm_mandantes.formulario = Me
            Frm_mandantes.ShowDialog()
        End If

    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub GroupBox5_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub Txt_comision_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtExcento.TextChanged

    End Sub

    Private Sub RdbClientes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RdbClientes.CheckedChanged

        btnLimpiar_Click(Me, e)

        If RdbClientes.Checked Then
            Grp_mandante.Visible = True
            CmbMandante.DataSource = Nothing
            CmbMandante.DataSource = (From m In contex.mandantes Select m).ToList()
            CmbMandante.DisplayMember = "razonsocial_mandante"
            CmbMandante.ValueMember = "id_mandante"

        Else
            Grp_mandante.Visible = False
            CmbMandante.DataSource = Nothing
        End If
    End Sub

    Private Sub RdbSinVta_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RdbSinVta.CheckedChanged
        If RdbSinVta.Checked Then
            Label13.Visible = False
            Txt_vunitario.Visible = False
            Txt_vunitario.Text = 0
        Else
            Label13.Visible = False
            Txt_vunitario.Visible = True
        End If
    End Sub

    Private Sub Btn_limpiar_Click(sender As System.Object, e As System.EventArgs)
        For Each c As Control In Me.GroupBox2.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = String.Empty
            End If
        Next
        id_clien = Nothing
        id_comuna = Nothing
    End Sub

    Private Sub RdbMandantes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RdbMandantes.CheckedChanged
        btnLimpiar_Click(Me, e)
    End Sub

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click

        id_clien = Nothing
        id_comuna = Nothing

        For Each c As Control In Me.GroupBox2.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = String.Empty
            End If
        Next
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click

        If RdbClientes.Checked Then
            Frm_clientes.Btn_asignar.Enabled = True
            Frm_clientes.Btn_asignar.Visible = True
            Frm_clientes.RdbNombre.Checked = True
            Frm_clientes.formulario = Me
            Frm_clientes.ShowDialog(Me)
        End If

        If RdbMandantes.Checked Then
            Frm_mandantes.Btn_asignar.Enabled = True
            Frm_mandantes.Btn_asignar.Visible = True
            Frm_mandantes.RdbNombre.Checked = True
            Frm_mandantes.formulario = Me
            Frm_mandantes.ShowDialog()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click

        Try


            If RdbClientes.Checked Then
                i += 1
                detalle = Nothing
                detalle = New DetalleGuiaView
                detalle.Id = i
                detalle.descripcion = Txt_descripcion.Text.ToUpper()

                detalle.cantidad = Txt_unidades.Text
                detalle.precioU = CDbl(Txt_vunitario.Text)
                detalle.afecto = ChkAfecto.Checked

                For Each c As Control In Me.GroupBox4.Controls
                    If TypeOf (c) Is TextBox Then
                        c.Text = String.Empty
                    End If
                Next
                If RdbSinVta.Checked Then
                    Txt_vunitario.Text = 0
                End If



                detalle.precio = detalle.precioU * detalle.cantidad
                detalle.idMandante = CmbMandante.SelectedValue
                Ldetalle.Add(detalle)
                detalle = Nothing
                DtgArticulos.DataSource = Nothing
                DtgArticulos.DataSource = Ldetalle
                DtgArticulos.Refresh()
            End If
        Catch ex As Exception

        End Try


        Try


            If RdbMandantes.Checked Then
                i += 1
                detalle = Nothing
                detalle = New DetalleGuiaView
                detalle.Id = i
                detalle.descripcion = Txt_descripcion.Text.ToUpper()
                detalle.cantidad = CInt(Txt_unidades.Text)
                detalle.precioU = CDbl(Txt_vunitario.Text)
                DtgArticulos.Refresh()

                For Each c As Control In Me.GroupBox4.Controls
                    If TypeOf (c) Is TextBox Then
                        c.Text = String.Empty
                    End If
                Next
                If RdbSinVta.Checked Then
                    Txt_vunitario.Text = 0
                End If


                detalle.precio = detalle.precioU * detalle.cantidad
                detalle.afecto = ChkAfecto.Checked
                detalle.idMandante = (From m In contex.mandantes Where m.rut_mandante = Txt_rut.Text Select m.id_mandante).FirstOrDefault()
                Ldetalle.Add(detalle)
                detalle = Nothing
                DtgArticulos.DataSource = Nothing
                DtgArticulos.DataSource = Ldetalle

            End If
        Catch ex As Exception

        End Try
        carga()
    End Sub

    Sub carga()

        With Me.DtgArticulos

            .RowHeadersVisible = False
            .Columns(0).DisplayIndex = 0
            .Columns(1).DisplayIndex = 1
            .Columns(2).DisplayIndex = 2
            .Columns(3).DisplayIndex = 3
            .Columns(4).DisplayIndex = 4

            .Columns(2).DefaultCellStyle.Format = " #,##0"
            .Columns(3).DefaultCellStyle.Format = "$ #,##0"
            .Columns(4).DefaultCellStyle.Format = "$ #,##0"





            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight



            Dim ancho As Integer
            ancho = .Width

            .Columns(0).Width = ancho * 0.07
            .Columns(1).Width = ancho * 0.45
            .Columns(2).Width = ancho * 0.08
            .Columns(3).Width = ancho * 0.15
            .Columns(4).Width = ancho * 0.15
            .Columns(7).Width = ancho * 0.06


            .Columns(0).HeaderText = "Orden"
            .Columns(1).HeaderText = "Descripcion"
            .Columns(2).HeaderText = "Cantidad"
            .Columns(3).HeaderText = "Precio Unitario"
            .Columns(4).HeaderText = "Total"
            .Columns(7).HeaderText = "Afecto"

            .Columns(5).Visible = False
            .Columns(6).Visible = False
        End With

        MtoAfecto = 0
        MtoExcento = 0
        MtoIva = 0
        MtoTotal = 0


        For Each l In Ldetalle

            If l.afecto Then
                MtoAfecto += l.precio
            Else
                MtoExcento += l.precio
            End If
        Next

        MtoIva = Math.Ceiling(MtoAfecto * 0.19)
        MtoTotal = MtoAfecto + MtoExcento


        TxtAfecto.Text = MtoAfecto.ToString("$ #,##0")
        TxtExcento.Text = MtoExcento.ToString("$ #,##0")
        TxtIva.Text = MtoIva.ToString("$ #,##0")
        TxtTotal.Text = MtoTotal.ToString("$ #,##0")

    End Sub

    Private Sub Txt_iva_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtIva.TextChanged

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Btn_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Btn_imprimir.Click


        If RdbClientes.Checked Then
            Dim guiag As New CcalculaGuia

        End If
    End Sub
End Class