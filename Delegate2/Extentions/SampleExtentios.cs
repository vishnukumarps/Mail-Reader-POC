using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2.Extentions
{
    public static class SampleExtentios
    {
        // list.find(x=>x.Name==""vishnu)

        public static IEnumerable<TSource> CustomFilter<TSource>(this IEnumerable<TSource> sources,Func<TSource,bool> predicate) where TSource : class
        {
            List<TSource> list = new List<TSource>();

            foreach (TSource source in sources)
            {
                if (predicate(source))
                {
                    list.Add(source);
                }
            }

            return list.Count > 0 ? list : new List<TSource>();
        }
    }
}
