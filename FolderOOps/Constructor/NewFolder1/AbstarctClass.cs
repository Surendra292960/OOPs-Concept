using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.Constructor.NewFolder1
{
    public abstract class AbstarctClass
    {
        public abstract void draw();
    }
    public class Rectangle: AbstarctClass
    {
        public override void draw()
        {
            Console.WriteLine("drawing rectangle.....");
        }
    }
    public class Circle: AbstarctClass
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle.....");

        }
    }
    public class TestAbstract
    {
        static void Main(string[] args)
        {
            AbstarctClass s;
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();
            Console.Read();
        }
    }
}
