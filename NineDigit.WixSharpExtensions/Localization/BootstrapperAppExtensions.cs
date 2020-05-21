using System;
using WixSharp.Bootstrapper;

namespace NineDigit.WixSharpExtensions.Localization
{
    public static class BootstrapperAppExtensions
    {
        /// <summary>
        /// Adds localization to bootstrapper application.
        /// If bootstrapper application is executed on the OS, which language matches one of the embedded localizations,
        /// this localizations will be automatically triggered and effectively switch the setup UI language.
        /// </summary>
        /// <remarks>
        /// http://windows-installer-xml-wix-toolset.687559.n2.nabble.com/My-experiences-making-a-multi-language-bundle-td7208949.html#a7582382
        /// https://www.codewise-llc.com/blog/2014/8/3/getting-started-with-customizing-wix-bootstrapper-ui
        /// </remarks>
        /// <param name="app"></param>
        /// <param name="localization"></param>
        public static WixStandardBootstrapperApplication AddLocalization(
            this WixStandardBootstrapperApplication app, BootstrapperAppLocalization localization)
        {
            if (app is null)
                throw new ArgumentNullException(nameof(app));

            if (localization is null)
                throw new ArgumentNullException(nameof(localization));

            localization.BindTo(app);

            return app;
        }
    }
}
