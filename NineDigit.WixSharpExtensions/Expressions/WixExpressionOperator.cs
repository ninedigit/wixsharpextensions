using System;

namespace NineDigit.WixSharpExtensions.Expressions
{
    /// <summary>
    /// Base class for expression operators.
    /// </summary>
    public abstract class WixExpressionOperator
    {
        protected WixExpressionOperator(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Invalid operator value", nameof(value));

            this.Value = value;
        }

        public string Value { get; }

        public override string ToString() => this.Value;
    }
}
