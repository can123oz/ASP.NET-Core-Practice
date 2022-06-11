using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using zeroToHeroMVC.Models.ModelMetadataTypes;

namespace zeroToHeroMVC.Models
{
    [ModelMetadataType(typeof(ProductMetadata))]
    public class Product
    {
       
        public int Id { get; set; }

        public string ProductName { get; set; }
        public int Quantity { get; set; }

        public string Email { get; set; }
    }
}
