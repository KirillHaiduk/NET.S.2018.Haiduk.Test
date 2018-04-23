using System;
using System.Collections.Generic;

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

            return GeneratorHelper(x1, x2, number, function);
        }

        private static IEnumerable<T> GeneratorHelper(T x1, T x2, int number, Func<T, T, T> function)
        {
            yield return x1;
            yield return x2;
            T first = x1;
            T next = x2;
            for (int i = 2; i < number; i++)
            {
                T temp = next;
                next = function(first, next);
                first = temp;
                yield return next;
            }
        }
    }
}
