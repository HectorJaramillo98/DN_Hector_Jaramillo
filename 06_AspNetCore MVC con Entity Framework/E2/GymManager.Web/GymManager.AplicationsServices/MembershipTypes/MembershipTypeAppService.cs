using System;
using GymManager.Core.MembershipTypes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationsServices.MembershipTypes
{
    public class MembershipTypeAppService : IMembershipTypeAppService
    {
        private static List<MembershipType> MembershipTypes = new List<MembershipType>();
        public int AddMembershipTypes(MembershipType membershipType)
        {
            membershipType.Id = new Random().Next();

            MembershipTypes.Add(membershipType);

            return membershipType.Id;
        }

        public void DeleteMembershipTypes(int membershipTypesId)
        {
            var m = MembershipTypes.Where(x => x.Id == membershipTypesId).FirstOrDefault();

            MembershipTypes.Remove(m);
        }

        public void EditMembershipTypes(MembershipType membershipType)
        {
            var m = MembershipTypes.Where(x => x.Id == membershipType.Id).FirstOrDefault();
            m.Name = membershipType.Name;
            m.Cost = membershipType.Cost;
            m.Duration = membershipType.Duration;
        }

        public MembershipType GetMembershipType(int membershipTypeId)
        {
            var m = MembershipTypes.Where(x => x.Id == membershipTypeId).FirstOrDefault();

            return m;
        }

        public List<MembershipType> GetMembershipTypes()
        {
            return MembershipTypes;
        }
    }
}
