using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.OOPs
{
    class ObjectClass
    {
        int id;
        String name;
        static void Main(string[] args)
        {
            ObjectClass obj1 = new ObjectClass();
            obj1.id = 11;
            obj1.name = "surendra";
            Console.WriteLine(obj1.id);
            Console.WriteLine(obj1.name);
            Console.Read();
        }
    }
}
