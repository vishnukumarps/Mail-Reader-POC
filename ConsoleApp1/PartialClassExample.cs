//using namespace1;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class PartialClassExample
//    {
//        static void Main(string[] args)
//        {
//            Helper helper = new Helper();
//            helper.Hai();
//            helper.Hello();
//        }
//    }
//}

//namespace namespace1
//{
//    public partial class Helper
//    {
//        int a = 99;

//        internal void Hai()
//        {
//            throw new NotImplementedException();
//        }

//        partial void AddTwoNumbers();

//    }

//    public partial class Helper
//    {
//        internal void Hello()
//        {
//            throw new NotImplementedException();
//        }
//        partial void AddTwoNumbers()
//        {
//            Console.WriteLine("Add two num");
//        }
//    }

//    public partial class Helper
//    {
//        internal void Hello2()
//        {

//            var dict = new Dictionary<string, Object>()
//            {
//                {"Id",1 }
//            };

//            dict.TryGetValue("Id",  out var value1);


//            int.TryParse("1", out int con);
//            throw new NotImplementedException();
//        }
//        //partial void AddTwoNumbers() // This is not possible
//        //{
//        //    Console.WriteLine("Add two num2");
//        //}
//    }
//}

//namespace namespace2
//{

//}
