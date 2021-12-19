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
        List<MembershipType> GetMembershipTypes();

        int AddMembershipTypes(MembershipType membershipTypes);

        void DeleteMembershipTypes(int membershipTypesId);

        void EditMembershipTypes(MembershipType membershipType);
        MembershipType GetMembershipType(int membershipTypeId);
    }
}
