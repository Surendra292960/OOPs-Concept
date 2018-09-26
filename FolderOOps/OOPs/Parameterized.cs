using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.OOPs
{
    class Parameterized
    {
        int EmpId;
        String EName;
        String EAddress;
        int EAge;
        public Parameterized(int id,String name,String add,int age)
        {
            this.EmpId = id;
            this.EName = name;
            this.EAddress = add;
            this.EAge = age;
        }
        public void DisplayDtata()
        {
       
            Console.WriteLine("Employee Id" + this.EmpId);
            Console.WriteLine("Employee Name" + this.EName);
            Console.WriteLine("Employee Address" + this.EAddress);
            Console.WriteLine("Employee Age" + this.EAge);
        }
    }
    class A
    {
        static void Main(string[] args)
        {
            Parameterized obj1 = new Parameterized(22,"Surendra","BTM",55);
            Parameterized obj2 = new Parameterized(23, "Abc", "BTM", 66);
            obj1.DisplayDtata();
            obj2.DisplayDtata();
            Console.Read();
        }
    }
}
