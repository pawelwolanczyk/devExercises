using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator_ReverseNotification
{
    public class Operation
    {
        public double? Operations(double n1, double n2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return n1 + n2;
                case '-':
                    return n2 - n1;
                case '*':
                    return n1 * n2;
                case '/':
                    return n2 / n1;
                default:
                    return null;
            }
        }
    }
}
