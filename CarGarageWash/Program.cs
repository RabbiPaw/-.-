using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGarageWash
{
    class Car 
    {
        public string mark;
        public string model;
    }
    class Garage
    {
        public List<Car> cars;
    }
    class Wash
    {
        delegate void Washing();
        static void Main()
        {
            int n=1;
            int i = 0;
            Car car = new Car();
            Garage garage = new Garage();
            garage.cars = new List<Car>();
            while (n != 0)
            {
                Console.WriteLine("Введите модель машины");
                car.model = Console.ReadLine();
                Console.WriteLine("Введите марку машины");
                car.mark = Console.ReadLine();
                garage.cars.Add(car);
                i++;
                Console.Write(@"

Продолжить ввод машин?
0) нет 

Введите любую клавишу для продолжения");
                n = Convert.ToInt32(Console.ReadLine());
            }
            int z = i;
            for (i=0; i < z; i++)
            {
                Washing wash_car;
                wash_car = Washh;
                wash_car();
            }
            void Washh() => Console.WriteLine("Машина марки " + garage.cars[i].mark + " модели " + garage.cars[i].model + " помыта.");
            }
        }
}
