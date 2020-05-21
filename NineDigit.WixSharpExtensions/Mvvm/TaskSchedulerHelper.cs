using System.Threading;
using System.Threading.Tasks;

namespace NineDigit.WixSharpExtensions.Mvvm
{
    public static class TaskSchedulerHelper
    {
        public static TaskScheduler FromCurrentSynchronizationContextOrDefault()
            => SynchronizationContext.Current is null
                ? TaskScheduler.Current
                : TaskScheduler.FromCurrentSynchronizationContext();

        /// <summary>
        /// Returns true if this method has been invokend on background thread, false otherwise.
        /// </summary>
        /// <returns></returns>
        public static bool IsRunningOnBackgroundThread()
            => null == SynchronizationContext.Current;
    }
}
