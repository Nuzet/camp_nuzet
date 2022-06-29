using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Input
    {
        public static string  InputTranslation(string word)
        {
            Console.Write($"Введiть замiну для слова {word}: ");
            string value = Console.ReadLine();
            return value;
        }
    }
}
