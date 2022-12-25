using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("F(x) = " + FunctionEvaluation(x));
            Console.ReadKey();
        }
    
        static double FunctionEvaluation(double x)
        {
            if ((Math.Abs(x)) < (Math.PI / 4))
            { 
                return Math.Atan(x);
            }
            else if (x >= (Math.PI / 4))
            {
               return 1;
            }
            else
            {
                return -1;
            }

        } 

}
    }
