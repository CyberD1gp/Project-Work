using System;
using System.Linq;

namespace Project_Work
{
    struct Methods
    {
        public void Read()
        {
            var workersRepository = new Rep();

            var workers = workersRepository.GetWorkers();
            foreach (var worker in workers)
            {
                Console.WriteLine(worker.ID + " " +
                        worker.Name + " " +
                        worker.Age + " " +
                        worker.Growth + " " +
                        worker.DateOfBirth + " " +
                        worker.PlaceOfBirth);
            }

        }

        public void Record()
        {
            var workersRepository = new Rep();
            Random random = new Random();           
            
            int ID = random.Next();
            Console.WriteLine("ФИО");
            string Name = Console.ReadLine();
            Console.WriteLine("Возраст");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Рост");
            int Growth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Дата рождения");
            DateTime DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Место рождения");
            string PlaceOfBirth = Console.ReadLine();

            var worker = new Worker(ID,
                Name,
                Age,
                Growth,
                DateOfBirth,
                PlaceOfBirth);
            workersRepository.Create(worker);
            workersRepository.Save();

        }

        public void SortedToDate()
        {
            var workerRepository = new Rep();
            var workers = workerRepository.GetWorkers().OrderBy(x => x.DateOfBirth);

            foreach(Worker worker in workers)
            {
                Console.WriteLine(worker.ID + " " +
                           worker.Name + " " +
                           worker.Age + " " +
                           worker.Growth + " " +
                           worker.DateOfBirth + " " +
                           worker.PlaceOfBirth);

            }
        }

        public void SortedToDateDown()
        {
            var workerRepository = new Rep();
            var workers = workerRepository.GetWorkers().OrderByDescending(x => x.DateOfBirth);

            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker.ID + " " +
                           worker.Name + " " +
                           worker.Age + " " +
                           worker.Growth + " " +
                           worker.DateOfBirth + " " +
                           worker.PlaceOfBirth);

            }



        }

        public void SortedToDateDiapason()
        {
            var WorkersRepository = new Rep();
            Console.WriteLine("Введите 1 дату");
            var FirstDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Введите 2 дату");
            var SecondDate = Convert.ToDateTime(Console.ReadLine());
            
            var workers = WorkersRepository.GetWorkers().Where(i => i.DateOfBirth == FirstDate
                                                               && i.DateOfBirth == SecondDate);
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker.ID + " " +
                           worker.Name + " " +
                           worker.Age + " " +
                           worker.Growth + " " +
                           worker.DateOfBirth + " " +
                           worker.PlaceOfBirth);

            }

        }

        public void NewRecord()
        {
            var WorkersRepository = new Rep();
            Console.WriteLine("Введите ID сотрудника");
            var newWorker = Int32.Parse(Console.ReadLine());

            var workers = WorkersRepository.GewWorkerByID(newWorker);

          


        }

    }
}
