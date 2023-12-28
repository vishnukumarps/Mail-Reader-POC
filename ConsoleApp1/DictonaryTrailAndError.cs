using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DictonaryTrailAndError
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> claims = new Dictionary<string, object>()
            {
                {"role_id", 1 },
                {"root_org_node_ids",new List<int>{ 322,300 } },
            };


            object? rootOrgIdObj = claims.FirstOrDefault(x => x.Key == "root_org_node_ids").Value;

            if (rootOrgIdObj != null)
            {
                var convertedIds = (List<int>)rootOrgIdObj;

                foreach (var convertedId in convertedIds)
                {
                    Console.WriteLine(convertedId);
                }
            }

            Console.ReadKey();
        }
    }
}
