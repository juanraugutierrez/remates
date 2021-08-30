Public Class LiquidacionView
    Public id_liquidacion As Integer
    Public comuna As String
    Public razon_social As String
    Public giro As String
    Public direccion As String
    Public fecha As Nullable(Of Date)
    Public nro_liquidacion As Integer
    Public monto_neto As Long
    Public monto_impuestoreca As Nullable(Of Long)
    Public mto_comision As Long
    Public monto_iva As Long
    Public monto_ila As Nullable(Of Long)
    Public monto_flete As Nullable(Of Long)
    Public monto_publicidad As Nullable(Of Long)
    Public liquido_apagar As Long
    Public nro_lotes As Integer
    Public rut As String
End Class
