using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace zeroToHeroMVC.Models.ModelMetadataTypes
{
    public class ProductMetadata 
    {

        [Required(ErrorMessage = "Please enter a Product name.")]
        [StringLength(50, ErrorMessage = "Please dont enter more than 50 characters.")]
        public string ProductName { get; set; }

        [EmailAddress(ErrorMessage = "Enter a valid email.")]
        public string Email { get; set; }

    }
}
