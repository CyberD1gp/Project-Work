using System;

namespace Project_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"Zametka.txt";
            Rep rep = new Rep(path);

            while (true)
            {
                string txt;
                Console.WriteLine("\nвведите Запись(z) или  Чтение(c)");
                txt = Console.ReadLine();
                if (txt == "z")
                {
                    rep.Records();
                }
                else if (txt == "c")
                {
                    rep.Read();
                }
                else
                {
                    Console.WriteLine("введите Запись(z) или  Чтение(c)");
                }




            }
        }
    }
}
