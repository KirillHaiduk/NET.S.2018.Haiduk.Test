using System;
using System.Collections.Generic;

namespace Task4.Solution
{
    public static class CalculatorVar2
    {
        public static double Calculate(IEnumerable<double> values, Func<IEnumerable<double>, double> average)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (average == null)
            {
                throw new ArgumentNullException(nameof(average));
            }

            return average(values);
        }
    }
}
