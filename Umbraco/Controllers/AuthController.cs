using Umbraco.Web.Mvc;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Models;
using Umbraco.Databases.Entities;
using NPoco;
using System.Collections.Generic;

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
            var employee = new Department() {
                Name = "IT 2",
                Description= "This is It Department 2"
            };

            IDatabase db = new Database("umbracoDbDSN");
            //Department employee = db.SingleById<Department>(1); // get by id
            //db.Update(employee); //update
            //db.Delete(employee); //delete
            //db.Insert(employee); // insert
            //List<Department> users = db.Fetch<Department>("select * from Department"); //get

            return RedirectToCurrentUmbracoPage();
        }
    }
}