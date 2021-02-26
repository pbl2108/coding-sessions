using System;

namespace Money
{
    public interface IExpression
    {
        Money Reduce(string to);
    }
}
