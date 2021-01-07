using System;
using System.Globalization;
using WixSharp;

namespace NineDigit.WixSharpExtensions.Localization
{
    /// <summary>
    /// Represents set of project localization information.
    /// Language codes: https://www.science.co.il/language/Locale-codes.php
    /// </summary>
    public sealed class ProjectLocalization
    {
        /// <summary>
        /// </summary>
        /// <param name="language">Culture info name. Example: "en-US"</param>
        /// <param name="localizationFile">Optional path to the localization file</param>
        /// <param name="downgradeErrorMessage">
        /// Optional downgrade error message
        /// that is displayed if users try to install a product with a lower version 
        /// number when a product with a higher version is installed.
        /// Used only when WixSharp.Project.MajorUpgrade.AllowDowngrades is set to <c>false</c> (the default).
        /// </param>
        /// <param name="nameInfo">Specify project name and description, if should be different in this localization.</param>
        /// <param name="controlPanelInfo">Specify information visible in add/remove programs menu, if they should be localized.</param>
        public ProjectLocalization(
            string language,
            string localizationFile = null,
            string downgradeErrorMessage = null,
            ProjectNameInfo nameInfo = null,
            ProjectControlPanelInfo controlPanelInfo = null)
            : this(CultureInfo.GetCultureInfo(language), localizationFile, downgradeErrorMessage, nameInfo, controlPanelInfo)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="cultureInfo">Culture info</param>
        /// <param name="localizationFile">Optional path to the localization file</param>
        /// <param name="downgradeErrorMessage">
        /// Optional downgrade error message
        /// that is displayed if users try to install a product with a lower version 
        /// number when a product with a higher version is installed.
        /// Used only when WixSharp.Project.MajorUpgrade.AllowDowngrades is set to <c>false</c> (the default).
        /// </param>
        /// <param name="nameInfo">Specify project name and description, if should be different in this localization.</param>
        /// <param name="controlPanelInfo">Specify information visible in add/remove programs menu, if they should be localized.</param>
        public ProjectLocalization(
            CultureInfo cultureInfo,
            string localizationFile = null,
            string downgradeErrorMessage = null,
            ProjectNameInfo nameInfo = null,
            ProjectControlPanelInfo controlPanelInfo = null)
            : this(GetNonNullCultureInfo(cultureInfo).Name, GetNonNullCultureInfo(cultureInfo).TextInfo.ANSICodePage.ToString(CultureInfo.InvariantCulture), GetNonNullCultureInfo(cultureInfo).LCID, localizationFile, downgradeErrorMessage, nameInfo, controlPanelInfo)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="language">Culture info name. Example: "en-US"</param>
        /// <param name="codePage">The ANSI code page identifier. Example: "1252" for en-US.</param>
        /// <param name="localizationFile">Optional path to the localization file</param>
        /// <param name="downgradeErrorMessage">
        /// Optional downgrade error message
        /// that is displayed if users try to install a product with a lower version 
        /// number when a product with a higher version is installed.
        /// Used only when WixSharp.Project.MajorUpgrade.AllowDowngrades is set to <c>false</c> (the default).
        /// </param>
        /// <param name="nameInfo">Specify project name and description, if should be different in this localization.</param>
        /// <param name="controlPanelInfo">Specify information visible in add/remove programs menu, if they should be localized.</param>
        public ProjectLocalization(
            string language,
            string codePage,
            string localizationFile = null,
            string downgradeErrorMessage = null,
            ProjectNameInfo nameInfo = null,
            ProjectControlPanelInfo controlPanelInfo = null)
            : this(language, codePage, new CultureInfo(language).LCID, localizationFile, downgradeErrorMessage, nameInfo, controlPanelInfo)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="language">Culture info name. Example: "en-US"</param>
        /// <param name="codePage">The ANSI code page identifier. Example: "1252" for en-US.</param>
        /// <param name="lcid">Language code Id</param>
        /// <param name="localizationFile">Optional path to the localization file</param>
        /// <param name="downgradeErrorMessage">
        /// Optional downgrade error message
        /// that is displayed if users try to install a product with a lower version 
        /// number when a product with a higher version is installed.
        /// Used only when WixSharp.Project.MajorUpgrade.AllowDowngrades is set to <c>false</c> (the default).
        /// </param>
        /// <param name="nameInfo">Specify project name and description, if should be different in this localization.</param>
        /// <param name="controlPanelInfo">Specify information visible in add/remove programs menu, if they should be localized.</param>
        private ProjectLocalization(
            string language,
            string codePage,
            int lcid,
            string localizationFile = null,
            string downgradeErrorMessage = null,
            ProjectNameInfo nameInfo = null,
            ProjectControlPanelInfo controlPanelInfo = null)
        {
            if (string.IsNullOrWhiteSpace(language))
                throw new ArgumentException("Invalid localization language.", nameof(language));

            if (string.IsNullOrWhiteSpace(codePage))
                throw new ArgumentException("Invalid localization code page", nameof(codePage));

            this.Language = language;
            this.CodePage = codePage;
            this.LocalizationFile = localizationFile;
            this.LanguageCodeId = lcid;
            this.DowngradeErrorMessage = downgradeErrorMessage;
            this.NameInfo = nameInfo;
            this.ControlPanelInfo = controlPanelInfo;
        }

        public string Language { get; }
        public string CodePage { get; }
        public string LocalizationFile { get; }
        public int LanguageCodeId { get; }
        public string DowngradeErrorMessage { get; }
        public ProjectControlPanelInfo ControlPanelInfo { get; }
        public ProjectNameInfo NameInfo { get; }

        internal void BindTo(Project project)
        {
            if (project is null)
                throw new ArgumentNullException(nameof(project));

            project.Language = this.Language;
            project.Codepage = this.CodePage;
            project.LocalizationFile = this.LocalizationFile ?? "";

            if (!string.IsNullOrWhiteSpace(this.DowngradeErrorMessage))
            {
                if (project.MajorUpgrade is null)
                    project.MajorUpgrade = new MajorUpgrade();

                project.MajorUpgrade.DowngradeErrorMessage = this.DowngradeErrorMessage;
            }

            this.NameInfo?.BindTo(project);
            this.ControlPanelInfo?.BindTo(project);
        }

        private static CultureInfo GetNonNullCultureInfo(CultureInfo cultureInfo)
        {
            if (cultureInfo is null)
                throw new ArgumentNullException(nameof(cultureInfo));

            return cultureInfo;
        }
    }
}
