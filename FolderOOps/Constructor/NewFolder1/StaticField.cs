using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.Constructor.NewFolder1
{
    class StaticField
    {
        int acc;
        public String name;
        public static float rateOfInterrest = 8.8f;
        public StaticField(int acc, String name)
        {
            this.acc = acc;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine(acc + " " + name + " " + rateOfInterrest);
        }
    }
    class Static
    {
        static void Main(string[] args)
        {
            StaticField o1 = new StaticField(111, "hcvgsd");
            StaticField o2 = new StaticField(5555, "gggg");
            o1.Display();
            o2.Display();
            Console.Read();
        }
    }
}
