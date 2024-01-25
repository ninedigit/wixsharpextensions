using System;
using System.Diagnostics;
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
            var x86ExeFileVersion = GetExecutableVersion(x86ExeFilePath);
            var x64ExeFileVersion = GetExecutableVersion(x64ExeFilePath);

            if (x86ExeFileVersion != x64ExeFileVersion)
                throw new InvalidOperationException($"Version mismatch between X86 build ({x86ExeFileVersion}) and X64 build ({x64ExeFileVersion})");

            this.Version = x64ExeFileVersion;
        }

        public Version Version { get; }
        public string ExecutableFileName { get; }

        private static Version GetExecutableVersion(string executableFilePath)
            => Version.Parse(FileVersionInfo.GetVersionInfo(executableFilePath).ProductVersion);

        /// <summary>
        /// </summary>
        /// <param name="filter">Optional filter to be applied for every file to be evaluated for the inclusion into MSI. Example: <code>(filePath, tileType) => !filePath.EndsWith(".Test.dll")</code></param>
        /// <returns></returns>
        public Files[] GetFiles(Func<string, FileBuildTypes, bool>? filter = null)
            => new X86AndX64FileBuilder(this.x86BuildDirectoryPath, this.x64BuildDirectoryPath).Build(filter);
    }
}
