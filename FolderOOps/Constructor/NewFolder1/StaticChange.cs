using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.Constructor.NewFolder1
{
    class StaticChange
    {
        public int id;
        public String name;
        public static String address="jjjjjjj";

        public StaticChange(int id, String name)
        {
            this.id = id;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine(id + " " + name + " " + address);
        }
    }

    class StaticChangeField
    {
        static void Main(string[] args)
        {
            StaticChange.address = "Bangalore";
            StaticChange p1 = new StaticChange(11,"surendra");
            StaticChange p2 = new StaticChange(525258, "gfhcdhc");
            p1.Display();
            p2.Display();
            Console.Read();
        }
    }
}
