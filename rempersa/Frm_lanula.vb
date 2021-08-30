Public Class Frm_lanula
    Dim reso As New resolucion
    Dim fac = New facturas
    Dim lisfac As New lliquidacion
    Private Sub Btn_buscar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_buscar.Click
        Try
            If IsNumeric(Txt_buscar.Text) Then
                Dim fecha = DateAdd(DateInterval.Day, -30, Now)
                fac = (From l In contex.liquidacion Where l.fecha >= fecha And l.nro_liquidacion = CInt(Txt_buscar.Text) Select l).ToList()

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

        '**************************************

        Try
            Dim nro As String
            nro = InputBox("Ingrese nro de liquidacion")
            Dim idfactura As Integer
            Dim liqu As New liquidacion
            idfactura = Dtg_facturas.Rows(0).Cells(0).Value
            liqu = (From l In contex.liquidacion Where l.id_liquidacion = idfactura Select l).FirstOrDefault()


            Dim liquiele As New factura_electronica.dte_liquidacion

            liquiele.esquema()

            Dim hoy As String = String.Concat(Now.Year.ToString(), "-", Now.Month.ToString("0#"), "-", Now.Day.ToString("0#"))

            liquiele.docucabecera("43", nro, hoy)
            liquiele.docuemisor("76520318-K", "Remates Persa Spa", "Remates", "726000", "Camino Lo Boza 8410, Galpon 5", "Renca", "Santiago")


            Dim repec As New receptorview
            repec = (From ma In contex.mandantes Where ma.id_mandante = liqu.id_mandante Select New receptorview With {.razonsocial = ma.razonsocial_mandante, .giro = ma.giro, .rut = ma.rut_mandante, .direccion = ma.direccion_mandante, .ciudad = "", .comuna = ma.id_comuna}).FirstOrDefault()
            repec.comuna = (From co In contex.comunas Where co.id_comuna = repec.comuna Select co.comuna).FirstOrDefault()
            repec.ciudad = "  "
            If repec.giro.Length > 40 Then
                repec.giro = repec.giro.Substring(0, 40)
            End If
            If repec.razonsocial.Length > 40 Then
                repec.razonsocial = repec.razonsocial.Substring(0, 40)
            End If
            If repec.direccion.Length > 69 Then
                repec.direccion = repec.direccion.Substring(0, 69)
            End If
            liquiele.docureceptor(repec.rut, repec.razonsocial, repec.giro, repec.direccion, repec.comuna, repec.ciudad)
            liquiele.docutotaliqui(String.Concat("-", liqu.mto_neto.ToString()), "19", String.Concat("-", liqu.mto_impreacudado.ToString()), String.Concat("-", liqu.liquido.ToString()), String.Copy(liqu.comision.ToString()), String.Concat("-", liqu.iva.ToString()))
            liquiele.docucomision("1", "C", "COMISION MARTILLERO", liqu.tasa_comision.ToString(), String.Concat("-", liqu.comision.ToString()), 0, String.Concat("-", liqu.iva.ToString()))

            liquiele.docudetalle("1", "ANULA LIQUIDACION FACTURA N° " & liqu.nro_liquidacion, 1, "UNID", liqu.mto_neto.ToString(), String.Concat("-", liqu.mto_neto.ToString()), " ", " ")
            Dim ff As String = String.Concat("SON: ", Num2Text(liqu.liquido.ToString()).ToUpper(), " PESOS.-")

            liquiele.docureferencia("1", "43", liqu.nro_liquidacion, String.Concat(liqu.fecha.Value.Year, "-", liqu.fecha.Value.Month.ToString("0#"), "-", liqu.fecha.Value.Day.ToString("0#")), "1", "ANULA LIQUIDACION")

            liquiele.docuadjuntos(ff, "TOSHIBA e-STUDIO451c PS3", "3")
            liquiele.grabal(String.Concat("Liquidacionfctura_P_", nro.ToString()), "c:\xml_factura\")
            liquiele.grabal(String.Concat("Liquidacionfctura_", nro.ToString()), My.Settings.rutafac)

            Dim mm As New liquidacion
            Dim neto As Long = 0
            Dim iva As Long = 0
            Dim ila As Long = 0
            Dim comision As Long = 0
            Dim cargo As Long = 0
            Dim total As Long = 0
            Dim garantia As Long = 0
            Dim liquido As Long = 0
            Dim fletes As Long = 0
            Dim publicidad As Long = 0
            Dim impues_recaudado As Long = 0

            mm.comision = liqu.comision * -1
            mm.id_mandante = liqu.id_mandante
            mm.tasa_comision = liqu.tasa_comision
            mm.mto_neto = liqu.mto_neto * -1
            mm.mto_impreacudado = liqu.mto_impreacudado * -1
            mm.iva = liqu.iva * -1
            mm.mto_ila = liqu.mto_ila * -1
            mm.liquido = liqu.liquido * -1
            mm.nro_liquidacion = nro
            mm.nro_lotes = 1
            mm.publicidad = liqu.publicidad * -1
            mm.flete = liqu.flete * 1
            mm.fecha = Now.ToShortDateString & " " & Now.ToLongTimeString

            Dim liqu3 As New liquidaciones
            Dim id_Factu As Integer = liqu3.carga(mm)
            Dim ppp As New detalle_liquidacion
            Dim ppp1 As New detalle_liquidacion
            Try

                'ppp = (From de In contex.detalle_liquidacion Where de.id_liquidacion = -1 Select de).FirstOrDefault()
                ppp.id_liquidacion = liqu.id_liquidacion
                ppp.id_lote = 1
                ppp.descripcion = "ANULA LIQUIDACION FACTURA N° " & liqu.nro_liquidacion
                ppp.unidades = 1
                ppp.precio_unitario = liqu.mto_neto * -1
                ppp.precio_unitario = liqu.mto_neto * -1
                ppp.afecto = 1
                ppp.mandante = (From m In contex.mandantes Where m.id_mandante = liqu.id_mandante Select m.id_mandante).FirstOrDefault()



                contex.AddTodetalle_liquidacion(ppp)
                contex.SaveChanges()
                contex.AcceptAllChanges()
            Catch ex As Exception

            End Try









        Catch ex As Exception
            MsgBox("error al tratar de anular factura", MsgBoxStyle.Critical, "Anulacion de facturas")
            Exit Sub
        End Try

        '*************************************************************

        MsgBox(lisfac.anula(Dtg_facturas.Rows(0).Cells(2).Value), MsgBoxStyle.Critical, "Anulacion de Liquidaciones")
        Me.Refresh()
        Me.Txt_buscar.Text = String.Empty

        Dtg_facturas.DataSource = Nothing
        Dtg_facturas.Refresh()


    End Sub



End Class