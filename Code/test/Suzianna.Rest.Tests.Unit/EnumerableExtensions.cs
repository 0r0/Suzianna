using System.Collections;
using System.Linq;

namespace Suzianna.Rest.Tests.Unit
{
    internal static class EnumerableExtensions
    {
        public static int CountOfType<TType>(this IEnumerable enumerable)
        {
            return enumerable.OfType<TType>().Count();
        }

        public static TType FirstElementOfType<TType>(this IEnumerable enumerable)
        {
            return enumerable.OfType<TType>().FirstOrDefault();
        }
    }
}
