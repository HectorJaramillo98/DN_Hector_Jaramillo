using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.Web.Models
{
    public class MembershipTypeViewModel
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Debe ingresar el nombre")]
        public string Name { get; set; }

        
        [Required]
        public int Duration { get; set; }

        [Required]
        public decimal Cost { get; set; }
    }
}
