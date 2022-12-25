using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task09._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3.Введите сколько лыжник пробежал в первый день (n)");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Ваедите на сколько процентов спротсмен увеличивал бег каждый день (m)");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение, которое привысит спортсмен (k)");
            double k = double.Parse(Console.ReadLine());
            int day = 0;
            double Sum = 0;
            do
            {
                day++;
                Sum = Sum + n * (1 + m / 100);
                n = n * (1 + m / 100);
            }
            while (Sum < k);
            Console.WriteLine("Сколько дней бегал спортсмен " + day);
            Console.ReadKey();
        }
    }
}
