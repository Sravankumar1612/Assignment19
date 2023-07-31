using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment19
{
    internal class ArthematicCalc
    {
        public void Add(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine("After Addition of {0} and {1}\nResult: {2}\t ", num1, num2, result);
        }
        public void Diff(double num1, double num2)
        {
            double result = num1 - num2;
            Console.WriteLine("After Subtraction of {0} and {1}\nResult: {2}\t ", num1, num2, result);
        }
        public void Div(double num1, double num2)
        {
            double result = num1 / num2;
            Console.WriteLine("After Division of {0} and {1}\nResult: {2}\t ", num1, num2, result);
        }
        public void Multi(double num1, double num2)
        {
            double result = num1 * num2;
            Console.WriteLine("After Multiplication of {0} and {1}\nResult: {2}\t " ,num1,num2, result);
        }
    }
}
