using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace Umbraco.Models
{
    public class LoginModel : ContentModel
    {
        public LoginModel(IPublishedContent content) : base(content)
        {

        }

        public string Title { get; set; } = "Login";
    }
}