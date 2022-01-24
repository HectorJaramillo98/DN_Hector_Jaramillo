using GymManager.Core.Members;
using System;using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GymManager.AplicationsServices.Members
{
    public interface IMembersAppService
    {
        Task<List<Member>> GetMembersAsync();

        Task<int> AddMembersAsync(Member member);

        Task EditMemberAsync(Member member);

        Task DeleteMembersAsync(int memberId);

        Task<Member> GetMemberAsync(int memberId);
    }
}
