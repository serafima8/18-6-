using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //производный класс автомобиль
    class Car : Vehicle
    {

        /// <summary>
        /// поле мощность автомобиля
        /// </summary>
        private int power;

        public int Power { get { return power; } set { power = value; } }

        /// <summary>
        /// конструктор без параметров
        /// </summary>
        public Car()
        {
        }

        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="maxS"></param>
        /// <param name="yearOfIssue"></param>
        /// <param name="power"></param>
        public Car(string name, int price, int maxS, int yearOfIssue, int power):base(name, price, maxS, yearOfIssue)
        {
            this.Power = power;
        }


        /// <summary>
        /// метод для вывода информации о транспорте (переопределенный)
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Средство передвижения: {Name}\nЦена: {Price}\nМаксимальная скорость: {MaxS}\nГод выпуска: {YearOfIssue}\nМощность автомобиля: {Power}");
        }


        /// <summary>
        /// Метод с помощью которого вводим информацию об автомобиле
        /// </summary>
        /// <returns></returns>
        static public Car InPut()
        {
            Console.Write("Введите средство передвижения: ");
            string name = Console.ReadLine();
            Console.Write("Введите цену: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Введите максимальная скорость: ");
            int maxS = int.Parse(Console.ReadLine());
            Console.Write("Введите год выпуска: ");
            int yearOfIssue = int.Parse(Console.ReadLine());
            Console.Write("Введите мощность автомобиля: ");
            int power = int.Parse(Console.ReadLine());
            return new Car(name, price, maxS, yearOfIssue, power);


        }
    }
}
