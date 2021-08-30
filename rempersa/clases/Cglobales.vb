Public Class Cglobales



    Public nfactura As Integer = 0
    Public nntcredito As Integer = 0
    Public nguia As Integer = 0
    Public nliquidacion As Integer = 0

    Sub valoresini()

        Me.nfactura = My.Settings.nfactura
        Me.nntcredito = My.Settings.nntcredito


    End Sub
    Sub modificafac(fac As Integer)
        My.Settings.nfactura = fac
        My.Settings.Save()
        valoresini()
    End Sub

    Sub modificafac()
        My.Settings.nfactura += 1
        My.Settings.Save()
        valoresini()
    End Sub




End Class
