using System;
using System.Collections.Generic;
using TestByndyusoft;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestEmptyArray()
        {
            List<int> arr = new List<int>();
            Assert.Throws<ArgumentException>(()=> {
                int res = Program.SumOfMins(arr);
            });
        }

        [Fact]
        public void TestNullArray()
        {
            Assert.Throws<NullReferenceException>(() => {
                int res = Program.SumOfMins(null);
            });
        }

        [Fact]
        public void TestCorrectResult()
        {
            List<int> arr = new List<int> ()
            {
                0, 5, -10, 15, 75, -11, -24, 3, 21, 43
            };
            int res = Program.SumOfMins(arr);
            Assert.Equal(-35, res);
        }

        [Fact]
        public void TestCorrectResult2()
        {
            List<int> arr = new List<int>()
            {
                0, 'a', -10, 15, 75, -11, -24, 3, 21, 43
            };
            int res = Program.SumOfMins(arr);
            Assert.Equal(-35, res);
        }
    }
}
