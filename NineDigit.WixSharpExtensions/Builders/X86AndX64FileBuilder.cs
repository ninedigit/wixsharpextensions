using NineDigit.WixSharpExtensions.Expressions;
using System;
using System.Collections.Generic;
using System.IO;
using WixSharp;

namespace NineDigit.WixSharpExtensions.Builders
{
    public sealed class X86AndX64FileBuilder
    {
        [Flags]
        enum FileBuildTypes
        {
            /// <summary>
            /// Same file is part of X86 and X64 build.
            /// </summary>
            Common = 1,
            /// <summary>
            /// Different files with matching names are part of both X86 and X64 build.
            /// </summary>
            BuildSpecific = 2,
            /// <summary>
            /// File is part of X86 build only.
            /// </summary>
            X86BuildOnly = 4,
            /// <summary>
            /// File is part of X64 build only.
            /// </summary>
            X64BuildOnly = 8
        }

        readonly string x86BuildDirectoryPath;
        readonly string x64BuildDirectoryPath;
        readonly IDictionary<string, string> x86BuildFiles;
        readonly IDictionary<string, string> x64BuildFiles;

        public X86AndX64FileBuilder(string x86BuildDirectoryPath, string x64BuildDirectoryPath)
        {
            if (string.IsNullOrWhiteSpace(x86BuildDirectoryPath))
                throw new ArgumentException($"'{nameof(x86BuildDirectoryPath)}' cannot be null or whitespace", nameof(x86BuildDirectoryPath));

            if (string.IsNullOrWhiteSpace(x64BuildDirectoryPath))
                throw new ArgumentException($"'{nameof(x64BuildDirectoryPath)}' cannot be null or whitespace", nameof(x64BuildDirectoryPath));

            if (x86BuildDirectoryPath == x64BuildDirectoryPath)
                throw new InvalidOperationException("The build directories must not match.");

            this.x86BuildDirectoryPath = x86BuildDirectoryPath;
            this.x64BuildDirectoryPath = x64BuildDirectoryPath;
            this.x86BuildFiles = GetFileHashes(x86BuildDirectoryPath);
            this.x64BuildFiles = GetFileHashes(x64BuildDirectoryPath);
        }

        private static IDictionary<string, string> GetFileHashes(string rootDirectoryPath)
        {
            if (string.IsNullOrWhiteSpace(rootDirectoryPath))
                throw new ArgumentException($"'{nameof(rootDirectoryPath)}' cannot be null or whitespace", nameof(rootDirectoryPath));

            var result = new Dictionary<string, string>();

            var directory = new DirectoryInfo(rootDirectoryPath);
            var files = directory.GetFiles("*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var filePath = file.FullName;
                var fileHash = FileHelper.GetFileHashString(filePath);

                result.Add(filePath, fileHash);
            }

            return result;
        }

        private FileBuildTypes GetFileBuildType(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException($"'{nameof(filePath)}' cannot be null or whitespace", nameof(filePath));

            var isX86FilePath = filePath.StartsWith(this.x86BuildDirectoryPath, StringComparison.InvariantCultureIgnoreCase);
            var isX64FilePath = filePath.StartsWith(this.x64BuildDirectoryPath, StringComparison.InvariantCultureIgnoreCase);

            if (!(isX86FilePath ^ isX64FilePath))
                throw new InvalidOperationException("The file origin could not be determined.");

            var x86FilePath = isX86FilePath ? filePath : Path.Combine(this.x86BuildDirectoryPath, filePath.Substring(this.x64BuildDirectoryPath.Length).Trim('\\'));
            var x64FilePath = isX64FilePath ? filePath : Path.Combine(this.x64BuildDirectoryPath, filePath.Substring(this.x86BuildDirectoryPath.Length).Trim('\\'));

            var existsInX86Build = this.x86BuildFiles.TryGetValue(x86FilePath, out string x86FileHash);
            var existsInX64Build = this.x64BuildFiles.TryGetValue(x64FilePath, out string x64FileHash);

            if (existsInX86Build && existsInX64Build)
                return x86FileHash == x64FileHash ? FileBuildTypes.Common : FileBuildTypes.BuildSpecific;
            else if (existsInX86Build)
                return FileBuildTypes.X86BuildOnly;
            else if (existsInX64Build)
                return FileBuildTypes.X64BuildOnly;

            throw new InvalidOperationException("The file hash was not found in x86 nor in x64 bit build.");
        }

        private bool IsFileBuildType(string filePath, FileBuildTypes types)
            => (GetFileBuildType(filePath) & types) != 0;

        public Files[] Build()
        {
            var is32BitOsCondition = new Condition(WixExpression.Is32BitOS());
            var is64BitOsCondition = new Condition(WixExpression.Is64BitOS());

            return new Files[]
            {
                // common files
                new Files(
                    sourcePath: Path.Combine(this.x86BuildDirectoryPath, "*.*"),
                    filter: (filePath) => IsFileBuildType(filePath, FileBuildTypes.Common)),

                // x86-specific
                new Files(
                    sourcePath: Path.Combine(this.x86BuildDirectoryPath, "*.*"),
                    filter: (filePath) => IsFileBuildType(filePath, FileBuildTypes.BuildSpecific | FileBuildTypes.X86BuildOnly))
                {
                    OnProcess = (wixFile) => wixFile.Condition = is32BitOsCondition
                },

                // x64-specific
                new Files(
                    sourcePath: Path.Combine(this.x64BuildDirectoryPath, "*.*"),
                    filter: (filePath) => IsFileBuildType(filePath, FileBuildTypes.BuildSpecific | FileBuildTypes.X64BuildOnly))
                {
                    OnProcess = (wixFile) => wixFile.Condition = is64BitOsCondition
                }
            };
        }
    }
}
