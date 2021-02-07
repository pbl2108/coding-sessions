using System;
using Xunit;

namespace TheMoneyExample.Test
{
    public class UnitTest1
    {
        [Fact(DisplayName = "Checks a equals 10")]
        public void Test1()
        {
            var a = 10;
            Assert.Equal(10, a);
        }
    }
}
