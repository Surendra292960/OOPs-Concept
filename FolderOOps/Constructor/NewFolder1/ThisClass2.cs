using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.Constructor.NewFolder1
{
    class ThisClass2
    {
        public int id;
        public String name;
        public float salary;

        public ThisClass2(int id, String name, float salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public void Display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }

    class TestThis
    {
        static void Main(string[] args)
        {
            ThisClass2 b1 = new ThisClass2(11, "surendra", 558);
            ThisClass2 b2 = new ThisClass2(13, "abc", 6456);
            b1.Display();
            b2.Display();
            Console.Read();
        }
    }
}

