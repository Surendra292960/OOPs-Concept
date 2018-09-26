using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.Constructor.NewFolder1
{
    public class SingleInheritance
    {
        public void eat() { Console.WriteLine("Eating..."); }
    }
     class Dog : SingleInheritance
    {
        public void bark() { Console.WriteLine("Barking..."); }
    }
    class TestInheritance2
    {
        static void Main(string[] args)
        { 
        Dog d1 = new Dog();
        d1.eat();
            d1.bark();
            Console.Read();
        }
    }
}
