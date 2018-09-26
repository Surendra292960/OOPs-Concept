using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.OOPs
{
    class ObjectClass2
    {
        public int id;
        public String name;
    }
    class TestStudent
    {
        static void Main(string[] args)
        {
            ObjectClass2 s1 = new ObjectClass2();
            s1.id = 101;
            s1.name = "surendra";
            Console.WriteLine(s1.id);
            Console.WriteLine(s1.name);
        }
    }
}
