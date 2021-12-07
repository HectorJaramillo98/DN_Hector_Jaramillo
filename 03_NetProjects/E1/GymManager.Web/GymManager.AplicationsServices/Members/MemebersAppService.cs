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
        public List<Member> GetMembers()
        {
           List<Member> members = new List<Member>();

            members.Add(new Member
            {
                Name = "Israel",
                LastName = "Garcia",
                Birthday = new DateTime(1986,9,24),
                AllowNewsletter = true,
                CityId = 1,
                Email = "israprueba.com"
            });
            members.Add(new Member
            {
                Name = "Axel",
                LastName = "Garcia",
                Birthday = new DateTime(1999, 9, 22),
                AllowNewsletter = true,
                CityId = 1,
                Email = "axelprueba.com"
            });
            members.Add(new Member
            {
                Name = "Fernando",
                LastName = "Zapien",
                Birthday = new DateTime(1990, 2, 12),
                AllowNewsletter = true,
                CityId = 1,
                Email = "ferprueba.com"
            });
            members.Add(new Member
            {
                Name = "Dulce",
                LastName = "Villalobos",
                Birthday = new DateTime(1996, 9, 2),
                AllowNewsletter = true,
                CityId = 1,
                Email = "villaprueba.com"
            });
            members.Add(new Member
            {
                Name = "Carlos",
                LastName = "Lopez",
                Birthday = new DateTime(1999, 9, 22),
                AllowNewsletter = true,
                CityId = 1,
                Email = "carlosprueba.com"
            });

            members.Add(new Member
            {
                Name = "Israel",
                LastName = "Garcia",
                Birthday = new DateTime(1986, 9, 24),
                AllowNewsletter = true,
                CityId = 1,
                Email = "israprueba.com"
            });
            members.Add(new Member
            {
                Name = "Axel",
                LastName = "Garcia",
                Birthday = new DateTime(1999, 9, 22),
                AllowNewsletter = true,
                CityId = 1,
                Email = "axelprueba.com"
            });
            members.Add(new Member
            {
                Name = "Fernando",
                LastName = "Zapien",
                Birthday = new DateTime(1990, 2, 12),
                AllowNewsletter = true,
                CityId = 1,
                Email = "ferprueba.com"
            });
            members.Add(new Member
            {
                Name = "Dulce",
                LastName = "Villalobos",
                Birthday = new DateTime(1996, 9, 2),
                AllowNewsletter = true,
                CityId = 1,
                Email = "villaprueba.com"
            });
            members.Add(new Member
            {
                Name = "Carlos",
                LastName = "Lopez",
                Birthday = new DateTime(1999, 9, 22),
                AllowNewsletter = true,
                CityId = 1,
                Email = "carlosprueba.com"
            });


            return members;
        }
    }
}
