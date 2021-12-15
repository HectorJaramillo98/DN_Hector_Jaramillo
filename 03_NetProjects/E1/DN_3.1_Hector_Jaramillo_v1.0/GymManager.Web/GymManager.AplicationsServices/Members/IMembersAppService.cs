using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationsServices.Members
{
    public interface IMembersAppService
    {
        List<Member> GetMembers();

        int AddMembers(Member member);

        void EditMember(Member member);

        void DeleteMembers(int memberId);

        Member GetMember(int memberId);
    }
}
