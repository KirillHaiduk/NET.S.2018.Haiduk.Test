﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Solution
{
    public interface ICalculator
    {
        double CalculateAverage(IEnumerable<double> values);
    }
}