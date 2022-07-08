using System;
using System.IO;

namespace Project_Work
{
    struct Worker
    {
        #region Поля
        public int ID;
        public string Name;
        public int Age;
        public int Growth;
        public DateTime DateOfBirth;
        public string PlaceOfBirth;        
        #endregion
        #region Сотрудник
        /// <param name="Id">ID</param>
        /// <param name="Name">ФИО</param>
        /// <param name="Age">Возраст</param>
        /// <param name="Growth">Рост</param>
        /// <param name="DateOfBirth">Дата рождения</param>
        /// <param name="PlaceOfBirth">Место рождения</param>     
        public Worker(int ID, string Name, int Age,int Growth, DateTime DateOfBirth , string PlaceOfBirth)
        {
            this.ID = ID;
            this.Name = Name;
            this.Age = Age;
            this.Growth = Growth;
            this.DateOfBirth = DateOfBirth;
            this.PlaceOfBirth = PlaceOfBirth;            
        }
        #endregion
        #region Распечтка        
        public string Print()
        {
            return $"{this.ID,10} {this.Name,15} {this.Age,15} {this.Growth,15} {this.DateOfBirth,10} {this.PlaceOfBirth,10}";
        }
        #endregion
    }

}
