using System;
using Xunit;

namespace Money.Test
{
    public class MoneyTests
    {
        [Fact(DisplayName = "Checks Multiplication")]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);

            Assert.Equal(10, product.Amount);
            product = five.Times(3);
            Assert.Equal(15, product.Amount);
        }

        [Fact(DisplayName = "Checks Equality")]
        public void TestEquality()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}
