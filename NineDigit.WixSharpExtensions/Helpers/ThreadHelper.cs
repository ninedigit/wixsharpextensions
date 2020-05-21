using System;
using System.Threading;

namespace NineDigit.WixSharpExtensions
{
    /// <summary>
    /// Helper for working with threads.
    /// </summary>
    public static class ThreadHelper
    {
        /// <summary>
        /// Starts thread on apartment given by <paramref name="apartmentState"/>
        /// and waits until the thead terminates.
        /// </summary>
        /// <param name="apartmentState"></param>
        /// <param name="threadStart"></param>
        /// <param name="timeout">A <see cref="TimeSpan"/> set to the amount of time to wait for the thread to terminate.</param>
        public static void RunThreadAndWait(ApartmentState apartmentState, ThreadStart threadStart, TimeSpan? timeout = null)
        {
            var thread = new Thread(threadStart);

            thread.SetApartmentState(apartmentState);
            thread.Start();

            if (timeout.HasValue)
                thread.Join(timeout.Value);
            else
                thread.Join();
        }
    }
}
