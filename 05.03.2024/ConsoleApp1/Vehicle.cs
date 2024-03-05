using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //абстрактный класс Vehicle (транспортное средство).
    abstract class Vehicle
    {

        /// <summary>
        /// поле названия средства передвижения
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// поле цены
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// поле максимальной скорости
        /// </summary>
        public int MaxS { get; set; }

        /// <summary>
        /// поле год выпуска
        /// </summary>
        public int YearOfIssue { get; set; }



        /// <summary>
        /// конструктор без параметров 
        /// </summary>
        public Vehicle()
        { 
        }

        /// <summary>
        /// Конструктор с праметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="maxS"></param>
        /// <param name="yearOfIssue"></param>
        public Vehicle(string name, int price, int maxS, int yearOfIssue)
        {
            this.Name = name;
            this.Price = price;
            this.MaxS = maxS;
            this.YearOfIssue = yearOfIssue;
        }


        /// <summary>
        /// абстрактный метод вывода информации
        /// </summary>
        public abstract void Print();
        
           
        











}
}
