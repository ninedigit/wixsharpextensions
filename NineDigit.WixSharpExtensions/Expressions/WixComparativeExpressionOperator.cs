namespace NineDigit.WixSharpExtensions.Expressions
{
    public sealed class WixComparativeExpressionOperator : WixBinaryExpressionOperator
    {
        private WixComparativeExpressionOperator(string value)
            : base(value)
        { }

        /// <summary>
        /// Equal
        /// </summary>
        public readonly static WixComparativeExpressionOperator Eq
            = new WixComparativeExpressionOperator("=");
        /// <summary>
        /// Not equal
        /// </summary>
        public readonly static WixComparativeExpressionOperator Neq
            = new WixComparativeExpressionOperator("<>");
        /// <summary>
        /// Greater than
        /// </summary>
        public readonly static WixComparativeExpressionOperator Gt
            = new WixComparativeExpressionOperator(">");
        /// <summary>
        /// Greater than or equal
        /// </summary>
        public readonly static WixComparativeExpressionOperator Gte
            = new WixComparativeExpressionOperator(">=");
        /// <summary>
        /// Less than
        /// </summary>
        public readonly static WixComparativeExpressionOperator Lt
            = new WixComparativeExpressionOperator("<");
        /// <summary>
        /// Less than or equal
        /// </summary>
        public readonly static WixComparativeExpressionOperator Lte
            = new WixComparativeExpressionOperator("<=");
        /// <summary>
        /// Equal, case insensitive
        /// </summary>
        public readonly static WixComparativeExpressionOperator EqCaseInsensitive
            = new WixComparativeExpressionOperator("~=");
        /// <summary>
        /// Not equal, case insensitive
        /// </summary>
        public readonly static WixComparativeExpressionOperator NeqCaseInsensitive
            = new WixComparativeExpressionOperator("~<>");
        /// <summary>
        /// Greater than, case insensitive
        /// </summary>
        public readonly static WixComparativeExpressionOperator GtCaseInsensitive
            = new WixComparativeExpressionOperator("~>");
        /// <summary>
        /// Greater than or equal, case insensitive
        /// </summary>
        public readonly static WixComparativeExpressionOperator GteCaseInsensitive
            = new WixComparativeExpressionOperator("~>=");
        /// <summary>
        /// Less than, case insensitive
        /// </summary>
        public readonly static WixComparativeExpressionOperator LtCaseInsensitive
            = new WixComparativeExpressionOperator("~<");
        /// <summary>
        /// Less than or equal, case insensitive
        /// </summary>
        public readonly static WixComparativeExpressionOperator LteCaseInsensitive
            = new WixComparativeExpressionOperator("~<=");
    }
}
