using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.Constructor.NewFolder1
{
    class StructClass2
    {
        public int height, width;
        public StructClass2(int w,int h)
        {
            width = w;
            height = h;
        }
        public void AreaOfRactangle()
        {
            Console.WriteLine("Area of ractangle is:" + (height * width));
        }

        public class TestStruct2
        {
            static void Main(string[] args)
            {
                StructClass2 o1 = new StructClass2(11,11);
                o1.AreaOfRactangle();
                Console.Read();
            }
        }
    }
}
