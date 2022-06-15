using System;
using System.IO;

namespace Project_Work
{
    struct Rep
    {
        private string path;
        private string[] titles;        
        public Worker[] workers;

        public Rep(string Path)
        {
            this.path = Path;
            this.titles = new string[6];
            this.workers = new Worker[6];
            
        }

        #region Запись
        public void Records()
        {

            using (StreamWriter zametka = new StreamWriter(this.path, append: true))
            {
                char key = 'д';

                do
                {
                    Worker worker = new Worker();
                    Random random = new Random();
                    worker.ID = random.Next().ToString();


                    Console.WriteLine("\nВведите ФИО: ");
                    worker.Name += $"{Console.ReadLine()}#";

                    Console.WriteLine("\nВведите возраст: ");
                    worker.Age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nВведите рост: ");
                    worker.Growth = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nВведите дату рождения:");
                    worker.DateOfBirth = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("\nВведите место рождения: ");
                    worker.PlaceOfBirth = $"{Console.ReadLine()}#";

                    zametka.WriteLine(worker.Print());

                    Console.Write("Продолжить н/д?");
                    key = Console.ReadKey(true).KeyChar;

                }
                while (char.ToLower(key) == 'д');

            }
        }

        #endregion
        public void Read()
        {
            using (StreamReader zametka = new StreamReader(this.path))
            {
                string line;
                Console.WriteLine($"{"ID"} {"Name"} {"Age"} {"Growth"} {"DateOfBirth"} {"PlaceOfBirth"}");


                while ((line = zametka.ReadLine()) != null)
                {
                    string[] data = line.Split('\t');
                    Console.WriteLine($"{data[0]}");
                }

            }
        }

        public void Load()
        {
            using(StreamReader lol = new StreamReader(this.path))
            {

                
                
                //с этой даты
                DateTime from = new DateTime();
                Console.WriteLine("Введите 1 дату");
                from = Convert.ToDateTime(Console.ReadLine());

                //по эту дату
                DateTime to = new DateTime();
                Console.WriteLine("Введите 2 дату");
                to = Convert.ToDateTime(Console.ReadLine());



                
                      
                            

            }
        }


    }

}
