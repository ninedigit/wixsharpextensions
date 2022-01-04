using NineDigit.WixSharpExtensions.Resources;
using System;

namespace NineDigit.WixSharpExtensions.Expressions
{
    /// <summary>
    /// https://www.firegiant.com/wix/tutorial/com-expression-syntax-miscellanea/expression-syntax/
    /// </summary>
    public class WixExpression
    {
        readonly string value;

        public WixExpression(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Invalid expression value.", nameof(value));

            this.value = value;
        }

        public WixExpression(int value)
            : this(value.ToString())
        {
        }

        private string ValueWithParentheses
            => this.value.Contains(" ") ? $"({this.value})" : this.value;

        // Note: when comparing strings, quotes may be needed:
        // InstallCondition="NOT (OLBitness ~= &quot;x64&quot;)"
        // InstallCondition="OLBitness ~= &quot;x64&quot;"
        // source: https://stackoverflow.com/questions/36797522/how-to-write-the-msipackage-installcondition-based-on-a-string-comparison-in-a

        public static WixExpression Is64BitOS()
            => new WixExpression("VersionNT64");

        public static WixExpression Is32BitOS()
            => !Is64BitOS();

        public static WixExpression OsVersion(WixComparativeExpressionOperator @operator, VersionNT osVersion)
        {
            if (@operator is null)
                throw new ArgumentNullException(nameof(@operator));

            return new WixExpression($"VersionNT {@operator} {(int)osVersion}");
        }

        public static WixExpression OsType(WixComparativeExpressionOperator @operator, MsiNTProductType productType)
        {
            if (@operator is null)
                throw new ArgumentNullException(nameof(@operator));

            return new WixExpression($"MsiNTProductType {@operator} {(int)productType}");
        }

        public static WixExpression Not(WixExpression wixExpressionBuilder)
        {
            if (wixExpressionBuilder is null)
                throw new ArgumentNullException(nameof(wixExpressionBuilder));

            return new WixExpression($"{WixUnaryExpressionOperator.Not} {wixExpressionBuilder.ValueWithParentheses}");
        }

        public static WixExpression Create(WixExpression lhs, WixBinaryExpressionOperator @operator, WixExpression rhs)
        {
            if (lhs is null)
                throw new ArgumentNullException(nameof(lhs));

            if (@operator is null)
                throw new ArgumentNullException(nameof(@operator));

            if (rhs is null)
                throw new ArgumentNullException(nameof(rhs));

            return new WixExpression($"{lhs.ValueWithParentheses} {@operator} {rhs.ValueWithParentheses}");
        }

        public static WixExpression And(WixExpression left, WixExpression right)
            => Create(left, WixLogicalExpressionOperator.And, right);

        public static WixExpression Or(WixExpression left, WixExpression right)
            => Create(left, WixLogicalExpressionOperator.Or, right);

        public static WixExpression Xor(WixExpression left, WixExpression right)
            => Create(left, WixLogicalExpressionOperator.Xor, right);

        public static WixExpression operator &(WixExpression left, WixExpression right)
            => And(left, right);
        public static WixExpression BitwiseAnd(WixExpression left, WixExpression right)
            => And(left, right);

        public static WixExpression operator |(WixExpression left, WixExpression right)
            => Or(left, right);
        public static WixExpression BitwiseOr(WixExpression left, WixExpression right)
            => Or(left, right);

        public static WixExpression operator !(WixExpression expression)
            => Not(expression);
        public static WixExpression LogicalNot(WixExpression expression)
            => Not(expression);

        public WixExpression And(WixExpression other)
            => And(this, other);

        public WixExpression Or(WixExpression other)
            => Or(this, other);

        public WixExpression Xor(WixExpression other)
            => Xor(this, other);

        public static implicit operator string?(WixExpression builder)
            => builder?.value;

        public override string ToString()
            => this.value;
    }
}
