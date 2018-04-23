using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6.Solution
{
    public static class NumberGenerator<T>
    {
        public static IEnumerable<T> Generator(T x1, T x2, int number, Func<T, T, T> function)
        {
            if (number <= 0)
            {
                throw new ArgumentException(nameof(number));
            }

            if (function == null)
            {
                throw new ArgumentNullException(nameof(function));
            }

            return GeneratorHelper<T>(x1, x2, number, function);
        }

        private static IEnumerable<T> GeneratorHelper<T>(T x1, T x2, int number, Func<T, T, T> function)
        {
            T first = x1;
            T next = x2;
            for (int i = 0; i < number; i++)
            {
                T temp = next;
                next = function(first, next);
                first = temp;
                yield return next;
            }
        }
    }
}
