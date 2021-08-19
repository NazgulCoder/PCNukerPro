Imports System.IO
Imports System.Management
Imports System.Runtime.InteropServices
Imports System.Security.Principal
Imports Microsoft.Win32

Module Scanners
#Region "File/Process Scanner"
    Public Function vbcprocess() As Boolean
        Dim vbcproc() As Process = Process.GetProcesses
        Dim I As Int32
        For I = 0 To vbcproc.Length - 1 Step I + 1
            Dim ProcessReleve As String = vbcproc(I).ProcessName
            Select Case ProcessReleve
                Case "vbc"
                    Return True
            End Select
        Next
        Return False
    End Function
    <DllImport("user32.dll", SetLastError:=True)>
    Private Function IsWindowVisible(ByVal hWnd As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
    Public Declare Function IsWindowVisible Lib "user32" _
         (ByVal hWnd As Long) As Long
    Public Sub QuickMalwareHunter()
        Dim possiblethreats As Integer = 0
        For Each p As Process In Process.GetProcesses()
            Try
                If IsWindowVisible(CLng(p.MainWindowHandle)) = 0 And (p.MainModule.FileName.ToString.Contains("AppData") Or p.MainModule.FileName.ToString.Contains("Temp")) Then
                    Form1.LogsListbox.Items.Add(p.MainModule.FileName.ToString & " is a possible threat!!")
                    possiblethreats += 1
                End If
            Catch ex As Exception
            End Try
        Next
        Form1.LogsListbox.Items.Add("Quick Malware Hunter Scan Terminated with " & possiblethreats.ToString & " possible threats!")
        Form1.numberOfThreats += possiblethreats
    End Sub

    Public Sub SmartMalwareHunter()
        Dim possiblethreats As Integer = 0
        Dim wordlistArray() As String = My.Resources.englishwords.ToString.Split(vbCrLf)
        For Each p As Process In Process.GetProcesses()
            Dim i As Integer = 0

            While i < wordlistArray.Length
                If Not p.ProcessName.ToLower.Contains(wordlistArray(i).Replace(vbLf, "")) Then
                    i += 1
                Else
                    Exit While 'if word is contained it will exit the while and will check with next process from the for each loop
                End If
                If i >= wordlistArray.Length Then
                    Form1.LogsListbox.Items.Add(p.MainModule.FileName.ToString & " is a possible threat!!")
                    possiblethreats += 1
                End If
            End While
        Next
        Form1.LogsListbox.Items.Add("Smart Malware Hunter Scan Terminated with " & possiblethreats.ToString & " possible threats!")
        Form1.numberOfThreats += possiblethreats
    End Sub
#End Region

#Region "Startup Scanner"
    Public Sub StartupFolderScan()
        Dim possiblethreats As Integer = 0
        Dim wordlistArray() As String = My.Resources.englishwords.ToString.Split(vbCrLf)
        Dim di As IO.DirectoryInfo = New IO.DirectoryInfo("C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup")
        For Each File As IO.FileInfo In di.GetFiles()
            Dim i As Integer = 0
            While i < wordlistArray.Length
                If Not File.ToString.ToLower.Contains(wordlistArray(i).Replace(vbLf, "")) Then
                    i += 1
                Else
                    'Form1.LogsListbox.Items.Add(i.ToString & " " & File.ToString) 'debugger
                    Exit While 'if word is contained it will exit the while and will check with next file from the for each loop
                End If
                If i >= wordlistArray.Length Then
                    Form1.LogsListbox.Items.Add("Startup Folder - " & File.ToString & " is a possible threat!!")
                    possiblethreats += 1
                End If
            End While
        Next
        Form1.numberOfThreats += possiblethreats
    End Sub

    Public Sub StartupRegistryScanLM()
        Dim possiblethreats As Integer = 0
        Dim wordlistArray() As String = My.Resources.englishwords.ToString.Split(vbCrLf)
        Dim regKey As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
        'regKey.GetValueNames()
        For i = 0 To UBound(regKey.GetValueNames())
            Dim iwhile As Integer = 0
            While iwhile < wordlistArray.Length
                If Not regKey.GetValueNames(i).ToLower.Contains(wordlistArray(iwhile).Replace(vbLf, "")) Then
                    iwhile += 1
                Else
                    'Form1.LogsListbox.Items.Add(iwhile.ToString & " " & regKey.GetValueNames(i)) 'debugger
                    Exit While 'if word is contained it will exit the while and will check with next file from the for each loop
                End If
                If iwhile >= wordlistArray.Length And Not regKey.GetValueNames(i).ToString = "" Then
                    Form1.LogsListbox.Items.Add("LocalMachine Regedit - " & regKey.GetValueNames(i) & " is a possible threat!!")
                    possiblethreats += 1
                End If
            End While
        Next
        Form1.numberOfThreats += possiblethreats
    End Sub
    Public Sub StartupRegistryScanCU()
        Dim possiblethreats As Integer = 0
        Dim wordlistArray() As String = My.Resources.englishwords.ToString.Split(vbCrLf)
        Dim regKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
        'regKey.GetValueNames()
        For i = 0 To UBound(regKey.GetValueNames())
            Dim iwhile As Integer = 0
            While iwhile < wordlistArray.Length
                If Not regKey.GetValueNames(i).ToLower.Contains(wordlistArray(iwhile).Replace(vbLf, "")) Then
                    iwhile += 1
                Else
                    'Form1.LogsListbox.Items.Add(iwhile.ToString & " " & regKey.GetValueNames(i)) 'debugger
                    Exit While 'if word is contained it will exit the while and will check with next file from the for each loop
                End If
                If iwhile >= wordlistArray.Length And Not regKey.GetValueNames(i).ToString = "" Then
                    Form1.LogsListbox.Items.Add("CurrentUser Regedit - " & regKey.GetValueNames(i) & " is a possible threat!!")
                    possiblethreats += 1
                End If
            End While
        Next
        Form1.numberOfThreats += possiblethreats
    End Sub
    Public Sub StartupRegistryScanWow64LM()
        Dim possiblethreats As Integer = 0
        Dim wordlistArray() As String = My.Resources.englishwords.ToString.Split(vbCrLf)
        Dim regKey As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\WOW6432Node\Microsoft\Windows\CurrentVersion\Run", True)
        'regKey.GetValueNames()
        For i = 0 To UBound(regKey.GetValueNames())
            Dim iwhile As Integer = 0
            While iwhile < wordlistArray.Length
                If Not regKey.GetValueNames(i).ToLower.Contains(wordlistArray(iwhile).Replace(vbLf, ""))  Then
                    iwhile += 1
                Else
                    'Form1.LogsListbox.Items.Add(iwhile.ToString & " " & regKey.GetValueNames(i)) 'debugger
                    Exit While 'if word is contained it will exit the while and will check with next file from the for each loop
                End If
                If iwhile >= wordlistArray.Length And Not regKey.GetValueNames(i).ToString = "" Then
                    Form1.LogsListbox.Items.Add("WOW6432Node Regedit - " & regKey.GetValueNames(i) & " is a possible threat!!")
                    possiblethreats += 1
                End If
            End While
        Next
        Form1.numberOfThreats += possiblethreats
    End Sub

    Public Sub StartupWMIService()
        Dim possiblethreats As Integer = 0
        Dim wordlistArray() As String = My.Resources.englishwords.ToString.Split(vbCrLf)

        Dim Scope As New ManagementScope("\\.\ROOT\cimv2")
        Dim Query As New ObjectQuery("SELECT * FROM Win32_StartupCommand")
        Dim Searcher As New ManagementObjectSearcher(Scope, Query)
        Dim queryCollection As ManagementObjectCollection = Searcher.Get

        For Each mObject As ManagementObject In queryCollection
            Dim i As Integer = 0
            While i < wordlistArray.Length
                If Not mObject("Caption").ToString.ToLower.Contains(wordlistArray(i).Replace(vbLf, "")) Then
                    i += 1
                Else
                    'Form1.LogsListbox.Items.Add(i.ToString & " " & mObject("Caption").ToString.ToLower) 'debugger
                    Exit While 'if word is contained it will exit the while and will check with next startup from the for each loop
                End If
                If i >= wordlistArray.Length Then
                    Form1.LogsListbox.Items.Add("WMI Startup - " & mObject("Caption").ToString & " is a possible threat!!")
                    possiblethreats += 1
                End If
            End While
        Next
        Form1.numberOfThreats += possiblethreats
    End Sub
#End Region
End Module
