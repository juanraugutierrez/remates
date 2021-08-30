Imports System.IO

Public Class exportfactura
    Public contex As New persaEntities11

    Public Class registro
        Public Cuenta As String = "1104-01"
        Public rut As String
        Public dverificador As String
        Public cliente As String
        Public dia As String
        Public mes As String
        Public año As String
        Public ndoc As String
        Public ldetalle As String
        Public tdocumento As String
        Public diav As String
        Public mesv As String
        Public añov As String
        Public cuentaasoc As String
        Public neto As String
        Public iva As String
        Public ccosto As String
        Public mescontable As String
        Public añocontable As String
        Public nboletafin As String
        Public csucursal As String
        Sub New()

        End Sub
    End Class

    Dim listado As New List(Of facturas)

    Sub New()

    End Sub

    Sub procesafacturas(fechaini As DateTime, fechafinal As DateTime, archivo As String)
        Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Try
            Dim mmm As Double = 0

            Using outputFile As New StreamWriter(mydocpath & Convert.ToString("\" + archivo + ".csv"))

                listado = (From f In contex.facturas Where f.fecha >= fechaini And f.fecha <= fechafinal
                           Select f).ToList()
                Dim i As Integer = 1
                For Each l In listado
                    Dim r As New registro
                    Dim line As String = String.Empty



                    r.año = CDate(l.fecha.Value).Year
                    r.mes = CDate(l.fecha.Value).Month
                    r.dia = CDate(l.fecha.Value).Day
                    r.diav = CDate(l.fecha.Value).Day
                    r.mesv = CDate(l.fecha.Value).Month
                    r.añov = CDate(l.fecha.Value).Year
                    r.dverificador = dvrut(l.id_cliente)(1)
                    r.rut = dvrut(l.id_cliente)(0)
                    r.cliente = bcliente(l.id_cliente)
                    r.ndoc = l.nro_factura
                    r.ldetalle = "1"
                    r.tdocumento = "1"
                    r.cuentaasoc = "5101-01"
                    r.neto = (l.monto_comision + l.mto_cargos).ToString
                    mmm = (l.monto_comision + l.mto_cargos) * 0.19
                    r.iva = Math.Round(mmm, MidpointRounding.AwayFromZero)
                    r.ccosto = String.Empty
                    r.mescontable = CDate(l.fecha.Value).Month
                    r.añocontable = CDate(l.fecha.Value).Year
                    r.nboletafin = 1
                    r.csucursal = String.Empty
                    line = String.Concat(r.Cuenta.PadRight(12, " "), ";", r.rut.PadLeft(8), ";", r.dverificador.PadLeft(1), ";", r.cliente.PadRight(120), ";", r.dia.PadLeft(2, "0"), ";", r.mes.PadLeft(2, "0"), ";", r.año.PadLeft(4, "0"), ";", r.ndoc.PadLeft(9, "0"), ";", r.ldetalle.PadLeft(4, "0"), ";", r.tdocumento.PadLeft(2, "0"), ";", r.diav.PadLeft(2, "0"), ";", r.mesv.PadLeft(2, "0"), ";", r.añov.PadLeft(4, "0"), ";", r.cuentaasoc.PadRight(12, " "), ";", r.neto.PadLeft(9, "0"), ";", r.iva.PadLeft(9, "0"), ";", "", ";", r.mescontable.PadLeft(2, "0"), ";", r.añocontable.PadLeft(4, "0"), ";", "", ";", "")
                    outputFile.WriteLine(line)

                    r.cuentaasoc = "2105-05"
                    mmm = 0
                    mmm = l.monto_total - ((l.monto_comision + l.mto_cargos) * 1.19)
                    r.neto = Math.Round(mmm, MidpointRounding.AwayFromZero)
                    r.iva = 0


                    line = String.Concat(r.Cuenta.PadRight(12, " "), ";", r.rut.PadLeft(8), ";", r.dverificador.PadLeft(1), ";", r.cliente.PadRight(120), ";", r.dia.PadLeft(2, "0"), ";", r.mes.PadLeft(2, "0"), ";", r.año.PadLeft(4, "0"), ";", r.ndoc.PadLeft(9, "0"), ";", r.ldetalle.PadLeft(4, "0"), ";", r.tdocumento.PadLeft(2, "0"), ";", r.diav.PadLeft(2, "0"), ";", r.mesv.PadLeft(2, "0"), ";", r.añov.PadLeft(4, "0"), ";", r.cuentaasoc.PadRight(12, " "), ";", r.neto.PadLeft(9, "0"), ";", r.iva.PadLeft(9, "0"), ";", "", ";", r.mescontable.PadLeft(2, "0"), ";", r.añocontable.PadLeft(4, "0"), ";", "", ";", "")
                    outputFile.WriteLine(line)





                    i += 1
                Next
            End Using
            MsgBox("Archivo Generado", MsgBoxStyle.Critical, "Archivo Generado")
        Catch ex As Exception
            MsgBox("Archivo no generado con el error" + vbCrLf + ex.Message + vbCrLf + ex.InnerException.Message, MsgBoxStyle.Critical, "Archivo Generado")
        End Try
    End Sub

    Function dvrut(id As Integer) As String()
        Dim rrut() As String
        Dim var As String

        var = (From c In contex.clientes Where c.id_cliente = id Select c.rut).FirstOrDefault()
        var = var.Replace(".", "")
        rrut = Split(var, "-")
        Return rrut
    End Function
    Function bcliente(id As Integer) As String
        Dim cliente As String
        Dim var As String

        var = (From c In contex.clientes Where c.id_cliente = id Select c.razon_social).FirstOrDefault()
        cliente = var.ToUpperInvariant().TrimEnd()

        Return cliente
    End Function





End Class
