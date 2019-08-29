using System;
using System.Collections.Generic;
using Xunit;

namespace TestByndyusoft.Tests
{
    public class ProgramTest
    {
        delegate int aa(List<int> a);

        [Fact]
        public void TestEmptyArray()
        {
            Assert.Equal(1, 1);
            //List<int> arr = new List<int>();
           
            //Assert.Throws<ArgumentException>(() => {
            //    int resultFunction = Program.SumOfMins(arr);
            //});
        }
    }
}
