

//namespace ConsoleApp1;

//internal class DelegateExample
//{
//    //public delegate Task SomeFunction(int response, Exception error);
//    public async Task<string> GetTotalFunction(int[] numList, Func<int, Task> callback)
//    {

//      return await Task.Run(async () =>
//       {
//           await Task.Delay(3000);
//           await callback(numList.Sum());

//           return "Success";
//       });
//    }


//}
