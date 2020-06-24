using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using WixSharp;

namespace NineDigit.WixSharpExtensions
{
    /// <summary>
    /// Project extensions for both Project and ManagerProject classes.
    /// </summary>
    public static class ProjectExtensions
    {
        /// <summary>
        /// </summary>
        /// <typeparam name="TProject"></typeparam>
        /// <param name="project"></param>
        /// <param name="directories">Collection of WixSharp.Dirs to be installed.</param>
        /// <returns></returns>
        public static TProject AddDirectories<TProject>(this TProject project, params Dir[] directories)
            where TProject : Project
        {
            if (project is null)
                throw new ArgumentNullException(nameof(project));
            if (directories is null)
                throw new ArgumentNullException(nameof(directories));
            
            if (directories.Length > 0)
                project.Dirs = project.Dirs?.JoinWith(directories) ?? directories;

            return project;
        }

        /// <summary>
        /// </summary>
        /// <typeparam name="TProject"></typeparam>
        /// <param name="project"></param>
        /// <param name="actions">Collection of actions to be attached to the project.</param>
        /// <returns></returns>
        public static TProject AddActions<TProject>(this TProject project, params WixSharp.Action[] actions)
            where TProject : Project
        {
            if (project is null)
                throw new ArgumentNullException(nameof(project));
            if (actions is null)
                throw new ArgumentNullException(nameof(actions));

            if (actions.Length > 0)
                project.Actions = project.Actions?.JoinWith(actions) ?? actions;

            return project;
        }

        /// <summary>
        /// Sets basic project info.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="upgradeCode">Same value for all project versions. Otherwise upgrade will not work.</param>
        /// <param name="name">Project name visible in installer.</param>
        /// <param name="description">Project full name or description</param>
        /// <param name="version">Project version without revision part specified.</param>
        /// <param name="installScope">Installation scope of this project.</param>
        /// <returns></returns>
        public static TProject SetProjectInfo<TProject>(this TProject project,
            Guid upgradeCode,
            string name,
            string description,
            Version version,
            InstallScope installScope = InstallScope.perMachine)
            where TProject : Project
        {
            if (project is null)
                throw new ArgumentNullException(nameof(project));
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Invalid project name.", nameof(name));
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Invalid project description.", nameof(description));
            if (version is null)
                throw new ArgumentNullException(nameof(version));
            if (version.Revision != default)
                throw new ArgumentException("Version must not contain revision. Only first three parts (major, minor and build) are supported by Wix.", nameof(version));

            project.GUID = upgradeCode;
            project.Name = name;
            project.Description = description;
            project.UpgradeCode = upgradeCode;
            project.InstallScope = installScope;
            project.Version = version;

            return project;
        }

        /// <summary>
        /// Sets properties visible in add/remove programs section of control panel.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="name">Name of the product</param>
        /// <param name="manufacturer">Product manufacturer</param>
        /// <param name="readme"></param>
        /// <param name="comment"></param>
        /// <param name="contact"></param>
        /// <param name="helpUrl"></param>
        /// <param name="aboutUrl"></param>
        /// <param name="productIconFilePath">Icon file</param>
        /// <param name="helpTelephone"></param>
        /// <returns></returns>
        public static TProject SetControlPanelInfo<TProject>(this TProject project,
            string name,
            string manufacturer,
            string readme,
            string comment,
            string contact,
            Uri helpUrl,
            Uri aboutUrl,
            FileInfo productIconFilePath,
            string helpTelephone = null)
            where TProject : Project
        {
            if (project is null)
                throw new ArgumentNullException(nameof(project));
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Invalid product name.", nameof(name));

            if (project.ControlPanelInfo is null)
                project.ControlPanelInfo = new ProductInfo();

            // https://github.com/oleg-shilo/wixsharp/blob/master/Source/src/WixSharp.Samples/Wix%23%20Samples/ProductInfo/setup.cs
            
            var info = project.ControlPanelInfo;

            info.Name = name;
            info.Manufacturer = manufacturer;
            info.Readme = readme;
            info.Comments = comment;
            info.Contact = contact;
            info.HelpLink = helpUrl?.ToString();
            info.UrlInfoAbout = aboutUrl?.ToString();
            info.ProductIcon = productIconFilePath?.FullName;
            info.HelpTelephone = helpTelephone;

            return project;
        }

