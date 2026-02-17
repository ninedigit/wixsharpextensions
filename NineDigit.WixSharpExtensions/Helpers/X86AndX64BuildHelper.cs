using System;
using System.IO;
using WixSharp;

namespace NineDigit.WixSharpExtensions
{
    public sealed class X86AndX64BuildHelper
    {
        readonly string x86BuildDirectoryPath;
        readonly string x64BuildDirectoryPath;

        /// <summary>
        /// </summary>
        /// <param name="x86BuildDirectoryPath">Directory path that contains x86 build.</param>
        /// <param name="x64BuildDirectoryPath">Directory path that contains x64 build.</param>
        /// <param name="exeFileName">Name of executable file. E.g. myApp.exe</param>
        public X86AndX64BuildHelper(string x86BuildDirectoryPath, string x64BuildDirectoryPath, string exeFileName)
        {
            if (string.IsNullOrWhiteSpace(x86BuildDirectoryPath))
                throw new ArgumentException($"'{nameof(x86BuildDirectoryPath)}' cannot be null or whitespace", nameof(x86BuildDirectoryPath));

            if (string.IsNullOrWhiteSpace(x64BuildDirectoryPath))
                throw new ArgumentException($"'{nameof(x64BuildDirectoryPath)}' cannot be null or whitespace", nameof(x64BuildDirectoryPath));

            if (x86BuildDirectoryPath == x64BuildDirectoryPath)
                throw new InvalidOperationException("The build directories must not match.");

            this.x86BuildDirectoryPath = x86BuildDirectoryPath;
            this.x64BuildDirectoryPath = x64BuildDirectoryPath;

            this.ExecutableFileName = exeFileName;
            
            var x86ExeFilePath = Path.Combine(this.x86BuildDirectoryPath, exeFileName);
            var x64ExeFilePath = Path.Combine(this.x64BuildDirectoryPath, exeFileName);

            if (!FileHelper.TryGetFileVersions(x86ExeFilePath, out FileVersions? x86Versions))
                throw new InvalidOperationException($"Could not parse X86 build assembly versions.");

            if (!FileHelper.TryGetFileVersions(x64ExeFilePath, out FileVersions? x64Versions))
                throw new InvalidOperationException($"Could not parse X64 build assembly versions.");

            if (x64Versions != x86Versions)
                throw new InvalidOperationException(
                    $"Version mismatch between X86 build (version: '{x86Versions.Version}', version info: {x86Versions.VersionInfo}) " +
                    $"and X64 build (version: '{x64Versions.Version}' / version info: '{x64Versions.VersionInfo}').");

            Versions = x64Versions;
        }

        [Obsolete("Use Versions property.")]
        public Version Version => Versions.Version;
        public FileVersions Versions { get; }
        public string ExecutableFileName { get; }

        /// <summary>
        /// </summary>
        /// <param name="filter">Optional filter to be applied for every file to be evaluated for the inclusion into MSI. Example: <code>(filePath, tileType) => !filePath.EndsWith(".Test.dll")</code></param>
        /// <returns></returns>
        public Files[] GetFiles(Func<string, FileBuildTypes, bool>? filter = null)
            => new X86AndX64FileBuilder(this.x86BuildDirectoryPath, this.x64BuildDirectoryPath).Build(filter);
    }
}
