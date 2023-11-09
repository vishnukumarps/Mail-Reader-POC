using System.IO;

namespace Work1.Helpers;

public class Calc:IDisposable
{
    private FileStream fileStream;
    public Calc(string fileName)
    {
        // Open a fictitious file for writing
        fileStream = new FileStream(fileName, FileMode.Create);
    }

    public Calc()
    {
            
    }
    public void Add(int a, int b, out int ans)
    {
        ans = a + b;
    }
   
    public void AddTwo(int a, int b, ref int ans)
    {
        ans = a + b;
    }
    public List<T3> ListAMinusListB<T1,T2,T3>(List<T1> list1,List<T2> lsit2)  where T1 :class where T2 :class where T3 :class
    {


        return null;
    }

    public void Dispose()
    {
        if (fileStream != null)
        {
            fileStream.Close();
            fileStream.Dispose();
        }
    }
}
