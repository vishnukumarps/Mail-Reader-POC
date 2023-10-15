using Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class ExtentionMethodExample
    {
        static void Main(string[] args)
        {
            int anyNumber = 100;

            var x = anyNumber.IsEvenOrOddWithThisKeyword();

           // var y = anyNumber.IsEvenOrOddWithoutThisKeyword(); // this is error
            bool y = ExtensionClass.IsEvenOrOddWithoutThisKeyword(2);

            List<Student> studentList = new List<Student>()
            {
                new Student() { Name = "Vishnu", RollNo = 12 },
                new Student() { Name = "Vipin", RollNo = 110 }
            };
            string[] stringArray = new string[] { "Hello1", "World", "C#", "Programming", "Example" };


            bool isPresent = studentList.IsPresent(x => x.Name == "vishnukumar ospsosns");
            bool b = stringArray.IsPresent(x => x == "C#");

            List<int>? newList = new List<int> { 1, 2, 1, 3, 1, 3 }.MyFilter(x => x == 3);

            var students = studentList.MyFilter2(x => x.RollNo == -4).FirstOrDefault();

            var x1 = 1.MultiplyBy<int, int, int>(2);

        }
    }

    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
    }
}

namespace Extension
{
    public static class ExtensionClass
    {
        public static bool IsEvenOrOddWithThisKeyword(this int number)
        {
            return (number % 2 == 0);
        }

        public static bool IsEvenOrOddWithoutThisKeyword(int number)
        {
            return (number % 2 == 0);
        }
        public static bool IsPresent<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate) where TSource : class
        {
            return source.Any(predicate);
        }
        public static List<int> MyFilter(this IEnumerable<int> source, Func<int, bool> predicate)
        {
            List<int> result = new List<int>();
            foreach (int item in source)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static IEnumerable<TSource> MyFilter2<TSource>(this IEnumerable<TSource> sources, Func<TSource, bool> predicate) where TSource : class
        {
            List<TSource> result = new List<TSource>();
            foreach (TSource source in sources)
            {
                if (predicate(source))
                {
                    result.Add(source);
                }
            }

            return result.Count > 0 ? result : new List<TSource>();
        }

        public static T3 MultiplyBy<T1, T2, T3>(this T1 t1, T2 t2)
        {

            dynamic dynamicT1 = t1;
            dynamic dynamicT2 = t2;

            return (T3)(dynamicT1 * dynamicT2);
        }
    }
}
