using System;

namespace FolderOOps.Constructor.NewFolder1
{
    class Destructor
    {
        public Destructor()
        {
            Console.WriteLine("Constructor Invoked1");
        }
       ~ Destructor()
        {
            Console.WriteLine("Destructor Invoked1");
        }
    }
    class TestEmployee
    {
        public static void Main(string[] args)
        {
            Destructor e1 = new Destructor();
            Destructor e2 = new Destructor();
            Console.Read();
        }
    }
}