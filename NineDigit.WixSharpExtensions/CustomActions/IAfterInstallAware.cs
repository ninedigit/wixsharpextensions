using WixSharp;

namespace NineDigit.WixSharpExtensions
{
    public interface IAfterInstallAware
    {
        /// <summary>
        /// Called after "InstallFiles" standard action, in **elevated** context (as admin).
        /// When called during product installation - files are already copied; services are not installed yet.
        /// When called during product uninstallation - services are uninstaled and files are already removed.
        /// <para>
        /// If exception occurs during invocation, installer terminates and all changes are rolled back.
        /// This can be altered globally by setting the <see cref="ManagedProject.AbortSetupOnUnhandledExceptions"/> property.
        /// </para>
        /// </summary>
        /// <param name="e"></param>
        void AfterInstallFiles(SetupEventArgs e);
    }
}
