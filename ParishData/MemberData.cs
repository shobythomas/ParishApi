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
            _parishContext.Member.Add(model);
            _parishContext.SaveChanges();
            return model;
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
        public Member GetSingleMember(int memberId) => _parishContext.Member.Find(memberId);
    }
}
