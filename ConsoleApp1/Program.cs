//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        private static async Task<int> GetTotal(List<int> numList, Func<int, Task> callback)
//        {
       

//            return await Task.Run(() =>
//            {
//                Task.Delay(300).Wait(); // Simulate a delay similar to setTimeout in JavaScript

//                if (numList.Count == 0)
//                {
//                    throw new Exception("Array is empty");
//                }

//                int total = numList.Sum();
//                //callback(total);
//                return total;
//            });


//        }

//        static async Task Main(string[] args)
//        {
//            List<int> numList = new List<int> { 1, 2, 3, 4 };

//           int t=await GetTotal(numList, async (int total) =>
//            {
//                Console.WriteLine(total);
//            });

//            try
//            {
//               var x= await GetTotal(numList,async (int total) => { });
//            }
//            catch (Exception)
//            {

//                throw;
//            }

//            Console.WriteLine(t);
//            // In a real application, you may want to wait for the asynchronous operation to complete.
//            // await Task.Run(async () => await GetTotalAsync(numList, callback));
//        }
//    }
//}