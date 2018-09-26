using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.Constructor.NewFolder1
{
    class Account
    {
        public int accno;
        public String name;
        public static int count = 0;
        public Account(int accno, String name)
        {
            this.accno = accno;
            this.name = name;
            count++;
        }
        public void Display()
        {
            Console.WriteLine(accno+" "+name);
        }

    }

    class TestAccount
    {
        static void Main(string[] args)
        {
            Account p1 = new Account(101,"Sonu");
            Account p2 = new Account(102,"sfcd");
            Account p3 = new Account(103,"dvfd");
            p1.Display();
            p2.Display();
            p3.Display();


            Console.WriteLine("Total Objects:" + Account.count);
            Console.ReadLine();

        }
    }
}
