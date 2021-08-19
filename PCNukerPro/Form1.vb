Public Class Form1
    Public Shared numberOfThreats As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        loadPCInfo()
        'makeTimers()
    End Sub


    Private Sub loadPCInfo()
        Dim strHostName As String = System.Net.Dns.GetHostName()
        pcname.Text = "PC Name: " & strHostName
        Dim Info As Object = GetInfo.ToString.Split("|")
        os.Text = "OS: " & Info(1)
        ram.Text = "RAM: " & Info(0)
        admin.Text = "Administrator: " & Info(3)
        processor.Text = Info(2)
        hddspace.Text = "HardDisk Space: " & Info(4) & "GB/" & Info(5) & "GB"
    End Sub

    Private Sub cleanbutton_Click(sender As Object, e As EventArgs) Handles cleanbutton.Click
        If tempcheckbox.Checked = True Then
            Try
                CleanTemp()
                CleanAppDataTemp()
            Catch
            End Try
        End If
        If prefetchcheckbox.Checked = True Then
            Try
                CleanPrefetch()
            Catch
            End Try
        End If
        If javacachecheckbox.Checked = True Then
            Try
                CleanJava()
            Catch
            End Try
        End If
        If recyclebincheckbox.Checked = True Then
            Try
                EmptyRecycleBin()
            Catch
            End Try
        End If
        AddItem2Listbox("Junk Files Cleaning Finished at " & DateTime.Now.ToString("HH:mm:ss"))
    End Sub

    Private Sub sfcbutton_Click(sender As Object, e As EventArgs) Handles sfcbutton.Click
        SFC()
        AddItem2Listbox("SFC Scannow Started at " & DateTime.Now.ToString("HH:mm:ss"))
    End Sub

    Private Sub chkdsk_Click(sender As Object, e As EventArgs) Handles chkdsk.Click
        CHKDSKK()
        AddItem2Listbox("CHKDSK Started at " & DateTime.Now.ToString("HH:mm:ss"))
    End Sub

    Private Sub dismscan_Click(sender As Object, e As EventArgs) Handles dismscan.Click
        DISMScann()
        AddItem2Listbox("DISM Scan Started at " & DateTime.Now.ToString("HH:mm:ss"))
    End Sub

    Private Sub dismrestore_Click(sender As Object, e As EventArgs) Handles dismrestore.Click
        DISMRestoree()
        AddItem2Listbox("DISM Restore Healt Started at " & DateTime.Now.ToString("HH:mm:ss"))
    End Sub

    Private Sub AddItem2Listbox(ByVal item As String)
        LogsListbox.Items.Add(item)
        LogsListbox.TopIndex = LogsListbox.Items.Count - 1
    End Sub

    Private Sub quickscanbutton_Click(sender As Object, e As EventArgs) Handles quickscanbutton.Click
        'VBC Scanner
        AddItem2Listbox("VBC Scan Started at " & DateTime.Now.ToString("HH:mm:ss"))
        If vbcprocess() = True Then
            numberOfThreats += 1
            AddItem2Listbox("vbc process found, you are infected with DarkCometRAT or other Trojans")
        Else
            AddItem2Listbox("Your system seems clear from vbc infection")
        End If
        'QuickMalwareHunter Scan
        AddItem2Listbox("Quick Malware Hunter Started at " & DateTime.Now.ToString("HH:mm:ss"))
        QuickMalwareHunter()
        'SmartMalwareHunter Scan
        AddItem2Listbox("Smart Malware Hunter Started at " & DateTime.Now.ToString("HH:mm:ss"))
        SmartMalwareHunter()

        AddItem2Listbox("Full System Malware Scan Terminated at " & DateTime.Now.ToString("HH:mm:ss") & " with " & numberOfThreats.ToString & " threats")

        If numberOfThreats > 0 Then
            MsgBox("Scan found " & numberOfThreats.ToString & " viruses in your system. Please check the log board for further details.", MsgBoxStyle.Critical, "VIRUSES FOUND!")
        End If
        numberOfThreats = 0
    End Sub

    Private Sub startupscanbutton_Click(sender As Object, e As EventArgs) Handles startupscanbutton.Click
        AddItem2Listbox("Startup Scan Started at " & DateTime.Now.ToString("HH:mm:ss"))
        'shellstartup scan
        StartupFolderScan()
        'startupscan regedit
        StartupRegistryScanLM()
        StartupRegistryScanCU()
        StartupRegistryScanWow64LM()
        StartupWMIService()

        AddItem2Listbox("Startup Malware Scan Terminated at " & DateTime.Now.ToString("HH:mm:ss") & " with " & numberOfThreats.ToString & " threats")

        If numberOfThreats > 0 Then
            MsgBox("Scan found " & numberOfThreats.ToString & " viruses in your Startup. Please check the log board for further details.", MsgBoxStyle.Critical, "VIRUSES FOUND!")
        End If
        numberOfThreats = 0
    End Sub
End Class

