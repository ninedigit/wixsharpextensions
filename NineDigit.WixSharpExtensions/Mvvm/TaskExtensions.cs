using System;
using System.Threading.Tasks;

namespace NineDigit.WixSharpExtensions
{
    /// <summary>
    /// Extensions methods related to <see cref="Task"/> class.
    /// </summary>
    public static class TaskExtensions
    {
        /// <summary>
        /// Awaits given <paramref name="task"/> and handles exception, if <paramref name="handler"/> is provided.
        /// </summary>
        /// <param name="task"></param>
        /// <param name="handler"></param>
#pragma warning disable RECS0165 // Asynchronous methods should return a Task instead of void
        public static async void FireAndForgetSafeAsync(this Task task, IErrorHandler handler = null)
#pragma warning restore RECS0165 // Asynchronous methods should return a Task instead of void
        {
            if (task is null)
                throw new ArgumentNullException(nameof(task));

            try
            {
                await task.ConfigureAwait(false);
            }
            catch (Exception ex) when (handler != null)
            {
                handler.HandleError(ex);
            }
        }
    }
}
