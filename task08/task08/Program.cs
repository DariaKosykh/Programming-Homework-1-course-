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
            double x = int.Parse(Console.ReadLine());
            FunctionEvaluation(ref x);
            Console.WriteLine("F(x) = " + FunctionEvaluation(ref x));
            Console.ReadKey();
        }
    
        static double FunctionEvaluation(ref double x)
        {
            if ((Math.Abs(x)) < (Math.PI / 4))
            { 
                return Math.Atan(x) * 180 / Math.PI;
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
