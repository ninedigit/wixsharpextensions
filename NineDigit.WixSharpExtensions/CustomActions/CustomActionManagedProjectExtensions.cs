using System;
using System.Collections.Generic;
using System.Linq;
using WixSharp;

namespace NineDigit.WixSharpExtensions
{
    public static class CustomActionManagedProjectExtensions
    {
        /// <summary>
        /// Binds custom action to the <paramref name="project"/>.
        /// </summary>
        /// <typeparam name="TCustomAction"></typeparam>
        /// <param name="project"></param>
        /// <returns></returns>
        public static ManagedProject BindCustomActionIf<TCustomAction>(this ManagedProject project, bool condition)
            where TCustomAction : CustomAction, new()
            => condition ? BindCustomAction(project, new TCustomAction()) : project;

        /// <summary>
        /// Binds custom action to the <paramref name="project"/>.
        /// </summary>
        /// <typeparam name="TCustomAction"></typeparam>
        /// <param name="project"></param>
        /// <returns></returns>
        public static ManagedProject BindCustomAction<TCustomAction>(this ManagedProject project)
            where TCustomAction : CustomAction, new()
            => BindCustomAction(project, new TCustomAction());

        /// <summary>
        /// Binds <paramref name="customAction"/> to the <paramref name="project"/>.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="customAction"></param>
        /// <returns></returns>
        public static ManagedProject BindCustomAction(this ManagedProject project, CustomAction customAction)
        {
            if (project is null)
                throw new ArgumentNullException(nameof(project));

            if (customAction is null)
                throw new ArgumentNullException(nameof(customAction));

            customAction.BindTo(project);

            project.EmbedWixSharpExtensions();

            return project;
        }

        /// <summary>
        /// Packages WixSharpExtensions assembly into MSI setup. This is required when using <see cref="CustomAction"/> classes.
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public static ManagedProject EmbedWixSharpExtensions(this ManagedProject project)
        {
            if (project is null)
                throw new ArgumentNullException(nameof(project));

            var wixSharpLocation = typeof(CustomActionManagedProjectExtensions).Assembly.Location;

            return project.EmbedAssembly(wixSharpLocation);
        }

        /// <summary>
        /// Packages assembly specified by <paramref name="assemblyPath"/> into MSI setup.
        /// This is useful when external functionality is stored outside main setup project.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="assemblyPath"></param>
        /// <returns></returns>
        public static ManagedProject EmbedAssembly(this ManagedProject project, string assemblyPath)
        {
            if (project is null)
                throw new ArgumentNullException(nameof(project));

            if (string.IsNullOrWhiteSpace(assemblyPath))
                throw new ArgumentException("Invalid assembly path.", nameof(assemblyPath));

            project.DefaultRefAssemblies ??= new List<string>();

            if (!project.DefaultRefAssemblies.Any(i => i.Equals(assemblyPath, StringComparison.InvariantCultureIgnoreCase)))
                project.DefaultRefAssemblies.Add(assemblyPath);

            return project;
        }
    }
}
