using Umbraco.Web.Mvc;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Models;

namespace Umbraco.Controllers
{
    public class LoginController : RenderMvcController
    {
        // this is how controller works for login
        public ActionResult Index(ContentModel model, string test)
        {
            var loginModel = new Umbraco.Models.LoginModel(model.Content); 
            return CurrentTemplate(loginModel);
        }
    }
}