Public Class Frm_anula
    Dim reso As New resolucion
    Dim fac = New facturas
    Dim lisfac As New lfacturas

    Private Sub Btn_buscar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_buscar.Click
        Try
            If IsNumeric(Txt_buscar.Text) Then
                fac = lisfac.listafacturas(CInt(Txt_buscar.Text))

                Dtg_facturas.DataSource = fac


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Frm_anula_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        reso.ajustarResolucion(Me)
        Me.Txt_buscar.Text = String.Empty
        Dtg_facturas.RowHeadersVisible = False
    End Sub

    Private Sub Txt_buscar_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_buscar.KeyPress

        If Not IsNumeric(e.KeyChar) And Not (AscW(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Btn_anular_Click(sender As System.Object, e As System.EventArgs) Handles Btn_anular.Click
        Try
            Dim nro As String
            nro = InputBox("Ingrese nro de nota de Credito")
            Dim idfactura As Integer
            Dim cnota As New Ccalculanotacredito
            idfactura = Dtg_facturas.Rows(0).Cells(0).Value
            Dim var As New List(Of detalle_factura)
            Dim var1 As New facturas
            Dim cli As New clientes
            var = (From deta In contex.detalle_factura Where deta.id_factura = idfactura Select deta).ToList()
            var1 = (From factu In contex.facturas Where factu.id_factura = idfactura Select factu).FirstOrDefault()
            cli = (From client In contex.clientes Where client.id_cliente = var1.id_cliente Select client).FirstOrDefault()

            cnota.recibe_datosanula(cli, var, var1, CInt(nro))


        Catch ex As Exception
            MsgBox("error al tratar de anular factura", MsgBoxStyle.Critical, "Anulacion de facturas")
            Exit Sub
        End Try



        MsgBox(lisfac.anula(Dtg_facturas.Rows(0).Cells(0).Value), MsgBoxStyle.Critical, "Anulacion de facturas")
        Me.Refresh()
        Me.Txt_buscar.Text = String.Empty

        Dtg_facturas.DataSource = Nothing
        Dtg_facturas.Refresh()


    End Sub

    Private Sub Btn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_eliminar.Click
        MsgBox(lisfac.elimina(Dtg_facturas.Rows(0).Cells(0).Value), MsgBoxStyle.Critical, "Eliminacion de facturas")
        Me.Refresh()
        Me.Txt_buscar.Text = String.Empty

        Dtg_facturas.DataSource = Nothing
        Dtg_facturas.Refresh()
    End Sub


End Class