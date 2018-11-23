using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите марку автомобиля, информацию о котором вы хотели бы узнать:");
            AbstractCar[] mass = new AbstractCar[] { new HondaCivic(), new RenaultLogan(), new LadaPriora() };
            string st = Console.ReadLine();
            for (int i = 0; i < mass.Length ; i++)
            {
               if(st == mass[i].Model())
                {
                    Console.WriteLine(mass[i].EngineCapacity());
                    Console.WriteLine(mass[i].BodyType());
                    Console.WriteLine(mass[i].CarDrive());
                }

            }
            Console.ReadKey();
        }
    }
}
