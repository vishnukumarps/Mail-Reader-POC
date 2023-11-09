

Test();

void Test()
{
    IDictionary<int, Action> _operationHandler = new Dictionary<int, Action>()
            {
                {1,Sum },
                {2, Product },
                {3, Quotient },
                {4, Subtract },
            };

    Console.WriteLine("Enter a number");
    int n=Convert.ToInt32(Console.ReadLine());

    if (_operationHandler.ContainsKey(n))
    {
        _operationHandler[n].Invoke();
    }
}
 void Sum()
{
    Console.WriteLine("Sum");
}
void Product()
{
    Console.WriteLine("Product");
}
 void Quotient()
{
    //quotient
    Console.WriteLine("Quotient");
}

 void Subtract()
{
    Console.WriteLine("Subtract");
}


