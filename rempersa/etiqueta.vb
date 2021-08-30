Imports System.Drawing.Printing
Public Class etiqueta
    Public codigo As String
    Public bodega As String
    Public cantidad As Double
    Public guia As String
    Public usuario As String
    Public descripcion As String
    Public lefmargen As Double
    Public rigthmargen As Double
    Dim linea1 As String
    Dim linea2 As String
    Dim linea3 As String
    Dim linea4 As String
    Dim linea5 As String
    Public tipo As Boolean

    Sub New(ByVal guia As String, ByVal usuario As String, ByVal bodega As String, ByVal codigo As String, ByVal cantidad As Double, ByVal descripcion As String, ByVal tip As Boolean, ByVal tipomerca As String)
        tipo = tip
        If usuario.Length = 0 Then
            'Dim paso() As String
            'paso = RematesKozak.lusuario.Text.Split("|")
            'usuario = Trim(paso(1)).ToUpper
        End If


        linea1 = " REMATES PACIFICO         NGI      " & guia
        linea2 = " " & Now.ToShortDateString & " " & IIf(usuario.Length > 23, usuario.Substring(0, 22).ToUpper, usuario.ToUpper)
        'linea3 = "                                                                       " & bodega
        linea4 = "*" & codigo & "*"
        If String.IsNullOrEmpty(tipomerca) Or tipomerca = "N" Then
            If descripcion.Length > 25 Then
                linea5 = " " & cantidad & "Unid.   " & Trim(descripcion.Substring(0, 24))
            ElseIf descripcion.Length >= 1 And descripcion.Length <= 25 Then
                linea5 = " " & cantidad & "  Unid.   " & descripcion
            Else
                linea5 = " " & cantidad & "Unid.   "

            End If
        Else
            If descripcion.Length > 25 Then
                linea5 = " " & cantidad & "Unid. " & tipomerca.ToUpper & " " & Trim(descripcion.Substring(0, 24))
            ElseIf descripcion.Length >= 1 And descripcion.Length <= 25 Then
                linea5 = " " & cantidad & "  Unid. " & tipomerca.ToUpper & " " & descripcion
            Else
                linea5 = " " & cantidad & "Unid. " & tipomerca.ToUpper

            End If
        End If


        impetiqueta()
    End Sub


    Public Sub impetiqueta()

        Dim printDoc As New PrintDocument
        AddHandler printDoc.PrintPage, AddressOf print_PrintPage
        Dim prtPrev As New PrintPreviewDialog
        Dim ssize As New System.Drawing.Size(504, 400)
        Dim a As New System.Drawing.Printing.PaperSize("etiqueta (50 x 30 mm)", 194, 116)
        Dim margins As New Margins(5, 5, 10, 10)
        printDoc.DefaultPageSettings.Margins = margins
        printDoc.DefaultPageSettings.PaperSize = a
        printDoc.DefaultPageSettings.Landscape = False


        If Me.tipo Then
            prtPrev.Document = printDoc
            prtPrev.Text = "Previsualizar documento"
            prtPrev.ShowDialog()
        End If

        printDoc.Print()


    End Sub

    Private Sub print_PrintPage(ByVal sender As Object, _
                               ByVal e As PrintPageEventArgs)
        ' Este evento se producirá cada vez que se imprima una nueva página


        ' imprimimos la cadena en el margen izquierdo
        Dim i As Integer = 1
        'Dim letra As Array
        'Dim letras As String
        Dim posd As Integer = 0
        Dim xPos As Single = e.MarginBounds.Left
        ' La fuente a usar
        Dim prFont As New Font("Arial Narrow", 8, FontStyle.Bold)
        Dim prFont1 As New Font("Times New Roman", 6, FontStyle.Bold)
        Dim prFont2 As New Font("Arial Narrow", 6, FontStyle.Bold)
        Dim prFont3 As New Font("Arial Black", 6, FontStyle.Bold)
        Dim prFont6 As New Font("C39HrP48DhTt", 48, FontStyle.Regular)

        ' la posición superior
        Dim yPos As Single = prFont.GetHeight(e.Graphics)

        '


        e.Graphics.DrawString(linea1, prFont, Brushes.Black, 1, 1)
        e.Graphics.DrawString(linea2, prFont1, Brushes.Black, 1, 14)
        'e.Graphics.DrawString(linea3, prFont2, Brushes.Black, 1, 15)
        e.Graphics.DrawString(linea4, prFont6, Brushes.Black, 1, 26)
        e.Graphics.DrawString(linea5, prFont3, Brushes.Black, 1, 94)

        e.HasMorePages = False


    End Sub
End Class
