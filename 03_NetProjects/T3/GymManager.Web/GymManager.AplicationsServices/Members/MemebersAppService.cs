﻿using GymManager.Core.Members;
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

        public List<Member> GetMembers()
        {
          
            return Members;
        }
    }
}
