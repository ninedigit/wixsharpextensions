#nullable enable

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace NineDigit.WixSharpExtensions
{
    public static class FileHelper
    {
        /// <summary>
        /// Gets SHA256 hash of file specified by <paramref name="filePath"/>.
        /// </summary>
        /// <param name="filePath">File path</param>
        /// <returns></returns>
        public static byte[] GetFileHash(string filePath)
        {
            using var hashAlgorithm = SHA256.Create();
            
            using var stream = System.IO.File.OpenRead(filePath);
            
            return hashAlgorithm.ComputeHash(stream);
        }

        public static string GetFileHashString(string filePath)
        {
            var hash = GetFileHash(filePath);
            return BitConverter.ToString(hash).Replace("-", "");
        }

        /// <summary>
        /// Gets assembly version.
        /// </summary>
        /// <param name="filePath">File path</param>
        /// <param name="version">The retrieved version, if return value is <c>true</c>.</param>
        /// <returns></returns>
        public static bool TryGetAssemblyFileVersion(string filePath, out Version? version)
        {
            try
            {
                version = AssemblyName.GetAssemblyName(filePath).Version;
                return true;
            }
            catch (BadImageFormatException)
            {
                version = default;
                return false;
            }
        }

        public static bool TryGetFileVersions(this string filePath, out FileVersions? versions)
        {
            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
            {
                versions = null;
                return false;
            }

            try
            {
                var fvi = FileVersionInfo.GetVersionInfo(filePath);
                // e.g. '1.2.3'
                Version version;

                if (fvi.FileBuildPart >= 0)
                    version = new Version(fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart);
                else
                    version = new Version(fvi.FileMajorPart, fvi.FileMinorPart);

                var versionInfo = fvi.ProductVersion; // e.g. '1.2.3-beta.4'
                
                versions = new FileVersions(version, versionInfo);
                return true;
            }
            catch
            {
                versions = default;
                return false;
            }
        }
    }
}
