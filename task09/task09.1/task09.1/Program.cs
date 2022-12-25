using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task09._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введение значение x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение n");
            int n = int.Parse(Console.ReadLine());
            double Sum = 0;
            int stepen = 1;
            while(stepen<=2*n+1)
            {
                Sum = Sum + Math.Pow(x, stepen)/stepen;
                stepen = stepen + 2;
            }
            Console.WriteLine("Сумма = " + Sum);
            Console.ReadKey();
        } 
    }
}