        /// <summary>
        /// </summary>
        /// <param name="project"></param>
        /// <param name="downgradeErrorMessage">Message that will appear when user tries to install older version. The [ProductName] will be replaced with actual product name.</param>
        /// <returns></returns>
        public static TProject DisableDowngradeToPreviousVersion<TProject>(this TProject project,
            string downgradeErrorMessage = "A newer version of [ProductName] is already installed. If you really want to install the older version, please uninstall this application first. The installation will now terminate.")
            where TProject : Project
        {
            if (project is null)
                throw new ArgumentNullException(nameof(project));

            if (string.IsNullOrWhiteSpace(downgradeErrorMessage))
                throw new ArgumentException("Downgrade error message must be specified.", nameof(downgradeErrorMessage));

            if (project.MajorUpgrade is null)
                project.MajorUpgrade = new MajorUpgrade();

            project.MajorUpgrade.DowngradeErrorMessage = downgradeErrorMessage;

            return project;
        }

        /// <summary>
        /// Installer content cabinet file (.cab) will be embedded to the msi installer.
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public static TProject EmbedCabinetIntoInstaller<TProject>(this TProject project)
            where TProject : Project
        {
            if (project is null)
                throw new ArgumentNullException(nameof(project));

            if (project.Media is null)
                project.Media = new List<Media>();

            project.Media.Add(new Media() { EmbedCab = true });

            return project;
        }

        /// <summary>
        /// Signs the product MSI with certificate described by its thumprint.
        /// </summary>
        /// <typeparam name="TProject"></typeparam>
        /// <param name="project"></param>
        /// <param name="certificateThumbprint">Certificate thumprint.</param>
        /// <param name="signedContentDescription">Description of the product.</param>
        /// <param name="timestampServerUrl">Timestamp server URL</param>
        /// <param name="hashAlgorithm">Hash algorithm</param>
        /// <returns></returns>
        public static TProject SignWithCertificateThumprint<TProject>(this TProject project,
            string certificateThumbprint,
            string signedContentDescription,
            Uri timestampServerUrl,
            HashAlgorithmType hashAlgorithm = HashAlgorithmType.sha256)
            where TProject : Project
        {
            if (project is null)
                throw new ArgumentNullException(nameof(project));
            if (string.IsNullOrWhiteSpace(certificateThumbprint))
                throw new ArgumentException("Invalid certificate thumbprint.", nameof(certificateThumbprint));
            if (string.IsNullOrWhiteSpace(signedContentDescription))
                throw new ArgumentException("Invalid signed content description.", nameof(signedContentDescription));
            if (timestampServerUrl is null)
                throw new ArgumentNullException(nameof(timestampServerUrl));

            // https://github.com/oleg-shilo/wixsharp/blob/master/Source/src/WixSharp.Samples/Wix%23%20Samples/Signing/setup.cs
            project.DigitalSignature = new DigitalSignature()
            {
                CertificateId = certificateThumbprint,
                CertificateStore = StoreType.sha1Hash,
                Description = signedContentDescription,
                HashAlgorithm = hashAlgorithm,
                TimeUrl = timestampServerUrl
            };

            return project;
        }

