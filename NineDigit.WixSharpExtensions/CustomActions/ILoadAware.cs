using WixSharp;

namespace NineDigit.WixSharpExtensions
{
    public interface ILoadAware
    {
        /// <summary>
        /// Occurs before "AppSearch" standard action, in non-elevated context (as non-admin).
        /// <para>
        /// If exception occurs during invocation, installer terminates and all changes are rolled back.
        /// This can be altered globally by setting the <see cref="ManagedProject.AbortSetupOnUnhandledExceptions"/> property.
        /// </para>
        /// </summary>
        /// <param name="e"></param>
        void OnLoad(SetupEventArgs e);
    }
}
