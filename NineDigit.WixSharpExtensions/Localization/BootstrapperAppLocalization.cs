using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using WixSharp.Bootstrapper;

namespace NineDigit.WixSharpExtensions.Localization
{
    /// <summary>
    /// Represents set of bootstrapper application localization information.
    /// </summary>
    public sealed class BootstrapperAppLocalization
    {
        /// <summary>
        /// </summary>
        /// <param name="language">Culture info name. Example: "en-US"</param>
        /// <param name="themeWxlFilePath">Path to localized file of UI messages, such as: "{WiX Toolset install location}\SDK\themes\HyperlinkTheme.wxl"</param>
        /// <param name="licenceRtfFilePath">Optional path to licence in RTF format.</param>
        public BootstrapperAppLocalization(string language, string themeWxlFilePath, string? licenceRtfFilePath = null)
            : this(CultureInfo.GetCultureInfo(language), themeWxlFilePath, licenceRtfFilePath)
        { }

        /// <summary>
        /// </summary>
        /// <param name="cultureInfo"></param>
        /// <param name="themeWxlFilePath">Path to localized file of UI messages, such as: "{WiX Toolset install location}\SDK\themes\HyperlinkTheme.wxl"</param>
        /// <param name="licenceRtfFilePath">Optional path to licence in RTF format.</param>
        public BootstrapperAppLocalization(CultureInfo cultureInfo, string themeWxlFilePath, string? licenceRtfFilePath = null)
            : this(GetNonNullCultureInfo(cultureInfo).LCID, themeWxlFilePath, licenceRtfFilePath)
        { }

        /// <summary>
        /// </summary>
        /// <param name="languageCodeId">Language code identifier (LCID). Language codes: https://www.science.co.il/language/Locale-codes.php </param>
        /// <param name="themeWxlFilePath">Path to localized file of UI messages, such as: "{WiX Toolset install location}\SDK\themes\HyperlinkTheme.wxl"</param>
        /// <param name="licenceRtfFilePath">Optional path to licence in RTF format.</param>
        public BootstrapperAppLocalization(int languageCodeId, string themeWxlFilePath, string? licenceRtfFilePath = null)
        {
            this.LanguageCodeId = languageCodeId;

            if (string.IsNullOrWhiteSpace(themeWxlFilePath))
                throw new ArgumentException("Invalid theme wxl file path.", nameof(themeWxlFilePath));

            this.ThemeWxlFilePath = themeWxlFilePath;
            this.LicenceRtfFilePath = licenceRtfFilePath;
        }

        public int LanguageCodeId { get; }
        public string ThemeWxlFilePath { get; }
        public string? LicenceRtfFilePath { get; }

        internal void BindTo(WixStandardBootstrapperApplication app)
        {
            if (app is null)
                throw new ArgumentNullException(nameof(app));

            var payloadsToAdd = new List<Payload>
            {
                new Payload(this.ThemeWxlFilePath)
                {
                    Compressed = true,
                    Name = $@"{this.LanguageCodeId}\thm.wxl"
                }
            };

            if (!string.IsNullOrWhiteSpace(this.LicenceRtfFilePath))
            {
                payloadsToAdd.Add(new Payload(this.LicenceRtfFilePath)
                {
                    Compressed = true,
                    Name = $@"{this.LanguageCodeId}\license.rtf"
                });
            }

            app.Payloads = app.Payloads.Union(payloadsToAdd).ToArray();
        }

        private static CultureInfo GetNonNullCultureInfo(CultureInfo cultureInfo)
        {
            if (cultureInfo is null)
                throw new ArgumentNullException(nameof(cultureInfo));

            return cultureInfo;
        }
    }
}
