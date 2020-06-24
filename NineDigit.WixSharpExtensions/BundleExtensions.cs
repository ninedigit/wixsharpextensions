﻿using NineDigit.WixSharpExtensions.Expressions;
using System;
using System.IO;
using WixSharp;
using WixSharp.Bootstrapper;

namespace NineDigit.WixSharpExtensions
{
    /// <summary>
    /// Extensions related to Bootstrapper bundle.
    /// </summary>
    public static class BundleExtensions
    {
        /// <summary>
        /// Sets basic information about bundle project.
        /// </summary>
        /// <param name="bundle"></param>
        /// <param name="upgradeCode">
        /// Unique identifier for a family of bundles. If two bundles have the same UpgradeCode
        /// the bundle with the highest version will be installed.
        /// </param>
        /// <param name="name">Bundle name</param>
        /// <param name="version">Bundle version</param>
        /// <returns></returns>
        public static Bundle SetInfo(this Bundle bundle, Guid upgradeCode, string name, Version version)
        {
            if (bundle is null)
                throw new ArgumentNullException(nameof(bundle));

            bundle.UpgradeCode = upgradeCode;
            bundle.Name = name;
            bundle.Version = version;

            return bundle;
        }

        /// <summary>
        /// Forces WixSharp.Compiler to preserve all temporary build files (e.g. *.wxs).
        /// By default, all temporary files are deleted at the end of the build/compilation.
        /// Note: if WixSharp.Compiler fails to build EXE the PreserveTempFiles value is ignored and all temporary files are preserved.
        /// </summary>
        /// <param name="bundle"></param>
        /// <param name="preserveTempFiles"></param>
        /// <returns></returns>
        public static Bundle PreserveTempFiles(this Bundle bundle, bool preserveTempFiles = true)
        {
            if (bundle is null)
                throw new ArgumentNullException(nameof(bundle));

            bundle.PreserveTempFiles = preserveTempFiles;

            return bundle;
        }

        /// <summary>
        /// Signs the bundle with certificate described by its thumprint.
        /// </summary>
        /// <param name="bundle"></param>
        /// <param name="certificateThumbprint">Certificate thumprint.</param>
        /// <param name="signedContentDescription">Description of the product.</param>
        /// <param name="timestampServerUrl">Timestamp server URL</param>
        /// <param name="hashAlgorithm">Hash algorithm</param>
        /// <returns></returns>
        public static Bundle SignWithCertificateThumprint(this Bundle bundle,
            string certificateThumbprint,
            string signedContentDescription,
            Uri timestampServerUrl,
            HashAlgorithmType hashAlgorithm = HashAlgorithmType.sha256)
        {
            if (bundle is null)
                throw new ArgumentNullException(nameof(bundle));
            if (string.IsNullOrWhiteSpace(certificateThumbprint))
                throw new ArgumentException("Invalid certificate thumbprint.", nameof(certificateThumbprint));
            if (string.IsNullOrWhiteSpace(signedContentDescription))
                throw new ArgumentException("Invalid signed content description.", nameof(signedContentDescription));
            if (timestampServerUrl is null)
                throw new ArgumentNullException(nameof(timestampServerUrl));

            // https://github.com/oleg-shilo/wixsharp/blob/master/Source/src/WixSharp.Samples/Wix%23%20Samples/Signing/setup.cs
            // https://github.com/oleg-shilo/wixsharp/issues/827

            bundle.DigitalSignature = new DigitalSignatureBootstrapper()
            {
                // https://github.com/oleg-shilo/wixsharp/issues/827
                // CertificateId = CertificateThumbprint,
                // CertificateStore = StoreType.sha1Hash,
                // HashAlgorithm = HashAlgorithmType.sha256,
                Description = signedContentDescription,
                TimeUrl = timestampServerUrl,
                OptionalArguments = $"/v /sha1 {certificateThumbprint} /fd {hashAlgorithm}"
            };

            return bundle;
        }

