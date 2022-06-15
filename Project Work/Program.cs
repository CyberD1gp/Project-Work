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
                Console.WriteLine("\nвведите Запись(z) , Чтение(c) , Сортировка дат в диапозоне(s)");
                txt = Console.ReadLine();
                if (txt == "z")
                {
                    rep.Records();
                }
                else if (txt == "c")
                {
                    rep.Read();
                }
                else if(txt == "s")
                {
                    rep.Load();
                }
                else
                {
                    Console.WriteLine("введите Запись(z) или  Чтение(c)");
                }




            }
        }
    }
}
