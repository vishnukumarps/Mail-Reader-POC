//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class DictonaryExample
//    {
//        static void Main(string[] args)
//        {
//            Dictionary<int, Student>? students= new Dictionary<int, Student>()
//            {

//                {1, new Student() { Id=1, Name="Vishnu",Address="Kollam"} },
//                {2, new Student() { Id=1, Name="Vipin",Address="Kollam"} }
//            };

//            Student? student =students.FirstOrDefault(x => x.Key == 1).Value;
//            students.ContainsKey(1);

//            var result = students.FirstOrDefault(x => x.Value.Name == "Vipin").Key;

//            Student? result2 = students.FirstOrDefault(x => x.Value.Name == "Vipin").Value;

//            List<Student> studentList = new List<Student>();
//            Student student1 = new Student { Id = 1, Name = "Alice", Address = "123 Main St" };
//            Student student2 = new Student { Id = 2, Name = "Bob", Address = "456 Elm St" };
//            Student student3 = new Student { Id = 3, Name = "Charlie", Address = "789 Oak St" };

//            studentList.Add(student1);
//            studentList.Add(student2);
//            studentList.Add(student3);

//            Dictionary<int, Student> studentDictionary = studentList.ToDictionary(student => student.Id);

//            Dictionary<int, StudentDto> studentDictionary2 = studentList.ToDictionary(student => student.Id, student => new StudentDto
//            {
//                Name = student.Name,
//                Address = student.Address
//            });


//            Dictionary<string, StudentDto>? dic = studentList.ToDictionary(x => x.Name, x => new StudentDto
//            {
//                Address = x.Address,
//                Name = x.Name,
//            });

           
//        }
//    }

//    class Student
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Address { get; set; }
//    }

//    class StudentDto
//    {
     
//        public string Name { get; set; }
//        public string Address { get; set; }
//    }
//}
