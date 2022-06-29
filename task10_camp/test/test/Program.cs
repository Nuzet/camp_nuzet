using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary;
            try
            {
                Translator translator = new Translator();
                dictionary = Service.ReadDictionary("../../../Dictionary.txt");
                translator.AddDictionary(dictionary);
                Service.TranslateByLine("../../../Text.txt", translator);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}