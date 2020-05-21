using System;

namespace NineDigit.WixSharpExtensions
{
    public interface IErrorHandler
    {
        void HandleError(Exception ex);
    }
}
