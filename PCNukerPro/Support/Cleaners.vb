Module Cleaners
    Private Declare Function SHEmptyRecycleBin Lib "shell32.dll" Alias "SHEmptyRecycleBinA" (ByVal hWnd As Int32, ByVal pszRootPath As String, ByVal dwFlags As Int32) As Int32

    Private Declare Function SHUpdateRecycleBinIcon Lib "shell32.dll" () As Int32

    Private Const SHERB_NOCONFIRMATION = &H1

    Private Const SHERB_NOPROGRESSUI = &H2

    Private Const SHERB_NOSOUND = &H4

    Public Sub EmptyRecycleBin()

        SHEmptyRecycleBin(Form1.Handle.ToInt32, vbNullString, SHERB_NOCONFIRMATION)

        SHUpdateRecycleBinIcon()
        Form1.LogsListbox.Items.Add("Recycle Bin Cleaned Successfully")
    End Sub
    Public Sub CleanTemp()
        Dim di As IO.DirectoryInfo = New IO.DirectoryInfo("C:\Windows\Temp")
        For Each File As IO.FileInfo In di.GetFiles()
            Try
                File.Delete()
                Form1.LogsListbox.Items.Add("C:\Windows\Temp\" & File.ToString & " Deleted")
            Catch
                Form1.LogsListbox.Items.Add("Cannot Delete C:\Windows\Temp\" & File.ToString)
            End Try
        Next
    End Sub
    Public Sub CleanPrefetch()
        Dim di As IO.DirectoryInfo = New IO.DirectoryInfo("C:\Windows\Prefetch")
        For Each File As IO.FileInfo In di.GetFiles()
            Try
                File.Delete()
                Form1.LogsListbox.Items.Add("C:\Windows\Prefetch\" & File.ToString & " Deleted")
            Catch
                Form1.LogsListbox.Items.Add("Cannot Delete C:\Windows\Prefetch\" & File.ToString)
            End Try
        Next
    End Sub
    Public Sub CleanJava()
        Dim di As IO.DirectoryInfo = New IO.DirectoryInfo("C:\Users\" & Environment.UserName & "\AppData\Local\Sun\Java\Deployment\cache")
        For Each File As IO.FileInfo In di.GetFiles()
            Try
                File.Delete()
                Form1.LogsListbox.Items.Add("C:\Users\" & Environment.UserName & "\AppData\Local\Sun\Java\Deployment\cache\" & File.ToString & " Deleted")
            Catch
                Form1.LogsListbox.Items.Add("Cannot Delete C:\Users\" & Environment.UserName & "\AppData\Local\Sun\Java\Deployment\cache\" & File.ToString)
            End Try
        Next
    End Sub
    Public Sub CleanAppDataTemp()
        Dim di As IO.DirectoryInfo = New IO.DirectoryInfo("C:\Users\" & Environment.UserName & "\AppData\Local\Temp")
        For Each File As IO.FileInfo In di.GetFiles()
            Try
                File.Delete()
                Form1.LogsListbox.Items.Add("C:\Users\" & Environment.UserName & "\AppData\Local\Temp\" & File.ToString & " Deleted")
            Catch
                Form1.LogsListbox.Items.Add("Cannot Delete C:\Users\" & Environment.UserName & "\AppData\Local\Temp\" & File.ToString)
            End Try
        Next
    End Sub
End Module