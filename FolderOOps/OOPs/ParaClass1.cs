using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.OOPs
{
    class ParaClass1
    {
        int EmpId;
        String EName;
        String EAddress;
        int EAge;


        public ParaClass1(int ID,String name)
        {
            this.EmpId = ID;
            this.EName = name;
        }
        public ParaClass1()
        {
            this.EmpId = 111;
            this.EName = "BTM";
            this.EAddress = "BTM";
            this.EAge = 655;
        }
        public ParaClass1(int id, String name, String add, int age)
        {
            this.EmpId = id;
            this.EName = name;
            this.EAddress = add;
            this.EAge = age;
        }
        public void DisplayDtata()
        {

            Console.WriteLine("Employee Id:" + this.EmpId);
            Console.WriteLine("Employee Name:" + this.EName);
            Console.WriteLine("Employee Address:" + this.EAddress);
            Console.WriteLine("Employee Age:" + this.EAge);
        }
    }
    class G
    {
        static void Main(string[] args)
        {
            ParaClass1 obj1 = new ParaClass1(22, "Surendra", "BTM", 55);
            ParaClass1 obj2 = new ParaClass1(23, "Abc", "BTM", 66);
            ParaClass1 obj3 = new ParaClass1();
            ParaClass1 obj4 = new ParaClass1(111,"Mohan");
            obj1.DisplayDtata();
            obj2.DisplayDtata();
            obj3.DisplayDtata();
            obj4.DisplayDtata();
            Console.Read();
        }
    }
}