        /// <summary>
        /// Hides an "Options" button from bootstrapper UI.
        /// An hotfix for https://github.com/oleg-shilo/wixsharp/issues/803
        /// </summary>
        /// <param name="bundle"></param>
        public static Bundle SuppressApplicationOptionsUI(this Bundle bundle)
        {
            if (bundle is null)
                throw new ArgumentNullException(nameof(bundle));

            bundle.WixSourceFormated += (ref string xmlContent) =>
            {
                if (xmlContent.Contains("SuppressOptionsUI=\"yes\""))
                    return;

                xmlContent = xmlContent.Replace(
                    ":WixStandardBootstrapperApplication ",
                    ":WixStandardBootstrapperApplication SuppressOptionsUI=\"yes\" ");
            };

            return bundle;
        }

        /// <summary>
        /// Required to use registry searches and many other non-default operations.
        /// </summary>
        /// <param name="bundle"></param>
        /// <returns></returns>
        public static Bundle IncludeWixUtilExtension(this Bundle bundle)
        {
            if (bundle is null)
                throw new ArgumentNullException(nameof(bundle));

            bundle.Include(WixExtension.Util);

            return bundle;
        }

        /// <summary>
        /// Adds online (not embedded) dependency to the bootstrapper bundle.
        /// </summary>
        /// <typeparam name="TPackage"></typeparam>
        /// <param name="bundle"></param>
        /// <param name="fileName"></param>
        /// <param name="installCondition"></param>
        /// <param name="localParentPath"></param>
        /// <param name="onlineParentPath"></param>
        /// <param name="isRequired"></param>
        /// <param name="msiVisibleInAddRemoveProgramsMenu">Applied only when TPackage is <see cref="MsiPackage"/>, ignored otherwise.</param>
        /// <param name="msiDisplayInternalUI">Applied only when TPackage is <see cref="MsiPackage"/>, ignored otherwise.</param>
        /// <param name="exeInstallCommand">Applied only when TPackage is <see cref="ExePackage"/>, ignored otherwise.</param>
        /// <returns></returns>
        public static Bundle AddOnlineDependency<TPackage>(
            this Bundle bundle,
            string fileName,
            string localParentPath,
            string onlineParentPath,
            WixExpression installCondition = null,
            bool isRequired = true,
            bool? msiVisibleInAddRemoveProgramsMenu = null,
            bool? msiDisplayInternalUI = null,
            string exeInstallCommand = null)
            where TPackage : WixSharp.Bootstrapper.Package, new()
        {
            if (bundle is null)
                throw new ArgumentNullException(nameof(bundle));

            var package = new TPackage()
            {
                DownloadUrl = Path.Combine(onlineParentPath, fileName),
                SourceFile = Path.Combine(localParentPath, fileName),
                Compressed = false, // set false to left as external payload
                InstallCondition = installCondition,
                Vital = isRequired,
            };

            if (package is MsiPackage msiPackage)
            {
                msiPackage.Visible = msiVisibleInAddRemoveProgramsMenu;
                msiPackage.DisplayInternalUI = msiDisplayInternalUI;
            }
            else if (package is ExePackage exePackage)
            {
                exePackage.InstallCommand = exeInstallCommand;
            }

            bundle.Chain.Add(package);

            return bundle;
        }

