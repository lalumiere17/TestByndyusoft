using System;
using System.Collections;
using System.Collections.Generic;
using TestByndyusoft;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestNull()
        {
            Assert.Throws<ArgumentNullException>(() => {
                double res = ArrayAnalyzer.SumOfMins(null);
            });
        }

        [Fact]
        public void TestEmptyList()
        {
            ArrayList arr = new ArrayList();
            Assert.Throws<ArgumentException>(()=> {
                double res = ArrayAnalyzer.SumOfMins(arr);
            });
        }

        [Fact]
        public void TestCorrectResult()
        {
            ArrayList arr = new ArrayList ()
            {
                -27.39, 0, 5, -10.75, 15, 75.43, -11, -24, 14.87, 3, 21, 43, -50
            };
            double res = ArrayAnalyzer.SumOfMins(arr);
            Assert.Equal(-77.39, res);
        }

        [Fact]
        public void TestALotOfElements()
        {
            Random rand = new Random();
            ArrayList arr = new ArrayList();
            for (int i = 0; i < 100000000; i++)
                arr.Add(rand.Next(0, 10000));

            arr.Add(-2);
            arr.Add(-2);

            double res = ArrayAnalyzer.SumOfMins(arr);
            Assert.Equal(-4, res);
        }

        [Fact]
        public void TestShortArray()
        {
            ArrayList arr = new ArrayList() { 5 };
            Assert.Throws<ArgumentException>(() => {
                double res = ArrayAnalyzer.SumOfMins(arr);
            });
        }

        [Fact]
        public void TestConsistChar()
        {
            ArrayList arr = new ArrayList() { 5, 5.5, 0.344, -10, 'd', -24.5 };
            Assert.Throws<ArgumentException>(() => {
                double res = ArrayAnalyzer.SumOfMins(arr);
            });
        }

        [Fact]
        public void TestConsistStr()
        {
            ArrayList arr = new ArrayList() { 5, 5.5, 0.344, -10, "i'm_str", 7, -24.5 };
            Assert.Throws<ArgumentException>(() => {
                double res = ArrayAnalyzer.SumOfMins(arr);
            });
        }

        [Fact]
        public void TestConsistBool()
        {
            ArrayList arr = new ArrayList() { 5, 5.5, 0.344, -10, 15, -24.5, true };
            Assert.Throws<ArgumentException>(() => {
                double res = ArrayAnalyzer.SumOfMins(arr);
            });
        }
        [Fact]
        public void TestConsistNull()
        {
            ArrayList arr = new ArrayList() { 5, 5.5, 0.344, -10, null, -24.5 };
            Assert.Throws<ArgumentException>(() => {
                double res = ArrayAnalyzer.SumOfMins(arr);
            });
        }
        
    }
}
