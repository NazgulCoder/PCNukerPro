﻿Imports System.Security.Principal

Module Info
    Public Function GetInfo()
        Dim Ram As Double = My.Computer.Info.TotalPhysicalMemory / (1024 ^ 3)
        Dim FRam As String = Ram.ToString("N") & " GB"
        Dim OS As String = My.Computer.Info.OSFullName.ToString
        OS = OS.Replace("Microsoft", "")
        Dim Processor As String = My.Computer.Registry.LocalMachine.OpenSubKey("Hardware\description\System\CentralProcessor\0").GetValue("ProcessorNameString").ToString
        Dim ADmin As String
        Dim freespace As Long
        freespace = My.Computer.FileSystem.GetDriveInfo("C:\").AvailableFreeSpace / (1024 ^ 3)
        Dim totalspace As Long
        totalspace = My.Computer.FileSystem.GetDriveInfo("C:\").TotalSize / (1024 ^ 3)

        If IsAdmin() = True Then
            ADmin = "True"
        Else
            ADmin = "False"
        End If
        Return FRam & "|" & OS & "|" & Processor & "|" & ADmin & "|" & freespace & "|" & totalspace
    End Function
    Public Function IsAdmin()
        Dim result As Boolean = True
        Try
            Dim User As WindowsIdentity = WindowsIdentity.GetCurrent
            Dim Principal As New WindowsPrincipal(User)
            result = Principal.IsInRole(WindowsBuiltInRole.Administrator)
        Catch ex As Exception
        End Try
        Return result
    End Function
End Module
