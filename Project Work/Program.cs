using System;
using System.IO;

namespace Project_Work
{
    internal class program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();

            while (true)
            {
                
                string txt;
                Console.WriteLine("\nвведите запись(1) ," +
                    " \nчтение(2) ," +
                    " \nсортировка дат в диапозоне(3)" +
                    " \nсортировка по возрастанию дат(4)" +
                    " \nсортировка по убыванию дат(5) ");
                txt = Console.ReadLine();
                if (txt == "1")
                {
                    methods.Record();
                }
                else if (txt == "2")
                {
                    methods.Read();
                }
                else if (txt == "3")
                {
                    methods.SortedToDateDiapason();
                }
                else if (txt == "4")
                {
                    methods.SortedToDate();
                }
                else if (txt == "5")
                {
                    methods.SortedToDateDown();
                }
              




            }
        }
    }
}
