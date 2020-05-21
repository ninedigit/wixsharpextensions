namespace NineDigit.WixSharpExtensions.Expressions
{
    /// <summary>
    /// Base class for binary expression operators.
    /// </summary>
    public abstract class WixBinaryExpressionOperator : WixExpressionOperator
    {
        protected WixBinaryExpressionOperator(string value)
            : base(value)
        { }
    }
}
