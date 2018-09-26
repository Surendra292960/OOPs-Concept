using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.Constructor.NewFolder1
{

    public class Address
    {
        public string addressLine, city, state;
        public Address(string addressLine, string city, string state)
        {
            this.addressLine = addressLine;
            this.city = city;
            this.state = state;
        }
    }
    public class Employee1
    {
        public int id;
        public string name;
        public Address address;//Employee HAS-A Address  
        public Employee1(int id, string name, Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " +address.addressLine + " " + address.city + " " + address.state);
        }
    }
    public class TestAggregation
    {
        public static void Main(string[] args)
        {
            Address a1 = new Address("G-13, Sec-3", "Noida", "UP");
            Employee1 e1 = new Employee1(1, "Sonoo", a1);
            e1.display();
            Console.Read();
        }
    }
}