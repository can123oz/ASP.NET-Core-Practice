using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace zeroToHeroMVC.Models.ModelMetadataTypes
{
    public class ProductMetadata 
    {

        [Required(ErrorMessage = "Lutfen product name`i giriniz.")]
        [StringLength(10, ErrorMessage = "Lutfen product name`i en fazla 100 karakter giriniz.")]
        public string ProductName { get; set; }

        [EmailAddress(ErrorMessage = "Lutfen dogru bir email adresi giriniz.")]
        public string Email { get; set; }

    }
}