        /// <summary>
        /// Sets and configures minimal user interface.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="backgroundImage">
        /// Installer dialogs background.
        /// If not specified default image will be used.
        /// If the image is to be used in the default ManagedUI dialogs it will be left-docked
        /// at runtime and will effectively play the role of a left-aligned dialog banner.
        /// Thus if it is too wide it can push away (to right) the all other UI elements.
        /// The optimal size of the image for ManagedUI is 494 by 312 pixels.
        /// The optimal format is BMP.
        /// </param>
        /// <param name="bannerImage">
        /// Installer banner visible on top of the window.
        /// If not specified, default image will be used.
        /// The optimal format is BMP.
        /// The optimal size of the image is 500 by 63 pixels.
        /// </param>
        /// <param name="licenceRtfFile"></param>
        /// <returns></returns>
        public static TProject SetMinimalUI<TProject>(this TProject project,
            FileInfo backgroundImage = null,
            FileInfo bannerImage = null,
            FileInfo licenceRtfFile = null)
            where TProject : Project
        {
            if (project is null)
                throw new ArgumentNullException(nameof(project));

            project.UI = WUI.WixUI_Minimal;
            project.BackgroundImage = backgroundImage?.FullName;
            project.ValidateBackgroundImage = false; // ignoring incorrect banner resolution
            project.BannerImage = bannerImage?.FullName;
            project.LicenceFile = licenceRtfFile?.FullName;

            return project;
        }

        /// <summary>
        /// Sets MSI output directory and file name.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="outputDir"></param>
        /// <param name="outputFileName">File name without the (.MSI/.MSM) extension.</param>
        /// <returns></returns>
        public static TProject SetOutputPath<TProject>(this TProject project,
            DirectoryInfo outputDir,
            string outputFileName)
            where TProject : Project
        {
            if (project is null)
                throw new ArgumentNullException(nameof(project));

            project.OutDir = outputDir?.FullName;
            project.OutFileName = outputFileName;

            return project;
        }

        /// <summary>
        /// Forces WixSharp.Compiler to preserve all temporary build files (e.g. *.wxs).
        /// By default, all temporary files are deleted at the end of the build/compilation.
        /// Note: if WixSharp.Compiler fails to build MSI the PreserveTempFiles value is ignored and all temporary files are preserved.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="preserveTempFiles"></param>
        /// <returns></returns>
        public static TProject PreserveTempFiles<TProject>(this TProject project, bool preserveTempFiles = true)
            where TProject : Project
        {
            if (project is null)
                throw new ArgumentNullException(nameof(project));

            project.PreserveTempFiles = preserveTempFiles;

            return project;
        }

        /// <summary>
        /// Adds windows service with firewall rule.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="executableFileName">Name (with extension, wihout path) of the executable file that represents windows service.</param>
        /// <param name="name">Service name visible in services list.</param>
        /// <param name="displayName"></param>
        /// <param name="description">Service description visible in services list.</param>
        /// <param name="dependsOn">Collection of service dependencies</param>
        /// <returns></returns>
        public static TProject AddWindowsServiceAndFirewallRule<TProject>(this TProject project,
            string executableFileName,
            string name,
            string displayName,
            string description,
            ServiceDependency[] dependsOn = null)
            where TProject : Project
        {
            if (project is null)
                throw new ArgumentNullException(nameof(project));

            var serviceFile = project
                .ResolveWildCards() // we need evaluate files specified by mask to get desired .exe file, otherwise the "AllFiles" preoprty would contain empty collection.
                .AllFiles
                .SingleOrDefault(i => i.Name.EndsWith(executableFileName, true, CultureInfo.InvariantCulture));

            if (serviceFile is null)
                throw new InvalidOperationException("Service file could not be found. Please verify that you specified executable file name with extension and without path. Make sure that AddWindowsService method is called after all files and directories are added to the project definition.");

            serviceFile.ServiceInstaller = new ServiceInstaller
            {
                Name = name,
                DisplayName = displayName,
                Description = description,
                ErrorControl = SvcErrorControl.normal,
                Start = SvcStartType.auto,
                Type = SvcType.ownProcess,
                StartOn = SvcEvent.Install_Wait,
                StopOn = SvcEvent.Uninstall_Wait,
                RemoveOn = SvcEvent.Uninstall_Wait,
                ConfigureServiceTrigger = ConfigureServiceTrigger.None,
                FirstFailureActionType = FailureActionType.restart,
                SecondFailureActionType = FailureActionType.restart,
                DependsOn = dependsOn
            };

            serviceFile.FirewallExceptions = new[]
            {
                new FirewallException()
                {
                    Name = name,
                    Description = description,
                    Scope = FirewallExceptionScope.any
                }
            };

            return project;
        }
    }
}