using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите четырехзначное число");
            a = int.Parse(Console.ReadLine());
            int a1 = a / 10;
            Console.WriteLine("Число десятков " + a1);
            int a2 = a / 100;
            Console.WriteLine("Число сотен " + a2);
            int s = 0;
            while (a > 0)
            {
                s = s + a % 10;
                a = a / 10;
            }
            Console.WriteLine("Cумма цифр четырёхзначного числа " + s);
            Console.ReadKey();

        }
    }
}
