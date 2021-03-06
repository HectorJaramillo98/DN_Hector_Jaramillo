using GymManager.Core.Members;
using GymManager.Core.MembershipTypes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GymManager.Web.Models
{
    public class MemberViewModel
    {
       
        public List<MembershipType> membershipList = new List<MembershipType>();

        public List<City> Cities { get; set; }
        public int Id { get; set; }

        [StringLength(15)]
        [Required(ErrorMessage = "Debe ingresar el nombre")]
        public string Name { get; set; }

        [StringLength(20)]
        [Required]
        public string LastName { get; set; }

        [BindProperty, DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        public bool AllowNewsletter { get; set; }

        [Required]
        public int CityId { get; set; }

        [BindProperty, DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedOn { get; set; }

        [BindProperty, DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime LastUpdate { get; set; }



    }
}
