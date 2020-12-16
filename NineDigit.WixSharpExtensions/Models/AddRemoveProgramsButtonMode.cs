namespace NineDigit.WixSharpExtensions
{
    /// <summary>
    /// Bundle visibility modes in the Add/Remove programs menu.
    /// </summary>
    public enum AddRemoveProgramsButtonMode
    {
        /// <summary>
        /// Bundle will not be visible in Add/Remove programs menu.
        /// </summary>
        None,
        /// <summary>
        /// Modify button will be enabled in Add/Remove programs menu.
        /// </summary>
        ChangeButtonOnly,
        /// <summary>
        /// Remove button will be enabled in Add/Remove programs menu.
        /// </summary>
        UninstallButtonOnly,
        /// <summary>
        /// Boths remove and modify buttons will be enabled in Add/Remove programs menu.
        /// </summary>
        ModifyAndRemove,
        /// <summary>
        /// Single "Uninstall/Change" button will be visible in  Add/Remove programs menu.
        /// </summary>
        SingleUninstallChangeButton,
    }
}
