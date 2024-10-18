using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    static class CatWorld
    {
        public static int NumberOfCats { get; set; }
        public static int TotalCatNaps { get; set; }
        static CatWorld()
        {
            NumberOfCats = 5;
        }
        public static void AddCat()
        {
            Console.WriteLine($"Current Cat Count Is:- {NumberOfCats}");
            NumberOfCats++;
            Console.WriteLine("\n new Cat Has Joined..");
        }
    }
    internal class StaticClass1
    {
        static void Main()
        {
            CatWorld.AddCat();
            CatWorld.AddCat();
            CatWorld.AddCat();

        }
    }
}
