using System.Collections.Generic;
using WixSharp.Bootstrapper;

namespace NineDigit.WixSharpExtensions
{
    public sealed class ExitCodeMapBuilder
    {

        private const int DefaultIndex = int.MinValue;
#if NET8_0
        readonly IDictionary<int, BehaviorValues> data;
#else
        readonly IDictionary<int?, BehaviorValues> data;
#endif

        public ExitCodeMapBuilder()
        {

#if NET8_0
            this.data = new Dictionary<int, BehaviorValues>();
#else
            this.data = new Dictionary<int?, BehaviorValues>();
#endif
        }

        /// <summary>
        /// Adds result mapping for executable exit code.
        /// </summary>
        /// <param name="exitCode">Exit code returned from executable package.
        /// For win32 system error codes, please refer to: https://docs.microsoft.com/windows/win32/debug/system-error-codes
        /// </param>
        /// <param name="result">Specifies how given exit code will be treated by bootstrapper.</param>
        /// <returns></returns>
        public ExitCodeMapBuilder Add(int exitCode, BehaviorValues result)
        {
            this.data[exitCode] = result;
            return this;
        }

        /// <summary>
        /// Adds default result for all exit codes that are not explicitly mapped.
        /// </summary>
        /// <param name="defaultResult">Specified how exit code that is not explicitly mapped will be treated by bootstrapper.</param>
        /// <returns></returns>
        public ExitCodeMapBuilder AddDefaultResult(BehaviorValues defaultResult)
        {
#if NET8_0
            this.data[DefaultIndex] = defaultResult;
#else
            this.data[null!] = defaultResult;
#endif
            return this;
        }

        public ExitCodeMap Build()
            => new ExitCodeMap(this.data);
    }
}
