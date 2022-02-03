using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManager.Core.MembershipTypes;

namespace GymManager.AplicationsServices.MembershipTypes
{
    public interface IMembershipTypeAppService
    {
        Task<List<MembershipType>> GetMembershipTypesAsync();

        Task<int> AddMembershipTypesAsync(MembershipType membershipTypes);

        Task DeleteMembershipTypesAsync(int membershipTypesId);

        Task EditMembershipTypesAsync(MembershipType membershipType);
        Task<MembershipType> GetMembershipTypeAsync(int membershipTypeId);
    }
}
