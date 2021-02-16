using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public class Money
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


        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && Currency().Equals(money.Currency());
        }



        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
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
