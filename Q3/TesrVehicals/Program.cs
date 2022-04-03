namespace Vehicle
{
    public class Vehicle
    {
        private string _name;
        private string _model;
        private string _year;
        private string _make;
        public string name{
            get{return this._name;}
            set{this._name = value;}
        }
        public string model{
            get{return this._model;}
            set{this._model=value;}
        }
        public string year{
            get{return this._year;}
            set{this._year=value;}
        }
        public Vehicle()
        {
        }
        public Vehicle(string make, string model, string year)
        {
            this._make = make;
            this.model = model;
            this.year = year;
        }
        public void accelerate()
        {
            Console.WriteLine("Accelerating!");
        }

        public void deAccelerate()
        {
            Console.WriteLine("Deaccelerating!");
        }

        public void drive()
        {
            Console.WriteLine("Driving!");
        }

        public void start()
        {
            Console.WriteLine("Starting!");
        }
        public void stop()
        {
            Console.WriteLine("Stop!");
        }
    }

    class Car : Vehicle
    {
    }

    class Van : Vehicle
    {
    }

    class Sportscar : Car
    {}

    class ExcursionVan : Van
    {}

    class MiniVan : Van
    {
        protected bool cargo_Net;
        protected bool dual_Sliding_Doors;
 
        public MiniVan()
        {
        }
        public MiniVan(bool cargo_Net, bool dual_Sliding_Doors)
        {
            this.cargo_Net = cargo_Net;
            this.dual_Sliding_Doors = dual_Sliding_Doors;
        }
 
        public void SetCargoNet(bool cargo_Net)
        {
            this.cargo_Net = cargo_Net;
        }
        public void SetDualSlidingDoors(bool dual_Sliding_Doors)
        {
            this.dual_Sliding_Doors = dual_Sliding_Doors;
        }
 
        public bool HasCargoNet()
        {
            return cargo_Net;
        }
        public bool HasDualSlidingDoors()
        {
            return dual_Sliding_Doors;
        }
    }
}

namespace TestVehicles
{
    class Program
    {
        static void Main()
        {
            Vehicle.Car myCar = new Vehicle.Car();
            myCar.drive();
 
            Vehicle.Sportscar mySportsCar = new Vehicle.Sportscar();
            mySportsCar.drive();
 
            Vehicle.Van myVan = new Vehicle.Van();
            myVan.drive();
 
            Vehicle.MiniVan myMiniVan = new Vehicle.MiniVan();
            myMiniVan.drive();
 
            Vehicle.ExcursionVan myExcursionVan = new Vehicle.ExcursionVan();
            myExcursionVan.drive();
        }
    }
}
