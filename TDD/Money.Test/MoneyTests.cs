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

        [Fact(DisplayName = "Checks Plus Returns Sum")]
        public void TestPlusReturnsSum()
        {
            Money five = Money.Dollar(5);
            IExpression result = five.Plus(five);
            Sum sum = (Sum)result;
            Assert.Equal(five, sum.augend);
            Assert.Equal(five, sum.addend);
        }

        [Fact(DisplayName = "Checks Reduce Sum")]
        public void TestReduceSum()
        {
            IExpression sum = new Sum(Money.Dollar(3), Money.Dollar(4));
            Bank bank = new Bank();
            Money result = bank.Reduce(sum, "USD");
            Assert.Equal(Money.Dollar(7), result);
        }

        [Fact(DisplayName = "Checks Reduce Money")]
        public void TestReduceMoney()
        {
            Bank bank = new Bank();
            Money result = bank.Reduce(Money.Dollar(1), "USD");
            Assert.Equal(Money.Dollar(1), result);
        }

        [Fact(DisplayName = "Checks Identity Rate")]
        public void TestIdentityRate()
        {
            Assert.Equal(1, new Bank().Rate("USD", "USD"));
        }

        [Fact(DisplayName = "Checks Reduce Money Different Currency")]
        public void TestReduceMoneyDifferentCurrency()
        {
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(Money.Franc(2), "USD");
            Assert.Equal(Money.Dollar(1), result);
        }

        [Fact(DisplayName = "Checks Mixed Addition")]
        public void TestMixedAddition()
        {
            IExpression fiveBucks = Money.Dollar(5);
            IExpression tenFranks = Money.Franc(10);

            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);

            Money result = bank.Reduce(fiveBucks.Plus(tenFranks), "USD");
            Assert.Equal(Money.Dollar(10), result);
        }

    }
}
