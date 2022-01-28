using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Exercise.Entities
{
    public class Member
    {
        public  int Id { get; set; }

        public string Name { get; set; }

        public DateTime RegisteredOn { get; set; }

        public string Membershiptype { get; set; }
    }
}
