using System.Collections.Generic;
using WixSharp.Bootstrapper;

namespace NineDigit.WixSharpExtensions
{
    public sealed class ExitCodeMapBuilder
    {
        readonly IDictionary<int?, BehaviorValues> data;

        public ExitCodeMapBuilder()
        {
            this.data = new Dictionary<int?, BehaviorValues>();
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
            this.data[null] = defaultResult;
            return this;
        }

        public ExitCodeMap Build()
            => new ExitCodeMap(this.data);
    }
}
