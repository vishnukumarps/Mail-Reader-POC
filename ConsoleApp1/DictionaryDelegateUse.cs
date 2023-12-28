

//Test();

//void Test()
//{
//    IDictionary<int, Action> _operationHandler = new Dictionary<int, Action>()
//            {
//                {1,Sum },
//                {2, Product },
//                {3, Quotient },
//                {4, Subtract },
//            };

//    var _operationHandler2 = new Dictionary<int,Func<int,int,Task<int>>>()
//            {
//               {22,async(a,b)=>await HandleCreateOrganizationRequest(1,2)}
//            };
//    Console.WriteLine("Enter a number");
//    int n = Convert.ToInt32(Console.ReadLine());

//    if (_operationHandler.ContainsKey(n))
//    {
//        _operationHandler[n].Invoke();
//    }
//}
//void Sum()
//{
//    Console.WriteLine("Sum");
//}
//void Product()
//{
//    Console.WriteLine("Product");
//}
//void Quotient()
//{
//    //quotient
//    Console.WriteLine("Quotient");
//}

//void Subtract()
//{
//    Console.WriteLine("Subtract");
//}


//async Task<int> HandleCreateOrganizationRequest(int a, int b)
//{

//    return await Task.FromResult(1);
//}