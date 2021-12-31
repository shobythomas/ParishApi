using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParishApi.Helper;
using ParishApi.Interface;
using ParishApi.Models;
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
    public class MemberController : ControllerBase
    {
        private IMemberData _memberData;

        private IUserLoginData _userData;

        public MemberController(IMemberData memberData, IUserLoginData userData)
        {
            _memberData = memberData;
            _userData = userData;
        }
        
        [HttpPost, ActionName("ValidateUserName")]
        [Route("/api/ValidateUserName")]
        public IActionResult ValidateUserName(LoginUIModel model)
        {
            OutputMsgUIModel _outPut = new OutputMsgUIModel();
            try
            {
                var res = _memberData.ValidateUserName(model.username);
                _outPut.MSG = res == true ? "Username exist, Please choose another one" : "";
                _outPut.Status = res;
                return Ok(_outPut);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost, ActionName("RegisterMember")]
        [Route("/api/RegisterMember")]
        public IActionResult RegisterMember(MemberUIModel model)
        {
            OutputMsgUIModel _outPut = new OutputMsgUIModel();
            try
            {
                Member member = new Member();
                member.isactive = false;
                member.isapproved = false;
                member.mobileno = string.Empty;
                member.gender = model.gender==null?string.Empty:model.gender;
                member.isemailnotification = false;
                member.issmsnotification = false;
                member.notes = string.Empty;
                member.presentaddress = string.Empty;
                member.bloodgroup = model.bloodgroup==null?string.Empty:model.bloodgroup;
                member.joiningdate = DateTime.Now;
                member.middlename = model.middlename == null ? string.Empty : model.middlename;
                member.lastname = model.lastname == null ? string.Empty : model.lastname;
                member.firstname = model.firstname;
                member.membercode = model.username;
                member.email = model.email;
                member.accoundcode = model.username;
                member.city = string.Empty;
                member.country = string.Empty;
                member.street = string.Empty;
                member.pincode = string.Empty;
                member.subscriptionamount = 0;
                member.profileimage = string.Empty;
                member.homeparish = string.Empty;
                member.homephone = string.Empty;
                member.workphone = string.Empty;
                member.occupation = string.Empty;
                member.qualification = string.Empty;
                member.state = string.Empty;
                var res = _memberData.AddMember(member);
                var password = PasswordHelper.GeneratePassword(8);
                UserLogin userLogin = new UserLogin();
                userLogin.password = EnCrpyDeCrpt.KeyEncrypt(password, string.Empty);
                userLogin.usercode = model.username;
                userLogin.username = model.username;
                userLogin.usertype = 1;
                var result = _userData.AddUserLogin(userLogin);
                _outPut.Status = true;
                _outPut.MSG = "Registration Successfully Completed!";
                return Ok(_outPut);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        

    }
}
