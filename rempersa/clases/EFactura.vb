Public Class EFactura
    Public Property NumeroFactura() As Integer
    Public Property Razonsocial() As String
    Public Property Rut() As String
    Public Property Direccion() As String
    Public Property Giro() As String
    Public Property Comuna() As String
    Public Property Telefono() As String


    Public Property Neto() As Long
    Public Property impuesto_recauda() As Long
    Public Property Comision() As Long
    Public Property Cargos() As Long
    Public Property Iva() As Long
    Public Property Ila() As Long
    Public Property Total() As Long
    Public Property Garantia() As Long
    Public Property Liquido() As Long
    Public Property Fletes() As Long

    Public Property Publicidad() As Long
    Public Property FechaFacturacion() As String

    Public Property totaltexto As String

    Public Detail As New List(Of EArticulo)()

End Class
