namespace NineDigit.WixSharpExtensions.Resources
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/windows/win32/msi/operating-system-property-values
    /// https://www.advancedinstaller.com/user-guide/qa-OS-dependent-install.html
    /// </summary>
    public enum VersionNT
    {
        /// <summary>
        /// 'Windwos 2000'
        /// or 'Windows 2000 with Service Pack 1'
        /// or 'Windows 2000 with Service Pack 2'
        /// or 'Windows 2000 with Service Pack 3'
        /// or 'Windows 2000 with Service Pack 4'
        /// </summary>
        Windows2000 = 500,
        /// <summary>
        /// 'Windows XP'
        /// or 'Windows XP with Service Pack 1 (SP1)'
        /// or 'Windows XP with Service Pack 2 (SP2)'
        /// or 'Windows XP with Service Pack 3 (SP3)'
        /// </summary>
        WindowsXP = 501,
        /// <summary>
        /// 'Windows Server 2003'
        /// or 'Windows Server 2003 with Service Pack 1 (SP1)'
        /// or 'Windows Server 2003 with Service Pack 2 (SP2)'
        /// </summary>
        WindowsServer2003 = 502,
        /// <summary>
        /// 'Windows Vista'
        /// or 'Windows Vista with Service Pack 1 (SP1)'
        /// or 'Windows Vista with Service Pack 2 (SP2)'
        /// or 'Windows Server 2008'
        /// or 'Windows Server 2008 with Service Pack 2 (SP2)'
        /// </summary>
        WindowsVistaOrWindowsServer2008 = 600,
        /// <summary>
        /// 'Windows 7'
        /// or 'Windows 7 with Service Pack 1 (SP1)'
        /// or 'Windows Server 2008 R2'
        /// </summary>
        Windows7OrWindows7Sp1OrServer2008R2 = 601,
        /// <summary>
        /// 'Windows 8'
        /// or 'Windows Server 2012'
        /// </summary>
        Windows8OrServer2012 = 602,
        /// <summary>
        /// 'Windows 8.1' 
        /// or 'Windows 10'
        /// or 'Windows Server 2012 R2'
        /// or 'Windows Sever 2016'
        /// or 'Windows Sever 2019'
        /// <para>
        /// In summary due to changes in the behaviour of Windows 10 it is not possible to reliably identify a Windows 10 Operating System from within an MSI.
        /// The same behavior occurs with the Windows Installer property <c>WindowsBuild</c>. This property will report as the value for Windows 8.1
        /// </para>
        /// </summary>
        Windows8dot1OrWindows10OrServer2012R2OrServer2016OrServer2019 = 603,
    }
}
