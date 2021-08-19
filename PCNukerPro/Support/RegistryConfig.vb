Imports Microsoft.Win32

Module RegistryConfig
    Dim vaultpath As RegistryKey
    Public Function registryExist() As Boolean
        If Registry.CurrentUser.OpenSubKey("Software\PCNukerPro") Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub createRegistry()
        Try
            Registry.CurrentUser.CreateSubKey("Software\PCNukerPro")
            vaultpath = Registry.CurrentUser.CreateSubKey("Software\PCNukerPro\vaults")
        Catch
            MsgBox("Could not create Registries, perhaps you dont have admin rights")
        End Try
    End Sub
    Public Sub createRegistryValues(ByVal value As String)
        vaultpath.SetValue(value, "")
    End Sub
    Public Sub deleteRegistryValues(ByVal value As String)
        vaultpath.DeleteValue(value)
    End Sub
    Public Sub loadRegistryValues()
        vaultpath = Registry.CurrentUser.OpenSubKey("Software\PCNukerPro\vaults", True)
        Try
            For Each value As String In vaultpath.GetValueNames
                Form1.vaultlistbox.Items.Add(value)
            Next
        Catch ex As Exception
            Form1.LogsListbox.Items.Add("Error while retrieving saved vaults")
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub deleteAllRegistry()
        Registry.CurrentUser.DeleteSubKey("Software\PCNukerPro")
    End Sub
End Module
