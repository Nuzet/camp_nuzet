using System;
using System.IO;

namespace t9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = Reader.ReadMenu(new StreamReader("..\\..\\..\\menu.txt"));
            Console.WriteLine(menu.ToString());
            Price prices = Reader.ReadPriceKurant(new StreamReader("..\\..\\..\\price.txt"));
            Console.WriteLine(prices);
            double total = 0;
            MenuService.TryGetMenuTotalSum(menu, prices, out total);
            Console.WriteLine(total);
        }
    }
}
