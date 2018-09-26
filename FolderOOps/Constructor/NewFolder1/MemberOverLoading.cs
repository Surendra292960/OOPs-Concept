using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOOps.Constructor.NewFolder1
{
    class MemberOverLoading
    {
        public static int add(int a, int b) { return a + b; }
        public static int add(int a, int b, int c) { return a + b + c; }
    }
    public class TestMemberOverLoading
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MemberOverLoading.add(12, 23));
            Console.WriteLine(MemberOverLoading.add(12, 23,25));
            Console.Read();
        }
    }
}
