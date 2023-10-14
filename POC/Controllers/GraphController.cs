using Azure.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using POC.Helper;
using System.Runtime;

namespace POC.Controllers
{
    public class TestController : Controller
    {
        GraphHelper graphHelper;
        private readonly ConfigSettings _settings;
        private DeviceCodeCredential? _deviceCodeCredential;

        private GraphServiceClient? _userClient;
        public TestController(GraphHelper graphHelper, IOptions<ConfigSettings> configSettingssAccessor)
        {
            this._settings = configSettingssAccessor.Value;

            this.graphHelper = graphHelper;

            this.graphHelper.InitializeGraph();
            var x=this.graphHelper.Messge;
        }

        public ActionResult Authenticate()
        {
            _deviceCodeCredential = new DeviceCodeCredential((info, cancel) =>
            {
                ViewBag.info = info.Message;
                ViewBag.url = info.VerificationUri;
                return Task.FromResult(info);
            },
                _settings.TenantId, _settings.ClientId);


            _userClient = new GraphServiceClient(_deviceCodeCredential, _settings.GraphUserScopes);



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
