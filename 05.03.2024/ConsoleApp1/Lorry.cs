using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //производный класс грузовик
    class Lorry : Vehicle
    {



        private int MaxCapacity;

        public int MaxCapacity1 { get { return MaxCapacity; } set { MaxCapacity = value; } }


        public Lorry() { }

        public Lorry(string name, int price, int maxS, int yearOfIssue, int maxCapacity) : base(name, price, maxS, yearOfIssue)
        {
            this.MaxCapacity = maxCapacity;
        }

        /// <summary>
        /// метод для вывода информации о транспорте (переопределенный)
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Средство передвижения: {Name}\nЦена: {Price}\nМаксимальная скорость: {MaxS}\nГод выпуска: {YearOfIssue}\nЕмкость: {MaxCapacity}");
        }

        /// <summary>
        /// Метод с помощью которого вводим информацию о грузовике
        /// </summary>
        /// <returns></returns>
        static public Lorry InPut()
        {
            Console.Write("Введите средство передвижения: ");
            string name = Console.ReadLine();
            Console.Write("Введите цену: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Введите максимальная скорость: ");
            int maxS = int.Parse(Console.ReadLine());
            Console.Write("Введите год выпуска: ");
            int yearOfIssue = int.Parse(Console.ReadLine());
            Console.Write("Максимальна емкость: ");
            int maxCapacity = int.Parse(Console.ReadLine());
            return new Lorry (name, price, maxS, yearOfIssue, maxCapacity);
        }


    }
}
