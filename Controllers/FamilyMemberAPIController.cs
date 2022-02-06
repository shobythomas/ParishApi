﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParishApi.Interface;
using ParishApi.Models;
using ParishApi.Models.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParishApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamilyMemberAPIController : ControllerBase
    {
        private IFamilyMemberData _familyMemberData;
        private readonly IMapper mapper;

        public FamilyMemberAPIController(IFamilyMemberData familymemberData, IMapper mapper)
        {
            _familyMemberData = familymemberData;
            this.mapper = mapper;

        }

        [HttpPost, ActionName("GetMemberAllFamilyDetails")]
        [Route("/api/GetMemberAllFamilyDetails")]
        public IActionResult GetMemberAllFamilyDetails(MemberFamily model)
        {
            try
            {
                var res = _familyMemberData.GetAllMemberFamilyMembers(model.memberid);
                return Ok(res);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost, ActionName("EditFamilyMember")]
        [Route("/api/EditFamilyMember")]
        public IActionResult EditFamilyMember(MemberFamily model)
        {
            OutputMsgUIModel _outPut = new OutputMsgUIModel();
            try
            {
                MemberFamilyDetail familyMember = mapper.Map<MemberFamilyDetail>(model);
                _familyMemberData.EditFamilyMemberAync(familyMember);
                _outPut.Status = true;
                _outPut.MSG = "Updated sucessfully!";
                return Ok(_outPut);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost, ActionName("CreateFamilyMmember")]
        [Route("/api/CreateFamilyMember")]
        public IActionResult CreateFamilyMember(MemberFamily model)
        {
            OutputMsgUIModel _outPut = new OutputMsgUIModel();
            try
            {
                MemberFamilyDetail familyMember = mapper.Map<MemberFamilyDetail>(model);
                _familyMemberData.AddFamilyMember(familyMember);
                _outPut.Status = true;
                _outPut.MSG = "Created Successfully!";
                return Ok(_outPut);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
