using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public class Money : IExpression
    {
        protected string currency;

        protected int amount;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }



        public Money Times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }

        public IExpression Plus(Money added)
        {
            return new Money(amount + added.amount, currency);
        }


        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && Currency().Equals(money.Currency());
        }



        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public string Currency()
        {
            return currency;
        }

        public override string ToString()
        {
            return amount + " " + currency;
        }

    }
}
