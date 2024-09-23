using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class Private
    {
        public class PrivateClass
        {
            private int Privatefield;

            public void setField(int value)
            {
                Privatefield = value;
            }
            public void show()
            {
                Console.WriteLine("private field value=" + Privatefield); 
            }
        }
        static void Main()
        {
            Console.WriteLine("Access modifier in C#");
            PrivateClass obj=new PrivateClass();
            obj.setField(10);
            obj.show();
            /*
            PublicClassExample obj = new PublicClassExample();
            obj.PublicProperty = 1;
            obj.Show();*/
        }
    }
}
