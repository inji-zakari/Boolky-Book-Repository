using System;
using System.Collections.Generic;
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
        public Decimal ListPrice { get; set; }
        [Required]
        [Range(1, 10000)]
        public Decimal Price { get; set; }
        [Required]
        [Range(1, 10000)]
        public Decimal Price50 { get; set; }
        [Required]
        [Range(1, 10000)]
        public Decimal Price100 { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int CoverTypeId { get; set; }
        public CoverType CoverType { get; set; }

    }
}
