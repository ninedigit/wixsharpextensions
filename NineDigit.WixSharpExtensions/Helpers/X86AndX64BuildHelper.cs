using NineDigit.WixSharpExtensions.Builders;
using System;
using System.IO;
using System.Linq;
using WixSharp;

namespace NineDigit.WixSharpExtensions
{
    public sealed class X86AndX64BuildHelper
    {
        readonly string x86BuildDirectoryPath;
        readonly string x64BuildDirectoryPath;

        /// <summary>
        /// </summary>
        /// <param name="x86BuildDirectoryPath">Directory path that contains X86 build - including single .EXE file.</param>
        /// <param name="x64BuildDirectoryPath">Directory path that contains X64 build - including single .EXE file.</param>
        public X86AndX64BuildHelper(string x86BuildDirectoryPath, string x64BuildDirectoryPath)
        {
            if (string.IsNullOrWhiteSpace(x86BuildDirectoryPath))
                throw new ArgumentException($"'{nameof(x86BuildDirectoryPath)}' cannot be null or whitespace", nameof(x86BuildDirectoryPath));

            if (string.IsNullOrWhiteSpace(x64BuildDirectoryPath))
                throw new ArgumentException($"'{nameof(x64BuildDirectoryPath)}' cannot be null or whitespace", nameof(x64BuildDirectoryPath));

            if (x86BuildDirectoryPath == x64BuildDirectoryPath)
                throw new InvalidOperationException("The build directories must not match.");

            this.x86BuildDirectoryPath = x86BuildDirectoryPath;
            this.x64BuildDirectoryPath = x64BuildDirectoryPath;

            var x86ExeFilePath = GetExecutableFilePath(this.x86BuildDirectoryPath);
            var x86ExeFileName = Path.GetFileName(x86ExeFilePath);
            var x64ExeFilePath = GetExecutableFilePath(this.x64BuildDirectoryPath);
            var x64ExeFileName = Path.GetFileName(x64ExeFilePath);

            if (Path.GetFileName(x86ExeFileName) != x64ExeFileName)
                throw new InvalidOperationException($"Executable file names mismatch between X86 build ({x86ExeFileName}) and X64 build ({x64ExeFileName})");

            this.ExecutableFileName = x64ExeFileName;

            var x86ExeFileVersion = GetExecutableOrDllVersion(x86ExeFilePath);
            var x64ExeFileVersion = GetExecutableOrDllVersion(x64ExeFilePath);

            if (x86ExeFileVersion != x64ExeFileVersion)
                throw new InvalidOperationException($"Version mismatch between X86 build ({x86ExeFileVersion}) and X64 build ({x64ExeFileVersion})");

            this.Version = x64ExeFileVersion;
        }

        public Version Version { get; }
        public string ExecutableFileName { get; }

        private static string GetExecutableFilePath(string directoryName)
        {
            var executableAssemblyFileNameCandidates = Directory.GetFiles(directoryName, "*.exe", SearchOption.TopDirectoryOnly).Where(i => i.EndsWith(".exe", ignoreCase: true)).ToList();
            if (executableAssemblyFileNameCandidates.Count == 0)
                throw new InvalidOperationException($"No .exe assembly found in directory {directoryName}.");
            if (executableAssemblyFileNameCandidates.Count > 1)
                throw new InvalidOperationException($"More than one .exe assembly found in directory {directoryName}.");

            return executableAssemblyFileNameCandidates[0];
        }

        private static Version GetExecutableOrDllVersion(string executableFilePath)
        {
            if (FileHelper.TryGetAssemblyFileVersion(executableFilePath, out Version? version) ||
                FileHelper.TryGetAssemblyFileVersion(executableFilePath.PathChangeExtension(".dll"), out version))
            {
                return version!;
            }

            throw new InvalidOperationException("Could not get assembly file version.");
        }

        public Files[] GetFiles()
            => new X86AndX64FileBuilder(this.x86BuildDirectoryPath, this.x64BuildDirectoryPath).Build();
    }
}
