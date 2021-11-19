using ParishApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParishApi.Interface
{
    public interface IMemberData
    {
        Member AddMember(Member model);

        Member EditMember(Member model);

        string DeleteMember(int memberId);

        List<Member> GetAllMmebers();

        Member GetSingleMember(int memberId);
    }
}
