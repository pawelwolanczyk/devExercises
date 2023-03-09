using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace Calculator_ReverseNotification
{
    internal class Division : BinaryExpression
    {
        public Division(Expression first, Expression second) : base(first, second)
        {

        }

        //public override double Calculate(double? point = null)
        //{
        //    return firstExpression.Calculate(point) + secondExpression.Calculate(point);
        //}
    }
}
