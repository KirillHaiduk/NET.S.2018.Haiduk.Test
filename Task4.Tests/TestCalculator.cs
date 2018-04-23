using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Task4.Solution;

namespace Task4.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMeanWithInterface()
        {
            var calculator = new MeanCalculator();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedianWithInterface()
        {
            var calculator = new MedianCalculator();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMeanWithDelegate()
        {
            Func<IEnumerable<double>, double> average = values => values.Sum() / values.Count();

            double expected = 8.3636363;

            double actual = CalculatorVar2.Calculate(values, average);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedianWithDelegate()
        {
            var median = new MedianCalculator();
            Func<IEnumerable<double>, double> average = median.CalculateAverage;

            double expected = 8.0;

            double actual = CalculatorVar2.Calculate(values, average);

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}