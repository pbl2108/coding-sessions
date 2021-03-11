using System;
using Xunit;

namespace Money.Test
{
    public class MoneyTests
    {
        [Fact(DisplayName = "Checks Multiplication")]
        public void TestMultiplication()
        {
            Money five = Money.Dollar(5);
            Assert.Equal(Money.Dollar(10), five.Times(2));
            Assert.Equal(Money.Dollar(15), five.Times(3));
        }

        [Fact(DisplayName = "Checks Equality")]
        public void TestEquality()
        {
            Assert.True(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.False(Money.Dollar(5).Equals(Money.Dollar(6)));
            Assert.False(Money.Franc(5).Equals(Money.Dollar(5)));
        }

        [Fact(DisplayName = "Checks Currency")]
        public void TestCurrency()
        {
            Assert.Equal("USD", Money.Dollar(1).Currency());
            Assert.Equal("CHF", Money.Franc(1).Currency());
        }

        [Fact(DisplayName = "Checks Simple Addition")]
        public void TestSimpleAddition()
        {
            Money five = Money.Dollar(5);
            IExpression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            Assert.Equal(Money.Dollar(10), reduced);
        }
    }
}
