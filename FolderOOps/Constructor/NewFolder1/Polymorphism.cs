using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.Constructor.NewFolder1
{
    public class Animal
    {
        public void eat() { Console.WriteLine("Eating..."); }
    }
    public class Donky : Animal
    {
        public void Bark() { Console.WriteLine("Barking..."); }
    }
    public class BabyDog : Donky
    {
        public void weep() { Console.WriteLine("Weeping..."); }
    }
    class TestInheritance3
    {
        public static void Main(string[] args)
        {
            BabyDog d1 = new BabyDog();
            d1.eat();
            d1.Bark();
            d1.weep();
            Console.Read();
        }
    }
}

