using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Graph.Models;
using POC.Helper;

namespace POC.Controllers
{
    public class TestController : Controller
    {
        GraphHelper graphHelper;
        public TestController(GraphHelper graphHelper)
        {
            this.graphHelper = graphHelper;

            this.graphHelper.InitializeGraph();
            var x=this.graphHelper.Messge;
        }

        public async Task<IActionResult> Index()
        {

            var User= await this.graphHelper.GetUserAsync();

            var x = this.graphHelper.Messge;
            int k = 0;
            return View();
        }
    }
}
