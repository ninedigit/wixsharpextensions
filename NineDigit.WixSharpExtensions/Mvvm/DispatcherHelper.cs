using System;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace NineDigit.WixSharpExtensions.Mvvm
{
    public static class DispatcherHelper
    {
        /// <summary>
        /// Invokes action with single argument of type T on UI thread
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">Action to be invoked</param>
        /// <param name="argument">Argument to pass to the invoked action</param>
        public static void BeginInvokeOnUI<T>(Action<T> action, T argument)
            => DefaultDispatcher.BeginInvoke(action, argument);

        /// <summary>
        /// Invokes specified action on UI thread. 
        /// Waiting for action execution completion is not performed.
        /// </summary>
        /// <param name="action"></param>
        public static void BeginInvokeOnUI(Action action)
        {
            if (action is null)
                throw new ArgumentNullException(nameof(action));

            BeginInvokeOnUI<object>((obj) => action(), null!);
        }

        /// <summary>
        /// Invokes action on UI thread and waits till action is completed
        /// </summary>
        /// <param name="action">Action to be invoked</param>
        public static void InvokeOnUI(Action action)
        {
            if (action is null)
                throw new ArgumentNullException(nameof(action));

            if (TaskSchedulerHelper.IsRunningOnBackgroundThread())
            {
                // http://stackoverflow.com/questions/9453553/windows-phone-how-to-tell-when-deployment-current-dispatcher-begininvoke-has-co/9453821#9453821
                void innerAction(EventWaitHandle evtWaitHandle)
                {
                    action();
                    evtWaitHandle.Set();
                }

                using EventWaitHandle waitHandle = new AutoResetEvent(false);
                
                BeginInvokeOnUI(innerAction, waitHandle);
                
                waitHandle.WaitOne();
            }
            else
            {
                action();
            }
        }

        /// <summary>
        /// Wraps the Application Dispatcher.
        /// </summary>
        internal static class DefaultDispatcher
        {
            /// <summary>
            /// Forwards the BeginInvoke to the current application's <see cref="Dispatcher"/>.
            /// </summary>
            /// <param name="action">Method to be invoked.</param>
            /// <param name="arg">Arguments to pass to the invoked method.</param>
            public static void BeginInvoke(Delegate action, object? arg)
            {
                if (action is null)
                    throw new ArgumentNullException(nameof(action));

                var app = Application.Current;

                if (app is null)
                    throw new InvalidOperationException("No associated application found to invoke a task.");

                app.Dispatcher.BeginInvoke(DispatcherPriority.Normal, action, arg);
            }
        }
    }
}
