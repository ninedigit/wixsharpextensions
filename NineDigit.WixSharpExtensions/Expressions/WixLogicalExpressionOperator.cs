namespace NineDigit.WixSharpExtensions.Expressions
{
    public sealed class WixLogicalExpressionOperator : WixBinaryExpressionOperator
    {
        private WixLogicalExpressionOperator(string value)
            : base(value)
        { }

        /// <summary>
        /// Logical AND
        /// </summary>
        public readonly static WixLogicalExpressionOperator And
            = new WixLogicalExpressionOperator("AND");

        /// <summary>
        /// Logical OR
        /// </summary>
        public readonly static WixLogicalExpressionOperator Or
            = new WixLogicalExpressionOperator("OR");

        /// <summary>
        /// Exclusive OR
        /// </summary>
        public readonly static WixLogicalExpressionOperator Xor
            = new WixLogicalExpressionOperator("XOR");
    }
}
