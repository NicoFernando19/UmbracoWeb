using Umbraco.Web.WebApi;
using System.Web.Http;

namespace Umbraco.Controllers
{
    public class ApisController : UmbracoApiController
    {
        [HttpGet]
        public string MyApi()
        {
            return "This is how API works in Umbraco";
        }
    }
}