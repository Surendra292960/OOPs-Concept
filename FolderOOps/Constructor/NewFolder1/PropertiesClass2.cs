using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.Constructor.NewFolder1
{
    class PropertiesClass2
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        class TestPropertiesClass2
        {
            public static void Main(string[] args)
            {
                PropertiesClass2 e1 = new PropertiesClass2();
                e1.Name = "Sonoo Jaiswal";
                Console.WriteLine("Employee Name: " + e1.Name);
                Console.Read();
            }
        }
    }
}
