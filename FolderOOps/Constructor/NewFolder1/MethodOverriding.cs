using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.Constructor.NewFolder1
{
    public class MethodOverriding
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating.....");
        }
    }
    public class Mango : MethodOverriding
    {
        public override void eat()
        {
            Console.WriteLine("Eating bread");
        }
    }
    public class TestOverriding
    {
        static void Main(string[] args)
        {
            Mango d = new Mango();
            d.eat();
            Console.Read();
        }
    }
}
    
