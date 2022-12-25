using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Translation());
            string word = "телега";
            string word1 = word.Remove(0, 2);
            Console.WriteLine(word1 + word[0]);
            string word2 = word.Substring(2, 2);
            Console.WriteLine(word.Substring(5) + word[0] + word2 + word[0]);
            Console.ReadKey();
        }
        static string Translation()
            {
            Console.WriteLine("Ведите слово для перевода");
            string massege = Console.ReadLine();
            massege = massege.Replace("А", "A");
            massege = massege.Replace("Б", "B");
            massege = massege.Replace("В", "V");
            massege = massege.Replace("Г", "G");
            massege = massege.Replace("Д", "D");
            massege = massege.Replace("E", "E");
            massege = massege.Replace("Ё", "E");
            massege = massege.Replace("Ж", "ZH");
            massege = massege.Replace("З", "Z");
            massege = massege.Replace("И", "I");
            massege = massege.Replace("Й", "I");
            massege = massege.Replace("K", "K");
            massege = massege.Replace("Л", "L");
            massege = massege.Replace("М", "M");
            massege = massege.Replace("Н", "N");
            massege = massege.Replace("О", "O");
            massege = massege.Replace("П", "P");
            massege = massege.Replace("Р", "R");
            massege = massege.Replace("С", "S");
            massege = massege.Replace("Т", "T");
            massege = massege.Replace("У", "U");
            massege = massege.Replace("Ф", "F");
            massege = massege.Replace("Х", "KH");
            massege = massege.Replace("Ц", "TS");
            massege = massege.Replace("Ч", "СH");
            massege = massege.Replace("Ш", "SH");
            massege = massege.Replace("Щ", "SHCH");
            massege = massege.Replace("Ъ", "IE");
            massege = massege.Replace("Ы", "Y");
            massege = massege.Replace("Ь", "");
            massege = massege.Replace("Э", "E");
            massege = massege.Replace("Ю", "IU");
            massege = massege.Replace("Я", "IA");
            massege = massege.Replace("а", "a");
            massege = massege.Replace("б", "b");
            massege = massege.Replace("в", "v");
            massege = massege.Replace("г", "g");
            massege = massege.Replace("д", "d");
            massege = massege.Replace("е", "e");
            massege = massege.Replace("ё", "e");
            massege = massege.Replace("ж", "zh");
            massege = massege.Replace("з", "z");
            massege = massege.Replace("и", "i");
            massege = massege.Replace("й", "i");
            massege = massege.Replace("к", "k");
            massege = massege.Replace("л", "l");
            massege = massege.Replace("м", "m");
            massege = massege.Replace("н", "n");
            massege = massege.Replace("о", "o");
            massege = massege.Replace("п", "p");
            massege = massege.Replace("р", "r");
            massege = massege.Replace("с", "s");
            massege = massege.Replace("т", "t");
            massege = massege.Replace("у", "u");
            massege = massege.Replace("ф", "f");
            massege = massege.Replace("х", "kh");
            massege = massege.Replace("ц", "ts");
            massege = massege.Replace("ч", "ch");
            massege = massege.Replace("ш", "sh");
            massege = massege.Replace("щ", "shch");
            massege = massege.Replace("ъ", "ie");
            massege = massege.Replace("ы", "y");
            massege = massege.Replace("ь", "");
            massege = massege.Replace("э", "e");
            massege = massege.Replace("ю", "iu");
            massege = massege.Replace("я", "ia");
            return massege;
        }
    }
}
