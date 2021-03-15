using System;
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
            using (var hashAlgorithm = SHA256.Create())
            {
                using (var stream = System.IO.File.OpenRead(filePath))
                {
                    return hashAlgorithm.ComputeHash(stream);
                }
            }
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
    }
}
