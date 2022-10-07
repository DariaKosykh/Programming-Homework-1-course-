using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите значение стороны a");
            a = int.Parse(Console.ReadLine());
            int b;
            Console.WriteLine("Введите значение стороны b");
            b = int.Parse(Console.ReadLine());
            int gradus;
            Console.WriteLine("Введите значение угла между ними (в градусах)");
            gradus = int.Parse(Console.ReadLine());
            double radian = gradus * Math.PI / 180;
            double S = (a * b * Math.Sin(radian)) / 2;
            Console.WriteLine("Площадь равна "  + S);
            double P =  Math.Sqrt(a * a + b * b - 2 * b * a * Math.Cos(radian)) + a + b;
            Console.WriteLine("Периметр равен " + P);
            Console.ReadKey(); 
        }
    }
}
