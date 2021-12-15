using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationsServices.Members
{
    public class MemebersAppService : IMembersAppService
    {
        private static List<Member> Members = new List<Member>();


        public int AddMembers(Member member)
        {
          member.Id = new Random().Next();  
            Members.Add(member);

            return member.Id;
        }

        public void DeleteMembers(int memberId)
        {
            var m = Members.Where(x=> x.Id == memberId).FirstOrDefault();
            Members.Remove(m);
        }

        public void EditMember(Member member)
        {
            var m = Members.Where(x => x.Id == member.Id).FirstOrDefault();
            m.AllowNewsletter = member.AllowNewsletter;
            m.Birthday = member.Birthday;
            m.CityId = member.CityId;
            m.Email = member.Email;
            m.LastName = member.LastName;
            m.Name = member.Name;
        }

        public Member GetMember(int memberId)
        {
            var m = Members.Where(x => x.Id == memberId).FirstOrDefault();
            return m;
        }

        public List<Member> GetMembers()
        {
          
            return Members;
        }
    }
}
