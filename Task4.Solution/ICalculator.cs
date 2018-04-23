using System.Collections.Generic;

namespace Task4.Solution
{
    public interface ICalculator
    {
        double CalculateAverage(IEnumerable<double> values);        
    }
}
