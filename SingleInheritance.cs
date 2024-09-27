using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Vehical  //base class 
    {
        public string Brand { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{Brand} is Driving");
        }
    }
    class Car:Vehical
    {
        public int NumbersofDoors { get; set; }

        public void showCarInfo()
        {
            Console.WriteLine($"{Brand} car has {NumbersofDoors} door");
        }
    }
    internal class SingleInheritance
    {
        public static void Main()
        {
            Car mycar=new Car();
            mycar.Brand = "Tata";
            mycar.NumbersofDoors=4;
            mycar.Drive();
            mycar.showCarInfo();

        }
    }
}
