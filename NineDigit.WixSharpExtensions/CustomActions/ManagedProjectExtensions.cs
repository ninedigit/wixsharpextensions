using System;
using WixSharp;

namespace NineDigit.WixSharpExtensions
{
    public static class ManagedProjectExtensions
    {
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

            return project;
        }
    }
}
