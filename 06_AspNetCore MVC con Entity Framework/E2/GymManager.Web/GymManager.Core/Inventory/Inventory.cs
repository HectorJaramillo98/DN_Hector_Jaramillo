using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Inventory
{
    public class Inventory
    {

        [Key]
        public int Id { get; set; }

        [StringLength(150)]
        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Cost { get; set; }
        
        [Required]
        [BindProperty, DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime UpdateInventory { get; set; }

        [Required]
        public int Stock  { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public MeasureType Measure { get; set; }

        [Required]
        public ProductType ProductType { get; set; }


    }
}
