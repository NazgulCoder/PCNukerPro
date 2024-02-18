# PCNukerPro
 simple standalone cleaning and antimalware utility, not meant to replace AV role, however some IT Supervisors or Managers may find this useful to implement in their systems. Feel free to learn, copy and paste, improve the Proof of Concept shown below.
 
 ### Features
 -Cleaner <br/>
 -FileSystem and DiskChecking Helper <br/>
 -AntiMalware (RunTime & Startup - Proof of Concept) <br/>
 -AntiRansomware (Proof of Concept) with Automatic Shutdown <br/>
 -Vault (System Lock Folders) <br/>
 
 ![tempsnip](https://user-images.githubusercontent.com/85739956/131254119-af250c4d-b04e-4b01-b936-572ee9ae9d8f.png)
![tempsnip2](https://user-images.githubusercontent.com/85739956/131254124-b1a8217c-6dbb-4f5d-9c0e-fa531bd9fa62.png)

 
 ### Proof of Concept for AntiMalware and AntiRansomware
 AntiMalware is available with few engines that smart check your system, please take note that it may advise many false positives since it relies on word recognition, startup  and process path folder and visibility of the process (this does not work for the system-injected malwares) <br/>
 
 AntiRansomware behaves as a honeypot waiting for the CryptoLocker to encrypt files in random folders of your PC (at the moment by default is "My Documents") and as soon as it triggers it will react with the chosen options (Vaults and Shutdown). This honeypot method won't work if the CryptoLocker works directly in BIOS, MBR or encrypts upon System Shutdown <br/>
 
 ### Planned Features
 -Startup <br/>
 -Install as Windows Service <br/>
 -User lockout after Ransomware Activity <br/>
 -User lockout after Ransomware Activity integrated with ActiveDirectory <br/>


### License MIT - PCNukerPro
Copyright 2021

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
