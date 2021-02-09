using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public class Franc
    {
        private int Amount;

        public Franc(int amount)
        {
            Amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(Amount*multiplier);
        }

        public override bool Equals(object obj)
        {
            Franc franc = (Franc)obj;
            return Amount == franc.Amount;
        }
    }
}
