using System;
namespace OOP
{
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
}