        /// <summary>
        /// Adds local (embedded) dependency to the boostrapper bundle.
        /// </summary>
        /// <typeparam name="TPackage"></typeparam>
        /// <param name="bundle"></param>
        /// <param name="filePath"></param>
        /// <param name="installCondition"></param>
        /// <param name="isRequired"></param>
        /// <param name="msiVisibleInAddRemoveProgramsMenu">Applied only when TPackage is <see cref="MsiPackage"/>, ignored otherwise.</param>
        /// <param name="msiDisplayInternalUI">Applied only when TPackage is <see cref="MsiPackage"/>, ignored otherwise.</param>
        /// <param name="exeInstallCommand">Applied only when TPackage is <see cref="ExePackage"/>, ignored otherwise.</param>
        /// <returns></returns>
        public static Bundle AddLocalDependency<TPackage>(
            this Bundle bundle,
            string filePath,
            WixExpression installCondition = null,
            bool isRequired = true,
            bool? msiVisibleInAddRemoveProgramsMenu = null,
            bool? msiDisplayInternalUI = null,
            string exeInstallCommand = null)
            where TPackage : WixSharp.Bootstrapper.Package, new()
        {
            if (bundle is null)
                throw new ArgumentNullException(nameof(bundle));

            var package = new TPackage()
            {
                SourceFile = filePath,
                Compressed = true, // set true to keep as internal payload
                InstallCondition = installCondition,
                Vital = isRequired,
            };

            if (package is MsiPackage msiPackage)
            {
                msiPackage.Visible = msiVisibleInAddRemoveProgramsMenu;
                msiPackage.DisplayInternalUI = msiDisplayInternalUI;
            }
            else if (package is ExePackage exePackage)
            {
                exePackage.InstallCommand = exeInstallCommand;
            }

            bundle.Chain.Add(package);

            return bundle;
        }

        /// <summary>
        /// Adds rollback boundary to the chain.
        /// </summary>
        /// <param name="bundle"></param>
        /// <returns></returns>
        public static Bundle AddRollbackBoundary(this Bundle bundle)
        {
            if (bundle is null)
                throw new ArgumentNullException(nameof(bundle));

            bundle.Chain.Add(new RollbackBoundary());

            return bundle;
        }

        /// <summary>
        /// Changes all chain items from online to local dependencies.
        /// </summary>
        /// <param name="bundle"></param>
        /// <returns></returns>
        public static Bundle SetAllOnlineDependenciesToLocal(this Bundle bundle)
        {
            if (bundle is null)
                throw new ArgumentNullException(nameof(bundle));

            foreach (var chainItem in bundle.Chain)
            {
                if (chainItem is WixSharp.Bootstrapper.Package package)
                {
                    package.Compressed = true;
                    package.DownloadUrl = null;
                }
            }

            return bundle;
        }

        /// <summary>
        /// </summary>
        /// <param name="bundle"></param>
        /// <param name="destinationVariableName"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        /// <remarks>
        /// https://stackoverflow.com/questions/38567796/how-to-determine-if-asp-net-core-has-been-installed-on-a-windows-server
        /// </remarks>
        public static Bundle AddRegistrySearchAspNetCoreExists(this Bundle bundle, string destinationVariableName, WixExpression condition = null)
        {
            if (bundle is null)
                throw new ArgumentNullException(nameof(bundle));

            return bundle.AddRegistrySearchFor64And86(
                destinationVariableName: destinationVariableName,
                root: RegistryHive.LocalMachine,
                keyX86: @"SOFTWARE\dotnet\Setup\InstalledVersions\x86\sharedhost",
                keyX64: @"SOFTWARE\dotnet\Setup\InstalledVersions\x64\sharedhost",
                value: "Version",
                condition: condition,
                result: SearchResult.exists,
                format: SearchFormat.raw);
        }

        /// <summary>
        /// </summary>
        /// <param name="bundle"></param>
        /// <param name="destinationVariableName"></param>
        /// <param name="condition">Condition for evaluating the search. If this evaluates to false, the search is not executed at all.</param>
        /// <returns></returns>
        /// <remarks>
        /// https://stackoverflow.com/questions/38567796/how-to-determine-if-asp-net-core-has-been-installed-on-a-windows-server
        /// </remarks>
        public static Bundle AddRegistrySearchAspNetCoreVersion(this Bundle bundle, string destinationVariableName, WixExpression condition = null)
        {
            if (bundle is null)
                throw new ArgumentNullException(nameof(bundle));

            return bundle.AddRegistrySearchFor64And86(
                destinationVariableName: destinationVariableName,
                root: RegistryHive.LocalMachine,
                keyX86: @"SOFTWARE\dotnet\Setup\InstalledVersions\x86\sharedhost",
                keyX64: @"SOFTWARE\dotnet\Setup\InstalledVersions\x64\sharedhost",
                value: "Version",
                condition: condition,
                result: SearchResult.value,
                format: SearchFormat.raw);
        }

