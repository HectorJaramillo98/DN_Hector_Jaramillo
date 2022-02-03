using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Members
{
    public class Check
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        public string Type { get; set; }

        public Member Member { get; set; }

        [BindProperty, DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Checkday { get; set; } 
    }
}
