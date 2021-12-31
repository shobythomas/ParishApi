using ParishApi.Models;
using ParishApi.Models.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParishApi.Interface
{
    public interface IFamilyMemberData
    {
        MemberFamilyDetail AddFamilyMember(MemberFamilyDetail model);

        MemberFamilyDetail EditFamilyMember(MemberFamilyDetail model);

        string DeleteFamilyMember(int familyMemberId);

        List<MemberFamilyDetail> GetAllMemberFamilyMembers(int memberId);

        MemberFamilyDetail FetchSingleFamilyMember(int familyMemberID);

        List<MemberFamilyUIModel> GetAllNewFamilyMembers();
    }
}
