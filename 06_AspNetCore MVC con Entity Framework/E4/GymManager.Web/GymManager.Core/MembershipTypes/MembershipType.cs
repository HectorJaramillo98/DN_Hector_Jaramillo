using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.MembershipTypes
{
    public class MembershipType
    {
            public int Id { get; set; }

            [StringLength(100)]
            [Required]
            public string Name { get; set; }

            [DataType(DataType.Currency)]
            [Required]
            public double Cost { get; set; }

            public DateTime CreatedOn { get; } = DateTime.Now;

        [Range(0, int.MaxValue, ErrorMessage = "Enter a valid Duration")]
        public int Duration { get; set; }

        public List<Member> Members { get; set; }

        public MembershipType()
        {
            Members = new List<Member>();
        }
    }
}
