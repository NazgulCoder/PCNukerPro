<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pcname = New System.Windows.Forms.Label()
        Me.os = New System.Windows.Forms.Label()
        Me.ram = New System.Windows.Forms.Label()
        Me.admin = New System.Windows.Forms.Label()
        Me.processor = New System.Windows.Forms.Label()
        Me.hddspace = New System.Windows.Forms.Label()
        Me.LogsListbox = New System.Windows.Forms.ListBox()
        Me.tempcheckbox = New System.Windows.Forms.CheckBox()
        Me.SeparatorImage = New System.Windows.Forms.PictureBox()
        Me.prefetchcheckbox = New System.Windows.Forms.CheckBox()
        Me.javacachecheckbox = New System.Windows.Forms.CheckBox()
        Me.recyclebincheckbox = New System.Windows.Forms.CheckBox()
        Me.cleanbutton = New System.Windows.Forms.Button()
        Me.sfcbutton = New System.Windows.Forms.Button()
        Me.chkdsk = New System.Windows.Forms.Button()
        Me.dismscan = New System.Windows.Forms.Button()
        Me.dismrestore = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.antimalwarelabel = New System.Windows.Forms.Label()
        Me.startupscanbutton = New System.Windows.Forms.Button()
        Me.quickscanbutton = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.setvaultscheckbox = New System.Windows.Forms.CheckBox()
        Me.ifransomwarelabeldetected = New System.Windows.Forms.Label()
        Me.shutdowncheckbox = New System.Windows.Forms.CheckBox()
        Me.stopransomware = New System.Windows.Forms.Button()
        Me.startransomware = New System.Windows.Forms.Button()
        Me.ransomware = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.vaultlistbox = New System.Windows.Forms.ListBox()
        Me.removevault = New System.Windows.Forms.Button()
        Me.unlockvault = New System.Windows.Forms.Button()
        Me.lockvault = New System.Windows.Forms.Button()
        Me.addvault = New System.Windows.Forms.Button()
        Me.ransomwaredescriptions = New System.Windows.Forms.Label()
        CType(Me.SeparatorImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'pcname
        '
        Me.pcname.AutoSize = True
        Me.pcname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pcname.Location = New System.Drawing.Point(6, 3)
        Me.pcname.Name = "pcname"
        Me.pcname.Size = New System.Drawing.Size(72, 16)
        Me.pcname.TabIndex = 0
        Me.pcname.Text = "PC Name: "
        '
        'os
        '
        Me.os.AutoSize = True
        Me.os.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.os.Location = New System.Drawing.Point(6, 19)
        Me.os.Name = "os"
        Me.os.Size = New System.Drawing.Size(33, 16)
        Me.os.TabIndex = 1
        Me.os.Text = "OS: "
        '
        'ram
        '
        Me.ram.AutoSize = True
        Me.ram.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ram.Location = New System.Drawing.Point(6, 35)
        Me.ram.Name = "ram"
        Me.ram.Size = New System.Drawing.Size(44, 16)
        Me.ram.TabIndex = 2
        Me.ram.Text = "RAM: "
        '
        'admin
        '
        Me.admin.AutoSize = True
        Me.admin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin.Location = New System.Drawing.Point(6, 51)
        Me.admin.Name = "admin"
        Me.admin.Size = New System.Drawing.Size(92, 16)
        Me.admin.TabIndex = 3
        Me.admin.Text = "Administrator: "
        '
        'processor
        '
        Me.processor.AutoSize = True
        Me.processor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.processor.Location = New System.Drawing.Point(6, 67)
        Me.processor.Name = "processor"
        Me.processor.Size = New System.Drawing.Size(17, 16)
        Me.processor.TabIndex = 4
        Me.processor.Text = "..."
        '
        'hddspace
        '
        Me.hddspace.AutoSize = True
        Me.hddspace.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hddspace.Location = New System.Drawing.Point(6, 83)
        Me.hddspace.Name = "hddspace"
        Me.hddspace.Size = New System.Drawing.Size(112, 16)
        Me.hddspace.TabIndex = 5
        Me.hddspace.Text = "Harddisk Space: "
        '
        'LogsListbox
        '
        Me.LogsListbox.FormattingEnabled = True
        Me.LogsListbox.HorizontalScrollbar = True
        Me.LogsListbox.Location = New System.Drawing.Point(12, 221)
        Me.LogsListbox.Name = "LogsListbox"
        Me.LogsListbox.ScrollAlwaysVisible = True
        Me.LogsListbox.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.LogsListbox.Size = New System.Drawing.Size(472, 173)
        Me.LogsListbox.TabIndex = 6
        '
        'tempcheckbox
        '
        Me.tempcheckbox.AutoSize = True
        Me.tempcheckbox.Checked = True
        Me.tempcheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tempcheckbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tempcheckbox.Location = New System.Drawing.Point(6, 123)
        Me.tempcheckbox.Name = "tempcheckbox"
        Me.tempcheckbox.Size = New System.Drawing.Size(63, 20)
        Me.tempcheckbox.TabIndex = 7
        Me.tempcheckbox.Text = "Temp"
        Me.tempcheckbox.UseVisualStyleBackColor = True
        '
        'SeparatorImage
        '
        Me.SeparatorImage.BackColor = System.Drawing.Color.Transparent
        Me.SeparatorImage.Image = CType(resources.GetObject("SeparatorImage.Image"), System.Drawing.Image)
        Me.SeparatorImage.Location = New System.Drawing.Point(-182, 102)
        Me.SeparatorImage.Name = "SeparatorImage"
        Me.SeparatorImage.Size = New System.Drawing.Size(866, 15)
        Me.SeparatorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SeparatorImage.TabIndex = 14
        Me.SeparatorImage.TabStop = False
        '
        'prefetchcheckbox
        '
        Me.prefetchcheckbox.AutoSize = True
        Me.prefetchcheckbox.Checked = True
        Me.prefetchcheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.prefetchcheckbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prefetchcheckbox.Location = New System.Drawing.Point(75, 123)
        Me.prefetchcheckbox.Name = "prefetchcheckbox"
        Me.prefetchcheckbox.Size = New System.Drawing.Size(76, 20)
        Me.prefetchcheckbox.TabIndex = 15
        Me.prefetchcheckbox.Text = "Prefetch"
        Me.prefetchcheckbox.UseVisualStyleBackColor = True
        '
        'javacachecheckbox
        '
        Me.javacachecheckbox.AutoSize = True
        Me.javacachecheckbox.Checked = True
        Me.javacachecheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.javacachecheckbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.javacachecheckbox.Location = New System.Drawing.Point(157, 123)
        Me.javacachecheckbox.Name = "javacachecheckbox"
        Me.javacachecheckbox.Size = New System.Drawing.Size(99, 20)
        Me.javacachecheckbox.TabIndex = 16
        Me.javacachecheckbox.Text = "Java Cache"
        Me.javacachecheckbox.UseVisualStyleBackColor = True
        '
        'recyclebincheckbox
        '
        Me.recyclebincheckbox.AutoSize = True
        Me.recyclebincheckbox.Checked = True
        Me.recyclebincheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.recyclebincheckbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recyclebincheckbox.Location = New System.Drawing.Point(262, 123)
        Me.recyclebincheckbox.Name = "recyclebincheckbox"
        Me.recyclebincheckbox.Size = New System.Drawing.Size(99, 20)
        Me.recyclebincheckbox.TabIndex = 17
        Me.recyclebincheckbox.Text = "Recycle Bin"
        Me.recyclebincheckbox.UseVisualStyleBackColor = True
        '
        'cleanbutton
        '
        Me.cleanbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cleanbutton.Location = New System.Drawing.Point(367, 120)
        Me.cleanbutton.Name = "cleanbutton"
        Me.cleanbutton.Size = New System.Drawing.Size(88, 23)
        Me.cleanbutton.TabIndex = 18
        Me.cleanbutton.Text = "Clean Files"
        Me.cleanbutton.UseVisualStyleBackColor = True
        '
        'sfcbutton
        '
        Me.sfcbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfcbutton.Location = New System.Drawing.Point(6, 149)
        Me.sfcbutton.Name = "sfcbutton"
        Me.sfcbutton.Size = New System.Drawing.Size(133, 23)
        Me.sfcbutton.TabIndex = 19
        Me.sfcbutton.Text = "FileSystem Scan"
        Me.sfcbutton.UseVisualStyleBackColor = True
        '
        'chkdsk
        '
        Me.chkdsk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkdsk.Location = New System.Drawing.Point(145, 149)
        Me.chkdsk.Name = "chkdsk"
        Me.chkdsk.Size = New System.Drawing.Size(93, 23)
        Me.chkdsk.TabIndex = 20
        Me.chkdsk.Text = "CHKDSK"
        Me.chkdsk.UseVisualStyleBackColor = True
        '
        'dismscan
        '
        Me.dismscan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dismscan.Location = New System.Drawing.Point(244, 149)
        Me.dismscan.Name = "dismscan"
        Me.dismscan.Size = New System.Drawing.Size(93, 23)
        Me.dismscan.TabIndex = 21
        Me.dismscan.Text = "DISM Scan"
        Me.dismscan.UseVisualStyleBackColor = True
        '
        'dismrestore
        '
        Me.dismrestore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dismrestore.Location = New System.Drawing.Point(343, 149)
        Me.dismrestore.Name = "dismrestore"
        Me.dismrestore.Size = New System.Drawing.Size(112, 23)
        Me.dismrestore.TabIndex = 22
        Me.dismrestore.Text = "DISM Restore"
        Me.dismrestore.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(472, 203)
        Me.TabControl1.TabIndex = 23
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.pcname)
        Me.TabPage1.Controls.Add(Me.dismrestore)
        Me.TabPage1.Controls.Add(Me.os)
        Me.TabPage1.Controls.Add(Me.dismscan)
        Me.TabPage1.Controls.Add(Me.ram)
        Me.TabPage1.Controls.Add(Me.chkdsk)
        Me.TabPage1.Controls.Add(Me.admin)
        Me.TabPage1.Controls.Add(Me.sfcbutton)
        Me.TabPage1.Controls.Add(Me.processor)
        Me.TabPage1.Controls.Add(Me.cleanbutton)
        Me.TabPage1.Controls.Add(Me.hddspace)
        Me.TabPage1.Controls.Add(Me.recyclebincheckbox)
        Me.TabPage1.Controls.Add(Me.SeparatorImage)
        Me.TabPage1.Controls.Add(Me.javacachecheckbox)
        Me.TabPage1.Controls.Add(Me.tempcheckbox)
        Me.TabPage1.Controls.Add(Me.prefetchcheckbox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(464, 177)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cleaner"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.antimalwarelabel)
        Me.TabPage2.Controls.Add(Me.startupscanbutton)
        Me.TabPage2.Controls.Add(Me.quickscanbutton)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(464, 177)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Malware"
        '
        'antimalwarelabel
        '
        Me.antimalwarelabel.AutoSize = True
        Me.antimalwarelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.antimalwarelabel.Location = New System.Drawing.Point(3, 30)
        Me.antimalwarelabel.Name = "antimalwarelabel"
        Me.antimalwarelabel.Size = New System.Drawing.Size(449, 144)
        Me.antimalwarelabel.TabIndex = 21
        Me.antimalwarelabel.Text = resources.GetString("antimalwarelabel.Text")
        '
        'startupscanbutton
        '
        Me.startupscanbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startupscanbutton.Location = New System.Drawing.Point(119, 6)
        Me.startupscanbutton.Name = "startupscanbutton"
        Me.startupscanbutton.Size = New System.Drawing.Size(107, 23)
        Me.startupscanbutton.TabIndex = 20
        Me.startupscanbutton.Text = "Startup Scan"
        Me.startupscanbutton.UseVisualStyleBackColor = True
        '
        'quickscanbutton
        '
        Me.quickscanbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quickscanbutton.Location = New System.Drawing.Point(6, 6)
        Me.quickscanbutton.Name = "quickscanbutton"
        Me.quickscanbutton.Size = New System.Drawing.Size(107, 23)
        Me.quickscanbutton.TabIndex = 19
        Me.quickscanbutton.Text = "Malware Scan"
        Me.quickscanbutton.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Transparent
        Me.TabPage3.Controls.Add(Me.ransomwaredescriptions)
        Me.TabPage3.Controls.Add(Me.setvaultscheckbox)
        Me.TabPage3.Controls.Add(Me.ifransomwarelabeldetected)
        Me.TabPage3.Controls.Add(Me.shutdowncheckbox)
        Me.TabPage3.Controls.Add(Me.stopransomware)
        Me.TabPage3.Controls.Add(Me.startransomware)
        Me.TabPage3.Controls.Add(Me.ransomware)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(464, 177)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Ransomware"
        '
        'setvaultscheckbox
        '
        Me.setvaultscheckbox.AutoSize = True
        Me.setvaultscheckbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setvaultscheckbox.Location = New System.Drawing.Point(118, 76)
        Me.setvaultscheckbox.Name = "setvaultscheckbox"
        Me.setvaultscheckbox.Size = New System.Drawing.Size(87, 20)
        Me.setvaultscheckbox.TabIndex = 10
        Me.setvaultscheckbox.Text = "Set Vaults"
        Me.setvaultscheckbox.UseVisualStyleBackColor = True
        '
        'ifransomwarelabeldetected
        '
        Me.ifransomwarelabeldetected.AutoSize = True
        Me.ifransomwarelabeldetected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ifransomwarelabeldetected.Location = New System.Drawing.Point(3, 57)
        Me.ifransomwarelabeldetected.Name = "ifransomwarelabeldetected"
        Me.ifransomwarelabeldetected.Size = New System.Drawing.Size(242, 16)
        Me.ifransomwarelabeldetected.TabIndex = 9
        Me.ifransomwarelabeldetected.Text = "If Ransomware Activity is detected then:"
        '
        'shutdowncheckbox
        '
        Me.shutdowncheckbox.AutoSize = True
        Me.shutdowncheckbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shutdowncheckbox.Location = New System.Drawing.Point(6, 76)
        Me.shutdowncheckbox.Name = "shutdowncheckbox"
        Me.shutdowncheckbox.Size = New System.Drawing.Size(106, 20)
        Me.shutdowncheckbox.TabIndex = 8
        Me.shutdowncheckbox.Text = "Shutdown PC"
        Me.shutdowncheckbox.UseVisualStyleBackColor = True
        '
        'stopransomware
        '
        Me.stopransomware.Enabled = False
        Me.stopransomware.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stopransomware.Location = New System.Drawing.Point(168, 6)
        Me.stopransomware.Name = "stopransomware"
        Me.stopransomware.Size = New System.Drawing.Size(156, 23)
        Me.stopransomware.TabIndex = 2
        Me.stopransomware.Text = "Stop Anti-Ransomware"
        Me.stopransomware.UseVisualStyleBackColor = True
        '
        'startransomware
        '
        Me.startransomware.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startransomware.Location = New System.Drawing.Point(6, 6)
        Me.startransomware.Name = "startransomware"
        Me.startransomware.Size = New System.Drawing.Size(156, 23)
        Me.startransomware.TabIndex = 1
        Me.startransomware.Text = "Start Anti-Ransomware"
        Me.startransomware.UseVisualStyleBackColor = True
        '
        'ransomware
        '
        Me.ransomware.AutoSize = True
        Me.ransomware.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ransomware.Location = New System.Drawing.Point(3, 32)
        Me.ransomware.Name = "ransomware"
        Me.ransomware.Size = New System.Drawing.Size(160, 16)
        Me.ransomware.TabIndex = 0
        Me.ransomware.Text = "Ransomware Status: OFF"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Transparent
        Me.TabPage4.Controls.Add(Me.vaultlistbox)
        Me.TabPage4.Controls.Add(Me.removevault)
        Me.TabPage4.Controls.Add(Me.unlockvault)
        Me.TabPage4.Controls.Add(Me.lockvault)
        Me.TabPage4.Controls.Add(Me.addvault)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(464, 177)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Vault"
        '
        'vaultlistbox
        '
        Me.vaultlistbox.FormattingEnabled = True
        Me.vaultlistbox.Location = New System.Drawing.Point(3, 35)
        Me.vaultlistbox.Name = "vaultlistbox"
        Me.vaultlistbox.Size = New System.Drawing.Size(458, 134)
        Me.vaultlistbox.TabIndex = 6
        '
        'removevault
        '
        Me.removevault.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removevault.Location = New System.Drawing.Point(80, 6)
        Me.removevault.Name = "removevault"
        Me.removevault.Size = New System.Drawing.Size(68, 23)
        Me.removevault.TabIndex = 5
        Me.removevault.Text = "Remove"
        Me.removevault.UseVisualStyleBackColor = True
        '
        'unlockvault
        '
        Me.unlockvault.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unlockvault.Location = New System.Drawing.Point(268, 6)
        Me.unlockvault.Name = "unlockvault"
        Me.unlockvault.Size = New System.Drawing.Size(108, 23)
        Me.unlockvault.TabIndex = 4
        Me.unlockvault.Text = "Unlock Vault"
        Me.unlockvault.UseVisualStyleBackColor = True
        '
        'lockvault
        '
        Me.lockvault.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lockvault.Location = New System.Drawing.Point(154, 6)
        Me.lockvault.Name = "lockvault"
        Me.lockvault.Size = New System.Drawing.Size(108, 23)
        Me.lockvault.TabIndex = 3
        Me.lockvault.Text = "Lock Vault"
        Me.lockvault.UseVisualStyleBackColor = True
        '
        'addvault
        '
        Me.addvault.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addvault.Location = New System.Drawing.Point(6, 6)
        Me.addvault.Name = "addvault"
        Me.addvault.Size = New System.Drawing.Size(68, 23)
        Me.addvault.TabIndex = 2
        Me.addvault.Text = "Add"
        Me.addvault.UseVisualStyleBackColor = True
        '
        'ransomwaredescriptions
        '
        Me.ransomwaredescriptions.AutoSize = True
        Me.ransomwaredescriptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ransomwaredescriptions.Location = New System.Drawing.Point(3, 99)
        Me.ransomwaredescriptions.Name = "ransomwaredescriptions"
        Me.ransomwaredescriptions.Size = New System.Drawing.Size(453, 64)
        Me.ransomwaredescriptions.TabIndex = 11
        Me.ransomwaredescriptions.Text = resources.GetString("ransomwaredescriptions.Text")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 406)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.LogsListbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "PCNukerPro"
        CType(Me.SeparatorImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pcname As Label
    Friend WithEvents os As Label
    Friend WithEvents ram As Label
    Friend WithEvents admin As Label
    Friend WithEvents processor As Label
    Friend WithEvents hddspace As Label
    Friend WithEvents LogsListbox As ListBox
    Friend WithEvents tempcheckbox As CheckBox
    Friend WithEvents SeparatorImage As PictureBox
    Friend WithEvents prefetchcheckbox As CheckBox
    Friend WithEvents javacachecheckbox As CheckBox
    Friend WithEvents recyclebincheckbox As CheckBox
    Friend WithEvents cleanbutton As Button
    Friend WithEvents sfcbutton As Button
    Friend WithEvents chkdsk As Button
    Friend WithEvents dismscan As Button
    Friend WithEvents dismrestore As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents quickscanbutton As Button
    Friend WithEvents antimalwarelabel As Label
    Friend WithEvents startupscanbutton As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents stopransomware As Button
    Friend WithEvents startransomware As Button
    Friend WithEvents ransomware As Label
    Friend WithEvents setvaultscheckbox As CheckBox
    Friend WithEvents ifransomwarelabeldetected As Label
    Friend WithEvents shutdowncheckbox As CheckBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents vaultlistbox As ListBox
    Friend WithEvents removevault As Button
    Friend WithEvents unlockvault As Button
    Friend WithEvents lockvault As Button
    Friend WithEvents addvault As Button
    Friend WithEvents ransomwaredescriptions As Label
End Class
