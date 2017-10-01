using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    public class Vehicle : IComparable<Vehicle>
    {
        public string _vehicleName { get; set; }
        public string _vehicleModel { get; set; }
        public int _yearOfManufacture { get; set; }
        public int _speedofVehicle { get; set; }

        public int CompareTo(Vehicle other)
        {
            return this._vehicleName.CompareTo(other._vehicleName);
        }

        //2. Override equals method to check two vehicles for equality
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Vehicle))
            {
                return false;
            }
            Vehicle v = obj as Vehicle;
            return _vehicleName == v._vehicleName && _vehicleModel == v._vehicleModel;
        }
    }

    class Program
    {

        public static void Main(string[] args)
        {
            Vehicle Bike = new Vehicle();
            Bike._vehicleName = "Bike";
            Bike._vehicleModel = "101";
            Bike._yearOfManufacture = 2012;
            Bike._speedofVehicle = 40;

            Vehicle Bicycle = new Vehicle();
            Bicycle._vehicleName = "Bicycle";
            Bicycle._vehicleModel = "102";
            Bicycle._yearOfManufacture = 2013;
            Bicycle._speedofVehicle = 30;

            Vehicle Car = new Vehicle();
            Car._vehicleName = "Car";
            Car._vehicleModel = "103";
            Car._yearOfManufacture = 2011;
            Car._speedofVehicle = 50;

            Vehicle Truck = new Vehicle();
            Truck._vehicleName = "Truck";
            Truck._vehicleModel = "104";
            Truck._yearOfManufacture = 2015;
            Truck._speedofVehicle = 60;

            List<Vehicle> VehicleList = new List<Vehicle>(100);
            VehicleList.Add(Bike);
            VehicleList.Add(Bicycle);
            VehicleList.Add(Car);
            VehicleList.Add(Truck);

            //1. IComparator to comapre two objects.

            int i = Bike.CompareTo(Bicycle);
            if (i == 0)
            {
                Console.WriteLine("IComparator CompareTo() method->");
                Console.WriteLine("Both Objects are equal according to CompareTo method");
            }
            else
            {
                Console.WriteLine("IComparator CompareTo() method->");
                Console.WriteLine("Objects are NOT equal according to CompareTo method");
            }

            // Sorting the vehicles
            Console.WriteLine("\n--------------");
            VehicleList.Sort();
            Console.WriteLine("After Sorting->");
            foreach (Vehicle v in VehicleList)
            {
                Console.WriteLine("Vehicle is: {0} , Model : {1} , Year : {2} ,Speed : {3} ", v._vehicleName, v._vehicleModel, v._yearOfManufacture, v._speedofVehicle);
            }

            // Printing all objects
            Console.WriteLine("\n--------------");
            Console.WriteLine("Printing Status of Objects->");
            foreach (Vehicle v in VehicleList)
            {
                Console.WriteLine("Vehicle is: {0} , Status : {1} , Year : {2} ,Speed : {3} ", v._vehicleName, v._vehicleModel, v._yearOfManufacture, v._speedofVehicle);
            }

            // Calling overriden Equals method
            Console.WriteLine("\n--------------");
            Console.WriteLine("Overriden Equals method->");
            Console.WriteLine("It says equality of Bike and Car is :" + Bike.Equals(Car));
            Console.Read();
        }
    }
}
