using System;

namespace Money
{
    public interface IExpression
    {
        Money Reduce(Bank bank, string to);
    }
}
