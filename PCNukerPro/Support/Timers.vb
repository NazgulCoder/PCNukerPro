Imports System.Timers
Imports Timer = System.Timers.Timer

Module Timers
    Dim oneTimer As Timer = New Timer()
    Public Sub makeTimers()
        oneTimer.Interval = 1000
        AddHandler oneTimer.Elapsed, AddressOf oneTimerEvent
        oneTimer.AutoReset = True
        oneTimer.Enabled = True
    End Sub
    Public Sub oneTimerEvent(ByVal source As Object, ByVal e As ElapsedEventArgs)

    End Sub
End Module
