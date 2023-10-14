//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class ListAndMistory
//    {
//        static void Main(string[] args)
//        {
//            Helper helper = new Helper();
//            List<string> list = new List<string>();
            
//            Student student = new Student();
//            int age = 0;



//            helper.AddNewFruit(list, "Banana");

//            helper.AddStudent(student, "Vishnu", 30);
//            helper.AssignAge(age, 28);
//            helper.AssignAgeWithRef(ref age, 28);
//            helper.AssignAgeWithOut(out  age, 28);

//            helper.AssignAgeWithOut(out int age3, 28);
//            //helper.AssignAgeWithRef(ref int  age4, 28);  // ref need a pre initilized variable


//            Console.WriteLine(age); // Here AGe is 0 why?

//            Console.WriteLine(student); // I get the output  vishnu 30 which is expected

//            foreach (var item in list)
//            {
//                Console.WriteLine(item);  // I get the I output  Banana which is expected
//            }

//        }

     
//    }

//    public record Student
//    {
//        public int RollNo { get; set; }
//        public string Name { get; set; }
//    }

//    class Helper
//    {
//        public void AddStudent(Student student , string Name, int rollNo)
//        {
//            student.RollNo=rollNo;
//             student.Name=Name; 
//        }
//        public void AssignAge(int age2, int value)
//        {
//            age2 = value;
//        }
//        public void AddNewFruit(List<string> fruiits, string newFruit)
//        {

//            fruiits.Add(newFruit);
//        }

//        public void AssignAgeWithRef(ref int age2, int value)
//        {
//            age2 = value;
//        }
//        public void AssignAgeWithOut(out int age2, int value)
//        {
//            age2 = value;
//        }
//    }
//}
