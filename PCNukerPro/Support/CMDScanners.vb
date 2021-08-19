Module CMDScanners
    Public Sub SFC()
        Dim startInfo As ProcessStartInfo = New ProcessStartInfo()
        startInfo.FileName = "cmd.exe"
        startInfo.WorkingDirectory = "\Windows\system32"
        startInfo.Arguments = "/K sfc /scannow"
        startInfo.Verb = "RunAs"
        Dim process As Process = New Process()
        process.StartInfo = startInfo
        process.Start()
    End Sub
    Public Sub CHKDSKK()
        Dim startInfo As ProcessStartInfo = New ProcessStartInfo()
        startInfo.FileName = "cmd.exe"
        startInfo.WorkingDirectory = "\Windows\system32"
        startInfo.Arguments = "/K chkdsk /f"
        startInfo.Verb = "RunAs"
        Dim process As Process = New Process()
        process.StartInfo = startInfo
        process.Start()
    End Sub

    Public Sub DISMScann()
        Dim startInfo As ProcessStartInfo = New ProcessStartInfo()
        startInfo.FileName = "cmd.exe"
        startInfo.WorkingDirectory = "\Windows\system32"
        startInfo.Arguments = "/K DISM.exe /Online /Cleanup-image /ScanHealth"
        startInfo.Verb = "RunAs"
        Dim process As Process = New Process()
        process.StartInfo = startInfo
        process.Start()
    End Sub

    Public Sub DISMRestoree()
        Dim startInfo As ProcessStartInfo = New ProcessStartInfo()
        startInfo.FileName = "cmd.exe"
        startInfo.WorkingDirectory = "\Windows\system32"
        startInfo.Arguments = "/K DISM.exe /Online /Cleanup-image /RestoreHealth"
        startInfo.Verb = "RunAs"
        Dim process As Process = New Process()
        process.StartInfo = startInfo
        process.Start()
    End Sub
End Module
