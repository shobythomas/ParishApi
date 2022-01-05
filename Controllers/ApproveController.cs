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
    public class ApproveController : ControllerBase
    {
        private IMemberData _memberData;
        private IFamilyMemberData _familyData;
        private IUserLoginData _userLoginData;

        public ApproveController(IMemberData memberData, IFamilyMemberData familyData, IUserLoginData userLoginData)
        {
            _memberData = memberData;
            _familyData = familyData;
            _userLoginData = userLoginData;
        }

        [HttpPost, ActionName("ApproveFamilyMember")]
        [Route("/api/ApproveFamilyMember")]
        public IActionResult ApproveFamilyMember(MemberFamilyUIModel model)
        {
            try
            {
                var familyDetail = new MemberFamilyDetail
                {
                    memberid = model.memberid,
                    memberfamilyid = Convert.ToInt32(model.memberfamilyid),
                    isapproved = true
                };
                //send mail code from here
                _familyData.UpdateStatus(familyDetail);
                return Ok();
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost, ActionName("ApproveMember")]
        [Route("/api/ApproveMember")]
        public IActionResult ApproveMember(MemberUIModel model)
        {
            try {

                var res = _memberData.GetMemberByCode(model.membercode);
                if (res != null)
                {
                    int memberId = res.memberid;
                    if (res.isactive == false)
                    {
                        var password = PasswordHelper.GeneratePassword(8);
                        var userLogin = new UserLogin
                        {
                            usercode = res.membercode,
                            username = res.membercode,
                            password = EnCrpyDeCrpt.KeyEncrypt(password, string.Empty),
                            usertype = 1
                        };
                        _userLoginData.EditUserLogin(userLogin);
                        var member = new Member
                        {
                            membercode = res.membercode,
                            isapproved = true,
                            isactive = true,
                            accoundcode = res.membercode,
                            subscriptionamount = StMarysConstant.SubscriptionFee
                        };
                        _memberData.EditMember(member);

                        PrepareMailContent(res.firstname, res.email, password);
                    }
                }
                    return Ok();
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        public void PrepareMailContent(string name, string email, string loginPassword)
        {
            var password = new MemberRegistrationPasswordModel
            {
                EmailID = email,
                Name = name,
                Password = loginPassword
            };
            SendRegisterPassword(password);
        }
        private void SendRegisterPassword(MemberRegistrationPasswordModel model)
        {
            var mailContent = EmailUtility.PrepareRegistrationPassword(model);
            EmailUtility.SendEmail(mailContent);
        }
    }
}
