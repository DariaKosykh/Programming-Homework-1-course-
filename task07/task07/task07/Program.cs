using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Только одно из чисел m и n меньше двадцати");
            Console.WriteLine("Введите m");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите n");
            int j = int.Parse(Console.ReadLine());
            First(ref i, ref j);
            Console.WriteLine("Введите кординаты точки (x)");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кординаты точки (у)");
            double y = int.Parse(Console.ReadLine());
            PointBelongs(ref x, ref y);
            Console.ReadKey();
        }

        private static void First(ref int m, ref int n)
        {
            if ((m < 20) ^ (n < 20))
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }
        }

        private static void PointBelongs(ref double x, ref double y)
        {
            if ((x <= -2.0) & (y >= 1.0))
            {
                Console.WriteLine("Точка принадлежит области");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит области");
            }

        }

    }

}
       
