
Public Class facturadb

    Inherits EFactura
    Public contex As New persaEntities11
    Property id_cliente() As Integer
    Property nlotes() As Long
    Property id_remate() As Integer
    Property id_ejecutivo() As Integer
    Property id_estado() As Integer
    Property id_nomina() As Integer
    Property id_comuna() As Integer
    Property id_condicionespago() As Integer
    Property ingreso_liquido() As Long
    Property cargo() As Long
    Property fecha() As Date
    Function cargafa()
        Dim fa As New facturas

        fa.id_condicion_pago = id_condicionespago
        fa.id_estado = 1
        fa.id_nomina = 0
        fa.id_ejecutivo = 1
        fa.id_remate = id_remate
        fa.id_cliente = id_cliente
        fa.nro_lotes = nlotes
        fa.id_comuna = id_comuna
        fa.fecha = fecha


        fa.monto_total = Total
        fa.monto_iva = Iva
        fa.monto_ila = Ila
        fa.monto_neto = Neto
        fa.garantia = Garantia
        fa.ingreso_liquido = ingreso_liquido
        fa.monto_comision = comision
        fa.nro_factura = NumeroFactura
        fa.mto_cargos = cargo

        Try
            contex.AddTofacturas(fa)
            contex.SaveChanges()
            contex.AcceptAllChanges()

            Dim idfac As Integer = fa.id_factura
            Return idfac
        Catch ex As Exception
            MsgBox(ex.InnerException.Message, MsgBoxStyle.Critical, " Error")
            Return 0
        End Try


    End Function


    Function cargafa(f As facturas)
        Dim fa As New facturas

        fa.id_condicion_pago = 1
        fa.id_nomina = 0
        fa.id_ejecutivo = 1
        fa.id_remate = f.id_remate
        fa.id_cliente = f.id_cliente
        fa.nro_lotes = 0
        fa.id_comuna = f.id_comuna
        fa.fecha = fecha


        fa.monto_total = Total
        fa.monto_iva = Iva
        fa.monto_ila = Ila
        fa.monto_neto = Neto
        fa.garantia = Garantia
        fa.ingreso_liquido = ingreso_liquido
        fa.monto_comision = Comision
        fa.nro_factura = NumeroFactura
        fa.mto_cargos = cargo

        Try
            contex.AddTofacturas(fa)
            contex.SaveChanges()
            contex.AcceptAllChanges()

            Dim idfac As Integer = fa.id_factura
            Return idfac
        Catch ex As Exception
            MsgBox(ex.InnerException.Message, MsgBoxStyle.Critical, " Error")
            Return 0
        End Try


    End Function

    Sub detalle()


    End Sub


End Class
