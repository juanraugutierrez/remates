Imports Conexiones

Public Class LoginForm1
    Dim reso As New resolucion
    Public activo As Boolean

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim acc As New acciones


        If Not (String.IsNullOrEmpty(Me.UsernameTextBox.Text) And String.IsNullOrEmpty(Me.PasswordTextBox.Text)) Then
            activo = acc.userValida(Me.UsernameTextBox.Text, PasswordTextBox.Text)
            'remates.tool_usuario.Text = UsernameTextBox.Text
            uactivo = activo
        Else
            MsgBox("Debe ingresar todos los datos", MsgBoxStyle.Critical, "Usuarios")
            End
            Me.Close()
        End If
        If Not (activo) Then
            MsgBox("Usuario o Password invalidas", MsgBoxStyle.Critical, "Usuarios")
            Me.Close()
            End
        End If
        remates.TLbl_version.Text = "Version:  " & My.Settings.vers
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        End
    End Sub



    Private Sub LoginForm1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
        Me.Text = "Sistema de Remates"
        Me.StartPosition = FormStartPosition.CenterParent
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width / 2 - 120
        y = Screen.PrimaryScreen.WorkingArea.Height / 2 - 190
        Me.Location = New Point(x, y)

        Dim ca = New conecta()
        Dim pp As String = ca.conectas()
        If String.IsNullOrEmpty(pp) Then
            MsgBox("No Hay red Disponible", MsgBoxStyle.Critical, "Conexion")
            End
            Me.Close()
            Exit Sub
        End If
        pp = String.Empty
        pp = ca.servidor("192.168.0.200")

        If pp.Contains("No") Then
            MsgBox("Estado de acceso a la BBDD:" + pp, MsgBoxStyle.Critical, "Conexion")
        End If




    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
