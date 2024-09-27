using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class myShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Shape");
        }
    }
    class circle : myShape
    {
        public void DrawCircle()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
    class Rectangle:myShape
    {
        public void DrawRectangle()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }
    class Trangle:myShape
    {
        public void DrawTriangle()
        {
            Console.WriteLine("Drawing a Triangle");
        }
    }
    internal class HirarchicalInheritance
    {
        static void Main()
        {
           circle mycircle=new circle();
            mycircle.Draw();
            mycircle.DrawCircle();

            Rectangle rect1=new Rectangle();
            rect1.Draw();
            rect1.DrawRectangle();

            Trangle trangle=new Trangle();
            trangle.Draw();
            trangle.DrawTriangle();

        }
    }
}
