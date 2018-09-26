using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.Constructor.NewFolder1
{
    class ParamerizedClass2
    {
        int id;
        String name;
        public ParamerizedClass2(int  id, String name)
        {
            this.id = id;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine(id + " " + name);
        }
    }
    class TestEmp
    {
        static void Main(string[] args)
        {
            ParamerizedClass2 s1 = new ParamerizedClass2(11,"bca");
            s1.Display();
            Console.Read();

        }
    }
}
