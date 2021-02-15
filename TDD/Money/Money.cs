using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public abstract class Money
    {
        protected string currency;

        protected int amount;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }



        public abstract Money Times(int multiplier);


        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && GetType().Equals(money.GetType());
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

    }
}
