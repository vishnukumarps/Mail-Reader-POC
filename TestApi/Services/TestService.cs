namespace TestApi.Services;

public class TestService
{

    public int GetMeARandomNumber()
    {
        return new Random().Next(100, 2000);
    }
}
