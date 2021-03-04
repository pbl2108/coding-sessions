using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public class Bank
    {
        private class Pair
        {
            private string from;
            private string to;

            public Pair(string from, string to)
            {
                this.from = from;
                this.to = to;
            }

            public override bool Equals(object obj)
            {
                Pair pair = (Pair)obj;
                return from.Equals(pair.from) && to.Equals(pair.to);
            }

            public override int GetHashCode()
            {
                return 0;
            }
        }

        private Dictionary<Pair, int> rates = new Dictionary<Pair, int>();

        public void AddRate(string from, string to, int rate)
        {
            rates.Add(new Pair(from, to), rate);
        }

        public Money Reduce(IExpression source, string to)
        {
           return source.Reduce(this, to);
        }

        public int Rate(string from, string to)
        {
            if (from.Equals(to))
                return 1;

            int rate = rates[new Pair(from, to)];
            return rate;
        }
    }
}
