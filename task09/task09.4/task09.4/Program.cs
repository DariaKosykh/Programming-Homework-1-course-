using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task09._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10000; i > 0; i--)
            {
                int m = 1, sum = default;
                while (m != i)
                {
                    if (i % m == 0)  sum += m;
                    m++;
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
