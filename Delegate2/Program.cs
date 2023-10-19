using Delegate2.Extentions;
using SampleName;

namespace Delegate2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sample sample = new Sample();
            //sample.RunAllMyLogic();

            List<Student> studentList = new List<Student>();

            // Adding students to the list
            studentList.Add(new Student { Name = "John", Age = 20 });
            studentList.Add(new Student { Name = "Alice", Age = 22 });
            studentList.Add(new Student { Name = "Bob", Age = 21 });

           // Student? student= studentList.CustomFilter((x) => { return x.Name == "Bob"; }).FirstOrDefault();
           // Console.WriteLine(  student);
        }
    }
}

namespace SampleName
{
    class Sample
    {
        public delegate void delegate1();

        //public delegate1 _delegate1= delegate { };
        public delegate1? _delegate1;


        public Action? action;
        public Action<int>? action2;



        public delegate int delegate2(int number);

        public delegate2? _delegate2 ;


        public Func<int,char,string>? action3;

        public EventHandler<Student> studentCreated;



        public void RunAllMyLogic()
        {
            int x = 10;
            _delegate1 += SendEmail;  // subscribe
            _delegate1 += SendSMS;
            _delegate1 += () => { Console.WriteLine("Hello"); };


          
            studentCreated.Invoke(this, new Student());

            action += SendEmail;
            action.Invoke();

            action2 += Test;
            action2.Invoke(8);

            action3 += Test2;
            action3.Invoke(10, 'c');

           // _delegate1();
            _delegate1.Invoke();


            _delegate1-= SendSMS; // // un subscribe

            _delegate1.Invoke();
            _delegate1 = null;


            _delegate2 += GetMeARandomNum;



            Console.WriteLine(_delegate2.Invoke(800));


        }



        public void SendEmail()
        {
            Console.WriteLine( "Email Sending");
        }

        public void SendSMS()
        {
            Console.WriteLine("SMS Sending");
        }

        public int GetMeARandomNum(int maxLimit)
        {
            return new Random().Next(0,maxLimit);
        }

        public void  Test(int x)
        {
            Console.WriteLine( x);
        }

        public string Test2(int x, char y)
        {
            Console.WriteLine(x);

            return "hello";
        }

        public void SendSMS3(Object sender,Student student)
        {
            Console.WriteLine("SMS Sending");
        }
    }

    class Student
    {
        public string Name { get; set; }
       public int Age { get; set; }
    }
}