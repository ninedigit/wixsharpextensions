using System.Xml;

namespace NineDigit.WixSharpExtensions
{
    public class SignToolSignOptions
    {
        /// <summary>
        /// </summary>
        /// <param name="userName">SSL.com account username</param>
        /// <param name="password">SSL.com account password.</param>
        /// <param name="totpSecret">The TOTP (time-based one-time password) secret value associated with your eSigner certificate.</param>
        /// <param name="credentialId">Credential ID for signing certificate. Required only for users with more than one eSigner code signing certificate.</param>
        /// <exception cref="System.ArgumentException"></exception>
        public SignToolSignOptions(string userName, string password, string totpSecret, string? credentialId)
        {
            if (string.IsNullOrWhiteSpace(userName))
                throw new System.ArgumentException($"'{nameof(userName)}' cannot be null or whitespace.", nameof(userName));
            if (string.IsNullOrWhiteSpace(password))
                throw new System.ArgumentException($"'{nameof(password)}' cannot be null or whitespace.", nameof(password));
            if (string.IsNullOrWhiteSpace(totpSecret))
                throw new System.ArgumentException($"'{nameof(totpSecret)}' cannot be null or whitespace.", nameof(totpSecret));

            UserName = userName;
            Password = password;
            TotpSecret = totpSecret;
            CredentialId = credentialId;
        }

        /// <summary>
        /// SSL.com account username
        /// </summary>
        public string UserName { get; }
        /// <summary>
        /// SSL.com account password.
        /// </summary>
        public string Password { get; }
        /// <summary>
        /// The TOTP (time-based one-time password) secret value associated with your eSigner certificate. 
        /// </summary>
        public string TotpSecret { get; }
        /// <summary>
        /// Credential ID for signing certificate.
        /// </summary>
        public string? CredentialId { get; }

        /// <summary>
        /// Creates new instance based on parsed values from file with following XML structure:
        /// <code>
        /// <![CDATA[
        /// <Project>
        ///     <PropertyGroup>
        ///         <CodeSignToolCredentialId></CodeSignToolCredentialId>
        ///         <CodeSignToolUserName></CodeSignToolUserName>
        ///         <CodeSignToolPassword></CodeSignToolPassword>
        ///         <CodeSignToolTotpSecret></CodeSignToolTotpSecret>
        ///     </PropertyGroup>
        /// </Project>
        /// ]]>
        /// </code>
        /// </summary>
        /// <param name="filePath">Path to the file with XML content.</param>
        /// <returns></returns>
        public static SignToolSignOptions FromPropsFile(string filePath)
        {
            if (!System.IO.File.Exists(filePath))
                throw new System.InvalidOperationException($"The file '{filePath}' was not found.");

            var xmlDocument = new XmlDocument();
            xmlDocument.Load(filePath);

            var userName = xmlDocument.SelectSingleNode("//Project/PropertyGroup/CodeSignToolUserName")?.InnerText;
            var password = xmlDocument.SelectSingleNode("//Project/PropertyGroup/CodeSignToolPassword")?.InnerText;
            var totpSecret = xmlDocument.SelectSingleNode("//Project/PropertyGroup/CodeSignToolTotpSecret")?.InnerText;
            var credentialId = xmlDocument.SelectSingleNode("//Project/PropertyGroup/CodeSignToolCredentialId")?.InnerText;

            return new SignToolSignOptions(userName, password, totpSecret, credentialId);
        }
    }
}

