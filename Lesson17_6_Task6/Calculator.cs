using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17_6_Task6
{
    static class Calculator
    {
        public static int Add(int operand1, int operand2)
        {
            return operand1 + operand2;
        }
        public static int Sub(int operand1, int operand2)
        {
            return operand1 - operand2;
        }
        public static int Mul(int operand1, int operand2)
        {
            return operand1 * operand2;
        }
        public static void Div(int operand1, int operand2)
        {
            if (operand2 != 0)
            {
                double div = (double)operand1 / operand2;
                Console.WriteLine("{0} / {1} = {2}\n", operand1, operand2, div);
            }
            else
            {
                Console.WriteLine("You can't divide by zero");
            }
        }
    }
}
