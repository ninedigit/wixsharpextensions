using WixSharp;

namespace NineDigit.WixSharpExtensions
{
    public interface IBeforeInstallAware
    {
        /// <summary>
        /// Called before "InstallFiles" standard action, in non-elevated context (as non-admin),
        /// before files are copied in installation directory.
        /// </summary>
        /// <para>
        /// If exception occurs during invocation, installer terminates and all changes are rolled back.
        /// This can be altered globally by setting the <see cref="ManagedProject.AbortSetupOnUnhandledExceptions"/> property.
        /// </para>
        /// <param name="e"></param>
        void OnBeforeInstallFiles(SetupEventArgs e);
    }
}
