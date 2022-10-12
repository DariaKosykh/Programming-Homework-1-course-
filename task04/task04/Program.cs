using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Введите значение x");
            x = int.Parse(Console.ReadLine());
            var x1 = x * Math.PI / 180; //перевод из градусов в радианы
            double y = (Math.Tan(x1) + Math.Sqrt(Math.Pow(Math.Sin(x1), 2) + 4)) /(Math.Pow((Math.Cos(x1)), 2) + 4); //расчёт по формуле(функция под номером 11)
            Console.WriteLine("Значение у " + y);
            Console.ReadKey();
            
        }

    }
}
