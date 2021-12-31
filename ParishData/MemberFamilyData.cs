using ParishApi.Entity;
using ParishApi.Interface;
using ParishApi.Models;
using ParishApi.Models.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParishApi.ParishData
{
    public class MemberFamilyData : IFamilyMemberData
    {
        private ParishContext _parishContext;

        public MemberFamilyData(ParishContext parishContext)
        {
            _parishContext = parishContext;
        }

        public MemberFamilyDetail AddFamilyMember(MemberFamilyDetail model)
        {
            _parishContext.MemberFamilyDetail.Add(model);
            _parishContext.SaveChanges();
            return model;
        }

        public string DeleteFamilyMember(int familyMemberId)
        {
            string msg = string.Empty;
            var existingMember = _parishContext.MemberFamilyDetail.Find(familyMemberId);
            if (existingMember != null)
            {
                    _parishContext.MemberFamilyDetail.Remove(existingMember);
                    _parishContext.SaveChanges();
                    msg = "Deleted Successfully";
                    return msg;
            }
            else
            {
                msg = "No such family member exist!";
                return msg;
            }
        }

        public MemberFamilyDetail EditFamilyMember(MemberFamilyDetail model)
        {
            var existingMember = _parishContext.MemberFamilyDetail.Find(model.memberfamilyid);
            if (existingMember != null)
            {
                _parishContext.MemberFamilyDetail.Update(model);
                _parishContext.SaveChanges();
            }
            return model;
        }

        public MemberFamilyDetail FetchSingleFamilyMember(int familyMemberID) => _parishContext.MemberFamilyDetail.Find(familyMemberID);

        public List<MemberFamilyDetail> GetAllMemberFamilyMembers(int memberId) => _parishContext.MemberFamilyDetail.Where(p=>p.memberid==memberId).ToList();

        public List<MemberFamilyUIModel> GetAllNewFamilyMembers()
        {

            return (from m in _parishContext.Member
                    join f in _parishContext.MemberFamilyDetail on m.memberid equals f.memberid
                    into sls
                    from details in sls.DefaultIfEmpty()
                    select new MemberFamilyUIModel()
                    {
                        membername = m.firstname,
                        memberfamilyid = details.memberfamilyid,
                        relname = details.relname
                    }).ToList();
        }
    }
}
