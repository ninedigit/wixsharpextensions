using System;
using WixSharp;

namespace NineDigit.WixSharpExtensions
{
    public class ProjectNameInfo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Project name visible in installer.</param>
        /// <param name="description">Project full name or description</param>
        public ProjectNameInfo(string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Invalid project name.", nameof(name));

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Invalid project description.", nameof(description));

            this.Name = name;
            this.Description = description;
        }

        public string Name { get; }
        public string Description { get; }

        public void BindTo(Project project)
        {
            if (project is null)
                throw new ArgumentNullException(nameof(project));

            project.Name = this.Name;
            project.Description = this.Description;
        }
    }
}