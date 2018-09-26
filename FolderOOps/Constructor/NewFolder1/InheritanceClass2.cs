using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.Constructor.NewFolder1
{
    class InheritanceClass2
    {
        public float salary = 40000;
    }
     class Programmer : InheritanceClass2
    {
        public float bonus = 10000;
    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {
            Programmer p1 = new Programmer();

            Console.WriteLine("Salary: " + p1.salary);
            Console.WriteLine("Bonus: " + p1.bonus);
            Console.Read();

        }
    }
}
