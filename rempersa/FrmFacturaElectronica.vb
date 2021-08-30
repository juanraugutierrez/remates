Imports factura_electronica


Public Class FrmFacturaElectronica

    Private Shared frmInstance As FrmFacturaElectronica = Nothing


    Public Shared Function Instance() As Form
        If frmInstance Is Nothing OrElse frmInstance.IsDisposed = True Then
            frmInstance = New FrmFacturaElectronica
        End If
        frmInstance.BringToFront()
        Return frmInstance
    End Function

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim fecha As DateTime
        Dim fechaf As DateTime

        fecha = DateAdd(DateInterval.Day, -30, Now())
        fechaf = Now()

        Dim fac As List(Of facturas)
        Dim detfaa As List(Of detalle_factura)
        Dim clie As List(Of clientes)
        Dim clieu As clientes
        Dim facelec As New dte_norma
        fac = (From f In contex.facturas Where f.fecha >= "15-09-2016" And f.fecha <= "30-09-2016" Select f).ToList()
        Dim maxi, mini As Integer

        maxi = Aggregate el In fac
             Into Max(el.id_factura)

        mini = Aggregate el In fac
              Into Min(el.id_factura)


        Dim i As Integer = 0
        For Each f In fac
            i += 1
            Dim d As New dte_norma
            d.esquema()
            d.docucabecera("33", f.nro_factura, DateTime.Now.ToString("yyyy-MM-dd"))
            d.docuemisor("76520318-K", "Remates Persa Spa", "Remates", "726000", "Camino Lo Boza 8410, Galpon 5", "Renca", "Santiago")
            Dim ccc As Integer = f.id_cliente.Value

            Dim clierut As String
            Dim clierzon As String
            Dim cliedire As String
            Dim cliecomu As String
            Dim cliecomun As Integer
            Dim cliegiro As String

            clierut = (From cl In contex.clientes Where cl.id_cliente = ccc Select cl.rut).FirstOrDefault()
            clierzon = (From cl In contex.clientes Where cl.id_cliente = ccc Select cl.razon_social).FirstOrDefault()
            cliedire = (From cl In contex.clientes Where cl.id_cliente = ccc Select cl.direccion).FirstOrDefault()
            cliegiro = (From cl In contex.clientes Where cl.id_cliente = ccc Select cl.giro).FirstOrDefault()
            cliecomun = (From cl In contex.clientes Where cl.id_cliente = ccc Select cl.id_comuna).FirstOrDefault()
            cliecomu = (From co In contex.comunas Where co.id_comuna = cliecomun Select co.comuna).FirstOrDefault()
            'cliecomu = (From cl In contex.clientes Join co In contex.comunas On cl.id_comuna Equals co.comuna Where cl.id_cliente = ccc Select co.comuna).FirstOrDefault()

            d.docureceptor(clierut, clierzon, cliegiro, cliedire, cliecomu, "Santiago")

            d.docutotal(f.monto_neto + f.monto_comision + f.mto_cargos, "19.00", f.monto_iva, f.monto_total)
            Dim fff As Integer = f.id_factura

            Dim ii As Integer = 1
            Dim loteT As String
            detfaa = (From df In contex.detalle_factura Where df.id_factura = fff Select df).ToList()
            For Each de In detfaa
                If String.IsNullOrEmpty(de.sub_lote) Then
                    loteT = "Lote:" & de.nro_lote
                Else
                    loteT = "Lote:" & de.nro_lote & " " & de.sub_lote
                End If


                d.docudetalle(ii.ToString(), de.descripcion.ToString() & " (" & loteT & ")", de.cantidad.ToString(), "Lote", de.precio_unitario.ToString(), de.precio_total.ToString())
                ii += 1
            Next
            If f.monto_comision > 0 Then
                d.docudetalle(ii.ToString(), "Comision Martillero", 1, "Lote", f.monto_comision, f.monto_comision)
                ii += 1
            End If
            If f.mto_cargos > 0 Then
                d.docudetalle(ii.ToString(), "Cargo de Facturacion", 1, "Lote", f.mto_cargos, f.mto_cargos)
            End If


            d.docuadjuntos("OBSERVACIONES", "impresora", "1")
            Dim ruta As String = "C:\correo\"
            d.graba("pruebaclase-" & f.nro_factura, ruta)
        Next
        MessageBox.Show("Listo", "grabado")





    End Sub

    Private Sub FrmFacturaElectronica_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class