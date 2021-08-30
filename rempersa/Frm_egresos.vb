Public Class Frm_egresos


    Private Shared frmInstance As Frm_egresos = Nothing


    Public Shared Function Instance() As Form
        If frmInstance Is Nothing OrElse frmInstance.IsDisposed = True Then
            frmInstance = New Frm_egresos
        End If
        frmInstance.BringToFront()
        Return frmInstance
    End Function
    Private Sub Frm_egresos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class