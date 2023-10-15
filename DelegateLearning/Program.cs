using DelegateLearning.Events;
using Learn;

namespace DelegateLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DelegateManager delegateManager = new DelegateManager();
            //delegateManager.RunAllMyLogic();    


            UserEventManager userEventManager = new UserEventManager();
            userEventManager.CreateUser(new User() { MyProperty=1000});
        }
    }
}

/// Simple Exmaples
/// Action
/// Func 
/// 

namespace Learn
{
    public class DelegateManager
    {
        public delegate void delegate1();

        public delegate1 dl;

        public Action action;
        public Action<User> userCreated = delegate { };


        public delegate int delegate2(int no);

        public delegate2 dl2;

        public Func<User,int, bool> UserCreatedEvent;

        //public delegate void EmployeHandler(Object ob,User user);
        //public event EmployeHandler emp;

        //public EventHandler<User> UserCreated;
        public void RunAllMyLogic()
        {

            dl += SendEmail;
            dl += SendSms;


            dl();

            dl2 = (int no) => { return no*100; };
            Console.WriteLine(dl2(50));

            userCreated += SendEmail;

            userCreated( new User());
            userCreated.Invoke(new User());

            UserCreatedEvent += SendEmail;

            UserCreatedEvent.Invoke(new User(),1);
        }


        public void SendEmail()
        {
            Console.WriteLine( "Email" );
        }

        public void SendEmail(User user)
        {
            Console.WriteLine("user Email");
        }

        public bool SendEmail(User user,int flag=0)
        {
            Console.WriteLine($"user Email {flag}");
            return true;
        }

        public void SendSms()
        {
            Console.WriteLine("Sms");
        }

    }
}
