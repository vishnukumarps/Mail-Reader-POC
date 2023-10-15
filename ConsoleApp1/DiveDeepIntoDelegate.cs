//using SampleTest;
//using System;
//using System.Diagnostics;

//namespace ConsoleApp1
//{
//    internal class DiveDeepIntoDelegate
//    {
//        static void Main(string[] args)
//        {
//             DelegateManager delegateManager = new DelegateManager();

//            delegateManager.DoSomething();
//        }
//    }

//}


//namespace SampleTest
//{
//    class DelegateManager
//    {
//        public delegate void SampleDeleagte1();
//        SampleDeleagte1 sampleDeleagte1;

//        public Action sampleDelegarte11;


//        //With return Type and Params
//        public delegate int SampleDelegate2(int from,int to);
//        SampleDelegate2 sampleDelegate2;
//        public Action<int, int> sampleDelegate22;
//        public Func<int, int, int> sampleDelegate222;


//        public void DoSomething()
//        {
//             sampleDeleagte1+= HelloWorld;
//            sampleDeleagte1 += HelloWorld2;

//            /// after 300 line I decided to unsubscribe HelloWorld the first function how can I do that?
//            sampleDeleagte1 -= HelloWorld;

//           // sampleDeleagte1();


//            sampleDelegate2 += GetARandomNumber;
//            Console.WriteLine(sampleDelegate2(20, 30));

//            sampleDeleagte1= () => { };

//        }

//        public void HelloWorld()
//        {
//            //  Debugger.Log("", "Hello"); ;

//            Console.WriteLine("Hello");

//        }
//        public void HelloWorld2()
//        {
//            //  Debugger.Log("", "Hello"); ;

//            Console.WriteLine("Hello2");

//        }

//        public int GetARandomNumber(int from, int to)
//        {

//            return new Random().Next(from, to); 
//        }
//    }
//}
