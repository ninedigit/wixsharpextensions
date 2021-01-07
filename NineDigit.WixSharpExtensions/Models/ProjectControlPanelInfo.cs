using System;
using System.IO;
using WixSharp;

namespace NineDigit.WixSharpExtensions
{
    public class ProjectControlPanelInfo
    {
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="manufacturer"></param>
        /// <param name="readme"></param>
        /// <param name="comment"></param>
        /// <param name="contact"></param>
        /// <param name="helpUrl"></param>
        /// <param name="aboutUrl"></param>
        /// <param name="productIconFilePath"></param>
        /// <param name="helpTelephone"></param>
        public ProjectControlPanelInfo(
            string name,
            string manufacturer,
            string readme,
            string comment,
            string contact,
            Uri helpUrl,
            Uri aboutUrl,
            FileInfo productIconFilePath,
            string helpTelephone)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Invalid product name.", nameof(name));

            this.Name = name;
            this.Manufacturer = manufacturer;
            this.Readme = readme;
            this.Comments = comment;
            this.Contact = contact;
            this.HelpUrl = helpUrl;
            this.AboutUrl = aboutUrl;
            this.ProductIconFilePath = productIconFilePath;
            this.HelpTelephone = helpTelephone;
        }

        public string Name { get; }
        public string Manufacturer { get; }
        public string Readme { get; }
        public string Comments { get; }
        public string Contact { get; }
        public Uri HelpUrl { get; }
        public Uri AboutUrl { get; }
        FileInfo ProductIconFilePath { get; }
        public string HelpTelephone { get; }

        public ProjectControlPanelInfo DeepClone()
        {
            return new ProjectControlPanelInfo(
                this.Name, this.Manufacturer, this.Readme, this.Comments,
                this.Contact, this.HelpUrl, this.AboutUrl, this.ProductIconFilePath, this.HelpTelephone);
        }

        public void BindTo(Project project)
        {
            if (project is null)
                throw new ArgumentNullException(nameof(project));

            if (project.ControlPanelInfo is null)
                project.ControlPanelInfo = new ProductInfo();

            this.BindTo(project.ControlPanelInfo);
        }

        public void BindTo(ProductInfo info)
        {
            if (info is null)
                throw new ArgumentNullException(nameof(info));

            // https://github.com/oleg-shilo/wixsharp/blob/master/Source/src/WixSharp.Samples/Wix%23%20Samples/ProductInfo/setup.cs

            info.Name = this.Name;
            info.Manufacturer = this.Manufacturer;
            info.Readme = this.Readme;
            info.Comments = this.Comments;
            info.Contact = this.Contact;
            info.HelpLink = this.HelpUrl?.ToString();
            info.UrlInfoAbout = this.AboutUrl?.ToString();
            info.ProductIcon = this.ProductIconFilePath?.FullName;
            info.HelpTelephone = this.HelpTelephone;
        }
    }
}