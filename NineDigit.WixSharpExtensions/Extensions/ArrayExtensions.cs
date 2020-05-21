using System.Linq;

namespace NineDigit.WixSharpExtensions
{
    public static class ArrayExtensions
    {
        public static T[] JoinWith<T>(this T[] left, T[] right)
        {
            if (left is null && right is null)
                return null;
            else if (left is null)
                return right.ToArray();
            else if (right is null)
                return left.ToArray();

            var result = new T[left.Length + right.Length];
            
            left.CopyTo(result, 0);
            right.CopyTo(result, left.Length);
            
            return result;
        }
    }
}
