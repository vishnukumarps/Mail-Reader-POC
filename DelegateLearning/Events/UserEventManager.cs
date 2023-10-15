using Learn;

namespace DelegateLearning.Events
{
    public class UserEventManager
    {
        private delegate bool UserCreationHandler(User newUser);

        private UserCreationHandler? OnUserCreated;

        public void CreateUser(User user)
        {
            // Subscribe to the event
            OnUserCreated += NotifyUserByEmail;
            OnUserCreated += NotifyUserBySms;
            OnUserCreated += LogUserCreationToDatabase;

            // Invoke the delegate
            OnUserCreated?.Invoke(user);
            // OnUserCreated(user?? new User());

            // Unsubscribe when no longer needed
            OnUserCreated -= NotifyUserByEmail;
            OnUserCreated -= NotifyUserBySms;
            OnUserCreated -= LogUserCreationToDatabase;

            // Unsubscribe all at once
            OnUserCreated = null;


        }

        private bool NotifyUserByEmail(User user)
        {
            Console.WriteLine($"Sending email to user {user.MyProperty}");
            return true;
        }

        private bool NotifyUserBySms(User user)
        {
            Console.WriteLine($"Sending SMS to user {user.MyProperty}");
            return true;
        }

        private bool LogUserCreationToDatabase(User user)
        {
            Console.WriteLine($"Logging user creation to database {user.MyProperty}");
            return true;
        }
    }

    public class StudentEventManager
    {
        private delegate bool StudentCreatedHandler(object sender, User user);
        private event StudentCreatedHandler? OnStudentCreated;
        //                        |
        //  OR U can use 1 line \|/

        // Declare the event using the built-in EventHandler delegate
        public event EventHandler<User>? UserCreated;









        // Method to raise the UserCreated event
        public void RaiseUserCreatedEvent(User user)
        {
            UserCreated += (Object? ob, User user) => { /*Function 2*/};
            UserCreated += (Object? ob, User user) => { /*Function 1*/};


            UserCreated?.Invoke(this, user);

            //unSubscribtion is not possible   If we use arrow function



            OnStudentCreated+= (Object? ob, User user) => { /*Function 2*/ return true; };
            OnStudentCreated += (Object? ob, User user) => { /*Function 2*/ return false; };

            var x=OnStudentCreated?.Invoke(this, user);
            var xx=OnStudentCreated.GetInvocationList();
        }
    }
}
