using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_ReverseNotification
{
    internal abstract class BinaryExpression : Expression
    {
        protected readonly Expression firstExpression, secondExpression;
        protected BinaryExpression(Expression first, Expression second)
        {
            firstExpression = first;
            secondExpression = second;
        }
    }
}
