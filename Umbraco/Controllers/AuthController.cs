using Umbraco.Web.Mvc;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Models;

namespace Umbraco.Controllers
{
    public class AuthController : SurfaceController
    {
        [HttpGet]
        public ActionResult LoginForm()
        {
            LoginFormModel loginFormModel = new LoginFormModel() { LoginFormId = CurrentPage.Id };
            return PartialView("~/Views/Partials/LoginForm.cshtml", loginFormModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginPost(LoginFormModel loginFormModel)
        {
            return RedirectToCurrentUmbracoPage();
        }
    }
}