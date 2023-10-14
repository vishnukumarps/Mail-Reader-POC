using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubMock
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class CustomAttribute : Attribute, IAuthorizationFilter
    {
        private readonly IList<string> _roleList;
        public CustomAttribute(params string[] roleList)
        {
            _roleList = roleList;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            foreach (var role in _roleList)
            {
                Console.WriteLine( role);
            }

   
        }
    }
}

