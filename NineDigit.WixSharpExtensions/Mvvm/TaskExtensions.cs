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
        public static async void FireAndForgetSafeAsync(this Task task, IErrorHandler? handler = null)
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
