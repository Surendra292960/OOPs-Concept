using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.Constructor.NewFolder1
{
    class Employee
    {
        private static int counter;
        public Employee()
        {
            counter++;
        }
        public static int Counter
        {
            get
            {
                return counter;
            }
        }
    }
    class TestEmployeeCounter
    {
        static void Main(string[] args)
        {
            Employee a1 = new Employee();
            Employee a2 = new Employee();
            Employee a3 = new Employee();

            Console.WriteLine("No.of Employees:" + Employee.Counter);
            Console.Read();

        }
    }
}
