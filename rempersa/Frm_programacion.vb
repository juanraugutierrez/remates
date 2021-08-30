Imports Calendar

Public Class Frm_programacion
    Dim m_Appointments As New List(Of Appointment)

    Private Sub programacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        DayView1.DaysToShow = 5
        DayView1.StartDate = DateTime.Now

        AddHandler DayView1.NewAppointment, AddressOf dayView1_NewAppointment
        AddHandler DayView1.SelectionChanged, AddressOf dayView1_SelectionChanged
        AddHandler DayView1.ResolveAppointments, AddressOf dayView1_ResolveAppointments

        Refresh()

    End Sub
    Sub dayView1_SelectionChanged(sender As System.Object, e As EventArgs)
        Texto.Text = String.Empty
        If IsNothing(DayView1.SelectedAppointment) Then
            fecha_inicio.Value = DayView1.SelectionStart
            Fecha_fin.Value = DayView1.SelectionEnd
        Else
            fecha_inicio.Value = DayView1.SelectedAppointment.StartDate
            Fecha_fin.Value = DayView1.SelectedAppointment.EndDate
            Texto.Text = DayView1.SelectedAppointment.Title
        End If
    End Sub
    Sub dayView1_ResolveAppointments(sender As System.Object, e As ResolveAppointmentsEventArgs)

        Dim m_Apps As New List(Of Appointment)

        For Each m_App As Appointment In m_Appointments
            If ((m_App.StartDate >= e.StartDate) And (m_App.StartDate <= e.EndDate)) Then
                m_Apps.Add(m_App)
            End If
        Next
        e.Appointments = m_Apps
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        DayView1.StartDate = MonthCalendar1.SelectionStart
    End Sub
    Private Sub dayView1_NewAppointment(sender As System.Object, e As NewAppointmentEventArgs)
        Dim m_Appointment As New Appointment
        m_Appointment.StartDate = e.StartDate
        m_Appointment.EndDate = e.EndDate
        m_Appointment.Title = e.Title
        m_Appointments.Add(m_Appointment)
        DayView1.Refresh()
        Me.Refresh()

    End Sub

    Private Sub DayView1_Click(sender As System.Object, e As System.EventArgs) Handles DayView1.Click


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim testDialog As New Frm_nuevaprograma
        Dim m_App As New Appointment

        If DayView1.SelectionStart >= DateTime.Now Then
            m_App.StartDate = DayView1.SelectionStart
            m_App.EndDate = DayView1.SelectionEnd
            m_App.BorderColor = Color.Red
        Else
            DayView1.SelectionStart = DateTime.Now
            DayView1.SelectionEnd = DateTime.Now.AddHours(1)
            m_App.StartDate = DayView1.SelectionStart
            m_App.EndDate = DayView1.SelectionEnd
        End If


        testDialog.fecha_inicio.Value = DayView1.SelectionStart
        testDialog.fecha_fin.Value = DayView1.SelectionEnd

        If testDialog.ShowDialog = DialogResult.OK Then

            m_App.StartDate = testDialog.fecha_inicio.Value
            m_App.EndDate = testDialog.fecha_fin.Value
            m_App.Title = testDialog.Texto.Text
            m_Appointments.Add(m_App)
        Else
            MessageBox.Show("Cancelado")
        End If
        DayView1.StartDate = MonthCalendar1.SelectionStart
    End Sub

    Private Sub DayView1_AppoinmentMove(sender As System.Object, e As Global.Calendar.AppointmentEventArgs) Handles DayView1.AppoinmentMove

    End Sub

    'Private Sub DayView1_NewAppointment(sender As System.Object, args As Calendar.NewAppointmentEventArgs) Handles DayView1.NewAppointment
    '    Dim m_Appointment As New Appointment
    '    m_Appointment.StartDate = args.StartDate
    '    m_Appointment.EndDate = args.EndDate
    '    m_Appointment.Title = args.Title
    '    m_Appointments.Add(m_Appointment)
    'End Sub


    'Private Sub DayView1_ResolveAppointments(sender As System.Object, args As Calendar.ResolveAppointmentsEventArgs) Handles DayView1.ResolveAppointments
    '    Dim m_Apps As New List(Of Appointment)

    '    For Each m_App As Appointment In m_Appointments
    '        If ((m_App.StartDate >= args.StartDate) And (m_App.StartDate <= args.EndDate)) Then
    '            m_Apps.Add(m_App)
    '        End If
    '        args.Appointments = m_Apps
    '    Next

    'End Sub

    Private Sub NewAppointmentEventHandler(sender As Object, args As NewAppointmentEventArgs)
        Throw New NotImplementedException
    End Sub

    'Private Sub EventHandler(p1 As Object, sender As Object, e As EventArgs)
    '    Throw New NotImplementedException
    'End Sub

    'Private Function dayView1_SelectionChanged() As Object
    '    Throw New NotImplementedException
    'End Function

    Private Sub EventHandler(p1 As Object, sender As Object, e As EventArgs)
        Throw New NotImplementedException
    End Sub

    Private Sub NewAppointmentEventHandler(p1 As Object, sender As Object, args As NewAppointmentEventArgs)
        Throw New NotImplementedException
    End Sub


End Class