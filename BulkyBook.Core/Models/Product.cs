using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Core.Models
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        [Required]
        [Range(1, 10000)]
        [Display(Name = "List Price")]
        public Decimal ListPrice { get; set; }
        [Required]
        [Range(1, 10000)]
        [Display(Name = "Priice for 1-50")]
        public Decimal Price { get; set; }
        [Required]
        [Range(1, 10000)]
        [Display(Name = "Proce between 50-100")]
        public Decimal Price50 { get; set; }
        [Required]
        [Range(1, 10000)]
        [Display(Name = "Price for 100+")]
        public Decimal Price100 { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [ValidateNever]
        public Category Category { get; set; }
        [Display(Name = "Cover Type")]
        public int CoverTypeId { get; set; }
        [ValidateNever]
        public CoverType CoverType { get; set; }

    }
}
