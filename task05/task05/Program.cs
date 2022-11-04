using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1;
             P(3, 11,out x1);
            double x2;
             P(5, 13, out x2);
            double x3;
             P(7, 17, out x3);
            double x = x1 + x2 + x3;
            Console.WriteLine(x);
            Console.ReadKey();
        }
        static void P(int a,int b, out double t)
        {
            t = (1 + Math.Pow(a, 2)) / (1 + Math.Pow(b, 2));
        }
}   }
       
       
 


