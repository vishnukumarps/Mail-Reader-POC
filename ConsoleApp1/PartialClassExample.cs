using namespace1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PartialClassExample
    {
        static void Main(string[] args)
        {
           Helper helper = new Helper();
            helper.AddTwoNumbers();
        }
    }
}

namespace namespace1
{
    public partial class  Helper
    {
        int a = 99;
        public partial void AddTwoNumbers();
        public partial void AddTwoNumbers()
        {
            a = 100;
            Console.WriteLine( a);
        }
    }
}

namespace namespace2
{
    public partial class Helper
    {
        public partial void AddTwoNumbers();
        public partial void AddTwoNumbers()
        {

            Console.WriteLine("Hello");
        }
    }
}