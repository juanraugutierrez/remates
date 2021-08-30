Imports System.Threading
Public Class Frm_monitor
    Public ser As New List(Of serie)
    Public ser1 As New List(Of serie)
    Dim t As Thread

    Friend Sub Frm_monitor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        Dim seri As New serie
        seri.hormin = Now.Hour.ToString() & " " & Now.Minute.ToString
        seri.valor = Math.Ceiling(Math.Sin((Now.Minute + 90 / 10) / Math.PI))

        ser.Add(seri)

        seri.valor = Math.Ceiling(Math.Cos((Now.Minute + 90 / 10) / Math.PI))
        ser1.Add(seri)
        actualiza()




        't = New Thread(AddressOf Me.ProcesodeFondo)

        Me.t = New Thread(New ThreadStart(AddressOf Me.ProcesodeFondo))

        For Each r In ser
            ChartGraph.Series("Adjudicados").Points.AddXY(r.hormin, r.valor)
        Next
        For Each r In ser1
            ChartGraph.Series("Garantias").Points.AddXY(r.hormin, r.valor)
        Next


        ChartGraph.Series.Clear()
        ChartGraph.Refresh()
    End Sub
    Public Sub ProcesodeFondo()


        Dim seri As New serie
        seri.hormin = Now.Hour.ToString() & " " & Now.Minute.ToString
        seri.valor = Math.Ceiling(Math.Sin((Now.Minute + 90 / 10) / Math.PI))

        ser.Add(seri)

        seri.valor = Math.Ceiling(Math.Cos((Now.Minute + 90 / 10) / Math.PI))
        ser1.Add(seri)
        actualiza()




        Thread.Sleep(10)

    End Sub

    Public Sub actualiza()

        ChartGraph.Series.Dispose()
        Me.ChartGraph.Series.Add("Adjudicados")
        Me.ChartGraph.Series.Add("Garantias")


        For Each r In ser
            ChartGraph.Series("Adjudicados").Points.AddXY(r.hormin, r.valor)
        Next
        For Each r In ser1
            ChartGraph.Series("Garantias").Points.AddXY(r.hormin, r.valor)
        Next
    End Sub

    Private Sub ChartGraph_Click(sender As System.Object, e As System.EventArgs) Handles ChartGraph.Click

    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If t.ThreadState = ThreadState.Suspended Then
            t.Resume()
        ElseIf t.ThreadState = ThreadState.Stopped Then
            MsgBox("Imposible reiniciar un Hilo despues de abortado", MsgBoxStyle.Critical)
        Else
            t.Start()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        t.Abort()
    End Sub
End Class