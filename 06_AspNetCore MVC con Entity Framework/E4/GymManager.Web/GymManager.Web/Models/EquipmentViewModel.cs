using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.Web.Models
{
    public class EquipmentViewModel
    {       
        public int Id { get; set; }

        [StringLength(15)]
        [Required(ErrorMessage = "Debe ingresar el nombre")]
        public string Name { get; set; }

        [StringLength(200)]
        [Required]
        public string Description { get; set; }
    }
}
