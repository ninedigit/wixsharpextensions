using System;
using System.Diagnostics;
using System.Linq;
using WixSharp;
using WixSharp.CommonTasks;

namespace NineDigit.WixSharpExtensions.Localization
{
    public static class ProjectExtensions
    {
        /// <summary>
        /// Produces multilanguage MSI with embedded transformations based on <paramref name="localizations"/> collection.
        /// If this msi is executed on the OS, which language matches one of the embedded transformations,
        /// this transformation will be automatically triggered and effectively switch the setup UI language.
        /// </summary>
        /// <param name="project">Wix# project.</param>
        /// <param name="defaultLocalization">Use your OS language as default localization. This will ensure that the all transformations are embedded in such a way that the produced msi can switch to any alternative language both automatically and manually.</param>
        /// <param name="localizations">Collection of localizations. At least one localization is expected.</param>
        /// <returns>Path to output MSI file.</returns>
        public static string BuildMultilanguageMsi(this Project project, ProjectLocalization defaultLocalization, params ProjectLocalization[] localizations)
        {
            if (project is null)
                throw new ArgumentNullException(nameof(project));

            if (defaultLocalization is null)
                throw new ArgumentNullException(nameof(defaultLocalization));

            if (localizations is null)
                throw new ArgumentNullException(nameof(localizations));

            if (!localizations.Any())
                throw new ArgumentException("At least one localization expected", nameof(localizations));

            var torchCmd = Compiler.WixLocation.PathCombine("torch.exe");

            defaultLocalization.BindTo(project);

            var msiFilePath = project.BuildMsi();
            var preserveTempFiles = project.PreserveTempFiles;

            foreach (var localization in localizations)
            {
                if (localization is null)
                    continue;

                localization.BindTo(project);

                var localizedMsiFilePath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(msiFilePath), localization.Language + ".msi");
                project.BuildMsi(localizedMsiFilePath);

                var localizedMstFilePath = localizedMsiFilePath.PathChangeExtension(".mst");

                Process.Start(torchCmd, $"-p -t language \"{msiFilePath}\" \"{localizedMsiFilePath}\" -out \"{localizedMstFilePath}\"")
                    .WaitForExit();

                // note: file name must be in format "{language}.msi" due to internal wixSharp implementation
                msiFilePath.EmbedTransform(localizedMstFilePath);

                if (!preserveTempFiles)
                {
                    System.IO.File.Delete(localizedMsiFilePath);
                    System.IO.File.Delete(localizedMstFilePath);
                }
            }

            var langCodeIds = $"{defaultLocalization.LanguageCodeId}," + string.Join(",", localizations.Select(i => i.LanguageCodeId));
            msiFilePath.SetPackageLanguages(langCodeIds);

            if (project.DigitalSignature != null)
            {
                // sign the MSI after embedding transforms again (as it won't contain publisher info in UAC dialog)
                var signingReturnCode = project.DigitalSignature.Apply(msiFilePath);
                if (signingReturnCode != 0)
                    throw new InvalidOperationException($"Signing the file '{msiFilePath}' failed. Return code: {signingReturnCode}");
            }

            return msiFilePath;
        }
    }
}
