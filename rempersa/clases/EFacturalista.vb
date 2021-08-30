Public Class EFacturalista
    Public NumeroFactura As Integer
    Public Razonsocial As String
    Public Rut As String
    Public Direccion As String
    Public Giro As String
    Public Comuna As String
    Public Telefono As String


    Public Neto As Long
    Public impuesto_recauda As Long
    Public Comision As Long
    Public Cargos As Long
    Public Iva As Long
    Public Total As Long
    Public Garantia As Long
    Public Liquido As Long
    Public Fletes As Long

    Public Publicidad As Long
    Public FechaFacturacion As String

    Public totaltexto As String

    Public Detalle As New List(Of EArticulo)()
    Public ll As New lfacturas
    Public t As New Facturaview
    Sub busca(nro As Integer)
        t = ll.muestrafactura(nro)

    End Sub

End Class
