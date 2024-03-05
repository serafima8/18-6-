using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //производный класс велосипед
    class Bicycle : Vehicle
    {
        /// <summary>
        /// поле кол-ва пассажиров
        /// </summary>
        private int passengers;
        /// <summary>
        /// свойства 
        /// </summary>
        public int Passengers { get { return passengers; } set { passengers = value; } }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Bicycle() { }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="maxS"></param>
        /// <param name="yearOfIssue"></param>
        /// <param name="pessengers"></param>
        public Bicycle(string name, int price, int maxS, int yearOfIssue, int pessengers) : base(name, price, maxS, yearOfIssue)
        {
            this.Passengers = passengers;
        }



        /// <summary>
        /// метод для вывода информации о транспорте (переопределенный)
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Средство передвижения: {Name}\nЦена: {Price}\nМаксимальная скорость: {MaxS}\nГод выпуска: {YearOfIssue}\nКол-во пассажиров: {passengers}");
        }


        /// <summary>
        /// Метод с помощью которого вводим информацию об велосипеде
        /// </summary>
        /// <returns></returns>
        static public Bicycle InPut()
        {
            Console.Write("Введите средство передвижения: ");
            string name = Console.ReadLine();
            Console.Write("Введите цену: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Введите максимальная скорость: ");
            int maxS = int.Parse(Console.ReadLine());
            Console.Write("Введите год выпуска: ");
            int yearOfIssue = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во пассажиров: ");
            int pasengers = int.Parse(Console.ReadLine());
            return new Bicycle(name, price, maxS, yearOfIssue, pasengers);
        }






    }
}
