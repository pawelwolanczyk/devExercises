using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_ReverseNotification.Expressions
{
    public abstract class Expression
    {
        public virtual Expression Plus(Expression exper)
        {
            throw new NotImplementedException();
        }

        public virtual Expression Minus(Expression exper)
        {
            throw new NotImplementedException();
        }

        public virtual Expression Multiply(Expression exper)
        {
            throw new NotImplementedException();
        }

        public virtual Expression Divide(Expression exper)
        {
            throw new NotImplementedException();
        }

        public abstract double Calculate(double? point = null);

        public abstract override string ToString();
    }
}
