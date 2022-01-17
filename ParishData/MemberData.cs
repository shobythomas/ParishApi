using ParishApi.Entity;
using ParishApi.Interface;
using ParishApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParishApi.ParishData
{
    public class MemberData : IMemberData
    {
        private ParishContext _parishContext;

        public MemberData(ParishContext parishContext)
        {
            _parishContext = parishContext;
        }

        public Member AddMember(Member model)
        {
            try
            {
                _parishContext.Member.Add(model);
                _parishContext.SaveChanges();
                return model;
            }
            catch(Exception ex)
            {
                return null;
            }
           
        }

        public string DeleteMember(int memberId)
        {
            string msg = string.Empty;
            var existingMember = _parishContext.Member.Find(memberId);
            var ifFamilyMembersExist = _parishContext.MemberFamilyDetail.Find(memberId);
            if (existingMember != null)
            {
                if (ifFamilyMembersExist == null)
                {
                    _parishContext.Member.Remove(existingMember);
                    _parishContext.SaveChanges();
                    msg = "Deleted Successfully";
                    return msg;
                }
                else
                {
                    msg = "Familymembers exist!";
                    return msg;
                }
            }
            else
            {
                msg = "No such member exist!";
                return msg;
            }
        }

        public Member EditMember(Member model)
        {
            var existingMember = _parishContext.Member.Find(model.memberid);
            if (existingMember != null)
            {
                _parishContext.Member.Update(model);
                _parishContext.SaveChanges();
            }
            return model;
        }

        public List<Member> GetAllMmebers() => _parishContext.Member.ToList();

        public List<Member> GetAllNewMembers() => _parishContext.Member.Where(p => p.joiningdate >= DateTime.Now.Date.AddDays(-30)).ToList();

        public List<Member> GetAllPendingMembers()
        {
            return _parishContext.Member.Where(p => p.isapproved == false).ToList();
        }

        public Member GetMemberByCode(string memberCode) => _parishContext.Member.Find(memberCode);

        public Member GetSingleMember(int memberId) => _parishContext.Member.Find(memberId);

        public bool ValidateUserName(string userName)
        {
            var res = _parishContext.UserLogin.Where(p => p.username == userName).ToList();
            bool status = res.Count != 0 ? true : false;
            return status;
        }
    }
}
