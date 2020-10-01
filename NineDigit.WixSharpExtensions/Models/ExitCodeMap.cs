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
        private readonly IDictionary<int?, BehaviorValues> map;

        /// <summary>
        /// Creates new instance of exit code map. For fluent composition, use <see cref="ExitCodeMapBuilder"/>
        /// </summary>
        /// <param name="map"></param>
        public ExitCodeMap(IDictionary<int?, BehaviorValues> map)
        {
            if (map is null)
                throw new ArgumentNullException(nameof(map));

            this.map = new Dictionary<int?, BehaviorValues>(map);
        }

        public void BindTo(ExePackage exePackage)
        {
            if (exePackage is null)
                throw new ArgumentNullException(nameof(exePackage));

            exePackage.ExitCodes = this.map
                .Select(i => new ExitCode() { Value = i.Key?.ToString(CultureInfo.InvariantCulture), Behavior = i.Value })
                .ToList();
        }
    }
}
