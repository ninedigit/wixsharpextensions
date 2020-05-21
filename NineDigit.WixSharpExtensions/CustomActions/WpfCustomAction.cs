using System;
using System.Threading;
using System.Windows;

namespace NineDigit.WixSharpExtensions.CustomActions
{
    /// <summary>
    /// Custom action running WPF application.
    /// </summary>
    public abstract class WpfCustomAction : CustomAction
    {
        /// <summary>
        /// Runs WPF app based on MVVM architecture.
        /// This method will return after application shuts down (this can be configured by <paramref name="shutdownMode"/> parameter).
        /// </summary>
        /// <param name="shutdownMode">Shutdown mode of application.</param>
        /// <typeparam name="TWindow">Represents main WPF app window.</typeparam>
        /// <typeparam name="TViewModel">Represents datacontext.</typeparam>
        /// <returns>Application exit code.</returns>
        protected static int RunMvvmWpfApp<TWindow, TViewModel>(ShutdownMode shutdownMode = ShutdownMode.OnLastWindowClose)
            where TWindow : Window, new()
            where TViewModel : new()
            => RunWpfApp(() => new TWindow() { DataContext = new TViewModel() }, shutdownMode);

        /// <summary>
        /// Runs WPF application.
        /// This method will return after application shuts down (this can be configured by <paramref name="shutdownMode"/> parameter).
        /// </summary>
        /// <param name="windowFactory">Factory method that produces main WPF app window. Datacontext is expected to be set in factory.</param>
        /// <param name="shutdownMode">Shutdown mode of application.</param>
        /// <returns>Application exit code.</returns>
        protected static int RunWpfApp(Func<Window> windowFactory, ShutdownMode shutdownMode = ShutdownMode.OnLastWindowClose)
        {
            if (windowFactory is null)
                throw new ArgumentNullException(nameof(windowFactory));

            int appReturnCode = 0;

            ThreadHelper.RunThreadAndWait(ApartmentState.STA, () =>
            {
                var window = windowFactory.Invoke();

                var app = new Application()
                {
                    ShutdownMode = shutdownMode,
                };

                appReturnCode = app.Run(window);
            });

            return appReturnCode;
        }
    }
}
