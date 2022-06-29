using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t9
{
    internal class Reader
    {
        public static Menu ReadMenu(StreamReader reader)
        {
            Menu menu = new Menu();
            while (!reader.EndOfStream)
            {
                menu.AddDish(ReadDish(reader));
            }
            return menu;
        }
        public static Dish ReadDish(StreamReader reader)
        {
            string str = reader.ReadLine();
            Dish dish = new Dish(str);
            str = reader.ReadLine();
            while ((str != "") && (str != null))
            {
                try
                {
                    string[] arr = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    dish.AddIngredient(arr[0], Double.Parse(arr[1]));
                }
                catch (Exception ex)
                {
                    
                    continue;

                }
                str = reader.ReadLine();
            }
          
            return dish;
        }
        public static Price ReadPriceKurant(StreamReader reader)
        {
            Price prices = new Price();

            while (!reader.EndOfStream)
            {
                string[] arr = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                prices.AddPrice(arr[0], Int32.Parse(arr[1]));
            }
            return prices;
        }
        public static void PrintToConsole(Menu menu)
        {
            Console.WriteLine(menu);
        }
        public static void PrintToConsole(Dish dish)
        {
            Console.WriteLine(dish);
        }
    }
}
