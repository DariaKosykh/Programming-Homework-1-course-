using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task09._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            do
            {
            k++;
            }
            while (k*k <= n);
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
