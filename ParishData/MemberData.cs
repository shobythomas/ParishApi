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
        Member IMemberData.AddMember(Member model)
        {
            throw new NotImplementedException();
        }

        Member IMemberData.DeleteMember(int memberId)
        {
            throw new NotImplementedException();
        }

        Member IMemberData.EditMember(Member model)
        {
            throw new NotImplementedException();
        }

        List<Member> IMemberData.GetAllMmebers() => _parishContext.Member.ToList();

        Member IMemberData.GetSingleMember(int memberId) => _parishContext.Member.Find(memberId);
    }
}