        /// <summary>
        /// </summary>
        /// <param name="bundle"></param>
        /// <param name="destinationVariableName"></param>
        /// <param name="condition">Condition for evaluating the search. If this evaluates to false, the search is not executed at all.</param>
        /// <returns></returns>
        public static Bundle AddRegistrySeachWindows10OrNewerDetected(this Bundle bundle, string destinationVariableName, WixExpression condition = null)
        {
            if (bundle is null)
                throw new ArgumentNullException(nameof(bundle));

            // https://stackoverflow.com/a/31143093/1218508
            return bundle.AddRegistrySearch(new UtilRegistrySearch()
            {
                Variable = destinationVariableName,
                Root = RegistryHive.LocalMachine,
                Key = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion",
                Value = "CurrentMajorVersionNumber",
                Result = SearchResult.exists,
                Format = SearchFormat.raw,
                Condition = condition
            });
        }

        /// <summary>
        /// Adds two registry searches - for x64 and x86 registry.
        /// </summary>
        /// <param name="bundle"></param>
        /// <param name="destinationVariableName">Name of the variable in which to place the result of the search.</param>
        /// <param name="root"></param>
        /// <param name="keyX86"></param>
        /// <param name="keyX64"></param>
        /// <param name="value"></param>
        /// <param name="condition">Condition for evaluating the search. If this evaluates to false, the search is not executed at all.</param>
        /// <param name="result"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static Bundle AddRegistrySearchFor64And86(this Bundle bundle,
            string destinationVariableName,
            RegistryHive root,
            string keyX86,
            string keyX64,
            string value = null,
            WixExpression condition = null,
            SearchResult? result = null,
            SearchFormat? format = null)
        {
            if (bundle is null)
                throw new ArgumentNullException(nameof(bundle));

            if (string.IsNullOrWhiteSpace(destinationVariableName))
                throw new ArgumentException("Invalid variable name", nameof(destinationVariableName));

            bundle.AddRegistrySearch(new UtilRegistrySearch()
            {
                Variable = destinationVariableName,
                Root = root,
                Key = keyX64,
                Value = value,
                Condition = condition != null ? condition & WixExpression.Is64BitOS() : WixExpression.Is64BitOS(),
                Win64 = true,
                Result = result,
                Format = format,
            });
            bundle.AddRegistrySearch(new UtilRegistrySearch()
            {
                Variable = destinationVariableName,
                Root = root,
                Key = keyX86,
                Value = value,
                Condition = condition != null ? condition & !WixExpression.Is64BitOS() : !WixExpression.Is64BitOS(),
                Win64 = false,
                Result = result,
                Format = format,
            });

            return bundle;
        }

        /// <summary>
        /// Adds registry search to the bootstrapper bundle.
        /// </summary>
        /// <param name="bundle"></param>
        /// <param name="utilRegistrySearch"></param>
        /// <returns></returns>
        public static Bundle AddRegistrySearch(this Bundle bundle, UtilRegistrySearch utilRegistrySearch)
        {
            if (bundle is null)
                throw new ArgumentNullException(nameof(bundle));

            if (utilRegistrySearch is null)
                throw new ArgumentNullException(nameof(utilRegistrySearch));

            bundle.AddWixFragment("Wix/Bundle", utilRegistrySearch);

            return bundle;
        }

        /// <summary>
        /// Bundle itself will not be visible in Add/Remove programs menu.
        /// It is still possible to to configure show/hide its chain items separately.
        /// </summary>
        /// <param name="bundle"></param>
        /// <returns></returns>
        public static Bundle HideFromAddRemovePrograms(this Bundle bundle)
        {
            if (bundle is null)
                throw new ArgumentNullException(nameof(bundle));

            bundle.DisableRemove = true;
            bundle.DisableModify = "yes";

            return bundle;
        }
    }
}