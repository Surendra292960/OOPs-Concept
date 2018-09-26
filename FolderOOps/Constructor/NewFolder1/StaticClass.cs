using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.Constructor.NewFolder1
{
    public static class StaticClass
    {
        public static float PI = 3.14f;
        public static int cube(int n)
        {
            return n * n * n;
        }

        public static int Square(int n)
        {
            return n * n;
        }
        class TestStaticClass
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Value of PI is:" + StaticClass.PI);
                Console.WriteLine("Cube of 3 is:" + StaticClass.cube(3));
                Console.WriteLine("Square of 3 is:" + StaticClass.Square(3));
                Console.Read();
            }
        }
    }
}
