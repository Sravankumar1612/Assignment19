using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment19
{
    
    internal class Program
    {
        public delegate void ArthematicOperator(double num1, double num2);
        static void Main(string[] args)
        {
            ArthematicCalc Arthobj = new ArthematicCalc();
            begin:
            Console.WriteLine("Enter Your Choice");
            Console.WriteLine("1.ADDITION\n2.SUBTRACTION\n3.MULTIPLICATION\n4.DIVISION");
            int ch=int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    {
                        ArthematicOperator obj=new ArthematicOperator(Arthobj.Add);
                        obj(25, 30);
                        break;
                    }
                case 2:
                    {
                        ArthematicOperator obj = new ArthematicOperator(Arthobj.Diff);
                        obj(35, 30);
                        break;
                    }
                case 3:
                    {
                        ArthematicOperator obj = new ArthematicOperator(Arthobj.Multi);
                        obj(3, 3);
                        break;
                    }
                case 4:
                    {
                        ArthematicOperator obj = new ArthematicOperator(Arthobj.Div);
                        obj(35, 5);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Option");
                        break;
                    }
            }
            Console.WriteLine("If you want to continue press 1");
            string opt=Console.ReadLine();
            if(opt=="1")
            {
                goto begin;
            }
            else
            {
                Console.WriteLine("End ");
            }
            Console.ReadKey();
        }
    }
}
