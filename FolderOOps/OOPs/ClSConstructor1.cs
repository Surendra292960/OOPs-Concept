using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.OOPs
{
    class ClSConstructor1
    {
        int EmpId;
        String EName;
        String EAddress;
        int EAge;
        public ClSConstructor1()
        {
            this.EmpId = 111;
            this.EName = "abc";
            this.EAddress = "BTM";
            this.EAge=25;
        }
        public void DisplayData()
        {
            Console.WriteLine("Employee Id" + this.EmpId);
            Console.WriteLine("Employee Name" + this.EName);
            Console.WriteLine("Employee Address" + this.EAddress);
            Console.WriteLine("Employee Age" + this.EAge);
           
        }
         class BConstructor
        {
            static void Main(string[] args)
            {
                ClSConstructor1 obj1 = new ClSConstructor1();
                obj1.DisplayData();
                Console.Read();
            }
        }
    }

}
