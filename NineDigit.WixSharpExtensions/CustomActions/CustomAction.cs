using System;
using WixSharp;

namespace NineDigit.WixSharpExtensions
{
    /// <summary>
    /// Base class for derived custom actions
    /// which can optionaly implement some (well, at least one or more) of following interfaces:
    /// <see cref="ILoadAware"/>, <see cref="IBeforeInstallAware"/>, <see cref="IAfterInstallAware"/>, ...
    /// </summary>
    public abstract class CustomAction
    {
        /// <summary>
        /// Applies custom action to given <paramref name="project"/>.
        /// </summary>
        /// <param name="project"></param>
        public void BindTo(ManagedProject project)
        {
            if (project is null)
                throw new ArgumentNullException(nameof(project));

            if (this is ILoadAware loadAware)
                project.Load += loadAware.OnLoad;

            if (this is IBeforeInstallAware beforeInstallAware)
                project.BeforeInstall += beforeInstallAware.OnBeforeInstallFiles;

            if (this is IAfterInstallAware afterInstallAware)
                project.AfterInstall += afterInstallAware.AfterInstallFiles;
        }
    }
}
