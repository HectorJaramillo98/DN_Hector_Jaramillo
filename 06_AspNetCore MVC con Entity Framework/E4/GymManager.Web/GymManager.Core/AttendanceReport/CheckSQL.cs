using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.AttendanceReport
{
    public class CheckSQL
    {
        public int Id { get; set; }
        public string MemberName { get; set; }
        public string MemberLastName { get; set; }

        public int Checks { get; set; }
    }
}
