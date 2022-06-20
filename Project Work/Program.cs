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
                Console.WriteLine("\nвведите Запись(1) ," +
                    " \nЧтение(2) ," +
                    " \nСортировка дат в диапозоне(3)" +
                    " \nСортировка по возрастанию дат(4)" +
                    " \nСортировка по убыванию дат(5) ");
                txt = Console.ReadLine();
                if (txt == "1")
                {
                    rep.Records();
                }
                else if (txt == "2")
                {
                    rep.Read();
                }
                else if (txt == "3")
                {
                    rep.Load();
                }
                else if (txt == "4")
                {
                    rep.SortedToUpDate();
                }
                else if(txt == "5")
                {
                    rep.SortedToDownDate();
                }
                else
                {
                    Console.WriteLine("введите Запись(z) или  Чтение(c)");
                }




            }
        }
    }
}
