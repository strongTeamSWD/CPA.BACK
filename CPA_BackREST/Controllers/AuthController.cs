using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CPA_BackREST.Models;
using CPA_BackREST.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CPA_BackREST.Controllers
{
      public class AuthParam{
        public string login { get; set; }
        public string password { get; set; }
    }
    
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        public UserService userService;

        public AuthController(UserService userService) {
            this.userService = userService;
        }

        // POST: api/Auth
            [HttpPost("login")]
        public Users AuthUser([FromBody] AuthParam param)
        {
            if(param!=null)
            return userService.GetUserByLoginPass(param.login, param.password);

            return null;
        }

        // POST: api/Auth
        [HttpPost("register")]
        public long RegisterUser([FromBody] Users newUser)
        {
            return userService.RegisterUser(newUser);
        }

        [HttpPost("update")]
        public bool UpdateUser([FromBody] Users user) {
            return userService.UpdateUser(user);
        }

        [HttpPost("delete")]
        public bool DeleteUser([FromBody] Users user)
        {
            return userService.UpdateUser(user);
        }
    }
}
