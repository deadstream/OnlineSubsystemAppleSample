using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;


namespace Backend.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppleController : ControllerBase
    {
        Data.Users Users;
        public AppleController(Data.Users users)
        {
            this.Users = users;
        }

        [Route("Check")]
        [HttpGet]
        public string GetCheck(string State)
        {
            Data.Users.Body body = null;

            if (string.IsNullOrEmpty(State))
            {
                body = new Data.Users.Body();
                body.error = "Not Found";
                return JsonConvert.SerializeObject(body);
            }
            if (Users.Tokens.TryRemove(State, out var keypair) == true)
            {
                body = keypair.Item1;
            }
            
            if (body == null)
            {
                body = new Data.Users.Body();
                body.error = "Not Found";
            }

            return JsonConvert.SerializeObject(body);
        }
   

        [Route("Redirect")]
        [HttpPost]
        public string PostRedirect([FromForm]Data.Users.Body body)
        {
            var handler = new JwtSecurityTokenHandler();
            var token = handler.ReadToken(body.id_token) as JwtSecurityToken;
            body.user = token.Subject;
            Users.Tokens.TryRemove(body.state, out var old);
            Users.Tokens.TryAdd(body.state, (body, DateTime.UtcNow));
            return "SignIn Success. Please return to the app.";
        }
    }
}
