using System;
using Xunit;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(4,Add(2,2));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(4, Add(2,3));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
