using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите марку автомобиля, информацию о котором вы хотели бы узнать:");
            List<AbstractCar> Cars = new List<AbstractCar>
            {
               new HondaCivic(),
               new RenaultLogan(),
               new LadaPriora()
            };
            string st = Console.ReadLine();
            foreach(AbstractCar car in Cars) 
            {
                if (st == car.Model())
                {
                    Console.WriteLine(car.EngineCapacity());
                    Console.WriteLine(car.BodyType());
                    Console.WriteLine(car.CarDrive());
                }
            }
            Console.ReadKey();
        }
    }

    public abstract class AbstractCar
    {
        protected string model;
        protected double HorsePover;
        protected double Watt;
        protected string Type;
        protected string Drive;
        public abstract string EngineCapacity();
        public abstract string BodyType();
        public abstract string CarDrive();
        public abstract string Model();

    }

    public class Car : AbstractCar
    {
        protected string model;
        public override string EngineCapacity()
        {
            return "Лошадиные силы=" + HorsePover + ", мощность - " + Watt + "ватт";
        }
        public override string BodyType()
        {
            return "Тип кузова - " + Type;
        }
        public override string CarDrive()
        {
            return "Привод - " + Drive;
        }
        public override string Model()
        {
            return model;
        }

    }

    public class HondaCivic : Car
    {
        public HondaCivic()
        {
            HorsePover = 142;
            Watt = 104441;
            Type = "хэтчбек";
            Drive = "передний";
            model = "Honda Civic";
        }
    }
    public class RenaultLogan : Car
    {
        public RenaultLogan()
        {
            HorsePover = 113;
            Watt = 83111.4;
            Type = "седан";
            Drive = "передний";
            model = "Renault Logan";
        }
    }
    public class LadaPriora : Car
    {
        public LadaPriora()
        {
            HorsePover = 106;
            Watt = 77962.9;
            Type = "купе";
            Drive = "передний";
            model = "Lada Priora";
        }
    }
}
