using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParishApi.Interface;
using ParishApi.Models.UIModels;
using ParishApi.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParishApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUserLoginData _userLogin;

        public LoginController(IUserLoginData userLogin)
        {
            _userLogin = userLogin;
        }

        [HttpPost, ActionName("Login")]
        [Route("/api/Login")]
        public IActionResult Login(LoginUIModel model)
        {
            try
            {
                model.password= EnCrpyDeCrpt.KeyEncrypt(model.password, string.Empty);
                var res = _userLogin.FetchUserWithNameAndPwd(model.username, model.password);
                if (res != null)
                {
                    res.lastloggedin = DateTime.Now;
                    _userLogin.UpdateLastLogin(res);
                    model.password= EnCrpyDeCrpt.KeyDecrypt(res.password, string.Empty);
                    model.isAdmin = res.usertype == 2? true : false;
                    model.Status = true;
                    model.MSG = "Login success!";
                }
                else
                {
                    model.Status = false;
                    model.MSG = "Username or Password is wrong, Please try again!!!";
                }
                return Ok(model);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }



    }
}
