using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using WixSharp.Bootstrapper;

namespace NineDigit.WixSharpExtensions
{
    /// <summary>
    /// Map of exit codes returned from executable package to a bootstrapper behavior.
    /// </summary>
    public sealed class ExitCodeMap
    {

#if NET8_0
        private readonly IDictionary<int, BehaviorValues> map;
#else
        private readonly IDictionary<int?, BehaviorValues> map;
#endif

        /// <summary>
        /// Creates new instance of exit code map. For fluent composition, use <see cref="ExitCodeMapBuilder"/>
        /// </summary>
        /// <param name="map"></param>

#if NET8_0
        public ExitCodeMap(IDictionary<int, BehaviorValues> map)
#else
        public ExitCodeMap(IDictionary<int?, BehaviorValues> map)
#endif
        {
            if (map is null)
                throw new ArgumentNullException(nameof(map));

#if NET8_0
            this.map = new Dictionary<int, BehaviorValues>(map);
#else
            this.map = new Dictionary<int?, BehaviorValues>(map);
#endif
        }

        public void BindTo(ExePackage exePackage)
        {
            if (exePackage is null)
                throw new ArgumentNullException(nameof(exePackage));

#if NET8_0
            exePackage.ExitCodes = this.map
                .Select(i => new ExitCode() { Value = i.Key.ToString(CultureInfo.InvariantCulture), Behavior = i.Value })
                .ToList();
#else
            exePackage.ExitCodes = this.map
                .Select(i => new ExitCode() { Value = i.Key?.ToString(CultureInfo.InvariantCulture), Behavior = i.Value })
                .ToList();
#endif
        }
    }
}
