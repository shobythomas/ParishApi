using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParishApi.Interface;
using ParishApi.Models.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParishApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private IMemberData _memberData;
        private IFamilyMemberData _familyData;

        public DashboardController(IMemberData memberData, IFamilyMemberData familyData)
        {
            _memberData = memberData;
            _familyData = familyData;
        }

        [HttpPost, ActionName("ListAllNewFamilyMembers")]
        [Route("/api/ListAllNewFamilyMembers")]
        public IActionResult ListAllNewFamilyMembers()
        {
            try
            {
                var res = _familyData.GetAllNewFamilyMembers();
                return Ok(res);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost, ActionName("ListAllNewMembers")]
        [Route("/api/ListAllNewMembers")]
        public IActionResult ListAllNewMembers()
        {
            try
            {
                var res = _memberData.GetAllNewMembers();
                return Ok(res);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
