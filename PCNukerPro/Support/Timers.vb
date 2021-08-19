Imports System.Timers
Imports Timer = System.Timers.Timer

Module Timers
    Dim oneTimer As Timer = New Timer()
    Public Sub makeTimers()
        oneTimer.Interval = 500
        AddHandler oneTimer.Elapsed, AddressOf oneTimerEvent
        oneTimer.AutoReset = True
        oneTimer.Enabled = True
    End Sub
    Public Sub oneTimerEvent(ByVal source As Object, ByVal e As ElapsedEventArgs)
        Form1.LogsListbox.TopIndex = Form1.LogsListbox.Items.Count - 1
    End Sub
End Module
