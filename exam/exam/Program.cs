using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите чётное натуральное число, которое болшьше или равно 4");
            int n = int.Parse(Console.ReadLine());
            if (NumberСheck(n))
            {
                for (int a = 2; a < n; a++)
                {
                    if (CheckSimpleNumber(a))
                    {
                        for (int b = 2; b < n; b++)
                        {
                            if (CheckSimpleNumber(b))
                            {
                                if (a + b == n)
                                {
                                    Console.WriteLine($"{a} + {b} = {n}");
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
            
        static bool CheckSimpleNumber(int n)
        {
            if (n == 1) return false;
            for ( int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
        static bool NumberСheck(int n)
        { 
            if ((n % 2 == 0) & (n >= 4))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Число задано не верно. Попробуйте снова.");
                return false;
            }
        }
    } 
}
