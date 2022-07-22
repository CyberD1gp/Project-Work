using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Globalization;

namespace Project_Work
{
    class Rep
    {
        public List<Worker> _workers { get; set; }

        public Rep()
        {
            _workers = new List<Worker>();
            _workers = GetWorkersFromTxt();

        }

        public List<Worker> GetWorkers()
        {
            return _workers;
        }

        public void Create(Worker worker)
        {
            _workers.Add(worker);
        }

        public void Update(Worker worker)
        {
            var oldWorker = _workers
                .FirstOrDefault(i => i.ID == worker.ID);
            _workers.Remove(oldWorker);
            _workers.Add(worker);
        }

        public void Delete(Worker worker)
        {
            var oldWorker = _workers
                .FirstOrDefault(i => i.ID == worker.ID);
            _workers.Remove(oldWorker);

        }

        public List<Worker> GetWorkersFromTxt()
        {
            var workers = new List<Worker>();

            File.Exists("Book.txt");
            string[] workersTxt = File.ReadAllLines("Book.txt");


            foreach (string workersTxtString in workersTxt)
            {
                var worker = GetWorkersFromTxtString(workersTxtString);
                workers.Add(worker);
            }
            return workers;
            
        }

        public Worker GetWorkersFromTxtString(string workersTxtStrings)
        {
            string[] massive = workersTxtStrings.Split('#');
            int ID = Convert.ToInt32(massive[0]);
            string Name = massive[1];
            int Age = Convert.ToInt32(massive[2]);
            int Growth = Convert.ToInt32(massive[3]);
            DateTime DateOfBirth = Convert.ToDateTime(massive[4]);
            string PlaceOfBirth = massive[5];

            var worker = new Worker(ID, Name, Age, Growth, DateOfBirth, PlaceOfBirth);
            return worker;
        }

        public void Save()
        {
            using (StreamWriter vs = new StreamWriter("Book.txt", false))
            {
                foreach (Worker worker in _workers)
                    vs.WriteLine(worker.ID + "#" +
                        worker.Name + "#" +
                        worker.Age + "#" +
                        worker.Growth + "#" +
                        worker.DateOfBirth + "#" +
                        worker.PlaceOfBirth);

            }

        }

        public Worker GewWorkerByID(int ID)
        {
            return _workers.FirstOrDefault(i => i.ID == ID);
        }

    }
}
