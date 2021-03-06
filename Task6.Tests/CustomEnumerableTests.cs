﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Test6.Solution;

namespace Task6.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};
            Func<int, int, int> function = (x, y) => x += y;
            CollectionAssert.AreEqual(expected, NumberGenerator<int>.Generator(1, 1, 10, function));
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            Func<int, int, int> function = (x, y) => 6 * y - 8 * x;
            CollectionAssert.AreEqual(expected, NumberGenerator<int>.Generator(1, 2, 10, function));
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };
            Func<double, double, double> function = (x, y) => y + (x / y);
            CollectionAssert.AreEqual(expected, NumberGenerator<double>.Generator(1, 2, 10, function));
        }
    }
}
