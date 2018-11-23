using System;
namespace OOP
{
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
}
