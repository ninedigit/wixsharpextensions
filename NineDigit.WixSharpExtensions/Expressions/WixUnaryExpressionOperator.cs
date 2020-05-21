namespace NineDigit.WixSharpExtensions.Expressions
{
    public sealed class WixUnaryExpressionOperator : WixExpressionOperator
    {
        private WixUnaryExpressionOperator(string value)
            : base(value)
        { }

        /// <summary>
        /// Prefix unary operator; inverts state of following term.
        /// </summary>
        public readonly static WixUnaryExpressionOperator Not
            = new WixUnaryExpressionOperator("NOT");
    }
}
