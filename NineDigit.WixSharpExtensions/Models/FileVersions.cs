#nullable enable

using System;

namespace NineDigit.WixSharpExtensions
{
    public sealed class FileVersions : IEquatable<FileVersions>
    {
        public FileVersions(Version version, string versionInfo)
        {
            Version = version;
            VersionInfo = versionInfo;
        }

        public Version Version { get; }
        public string VersionInfo { get; }

        public bool Equals(FileVersions? other)
        {
            if (ReferenceEquals(null, other))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return string.Equals(VersionInfo, other.VersionInfo, StringComparison.Ordinal)
                && Equals(Version, other.Version);
        }

        public override bool Equals(object obj)
            => Equals(obj as FileVersions);

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (VersionInfo != null ? StringComparer.Ordinal.GetHashCode(VersionInfo) : 0);
                hash = hash * 23 + (Version != null ? Version.GetHashCode() : 0);
                return hash;
            }
        }

        public static bool operator ==(FileVersions left, FileVersions right)
            => Equals(left, right);

        public static bool operator !=(FileVersions left, FileVersions right)
            => !Equals(left, right);
    }
}
