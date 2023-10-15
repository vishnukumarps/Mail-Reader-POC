using System.Collections.Generic;

namespace DelegateLearning.Extensions;

public static class SampleExtention
{
    public static IEnumerable<TSource> CustomFilter<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate) where TSource : class 
    {

        List<TSource> list = new List<TSource>();

        foreach (TSource item in source)
        {
            if (predicate(item))
            {
                list.Add(item); 
            }
        }
        return list.Count >0 ? list: new List<TSource>();
    }
   
}
