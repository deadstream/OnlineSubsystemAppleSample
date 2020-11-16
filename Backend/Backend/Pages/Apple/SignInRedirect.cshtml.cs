using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Backend.Pages.Apple
{
    public class SignInRedirectModel : PageModel
    {
        Data.Users Users;
        public SignInRedirectModel(Data.Users users)
        {
            this.Users = users;
        }
        //public void OnGet()
        //{
        //    string query = HttpContext.Request.QueryString.Value;
        //    Users.Tokens.TryAdd("", ("", DateTime.UtcNow.AddMinutes(5)));
            
        //}

        public class Body
        {
            public string code { get; set; } = string.Empty;
            public string id_token { get; set; } = string.Empty;
            public string state { get; set; } = string.Empty;
            public string user { get; set; } = string.Empty;
            public string error { get; set; } = string.Empty;
        }

        public void OnPost()
        {

        }
    }
}
