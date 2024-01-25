using System;
using WixSharp;
using WixSharp.CommonTasks;

namespace NineDigit.WixSharpExtensions
{
    public static class CodeSignToolExtensions
    {
        /// <summary>
        /// Signs file specified by its path using SingTool.
        /// </summary>
        /// <param name="fileToSign">File to sign.</param>
        /// <param name="signOptions">SignTool sign options.</param>
        /// <returns></returns>
        public static string SignWithCodeSignTool(this string fileToSign, SignToolSignOptions signOptions)
        {
            // CodeSignTool sign -input_file_path=$(ProjectDir)$(OutputPath)$(AssemblyName).exe -credential_id=$(CodeSignToolCredentialId) -username $(CodeSignToolUserName) -password &quot;$(CodeSignToolPassword)&quot; -override -totp_secret=&quot;$(CodeSignToolTotpSecret)&quot;"
            var args = $"sign -input_file_path=\"{fileToSign}\" -username \"{signOptions.UserName}\" -password \"{signOptions.Password}\" -override -totp_secret=\"{signOptions.TotpSecret}\"";
            
            if (!string.IsNullOrWhiteSpace(signOptions.CredentialId))
                args += $" -credential_id=\"{signOptions.CredentialId}\"";

            var tool = new ExternalTool
            {
                // Note: As CodeSignTool should be added to system path, we are not using wellKnownLocations here.
                
                //WellKnownLocations = wellKnownLocations ??
                //                     @"C:\Program Files (x86)\Windows Kits\10\App Certification Kit;" +
                //                     @"C:\Program Files (x86)\Windows Kits\10\bin\10.0.15063.0\x86;" +
                //                     @"C:\Program Files (x86)\Windows Kits\10\bin\x86;" +
                //                     @"C:\Program Files (x86)\Windows Kits\8.1\bin\x86;" +
                //                     @"C:\Program Files (x86)\Windows Kits\8.0\bin\x86;" +
                //                     @"C:\Program Files (x86)\Microsoft SDKs\ClickOnce\SignTool;" +
                //                     @"C:\Program Files (x86)\Microsoft SDKs\Windows\v7.1A\Bin;" +
                //                     @"C:\Program Files\Microsoft SDKs\Windows\v6.0A\bin",
                ExePath = "CodeSignTool.bat",
                Arguments = args
            };

            Console.WriteLine($"Signing '{fileToSign}' using SignTool.");

            if (signOptions.Password.IsNotEmpty() || signOptions.TotpSecret.IsNotEmpty())
                tool.ConsoleOut = (line) => Compiler.OutputWriteLine(line.Replace(signOptions.Password, "***").Replace(signOptions.TotpSecret, "***"));

            var returnCode = tool.ConsoleRun();
            if (returnCode == 0)
                Console.WriteLine($"File '{fileToSign}' successfully signed using SignTool.");
            else
                Console.WriteLine($"File '{fileToSign}' signing using SignTool failed. Return code: {returnCode}");

            return fileToSign;
        }
    }
}

