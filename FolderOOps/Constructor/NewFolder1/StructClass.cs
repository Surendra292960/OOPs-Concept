using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.Constructor.NewFolder1
{
    class StructClass
    {
        public int width, height;
    }
        public class TestStructs
        {
            public static void Main()
            {
            StructClass r = new StructClass();
                r.width = 4;
                r.height = 5;
                Console.WriteLine("Area of Rectangle is: " + (r.width * r.height));
            Console.Read();
            }
        }
    }

