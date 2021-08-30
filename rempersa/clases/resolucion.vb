Public Class resolucion


    Sub ajustarResolucion(formulario As System.Windows.Forms.Form)
        Dim ancho As String = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Width.ToString()
        Dim alto As String = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height.ToString()
        Dim tamaño As String = ancho + "x" + alto
        Select tamaño
            Case Is = "800x600"
                cambiarResolucion(formulario, 110.0, 110.0)
            Case Is = "1024x600"
                cambiarResolucion(formulario, 100.0, 110.0)
            Case Is = "1024x768"
                cambiarResolucion(formulario, 125.0, 118.0)
            Case Is = "1366x768"
                Exit Sub
            Case Else
                cambiarResolucion(formulario, 86.0, 96.0)
        End Select
    End Sub

    Private Sub cambiarResolucion(formulario As System.Windows.Forms.Form, ancho As Decimal, alto As Decimal)
        formulario.AutoScaleDimensions = New System.Drawing.SizeF(ancho, alto)
        formulario.PerformAutoScale()
    End Sub

End Class
