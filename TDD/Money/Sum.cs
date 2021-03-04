using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public class Sum : IExpression
    {
        public Money augend;
        public Money addend;

        public Sum()
        {
        }

        public Sum(Money augend, Money addend) : this()
        {
            this.augend = augend;
            this.addend = addend;
        }

        public Money Reduce(Bank bank, string to)
        {
            int amount = augend.amount + addend.amount;
            return new Money(amount, to);
        }
    }
}
