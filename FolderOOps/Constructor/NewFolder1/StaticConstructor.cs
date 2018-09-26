using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.Constructor.NewFolder1
{
    class StaticConstructor
    {
        public int id;
        public String name;
        public static float rateOfInterest;
        public StaticConstructor(int id, String name)
        {
            this.id = id;
            this.name = name;
        }
        static StaticConstructor()
        {
            rateOfInterest = 9.5f;
        }
        public void Display()
        {
            Console.WriteLine(id + " " + name + " " + rateOfInterest);
        }
    }

    class TestStaticConstructor
        {
        static void Main(string[] args)
        {
            StaticConstructor o1 = new StaticConstructor(101, "Nigam");
            StaticConstructor o2 = new StaticConstructor(102, "Basheer");

            o1.Display();
            o2.Display();
            Console.Read();


        }
    }
}
