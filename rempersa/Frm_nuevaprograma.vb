Public Class Frm_nuevaprograma

    Private Sub Frm_nuevaprograma_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        fecha_inicio.CustomFormat = "dd-MM-yyyy HH:mm"
        fecha_fin.CustomFormat = "dd-MM-yyyy HH:mm"
    End Sub

    Private Sub button1_Click(sender As System.Object, e As System.EventArgs) Handles button1.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub button2_Click(sender As System.Object, e As System.EventArgs) Handles button2.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class