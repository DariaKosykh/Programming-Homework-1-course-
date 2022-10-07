using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Анна Ахматова");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("А ты думал — я тоже такая");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("А ты думал — я тоже такая,\r\nЧто можно забыть меня,\r\nИ что брошусь, моля и рыдая,\r\nПод копыта гнедого коня.\r\n\r\nИли стану просить у знахарок\r\nВ наговорной воде корешок\r\nИ пришлю тебе странный подарок —\r\nМой заветный душистый платок.\r\n\r\nБудь же проклят. Ни стоном, ни взглядом\r\nОкаянной души не коснусь,\r\nНо клянусь тебе ангельским садом,\r\nЧудотворной иконой клянусь,\r\nИ ночей наших пламенным чадом —\r\nЯ к тебе никогда не вернусь.");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
