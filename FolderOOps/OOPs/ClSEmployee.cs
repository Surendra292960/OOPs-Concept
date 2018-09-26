using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.OOPs
{
    class ClSEmployee
    {
            int EmpId;
            String EName;
            String EAddress;
            int EAge;

             public void GetData()
            {
                Console.WriteLine("Employee Detail:");
                this.EmpId = Convert.ToInt32(Console.ReadLine());
                this.EName = Console.ReadLine();
                this.EAddress = Console.ReadLine();
                this.EAge = Convert.ToInt32(Console.ReadLine());
            }
            public void DispalayData()
            {
                Console.WriteLine("Employee Detail:");
                Console.WriteLine("EmpId is:" + this.EmpId);
                Console.WriteLine("EName is:" + this.EName);
                Console.WriteLine("EAddress is:" + this.EAddress);
                Console.WriteLine("EAge is:" + this.EAge);

        }
    }

    class ClSEncapsulate //Entry Point
    {
        static void Main(string[] args)
        {
            ClSEmployee obj1 = new ClSEmployee();
            obj1.GetData();
            obj1.DispalayData();
            Console.Read();
        }
    }
}
