using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
   
        class MyVehical
        {
            public void start()
            {
                Console.WriteLine("The vehical is started");
            }
        }
        class offriding : MyVehical
        {
            public void Drive()
            {
                Console.WriteLine("The car is Driving");
            }
        }
        class SportCar:offriding
        {
            public void Turboboast()
            {
                Console.WriteLine("the sport car is turbo mode");
            }
        }
    internal class MultilevelInheritance
    {
        public static void Main()
        {
              SportCar mycar1=new SportCar();
              mycar1.start();
              mycar1.Drive();
              mycar1.Turboboast();
        }
    }
}
