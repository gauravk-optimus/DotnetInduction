using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        public string make = "Unknown";
        public int yearOfManufacture = 0;
        public string model = "Unknown";
        public float speed = 0;
        int acceleration = 2;

        public void accelerate()
        {
            speed = speed*acceleration;
            Console.WriteLine("Speed after Acceleration " + speed);
        }
        public void deaccelarate()
        {
            speed = speed / acceleration;
            Console.WriteLine("Speed after Deceleration " + speed);
        }
        public void stop()
        {
            speed = speed * 0;
            Console.WriteLine("Vehicle is stopped");
        }
        public Boolean isMoving()
        {
            if (speed > 0)
            {
                Console.WriteLine("Vehicle is moving");
                return true;
            }
            else
            {
                Console.WriteLine("Vehicle is not moving");
                return false;
            }
        }
        public class Bicycle : Vehicle
        {
            
            public string BycycleColor = "Unknown";
            public Bicycle(string vehicleMaker, int vehicleYearOfManufacturer, string vehicleModel, float vehicleSpeed)
            {
                make = vehicleMaker;
                yearOfManufacture = vehicleYearOfManufacturer;
                model = vehicleModel;
                speed = vehicleSpeed;
            }
            public void setBycycleColor()
            {
                BycycleColor = "Red";
                Console.WriteLine("Bycycle color is set to Red by default");
            }
            public void getBycycleColor()
            {
                Console.WriteLine("Bycycle color is " + BycycleColor);
            }
        } 
         
        public class Bike : Vehicle
        {
            public string bikeType;
            public Bike(string vehicleMaker, int vehicleYearOfManufacturer, string vehicleModel, float vehicleSpeed)
            {
                make = vehicleMaker;
                yearOfManufacture = vehicleYearOfManufacturer;
                model = vehicleModel;
                speed = vehicleSpeed;
            }
            public void setBikeType()
            {
                Console.Write("Enter bike type :");
                bikeType = Console.ReadLine();
            }
            public void getBikeType()
            {
                Console.WriteLine("Bike Type is " + bikeType);
            }
        }
        public class Car : Vehicle
        {
            public string carBodyType;
            
            public Car(string vehicleMaker, int vehicleYearOfManufacturer, string vehicleModel, float vehicleSpeed)
            {
                make = vehicleMaker;
                yearOfManufacture = vehicleYearOfManufacturer;
                model = vehicleModel;
                speed = vehicleSpeed;
            }        

            public void setCarBodyType()
            {
                Console.Write("Enter Car body type :");
                carBodyType = Console.ReadLine();

            }
            public void getCarBodyType()
            {
                Console.WriteLine("Car body Type is " + carBodyType);
            }
        }
        public class Truck : Vehicle
        {
            public int truckLoadingCapacity = 0;
            public Truck(string vehicleMaker, int vehicleYearOfManufacturer, string vehicleModel, float vehicleSpeed)
            {
                make = vehicleMaker;
                yearOfManufacture = vehicleYearOfManufacturer;
                model = vehicleModel;
                speed = vehicleSpeed;
            }
            public void setTruckLoadingCapacity()
            {
                Console.Write("Enter Truck Loading Capacity :");
                truckLoadingCapacity = int.Parse(Console.ReadLine());
            }
            public void getTruckLoadingCapacity()
            {
                Console.Write("Truck Loading Capacity  is :"+ truckLoadingCapacity);
            }
        }
        static void Main(string[] args)
        {
            Bicycle b = new Bicycle("Hero", 2000, "Youngster", 30);
            Bike bk = new Bike("Yamaha", 2014, "FZ", 50);
            Car c = new Car("Maruti", 2015, "Dzire", 60);
            Truck t = new Truck("Tata", 2013, "1613", 40);

            b.setBycycleColor();
            bk.setBikeType();
            c.setCarBodyType();
            t.setTruckLoadingCapacity();
            Console.WriteLine("");

            Console.WriteLine("Bicycle details are");
            Console.WriteLine("Bike Maker "+bk.make);
            Console.WriteLine("Bike Manufacture year " + bk.yearOfManufacture);
            Console.WriteLine("Bike Model " + bk.model);
            Console.WriteLine("Bike Speed " + bk.speed);
            bk.accelerate();
            bk.deaccelarate();
            bk.isMoving();
            bk.stop();            
            bk.getBikeType();

            Console.WriteLine("Bike details are");
            Console.WriteLine("");
            Console.WriteLine("Bcycle Maker " + b.make);
            Console.WriteLine("Bcycle Manufacture year " + b.yearOfManufacture);
            Console.WriteLine("Bcycle Model " + b.model);
            Console.WriteLine("Bcycle Speed " + b.speed);
            b.accelerate();
            b.deaccelarate();
            b.isMoving();
            b.stop();            
            b.getBycycleColor();
            Console.WriteLine("");

            Console.WriteLine("Car details are");
            Console.WriteLine("Car Maker " + c.make);
            Console.WriteLine("Car Manufacture year " + c.yearOfManufacture);
            Console.WriteLine("Car Model " + c.model);
            Console.WriteLine("Car Speed " + c.speed);
            c.accelerate();
            c.deaccelarate();
            c.isMoving();
            c.stop();            
            c.getCarBodyType();
            Console.WriteLine("");

            Console.WriteLine("Truck details are");
            Console.WriteLine("Truck Maker " + t.make);
            Console.WriteLine("Truck Manufacture year " + t.yearOfManufacture);
            Console.WriteLine("Truck Model " + t.model);
            Console.WriteLine("Truck Speed " + t.speed);
            t.accelerate();
            t.deaccelarate();
            t.isMoving();
            t.stop();
            t.getTruckLoadingCapacity();

            Console.ReadLine();
        }
    }
}
