Public Class leefacturas
    Public contex As New persaEntities11
    Private Property var As System.Linq.IQueryable(Of persaEntities11)
    Private Property quer As System.Linq.IQueryable
    Public listfac As List(Of facturas)

    Sub New()

    End Sub

    Public Class totales
        Property nfactura As Integer
        Property montototal As Long
        Property montoiva As Long
        Property montocomision As Long
        Property montogarantia As Long
    End Class

    Public Function totalesfacturas(fechainicio As DateTime, fechafinal As DateTime) As totales
        Dim t As New totales
        listfac = (From f In contex.facturas Where f.fecha >= fechainicio And f.fecha <= fechafinal Select f).ToList()

        t.montototal = Aggregate f In contex.facturas
                       Where f.fecha >= fechainicio And f.fecha <= fechafinal And f.id_estado = 1
                       Into Sum(f.monto_neto)

        t.montoiva = Aggregate f In contex.facturas
                      Where f.fecha >= fechainicio And f.fecha <= fechafinal And f.id_estado = 1
                      Into Sum(f.monto_iva)

        t.nfactura = Aggregate f In contex.facturas
                    Where f.fecha >= fechainicio And f.fecha <= fechafinal
                    Into Count(f.nro_factura)

        t.nfactura += 1

        t.montogarantia = Aggregate f In contex.facturas
                     Where f.fecha >= fechainicio And f.fecha <= fechafinal And f.id_estado = 1
                     Into Sum(f.garantia)

        t.montocomision = Aggregate f In contex.facturas
                     Where f.fecha >= fechainicio And f.fecha <= fechafinal And f.id_estado = 1
                     Into Sum(f.monto_comision)
        Return t
    End Function


End Class
