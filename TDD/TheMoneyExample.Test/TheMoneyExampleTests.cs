using System;
using Xunit;

namespace TheMoneyExample.Test
{
    public class TheMoneyExampleTests
    {
        [Fact(DisplayName = "Checks Multiplication")]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            five.Times(2);
            Assert.Equal(10, five.Amount);
        }
    }
}
