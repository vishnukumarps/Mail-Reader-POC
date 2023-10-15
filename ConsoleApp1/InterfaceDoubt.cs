//using Doubts;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class InterfaceDoubt
//    {

//        static void Main(string[] args)
//        {
//            Sample s = new Sample();
//            s.Test2(s);
//        }
//    }
//}

//namespace  Doubts
//{
//    interface ISample
//    {
//        void Test(int c);
//    }


//    interface ISample2 :ISample
//    {
//        void Test2<T>(T c) where T : class;
//    }

//    public class Sample : ISample2
//    {
//        public void Test(int c)
//        {
//            throw new NotImplementedException();
//        }

//        public void Test2<T>(T c) where T : class
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
