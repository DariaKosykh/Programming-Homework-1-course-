using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task07._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого короля");
            var whitekingposition = Console.ReadLine();
            if (!checkposition(whitekingposition))
            {
                Console.WriteLine("Позиция белой фигуры неккоректна");
                return;
            }
            Console.WriteLine("Введите позицию черного слона");
            var blackslonposition = Console.ReadLine();
            if (!checkpositionslon(blackslonposition) || (whitekingposition == blackslonposition))
            {
                Console.WriteLine("Позиция черной фигуры неккоректна");
                return;
            }
            if (whitekinguderstrike(whitekingposition, blackslonposition))
            {
                Console.WriteLine("Белый король под ударом");
            }
            if (blackslonunderstrike(blackslonposition, whitekingposition))
            {
                Console.WriteLine("Черный слон под ударом");
            }
            Console.WriteLine("Введите ход белого короля");
            var whitekingmove = Console.ReadLine();
            if ((!correctwhitekingmove(whitekingposition, whitekingmove)))
            {
                Console.WriteLine("Ход короля неверный.");
            }
            else if (whitekinguderstrike(whitekingmove, blackslonposition))
            {
                Console.WriteLine("Король под ударом.");
            }
            else
            {
                Console.WriteLine("Ход короля верный.");
                if (whitekingmove == blackslonposition)
                {
                    Console.WriteLine("Черный слон срубленкон.");
                }
            }
        }
        static void decodeposition(string position, out int row, out int colomn)
        {
            row = int.Parse(position[1].ToString());
            colomn = (int)position[0] - 0x60;
        }
        static bool checkposition(string position)
        {
            int r, c;
            decodeposition(position, out r, out c);
            return r >= 1 & r <= 8 & c >= 1 & c <= 8;
        }
        static bool checkpositionslon(string position)
        {
            int r, c;
            decodeposition(position, out r, out c);
            return (r % 2 == 1 & c % 2 == 1) || (r % 2 == 0 & c % 2 == 0);
        }
        static bool whitekinguderstrike(string whitekingosition, string blackslonposition)
        {
            int wkr, wkc, bsr, bsc;
            decodeposition(whitekingosition, out wkr, out wkc);
            decodeposition(blackslonposition, out bsr, out bsc);
            return (Math.Abs(wkr - bsr) == Math.Abs(wkc - bsc)) & (wkr != bsr & wkc != bsc);
        }

        static bool blackslonunderstrike(string blackslonzposition, string whitekingposition)
        {
            int bsr, bsc, wkr, wkc;
            decodeposition(blackslonzposition, out bsr, out bsc);
            decodeposition(whitekingposition, out wkr, out wkc);
            return (wkr == bsr & Math.Abs(wkc - bsc) == 1) || (wkc == bsc & Math.Abs(wkr - bsr) == 1) || (Math.Abs(wkr - bsr) == 1 & Math.Abs(wkc - bsc) == 1);
        }
        static bool correctwhitekingmove(string kingstart, string kingend)
        {
            int wkrs, wkcs, wkre, wkce;
            decodeposition(kingstart, out wkrs, out wkcs);
            decodeposition(kingend, out wkre, out wkce);
            return (Math.Abs(wkrs - wkre) == 1) || (Math.Abs(wkrs - wkre) == 1 & Math.Abs(wkcs - wkce) == 1);
        }
    }
}
