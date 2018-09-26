using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.OOPs
{
    class ObjectClass3
    {

        public int id;
        public String name;
        public float salary;
        public void insert(int i, String n, float s)
        {
            id = i;
            name = n;
            salary = s;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }
    class TestEmployee
    {
        public static void Main(string[] args)
        {
            ObjectClass3 e1 = new ObjectClass3();
            ObjectClass3 e2 = new ObjectClass3();
            e1.insert(101, "Sonoo", 890000f);
            e2.insert(102, "Mahesh", 490000f);
            e1.display();
            e2.display();

        }
    }
}
