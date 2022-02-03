﻿using GymManager.Core.Members;
using GymManager.Core.MembershipTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.Web.Models
{
    public class RenewalViewModel
    {
        public int IdMembershipType { get; set; }
        public int IdMember { get; set; }

        public Member Member { get; set; }
        public List<MembershipType> MembershipTypes { get; set; }
        
    }
}
